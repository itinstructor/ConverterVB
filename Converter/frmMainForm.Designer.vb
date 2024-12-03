<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainForm))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tabLength = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblLengthToDescription = New System.Windows.Forms.Label()
        Me.lblLengthFromDescription = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLenghtTo = New System.Windows.Forms.TextBox()
        Me.txtLengthFrom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstLengthTo = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstLengthFrom = New System.Windows.Forms.ListBox()
        Me.tabWeight = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblWeightToDescription = New System.Windows.Forms.Label()
        Me.lblWeightFromDescription = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWeightTo = New System.Windows.Forms.TextBox()
        Me.txtWeightFrom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lstWeightTo = New System.Windows.Forms.ListBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lstWeightFrom = New System.Windows.Forms.ListBox()
        Me.tabTemperature = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtTemperatureFrom = New System.Windows.Forms.TextBox()
        Me.lblTemperatureTo = New System.Windows.Forms.Label()
        Me.lblTemperatureFrom = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTemperatureTo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lstTemperatureTo = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstTemperatureFrom = New System.Windows.Forms.ListBox()
        Me.TabComputer = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblBytesTo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBytes1000To = New System.Windows.Forms.TextBox()
        Me.lblByteTo = New System.Windows.Forms.Label()
        Me.lblByteFrom = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtByteTo = New System.Windows.Forms.TextBox()
        Me.txtByteFrom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.lstByteTo = New System.Windows.Forms.ListBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.lstByteFrom = New System.Windows.Forms.ListBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutConverter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl.SuspendLayout()
        Me.tabLength.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabWeight.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.tabTemperature.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabComputer.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tabLength)
        Me.TabControl.Controls.Add(Me.tabWeight)
        Me.TabControl.Controls.Add(Me.tabTemperature)
        Me.TabControl.Controls.Add(Me.TabComputer)
        Me.TabControl.Location = New System.Drawing.Point(0, 29)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Drawing.Point(3, 3)
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(321, 330)
        Me.TabControl.TabIndex = 4
        '
        'tabLength
        '
        Me.tabLength.BackColor = System.Drawing.SystemColors.Control
        Me.tabLength.Controls.Add(Me.Label13)
        Me.tabLength.Controls.Add(Me.GroupBox3)
        Me.tabLength.Controls.Add(Me.GroupBox2)
        Me.tabLength.Controls.Add(Me.GroupBox1)
        Me.tabLength.Location = New System.Drawing.Point(4, 24)
        Me.tabLength.Name = "tabLength"
        Me.tabLength.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLength.Size = New System.Drawing.Size(313, 302)
        Me.tabLength.TabIndex = 0
        Me.tabLength.Text = "Length"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(146, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = ">>"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblLengthToDescription)
        Me.GroupBox3.Controls.Add(Me.lblLengthFromDescription)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtLenghtTo)
        Me.GroupBox3.Controls.Add(Me.txtLengthFrom)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 85)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Convert"
        '
        'lblLengthToDescription
        '
        Me.lblLengthToDescription.AutoSize = True
        Me.lblLengthToDescription.Location = New System.Drawing.Point(192, 53)
        Me.lblLengthToDescription.Name = "lblLengthToDescription"
        Me.lblLengthToDescription.Size = New System.Drawing.Size(0, 15)
        Me.lblLengthToDescription.TabIndex = 24
        '
        'lblLengthFromDescription
        '
        Me.lblLengthFromDescription.AutoSize = True
        Me.lblLengthFromDescription.Location = New System.Drawing.Point(192, 23)
        Me.lblLengthFromDescription.Name = "lblLengthFromDescription"
        Me.lblLengthFromDescription.Size = New System.Drawing.Size(0, 15)
        Me.lblLengthFromDescription.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "To:"
        '
        'txtLenghtTo
        '
        Me.txtLenghtTo.Location = New System.Drawing.Point(47, 48)
        Me.txtLenghtTo.Name = "txtLenghtTo"
        Me.txtLenghtTo.ReadOnly = True
        Me.txtLenghtTo.Size = New System.Drawing.Size(139, 23)
        Me.txtLenghtTo.TabIndex = 21
        Me.txtLenghtTo.TabStop = False
        '
        'txtLengthFrom
        '
        Me.txtLengthFrom.Location = New System.Drawing.Point(47, 20)
        Me.txtLengthFrom.Name = "txtLengthFrom"
        Me.txtLengthFrom.Size = New System.Drawing.Size(139, 23)
        Me.txtLengthFrom.TabIndex = 19
        Me.txtLengthFrom.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "From:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstLengthTo)
        Me.GroupBox2.Location = New System.Drawing.Point(175, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 189)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "To"
        '
        'lstLengthTo
        '
        Me.lstLengthTo.FormattingEnabled = True
        Me.lstLengthTo.ItemHeight = 15
        Me.lstLengthTo.Items.AddRange(New Object() {"centimeter (cm)", "fathom (ftm)", "foot (ft)", "furlong (fur)", "inch (in)", "kilometer (km)", "meter (m)", "mile (mi)", "millimeter (mm)", "yard (yd)"})
        Me.lstLengthTo.Location = New System.Drawing.Point(10, 18)
        Me.lstLengthTo.Name = "lstLengthTo"
        Me.lstLengthTo.Size = New System.Drawing.Size(104, 154)
        Me.lstLengthTo.Sorted = True
        Me.lstLengthTo.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstLengthFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 189)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "From"
        '
        'lstLengthFrom
        '
        Me.lstLengthFrom.FormattingEnabled = True
        Me.lstLengthFrom.ItemHeight = 15
        Me.lstLengthFrom.Items.AddRange(New Object() {"centimeter (cm)", "fathom (ftm)", "foot (ft)", "furlong (fur)", "inch (in)", "kilometer (km)", "meter (m)", "mile (mi)", "millimeter (mm)", "yard (yd)"})
        Me.lstLengthFrom.Location = New System.Drawing.Point(10, 20)
        Me.lstLengthFrom.Name = "lstLengthFrom"
        Me.lstLengthFrom.Size = New System.Drawing.Size(104, 154)
        Me.lstLengthFrom.Sorted = True
        Me.lstLengthFrom.TabIndex = 15
        '
        'tabWeight
        '
        Me.tabWeight.BackColor = System.Drawing.SystemColors.Control
        Me.tabWeight.Controls.Add(Me.Label12)
        Me.tabWeight.Controls.Add(Me.GroupBox9)
        Me.tabWeight.Controls.Add(Me.GroupBox7)
        Me.tabWeight.Controls.Add(Me.GroupBox8)
        Me.tabWeight.Location = New System.Drawing.Point(4, 24)
        Me.tabWeight.Name = "tabWeight"
        Me.tabWeight.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWeight.Size = New System.Drawing.Size(313, 302)
        Me.tabWeight.TabIndex = 2
        Me.tabWeight.Text = "Weight"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(134, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 15)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = ">>"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lblWeightToDescription)
        Me.GroupBox9.Controls.Add(Me.lblWeightFromDescription)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.txtWeightTo)
        Me.GroupBox9.Controls.Add(Me.txtWeightFrom)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Location = New System.Drawing.Point(10, 203)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(270, 85)
        Me.GroupBox9.TabIndex = 23
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Convert"
        '
        'lblWeightToDescription
        '
        Me.lblWeightToDescription.AutoSize = True
        Me.lblWeightToDescription.Location = New System.Drawing.Point(192, 53)
        Me.lblWeightToDescription.Name = "lblWeightToDescription"
        Me.lblWeightToDescription.Size = New System.Drawing.Size(0, 15)
        Me.lblWeightToDescription.TabIndex = 24
        '
        'lblWeightFromDescription
        '
        Me.lblWeightFromDescription.AutoSize = True
        Me.lblWeightFromDescription.Location = New System.Drawing.Point(192, 23)
        Me.lblWeightFromDescription.Name = "lblWeightFromDescription"
        Me.lblWeightFromDescription.Size = New System.Drawing.Size(0, 15)
        Me.lblWeightFromDescription.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "To:"
        '
        'txtWeightTo
        '
        Me.txtWeightTo.Location = New System.Drawing.Point(47, 48)
        Me.txtWeightTo.Name = "txtWeightTo"
        Me.txtWeightTo.ReadOnly = True
        Me.txtWeightTo.Size = New System.Drawing.Size(139, 23)
        Me.txtWeightTo.TabIndex = 21
        Me.txtWeightTo.TabStop = False
        '
        'txtWeightFrom
        '
        Me.txtWeightFrom.Location = New System.Drawing.Point(47, 20)
        Me.txtWeightFrom.Name = "txtWeightFrom"
        Me.txtWeightFrom.Size = New System.Drawing.Size(139, 23)
        Me.txtWeightFrom.TabIndex = 19
        Me.txtWeightFrom.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "From:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lstWeightTo)
        Me.GroupBox7.Location = New System.Drawing.Point(175, 7)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(105, 189)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "To"
        '
        'lstWeightTo
        '
        Me.lstWeightTo.FormattingEnabled = True
        Me.lstWeightTo.ItemHeight = 15
        Me.lstWeightTo.Items.AddRange(New Object() {"carat", "gram (g)", "kilogram", "megagram", "milligram", "ounce", "pound", "ton"})
        Me.lstWeightTo.Location = New System.Drawing.Point(10, 18)
        Me.lstWeightTo.Name = "lstWeightTo"
        Me.lstWeightTo.Size = New System.Drawing.Size(81, 154)
        Me.lstWeightTo.Sorted = True
        Me.lstWeightTo.TabIndex = 16
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lstWeightFrom)
        Me.GroupBox8.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(104, 189)
        Me.GroupBox8.TabIndex = 21
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "From"
        '
        'lstWeightFrom
        '
        Me.lstWeightFrom.FormattingEnabled = True
        Me.lstWeightFrom.ItemHeight = 15
        Me.lstWeightFrom.Items.AddRange(New Object() {"carat", "gram (g)", "kilogram", "megagram", "milligram", "ounce", "pound", "ton"})
        Me.lstWeightFrom.Location = New System.Drawing.Point(10, 20)
        Me.lstWeightFrom.Name = "lstWeightFrom"
        Me.lstWeightFrom.Size = New System.Drawing.Size(86, 154)
        Me.lstWeightFrom.Sorted = True
        Me.lstWeightFrom.TabIndex = 15
        '
        'tabTemperature
        '
        Me.tabTemperature.BackColor = System.Drawing.SystemColors.Control
        Me.tabTemperature.Controls.Add(Me.Label11)
        Me.tabTemperature.Controls.Add(Me.GroupBox6)
        Me.tabTemperature.Controls.Add(Me.GroupBox5)
        Me.tabTemperature.Controls.Add(Me.GroupBox4)
        Me.tabTemperature.Location = New System.Drawing.Point(4, 24)
        Me.tabTemperature.Name = "tabTemperature"
        Me.tabTemperature.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTemperature.Size = New System.Drawing.Size(313, 302)
        Me.tabTemperature.TabIndex = 1
        Me.tabTemperature.Text = "Temperature"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(131, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = ">>"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtTemperatureFrom)
        Me.GroupBox6.Controls.Add(Me.lblTemperatureTo)
        Me.GroupBox6.Controls.Add(Me.lblTemperatureFrom)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txtTemperatureTo)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Location = New System.Drawing.Point(10, 142)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(269, 85)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Convert"
        '
        'txtTemperatureFrom
        '
        Me.txtTemperatureFrom.Location = New System.Drawing.Point(47, 20)
        Me.txtTemperatureFrom.Name = "txtTemperatureFrom"
        Me.txtTemperatureFrom.Size = New System.Drawing.Size(138, 23)
        Me.txtTemperatureFrom.TabIndex = 25
        Me.txtTemperatureFrom.Text = "1"
        '
        'lblTemperatureTo
        '
        Me.lblTemperatureTo.AutoSize = True
        Me.lblTemperatureTo.Location = New System.Drawing.Point(192, 53)
        Me.lblTemperatureTo.Name = "lblTemperatureTo"
        Me.lblTemperatureTo.Size = New System.Drawing.Size(0, 15)
        Me.lblTemperatureTo.TabIndex = 24
        '
        'lblTemperatureFrom
        '
        Me.lblTemperatureFrom.AutoSize = True
        Me.lblTemperatureFrom.Location = New System.Drawing.Point(192, 23)
        Me.lblTemperatureFrom.Name = "lblTemperatureFrom"
        Me.lblTemperatureFrom.Size = New System.Drawing.Size(0, 15)
        Me.lblTemperatureFrom.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "To:"
        '
        'txtTemperatureTo
        '
        Me.txtTemperatureTo.Location = New System.Drawing.Point(47, 48)
        Me.txtTemperatureTo.Name = "txtTemperatureTo"
        Me.txtTemperatureTo.ReadOnly = True
        Me.txtTemperatureTo.Size = New System.Drawing.Size(139, 23)
        Me.txtTemperatureTo.TabIndex = 21
        Me.txtTemperatureTo.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "From:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lstTemperatureTo)
        Me.GroupBox5.Location = New System.Drawing.Point(175, 7)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(104, 128)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "To"
        '
        'lstTemperatureTo
        '
        Me.lstTemperatureTo.FormattingEnabled = True
        Me.lstTemperatureTo.ItemHeight = 15
        Me.lstTemperatureTo.Items.AddRange(New Object() {"Celsius", "Fahrenheit"})
        Me.lstTemperatureTo.Location = New System.Drawing.Point(10, 20)
        Me.lstTemperatureTo.Name = "lstTemperatureTo"
        Me.lstTemperatureTo.Size = New System.Drawing.Size(86, 94)
        Me.lstTemperatureTo.Sorted = True
        Me.lstTemperatureTo.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstTemperatureFrom)
        Me.GroupBox4.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 128)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "From"
        '
        'lstTemperatureFrom
        '
        Me.lstTemperatureFrom.FormattingEnabled = True
        Me.lstTemperatureFrom.ItemHeight = 15
        Me.lstTemperatureFrom.Items.AddRange(New Object() {"Celsius", "Fahrenheit"})
        Me.lstTemperatureFrom.Location = New System.Drawing.Point(10, 20)
        Me.lstTemperatureFrom.Name = "lstTemperatureFrom"
        Me.lstTemperatureFrom.Size = New System.Drawing.Size(86, 94)
        Me.lstTemperatureFrom.Sorted = True
        Me.lstTemperatureFrom.TabIndex = 15
        '
        'TabComputer
        '
        Me.TabComputer.BackColor = System.Drawing.SystemColors.Control
        Me.TabComputer.Controls.Add(Me.Label2)
        Me.TabComputer.Controls.Add(Me.GroupBox10)
        Me.TabComputer.Controls.Add(Me.GroupBox11)
        Me.TabComputer.Controls.Add(Me.GroupBox12)
        Me.TabComputer.Location = New System.Drawing.Point(4, 24)
        Me.TabComputer.Name = "TabComputer"
        Me.TabComputer.Padding = New System.Windows.Forms.Padding(3)
        Me.TabComputer.Size = New System.Drawing.Size(313, 302)
        Me.TabComputer.TabIndex = 3
        Me.TabComputer.Text = "Computer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = ">>"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label15)
        Me.GroupBox10.Controls.Add(Me.Label14)
        Me.GroupBox10.Controls.Add(Me.lblBytesTo)
        Me.GroupBox10.Controls.Add(Me.Label4)
        Me.GroupBox10.Controls.Add(Me.txtBytes1000To)
        Me.GroupBox10.Controls.Add(Me.lblByteTo)
        Me.GroupBox10.Controls.Add(Me.lblByteFrom)
        Me.GroupBox10.Controls.Add(Me.Label9)
        Me.GroupBox10.Controls.Add(Me.txtByteTo)
        Me.GroupBox10.Controls.Add(Me.txtByteFrom)
        Me.GroupBox10.Controls.Add(Me.Label10)
        Me.GroupBox10.Location = New System.Drawing.Point(10, 165)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(292, 130)
        Me.GroupBox10.TabIndex = 21
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Convert"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 15)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Kilo = 1000"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(4, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 15)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Kilo = 1024"
        '
        'lblBytesTo
        '
        Me.lblBytesTo.AutoSize = True
        Me.lblBytesTo.Location = New System.Drawing.Point(193, 108)
        Me.lblBytesTo.Name = "lblBytesTo"
        Me.lblBytesTo.Size = New System.Drawing.Size(0, 15)
        Me.lblBytesTo.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "To:"
        Me.ToolTip.SetToolTip(Me.Label4, "Kilo = 1000")
        '
        'txtBytes1000To
        '
        Me.txtBytes1000To.Location = New System.Drawing.Point(48, 104)
        Me.txtBytes1000To.Name = "txtBytes1000To"
        Me.txtBytes1000To.ReadOnly = True
        Me.txtBytes1000To.Size = New System.Drawing.Size(139, 23)
        Me.txtBytes1000To.TabIndex = 25
        Me.txtBytes1000To.TabStop = False
        Me.ToolTip.SetToolTip(Me.txtBytes1000To, "Kilo = 1000")
        '
        'lblByteTo
        '
        Me.lblByteTo.AutoSize = True
        Me.lblByteTo.Location = New System.Drawing.Point(192, 66)
        Me.lblByteTo.Name = "lblByteTo"
        Me.lblByteTo.Size = New System.Drawing.Size(0, 15)
        Me.lblByteTo.TabIndex = 24
        '
        'lblByteFrom
        '
        Me.lblByteFrom.AutoSize = True
        Me.lblByteFrom.Location = New System.Drawing.Point(192, 23)
        Me.lblByteFrom.Name = "lblByteFrom"
        Me.lblByteFrom.Size = New System.Drawing.Size(0, 15)
        Me.lblByteFrom.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 15)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "To:"
        Me.ToolTip.SetToolTip(Me.Label9, "Kilo = 1024")
        '
        'txtByteTo
        '
        Me.txtByteTo.Location = New System.Drawing.Point(47, 62)
        Me.txtByteTo.Name = "txtByteTo"
        Me.txtByteTo.ReadOnly = True
        Me.txtByteTo.Size = New System.Drawing.Size(139, 23)
        Me.txtByteTo.TabIndex = 21
        Me.txtByteTo.TabStop = False
        Me.ToolTip.SetToolTip(Me.txtByteTo, "Kilo = 1024")
        '
        'txtByteFrom
        '
        Me.txtByteFrom.Location = New System.Drawing.Point(47, 20)
        Me.txtByteFrom.Name = "txtByteFrom"
        Me.txtByteFrom.Size = New System.Drawing.Size(139, 23)
        Me.txtByteFrom.TabIndex = 19
        Me.txtByteFrom.Text = "1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "From:"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.lstByteTo)
        Me.GroupBox11.Location = New System.Drawing.Point(175, 7)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(127, 159)
        Me.GroupBox11.TabIndex = 20
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "To"
        '
        'lstByteTo
        '
        Me.lstByteTo.FormattingEnabled = True
        Me.lstByteTo.ItemHeight = 15
        Me.lstByteTo.Items.AddRange(New Object() {"byte", "kilobyte (KB)", "megabyte (MB)", "gigabyte (GB)", "terabyte (TB)", "petabyte (PB)"})
        Me.lstByteTo.Location = New System.Drawing.Point(10, 18)
        Me.lstByteTo.Name = "lstByteTo"
        Me.lstByteTo.Size = New System.Drawing.Size(104, 124)
        Me.lstByteTo.TabIndex = 16
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.lstByteFrom)
        Me.GroupBox12.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(127, 159)
        Me.GroupBox12.TabIndex = 19
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "From"
        '
        'lstByteFrom
        '
        Me.lstByteFrom.FormattingEnabled = True
        Me.lstByteFrom.ItemHeight = 15
        Me.lstByteFrom.Items.AddRange(New Object() {"byte", "kilobyte (KB)", "megabyte (MB)", "gigabyte (GB)", "terabyte (TB)", "petabyte (PB)"})
        Me.lstByteFrom.Location = New System.Drawing.Point(10, 20)
        Me.lstByteFrom.Name = "lstByteFrom"
        Me.lstByteFrom.Size = New System.Drawing.Size(104, 124)
        Me.lstByteFrom.TabIndex = 15
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiHelp})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(322, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiFile.Text = "&File"
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.Size = New System.Drawing.Size(92, 22)
        Me.tsmiExit.Text = "E&xit"
        '
        'tsmiHelp
        '
        Me.tsmiHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAboutConverter})
        Me.tsmiHelp.Name = "tsmiHelp"
        Me.tsmiHelp.Size = New System.Drawing.Size(44, 20)
        Me.tsmiHelp.Text = "&Help"
        '
        'tsmiAboutConverter
        '
        Me.tsmiAboutConverter.Name = "tsmiAboutConverter"
        Me.tsmiAboutConverter.Size = New System.Drawing.Size(162, 22)
        Me.tsmiAboutConverter.Text = "&About Converter"
        '
        'frmMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 360)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMainForm"
        Me.Text = "Converter"
        Me.TabControl.ResumeLayout(False)
        Me.tabLength.ResumeLayout(False)
        Me.tabLength.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tabWeight.ResumeLayout(False)
        Me.tabWeight.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.tabTemperature.ResumeLayout(False)
        Me.tabTemperature.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabComputer.ResumeLayout(False)
        Me.TabComputer.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabLength As System.Windows.Forms.TabPage
    Friend WithEvents tabTemperature As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstLengthFrom As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstLengthTo As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLengthToDescription As System.Windows.Forms.Label
    Friend WithEvents lblLengthFromDescription As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLenghtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtLengthFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsmiAboutConverter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTemperatureFrom As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lstTemperatureTo As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTemperatureTo As System.Windows.Forms.Label
    Friend WithEvents lblTemperatureFrom As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTemperatureTo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTemperatureFrom As System.Windows.Forms.TextBox
    Friend WithEvents tabWeight As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lblWeightToDescription As System.Windows.Forms.Label
    Friend WithEvents lblWeightFromDescription As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtWeightTo As System.Windows.Forms.TextBox
    Friend WithEvents txtWeightFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents lstWeightTo As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents lstWeightFrom As System.Windows.Forms.ListBox
    Friend WithEvents TabComputer As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents lblByteTo As System.Windows.Forms.Label
    Friend WithEvents lblByteFrom As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtByteTo As System.Windows.Forms.TextBox
    Friend WithEvents txtByteFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents lstByteTo As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents lstByteFrom As System.Windows.Forms.ListBox
    Friend WithEvents lblBytesTo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBytes1000To As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
