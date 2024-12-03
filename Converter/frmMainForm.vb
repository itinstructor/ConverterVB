'Project:       Converter 2.0
'Programmer:    William Loring
'Date:          06/19/2010
'Revised:       05/21/2011
'Description:   Convert various length, temperature, weight measurements
Public Class frmMainForm

    ' Set an accuracy constant for conversion display
    Friend Const strDecimalPlaces As String = "10"

    ' Form_Load event sets default settings for program
    Private Sub frmMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the selection in the list boxes in each tab to a default choice
        lstLengthFrom.SelectedIndex = 4
        lstLengthTo.SelectedIndex = 4
        lstTemperatureFrom.SelectedIndex = 1
        lstTemperatureTo.SelectedIndex = 0
        lstWeightFrom.SelectedIndex = 1
        lstWeightTo.SelectedIndex = 1
        lstByteFrom.SelectedIndex = 4
        lstByteTo.SelectedIndex = 2

        ' When the form is loaded, set the focus on the first tab, and select the input txt field
        TabControl.SelectedIndex = 0
        txtLengthFrom.Select()
    End Sub ' frmMainForm Load

    ' Select the input area when the tab changes
    Private Sub TabControl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedIndex = 0 Then
            txtLengthFrom.Select()
        ElseIf TabControl.SelectedIndex = 1 Then
            txtWeightFrom.Focus()
            txtWeightFrom.SelectAll()
        ElseIf TabControl.SelectedIndex = 2 Then
            txtTemperatureFrom.Focus()
            txtTemperatureFrom.SelectAll()
        ElseIf TabControl.SelectedIndex = 3 Then
            txtByteFrom.Focus()
            txtByteFrom.SelectAll()
        End If
    End Sub ' Select the input area when the tab changes

    Private Sub lstLengthFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLengthTo.SelectedIndexChanged, lstLengthFrom.SelectedIndexChanged
        ' If either Length list box changes, activate the procedure
        LengthConversion()
    End Sub

    Private Sub txtLengthFrom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLengthFrom.KeyPress
        ' Intercept the keystroke, and perform the appropriate method
        Select Case e.KeyChar
            Case ControlChars.Cr : LengthConversion()
        End Select
    End Sub

    ' If either Weight list textbox changes, activate the procedure
    Private Sub lstWeightFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstWeightFrom.SelectedIndexChanged, lstWeightTo.SelectedIndexChanged
        WeightConversion()
    End Sub

    Private Sub txtWeightFrom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeightFrom.KeyPress
        ' Intercept the keystroke, and perform the appropriate method
        Select Case e.KeyChar
            Case ControlChars.Cr : WeightConversion()
        End Select
    End Sub

    Private Sub lstTemperatureFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTemperatureTo.SelectedIndexChanged, lstTemperatureFrom.SelectedIndexChanged
        ' When either listbox changes, run this procedure
        TemperatureConversion()
    End Sub ' Temperature conversion

    Private Sub txtTemperatureFrom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTemperatureFrom.KeyPress
        ' Intercept the keystroke, and perform the appropriate method
        Select Case e.KeyChar
            Case ControlChars.Cr : TemperatureConversion()
        End Select
    End Sub

    Private Sub lstByteFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstByteTo.SelectedIndexChanged, lstByteFrom.SelectedIndexChanged
        ' When either listbox changes, run this procedure
        ByteConversion()
    End Sub ' Byte conversion

    Private Sub txtByteFrom_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtByteFrom.KeyPress
        ' Intercept the keystroke, and perform the appropriate method
        Select Case e.KeyChar
            Case ControlChars.Cr : ByteConversion()
        End Select
    End Sub

    ' Exit the program
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExit.Click
        Me.Close()
    End Sub ' Exit the program

    Private Sub AboutConverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiAboutConverter.Click
        AboutBox.ShowDialog()
    End Sub
End Class