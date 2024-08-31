Module ByteConversionModule

    ' Computer measurement name constants
    Private Const strByte As String = "byte"
    Private Const strKilobyte As String = "kilobyte (KB)"
    Private Const strMegabyte As String = "megabyte (MB)"
    Private Const strGigabyte As String = "gigabyte (GB)"
    Private Const strTerabyte As String = "terabyte (TB)"
    Private Const strPetabyte As String = "petabyte (PB)"

    ' Constants for Bytes conversion factors Base 2
    Private Const dblBYTE_TO_KILOBYTE As Double = 2 ^ 10  ' 1024
    Private Const dblBYTE_TO_MEGABYTE As Double = 2 ^ 20  ' 1048576
    Private Const dblBYTE_TO_GIGABYTE As Double = 2 ^ 30  ' 1073741824
    Private Const dblBYTE_TO_TERABYTE As Double = 2 ^ 40  ' 1099511627776
    Private Const dblBYTE_TO_PETABYTE As Double = 2 ^ 50  ' 1125899906842624

    ' Constants for Bytes conversion factors Base 10
    Private Const dblBYTE_TO_KILOBYTE1000 As Double = 1000
    Private Const dblBYTE_TO_MEGABYTE1000 As Double = 1000000
    Private Const dblBYTE_TO_GIGABYTE1000 As Double = 1000000000
    Private Const dblBYTE_TO_TERABYTE1000 As Double = 1000000000000
    Private Const dblBYTE_TO_PETABYTE1000 As Double = 1000000000000000

    ' Bytes conversion subroutine
    Friend Sub ByteConversion()
        ' Declare local variables to store the input and result
        Dim dblInput As Double
        Dim dblResult, dblResult1000 As Double

        frmMainForm.lblByteFrom.Text = frmMainForm.lstByteFrom.Text
        frmMainForm.lblByteTo.Text = frmMainForm.lstByteTo.Text
        frmMainForm.lblBytesTo.Text = frmMainForm.lstByteTo.Text

        Try
            ' Get the number to be converted
            dblInput = Double.Parse(frmMainForm.txtByteFrom.Text)

            ' Convert from Bytes
            If (frmMainForm.lstByteFrom.Text = strByte) Then
                If (frmMainForm.lstByteTo.Text = strByte) Then
                    dblResult = dblInput
                    dblResult1000 = dblInput
                ElseIf (frmMainForm.lstByteTo.Text = strKilobyte) Then
                    dblResult = dblInput / dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput / dblBYTE_TO_KILOBYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strMegabyte) Then
                    dblResult = dblInput / dblBYTE_TO_MEGABYTE
                    dblResult1000 = dblInput / dblBYTE_TO_MEGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strGigabyte) Then
                    dblResult = dblInput / dblBYTE_TO_GIGABYTE
                    dblResult1000 = dblInput / dblBYTE_TO_GIGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strPetabyte) Then
                    dblResult = dblInput / dblBYTE_TO_PETABYTE
                    dblResult1000 = dblInput / dblBYTE_TO_PETABYTE1000
                End If

                ' Convert from Kilobytes
            ElseIf (frmMainForm.lstByteFrom.Text = strKilobyte) Then
                If (frmMainForm.lstByteTo.Text = strByte) Then
                    dblResult = dblInput * dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput * dblBYTE_TO_KILOBYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strKilobyte) Then
                    dblResult = dblInput
                    dblResult1000 = dblInput
                ElseIf (frmMainForm.lstByteTo.Text = strMegabyte) Then
                    dblResult = dblInput / dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput / dblBYTE_TO_KILOBYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strGigabyte) Then
                    dblResult = dblInput / dblBYTE_TO_MEGABYTE
                    dblResult1000 = dblInput / dblBYTE_TO_MEGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strTerabyte) Then
                    dblResult = dblInput / dblBYTE_TO_GIGABYTE
                    dblResult1000 = dblInput / dblBYTE_TO_GIGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strPetabyte) Then
                    dblResult = dblInput / dblBYTE_TO_TERABYTE
                    dblResult1000 = dblInput / dblBYTE_TO_TERABYTE1000
                End If

                ' Convert from Megabytes
            ElseIf (frmMainForm.lstByteFrom.Text = strMegabyte) Then
                If (frmMainForm.lstByteTo.Text = strByte) Then
                    dblResult = dblInput * dblBYTE_TO_MEGABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_MEGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strKilobyte) Then
                    dblResult = dblInput * dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput * dblBYTE_TO_KILOBYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strMegabyte) Then
                    dblResult = dblInput
                    dblResult1000 = dblInput
                ElseIf (frmMainForm.lstByteTo.Text = strGigabyte) Then
                    dblResult = dblInput / dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput / dblBYTE_TO_KILOBYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strTerabyte) Then
                    dblResult = dblInput / dblBYTE_TO_MEGABYTE
                    dblResult1000 = dblInput / dblBYTE_TO_MEGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strPetabyte) Then
                    dblResult = dblInput / dblBYTE_TO_GIGABYTE
                    dblResult1000 = dblInput / dblBYTE_TO_GIGABYTE1000
                End If

                ' Convert from Gigabytes
            ElseIf (frmMainForm.lstByteFrom.Text = strGigabyte) Then
                If (frmMainForm.lstByteTo.Text = strByte) Then
                    dblResult = dblInput * dblBYTE_TO_GIGABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_GIGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strKilobyte) Then
                    dblResult = dblInput * dblBYTE_TO_MEGABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_MEGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strMegabyte) Then
                    dblResult = dblInput * dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput * dblBYTE_TO_KILOBYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strGigabyte) Then
                    dblResult = dblInput
                    dblResult1000 = dblInput
                ElseIf (frmMainForm.lstByteTo.Text = strTerabyte) Then
                    dblResult = dblInput / dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput / dblBYTE_TO_KILOBYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strPetabyte) Then
                    dblResult = dblInput / dblBYTE_TO_MEGABYTE
                    dblResult1000 = dblInput / dblBYTE_TO_MEGABYTE1000
                End If

                ' Convert from Terabytes
            ElseIf (frmMainForm.lstByteFrom.Text = strTerabyte) Then
                If (frmMainForm.lstByteTo.Text = strByte) Then
                    dblResult = dblInput * dblBYTE_TO_TERABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_TERABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strKilobyte) Then
                    dblResult = dblInput * dblBYTE_TO_GIGABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_GIGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strMegabyte) Then
                    dblResult = dblInput * dblBYTE_TO_MEGABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_MEGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strGigabyte) Then
                    dblResult = dblInput * dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput * dblBYTE_TO_KILOBYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strTerabyte) Then
                    dblResult = dblInput
                    dblResult1000 = dblInput
                ElseIf (frmMainForm.lstByteTo.Text = strPetabyte) Then
                    dblResult = dblInput / dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput / dblBYTE_TO_KILOBYTE1000
                End If

                ' Convert from Petabytes
            ElseIf (frmMainForm.lstByteFrom.Text = strPetabyte) Then
                If (frmMainForm.lstByteTo.Text = strByte) Then
                    dblResult = dblInput * dblBYTE_TO_PETABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_PETABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strKilobyte) Then
                    dblResult = dblInput * dblBYTE_TO_TERABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_TERABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strMegabyte) Then
                    dblResult = dblInput * dblBYTE_TO_GIGABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_GIGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strGigabyte) Then
                    dblResult = dblInput * dblBYTE_TO_MEGABYTE
                    dblResult1000 = dblInput * dblBYTE_TO_MEGABYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strTerabyte) Then
                    dblResult = dblInput * dblBYTE_TO_KILOBYTE
                    dblResult1000 = dblInput * dblBYTE_TO_KILOBYTE1000
                ElseIf (frmMainForm.lstByteTo.Text = strPetabyte) Then
                    dblResult = dblInput
                    dblResult1000 = dblInput
                End If
            End If

            ' Convert the result to a string, round it off and display
            frmMainForm.txtByteTo.Text = RemoveTrailingZeros(dblResult.ToString("n" & frmMainForm.strDecimalPlaces))
            frmMainForm.txtBytes1000To.Text = RemoveTrailingZeros(dblResult1000.ToString("n" & frmMainForm.strDecimalPlaces))
            frmMainForm.txtByteFrom.Focus()
            frmMainForm.txtByteFrom.SelectAll()

            ' Handle any exceptions
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number.", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With frmMainForm.txtByteFrom
                .Clear()
                .Focus()
            End With
        End Try
    End Sub
End Module