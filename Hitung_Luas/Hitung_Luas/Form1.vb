Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBPanjang.TextChanged
        LabelBPanjang.Text = TextBoxBPanjang.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TextBoxBHasil.Text = TextBoxBPanjang.Text * TextBoxBLebar.Text * TextBoxBTinggi.Text
        Catch ex As Exception
            MsgBox("Input Nilai Ada Yang Salah!", MsgBoxStyle.Exclamation, "Keterangan")
            TextBoxBTinggi.Text = ""
            TextBoxBLebar.Text = ""
            TextBoxBPanjang.Text = ""
            TextBoxBPanjang.Focus()
            LabelBLebar.Text = "L"
            LabelBPanjang.Text = "P"
            LabelBTinggi.Text = "T"
            TextBoxBHasil.Text = 00
        End Try
    End Sub

    Private Sub TextBoxBLebar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBLebar.TextChanged
        LabelBLebar.Text = TextBoxBLebar.Text
    End Sub

    Private Sub TextBoxBTinggi_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBTinggi.TextChanged
        LabelBTinggi.Text = TextBoxBTinggi.Text
    End Sub

    Private Sub TextBoxSisi_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSisi.TextChanged
        LabelSisi.Text = TextBoxSisi.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TextBoxLuasP.Text = TextBoxSisi.Text ^ 2
        Catch ex As Exception
            MsgBox("Ada Kesalahan Pada Input Nilai!", MsgBoxStyle.Exclamation, "Keterangan")
            TextBoxSisi.Text = ""
            LabelSisi.Text = "S"
            TextBoxSisi.Focus()
            TextBoxLuasP.Text = 00
        End Try
    End Sub

    Private Sub TextBoxBLebar_Click(sender As Object, e As EventArgs) Handles TextBoxBLebar.Click
        TextBoxBLebar.Text = ""
        LabelBLebar.Text = "L"
    End Sub

    Private Sub TextBoxBPanjang_Click(sender As Object, e As EventArgs) Handles TextBoxBPanjang.Click
        TextBoxBPanjang.Text = ""
        LabelBPanjang.Text = "P"
    End Sub

    Private Sub TextBoxBTinggi_Click(sender As Object, e As EventArgs) Handles TextBoxBTinggi.Click
        TextBoxBTinggi.Text = ""
        LabelBTinggi.Text = "T"
    End Sub

    Private Sub TextBoxSisi_Click(sender As Object, e As EventArgs) Handles TextBoxSisi.Click
        TextBoxSisi.Text = ""
        LabelSisi.Text = "S"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            TextBoxHasilR.Text = 3.14 * (TextBoxR.Text ^ 2)
        Catch ex As Exception
            MsgBox("Ada Kesalahan Pada Input Nilai!", MsgBoxStyle.Exclamation, "Keterangan")
            TextBoxR.Text = ""
            TextBoxR.Focus()
            LabelR.Text = "r"
            TextBoxHasilR.Text = 00
        End Try
    End Sub

    Private Sub TextBoxR_Click(sender As Object, e As EventArgs) Handles TextBoxR.Click
        TextBoxR.Text = ""
        LabelR.Text = "r"
    End Sub

    Private Sub TextBoxR_TextChanged(sender As Object, e As EventArgs) Handles TextBoxR.TextChanged
        LabelR.Text = TextBoxR.Text
    End Sub

    Private Sub TextBoxFahrenheit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFahrenheit.TextChanged
        Try
            Dim res, suhu, resh As Double
            res = TextBoxFahrenheit.Text
            suhu = (9 / 5) * res + 32
            resh = Math.Round(suhu, 2)
            TextBoxCelsius.Text = resh
            GaugeControl2.LinearScales("Scale1").Pointers("Pointer1").Value = res
        Catch ex As Exception
            MsgBox("Nilai Tidak Boleh Kosong!", MsgBoxStyle.Information, "Keterangan")
            TextBoxFahrenheit.Text = 0
            TextBoxFahrenheit.Focus()
        End Try
    End Sub

    Private Sub TextBoxPp_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPp.TextChanged
        LabelPp.Text = TextBoxPp.Text
    End Sub

    Private Sub TextBoxPl_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPl.TextChanged
        LabelPl.Text = TextBoxPl.Text
    End Sub

    Private Sub TextBoxPl_Click(sender As Object, e As EventArgs) Handles TextBoxPl.Click
        LabelPl.Text = "L"
        TextBoxPl.Text = ""
    End Sub

    Private Sub TextBoxPp_Click(sender As Object, e As EventArgs) Handles TextBoxPp.Click
        LabelPp.Text = "P"
        TextBoxPp.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            TextBoxLPP.Text = TextBoxPp.Text * TextBoxPl.Text
        Catch ex As Exception
            MsgBox("Ada Kesalahan Pada Input Nilai", MsgBoxStyle.Exclamation, "Keterangan")
            TextBoxPl.Text = ""
            TextBoxPp.Text = ""
            LabelPp.Text = "P"
            LabelPl.Text = "L"
            TextBoxPp.Focus()
            TextBoxLPP.Text = 00
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hitung_Luas"
    End Sub
End Class
