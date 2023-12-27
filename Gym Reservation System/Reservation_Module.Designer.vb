<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reservation_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation_Module))
        Me.HdrReservation = New System.Windows.Forms.Panel()
        Me.HdrLogbook1 = New System.Windows.Forms.Panel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HdrLogBook = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.t = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PanelLogBook = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.PanelRNum = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtRNum = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cboSearch = New System.Windows.Forms.ComboBox()
        Me.chkToday = New System.Windows.Forms.CheckBox()
        Me.PanelDetails = New System.Windows.Forms.Panel()
        Me.dtpBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.comboboxTime = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPName = New System.Windows.Forms.TextBox()
        Me.comboboxStatus = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdentification = New System.Windows.Forms.TextBox()
        Me.txtSearchBar = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dgvLogBook = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_System_DatabaseDataSet = New Gym_Reservation_System.Reservation_System_DatabaseDataSet()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PanelReservation = New System.Windows.Forms.Panel()
        Me.PanelOutsider = New System.Windows.Forms.Panel()
        Me.txtOutsiderID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PanelEmployee = New System.Windows.Forms.Panel()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnLogbook = New System.Windows.Forms.Button()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelAvailable = New System.Windows.Forms.Panel()
        Me.LabelAvailable = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PanelNAvailable = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PanelReserved = New System.Windows.Forms.Panel()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ReservationSystemDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentReservationTableAdapter = New Gym_Reservation_System.Reservation_System_DatabaseDataSetTableAdapters.StudentReservationTableAdapter()
        Me.panelExit = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.HdrReservation.SuspendLayout()
        Me.HdrLogbook1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HdrLogBook.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLogBook.SuspendLayout()
        Me.PanelRNum.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetails.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLogBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelReservation.SuspendLayout()
        Me.PanelOutsider.SuspendLayout()
        Me.PanelEmployee.SuspendLayout()
        Me.PanelAvailable.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNAvailable.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelReserved.SuspendLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationSystemDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelExit.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HdrReservation
        '
        Me.HdrReservation.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.HdrReservation.Controls.Add(Me.HdrLogbook1)
        Me.HdrReservation.Controls.Add(Me.PictureBox2)
        Me.HdrReservation.Controls.Add(Me.Label2)
        Me.HdrReservation.Controls.Add(Me.PictureBox1)
        Me.HdrReservation.Controls.Add(Me.Label1)
        Me.HdrReservation.Location = New System.Drawing.Point(78, 53)
        Me.HdrReservation.Name = "HdrReservation"
        Me.HdrReservation.Size = New System.Drawing.Size(1023, 122)
        Me.HdrReservation.TabIndex = 0
        '
        'HdrLogbook1
        '
        Me.HdrLogbook1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.HdrLogbook1.Controls.Add(Me.PictureBox11)
        Me.HdrLogbook1.Controls.Add(Me.Label19)
        Me.HdrLogbook1.Controls.Add(Me.PictureBox12)
        Me.HdrLogbook1.Controls.Add(Me.Label20)
        Me.HdrLogbook1.Location = New System.Drawing.Point(0, 0)
        Me.HdrLogbook1.Name = "HdrLogbook1"
        Me.HdrLogbook1.Size = New System.Drawing.Size(1027, 122)
        Me.HdrLogbook1.TabIndex = 4
        '
        'PictureBox11
        '
        Me.PictureBox11.BackgroundImage = CType(resources.GetObject("PictureBox11.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox11.Location = New System.Drawing.Point(642, 27)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(236, 50)
        Me.PictureBox11.TabIndex = 3
        Me.PictureBox11.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(141, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(245, 27)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "LOGBOOK SECTION"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.umak_logo
        Me.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox12.Location = New System.Drawing.Point(51, 29)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(82, 74)
        Me.PictureBox12.TabIndex = 1
        Me.PictureBox12.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(139, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(509, 42)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "UNIVERSITY OF MAKATI GYM"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(642, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(236, 50)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(141, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RESERVATION SECTION"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.umak_logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(51, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 74)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(139, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UNIVERSITY OF MAKATI GYM"
        '
        'HdrLogBook
        '
        Me.HdrLogBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.HdrLogBook.Controls.Add(Me.PictureBox6)
        Me.HdrLogBook.Controls.Add(Me.t)
        Me.HdrLogBook.Controls.Add(Me.PictureBox7)
        Me.HdrLogBook.Controls.Add(Me.Label16)
        Me.HdrLogBook.Location = New System.Drawing.Point(-4, -122)
        Me.HdrLogBook.Name = "HdrLogBook"
        Me.HdrLogBook.Size = New System.Drawing.Size(1023, 122)
        Me.HdrLogBook.TabIndex = 4
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(642, 27)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(236, 50)
        Me.PictureBox6.TabIndex = 3
        Me.PictureBox6.TabStop = False
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.t.Location = New System.Drawing.Point(141, 71)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(245, 27)
        Me.t.TabIndex = 2
        Me.t.Text = "LOGBOOK SECTION"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.umak_logo
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(51, 29)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(82, 74)
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Black", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label16.Location = New System.Drawing.Point(139, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(509, 42)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "UNIVERSITY OF MAKATI GYM"
        '
        'PanelLogBook
        '
        Me.PanelLogBook.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.PanelLogBook.Controls.Add(Me.btnExport)
        Me.PanelLogBook.Controls.Add(Me.HdrLogBook)
        Me.PanelLogBook.Controls.Add(Me.PanelRNum)
        Me.PanelLogBook.Controls.Add(Me.btnReturn)
        Me.PanelLogBook.Controls.Add(Me.btnDelete)
        Me.PanelLogBook.Controls.Add(Me.btnUpdate)
        Me.PanelLogBook.Controls.Add(Me.PictureBox4)
        Me.PanelLogBook.Controls.Add(Me.cboSearch)
        Me.PanelLogBook.Controls.Add(Me.chkToday)
        Me.PanelLogBook.Controls.Add(Me.PanelDetails)
        Me.PanelLogBook.Controls.Add(Me.txtSearchBar)
        Me.PanelLogBook.Controls.Add(Me.PictureBox3)
        Me.PanelLogBook.Controls.Add(Me.dgvLogBook)
        Me.PanelLogBook.Controls.Add(Me.PictureBox5)
        Me.PanelLogBook.Location = New System.Drawing.Point(89, 173)
        Me.PanelLogBook.Name = "PanelLogBook"
        Me.PanelLogBook.Size = New System.Drawing.Size(1026, 566)
        Me.PanelLogBook.TabIndex = 27
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), System.Drawing.Image)
        Me.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnExport.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExport.Location = New System.Drawing.Point(321, 433)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(164, 60)
        Me.btnExport.TabIndex = 48
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'PanelRNum
        '
        Me.PanelRNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.PanelRNum.Controls.Add(Me.Label13)
        Me.PanelRNum.Controls.Add(Me.txtRNum)
        Me.PanelRNum.Location = New System.Drawing.Point(41, 437)
        Me.PanelRNum.Name = "PanelRNum"
        Me.PanelRNum.Size = New System.Drawing.Size(258, 51)
        Me.PanelRNum.TabIndex = 47
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(3, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 21)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Reserve Number:"
        '
        'txtRNum
        '
        Me.txtRNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtRNum.Location = New System.Drawing.Point(156, 11)
        Me.txtRNum.Multiline = True
        Me.txtRNum.Name = "txtRNum"
        Me.txtRNum.Size = New System.Drawing.Size(89, 28)
        Me.txtRNum.TabIndex = 43
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReturn.BackgroundImage = CType(resources.GetObject("btnReturn.BackgroundImage"), System.Drawing.Image)
        Me.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReturn.Location = New System.Drawing.Point(824, 433)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(164, 60)
        Me.btnReturn.TabIndex = 32
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Location = New System.Drawing.Point(656, 433)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(164, 60)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Location = New System.Drawing.Point(489, 433)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(163, 60)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(436, 29)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox4.TabIndex = 44
        Me.PictureBox4.TabStop = False
        '
        'cboSearch
        '
        Me.cboSearch.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.cboSearch.FormattingEnabled = True
        Me.cboSearch.Items.AddRange(New Object() {"Student ID", "Booking Date", "Student Name", "Status"})
        Me.cboSearch.Location = New System.Drawing.Point(828, 41)
        Me.cboSearch.Name = "cboSearch"
        Me.cboSearch.Size = New System.Drawing.Size(158, 27)
        Me.cboSearch.TabIndex = 41
        '
        'chkToday
        '
        Me.chkToday.AutoSize = True
        Me.chkToday.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.chkToday.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chkToday.Location = New System.Drawing.Point(647, 42)
        Me.chkToday.Name = "chkToday"
        Me.chkToday.Size = New System.Drawing.Size(160, 25)
        Me.chkToday.TabIndex = 38
        Me.chkToday.Text = "Reserved Today"
        Me.chkToday.UseVisualStyleBackColor = True
        '
        'PanelDetails
        '
        Me.PanelDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.PanelDetails.Controls.Add(Me.dtpBookingDate)
        Me.PanelDetails.Controls.Add(Me.Label12)
        Me.PanelDetails.Controls.Add(Me.comboboxTime)
        Me.PanelDetails.Controls.Add(Me.Label8)
        Me.PanelDetails.Controls.Add(Me.Label9)
        Me.PanelDetails.Controls.Add(Me.txtPName)
        Me.PanelDetails.Controls.Add(Me.comboboxStatus)
        Me.PanelDetails.Controls.Add(Me.Label10)
        Me.PanelDetails.Controls.Add(Me.Label11)
        Me.PanelDetails.Controls.Add(Me.txtIdentification)
        Me.PanelDetails.Location = New System.Drawing.Point(41, 334)
        Me.PanelDetails.Name = "PanelDetails"
        Me.PanelDetails.Size = New System.Drawing.Size(947, 87)
        Me.PanelDetails.TabIndex = 46
        '
        'dtpBookingDate
        '
        Me.dtpBookingDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.dtpBookingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBookingDate.Location = New System.Drawing.Point(14, 13)
        Me.dtpBookingDate.Name = "dtpBookingDate"
        Me.dtpBookingDate.Size = New System.Drawing.Size(137, 29)
        Me.dtpBookingDate.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(24, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 21)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Booking Date"
        '
        'comboboxTime
        '
        Me.comboboxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.comboboxTime.FormattingEnabled = True
        Me.comboboxTime.Items.AddRange(New Object() {"8:30 - 10:00 AM", "10:00 - 11:30 AM", "1:30 - 2:30 PM", "2:30 - 3:30 PM"})
        Me.comboboxTime.Location = New System.Drawing.Point(156, 13)
        Me.comboboxTime.Name = "comboboxTime"
        Me.comboboxTime.Size = New System.Drawing.Size(158, 28)
        Me.comboboxTime.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(178, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Booking Time"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(382, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Person Name"
        '
        'txtPName
        '
        Me.txtPName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtPName.Location = New System.Drawing.Point(320, 12)
        Me.txtPName.Multiline = True
        Me.txtPName.Name = "txtPName"
        Me.txtPName.Size = New System.Drawing.Size(252, 30)
        Me.txtPName.TabIndex = 13
        '
        'comboboxStatus
        '
        Me.comboboxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.comboboxStatus.FormattingEnabled = True
        Me.comboboxStatus.Items.AddRange(New Object() {"Student", "Employee", "Outsider"})
        Me.comboboxStatus.Location = New System.Drawing.Point(578, 14)
        Me.comboboxStatus.Name = "comboboxStatus"
        Me.comboboxStatus.Size = New System.Drawing.Size(160, 28)
        Me.comboboxStatus.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(630, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 21)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(783, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 21)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Identification"
        '
        'txtIdentification
        '
        Me.txtIdentification.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtIdentification.Location = New System.Drawing.Point(744, 14)
        Me.txtIdentification.Multiline = True
        Me.txtIdentification.Name = "txtIdentification"
        Me.txtIdentification.Size = New System.Drawing.Size(190, 28)
        Me.txtIdentification.TabIndex = 29
        '
        'txtSearchBar
        '
        Me.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchBar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.txtSearchBar.Location = New System.Drawing.Point(69, 29)
        Me.txtSearchBar.Multiline = True
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(363, 36)
        Me.txtSearchBar.TabIndex = 33
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(46, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(454, 54)
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'dgvLogBook
        '
        Me.dgvLogBook.AllowUserToAddRows = False
        Me.dgvLogBook.AllowUserToDeleteRows = False
        Me.dgvLogBook.AutoGenerateColumns = False
        Me.dgvLogBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.IdentificationDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.PNameDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn6})
        Me.dgvLogBook.DataSource = Me.StudentReservationBindingSource
        Me.dgvLogBook.Location = New System.Drawing.Point(43, 88)
        Me.dgvLogBook.Name = "dgvLogBook"
        Me.dgvLogBook.RowHeadersWidth = 51
        Me.dgvLogBook.Size = New System.Drawing.Size(945, 237)
        Me.dgvLogBook.TabIndex = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ReserveNum"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ReserveNum"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'IdentificationDataGridViewTextBoxColumn
        '
        Me.IdentificationDataGridViewTextBoxColumn.DataPropertyName = "Identification"
        Me.IdentificationDataGridViewTextBoxColumn.HeaderText = "Identification"
        Me.IdentificationDataGridViewTextBoxColumn.Name = "IdentificationDataGridViewTextBoxColumn"
        Me.IdentificationDataGridViewTextBoxColumn.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BookingDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BookingDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "BookingTime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "BookingTime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'PNameDataGridViewTextBoxColumn
        '
        Me.PNameDataGridViewTextBoxColumn.DataPropertyName = "PName"
        Me.PNameDataGridViewTextBoxColumn.HeaderText = "PName"
        Me.PNameDataGridViewTextBoxColumn.Name = "PNameDataGridViewTextBoxColumn"
        Me.PNameDataGridViewTextBoxColumn.Width = 170
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'StudentReservationBindingSource
        '
        Me.StudentReservationBindingSource.DataMember = "StudentReservation"
        Me.StudentReservationBindingSource.DataSource = Me.Reservation_System_DatabaseDataSet
        '
        'Reservation_System_DatabaseDataSet
        '
        Me.Reservation_System_DatabaseDataSet.DataSetName = "Reservation_System_DatabaseDataSet"
        Me.Reservation_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.RESERVATION___bg
        Me.PictureBox5.Location = New System.Drawing.Point(0, 80)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1022, 341)
        Me.PictureBox5.TabIndex = 45
        Me.PictureBox5.TabStop = False
        '
        'PanelReservation
        '
        Me.PanelReservation.BackColor = System.Drawing.Color.Black
        Me.PanelReservation.Controls.Add(Me.PanelOutsider)
        Me.PanelReservation.Controls.Add(Me.PanelEmployee)
        Me.PanelReservation.Controls.Add(Me.txtStudentID)
        Me.PanelReservation.Controls.Add(Me.btnLogbook)
        Me.PanelReservation.Controls.Add(Me.cboTime)
        Me.PanelReservation.Controls.Add(Me.cboStatus)
        Me.PanelReservation.Controls.Add(Me.btnReserve)
        Me.PanelReservation.Controls.Add(Me.txtName)
        Me.PanelReservation.Controls.Add(Me.Label7)
        Me.PanelReservation.Controls.Add(Me.Label6)
        Me.PanelReservation.Controls.Add(Me.Label5)
        Me.PanelReservation.Controls.Add(Me.btnCheck)
        Me.PanelReservation.Controls.Add(Me.dtpDate)
        Me.PanelReservation.Controls.Add(Me.Label4)
        Me.PanelReservation.Controls.Add(Me.Label3)
        Me.PanelReservation.Location = New System.Drawing.Point(537, 171)
        Me.PanelReservation.Name = "PanelReservation"
        Me.PanelReservation.Size = New System.Drawing.Size(567, 568)
        Me.PanelReservation.TabIndex = 1
        '
        'PanelOutsider
        '
        Me.PanelOutsider.Controls.Add(Me.txtOutsiderID)
        Me.PanelOutsider.Controls.Add(Me.Label15)
        Me.PanelOutsider.Location = New System.Drawing.Point(46, 328)
        Me.PanelOutsider.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelOutsider.Name = "PanelOutsider"
        Me.PanelOutsider.Size = New System.Drawing.Size(496, 80)
        Me.PanelOutsider.TabIndex = 24
        '
        'txtOutsiderID
        '
        Me.txtOutsiderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtOutsiderID.Location = New System.Drawing.Point(185, 17)
        Me.txtOutsiderID.Name = "txtOutsiderID"
        Me.txtOutsiderID.Size = New System.Drawing.Size(308, 30)
        Me.txtOutsiderID.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(6, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(167, 29)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "OUTSIDER ID"
        '
        'PanelEmployee
        '
        Me.PanelEmployee.Controls.Add(Me.txtEmpID)
        Me.PanelEmployee.Controls.Add(Me.Label14)
        Me.PanelEmployee.Location = New System.Drawing.Point(46, 328)
        Me.PanelEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelEmployee.Name = "PanelEmployee"
        Me.PanelEmployee.Size = New System.Drawing.Size(496, 80)
        Me.PanelEmployee.TabIndex = 22
        '
        'txtEmpID
        '
        Me.txtEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtEmpID.Location = New System.Drawing.Point(185, 17)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(308, 30)
        Me.txtEmpID.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(6, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(177, 29)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "EMPLOYEE ID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtStudentID.Location = New System.Drawing.Point(217, 345)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(321, 30)
        Me.txtStudentID.TabIndex = 21
        '
        'btnLogbook
        '
        Me.btnLogbook.BackColor = System.Drawing.Color.Transparent
        Me.btnLogbook.BackgroundImage = CType(resources.GetObject("btnLogbook.BackgroundImage"), System.Drawing.Image)
        Me.btnLogbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogbook.FlatAppearance.BorderSize = 0
        Me.btnLogbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnLogbook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnLogbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogbook.Font = New System.Drawing.Font("Arial Black", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogbook.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogbook.Location = New System.Drawing.Point(373, 429)
        Me.btnLogbook.Name = "btnLogbook"
        Me.btnLogbook.Size = New System.Drawing.Size(169, 47)
        Me.btnLogbook.TabIndex = 20
        Me.btnLogbook.Text = "LOGBOOK"
        Me.btnLogbook.UseVisualStyleBackColor = False
        '
        'cboTime
        '
        Me.cboTime.BackColor = System.Drawing.SystemColors.Window
        Me.cboTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Items.AddRange(New Object() {"8:30 - 10:00 AM", "10:00 - 11:30 AM", "1:30 - 2:30 PM", "2:30 - 3:30 PM"})
        Me.cboTime.Location = New System.Drawing.Point(355, 104)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(184, 33)
        Me.cboTime.TabIndex = 18
        '
        'cboStatus
        '
        Me.cboStatus.BackColor = System.Drawing.SystemColors.Window
        Me.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Student", "Employee", "Outsider"})
        Me.cboStatus.Location = New System.Drawing.Point(181, 243)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(358, 33)
        Me.cboStatus.TabIndex = 17
        '
        'btnReserve
        '
        Me.btnReserve.BackColor = System.Drawing.Color.Transparent
        Me.btnReserve.BackgroundImage = CType(resources.GetObject("btnReserve.BackgroundImage"), System.Drawing.Image)
        Me.btnReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReserve.FlatAppearance.BorderSize = 0
        Me.btnReserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReserve.Font = New System.Drawing.Font("Arial Black", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnReserve.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReserve.Location = New System.Drawing.Point(198, 429)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(169, 47)
        Me.btnReserve.TabIndex = 15
        Me.btnReserve.Text = "RESERVE"
        Me.btnReserve.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtName.Location = New System.Drawing.Point(181, 293)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(358, 30)
        Me.txtName.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(50, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 29)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "PERSON'S ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(51, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 29)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "STATUS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(51, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "NAME"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.Transparent
        Me.btnCheck.BackgroundImage = CType(resources.GetObject("btnCheck.BackgroundImage"), System.Drawing.Image)
        Me.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCheck.FlatAppearance.BorderSize = 0
        Me.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.Font = New System.Drawing.Font("Arial Black", 12.0!)
        Me.btnCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCheck.Location = New System.Drawing.Point(56, 159)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(269, 47)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "CHECK AVAILABILITY"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'dtpDate
        '
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.dtpDate.CustomFormat = ""
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(355, 61)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(184, 30)
        Me.dtpDate.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(57, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PREFERRED TIME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(57, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PREFERRED DATE"
        '
        'PanelAvailable
        '
        Me.PanelAvailable.BackColor = System.Drawing.Color.Black
        Me.PanelAvailable.Controls.Add(Me.LabelAvailable)
        Me.PanelAvailable.Controls.Add(Me.PictureBox8)
        Me.PanelAvailable.Location = New System.Drawing.Point(130, 226)
        Me.PanelAvailable.Name = "PanelAvailable"
        Me.PanelAvailable.Size = New System.Drawing.Size(377, 125)
        Me.PanelAvailable.TabIndex = 2
        '
        'LabelAvailable
        '
        Me.LabelAvailable.AutoSize = True
        Me.LabelAvailable.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.LabelAvailable.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAvailable.Location = New System.Drawing.Point(67, 78)
        Me.LabelAvailable.Name = "LabelAvailable"
        Me.LabelAvailable.Size = New System.Drawing.Size(228, 22)
        Me.LabelAvailable.TabIndex = 26
        Me.LabelAvailable.Text = "There are still slots remaining."
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.av
        Me.PictureBox8.Location = New System.Drawing.Point(21, 11)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(203, 56)
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'PanelNAvailable
        '
        Me.PanelNAvailable.BackColor = System.Drawing.Color.Black
        Me.PanelNAvailable.Controls.Add(Me.Label17)
        Me.PanelNAvailable.Controls.Add(Me.PictureBox9)
        Me.PanelNAvailable.Location = New System.Drawing.Point(130, 224)
        Me.PanelNAvailable.Name = "PanelNAvailable"
        Me.PanelNAvailable.Size = New System.Drawing.Size(377, 126)
        Me.PanelNAvailable.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label17.Location = New System.Drawing.Point(33, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(329, 22)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Maximum Capacity of 20 has been reached."
        '
        'PictureBox9
        '
        Me.PictureBox9.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.notav
        Me.PictureBox9.Location = New System.Drawing.Point(21, 14)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(245, 52)
        Me.PictureBox9.TabIndex = 0
        Me.PictureBox9.TabStop = False
        '
        'PanelReserved
        '
        Me.PanelReserved.BackColor = System.Drawing.Color.Black
        Me.PanelReserved.Controls.Add(Me.PictureBox13)
        Me.PanelReserved.Controls.Add(Me.Label18)
        Me.PanelReserved.Location = New System.Drawing.Point(129, 226)
        Me.PanelReserved.Name = "PanelReserved"
        Me.PanelReserved.Size = New System.Drawing.Size(377, 126)
        Me.PanelReserved.TabIndex = 26
        '
        'PictureBox13
        '
        Me.PictureBox13.BackgroundImage = CType(resources.GetObject("PictureBox13.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(-4, 9)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(384, 67)
        Me.PictureBox13.TabIndex = 26
        Me.PictureBox13.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(89, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(259, 22)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Data has been added to database."
        '
        'ReservationSystemDatabaseDataSetBindingSource
        '
        Me.ReservationSystemDatabaseDataSetBindingSource.DataSource = Me.Reservation_System_DatabaseDataSet
        Me.ReservationSystemDatabaseDataSetBindingSource.Position = 0
        '
        'StudentReservationTableAdapter
        '
        Me.StudentReservationTableAdapter.ClearBeforeFill = True
        '
        'panelExit
        '
        Me.panelExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.panelExit.Controls.Add(Me.btnMinimize)
        Me.panelExit.Controls.Add(Me.btnExit)
        Me.panelExit.Location = New System.Drawing.Point(-1, -2)
        Me.panelExit.Name = "panelExit"
        Me.panelExit.Size = New System.Drawing.Size(1106, 55)
        Me.panelExit.TabIndex = 39
        '
        'btnMinimize
        '
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(948, 2)
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
        Me.btnExit.Location = New System.Drawing.Point(1012, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 52)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.Black
        Me.panelMenu.Controls.Add(Me.PictureBox10)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Controls.Add(Me.PictureBox14)
        Me.panelMenu.Controls.Add(Me.PictureBox15)
        Me.panelMenu.Controls.Add(Me.btnArchive)
        Me.panelMenu.Controls.Add(Me.btnReservation)
        Me.panelMenu.Location = New System.Drawing.Point(-1, 53)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(102, 684)
        Me.panelMenu.TabIndex = 40
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Location = New System.Drawing.Point(207, 34)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(92, 70)
        Me.PictureBox10.TabIndex = 42
        Me.PictureBox10.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Location = New System.Drawing.Point(-2, 401)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(314, 99)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.hsu_logo
        Me.PictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox14.Location = New System.Drawing.Point(20, 36)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(71, 65)
        Me.PictureBox14.TabIndex = 41
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.umak_logo
        Me.PictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox15.Location = New System.Drawing.Point(20, 36)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(70, 65)
        Me.PictureBox15.TabIndex = 40
        Me.PictureBox15.TabStop = False
        '
        'btnArchive
        '
        Me.btnArchive.BackgroundImage = CType(resources.GetObject("btnArchive.BackgroundImage"), System.Drawing.Image)
        Me.btnArchive.FlatAppearance.BorderSize = 0
        Me.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchive.Location = New System.Drawing.Point(-2, 300)
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
        Me.btnReservation.Location = New System.Drawing.Point(-1, 203)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(313, 99)
        Me.btnReservation.TabIndex = 0
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Reservation_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1104, 737)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.PanelLogBook)
        Me.Controls.Add(Me.panelExit)
        Me.Controls.Add(Me.PanelReserved)
        Me.Controls.Add(Me.PanelNAvailable)
        Me.Controls.Add(Me.PanelAvailable)
        Me.Controls.Add(Me.PanelReservation)
        Me.Controls.Add(Me.HdrReservation)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reservation_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HdrReservation.ResumeLayout(False)
        Me.HdrReservation.PerformLayout()
        Me.HdrLogbook1.ResumeLayout(False)
        Me.HdrLogbook1.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HdrLogBook.ResumeLayout(False)
        Me.HdrLogBook.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLogBook.ResumeLayout(False)
        Me.PanelLogBook.PerformLayout()
        Me.PanelRNum.ResumeLayout(False)
        Me.PanelRNum.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetails.ResumeLayout(False)
        Me.PanelDetails.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLogBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelReservation.ResumeLayout(False)
        Me.PanelReservation.PerformLayout()
        Me.PanelOutsider.ResumeLayout(False)
        Me.PanelOutsider.PerformLayout()
        Me.PanelEmployee.ResumeLayout(False)
        Me.PanelEmployee.PerformLayout()
        Me.PanelAvailable.ResumeLayout(False)
        Me.PanelAvailable.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNAvailable.ResumeLayout(False)
        Me.PanelNAvailable.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelReserved.ResumeLayout(False)
        Me.PanelReserved.PerformLayout()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationSystemDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelExit.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HdrReservation As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Friend WithEvents PanelReservation As Panel
    Friend WithEvents Label3 As Label

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCheck As Button

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Friend WithEvents btnReserve As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents ReservationSystemDatabaseDataSetBindingSource As BindingSource
    Friend WithEvents Reservation_System_DatabaseDataSet As Reservation_System_DatabaseDataSet
    Friend WithEvents StudentReservationTableAdapter As Reservation_System_DatabaseDataSetTableAdapters.StudentReservationTableAdapter
    Friend WithEvents StudentReservationBindingSource As BindingSource
    Friend WithEvents btnLogbook As Button
    Friend WithEvents HdrLogBook As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents t As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PanelEmployee As Panel
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PanelOutsider As Panel
    Friend WithEvents txtOutsiderID As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PanelAvailable As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PanelNAvailable As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents LabelAvailable As Label
    Friend WithEvents PanelLogBook As Panel
    Friend WithEvents PanelRNum As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents txtRNum As TextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cboSearch As ComboBox
    Friend WithEvents chkToday As CheckBox
    Friend WithEvents PanelDetails As Panel
    Friend WithEvents dtpBookingDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents comboboxTime As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPName As TextBox
    Friend WithEvents comboboxStatus As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtIdentification As TextBox
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ReserveNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PanelReserved As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents HdrLogbook1 As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents btnExport As Button
    Friend WithEvents dgvLogBook As DataGridView
    Friend WithEvents panelExit As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents panelMenu As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents btnArchive As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdentificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
