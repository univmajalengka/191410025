<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ID_BarcodeLabel As System.Windows.Forms.Label
        Dim Nama_BarangLabel As System.Windows.Forms.Label
        Dim UnitLabel As System.Windows.Forms.Label
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim Harga_SatuanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataDataSet = New POS_3._5.dataDataSet()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New POS_3._5.dataDataSetTableAdapters.barangTableAdapter()
        Me.TableAdapterManager = New POS_3._5.dataDataSetTableAdapters.TableAdapterManager()
        Me.BarangBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BarangBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_BarangTextBox = New System.Windows.Forms.TextBox()
        Me.UnitComboBox = New System.Windows.Forms.ComboBox()
        Me.JumlahNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Harga_SatuanTextBox = New System.Windows.Forms.TextBox()
        Me.GambarPictureBox = New System.Windows.Forms.PictureBox()
        Me.BarangDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        ID_BarcodeLabel = New System.Windows.Forms.Label()
        Nama_BarangLabel = New System.Windows.Forms.Label()
        UnitLabel = New System.Windows.Forms.Label()
        JumlahLabel = New System.Windows.Forms.Label()
        Harga_SatuanLabel = New System.Windows.Forms.Label()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarangBindingNavigator.SuspendLayout()
        CType(Me.JumlahNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GambarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_BarcodeLabel
        '
        ID_BarcodeLabel.AutoSize = True
        ID_BarcodeLabel.Location = New System.Drawing.Point(12, 67)
        ID_BarcodeLabel.Name = "ID_BarcodeLabel"
        ID_BarcodeLabel.Size = New System.Drawing.Size(64, 13)
        ID_BarcodeLabel.TabIndex = 1
        ID_BarcodeLabel.Text = "ID Barcode:"
        '
        'Nama_BarangLabel
        '
        Nama_BarangLabel.AutoSize = True
        Nama_BarangLabel.Location = New System.Drawing.Point(12, 93)
        Nama_BarangLabel.Name = "Nama_BarangLabel"
        Nama_BarangLabel.Size = New System.Drawing.Size(75, 13)
        Nama_BarangLabel.TabIndex = 3
        Nama_BarangLabel.Text = "Nama Barang:"
        '
        'UnitLabel
        '
        UnitLabel.AutoSize = True
        UnitLabel.Location = New System.Drawing.Point(12, 119)
        UnitLabel.Name = "UnitLabel"
        UnitLabel.Size = New System.Drawing.Size(29, 13)
        UnitLabel.TabIndex = 5
        UnitLabel.Text = "Unit:"
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Location = New System.Drawing.Point(12, 143)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(43, 13)
        JumlahLabel.TabIndex = 7
        JumlahLabel.Text = "Jumlah:"
        '
        'Harga_SatuanLabel
        '
        Harga_SatuanLabel.AutoSize = True
        Harga_SatuanLabel.Location = New System.Drawing.Point(12, 172)
        Harga_SatuanLabel.Name = "Harga_SatuanLabel"
        Harga_SatuanLabel.Size = New System.Drawing.Size(76, 13)
        Harga_SatuanLabel.TabIndex = 9
        Harga_SatuanLabel.Text = "Harga Satuan:"
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "barang"
        Me.BarangBindingSource.DataSource = Me.DataDataSet
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.pembeliTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = POS_3._5.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BarangBindingNavigator
        '
        Me.BarangBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BarangBindingNavigator.AutoSize = False
        Me.BarangBindingNavigator.BindingSource = Me.BarangBindingSource
        Me.BarangBindingNavigator.CountItem = Nothing
        Me.BarangBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BarangBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.BarangBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BarangBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BarangBindingNavigatorSaveItem})
        Me.BarangBindingNavigator.Location = New System.Drawing.Point(12, 423)
        Me.BarangBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BarangBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BarangBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BarangBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BarangBindingNavigator.Name = "BarangBindingNavigator"
        Me.BarangBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BarangBindingNavigator.Size = New System.Drawing.Size(182, 25)
        Me.BarangBindingNavigator.TabIndex = 0
        Me.BarangBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BarangBindingNavigatorSaveItem
        '
        Me.BarangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BarangBindingNavigatorSaveItem.Image = CType(resources.GetObject("BarangBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BarangBindingNavigatorSaveItem.Name = "BarangBindingNavigatorSaveItem"
        Me.BarangBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.BarangBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ID_BarcodeTextBox
        '
        Me.ID_BarcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "ID_Barcode", True))
        Me.ID_BarcodeTextBox.Location = New System.Drawing.Point(94, 64)
        Me.ID_BarcodeTextBox.Name = "ID_BarcodeTextBox"
        Me.ID_BarcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_BarcodeTextBox.TabIndex = 0
        '
        'Nama_BarangTextBox
        '
        Me.Nama_BarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Nama Barang", True))
        Me.Nama_BarangTextBox.Location = New System.Drawing.Point(94, 90)
        Me.Nama_BarangTextBox.Name = "Nama_BarangTextBox"
        Me.Nama_BarangTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Nama_BarangTextBox.TabIndex = 4
        '
        'UnitComboBox
        '
        Me.UnitComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Unit", True))
        Me.UnitComboBox.FormattingEnabled = True
        Me.UnitComboBox.Items.AddRange(New Object() {"pcs", "lusin", "box"})
        Me.UnitComboBox.Location = New System.Drawing.Point(94, 116)
        Me.UnitComboBox.Name = "UnitComboBox"
        Me.UnitComboBox.Size = New System.Drawing.Size(65, 21)
        Me.UnitComboBox.TabIndex = 6
        '
        'JumlahNumericUpDown
        '
        Me.JumlahNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BarangBindingSource, "Jumlah", True))
        Me.JumlahNumericUpDown.Location = New System.Drawing.Point(94, 143)
        Me.JumlahNumericUpDown.Name = "JumlahNumericUpDown"
        Me.JumlahNumericUpDown.Size = New System.Drawing.Size(44, 20)
        Me.JumlahNumericUpDown.TabIndex = 8
        '
        'Harga_SatuanTextBox
        '
        Me.Harga_SatuanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Harga Satuan", True))
        Me.Harga_SatuanTextBox.Location = New System.Drawing.Point(94, 169)
        Me.Harga_SatuanTextBox.Name = "Harga_SatuanTextBox"
        Me.Harga_SatuanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Harga_SatuanTextBox.TabIndex = 10
        '
        'GambarPictureBox
        '
        Me.GambarPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GambarPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BarangBindingSource, "Gambar", True))
        Me.GambarPictureBox.Location = New System.Drawing.Point(283, 62)
        Me.GambarPictureBox.Name = "GambarPictureBox"
        Me.GambarPictureBox.Size = New System.Drawing.Size(132, 89)
        Me.GambarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GambarPictureBox.TabIndex = 12
        Me.GambarPictureBox.TabStop = False
        '
        'BarangDataGridView
        '
        Me.BarangDataGridView.AutoGenerateColumns = False
        Me.BarangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BarangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.BarangDataGridView.DataSource = Me.BarangBindingSource
        Me.BarangDataGridView.Location = New System.Drawing.Point(12, 200)
        Me.BarangDataGridView.Name = "BarangDataGridView"
        Me.BarangDataGridView.Size = New System.Drawing.Size(405, 220)
        Me.BarangDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Barcode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Barcode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nama Barang"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Unit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Jumlah"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Jumlah"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Harga Satuan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Harga Satuan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(306, 156)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 39)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "             Gambar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(0, 451)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(427, 69)
        Me.Panel1.TabIndex = 18
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(346, 15)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(59, 40)
        Me.Button5.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Button5, "Kembali")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(10, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "          Tambah"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(114, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 39)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "          Simpan"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(327, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 39)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "          Hapus"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(-4, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 60)
        Me.Panel2.TabIndex = 19
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(222, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 39)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "         Edit"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(427, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BarangDataGridView)
        Me.Controls.Add(ID_BarcodeLabel)
        Me.Controls.Add(Me.ID_BarcodeTextBox)
        Me.Controls.Add(Nama_BarangLabel)
        Me.Controls.Add(Me.Nama_BarangTextBox)
        Me.Controls.Add(UnitLabel)
        Me.Controls.Add(Me.UnitComboBox)
        Me.Controls.Add(JumlahLabel)
        Me.Controls.Add(Me.JumlahNumericUpDown)
        Me.Controls.Add(Harga_SatuanLabel)
        Me.Controls.Add(Me.Harga_SatuanTextBox)
        Me.Controls.Add(Me.GambarPictureBox)
        Me.Controls.Add(Me.BarangBindingNavigator)
        Me.MaximumSize = New System.Drawing.Size(435, 552)
        Me.MinimumSize = New System.Drawing.Size(435, 552)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarangBindingNavigator.ResumeLayout(False)
        Me.BarangBindingNavigator.PerformLayout()
        CType(Me.JumlahNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GambarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataDataSet As POS_3._5.dataDataSet
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarangTableAdapter As POS_3._5.dataDataSetTableAdapters.barangTableAdapter
    Friend WithEvents TableAdapterManager As POS_3._5.dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BarangBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BarangBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ID_BarcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_BarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents JumlahNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Harga_SatuanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GambarPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BarangDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
