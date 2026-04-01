-- =============================================
-- Table: dbo.Auction_BarcodeConfig
-- Database: DtUpdate
-- =============================================

CREATE TABLE [dbo].[Auction_BarcodeConfig] (

    [size_id] int(10,0) NOT NULL,
    [L_IDTextBox_U] nvarchar(50),
    [L_IDTextBox_D] nvarchar(50),
    [L_FO_madeTextBox_U] nvarchar(50),
    [L_FO_madeTextBox_D] nvarchar(50),
    [L_font_IDTextBox_U] nvarchar(50),
    [L_font_IDTextBox_D] nvarchar(50),
    [L_ComboBox3_U] nvarchar(50),
    [L_ComboBox3_D] nvarchar(50),
    [L_FO_gramTextBox_U] nvarchar(50),
    [L_FO_gramTextBox_D] nvarchar(50),
    [L_الوزن_U] nvarchar(50),
    [L_الوزن_D] nvarchar(50),
    [L_المصنعيه_U] nvarchar(50),
    [L_المصنعيه_D] nvarchar(50),
    [L_FO_gramMadeTextBox_U] nvarchar(50),
    [L_FO_gramMadeTextBox_D] nvarchar(50),
    [L_Gram_valuTextBox_U] nvarchar(50),
    [L_Gram_valuTextBox_D] nvarchar(50),
    [L_العيار_U] nvarchar(50),
    [L_العيار_D] nvarchar(50),
    [L_FO_extrasTextBox_U] nvarchar(50),
    [L_FO_extrasTextBox_D] nvarchar(50),
    [L_فصوص_U] nvarchar(50),
    [L_فصوص_D] nvarchar(50),
    [R_IDTextBox_U] nvarchar(50),
    [R_IDTextBox_D] nvarchar(50),
    [R_FO_madeTextBox_U] nvarchar(50),
    [R_FO_madeTextBox_D] nvarchar(50),
    [R_font_IDTextBox_U] nvarchar(50),
    [R_font_IDTextBox_D] nvarchar(50),
    [R_ComboBox3_U] nvarchar(50),
    [R_ComboBox3_D] nvarchar(50),
    [R_FO_gramTextBox_U] nvarchar(50),
    [R_FO_gramTextBox_D] nvarchar(50),
    [R_الوزن_U] nvarchar(50),
    [R_الوزن_D] nvarchar(50),
    [R_المصنعيه_U] nvarchar(50),
    [R_المصنعيه_D] nvarchar(50),
    [R_FO_gramMadeTextBox_U] nvarchar(50),
    [R_FO_gramMadeTextBox_D] nvarchar(50),
    [R_Gram_valuTextBox_U] nvarchar(50),
    [R_Gram_valuTextBox_D] nvarchar(50),
    [R_العيار_U] nvarchar(50),
    [R_العيار_D] nvarchar(50),
    [R_FO_extrasTextBox_U] nvarchar(50),
    [R_FO_extrasTextBox_D] nvarchar(50),
    [R_فصوص_U] nvarchar(50),
    [R_فصوص_D] nvarchar(50),
    [سبايكu] nvarchar(50),
    [سبايكd] nvarchar(50),
    [ويبu] nvarchar(50),
    [ويبd] nvarchar(50),
    [باركود_ويبu] nvarchar(50),
    [باركود_ويبd] nvarchar(50),
    [tel_u] nvarchar(50),
    [tel_d] nvarchar(50),
    [print_set] nvarchar(50),
    [print] nvarchar(50)

);

ALTER TABLE [dbo].[Auction_BarcodeConfig]
ADD CONSTRAINT [PK_Auction_BarcodeConfig] PRIMARY KEY ([size_id]);

