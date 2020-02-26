Public Class Form6

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As New Form2
        i.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As New Form3
        i.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As New Form5
        i.Show()
        Me.Close()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDataSet.pembeli' table. You can move, or remove it, as needed.
        Me.PembeliTableAdapter.Fill(Me.DataDataSet.pembeli)
        'TODO: This line of code loads data into the 'DataDataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.DataDataSet.barang)
        Label3.Text = BindingNavigatorCountItem.Text
        Label4.Text = BindingNavigatorCountItem1.Text
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim x = MsgBox("Apakah Anda Setuju?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Konfirmasi")
        If x = vbYes Then
            Form1.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Dim i As New Form7
        i.Show()
    End Sub

    Private Sub BarangBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BarangBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDataSet)

    End Sub
End Class