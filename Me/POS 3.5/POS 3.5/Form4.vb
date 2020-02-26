Public Class Form4

    Private Sub PembeliBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembeliBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PembeliBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.pembeli' table. You can move, or remove it, as needed.
        Me.PembeliTableAdapter.Fill(Me.DataDataSet.pembeli)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim caridata As String = TextBox1.Text
            Dim rowdata As DataRow
            rowdata = DataDataSet.pembeli.Rows.Find(caridata)
            If Not (rowdata Is Nothing) Then
                Me.PembeliBindingSource.Position = rowdata.Table.Rows.IndexOf(rowdata)
            Else
                MessageBox.Show("Anda Belum Melakukan Transaksi", "Keterangan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("ID Berupa Huruf", "Diisi Karakter Lain", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
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
        ListBox1.Items.Add("Total Belanja = " & Total_PembelianTextBox.Text)
        ListBox1.Items.Add("Tanggal Belanja = " & Tanggal_PembelianDateTimePicker.Value)
        ListBox1.Items.Add("ID = " & ID_PembeliTextBox.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
End Class