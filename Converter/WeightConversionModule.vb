Module WeightConversionModule

    ' Weight names constants in list boxes for easier updating and comparison
    Friend Const strCarat As String = "carat"
    Friend Const strGram As String = "gram (g)"
    Friend Const strKilogram As String = "kilogram"
    Friend Const strMegagram As String = "megagram"
    Friend Const strMilligram As String = "milligram"
    Friend Const strOunce As String = "ounce"
    Friend Const strPound As String = "pound"
    Friend Const strTon As String = "ton"

    ' Constants for carat conversion factors
    Private Const decCARATS_TO_GRAMS As Decimal = 0.2D
    Private Const decCARATS_TO_KILOGRAMS As Decimal = 0.0002D
    Private Const decCARATS_TO_MEGAGRAMS As Decimal = 0.00000020000000000000002D
    Private Const intCARATS_TO_MILLIGRAMS As Integer = 200
    Private Const decCARATS_TO_OUNCES As Decimal = 0.00705479239D
    Private Const decCARATS_TO_POUNDS As Decimal = 0.000440924524D
    Private Const decCARATS_TO_TONS As Decimal = 0.0000002204622621848776D

    ' Constants for gram conversion factors
    Private Const intGRAMS_TO_CARATS As Integer = 5
    Private Const decGRAMS_TO_KILOGRAMS As Decimal = 0.001D
    Private Const decGRAMS_TO_MEGAGRAMS As Decimal = 0.000001D
    Private Const intGRAMS_TO_MILLIGRAMS As Integer = 1000
    Private Const decGRAMS_TO_OUNCES As Decimal = 0.0352739619D
    Private Const decGRAMS_TO_POUNDS As Decimal = 0.00220462262D
    Private Const decGRAMS_TO_TONS As Decimal = 0.00000110231131D

    ' Constants for ounce conversion factors
    Private Const decOUNCES_TO_CARATS As Decimal = 141.747616D
    Private Const decOUNCES_TO_GRAMS As Decimal = 28.3495231D
    Private Const decOUNCES_TO_KILOGRAMS As Decimal = 0.0283495231D
    Private Const decOUNCES_TO_MEGAGRAMS As Decimal = 0.0000283495231D
    Private Const decOUNCES_TO_MILLIGRAMS As Decimal = 28349.5231D
    Private Const intOUNCES_TO_POUNDS As Integer = 16
    Private Const intOUNCES_TO_TONS As Integer = 32000

    ' Declare local variables to store the input and result
    Friend Sub WeightConversion()

        Dim decInput As Decimal
        Dim decResult As Decimal

        ' Set the result labels
        frmMainForm.lblWeightFromDescription.Text = frmMainForm.lstWeightFrom.Text
        frmMainForm.lblWeightToDescription.Text = frmMainForm.lstWeightTo.Text
        Try
            ' Get the number to be converted
            decInput = Decimal.Parse(frmMainForm.txtWeightFrom.Text)

            ' Convert from Carat
            If (frmMainForm.lstWeightFrom.Text = strCarat) Then
                decResult = ConvertFromCarat(frmMainForm.lstWeightTo.Text, decInput)

                ' Convert from Gram
            ElseIf (frmMainForm.lstWeightFrom.Text = strGram) Then
                decResult = ConvertFromGram(frmMainForm.lstWeightTo.Text, decInput)

                ' Convert from Kilogram
            ElseIf (frmMainForm.lstWeightFrom.Text = strKilogram) Then
                ' Use Gram conversion, and multiply by 1,000
                decInput = decInput * 1000
                decResult = ConvertFromGram(frmMainForm.lstWeightTo.Text, decInput)

                ' Convert from Megagram
            ElseIf (frmMainForm.lstWeightFrom.Text = strMegagram) Then
                ' Use Gram conversion, and multiply by 1000000
                decInput = decInput * 1000000
                decResult = ConvertFromGram(frmMainForm.lstWeightTo.Text, decInput)

                ' Convert from Milligram
            ElseIf (frmMainForm.lstWeightFrom.Text = strMilligram) Then
                ' Use Gram conversion, and multiply by .001
                decInput = decInput * 0.001D
                decResult = ConvertFromGram(frmMainForm.lstWeightTo.Text, decInput)

                ' Convert from Ounce
            ElseIf (frmMainForm.lstWeightFrom.Text = strOunce) Then
                decResult = ConvertFromOunce(frmMainForm.lstWeightTo.Text, decInput)

                ' Convert from Pound
            ElseIf (frmMainForm.lstWeightFrom.Text = strPound) Then
                ' Use Ounce conversion, and multiply by 16
                decInput = decInput * 16
                decResult = ConvertFromOunce(frmMainForm.lstWeightTo.Text, decInput)

                ' Convert from Ton
            ElseIf (frmMainForm.lstWeightFrom.Text = strTon) Then
                ' Use Ounce conversion, and multiply by 32,000
                decInput = decInput * 32000
                decResult = ConvertFromOunce(frmMainForm.lstWeightTo.Text, decInput)
            End If

            ' Display and format the result
            frmMainForm.txtWeightTo.Text = RemoveTrailingZeros(decResult.ToString("n" & frmMainForm.strDecimalPlaces))
            frmMainForm.txtWeightFrom.Focus()
            frmMainForm.txtWeightFrom.SelectAll()

        Catch ex As Exception ' Catch and handle input exceptions
            MessageBox.Show("Please enter a valid number.", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With frmMainForm.txtWeightFrom
                .Clear()
                .Select()
            End With
        End Try
    End Sub

    ' Convert from Carats
    Friend Function ConvertFromCarat(ByVal strWeightTo As String, ByVal decInput As Decimal) As Decimal
        Dim decResult As Decimal

        If (strWeightTo = strCarat) Then
            decResult = decInput
        ElseIf (strWeightTo = strGram) Then
            decResult = decInput * decCARATS_TO_GRAMS
        ElseIf (strWeightTo = strKilogram) Then
            decResult = decInput * decCARATS_TO_KILOGRAMS
        ElseIf (strWeightTo = strMegagram) Then
            decResult = decInput * decCARATS_TO_MEGAGRAMS
        ElseIf (strWeightTo = strMilligram) Then
            decResult = decInput * intCARATS_TO_MILLIGRAMS
        ElseIf (strWeightTo = strOunce) Then
            decResult = decInput * decCARATS_TO_OUNCES
        ElseIf (strWeightTo = strPound) Then
            decResult = decInput * decCARATS_TO_POUNDS
        ElseIf (strWeightTo = strTon) Then
            decResult = decInput * decCARATS_TO_TONS
        End If

        Return decResult

    End Function ' Convert from carats

    ' Convert from Grams
    Friend Function ConvertFromGram(ByVal strWeightTo As String, ByVal decInput As Decimal) As Decimal
        Dim decResult As Decimal

        If (strWeightTo = strCarat) Then
            decResult = decInput * intGRAMS_TO_CARATS
        ElseIf (strWeightTo = strGram) Then
            decResult = decInput
        ElseIf (strWeightTo = strKilogram) Then
            decResult = decInput * decGRAMS_TO_KILOGRAMS
        ElseIf (strWeightTo = strMegagram) Then
            decResult = decInput * decGRAMS_TO_MEGAGRAMS
        ElseIf (strWeightTo = strMilligram) Then
            decResult = decInput * intGRAMS_TO_MILLIGRAMS
        ElseIf (strWeightTo = strOunce) Then
            decResult = decInput * decCARATS_TO_OUNCES
        ElseIf (strWeightTo = strPound) Then
            decResult = decInput * decGRAMS_TO_POUNDS
        ElseIf (strWeightTo = strTon) Then
            decResult = decInput * decGRAMS_TO_TONS
        End If

        Return decResult

    End Function ' Convert from grams

    ' Convert from Ounces
    Friend Function ConvertFromOunce(ByVal strWeightTo As String, ByVal decInput As Decimal) As Decimal
        Dim decResult As Decimal

        If (strWeightTo = strCarat) Then
            decResult = decInput * decOUNCES_TO_CARATS
        ElseIf (strWeightTo = strGram) Then
            decResult = decInput * decOUNCES_TO_GRAMS
        ElseIf (strWeightTo = strKilogram) Then
            decResult = decInput * decOUNCES_TO_KILOGRAMS
        ElseIf (strWeightTo = strMegagram) Then
            decResult = decInput * decOUNCES_TO_MEGAGRAMS
        ElseIf (strWeightTo = strMilligram) Then
            decResult = decInput * decOUNCES_TO_MILLIGRAMS
        ElseIf (strWeightTo = strOunce) Then
            decResult = decInput
        ElseIf (strWeightTo = strPound) Then
            decResult = decInput / intOUNCES_TO_POUNDS
        ElseIf (strWeightTo = strTon) Then
            decResult = decInput / intOUNCES_TO_TONS
        End If

        Return decResult

    End Function ' Convert from grams

End Module