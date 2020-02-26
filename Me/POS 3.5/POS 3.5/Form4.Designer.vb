<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.DataDataSet = New POS_3._5.dataDataSet()
        Me.PembeliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PembeliTableAdapter = New POS_3._5.dataDataSetTableAdapters.pembeliTableAdapter()
        Me.TableAdapterManager = New POS_3._5.dataDataSetTableAdapters.TableAdapterManager()
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
        Me.ID_PembeliTextBox = New System.Windows.Forms.TextBox()
        Me.Total_PembelianTextBox = New System.Windows.Forms.TextBox()
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox()
        Me.Tanggal_PembelianDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembeliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PembeliBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PembeliBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataDataSet
        '
        Me.DataDataSet.DataSetName = "dataDataSet"
        Me.DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PembeliBindingSource
        '
        Me.PembeliBindingSource.DataMember = "pembeli"
        Me.PembeliBindingSource.DataSource = Me.DataDataSet
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
        Me.PembeliBindingNavigator.BackColor = System.Drawing.SystemColors.Control
        Me.PembeliBindingNavigator.BindingSource = Me.PembeliBindingSource
        Me.PembeliBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PembeliBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PembeliBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.PembeliBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PembeliBindingNavigatorSaveItem})
        Me.PembeliBindingNavigator.Location = New System.Drawing.Point(85, 103)
        Me.PembeliBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PembeliBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PembeliBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PembeliBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PembeliBindingNavigator.Name = "PembeliBindingNavigator"
        Me.PembeliBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PembeliBindingNavigator.Size = New System.Drawing.Size(125, 25)
        Me.PembeliBindingNavigator.TabIndex = 0
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
        'ID_PembeliTextBox
        '
        Me.ID_PembeliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "ID_Pembeli", True))
        Me.ID_PembeliTextBox.Location = New System.Drawing.Point(133, 125)
        Me.ID_PembeliTextBox.Name = "ID_PembeliTextBox"
        Me.ID_PembeliTextBox.ReadOnly = True
        Me.ID_PembeliTextBox.Size = New System.Drawing.Size(77, 20)
        Me.ID_PembeliTextBox.TabIndex = 2
        '
        'Total_PembelianTextBox
        '
        Me.Total_PembelianTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Total Pembelian", True))
        Me.Total_PembelianTextBox.Location = New System.Drawing.Point(133, 186)
        Me.Total_PembelianTextBox.Name = "Total_PembelianTextBox"
        Me.Total_PembelianTextBox.ReadOnly = True
        Me.Total_PembelianTextBox.Size = New System.Drawing.Size(77, 20)
        Me.Total_PembelianTextBox.TabIndex = 10
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PembeliBindingSource, "Keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(133, 212)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.ReadOnly = True
        Me.KeteranganTextBox.Size = New System.Drawing.Size(77, 20)
        Me.KeteranganTextBox.TabIndex = 16
        '
        'Tanggal_PembelianDateTimePicker
        '
        Me.Tanggal_PembelianDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PembeliBindingSource, "Tanggal Pembelian", True))
        Me.Tanggal_PembelianDateTimePicker.Location = New System.Drawing.Point(133, 160)
        Me.Tanggal_PembelianDateTimePicker.Name = "Tanggal_PembelianDateTimePicker"
        Me.Tanggal_PembelianDateTimePicker.Size = New System.Drawing.Size(77, 20)
        Me.Tanggal_PembelianDateTimePicker.TabIndex = 8
        Me.Tanggal_PembelianDateTimePicker.Value = New Date(2019, 8, 27, 0, 0, 0, 0)
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(20, 54)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(301, 277)
        Me.ListBox1.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(248, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 40)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 46)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(0, 340)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(343, 53)
        Me.Panel2.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(219, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 36)
        Me.Button3.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button3, "Cetak")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(267, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 36)
        Me.Button2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Button2, "Kembali")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(342, 394)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ID_PembeliTextBox)
        Me.Controls.Add(Me.Tanggal_PembelianDateTimePicker)
        Me.Controls.Add(Me.Total_PembelianTextBox)
        Me.Controls.Add(Me.KeteranganTextBox)
        Me.Controls.Add(Me.PembeliBindingNavigator)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List"
        CType(Me.DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembeliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PembeliBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PembeliBindingNavigator.ResumeLayout(False)
        Me.PembeliBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Total_PembelianTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeteranganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tanggal_PembelianDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
