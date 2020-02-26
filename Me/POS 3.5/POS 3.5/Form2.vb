Public Class Form2

    Private Sub BarangBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DataDataSet.barang)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.BindingNavigatorAddNewItem.PerformClick()
        JumlahNumericUpDown.Value = 0
        Button1.Enabled = False
        ID_BarcodeTextBox.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button1.Enabled = True Then
            MsgBox("Anda Belum Menekan Tombol Tambah", MsgBoxStyle.Information, "Keterangan")
        ElseIf ID_BarcodeTextBox.Text = "" And Nama_BarangTextBox.Text = "" And UnitComboBox.Text = "" And JumlahNumericUpDown.Value = 0 And Harga_SatuanTextBox.Text = "" Then
            MsgBox("Anda Belum Memasukan Data", MsgBoxStyle.Information, "Keterangan")
            ID_BarcodeTextBox.Focus()
        ElseIf ID_BarcodeTextBox.Text = "" Then
            MsgBox("Anda Belum Mengisi ID", MsgBoxStyle.Information, "Keterangan")
            ID_BarcodeTextBox.Focus()
        ElseIf Nama_BarangTextBox.Text = "" Then
            MsgBox("Anda Belum Mengisi Barang", MsgBoxStyle.Information, "Keterangan")
            Nama_BarangTextBox.Focus()
        ElseIf UnitComboBox.Text = "" Then
            MsgBox("Anda Belum Mengisi Unit", MsgBoxStyle.Information, "Keterangan")
            UnitComboBox.Focus()
        ElseIf JumlahNumericUpDown.Value = 0 Then
            MsgBox("Anda Belum Mengisi Jumlah", MsgBoxStyle.Information, "Keterangan")
            JumlahNumericUpDown.Focus()
        ElseIf Harga_SatuanTextBox.Text = "" Then
            MsgBox("Anda Belum Mengisi Harga", MsgBoxStyle.Information, "Keterangan")
            Harga_SatuanTextBox.Focus()
        Else
            Me.BarangBindingNavigatorSaveItem.PerformClick()
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.BindingNavigatorDeleteItem.PerformClick()
        Me.BarangBindingNavigatorSaveItem.PerformClick()
        Button1.Enabled = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "Gambar (*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff) | *.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            GambarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
            GambarPictureBox.Image = New Bitmap(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim i As New Form6
        i.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button1.Enabled = False
    End Sub
End Class