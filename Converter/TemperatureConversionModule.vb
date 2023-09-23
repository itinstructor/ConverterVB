Module TemperatureConversionModule
    Friend Sub TemperatureConversion()

        ' Declare local variables to store the input and result
        Dim dblInput As Double
        Dim dblResult As Double

        ' Set the result labels
        frmMainForm.lblTemperatureFrom.Text = frmMainForm.lstTemperatureFrom.Text
        frmMainForm.lblTemperatureTo.Text = frmMainForm.lstTemperatureTo.Text
        Try
            ' Get the number to be converted
            dblInput = Decimal.Parse(frmMainForm.txtTemperatureFrom.Text)

            If (frmMainForm.lstTemperatureFrom.Text = "Fahrenheit") Then
                If (frmMainForm.lstTemperatureTo.Text = "Celsius") Then
                    dblResult = ((dblInput - 32.0) * 5.0) / 9
                ElseIf (frmMainForm.lstTemperatureTo.Text = "Fahrenheit") Then
                    dblResult = dblInput
                End If
            ElseIf (frmMainForm.lstTemperatureFrom.Text = "Celsius") Then
                If (frmMainForm.lstTemperatureTo.Text = "Celsius") Then
                    dblResult = dblInput
                ElseIf (frmMainForm.lstTemperatureTo.Text = "Fahrenheit") Then
                    dblResult = ((dblInput * 9.0) / 5.0) + 32
                End If
            End If

            ' Convert the result to a string, round it off, and add the degree character
            frmMainForm.txtTemperatureTo.Text = RemoveTrailingZeros(dblResult.ToString("n" & frmMainForm.strDecimalPlaces)) & Chr(176)
            frmMainForm.txtTemperatureFrom.Focus()
            frmMainForm.txtTemperatureFrom.SelectAll()

            ' Handle any exceptions
        Catch ex As Exception
            MessageBox.Show("Please enter a valid number.", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            With frmMainForm.txtTemperatureFrom
                .Clear()
                .Focus()
            End With
        End Try
    End Sub
End Module
