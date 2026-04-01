Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Module Program
    Sub Main(args As String())
        Console.OutputEncoding = Encoding.UTF8
        Try
            Dim filePath As String = Path.Combine("..", "bin", "Debug", "license_cache.dat")
            If Not File.Exists(filePath) Then
                Console.WriteLine("File not found: " & Path.GetFullPath(filePath))
                Return
            End If

            Dim encryptedContent As String = File.ReadAllText(filePath, Encoding.UTF8)

            Dim jsonContent As String = Decrypt(encryptedContent)
            If String.IsNullOrEmpty(jsonContent) Then
                Console.WriteLine("Failed to decrypt content.")
                Return
            End If
            
            Console.WriteLine("========================================")
            Console.WriteLine("DATA DISPLAY")
            Console.WriteLine("========================================")
            Console.WriteLine("{0,-30} | {1}", "Field", "Value")
            Console.WriteLine(New String("-"c, 80))

            ' Simple JSON parsing regex
            Dim pattern As String = """([^""]+)""\s*:\s*""((?:[^""\\]|\\.)*)"""
            Dim matches As MatchCollection = Regex.Matches(jsonContent, pattern)

            For Each m As Match In matches
                Dim key As String = m.Groups(1).Value
                Dim value As String = m.Groups(2).Value
                
                ' Unescape
                value = value.Replace("\""", """").Replace("\\", "\")

                Dim displayValue As String = value
                If key <> "LastSaved" AndAlso value.Length > 10 Then
                     Dim innerDecrypted As String = Decrypt(value)
                     If Not String.IsNullOrEmpty(innerDecrypted) Then
                         displayValue = innerDecrypted
                     End If
                End If

                Console.WriteLine("{0,-30} | {1}", key, displayValue)
            Next
             Console.WriteLine(New String("-"c, 80))

        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Function Decrypt(ByVal DEncrtext As String) As String
        Try
            Dim txt() As Byte = Convert.FromBase64String(DEncrtext)
            Using md5 As MD5 = MD5.Create()
                Dim keymd5() As Byte = md5.ComputeHash(Encoding.UTF8.GetBytes("0"))
                Using trip As TripleDES = TripleDES.Create()
                    trip.Key = keymd5
                    trip.Mode = CipherMode.ECB
                    trip.Padding = PaddingMode.PKCS7
                    Dim trans As ICryptoTransform = trip.CreateDecryptor()
                    Dim result() As Byte = trans.TransformFinalBlock(txt, 0, txt.Length)
                    Return Encoding.UTF8.GetString(result)
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module
