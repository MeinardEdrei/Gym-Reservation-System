<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Module))
        Me.panelExit = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnAuditLog = New System.Windows.Forms.Button()
        Me.labelUser = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.dgvAccounts = New System.Windows.Forms.DataGridView()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_System_DatabaseDataSet1 = New Gym_Reservation_System.Reservation_System_DatabaseDataSet1()
        Me.panelRegister = New System.Windows.Forms.Panel()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.labelPass = New System.Windows.Forms.Label()
        Me.txtRPassword2 = New System.Windows.Forms.TextBox()
        Me.txtRPassword1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRUsername = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.panelStaff = New System.Windows.Forms.Panel()
        Me.panelID = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.PanelDetails = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.comboboxPosition = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UserAccountsTableAdapter = New Gym_Reservation_System.Reservation_System_DatabaseDataSet1TableAdapters.UserAccountsTableAdapter()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuditLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_System_DatabaseDataSet5 = New Gym_Reservation_System.Reservation_System_DatabaseDataSet5()
        Me.AuditLogTableAdapter = New Gym_Reservation_System.Reservation_System_DatabaseDataSet5TableAdapters.AuditLogTableAdapter()
        Me.panelRecords = New System.Windows.Forms.Panel()
        Me.btnReturn2 = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.panelClock = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnDeleteAll = New System.Windows.Forms.PictureBox()
        Me.panelExit.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_System_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRegister.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelStaff.SuspendLayout()
        Me.panelID.SuspendLayout()
        Me.PanelDetails.SuspendLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_System_DatabaseDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRecords.SuspendLayout()
        Me.panelClock.SuspendLayout()
        CType(Me.btnDeleteAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelExit
        '
        Me.panelExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.panelExit.Controls.Add(Me.btnMinimize)
        Me.panelExit.Controls.Add(Me.btnExit)
        Me.panelExit.Location = New System.Drawing.Point(-3, -2)
        Me.panelExit.Name = "panelExit"
        Me.panelExit.Size = New System.Drawing.Size(1106, 55)
        Me.panelExit.TabIndex = 38
        '
        'btnMinimize
        '
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(950, 2)
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
        Me.btnExit.Location = New System.Drawing.Point(1014, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 52)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.Black
        Me.panelMenu.Controls.Add(Me.btnAuditLog)
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
        Me.panelMenu.TabIndex = 39
        '
        'btnAuditLog
        '
        Me.btnAuditLog.BackgroundImage = CType(resources.GetObject("btnAuditLog.BackgroundImage"), System.Drawing.Image)
        Me.btnAuditLog.FlatAppearance.BorderSize = 0
        Me.btnAuditLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuditLog.Location = New System.Drawing.Point(6, 399)
        Me.btnAuditLog.Name = "btnAuditLog"
        Me.btnAuditLog.Size = New System.Drawing.Size(314, 99)
        Me.btnAuditLog.TabIndex = 45
        Me.btnAuditLog.UseVisualStyleBackColor = True
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.BackColor = System.Drawing.Color.Black
        Me.labelUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.labelUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelUser.Location = New System.Drawing.Point(195, 140)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(71, 26)
        Me.labelUser.TabIndex = 44
        Me.labelUser.Text = "User!"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.Color.Black
        Me.Label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.Label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label.Location = New System.Drawing.Point(25, 140)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(178, 26)
        Me.Label.TabIndex = 43
        Me.Label.Text = "Welcome Back,"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(200, 33)
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
        Me.btnLogout.Location = New System.Drawing.Point(7, 497)
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
        Me.PictureBox10.Location = New System.Drawing.Point(117, 36)
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
        Me.PictureBox11.Location = New System.Drawing.Point(30, 36)
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
        Me.btnArchive.Location = New System.Drawing.Point(6, 303)
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
        Me.btnReservation.Location = New System.Drawing.Point(7, 208)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(313, 99)
        Me.btnReservation.TabIndex = 0
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'dgvAccounts
        '
        Me.dgvAccounts.AllowUserToAddRows = False
        Me.dgvAccounts.AllowUserToDeleteRows = False
        Me.dgvAccounts.AutoGenerateColumns = False
        Me.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAccounts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.dgvAccounts.DataSource = Me.UserAccountsBindingSource
        Me.dgvAccounts.Location = New System.Drawing.Point(395, 193)
        Me.dgvAccounts.Name = "dgvAccounts"
        Me.dgvAccounts.Size = New System.Drawing.Size(659, 447)
        Me.dgvAccounts.TabIndex = 40
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.Width = 150
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.Width = 150
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.Width = 150
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 150
        '
        'UserAccountsBindingSource
        '
        Me.UserAccountsBindingSource.DataMember = "UserAccounts"
        Me.UserAccountsBindingSource.DataSource = Me.Reservation_System_DatabaseDataSet1
        '
        'Reservation_System_DatabaseDataSet1
        '
        Me.Reservation_System_DatabaseDataSet1.DataSetName = "Reservation_System_DatabaseDataSet1"
        Me.Reservation_System_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panelRegister
        '
        Me.panelRegister.BackColor = System.Drawing.Color.Black
        Me.panelRegister.Controls.Add(Me.cboPosition)
        Me.panelRegister.Controls.Add(Me.labelPass)
        Me.panelRegister.Controls.Add(Me.txtRPassword2)
        Me.panelRegister.Controls.Add(Me.txtRPassword1)
        Me.panelRegister.Controls.Add(Me.Label2)
        Me.panelRegister.Controls.Add(Me.txtRUsername)
        Me.panelRegister.Controls.Add(Me.btnReturn)
        Me.panelRegister.Controls.Add(Me.btnSignup)
        Me.panelRegister.Controls.Add(Me.PictureBox1)
        Me.panelRegister.Controls.Add(Me.PictureBox2)
        Me.panelRegister.Controls.Add(Me.PictureBox3)
        Me.panelRegister.Controls.Add(Me.PictureBox4)
        Me.panelRegister.Location = New System.Drawing.Point(572, 53)
        Me.panelRegister.Name = "panelRegister"
        Me.panelRegister.Size = New System.Drawing.Size(531, 684)
        Me.panelRegister.TabIndex = 41
        '
        'cboPosition
        '
        Me.cboPosition.BackColor = System.Drawing.SystemColors.Window
        Me.cboPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPosition.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Head", "Employee"})
        Me.cboPosition.Location = New System.Drawing.Point(112, 516)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(340, 40)
        Me.cboPosition.TabIndex = 39
        '
        'labelPass
        '
        Me.labelPass.AutoSize = True
        Me.labelPass.BackColor = System.Drawing.Color.Black
        Me.labelPass.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.labelPass.ForeColor = System.Drawing.Color.Brown
        Me.labelPass.Location = New System.Drawing.Point(261, 566)
        Me.labelPass.Name = "labelPass"
        Me.labelPass.Size = New System.Drawing.Size(202, 21)
        Me.labelPass.TabIndex = 38
        Me.labelPass.Text = "Password do not match."
        '
        'txtRPassword2
        '
        Me.txtRPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRPassword2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPassword2.Location = New System.Drawing.Point(112, 427)
        Me.txtRPassword2.Multiline = True
        Me.txtRPassword2.Name = "txtRPassword2"
        Me.txtRPassword2.Size = New System.Drawing.Size(344, 36)
        Me.txtRPassword2.TabIndex = 37
        '
        'txtRPassword1
        '
        Me.txtRPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRPassword1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRPassword1.Location = New System.Drawing.Point(112, 332)
        Me.txtRPassword1.Multiline = True
        Me.txtRPassword1.Name = "txtRPassword1"
        Me.txtRPassword1.Size = New System.Drawing.Size(344, 36)
        Me.txtRPassword1.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 34.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(71, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 65)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "REGISTRATION"
        '
        'txtRUsername
        '
        Me.txtRUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUsername.Location = New System.Drawing.Point(112, 237)
        Me.txtRUsername.Multiline = True
        Me.txtRUsername.Name = "txtRUsername"
        Me.txtRUsername.Size = New System.Drawing.Size(344, 36)
        Me.txtRUsername.TabIndex = 35
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.BackgroundImage = CType(resources.GetObject("btnReturn.BackgroundImage"), System.Drawing.Image)
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReturn.Location = New System.Drawing.Point(316, 599)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(164, 60)
        Me.btnReturn.TabIndex = 34
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.Transparent
        Me.btnSignup.BackgroundImage = CType(resources.GetObject("btnSignup.BackgroundImage"), System.Drawing.Image)
        Me.btnSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignup.FlatAppearance.BorderSize = 0
        Me.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignup.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnSignup.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSignup.Location = New System.Drawing.Point(147, 599)
        Me.btnSignup.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(164, 60)
        Me.btnSignup.TabIndex = 33
        Me.btnSignup.Text = "REGISTER"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(311, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 70)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(84, 192)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(387, 386)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.hsu_logo
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(234, 36)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 65)
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.umak_logo
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(148, 36)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(70, 65)
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'panelStaff
        '
        Me.panelStaff.BackColor = System.Drawing.Color.Black
        Me.panelStaff.Controls.Add(Me.panelID)
        Me.panelStaff.Controls.Add(Me.btnDelete)
        Me.panelStaff.Controls.Add(Me.btnUpdate)
        Me.panelStaff.Controls.Add(Me.btnRegister)
        Me.panelStaff.Location = New System.Drawing.Point(382, 652)
        Me.panelStaff.Name = "panelStaff"
        Me.panelStaff.Size = New System.Drawing.Size(688, 85)
        Me.panelStaff.TabIndex = 42
        '
        'panelID
        '
        Me.panelID.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.panelID.Controls.Add(Me.Label13)
        Me.panelID.Controls.Add(Me.txtID)
        Me.panelID.Location = New System.Drawing.Point(19, 24)
        Me.panelID.Name = "panelID"
        Me.panelID.Size = New System.Drawing.Size(144, 51)
        Me.panelID.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(3, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 21)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtID.Location = New System.Drawing.Point(38, 11)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(94, 28)
        Me.txtID.TabIndex = 43
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(344, 20)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(164, 60)
        Me.btnDelete.TabIndex = 37
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(177, 20)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(163, 60)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.BackgroundImage = CType(resources.GetObject("btnRegister.BackgroundImage"), System.Drawing.Image)
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegister.Location = New System.Drawing.Point(512, 20)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(164, 60)
        Me.btnRegister.TabIndex = 35
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'PanelDetails
        '
        Me.PanelDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PanelDetails.Controls.Add(Me.txtPassword)
        Me.PanelDetails.Controls.Add(Me.Label8)
        Me.PanelDetails.Controls.Add(Me.Label9)
        Me.PanelDetails.Controls.Add(Me.txtUsername)
        Me.PanelDetails.Controls.Add(Me.comboboxPosition)
        Me.PanelDetails.Controls.Add(Me.Label10)
        Me.PanelDetails.Location = New System.Drawing.Point(415, 564)
        Me.PanelDetails.Name = "PanelDetails"
        Me.PanelDetails.Size = New System.Drawing.Size(626, 113)
        Me.PanelDetails.TabIndex = 47
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtPassword.Location = New System.Drawing.Point(229, 16)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(202, 30)
        Me.txtPassword.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(74, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(286, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtUsername.Location = New System.Drawing.Point(21, 16)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(202, 30)
        Me.txtUsername.TabIndex = 13
        '
        'comboboxPosition
        '
        Me.comboboxPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.comboboxPosition.FormattingEnabled = True
        Me.comboboxPosition.Items.AddRange(New Object() {"Head", "Employee"})
        Me.comboboxPosition.Location = New System.Drawing.Point(437, 17)
        Me.comboboxPosition.Name = "comboboxPosition"
        Me.comboboxPosition.Size = New System.Drawing.Size(170, 28)
        Me.comboboxPosition.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(486, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 21)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Position"
        '
        'UserAccountsTableAdapter
        '
        Me.UserAccountsTableAdapter.ClearBeforeFill = True
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.AutoGenerateColumns = False
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TimeDataGridViewTextBoxColumn, Me.AccountDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn1})
        Me.dgvRecords.DataSource = Me.AuditLogBindingSource
        Me.dgvRecords.Location = New System.Drawing.Point(429, 193)
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.ReadOnly = True
        Me.dgvRecords.Size = New System.Drawing.Size(599, 447)
        Me.dgvRecords.TabIndex = 48
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
        'PositionDataGridViewTextBoxColumn1
        '
        Me.PositionDataGridViewTextBoxColumn1.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn1.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn1.Name = "PositionDataGridViewTextBoxColumn1"
        Me.PositionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PositionDataGridViewTextBoxColumn1.Width = 153
        '
        'AuditLogBindingSource
        '
        Me.AuditLogBindingSource.DataMember = "AuditLog"
        Me.AuditLogBindingSource.DataSource = Me.Reservation_System_DatabaseDataSet5
        '
        'Reservation_System_DatabaseDataSet5
        '
        Me.Reservation_System_DatabaseDataSet5.DataSetName = "Reservation_System_DatabaseDataSet5"
        Me.Reservation_System_DatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuditLogTableAdapter
        '
        Me.AuditLogTableAdapter.ClearBeforeFill = True
        '
        'panelRecords
        '
        Me.panelRecords.BackColor = System.Drawing.Color.Black
        Me.panelRecords.Controls.Add(Me.btnDeleteAll)
        Me.panelRecords.Controls.Add(Me.btnReturn2)
        Me.panelRecords.Controls.Add(Me.btnExport)
        Me.panelRecords.Location = New System.Drawing.Point(382, 652)
        Me.panelRecords.Name = "panelRecords"
        Me.panelRecords.Size = New System.Drawing.Size(688, 85)
        Me.panelRecords.TabIndex = 49
        '
        'btnReturn2
        '
        Me.btnReturn2.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn2.BackgroundImage = CType(resources.GetObject("btnReturn2.BackgroundImage"), System.Drawing.Image)
        Me.btnReturn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn2.FlatAppearance.BorderSize = 0
        Me.btnReturn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReturn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReturn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn2.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnReturn2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReturn2.Location = New System.Drawing.Point(323, 13)
        Me.btnReturn2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn2.Name = "btnReturn2"
        Me.btnReturn2.Size = New System.Drawing.Size(164, 60)
        Me.btnReturn2.TabIndex = 50
        Me.btnReturn2.Text = "RETURN"
        Me.btnReturn2.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Transparent
        Me.btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), System.Drawing.Image)
        Me.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnExport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExport.Location = New System.Drawing.Point(491, 13)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(164, 60)
        Me.btnExport.TabIndex = 49
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'panelClock
        '
        Me.panelClock.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelClock.Controls.Add(Me.Label1)
        Me.panelClock.Controls.Add(Me.labelTime)
        Me.panelClock.Location = New System.Drawing.Point(328, 53)
        Me.panelClock.Name = "panelClock"
        Me.panelClock.Size = New System.Drawing.Size(775, 122)
        Me.panelClock.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(48, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 27)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "CURRENT TIME"
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
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.reset
        Me.btnDeleteAll.Location = New System.Drawing.Point(7, 7)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(258, 69)
        Me.btnDeleteAll.TabIndex = 54
        Me.btnDeleteAll.TabStop = False
        '
        'Staff_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.RESERVATION___bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1104, 737)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelClock)
        Me.Controls.Add(Me.panelRecords)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelExit)
        Me.Controls.Add(Me.dgvRecords)
        Me.Controls.Add(Me.panelStaff)
        Me.Controls.Add(Me.PanelDetails)
        Me.Controls.Add(Me.dgvAccounts)
        Me.Controls.Add(Me.panelRegister)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Staff_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelExit.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_System_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRegister.ResumeLayout(False)
        Me.panelRegister.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelStaff.ResumeLayout(False)
        Me.panelID.ResumeLayout(False)
        Me.panelID.PerformLayout()
        Me.PanelDetails.ResumeLayout(False)
        Me.PanelDetails.PerformLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_System_DatabaseDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRecords.ResumeLayout(False)
        Me.panelClock.ResumeLayout(False)
        Me.panelClock.PerformLayout()
        CType(Me.btnDeleteAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents Reservation_System_DatabaseDataSet1 As Reservation_System_DatabaseDataSet1
    Friend WithEvents UserAccountsBindingSource As BindingSource
    Friend WithEvents UserAccountsTableAdapter As Reservation_System_DatabaseDataSet1TableAdapters.UserAccountsTableAdapter
    Friend WithEvents panelRegister As Panel
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents labelPass As Label
    Friend WithEvents txtRPassword2 As TextBox
    Friend WithEvents txtRPassword1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRUsername As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSignup As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents panelStaff As Panel
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PanelDetails As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents comboboxPosition As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents panelID As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label As Label
    Friend WithEvents labelUser As Label
    Friend WithEvents btnAuditLog As Button
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents Reservation_System_DatabaseDataSet5 As Reservation_System_DatabaseDataSet5
    Friend WithEvents AuditLogBindingSource As BindingSource
    Friend WithEvents AuditLogTableAdapter As Reservation_System_DatabaseDataSet5TableAdapters.AuditLogTableAdapter
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents panelRecords As Panel
    Friend WithEvents btnExport As Button
    Friend WithEvents btnReturn2 As Button
    Friend WithEvents panelClock As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents labelTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnDeleteAll As PictureBox
End Class
