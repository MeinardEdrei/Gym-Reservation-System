<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Homepage_Module
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage_Module))
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.chkShowPass = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelExit = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.labelUser = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuditLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_System_DatabaseDataSet2 = New Gym_Reservation_System.Reservation_System_DatabaseDataSet2()
        Me.AuditLogTableAdapter = New Gym_Reservation_System.Reservation_System_DatabaseDataSet2TableAdapters.AuditLogTableAdapter()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelClock = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelLogin.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelExit.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_System_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelClock.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelLogin
        '
        Me.panelLogin.BackColor = System.Drawing.Color.Black
        Me.panelLogin.Controls.Add(Me.chkShowPass)
        Me.panelLogin.Controls.Add(Me.txtPassword)
        Me.panelLogin.Controls.Add(Me.txtUsername)
        Me.panelLogin.Controls.Add(Me.btnLogin)
        Me.panelLogin.Controls.Add(Me.PictureBox6)
        Me.panelLogin.Controls.Add(Me.PictureBox5)
        Me.panelLogin.Controls.Add(Me.PictureBox7)
        Me.panelLogin.Controls.Add(Me.Label3)
        Me.panelLogin.Controls.Add(Me.PictureBox8)
        Me.panelLogin.Controls.Add(Me.Label4)
        Me.panelLogin.Location = New System.Drawing.Point(574, 53)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(531, 684)
        Me.panelLogin.TabIndex = 3
        '
        'chkShowPass
        '
        Me.chkShowPass.AutoSize = True
        Me.chkShowPass.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.chkShowPass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkShowPass.Location = New System.Drawing.Point(314, 486)
        Me.chkShowPass.Name = "chkShowPass"
        Me.chkShowPass.Size = New System.Drawing.Size(140, 22)
        Me.chkShowPass.TabIndex = 39
        Me.chkShowPass.Text = "Show Password"
        Me.chkShowPass.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.txtPassword.Location = New System.Drawing.Point(103, 435)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(343, 36)
        Me.txtPassword.TabIndex = 35
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(103, 340)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(343, 36)
        Me.txtUsername.TabIndex = 34
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(297, 547)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(164, 60)
        Me.btnLogin.TabIndex = 33
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(311, 54)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(92, 70)
        Me.PictureBox6.TabIndex = 26
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(72, 282)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(404, 223)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.hsu_logo
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(234, 54)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(71, 65)
        Me.PictureBox7.TabIndex = 25
        Me.PictureBox7.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 34.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(61, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(446, 65)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "UNIVERSITY OF "
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.umak_logo
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Location = New System.Drawing.Point(148, 54)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(70, 65)
        Me.PictureBox8.TabIndex = 24
        Me.PictureBox8.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 34.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(100, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 65)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "MAKATI GYM"
        '
        'panelExit
        '
        Me.panelExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.panelExit.Controls.Add(Me.btnMinimize)
        Me.panelExit.Controls.Add(Me.btnExit)
        Me.panelExit.Location = New System.Drawing.Point(0, -2)
        Me.panelExit.Name = "panelExit"
        Me.panelExit.Size = New System.Drawing.Size(1103, 55)
        Me.panelExit.TabIndex = 37
        '
        'btnMinimize
        '
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(947, 2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(58, 52)
        Me.btnMinimize.TabIndex = 1
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(1011, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 52)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.Black
        Me.panelMenu.Controls.Add(Me.labelUser)
        Me.panelMenu.Controls.Add(Me.Label)
        Me.panelMenu.Controls.Add(Me.PictureBox9)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.PictureBox10)
        Me.panelMenu.Controls.Add(Me.PictureBox11)
        Me.panelMenu.Controls.Add(Me.btnArchive)
        Me.panelMenu.Controls.Add(Me.btnReservation)
        Me.panelMenu.Location = New System.Drawing.Point(0, 53)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(329, 684)
        Me.panelMenu.TabIndex = 38
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.BackColor = System.Drawing.Color.Black
        Me.labelUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.labelUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelUser.Location = New System.Drawing.Point(202, 149)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(71, 26)
        Me.labelUser.TabIndex = 46
        Me.labelUser.Text = "User!"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Black
        Me.Label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.Label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label.Location = New System.Drawing.Point(32, 149)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(178, 26)
        Me.Label.TabIndex = 45
        Me.Label.Text = "Welcome Back,"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(199, 44)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(92, 70)
        Me.PictureBox9.TabIndex = 42
        Me.PictureBox9.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(7, 405)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(314, 99)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.hsu_logo
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(122, 46)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(71, 65)
        Me.PictureBox10.TabIndex = 41
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.umak_logo
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox11.Location = New System.Drawing.Point(37, 46)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(70, 65)
        Me.PictureBox11.TabIndex = 40
        Me.PictureBox11.TabStop = False
        '
        'btnArchive
        '
        Me.btnArchive.BackgroundImage = CType(resources.GetObject("btnArchive.BackgroundImage"), System.Drawing.Image)
        Me.btnArchive.FlatAppearance.BorderSize = 0
        Me.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchive.Location = New System.Drawing.Point(7, 304)
        Me.btnArchive.Name = "btnArchive"
        Me.btnArchive.Size = New System.Drawing.Size(314, 99)
        Me.btnArchive.TabIndex = 1
        Me.btnArchive.UseVisualStyleBackColor = True
        '
        'btnReservation
        '
        Me.btnReservation.BackgroundImage = CType(resources.GetObject("btnReservation.BackgroundImage"), System.Drawing.Image)
        Me.btnReservation.FlatAppearance.BorderSize = 0
        Me.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservation.Location = New System.Drawing.Point(8, 207)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(313, 99)
        Me.btnReservation.TabIndex = 0
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.AutoGenerateColumns = False
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeDataGridViewTextBoxColumn, Me.AccountDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn})
        Me.dgvRecords.DataSource = Me.AuditLogBindingSource
        Me.dgvRecords.Location = New System.Drawing.Point(435, 206)
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.ReadOnly = True
        Me.dgvRecords.Size = New System.Drawing.Size(599, 485)
        Me.dgvRecords.TabIndex = 39
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TimeDataGridViewTextBoxColumn.Width = 200
        '
        'AccountDataGridViewTextBoxColumn
        '
        Me.AccountDataGridViewTextBoxColumn.DataPropertyName = "Account"
        Me.AccountDataGridViewTextBoxColumn.HeaderText = "Account"
        Me.AccountDataGridViewTextBoxColumn.Name = "AccountDataGridViewTextBoxColumn"
        Me.AccountDataGridViewTextBoxColumn.ReadOnly = True
        Me.AccountDataGridViewTextBoxColumn.Width = 200
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        Me.PositionDataGridViewTextBoxColumn.Width = 153
        '
        'AuditLogBindingSource
        '
        Me.AuditLogBindingSource.DataMember = "AuditLog"
        Me.AuditLogBindingSource.DataSource = Me.Reservation_System_DatabaseDataSet2
        '
        'Reservation_System_DatabaseDataSet2
        '
        Me.Reservation_System_DatabaseDataSet2.DataSetName = "Reservation_System_DatabaseDataSet2"
        Me.Reservation_System_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuditLogTableAdapter
        '
        Me.AuditLogTableAdapter.ClearBeforeFill = True
        '
        'labelTime
        '
        Me.labelTime.AutoSize = True
        Me.labelTime.BackColor = System.Drawing.Color.Transparent
        Me.labelTime.Font = New System.Drawing.Font("Arial Black", 35.0!, System.Drawing.FontStyle.Bold)
        Me.labelTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelTime.Location = New System.Drawing.Point(41, 15)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(263, 67)
        Me.labelTime.TabIndex = 47
        Me.labelTime.Text = "01:11 PM"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'panelClock
        '
        Me.panelClock.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelClock.Controls.Add(Me.Label2)
        Me.panelClock.Controls.Add(Me.labelTime)
        Me.panelClock.Location = New System.Drawing.Point(328, 53)
        Me.panelClock.Name = "panelClock"
        Me.panelClock.Size = New System.Drawing.Size(775, 122)
        Me.panelClock.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(48, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 27)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "CURRENT TIME"
        '
        'Homepage_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.RESERVATION___bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1104, 737)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelExit)
        Me.Controls.Add(Me.dgvRecords)
        Me.Controls.Add(Me.panelClock)
        Me.Controls.Add(Me.panelLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Homepage_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelExit.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_System_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelClock.ResumeLayout(False)
        Me.panelClock.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelLogin As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents panelExit As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents panelMenu As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents btnArchive As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents Reservation_System_DatabaseDataSet2 As Reservation_System_DatabaseDataSet2
    Friend WithEvents AuditLogBindingSource As BindingSource
    Friend WithEvents AuditLogTableAdapter As Reservation_System_DatabaseDataSet2TableAdapters.AuditLogTableAdapter
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents labelUser As Label
    Friend WithEvents Label As Label
    Friend WithEvents labelTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelClock As Panel
    Friend WithEvents Label2 As Label
End Class
