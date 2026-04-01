Imports System.Windows.Forms.Design
Imports PACICardLibrary
Imports System.IO
Imports System.ServiceProcess
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text
Imports System.Security.Cryptography
Imports System.Text.Encoding
Imports Microsoft.Reporting.WinForms
Imports System.Net.Http
Imports System.Web
Imports Newtonsoft.Json.Linq
Imports System.Threading.Tasks
Imports System.Net.NetworkInformation

Public Class TestCooode
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim link As String = "https://pearl-kw.com/v2/api/rest/get-paci-details?token=2d8e14f3a91842cfae7b6b6d29b91d7a&civil_id=288021703384"
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = client.GetAsync(link).Result
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            Dim json = JObject.Parse(responseBody)
            Dim da = json("data")
            Dim da2 = da("civilid_details")
            Dim da3 = da2("MIDAuthSignResponse")
            Dim dafinal = da3("PersonalData")
            TextBox1.Text = dafinal("CivilID").ToString()
            TextBox2.Text = dafinal("FullNameAr").ToString()
            TextBox3.Text = dafinal("FullNameEn").ToString()
        End Using
    End Sub
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TextBox1.Text = ListBox1.SelectedItem(1)(ListBox1.SelectedValue).ToString
        'For i =  ListBox1.Items.Count

        'Next
    End Sub

    Private Sub TestCooode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmMain.Timer1.Stop()
        'CivilIDForm = New CivilID With {.Bounds = New Rectangle(2, 0, 995, 255)}
        'Controls.Add(CivilIDForm)
        'CardServiceStart()
        'paci = New PACMAN
        Dim link As String = "https://pearl-kw.com/v2/api/rest/get-paci-details?token=2d8e14f3a91842cfae7b6b6d29b91d7a&civil_id=288021703384"
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = client.GetAsync(link).Result
            response.EnsureSuccessStatusCode()
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            Dim json = JObject.Parse(responseBody)
            Dim da = json("data")
            Dim da2 = da("civilid_details")
            Dim da3 = da2("MIDAuthSignResponse")
            Dim dafinal = da3("PersonalData")
            TextBox1.Text = dafinal("CivilID").ToString()
            'TextBox2.Text = dafinal("FullNameAr").ToString()
            'TextBox3.Text = dafinal("FullNameEn").ToString()
        End Using
        'ReportViewer1.LocalReport.ReportPath = "D:\SourceCode\SourceCode20230210\DT_restrant\DT_restrant\Report\Untitled.rdl"
        'Dim DT As DataTable = GetRecordSet("select * from CastomerDETELS")
        'If DT.Rows.Count > 0 Then
        '    Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
        '    ReportViewer1.LocalReport.DataSources.Clear()
        '    ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
        '    ReportViewer1.RefreshReport()
        '    ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        'End If
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class