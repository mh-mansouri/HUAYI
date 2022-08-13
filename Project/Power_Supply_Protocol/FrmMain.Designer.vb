<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMMain))
        Me.MSCom = New System.IO.Ports.SerialPort(Me.components)
        Me.NumUpDown_VP_Set_Voltage = New System.Windows.Forms.NumericUpDown
        Me.Lbl_VP_SetVolt = New System.Windows.Forms.Label
        Me.Lbl_VP_SetCurrent = New System.Windows.Forms.Label
        Me.NumUpDown_VP_Set_Current = New System.Windows.Forms.NumericUpDown
        Me.Lbl_VP_GetCurrent = New System.Windows.Forms.Label
        Me.NumUpDown_VP_Get_Current = New System.Windows.Forms.NumericUpDown
        Me.Lbl_VP_GetVoltage = New System.Windows.Forms.Label
        Me.NumUpDown_VP_Get_Voltage = New System.Windows.Forms.NumericUpDown
        Me.Txt_VP_ErrTable = New System.Windows.Forms.TextBox
        Me.TmrHandler = New System.Windows.Forms.Timer(Me.components)
        Me.GrpBox_VirtualPower = New System.Windows.Forms.GroupBox
        Me.GrpBox_RealPower = New System.Windows.Forms.GroupBox
        Me.Lbl_RP_GetVolt = New System.Windows.Forms.Label
        Me.Txt_RP_ErrTable = New System.Windows.Forms.TextBox
        Me.NumUpDown_RP_Get_Voltage = New System.Windows.Forms.NumericUpDown
        Me.Lbl_RP_SetCurrent = New System.Windows.Forms.Label
        Me.NumUpDown_RP_Get_Current = New System.Windows.Forms.NumericUpDown
        Me.NumUpDown_RP_Set_Current = New System.Windows.Forms.NumericUpDown
        Me.Lbl_RP_GetCurrent = New System.Windows.Forms.Label
        Me.Lbl_RP_SetVolt = New System.Windows.Forms.Label
        Me.NumUpDown_RP_Set_Voltage = New System.Windows.Forms.NumericUpDown
        Me.GrpBox_Machine_Selection = New System.Windows.Forms.GroupBox
        Me.RdoBtn_VirtualMachine = New System.Windows.Forms.RadioButton
        Me.RdoBtn_RealMachine = New System.Windows.Forms.RadioButton
        CType(Me.NumUpDown_VP_Set_Voltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown_VP_Set_Current, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown_VP_Get_Current, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown_VP_Get_Voltage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox_VirtualPower.SuspendLayout()
        Me.GrpBox_RealPower.SuspendLayout()
        CType(Me.NumUpDown_RP_Get_Voltage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown_RP_Get_Current, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown_RP_Set_Current, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown_RP_Set_Voltage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBox_Machine_Selection.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSCom
        '
        '
        'NumUpDown_VP_Set_Voltage
        '
        Me.NumUpDown_VP_Set_Voltage.DecimalPlaces = 1
        Me.NumUpDown_VP_Set_Voltage.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumUpDown_VP_Set_Voltage.Location = New System.Drawing.Point(81, 14)
        Me.NumUpDown_VP_Set_Voltage.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumUpDown_VP_Set_Voltage.Name = "NumUpDown_VP_Set_Voltage"
        Me.NumUpDown_VP_Set_Voltage.Size = New System.Drawing.Size(96, 20)
        Me.NumUpDown_VP_Set_Voltage.TabIndex = 0
        '
        'Lbl_VP_SetVolt
        '
        Me.Lbl_VP_SetVolt.AutoSize = True
        Me.Lbl_VP_SetVolt.Location = New System.Drawing.Point(6, 16)
        Me.Lbl_VP_SetVolt.Name = "Lbl_VP_SetVolt"
        Me.Lbl_VP_SetVolt.Size = New System.Drawing.Size(68, 13)
        Me.Lbl_VP_SetVolt.TabIndex = 1
        Me.Lbl_VP_SetVolt.Text = "Set Voltage :"
        '
        'Lbl_VP_SetCurrent
        '
        Me.Lbl_VP_SetCurrent.AutoSize = True
        Me.Lbl_VP_SetCurrent.Location = New System.Drawing.Point(6, 42)
        Me.Lbl_VP_SetCurrent.Name = "Lbl_VP_SetCurrent"
        Me.Lbl_VP_SetCurrent.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_VP_SetCurrent.TabIndex = 3
        Me.Lbl_VP_SetCurrent.Text = "Set Current :"
        '
        'NumUpDown_VP_Set_Current
        '
        Me.NumUpDown_VP_Set_Current.DecimalPlaces = 1
        Me.NumUpDown_VP_Set_Current.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumUpDown_VP_Set_Current.Location = New System.Drawing.Point(81, 40)
        Me.NumUpDown_VP_Set_Current.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumUpDown_VP_Set_Current.Name = "NumUpDown_VP_Set_Current"
        Me.NumUpDown_VP_Set_Current.Size = New System.Drawing.Size(96, 20)
        Me.NumUpDown_VP_Set_Current.TabIndex = 1
        '
        'Lbl_VP_GetCurrent
        '
        Me.Lbl_VP_GetCurrent.AutoSize = True
        Me.Lbl_VP_GetCurrent.Location = New System.Drawing.Point(6, 94)
        Me.Lbl_VP_GetCurrent.Name = "Lbl_VP_GetCurrent"
        Me.Lbl_VP_GetCurrent.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_VP_GetCurrent.TabIndex = 7
        Me.Lbl_VP_GetCurrent.Text = "Get Current :"
        '
        'NumUpDown_VP_Get_Current
        '
        Me.NumUpDown_VP_Get_Current.DecimalPlaces = 1
        Me.NumUpDown_VP_Get_Current.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumUpDown_VP_Get_Current.Location = New System.Drawing.Point(81, 92)
        Me.NumUpDown_VP_Get_Current.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumUpDown_VP_Get_Current.Name = "NumUpDown_VP_Get_Current"
        Me.NumUpDown_VP_Get_Current.ReadOnly = True
        Me.NumUpDown_VP_Get_Current.Size = New System.Drawing.Size(96, 20)
        Me.NumUpDown_VP_Get_Current.TabIndex = 6
        '
        'Lbl_VP_GetVoltage
        '
        Me.Lbl_VP_GetVoltage.AutoSize = True
        Me.Lbl_VP_GetVoltage.Location = New System.Drawing.Point(6, 68)
        Me.Lbl_VP_GetVoltage.Name = "Lbl_VP_GetVoltage"
        Me.Lbl_VP_GetVoltage.Size = New System.Drawing.Size(69, 13)
        Me.Lbl_VP_GetVoltage.TabIndex = 5
        Me.Lbl_VP_GetVoltage.Text = "Get Voltage :"
        '
        'NumUpDown_VP_Get_Voltage
        '
        Me.NumUpDown_VP_Get_Voltage.DecimalPlaces = 1
        Me.NumUpDown_VP_Get_Voltage.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumUpDown_VP_Get_Voltage.Location = New System.Drawing.Point(81, 66)
        Me.NumUpDown_VP_Get_Voltage.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumUpDown_VP_Get_Voltage.Name = "NumUpDown_VP_Get_Voltage"
        Me.NumUpDown_VP_Get_Voltage.ReadOnly = True
        Me.NumUpDown_VP_Get_Voltage.Size = New System.Drawing.Size(96, 20)
        Me.NumUpDown_VP_Get_Voltage.TabIndex = 4
        '
        'Txt_VP_ErrTable
        '
        Me.Txt_VP_ErrTable.Location = New System.Drawing.Point(9, 118)
        Me.Txt_VP_ErrTable.Multiline = True
        Me.Txt_VP_ErrTable.Name = "Txt_VP_ErrTable"
        Me.Txt_VP_ErrTable.ReadOnly = True
        Me.Txt_VP_ErrTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_VP_ErrTable.Size = New System.Drawing.Size(168, 145)
        Me.Txt_VP_ErrTable.TabIndex = 8
        '
        'TmrHandler
        '
        '
        'GrpBox_VirtualPower
        '
        Me.GrpBox_VirtualPower.Controls.Add(Me.Lbl_VP_SetVolt)
        Me.GrpBox_VirtualPower.Controls.Add(Me.Txt_VP_ErrTable)
        Me.GrpBox_VirtualPower.Controls.Add(Me.NumUpDown_VP_Set_Voltage)
        Me.GrpBox_VirtualPower.Controls.Add(Me.Lbl_VP_GetCurrent)
        Me.GrpBox_VirtualPower.Controls.Add(Me.NumUpDown_VP_Set_Current)
        Me.GrpBox_VirtualPower.Controls.Add(Me.NumUpDown_VP_Get_Current)
        Me.GrpBox_VirtualPower.Controls.Add(Me.Lbl_VP_SetCurrent)
        Me.GrpBox_VirtualPower.Controls.Add(Me.Lbl_VP_GetVoltage)
        Me.GrpBox_VirtualPower.Controls.Add(Me.NumUpDown_VP_Get_Voltage)
        Me.GrpBox_VirtualPower.Location = New System.Drawing.Point(205, 12)
        Me.GrpBox_VirtualPower.Name = "GrpBox_VirtualPower"
        Me.GrpBox_VirtualPower.Size = New System.Drawing.Size(187, 269)
        Me.GrpBox_VirtualPower.TabIndex = 9
        Me.GrpBox_VirtualPower.TabStop = False
        Me.GrpBox_VirtualPower.Text = "Virtual Power"
        '
        'GrpBox_RealPower
        '
        Me.GrpBox_RealPower.Controls.Add(Me.Lbl_RP_GetVolt)
        Me.GrpBox_RealPower.Controls.Add(Me.Txt_RP_ErrTable)
        Me.GrpBox_RealPower.Controls.Add(Me.NumUpDown_RP_Get_Voltage)
        Me.GrpBox_RealPower.Controls.Add(Me.Lbl_RP_SetCurrent)
        Me.GrpBox_RealPower.Controls.Add(Me.NumUpDown_RP_Get_Current)
        Me.GrpBox_RealPower.Controls.Add(Me.NumUpDown_RP_Set_Current)
        Me.GrpBox_RealPower.Controls.Add(Me.Lbl_RP_GetCurrent)
        Me.GrpBox_RealPower.Controls.Add(Me.Lbl_RP_SetVolt)
        Me.GrpBox_RealPower.Controls.Add(Me.NumUpDown_RP_Set_Voltage)
        Me.GrpBox_RealPower.Location = New System.Drawing.Point(12, 12)
        Me.GrpBox_RealPower.Name = "GrpBox_RealPower"
        Me.GrpBox_RealPower.Size = New System.Drawing.Size(187, 269)
        Me.GrpBox_RealPower.TabIndex = 10
        Me.GrpBox_RealPower.TabStop = False
        Me.GrpBox_RealPower.Text = "Real Power"
        '
        'Lbl_RP_GetVolt
        '
        Me.Lbl_RP_GetVolt.AutoSize = True
        Me.Lbl_RP_GetVolt.Location = New System.Drawing.Point(6, 16)
        Me.Lbl_RP_GetVolt.Name = "Lbl_RP_GetVolt"
        Me.Lbl_RP_GetVolt.Size = New System.Drawing.Size(69, 13)
        Me.Lbl_RP_GetVolt.TabIndex = 1
        Me.Lbl_RP_GetVolt.Text = "Get Voltage :"
        '
        'Txt_RP_ErrTable
        '
        Me.Txt_RP_ErrTable.Location = New System.Drawing.Point(9, 118)
        Me.Txt_RP_ErrTable.Multiline = True
        Me.Txt_RP_ErrTable.Name = "Txt_RP_ErrTable"
        Me.Txt_RP_ErrTable.ReadOnly = True
        Me.Txt_RP_ErrTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_RP_ErrTable.Size = New System.Drawing.Size(168, 145)
        Me.Txt_RP_ErrTable.TabIndex = 8
        '
        'NumUpDown_RP_Get_Voltage
        '
        Me.NumUpDown_RP_Get_Voltage.DecimalPlaces = 1
        Me.NumUpDown_RP_Get_Voltage.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumUpDown_RP_Get_Voltage.Location = New System.Drawing.Point(81, 14)
        Me.NumUpDown_RP_Get_Voltage.Name = "NumUpDown_RP_Get_Voltage"
        Me.NumUpDown_RP_Get_Voltage.ReadOnly = True
        Me.NumUpDown_RP_Get_Voltage.Size = New System.Drawing.Size(96, 20)
        Me.NumUpDown_RP_Get_Voltage.TabIndex = 0
        '
        'Lbl_RP_SetCurrent
        '
        Me.Lbl_RP_SetCurrent.AutoSize = True
        Me.Lbl_RP_SetCurrent.Location = New System.Drawing.Point(6, 94)
        Me.Lbl_RP_SetCurrent.Name = "Lbl_RP_SetCurrent"
        Me.Lbl_RP_SetCurrent.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_RP_SetCurrent.TabIndex = 7
        Me.Lbl_RP_SetCurrent.Text = "Set Current :"
        '
        'NumUpDown_RP_Get_Current
        '
        Me.NumUpDown_RP_Get_Current.DecimalPlaces = 1
        Me.NumUpDown_RP_Get_Current.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumUpDown_RP_Get_Current.Location = New System.Drawing.Point(81, 40)
        Me.NumUpDown_RP_Get_Current.Name = "NumUpDown_RP_Get_Current"
        Me.NumUpDown_RP_Get_Current.ReadOnly = True
        Me.NumUpDown_RP_Get_Current.Size = New System.Drawing.Size(96, 20)
        Me.NumUpDown_RP_Get_Current.TabIndex = 1
        '
        'NumUpDown_RP_Set_Current
        '
        Me.NumUpDown_RP_Set_Current.DecimalPlaces = 1
        Me.NumUpDown_RP_Set_Current.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumUpDown_RP_Set_Current.Location = New System.Drawing.Point(81, 92)
        Me.NumUpDown_RP_Set_Current.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumUpDown_RP_Set_Current.Name = "NumUpDown_RP_Set_Current"
        Me.NumUpDown_RP_Set_Current.Size = New System.Drawing.Size(96, 20)
        Me.NumUpDown_RP_Set_Current.TabIndex = 6
        '
        'Lbl_RP_GetCurrent
        '
        Me.Lbl_RP_GetCurrent.AutoSize = True
        Me.Lbl_RP_GetCurrent.Location = New System.Drawing.Point(6, 42)
        Me.Lbl_RP_GetCurrent.Name = "Lbl_RP_GetCurrent"
        Me.Lbl_RP_GetCurrent.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_RP_GetCurrent.TabIndex = 3
        Me.Lbl_RP_GetCurrent.Text = "Get Current :"
        '
        'Lbl_RP_SetVolt
        '
        Me.Lbl_RP_SetVolt.AutoSize = True
        Me.Lbl_RP_SetVolt.Location = New System.Drawing.Point(6, 68)
        Me.Lbl_RP_SetVolt.Name = "Lbl_RP_SetVolt"
        Me.Lbl_RP_SetVolt.Size = New System.Drawing.Size(68, 13)
        Me.Lbl_RP_SetVolt.TabIndex = 5
        Me.Lbl_RP_SetVolt.Text = "Set Voltage :"
        '
        'NumUpDown_RP_Set_Voltage
        '
        Me.NumUpDown_RP_Set_Voltage.DecimalPlaces = 1
        Me.NumUpDown_RP_Set_Voltage.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumUpDown_RP_Set_Voltage.Location = New System.Drawing.Point(81, 66)
        Me.NumUpDown_RP_Set_Voltage.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumUpDown_RP_Set_Voltage.Name = "NumUpDown_RP_Set_Voltage"
        Me.NumUpDown_RP_Set_Voltage.Size = New System.Drawing.Size(96, 20)
        Me.NumUpDown_RP_Set_Voltage.TabIndex = 4
        '
        'GrpBox_Machine_Selection
        '
        Me.GrpBox_Machine_Selection.Controls.Add(Me.RdoBtn_VirtualMachine)
        Me.GrpBox_Machine_Selection.Controls.Add(Me.RdoBtn_RealMachine)
        Me.GrpBox_Machine_Selection.Location = New System.Drawing.Point(12, 287)
        Me.GrpBox_Machine_Selection.Name = "GrpBox_Machine_Selection"
        Me.GrpBox_Machine_Selection.Size = New System.Drawing.Size(380, 50)
        Me.GrpBox_Machine_Selection.TabIndex = 11
        Me.GrpBox_Machine_Selection.TabStop = False
        Me.GrpBox_Machine_Selection.Text = "Machine Selection"
        '
        'RdoBtn_VirtualMachine
        '
        Me.RdoBtn_VirtualMachine.AutoSize = True
        Me.RdoBtn_VirtualMachine.Checked = True
        Me.RdoBtn_VirtualMachine.Location = New System.Drawing.Point(274, 19)
        Me.RdoBtn_VirtualMachine.Name = "RdoBtn_VirtualMachine"
        Me.RdoBtn_VirtualMachine.Size = New System.Drawing.Size(87, 17)
        Me.RdoBtn_VirtualMachine.TabIndex = 1
        Me.RdoBtn_VirtualMachine.TabStop = True
        Me.RdoBtn_VirtualMachine.Text = "Virtual Power"
        Me.RdoBtn_VirtualMachine.UseVisualStyleBackColor = True
        '
        'RdoBtn_RealMachine
        '
        Me.RdoBtn_RealMachine.AutoSize = True
        Me.RdoBtn_RealMachine.Location = New System.Drawing.Point(9, 19)
        Me.RdoBtn_RealMachine.Name = "RdoBtn_RealMachine"
        Me.RdoBtn_RealMachine.Size = New System.Drawing.Size(80, 17)
        Me.RdoBtn_RealMachine.TabIndex = 0
        Me.RdoBtn_RealMachine.Text = "Real Power"
        Me.RdoBtn_RealMachine.UseVisualStyleBackColor = True
        '
        'FRMMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 349)
        Me.Controls.Add(Me.GrpBox_Machine_Selection)
        Me.Controls.Add(Me.GrpBox_RealPower)
        Me.Controls.Add(Me.GrpBox_VirtualPower)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMMain"
        Me.Text = "Main Form"
        CType(Me.NumUpDown_VP_Set_Voltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown_VP_Set_Current, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown_VP_Get_Current, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown_VP_Get_Voltage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox_VirtualPower.ResumeLayout(False)
        Me.GrpBox_VirtualPower.PerformLayout()
        Me.GrpBox_RealPower.ResumeLayout(False)
        Me.GrpBox_RealPower.PerformLayout()
        CType(Me.NumUpDown_RP_Get_Voltage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown_RP_Get_Current, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown_RP_Set_Current, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown_RP_Set_Voltage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBox_Machine_Selection.ResumeLayout(False)
        Me.GrpBox_Machine_Selection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MSCom As System.IO.Ports.SerialPort
    Friend WithEvents NumUpDown_VP_Set_Voltage As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_VP_SetVolt As System.Windows.Forms.Label
    Friend WithEvents Lbl_VP_SetCurrent As System.Windows.Forms.Label
    Friend WithEvents NumUpDown_VP_Set_Current As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_VP_GetCurrent As System.Windows.Forms.Label
    Friend WithEvents NumUpDown_VP_Get_Current As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_VP_GetVoltage As System.Windows.Forms.Label
    Friend WithEvents NumUpDown_VP_Get_Voltage As System.Windows.Forms.NumericUpDown
    Friend WithEvents Txt_VP_ErrTable As System.Windows.Forms.TextBox
    Friend WithEvents TmrHandler As System.Windows.Forms.Timer
    Friend WithEvents GrpBox_VirtualPower As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBox_RealPower As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_RP_GetVolt As System.Windows.Forms.Label
    Friend WithEvents Txt_RP_ErrTable As System.Windows.Forms.TextBox
    Friend WithEvents NumUpDown_RP_Get_Voltage As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_RP_SetCurrent As System.Windows.Forms.Label
    Friend WithEvents NumUpDown_RP_Get_Current As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumUpDown_RP_Set_Current As System.Windows.Forms.NumericUpDown
    Friend WithEvents Lbl_RP_GetCurrent As System.Windows.Forms.Label
    Friend WithEvents Lbl_RP_SetVolt As System.Windows.Forms.Label
    Friend WithEvents NumUpDown_RP_Set_Voltage As System.Windows.Forms.NumericUpDown
    Friend WithEvents GrpBox_Machine_Selection As System.Windows.Forms.GroupBox
    Friend WithEvents RdoBtn_VirtualMachine As System.Windows.Forms.RadioButton
    Friend WithEvents RdoBtn_RealMachine As System.Windows.Forms.RadioButton

End Class
