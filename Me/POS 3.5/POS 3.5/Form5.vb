Public Class Form5

    Private Sub PembeliBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembeliBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PembeliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.pembeli' table. You can move, or remove it, as needed.
        Me.PembeliTableAdapter.Fill(Me.DataDataSet.pembeli)
        TextBox1.Text = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = 0 Then
            MsgBox("Anda Belum Mengisi Uang Cicilan", MsgBoxStyle.Information, "Keterangan")
            TextBox1.Focus()
        Else
            Dim x = MsgBox("Apakah Anda Setuju?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Konfirmasi")
            If x = vbYes Then
                Bayar_TunggakanTextBox.Text = Val(Bayar_TunggakanTextBox.Text) + Val(TextBox1.Text)
                Sisa_TunggakanTextBox.Text = Val(Total_PembelianTextBox.Text) - Val(Bayar_TunggakanTextBox.Text)
                Me.PembeliBindingNavigatorSaveItem.PerformClick()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim caridata As String = InputBox("Masukan ID", "Pencarian ID")
            Dim rowdata As DataRow
            rowdata = DataDataSet.pembeli.Rows.Find(caridata)
            If Not (rowdata Is Nothing) Then
                Me.PembeliBindingSource.Position = rowdata.Table.Rows.IndexOf(rowdata)
            Else
                MessageBox.Show("ID tidak ditemukan", "Pencarian gagal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("ID Berupa Huruf", "Diisi Karakter Lain", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ID_PembeliTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_PembeliTextBox.TextChanged
        TextBox1.Text = 0
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim i As New Form6
        i.Show()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printFont As New Font("Arial", 12)
        Dim lineHeightSingle As Single = printFont.GetHeight + 2
        Dim horizontalPrintLocationSingle As Single = e.MarginBounds.Left
        Dim verticalPrintLocationSingle As Single = e.MarginBounds.Top
        Dim printLineString As String
        Dim listIndexInteger As Integer
        For listIndexInteger = 0 To Me.ListBox1.Items.Count - 1
            verticalPrintLocationSingle += lineHeightSingle
            printLineString = Me.ListBox1.Items(listIndexInteger).ToString
            e.Graphics.DrawString(printLineString, printFont, Brushes.Black, horizontalPrintLocationSingle, verticalPrintLocationSingle)
        Next listIndexInteger
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Total_PembelianTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Total_PembelianTextBox.TextChanged
        ListBox1.Items.Clear()
        ListBox1.Items.Add("=========================================")
        ListBox1.Items.Add("=========================================")
        ListBox1.Items.Add(" Kode Barang || Nama Barang || Jumlah || SubTotal")
        ListBox1.Items.Add("=========================================")
        For Each l As String In KeteranganTextBox.Lines
            ListBox1.Items.Add(l)
        Next
        ListBox1.Items.Add("")
        ListBox1.Items.Add("=========================================")
        ListBox1.Items.Add("ID = " & ID_PembeliTextBox.Text)
        ListBox1.Items.Add("=========================================")
        ListBox1.Items.Add("Total Belanja = " & Total_PembelianTextBox.Text)
        ListBox1.Items.Add("Bayar Tunggakan = " & Bayar_TunggakanTextBox.Text)
        ListBox1.Items.Add("Sisa Tunggakan = " & Sisa_TunggakanTextBox.Text)
    End Sub

    Private Sub Sisa_TunggakanTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sisa_TunggakanTextBox.TextChanged
        ListBox1.Items.Clear()
        ListBox1.Items.Add("=========================================")
        ListBox1.Items.Add("=========================================")
        ListBox1.Items.Add(" Kode Barang || Nama Barang || Jumlah || SubTotal")
        ListBox1.Items.Add("=========================================")
        For Each l As String In KeteranganTextBox.Lines
            ListBox1.Items.Add(l)
        Next
        ListBox1.Items.Add("")
        ListBox1.Items.Add("=========================================")
        ListBox1.Items.Add("ID = " & ID_PembeliTextBox.Text)
        ListBox1.Items.Add("=========================================")
        ListBox1.Items.Add("Total Belanja = " & Total_PembelianTextBox.Text)
        ListBox1.Items.Add("Bayar Tunggakan = " & Bayar_TunggakanTextBox.Text)
        ListBox1.Items.Add("Sisa Tunggakan = " & Sisa_TunggakanTextBox.Text)
    End Sub
End Class