<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Archive_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Archive_Module))
        Me.PanelExport = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvExport = New System.Windows.Forms.DataGridView()
        Me.ReserveNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentReservationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_System_DatabaseDataSet = New Gym_Reservation_System.Reservation_System_DatabaseDataSet()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.btnReturn2 = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.StudentReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeleteAll = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtSearchBar = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PanelExport.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentReservationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelButtons.SuspendLayout()
        CType(Me.StudentReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelExit.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnDeleteAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelExport
        '
        Me.PanelExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelExport.Controls.Add(Me.PictureBox2)
        Me.PanelExport.Controls.Add(Me.Label2)
        Me.PanelExport.Controls.Add(Me.PictureBox1)
        Me.PanelExport.Controls.Add(Me.Label1)
        Me.PanelExport.Location = New System.Drawing.Point(78, 53)
        Me.PanelExport.Name = "PanelExport"
        Me.PanelExport.Size = New System.Drawing.Size(1107, 122)
        Me.PanelExport.TabIndex = 1
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
        Me.Label2.Size = New System.Drawing.Size(227, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ARCHIVE SECTION"
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
        'dgvExport
        '
        Me.dgvExport.AllowUserToAddRows = False
        Me.dgvExport.AllowUserToDeleteRows = False
        Me.dgvExport.AutoGenerateColumns = False
        Me.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReserveNumDataGridViewTextBoxColumn, Me.IdentificationDataGridViewTextBoxColumn, Me.BookingDateDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.PNameDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn})
        Me.dgvExport.DataSource = Me.StudentReservationBindingSource1
        Me.dgvExport.Location = New System.Drawing.Point(124, 263)
        Me.dgvExport.Name = "dgvExport"
        Me.dgvExport.ReadOnly = True
        Me.dgvExport.Size = New System.Drawing.Size(958, 387)
        Me.dgvExport.TabIndex = 31
        '
        'ReserveNumDataGridViewTextBoxColumn
        '
        Me.ReserveNumDataGridViewTextBoxColumn.DataPropertyName = "ReserveNum"
        Me.ReserveNumDataGridViewTextBoxColumn.HeaderText = "ReserveNum"
        Me.ReserveNumDataGridViewTextBoxColumn.Name = "ReserveNumDataGridViewTextBoxColumn"
        Me.ReserveNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdentificationDataGridViewTextBoxColumn
        '
        Me.IdentificationDataGridViewTextBoxColumn.DataPropertyName = "Identification"
        Me.IdentificationDataGridViewTextBoxColumn.HeaderText = "Identification"
        Me.IdentificationDataGridViewTextBoxColumn.Name = "IdentificationDataGridViewTextBoxColumn"
        Me.IdentificationDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdentificationDataGridViewTextBoxColumn.Width = 150
        '
        'BookingDateDataGridViewTextBoxColumn
        '
        Me.BookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate"
        Me.BookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate"
        Me.BookingDateDataGridViewTextBoxColumn.Name = "BookingDateDataGridViewTextBoxColumn"
        Me.BookingDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.BookingDateDataGridViewTextBoxColumn.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BookingTime"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BookingTime"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'PNameDataGridViewTextBoxColumn
        '
        Me.PNameDataGridViewTextBoxColumn.DataPropertyName = "PName"
        Me.PNameDataGridViewTextBoxColumn.HeaderText = "PName"
        Me.PNameDataGridViewTextBoxColumn.Name = "PNameDataGridViewTextBoxColumn"
        Me.PNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PNameDataGridViewTextBoxColumn.Width = 200
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 150
        '
        'StudentReservationBindingSource1
        '
        Me.StudentReservationBindingSource1.DataMember = "StudentReservation"
        Me.StudentReservationBindingSource1.DataSource = Me.Reservation_System_DatabaseDataSet
        '
        'Reservation_System_DatabaseDataSet
        '
        Me.Reservation_System_DatabaseDataSet.DataSetName = "Reservation_System_DatabaseDataSet"
        Me.Reservation_System_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelButtons
        '
        Me.PanelButtons.BackColor = System.Drawing.Color.Black
        Me.PanelButtons.Controls.Add(Me.btnReturn2)
        Me.PanelButtons.Controls.Add(Me.btnExport)
        Me.PanelButtons.Location = New System.Drawing.Point(119, 654)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(968, 83)
        Me.PanelButtons.TabIndex = 35
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
        Me.btnReturn2.Location = New System.Drawing.Point(618, 12)
        Me.btnReturn2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn2.Name = "btnReturn2"
        Me.btnReturn2.Size = New System.Drawing.Size(164, 60)
        Me.btnReturn2.TabIndex = 52
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
        Me.btnExport.Location = New System.Drawing.Point(786, 12)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(164, 60)
        Me.btnExport.TabIndex = 51
        Me.btnExport.Text = "EXPORT"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'StudentReservationBindingSource
        '
        Me.StudentReservationBindingSource.DataMember = "StudentReservation"
        Me.StudentReservationBindingSource.DataSource = Me.Reservation_System_DatabaseDataSet
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
        Me.panelExit.TabIndex = 40
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
        Me.panelMenu.TabIndex = 41
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnDeleteAll)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.txtSearchBar)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(124, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 83)
        Me.Panel1.TabIndex = 42
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteAll.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.reset
        Me.btnDeleteAll.Location = New System.Drawing.Point(683, 7)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(262, 69)
        Me.btnDeleteAll.TabIndex = 53
        Me.btnDeleteAll.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(402, 28)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox4.TabIndex = 47
        Me.PictureBox4.TabStop = False
        '
        'txtSearchBar
        '
        Me.txtSearchBar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchBar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!)
        Me.txtSearchBar.Location = New System.Drawing.Point(35, 28)
        Me.txtSearchBar.Multiline = True
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(363, 36)
        Me.txtSearchBar.TabIndex = 45
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(454, 54)
        Me.PictureBox3.TabIndex = 46
        Me.PictureBox3.TabStop = False
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
        'Archive_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gym_Reservation_System.My.Resources.Resources.RESERVATION___bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1104, 737)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelExit)
        Me.Controls.Add(Me.PanelExport)
        Me.Controls.Add(Me.dgvExport)
        Me.Controls.Add(Me.PanelButtons)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Archive_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelExport.ResumeLayout(False)
        Me.PanelExport.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentReservationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_System_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelButtons.ResumeLayout(False)
        CType(Me.StudentReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelExit.ResumeLayout(False)
        Me.panelMenu.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnDeleteAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelExport As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Reservation_System_DatabaseDataSet As Reservation_System_DatabaseDataSet
    Friend WithEvents StudentReservationBindingSource As BindingSource
    Friend WithEvents StudentReservationTableAdapter As Reservation_System_DatabaseDataSetTableAdapters.StudentReservationTableAdapter
    Friend WithEvents ReservationArchiveTableAdapter As Reservation_System_DatabaseDataSetTableAdapters.ReservationArchiveTableAdapter
    Friend WithEvents StudentReservationBindingSource1 As BindingSource
    Friend WithEvents dgvExport As DataGridView
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents BookingTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReserveNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnExport As Button
    Friend WithEvents btnReturn2 As Button
    Friend WithEvents btnDeleteAll As PictureBox
End Class
