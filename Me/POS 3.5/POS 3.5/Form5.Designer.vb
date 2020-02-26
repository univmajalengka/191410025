<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim Nama_PembeliLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim Tanggal_PembelianLabel As System.Windows.Forms.Label
        Dim Bayar_TunggakanLabel As System.Windows.Forms.Label
        Dim Sisa_TunggakanLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox()
        Me.PembeliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New POS_3._5.dataDataSet()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PembeliTableAdapter = New POS_3._5.dataDataSetTableAdapters.pembeliTableAdapter()
        Me.TableAdapterManager = New POS_3._5.dataDataSetTableAdapters.TableAdapterManager()
        Me.PembeliBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PembeliBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_PembeliTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_PembeliTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_PembelianDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Total_PembelianTextBox = New System.Windows.Forms.TextBox()
        Me.Bayar_TunggakanTextBox = New System.Windows.Forms.TextBox()
        Me.Sisa_TunggakanTextBox = New System.Windows.Forms.TextBox()
        Me.PembeliDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Nama_PembeliLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        Tanggal_PembelianLabel = New System.Windows.Forms.Label()
        Bayar_TunggakanLabel = New System.Windows.Forms.Label()
        Sisa_TunggakanLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PembeliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PembeliBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PembeliBindingNavigator.SuspendLayout()
        CType(Me.PembeliDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nama_PembeliLabel
        '
        Nama_PembeliLabel.AutoSize = True
        Nama_PembeliLabel.Location = New System.Drawing.Point(11, 66)
        Nama_PembeliLabel.Name = "Nama_PembeliLabel"
        Nama_PembeliLabel.Size = New System.Drawing.Size(41, 13)
        Nama_PembeliLabel.TabIndex = 5
        Nama_PembeliLabel.Text = "Nama :"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(205, 38)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 7
        AlamatLabel.Text = "Alamat:"
        '
        'Tanggal_PembelianLabel
        '
        Tanggal_PembelianLabel.AutoSize = True
        Tanggal_PembelianLabel.Location = New System.Drawing.Point(205, 62)
        Tanggal_PembelianLabel.Name = "Tanggal_PembelianLabel"
        Tanggal_PembelianLabel.Size = New System.Drawing.Size(42, 13)
        Tanggal_PembelianLabel.TabIndex = 9
        Tanggal_PembelianLabel.Text = "Tgl Beli"
        '
        'Bayar_TunggakanLabel
        '
        Bayar_TunggakanLabel.AutoSize = True
        Bayar_TunggakanLabel.Location = New System.Drawing.Point(8, 23)
        Bayar_TunggakanLabel.Name = "Bayar_TunggakanLabel"
        Bayar_TunggakanLabel.Size = New System.Drawing.Size(67, 13)
        Bayar_TunggakanLabel.TabIndex = 13
        Bayar_TunggakanLabel.Text = "Uang Cicilan"
        '
        'Sisa_TunggakanLabel
        '
        Sisa_TunggakanLabel.AutoSize = True
        Sisa_TunggakanLabel.Location = New System.Drawing.Point(42, 73)
        Sisa_TunggakanLabel.Name = "Sisa_TunggakanLabel"
        Sisa_TunggakanLabel.Size = New System.Drawing.Size(33, 13)
        Sisa_TunggakanLabel.TabIndex = 15
        Sisa_TunggakanLabel.Text = "Sisa :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(8, 47)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(70, 13)
        Label1.TabIndex = 19
        Label1.Text = "Telah Bayar :"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 95)
        Me.Panel1.TabIndex = 0
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(124, 300)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.ReadOnly = True
        Me.KeteranganTextBox.Size = New System.Drawing.Size(200, 20)
        Me.KeteranganTextBox.TabIndex = 18
        '
        'PembeliBindingSource
        '
        Me.PembeliBindingSource.DataMember = "pembeli"
        Me.PembeliBindingSource.DataSource = Me.DataDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Location = New System.Drawing.Point(-1, 474)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(794, 95)
        Me.Panel2.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(709, 22)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 52)
        Me.Button4.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button4, "Kembali")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(653, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 52)
        Me.Button3.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Button3, "Cetak")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PembeliTableAdapter
        '
        Me.PembeliTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Nothing
        Me.TableAdapterManager.pembeliTableAdapter = Me.PembeliTableAdapter
        Me.TableAdapterManager.UpdateOrder = POS_3._5.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PembeliBindingNavigator
        '
        Me.PembeliBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PembeliBindingNavigator.AutoSize = False
        Me.PembeliBindingNavigator.BindingSource = Me.PembeliBindingSource
        Me.PembeliBindingNavigator.CountItem = Nothing
        Me.PembeliBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PembeliBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PembeliBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PembeliBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PembeliBindingNavigatorSaveItem})
        Me.PembeliBindingNavigator.Location = New System.Drawing.Point(12, 446)
        Me.PembeliBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PembeliBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PembeliBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PembeliBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PembeliBindingNavigator.Name = "PembeliBindingNavigator"
        Me.PembeliBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PembeliBindingNavigator.Size = New System.Drawing.Size(174, 25)
        Me.PembeliBindingNavigator.TabIndex = 2
        Me.PembeliBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'PembeliBindingNavigatorSaveItem
        '
        Me.PembeliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PembeliBindingNavigatorSaveItem.Image = CType(resources.GetObject("PembeliBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PembeliBindingNavigatorSaveItem.Name = "PembeliBindingNavigatorSaveItem"
        Me.PembeliBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.PembeliBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_PembeliTextBox
        '
        Me.ID_PembeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "ID_Pembeli", True))
        Me.ID_PembeliTextBox.Location = New System.Drawing.Point(85, 35)
        Me.ID_PembeliTextBox.Name = "ID_PembeliTextBox"
        Me.ID_PembeliTextBox.Size = New System.Drawing.Size(114, 20)
        Me.ID_PembeliTextBox.TabIndex = 4
        '
        'Nama_PembeliTextBox
        '
        Me.Nama_PembeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Nama Pembeli", True))
        Me.Nama_PembeliTextBox.Location = New System.Drawing.Point(58, 59)
        Me.Nama_PembeliTextBox.Name = "Nama_PembeliTextBox"
        Me.Nama_PembeliTextBox.Size = New System.Drawing.Size(141, 20)
        Me.Nama_PembeliTextBox.TabIndex = 6
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(249, 35)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(146, 20)
        Me.AlamatTextBox.TabIndex = 8
        '
        'Tanggal_PembelianDateTimePicker
        '
        Me.Tanggal_PembelianDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PembeliBindingSource, "Tanggal Pembelian", True))
        Me.Tanggal_PembelianDateTimePicker.Location = New System.Drawing.Point(279, 59)
        Me.Tanggal_PembelianDateTimePicker.Name = "Tanggal_PembelianDateTimePicker"
        Me.Tanggal_PembelianDateTimePicker.Size = New System.Drawing.Size(116, 20)
        Me.Tanggal_PembelianDateTimePicker.TabIndex = 10
        '
        'Total_PembelianTextBox
        '
        Me.Total_PembelianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Total Pembelian", True))
        Me.Total_PembelianTextBox.Location = New System.Drawing.Point(178, 362)
        Me.Total_PembelianTextBox.Name = "Total_PembelianTextBox"
        Me.Total_PembelianTextBox.ReadOnly = True
        Me.Total_PembelianTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Total_PembelianTextBox.TabIndex = 12
        '
        'Bayar_TunggakanTextBox
        '
        Me.Bayar_TunggakanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Bayar Tunggakan", True))
        Me.Bayar_TunggakanTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bayar_TunggakanTextBox.ForeColor = System.Drawing.Color.Green
        Me.Bayar_TunggakanTextBox.Location = New System.Drawing.Point(81, 44)
        Me.Bayar_TunggakanTextBox.Name = "Bayar_TunggakanTextBox"
        Me.Bayar_TunggakanTextBox.Size = New System.Drawing.Size(108, 20)
        Me.Bayar_TunggakanTextBox.TabIndex = 14
        Me.Bayar_TunggakanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Sisa_TunggakanTextBox
        '
        Me.Sisa_TunggakanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Sisa Tunggakan", True))
        Me.Sisa_TunggakanTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sisa_TunggakanTextBox.ForeColor = System.Drawing.Color.Green
        Me.Sisa_TunggakanTextBox.Location = New System.Drawing.Point(81, 70)
        Me.Sisa_TunggakanTextBox.Name = "Sisa_TunggakanTextBox"
        Me.Sisa_TunggakanTextBox.Size = New System.Drawing.Size(108, 20)
        Me.Sisa_TunggakanTextBox.TabIndex = 16
        Me.Sisa_TunggakanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PembeliDataGridView
        '
        Me.PembeliDataGridView.AutoGenerateColumns = False
        Me.PembeliDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PembeliDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PembeliDataGridView.DataSource = Me.PembeliBindingSource
        Me.PembeliDataGridView.Location = New System.Drawing.Point(12, 219)
        Me.PembeliDataGridView.Name = "PembeliDataGridView"
        Me.PembeliDataGridView.Size = New System.Drawing.Size(442, 224)
        Me.PembeliDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Pembeli"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Pembeli"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama Pembeli"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Pembeli"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Alamat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Tanggal Pembelian"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tanggal Pembelian"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total Pembelian"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Pembelian"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Bayar Tunggakan"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Bayar Tunggakan"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Sisa Tunggakan"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sisa Tunggakan"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(470, 208)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(301, 251)
        Me.ListBox1.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Green
        Me.TextBox1.Location = New System.Drawing.Point(81, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(108, 20)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Bayar_TunggakanLabel)
        Me.GroupBox1.Controls.Add(Me.Bayar_TunggakanTextBox)
        Me.GroupBox1.Controls.Add(Sisa_TunggakanLabel)
        Me.GroupBox1.Controls.Add(Me.Sisa_TunggakanTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(460, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 370)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tunggakan"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(199, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 72)
        Me.Button1.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.Button1, "Bayar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tunggakan")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(11, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 36)
        Me.Button2.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.Button2, "Cari" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ID")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.ID_PembeliTextBox)
        Me.GroupBox2.Controls.Add(Nama_PembeliLabel)
        Me.GroupBox2.Controls.Add(Me.Nama_PembeliTextBox)
        Me.GroupBox2.Controls.Add(AlamatLabel)
        Me.GroupBox2.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox2.Controls.Add(Tanggal_PembelianLabel)
        Me.GroupBox2.Controls.Add(Me.Tanggal_PembelianDateTimePicker)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 112)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pembeli"
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(668, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(22, 20)
        Me.TextBox2.TabIndex = 0
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PembeliDataGridView)
        Me.Controls.Add(Me.KeteranganTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Total_PembelianTextBox)
        Me.Controls.Add(Me.PembeliBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Pembeli"
        CType(Me.PembeliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PembeliBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PembeliBindingNavigator.ResumeLayout(False)
        Me.PembeliBindingNavigator.PerformLayout()
        CType(Me.PembeliDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataDataSet As POS_3._5.dataDataSet
    Friend WithEvents PembeliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembeliTableAdapter As POS_3._5.dataDataSetTableAdapters.pembeliTableAdapter
    Friend WithEvents TableAdapterManager As POS_3._5.dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PembeliBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PembeliBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_PembeliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_PembeliTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_PembelianDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Total_PembelianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Bayar_TunggakanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sisa_TunggakanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeteranganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PembeliDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
