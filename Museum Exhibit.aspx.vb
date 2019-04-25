
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim decBaseFee As Decimal               'Base tour fee
        Dim decTotalFee As Decimal              'Total tour fee
        Dim blnInputOk As Boolean = True
        Dim strLang As String                   'Displays the language the guides will use
        Dim strExhbt As String = ""

        'Constants for base fees
        Const decENGLISH As Decimal = 40D
        Const decGERMAN As Decimal = 25D
        Const decCHINESE As Decimal = 30D

        'Constants for additional fees
        Const decMESOPOTAMIA As Decimal = 10D
        Const decEUROPE As Decimal = 30D
        Const decAncEurope As Decimal = 50D
        Const decEastAsia As Decimal = 45.5D

        ' Grab the value of the selected language
        strLang = radioButtonList1.SelectedIndex

        ' Grab the exhibits
        'intExhbt = CheckBoxList1.SelectedIndex

        'Determine the base monthly fee and language that will be used
        Select Case (strLang)
            Case 0 : decBaseFee = decENGLISH
                strLang = "English"
            Case 1 : decBaseFee = decGERMAN
                strLang = "GERMAN"
            Case 2 : decBaseFee = decCHINESE
                strLang = "CHINESE"
            Case Else : strLang = "Choose a language"
        End Select

        'Check for additional services
        If CheckBoxList1.Items(0).Selected Then
                decBaseFee += decMESOPOTAMIA
            strExhbt = strExhbt & "Ancient Mesopotamia, "
        End If

        If CheckBoxList1.Items(1).Selected Then
            decBaseFee += decAncEurope
            strExhbt = strExhbt & "Ancient Europe, "
        End If

        If CheckBoxList1.Items(2).Selected Then
            decBaseFee += decEUROPE
            strExhbt = strExhbt & "Medieval Europe, "
        End If

        If CheckBoxList1.Items(3).Selected Then
            decBaseFee += decEastAsia
            strExhbt = strExhbt & "East Asia"
        End If

        'Calculate the total fee
        decTotalFee = decBaseFee

        'Display the language
        lblLanguage.Text = strLang

        'Display the exhibits
        lblExhibits.Text = strExhbt'("Exciting! On this tour you'll see: ") & 

        'Display the fees
        lblCost.Text = decTotalFee.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset the adult radio button
        radioButtonList1.SelectedIndex() = 0

        'Clear the check boxes
        CheckBoxList1.SelectedIndex = -1

        'Clear the fee labels
        lblCost.Text = String.Empty
        lblExhibits.Text = String.Empty
        lblLanguage.Text = String.Empty
    End Sub
End Class
