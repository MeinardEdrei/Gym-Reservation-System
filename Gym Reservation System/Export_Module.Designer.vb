<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Export_Module
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Export_Module))
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.panelExit = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.hdrExport = New System.Windows.Forms.Panel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.labelSection = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Reservation_System_DatabaseDataSet3 = New Gym_Reservation_System.Reservation_System_DatabaseDataSet3()
        Me.StudentReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_System_DatabaseDataSetStudRes = New Gym_Reservation_System.Reservation_System_DatabaseDataSetStudRes()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.btnArchive = New System.Windows.Forms.Button()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.panelReservation = New System.Windows.Forms.Panel()
        Me.btnReturn2 = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.ReservationArchiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_System_DatabaseDataSet4 = New Gym_Reservation_System.Reservation_System_DatabaseDataSet4()
        Me.ReservationArchiveTableAdapter = New Gym_Reservation_System.Reservation_System_DatabaseDataSet4TableAdapters.ReservationArchiveTableAdapter()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog3 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument4 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog4 = New System.Windows.Forms.PrintPreviewDialog()
        Me.AuditLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservation_System_DatabaseDataSet6 = New Gym_Reservation_System.Reservation_System_DatabaseDataSet6()
        Me.AuditLogTableAdapter = New Gym_Reservation_System.Reservation_System_DatabaseDataSet6TableAdapters.AuditLogTableAdapter()
        Me.PrintDocument5 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog5 = New System.Windows.Forms.PrintPreviewDialog()
        Me.StudentReservationTableAdapter = New Gym_Reservation_System.Reservation_System_DatabaseDataSetStudResTableAdapters.StudentReservationTableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer3 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.panelExit.SuspendLayout()
        Me.hdrExport.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_System_DatabaseDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_System_DatabaseDataSetStudRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelReservation.SuspendLayout()
        CType(Me.ReservationArchiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_System_DatabaseDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservation_System_DatabaseDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'hdrExport
        '
        Me.hdrExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.hdrExport.Controls.Add(Me.PictureBox11)
        Me.hdrExport.Controls.Add(Me.labelSection)
        Me.hdrExport.Controls.Add(Me.PictureBox12)
        Me.hdrExport.Controls.Add(Me.Label20)
        Me.hdrExport.Location = New System.Drawing.Point(78, 53)
        Me.hdrExport.Name = "hdrExport"
        Me.hdrExport.Size = New System.Drawing.Size(1059, 122)
        Me.hdrExport.TabIndex = 42
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
        'labelSection
        '
        Me.labelSection.AutoSize = True
        Me.labelSection.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSection.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelSection.Location = New System.Drawing.Point(141, 71)
        Me.labelSection.Name = "labelSection"
        Me.labelSection.Size = New System.Drawing.Size(221, 27)
        Me.labelSection.TabIndex = 2
        Me.labelSection.Text = "EXPORT SECTION"
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
        'Reservation_System_DatabaseDataSet3
        '
        Me.Reservation_System_DatabaseDataSet3.DataSetName = "Reservation_System_DatabaseDataSet3"
        Me.Reservation_System_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentReservationBindingSource
        '
        Me.StudentReservationBindingSource.DataMember = "StudentReservation"
        Me.StudentReservationBindingSource.DataSource = Me.Reservation_System_DatabaseDataSetStudRes
        '
        'Reservation_System_DatabaseDataSetStudRes
        '
        Me.Reservation_System_DatabaseDataSetStudRes.DataSetName = "Reservation_System_DatabaseDataSetStudRes"
        Me.Reservation_System_DatabaseDataSetStudRes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.panelMenu.Size = New System.Drawing.Size(102, 735)
        Me.panelMenu.TabIndex = 43
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
        'panelReservation
        '
        Me.panelReservation.BackColor = System.Drawing.Color.Black
        Me.panelReservation.Controls.Add(Me.btnReturn2)
        Me.panelReservation.Controls.Add(Me.btnReturn)
        Me.panelReservation.Controls.Add(Me.btnExcel)
        Me.panelReservation.Location = New System.Drawing.Point(129, 691)
        Me.panelReservation.Name = "panelReservation"
        Me.panelReservation.Size = New System.Drawing.Size(945, 97)
        Me.panelReservation.TabIndex = 45
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
        Me.btnReturn2.Location = New System.Drawing.Point(755, 20)
        Me.btnReturn2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn2.Name = "btnReturn2"
        Me.btnReturn2.Size = New System.Drawing.Size(164, 60)
        Me.btnReturn2.TabIndex = 53
        Me.btnReturn2.Text = "RETURN"
        Me.btnReturn2.UseVisualStyleBackColor = False
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
        Me.btnReturn.Location = New System.Drawing.Point(755, 20)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(164, 60)
        Me.btnReturn.TabIndex = 52
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExcel.BackgroundImage = CType(resources.GetObject("btnExcel.BackgroundImage"), System.Drawing.Image)
        Me.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Font = New System.Drawing.Font("Arial Black", 14.0!)
        Me.btnExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExcel.Location = New System.Drawing.Point(587, 20)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(164, 60)
        Me.btnExcel.TabIndex = 51
        Me.btnExcel.Text = "EXCEL"
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'ReservationArchiveBindingSource
        '
        Me.ReservationArchiveBindingSource.DataMember = "ReservationArchive"
        Me.ReservationArchiveBindingSource.DataSource = Me.Reservation_System_DatabaseDataSet4
        '
        'Reservation_System_DatabaseDataSet4
        '
        Me.Reservation_System_DatabaseDataSet4.DataSetName = "Reservation_System_DatabaseDataSet4"
        Me.Reservation_System_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationArchiveTableAdapter
        '
        Me.ReservationArchiveTableAdapter.ClearBeforeFill = True
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
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Document = Me.PrintDocument2
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintPreviewDialog3
        '
        Me.PrintPreviewDialog3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog3.Document = Me.PrintDocument3
        Me.PrintPreviewDialog3.Enabled = True
        Me.PrintPreviewDialog3.Icon = CType(resources.GetObject("PrintPreviewDialog3.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog3.Name = "PrintPreviewDialog3"
        Me.PrintPreviewDialog3.Visible = False
        '
        'PrintPreviewDialog4
        '
        Me.PrintPreviewDialog4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog4.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog4.Document = Me.PrintDocument4
        Me.PrintPreviewDialog4.Enabled = True
        Me.PrintPreviewDialog4.Icon = CType(resources.GetObject("PrintPreviewDialog4.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog4.Name = "PrintPreviewDialog4"
        Me.PrintPreviewDialog4.Visible = False
        '
        'AuditLogBindingSource
        '
        Me.AuditLogBindingSource.DataMember = "AuditLog"
        Me.AuditLogBindingSource.DataSource = Me.Reservation_System_DatabaseDataSet6
        '
        'Reservation_System_DatabaseDataSet6
        '
        Me.Reservation_System_DatabaseDataSet6.DataSetName = "Reservation_System_DatabaseDataSet6"
        Me.Reservation_System_DatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuditLogTableAdapter
        '
        Me.AuditLogTableAdapter.ClearBeforeFill = True
        '
        'PrintPreviewDialog5
        '
        Me.PrintPreviewDialog5.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog5.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog5.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog5.Document = Me.PrintDocument5
        Me.PrintPreviewDialog5.Enabled = True
        Me.PrintPreviewDialog5.Icon = CType(resources.GetObject("PrintPreviewDialog5.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog5.Name = "PrintPreviewDialog5"
        Me.PrintPreviewDialog5.Visible = False
        '
        'StudentReservationTableAdapter
        '
        Me.StudentReservationTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.StudentReservationBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Gym_Reservation_System.ResReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(100, 172)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1005, 513)
        Me.ReportViewer1.TabIndex = 46
        '
        'ReportViewer2
        '
        ReportDataSource4.Name = "DataSet2"
        ReportDataSource4.Value = Me.ReservationArchiveBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Gym_Reservation_System.ArchReport.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(100, 172)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(1005, 513)
        Me.ReportViewer2.TabIndex = 47
        '
        'ReportViewer3
        '
        Me.ReportViewer3.Location = New System.Drawing.Point(100, 172)
        Me.ReportViewer3.Name = "ReportViewer3"
        Me.ReportViewer3.ServerReport.BearerToken = Nothing
        Me.ReportViewer3.Size = New System.Drawing.Size(1005, 513)
        Me.ReportViewer3.TabIndex = 48
        '
        'Export_Module
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1104, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelReservation)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.hdrExport)
        Me.Controls.Add(Me.panelExit)
        Me.Controls.Add(Me.ReportViewer3)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Export_Module"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelExit.ResumeLayout(False)
        Me.hdrExport.ResumeLayout(False)
        Me.hdrExport.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_System_DatabaseDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_System_DatabaseDataSetStudRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelReservation.ResumeLayout(False)
        CType(Me.ReservationArchiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_System_DatabaseDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservation_System_DatabaseDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelExit As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents hdrExport As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents labelSection As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Reservation_System_DatabaseDataSet3 As Reservation_System_DatabaseDataSet3
    Friend WithEvents Reservation_System_DatabaseDataSetStudRes As Reservation_System_DatabaseDataSetStudRes
    Friend WithEvents StudentReservationBindingSource As BindingSource
    Friend WithEvents StudentReservationTableAdapter As Reservation_System_DatabaseDataSetStudResTableAdapters.StudentReservationTableAdapter
    Friend WithEvents panelMenu As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents btnArchive As Button
    Friend WithEvents btnReservation As Button
    Friend WithEvents panelReservation As Panel
    Friend WithEvents btnExcel As Button
    Friend WithEvents Reservation_System_DatabaseDataSet4 As Reservation_System_DatabaseDataSet4
    Friend WithEvents ReservationArchiveBindingSource As BindingSource
    Friend WithEvents ReservationArchiveTableAdapter As Reservation_System_DatabaseDataSet4TableAdapters.ReservationArchiveTableAdapter
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As PrintPreviewDialog
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog3 As PrintPreviewDialog
    Friend WithEvents PrintDocument4 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog4 As PrintPreviewDialog
    Friend WithEvents Reservation_System_DatabaseDataSet6 As Reservation_System_DatabaseDataSet6
    Friend WithEvents AuditLogBindingSource As BindingSource
    Friend WithEvents AuditLogTableAdapter As Reservation_System_DatabaseDataSet6TableAdapters.AuditLogTableAdapter
    Friend WithEvents btnReturn As Button
    Friend WithEvents PrintDocument5 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog5 As PrintPreviewDialog
    Friend WithEvents btnReturn2 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer3 As Microsoft.Reporting.WinForms.ReportViewer
End Class
