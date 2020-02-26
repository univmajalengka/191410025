<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim ID_PembeliLabel As System.Windows.Forms.Label
        Dim Nama_PembeliLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim Tanggal_PembelianLabel As System.Windows.Forms.Label
        Dim Total_PembelianLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Nama_BarangLabel As System.Windows.Forms.Label
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim Harga_SatuanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Nama_BarangTextBox = New System.Windows.Forms.TextBox()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDataSet = New POS_3._5.dataDataSet()
        Me.Harga_SatuanTextBox = New System.Windows.Forms.TextBox()
        Me.GambarPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Total_PembelianTextBox = New System.Windows.Forms.TextBox()
        Me.PembeliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tanggal_PembelianDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.ID_PembeliTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_PembeliTextBox = New System.Windows.Forms.TextBox()
        Me.PembeliTableAdapter = New POS_3._5.dataDataSetTableAdapters.pembeliTableAdapter()
        Me.TableAdapterManager = New POS_3._5.dataDataSetTableAdapters.TableAdapterManager()
        Me.BarangTableAdapter = New POS_3._5.dataDataSetTableAdapters.barangTableAdapter()
        Me.PembeliBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
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
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox()
        Me.ID_BarcodeTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        ID_PembeliLabel = New System.Windows.Forms.Label()
        Nama_PembeliLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        Tanggal_PembelianLabel = New System.Windows.Forms.Label()
        Total_PembelianLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Nama_BarangLabel = New System.Windows.Forms.Label()
        JumlahLabel = New System.Windows.Forms.Label()
        Harga_SatuanLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GambarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PembeliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PembeliBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PembeliBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_PembeliLabel
        '
        ID_PembeliLabel.AutoSize = True
        ID_PembeliLabel.Location = New System.Drawing.Point(15, 30)
        ID_PembeliLabel.Name = "ID_PembeliLabel"
        ID_PembeliLabel.Size = New System.Drawing.Size(61, 13)
        ID_PembeliLabel.TabIndex = 0
        ID_PembeliLabel.Text = "ID Pembeli:"
        '
        'Nama_PembeliLabel
        '
        Nama_PembeliLabel.AutoSize = True
        Nama_PembeliLabel.Location = New System.Drawing.Point(15, 53)
        Nama_PembeliLabel.Name = "Nama_PembeliLabel"
        Nama_PembeliLabel.Size = New System.Drawing.Size(78, 13)
        Nama_PembeliLabel.TabIndex = 2
        Nama_PembeliLabel.Text = "Nama Pembeli:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(311, 30)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 4
        AlamatLabel.Text = "Alamat:"
        '
        'Tanggal_PembelianLabel
        '
        Tanggal_PembelianLabel.AutoSize = True
        Tanggal_PembelianLabel.Location = New System.Drawing.Point(252, 57)
        Tanggal_PembelianLabel.Name = "Tanggal_PembelianLabel"
        Tanggal_PembelianLabel.Size = New System.Drawing.Size(101, 13)
        Tanggal_PembelianLabel.TabIndex = 6
        Tanggal_PembelianLabel.Text = "Tanggal Pembelian:"
        '
        'Total_PembelianLabel
        '
        Total_PembelianLabel.AutoSize = True
        Total_PembelianLabel.Location = New System.Drawing.Point(6, 31)
        Total_PembelianLabel.Name = "Total_PembelianLabel"
        Total_PembelianLabel.Size = New System.Drawing.Size(86, 13)
        Total_PembelianLabel.TabIndex = 8
        Total_PembelianLabel.Text = "Total Pembelian:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(17, 57)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(72, 13)
        Label1.TabIndex = 12
        Label1.Text = "Pembayaran :"
        '
        'Nama_BarangLabel
        '
        Nama_BarangLabel.AutoSize = True
        Nama_BarangLabel.Location = New System.Drawing.Point(9, 68)
        Nama_BarangLabel.Name = "Nama_BarangLabel"
        Nama_BarangLabel.Size = New System.Drawing.Size(75, 13)
        Nama_BarangLabel.TabIndex = 2
        Nama_BarangLabel.Text = "Nama Barang:"
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Location = New System.Drawing.Point(10, 122)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(43, 13)
        JumlahLabel.TabIndex = 6
        JumlahLabel.Text = "Jumlah:"
        '
        'Harga_SatuanLabel
        '
        Harga_SatuanLabel.AutoSize = True
        Harga_SatuanLabel.Location = New System.Drawing.Point(9, 94)
        Harga_SatuanLabel.Name = "Harga_SatuanLabel"
        Harga_SatuanLabel.Size = New System.Drawing.Size(76, 13)
        Harga_SatuanLabel.TabIndex = 8
        Harga_SatuanLabel.Text = "Harga Satuan:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 75)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Location = New System.Drawing.Point(-3, 491)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 79)
        Me.Panel2.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Location = New System.Drawing.Point(656, 13)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(61, 46)
        Me.Button6.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button6, "Refresh" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mulai Baru")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Location = New System.Drawing.Point(716, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 46)
        Me.Button5.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button5, "Kembali")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(45, 173)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 46)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Nama_BarangLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_BarangTextBox)
        Me.GroupBox1.Controls.Add(JumlahLabel)
        Me.GroupBox1.Controls.Add(Harga_SatuanLabel)
        Me.GroupBox1.Controls.Add(Me.Harga_SatuanTextBox)
        Me.GroupBox1.Controls.Add(Me.GambarPictureBox)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 259)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(20, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(51, 40)
        Me.Button3.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Button3, "Cari" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barang (F1)")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(91, 33)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(101, 20)
        Me.TextBox3.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(143, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 86)
        Me.Button2.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Button2, "Order" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barang(F2)")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.Black
        Me.NumericUpDown1.Location = New System.Drawing.Point(91, 120)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown1.TabIndex = 12
        '
        'Nama_BarangTextBox
        '
        Me.Nama_BarangTextBox.BackColor = System.Drawing.Color.White
        Me.Nama_BarangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Nama Barang", True))
        Me.Nama_BarangTextBox.ForeColor = System.Drawing.Color.Black
        Me.Nama_BarangTextBox.Location = New System.Drawing.Point(91, 62)
        Me.Nama_BarangTextBox.Name = "Nama_BarangTextBox"
        Me.Nama_BarangTextBox.ReadOnly = True
        Me.Nama_BarangTextBox.Size = New System.Drawing.Size(136, 20)
        Me.Nama_BarangTextBox.TabIndex = 3
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "barang"
        Me.BarangBindingSource.DataSource = Me.DataDataSet
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Harga_SatuanTextBox
        '
        Me.Harga_SatuanTextBox.BackColor = System.Drawing.Color.White
        Me.Harga_SatuanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "Harga Satuan", True))
        Me.Harga_SatuanTextBox.ForeColor = System.Drawing.Color.Black
        Me.Harga_SatuanTextBox.Location = New System.Drawing.Point(91, 92)
        Me.Harga_SatuanTextBox.Name = "Harga_SatuanTextBox"
        Me.Harga_SatuanTextBox.ReadOnly = True
        Me.Harga_SatuanTextBox.Size = New System.Drawing.Size(101, 20)
        Me.Harga_SatuanTextBox.TabIndex = 9
        '
        'GambarPictureBox
        '
        Me.GambarPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GambarPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BarangBindingSource, "Gambar", True))
        Me.GambarPictureBox.Location = New System.Drawing.Point(16, 151)
        Me.GambarPictureBox.Name = "GambarPictureBox"
        Me.GambarPictureBox.Size = New System.Drawing.Size(121, 92)
        Me.GambarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GambarPictureBox.TabIndex = 11
        Me.GambarPictureBox.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Total_PembelianLabel)
        Me.GroupBox2.Controls.Add(Me.Total_PembelianTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 343)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 132)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pembayaran"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(20, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 45)
        Me.Button1.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Button1, "Kembalian(F3)")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Green
        Me.TextBox2.Location = New System.Drawing.Point(93, 83)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(126, 21)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Green
        Me.TextBox1.Location = New System.Drawing.Point(93, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 21)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Total_PembelianTextBox
        '
        Me.Total_PembelianTextBox.BackColor = System.Drawing.Color.White
        Me.Total_PembelianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Total Pembelian", True))
        Me.Total_PembelianTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_PembelianTextBox.ForeColor = System.Drawing.Color.Green
        Me.Total_PembelianTextBox.Location = New System.Drawing.Point(93, 31)
        Me.Total_PembelianTextBox.Name = "Total_PembelianTextBox"
        Me.Total_PembelianTextBox.ReadOnly = True
        Me.Total_PembelianTextBox.Size = New System.Drawing.Size(126, 21)
        Me.Total_PembelianTextBox.TabIndex = 9
        Me.Total_PembelianTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PembeliBindingSource
        '
        Me.PembeliBindingSource.DataMember = "pembeli"
        Me.PembeliBindingSource.DataSource = Me.DataDataSet
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.ForeColor = System.Drawing.Color.Teal
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(269, 179)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(507, 295)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID Barang"
        Me.ColumnHeader1.Width = 117
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Barang"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 203
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Jumlah"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 83
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sub Total"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Tanggal_PembelianLabel)
        Me.GroupBox3.Controls.Add(Me.Tanggal_PembelianDateTimePicker)
        Me.GroupBox3.Controls.Add(AlamatLabel)
        Me.GroupBox3.Controls.Add(Me.AlamatTextBox)
        Me.GroupBox3.Controls.Add(ID_PembeliLabel)
        Me.GroupBox3.Controls.Add(Me.ID_PembeliTextBox)
        Me.GroupBox3.Controls.Add(Me.Nama_PembeliTextBox)
        Me.GroupBox3.Controls.Add(Nama_PembeliLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(269, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(506, 89)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Pembeli"
        '
        'Tanggal_PembelianDateTimePicker
        '
        Me.Tanggal_PembelianDateTimePicker.CalendarForeColor = System.Drawing.Color.Teal
        Me.Tanggal_PembelianDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Teal
        Me.Tanggal_PembelianDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Teal
        Me.Tanggal_PembelianDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Teal
        Me.Tanggal_PembelianDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Teal
        Me.Tanggal_PembelianDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PembeliBindingSource, "Tanggal Pembelian", True))
        Me.Tanggal_PembelianDateTimePicker.Location = New System.Drawing.Point(359, 53)
        Me.Tanggal_PembelianDateTimePicker.Name = "Tanggal_PembelianDateTimePicker"
        Me.Tanggal_PembelianDateTimePicker.Size = New System.Drawing.Size(115, 20)
        Me.Tanggal_PembelianDateTimePicker.TabIndex = 7
        Me.Tanggal_PembelianDateTimePicker.Value = New Date(2019, 8, 26, 0, 0, 0, 0)
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Alamat", True))
        Me.AlamatTextBox.ForeColor = System.Drawing.Color.Black
        Me.AlamatTextBox.Location = New System.Drawing.Point(359, 27)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(131, 20)
        Me.AlamatTextBox.TabIndex = 5
        '
        'ID_PembeliTextBox
        '
        Me.ID_PembeliTextBox.BackColor = System.Drawing.Color.White
        Me.ID_PembeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "ID_Pembeli", True))
        Me.ID_PembeliTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_PembeliTextBox.ForeColor = System.Drawing.Color.Green
        Me.ID_PembeliTextBox.Location = New System.Drawing.Point(103, 27)
        Me.ID_PembeliTextBox.Name = "ID_PembeliTextBox"
        Me.ID_PembeliTextBox.ReadOnly = True
        Me.ID_PembeliTextBox.Size = New System.Drawing.Size(105, 20)
        Me.ID_PembeliTextBox.TabIndex = 0
        Me.ID_PembeliTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Nama_PembeliTextBox
        '
        Me.Nama_PembeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Nama Pembeli", True))
        Me.Nama_PembeliTextBox.ForeColor = System.Drawing.Color.Black
        Me.Nama_PembeliTextBox.Location = New System.Drawing.Point(103, 50)
        Me.Nama_PembeliTextBox.Name = "Nama_PembeliTextBox"
        Me.Nama_PembeliTextBox.Size = New System.Drawing.Size(143, 20)
        Me.Nama_PembeliTextBox.TabIndex = 3
        '
        'PembeliTableAdapter
        '
        Me.PembeliTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.pembeliTableAdapter = Me.PembeliTableAdapter
        Me.TableAdapterManager.UpdateOrder = POS_3._5.dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'PembeliBindingNavigator
        '
        Me.PembeliBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PembeliBindingNavigator.AutoSize = False
        Me.PembeliBindingNavigator.BackColor = System.Drawing.SystemColors.Control
        Me.PembeliBindingNavigator.BindingSource = Me.PembeliBindingSource
        Me.PembeliBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PembeliBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PembeliBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PembeliBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PembeliBindingNavigatorSaveItem})
        Me.PembeliBindingNavigator.Location = New System.Drawing.Point(527, 251)
        Me.PembeliBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PembeliBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PembeliBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PembeliBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PembeliBindingNavigator.Name = "PembeliBindingNavigator"
        Me.PembeliBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PembeliBindingNavigator.Size = New System.Drawing.Size(111, 25)
        Me.PembeliBindingNavigator.TabIndex = 6
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PembeliBindingNavigatorSaveItem
        '
        Me.PembeliBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PembeliBindingNavigatorSaveItem.Image = CType(resources.GetObject("PembeliBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PembeliBindingNavigatorSaveItem.Name = "PembeliBindingNavigatorSaveItem"
        Me.PembeliBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.PembeliBindingNavigatorSaveItem.Text = "Save Data"
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(339, 303)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.ReadOnly = True
        Me.KeteranganTextBox.Size = New System.Drawing.Size(200, 20)
        Me.KeteranganTextBox.TabIndex = 15
        '
        'ID_BarcodeTextBox
        '
        Me.ID_BarcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BarangBindingSource, "ID_Barcode", True))
        Me.ID_BarcodeTextBox.Location = New System.Drawing.Point(339, 277)
        Me.ID_BarcodeTextBox.Name = "ID_BarcodeTextBox"
        Me.ID_BarcodeTextBox.ReadOnly = True
        Me.ID_BarcodeTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ID_BarcodeTextBox.TabIndex = 1
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(339, 251)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(98, 20)
        Me.TextBox4.TabIndex = 16
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.PembeliBindingNavigator)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.KeteranganTextBox)
        Me.Controls.Add(Me.ID_BarcodeTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GambarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PembeliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PembeliBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PembeliBindingNavigator.ResumeLayout(False)
        Me.PembeliBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataDataSet As POS_3._5.dataDataSet
    Friend WithEvents PembeliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PembeliTableAdapter As POS_3._5.dataDataSetTableAdapters.pembeliTableAdapter
    Friend WithEvents TableAdapterManager As POS_3._5.dataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PembeliBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
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
    Friend WithEvents KeteranganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BarangTableAdapter As POS_3._5.dataDataSetTableAdapters.barangTableAdapter
    Friend WithEvents BarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Nama_BarangTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Harga_SatuanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GambarPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ID_BarcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
