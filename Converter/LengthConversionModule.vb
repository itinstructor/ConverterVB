Module LengthConversionModule

    ' Length names constants in list boxes for easier updating and comparison
    Friend Const strCM As String = "centimeter (cm)"
    Friend Const strFathom As String = "fathom (ftm)"
    Friend Const strFoot As String = "foot (ft)"
    Friend Const strFurlong As String = "furlong (fur)"
    Friend Const strInch As String = "inch (in)"
    Friend Const strKM As String = "kilometer (km)"
    Friend Const strMeter As String = "meter (m)"
    Friend Const strMile As String = "mile (mi)"
    Friend Const strMM As String = "millimeter (mm)"
    Friend Const strYard As String = "yard (yd)"

    ' Constants for length conversion factors
    Private Const decCM_TO_FATHOMS As Decimal = 0.005468066D
    Private Const decCM_TO_FEET As Decimal = 0.032808399D
    Private Const decCM_TO_FURLONGS As Decimal = 0.000049709695379D
    Private Const decCM_TO_INCHES As Decimal = 0.393700787D
    Private Const decCM_TO_KM As Decimal = 0.00001D
    Private Const decCM_TO_METERS As Decimal = 0.01D
    Private Const decCM_TO_MILES As Decimal = 0.00000621371192237D
    Private Const intCM_TO_MM As Integer = 10
    Private Const decCM_TO_YARDS As Decimal = 0.0109361329834D

    Private Const decFATHOMS_TO_CM As Decimal = 182.88D
    Private Const intFATHOMS_TO_FEET As Integer = 6
    Private Const decFATHOMS_TO_FURLONGS As Decimal = 0.00909090909D
    Private Const intFATHOMS_TO_INCHES As Integer = 72
    Private Const decFATHOMS_TO_KM As Decimal = 0.0018288D
    Private Const decFATHOMS_TO_METERS As Decimal = 1.8288D
    Private Const decFATHOMS_TO_MILES As Decimal = 0.00113636364D
    Private Const decFATHOMS_TO_MM As Decimal = 1828.8D
    Private Const intFATHOMS_TO_YARDS As Integer = 2

    Private Const decFURLONGS_TO_CM As Decimal = 20116.8D
    Private Const intFURLONGS_TO_FATHOMS As Integer = 110
    Private Const intFURLONGS_TO_FEET As Integer = 660
    Private Const intFURLONGS_TO_INCHES As Integer = 7920
    Private Const decFURLONGS_TO_KM As Decimal = 0.201168D
    Private Const decFURLONGS_TO_METERS As Decimal = 201.168D
    Private Const decFURLONGS_TO_MILES As Decimal = 0.125D
    Private Const intFURLONGS_TO_MM As Integer = 201168
    Private Const intFURLONGS_TO_YARDS As Integer = 220

    Private Const decINCHES_TO_CM As Decimal = 2.54D
    Private Const intINCHES_TO_FATHOMS As Integer = 72
    Private Const intINCHES_TO_FEET As Integer = 12
    Private Const intINCHES_TO_FURLONGS As Integer = 7920
    Private Const decINCHES_TO_KM As Decimal = 0.0000254D
    Private Const decINCHES_TO_METERS As Decimal = 0.0254D
    Private Const intINCHES_TO_MILES As Integer = 63360
    Private Const decINCHES_TO_MM As Decimal = 25.4D
    Private Const intINCHES_TO_YARDS As Integer = 36

    ' Length conversion subroutine
    Friend Sub LengthConversion()
        ' Declare local variables to store the input and result
        Dim decInput As Decimal
        Dim decResult As Decimal

        frmMainForm.lblLengthFromDescription.Text = frmMainForm.lstLengthFrom.Text
        frmMainForm.lblLengthToDescription.Text = frmMainForm.lstLengthTo.Text
        Try
            ' Get the number to be converted
            decInput = Decimal.Parse(frmMainForm.txtLengthFrom.Text)

            ' Convert from CM
            If (frmMainForm.lstLengthFrom.Text = strCM) Then
                decResult = ConvertFromCM(frmMainForm.lstLengthTo.Text, decInput)

                ' Convert from KM
            ElseIf (frmMainForm.lstLengthFrom.Text = strKM) Then
                ' Use CM conversion, and multiply by 100,00
                decInput = decInput * 100000
                decResult = ConvertFromCM(frmMainForm.lstLengthTo.Text, decInput)

                ' Convert from Meter
            ElseIf (frmMainForm.lstLengthFrom.Text = strMeter) Then
                ' Use CM conversion, and multiply by 100
                decInput = decInput * 100
                decResult = ConvertFromCM(frmMainForm.lstLengthTo.Text, decInput)

                ' Convert from MM
            ElseIf (frmMainForm.lstLengthFrom.Text = strMM) Then
                ' Use CM conversion, and multiply by .1
                decInput = decInput * 0.1D
                decResult = ConvertFromCM(frmMainForm.lstLengthTo.Text, decInput)

                ' Convert from fathoms
            ElseIf (frmMainForm.lstLengthFrom.Text = strFathom) Then
                If (frmMainForm.lstLengthTo.Text = strCM) Then
                    decResult = decInput * decFATHOMS_TO_CM
                ElseIf (frmMainForm.lstLengthTo.Text = strFathom) Then
                    decResult = decInput
                ElseIf (frmMainForm.lstLengthTo.Text = strFoot) Then
                    decResult = decInput * intFATHOMS_TO_FEET
                ElseIf (frmMainForm.lstLengthTo.Text = strFurlong) Then
                    decResult = decInput * decFATHOMS_TO_FURLONGS
                ElseIf (frmMainForm.lstLengthTo.Text = strInch) Then
                    decResult = decInput * intFATHOMS_TO_INCHES
                ElseIf (frmMainForm.lstLengthTo.Text = strKM) Then
                    decResult = decInput * decFATHOMS_TO_KM
                ElseIf (frmMainForm.lstLengthTo.Text = strMeter) Then
                    decResult = decInput * decFATHOMS_TO_METERS
                ElseIf (frmMainForm.lstLengthTo.Text = strMile) Then
                    decResult = decInput * decFATHOMS_TO_MILES
                ElseIf (frmMainForm.lstLengthTo.Text = strMM) Then
                    decResult = decInput * decFATHOMS_TO_MM
                ElseIf (frmMainForm.lstLengthTo.Text = strYard) Then
                    decResult = decInput * intFATHOMS_TO_YARDS
                End If

                ' Convert from feet
            ElseIf (frmMainForm.lstLengthFrom.Text = strFoot) Then
                ' Use inch conversion, and multiply by 12
                decInput = decInput * 12
                decResult = ConvertFromInches(frmMainForm.lstLengthTo.Text, decInput)

                ' Convert from yards
            ElseIf (frmMainForm.lstLengthFrom.Text = strYard) Then
                ' Use inch conversion, and multiply by 36
                decInput = decInput * 36
                decResult = ConvertFromInches(frmMainForm.lstLengthTo.Text, decInput)

                ' Convert from furlong
            ElseIf (frmMainForm.lstLengthFrom.Text = strFurlong) Then
                If (frmMainForm.lstLengthTo.Text = strCM) Then
                    decResult = decInput * decFURLONGS_TO_CM
                ElseIf (frmMainForm.lstLengthTo.Text = strFathom) Then
                    decResult = decInput * intFURLONGS_TO_FATHOMS
                ElseIf (frmMainForm.lstLengthTo.Text = strFoot) Then
                    decResult = decInput * intFURLONGS_TO_FEET
                ElseIf (frmMainForm.lstLengthTo.Text = strFurlong) Then
                    decResult = decInput
                ElseIf (frmMainForm.lstLengthTo.Text = strInch) Then
                    decResult = decInput * intFURLONGS_TO_INCHES
                ElseIf (frmMainForm.lstLengthTo.Text = strKM) Then
                    decResult = decInput * decFURLONGS_TO_KM
                ElseIf (frmMainForm.lstLengthTo.Text = strMeter) Then
                    decResult = decInput * decFURLONGS_TO_METERS
                ElseIf (frmMainForm.lstLengthTo.Text = strMile) Then
                    decResult = decInput * decFURLONGS_TO_MILES
                ElseIf (frmMainForm.lstLengthTo.Text = strMM) Then
                    decResult = decInput * intFURLONGS_TO_MM
                ElseIf (frmMainForm.lstLengthTo.Text = strYard) Then
                    decResult = decInput * intFURLONGS_TO_YARDS
                End If

                ' Convert from Inches
            ElseIf (frmMainForm.lstLengthFrom.Text = strInch) Then

                decResult = ConvertFromInches(frmMainForm.lstLengthTo.Text, decInput)

                ' Convert from miles
            ElseIf (frmMainForm.lstLengthFrom.Text = strMile) Then
                ' Use inch conversion, and multiply by 63360
                decInput = decInput * 63360
                decResult = ConvertFromInches(frmMainForm.lstLengthTo.Text, decInput)

            End If

            ' Display and format the result
            frmMainForm.txtLenghtTo.Text = RemoveTrailingZeros(decResult.ToString("n" & frmMainForm.strDecimalPlaces))
            frmMainForm.txtLengthFrom.Focus()
            frmMainForm.txtLengthFrom.SelectAll()

        Catch ex As Exception
            MessageBox.Show("Please enter a valid number.", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With frmMainForm.txtLengthFrom
                .Clear()
                .Select()

            End With
        End Try
    End Sub

    ' Convert from CM
    Friend Function ConvertFromCM(ByVal strLengthTo As String, ByVal decInput As Decimal) As Decimal
        Dim decResult As Decimal

        If (strLengthTo = strCM) Then
            decResult = decInput
        ElseIf (strLengthTo = strFathom) Then
            decResult = decInput * decCM_TO_FATHOMS
        ElseIf (strLengthTo = strFoot) Then
            decResult = decInput * decCM_TO_FEET
        ElseIf (strLengthTo = strFurlong) Then
            decResult = decInput * decCM_TO_FURLONGS
        ElseIf (strLengthTo = strInch) Then
            decResult = decInput * decCM_TO_INCHES
        ElseIf (strLengthTo = strKM) Then
            decResult = decInput * decCM_TO_KM
        ElseIf (strLengthTo = strMeter) Then
            decResult = decInput * decCM_TO_METERS
        ElseIf (strLengthTo = strMile) Then
            decResult = decInput * decCM_TO_MILES
        ElseIf (strLengthTo = strMM) Then
            decResult = decInput * intCM_TO_MM
        ElseIf (strLengthTo = strYard) Then
            decResult = decInput * decCM_TO_YARDS
        End If

        Return decResult
    End Function ' Convert From CM

    ' Convert from Inches
    Friend Function ConvertFromInches(ByVal strLengthTo As String, ByVal decInput As Decimal) As Decimal
        Dim decResult As Decimal

        If (strLengthTo = strCM) Then
            decResult = decInput * decINCHES_TO_CM
        ElseIf (strLengthTo = strFathom) Then
            decResult = decInput / intINCHES_TO_FATHOMS
        ElseIf (strLengthTo = strFoot) Then
            decResult = decInput / intINCHES_TO_FEET
        ElseIf (strLengthTo = strFurlong) Then
            decResult = decInput / intINCHES_TO_FURLONGS
        ElseIf (strLengthTo = strInch) Then
            decResult = decInput
        ElseIf (strLengthTo = strKM) Then
            decResult = decInput * decINCHES_TO_KM
        ElseIf (strLengthTo = strMeter) Then
            decResult = decInput * decINCHES_TO_METERS
        ElseIf (strLengthTo = strMile) Then
            decResult = decInput / intINCHES_TO_MILES
        ElseIf (strLengthTo = strMM) Then
            decResult = decInput * decINCHES_TO_MM
        ElseIf (strLengthTo = strYard) Then
            decResult = decInput / intINCHES_TO_YARDS
        End If

        Return decResult
    End Function ' Convert from Inches

End Module