Public Class Form3

    Private Sub PembeliBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembeliBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PembeliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Button3.PerformClick()
        End If
        If e.KeyCode = Keys.F2 Then
            Me.Button2.PerformClick()
        End If
        If e.KeyCode = Keys.F3 Then
            Me.Button1.PerformClick()
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DataDataSet.barang)
        'TODO: This line of code loads data into the 'DataDataSet.pembeli' table. You can move, or remove it, as needed.
        Me.PembeliTableAdapter.Fill(Me.DataDataSet.pembeli)
        Me.BindingNavigatorAddNewItem.PerformClick()
        Tanggal_PembelianDateTimePicker.Value = Today
        Me.ID_PembeliTextBox.Clear()
        Dim R As New Random
        Dim number As Integer = R.Next(115000)
        Me.ID_PembeliTextBox.Text = "pem:" & number
        Me.KeyPreview = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Nama_BarangTextBox.Text = "" Then
            MsgBox("Nama Barang Belum Terisi", MsgBoxStyle.Information, "Keterangan")
            Button3.Focus()
        ElseIf NumericUpDown1.Value = 0 Then
            MsgBox("Jumlah Barang Belum Terisi", MsgBoxStyle.Information, "Keterangan")
            NumericUpDown1.Focus()
        Else
            TextBox4.Text = Val(NumericUpDown1.Text) * Val(Harga_SatuanTextBox.Text)
            Total_PembelianTextBox.Text = Val(Total_PembelianTextBox.Text) + Val(TextBox4.Text)
            KeteranganTextBox.Text &= Environment.NewLine & " " & ID_BarcodeTextBox.Text & "    " & Nama_BarangTextBox.Text & "    " & NumericUpDown1.Value & "    " & TextBox4.Text
            With ListView1
                .Items.Add(ID_BarcodeTextBox.Text)
                With .Items(.Items.Count - 1).SubItems
                    .Add(Nama_BarangTextBox.Text)
                    .Add(NumericUpDown1.Text)
                    .Add(TextBox4.Text)
                End With
            End With
            Me.PembeliBindingNavigatorSaveItem.PerformClick()
            NumericUpDown1.Value = 0
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form4.TextBox1.Text = ID_PembeliTextBox.Text
        Form4.Show()
        Form4.Button1.PerformClick()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Nominal Uang Pembayaran Belum Diisi", MsgBoxStyle.Information, "Keterangan")
        Else
            TextBox2.Text = Val(TextBox1.Text) - Val(Total_PembelianTextBox.Text)
            Me.Button4.PerformClick()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim caridata As String = TextBox3.Text
            Dim rowdata As DataRow
            rowdata = DataDataSet.barang.Rows.Find(caridata)
            If Not (rowdata Is Nothing) Then
                Me.BarangBindingSource.Position = rowdata.Table.Rows.IndexOf(rowdata)
            Else
                MessageBox.Show("ID tidak ditemukan", "Pencarian gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("ID Berupa Huruf", "Diisi Karakter Lain", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        TextBox3.Text = ""
        TextBox3.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim i As New Form6
        i.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim i As New Form3
        i.Show()
        Me.Close()
    End Sub

    Private Sub Nama_BarangTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nama_BarangTextBox.TextChanged
        TextBox3.Focus()
    End Sub
End Class