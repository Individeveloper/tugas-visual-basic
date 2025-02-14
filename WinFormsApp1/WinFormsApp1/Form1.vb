Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("X PPLG 1")
        ComboBox1.Items.Add("X PPLG 2")
        ComboBox1.Items.Add("XI PPLG 1")
        ComboBox1.Items.Add("XI PPLG 2")
        ComboBox1.Items.Add("XII PPLG 1")
        ComboBox1.Items.Add("XII PPLG 2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_proses.Click
        hasil.Text = (Val(nil_harian.Text) * 0.2) + (Val(nil_uts.Text) * 0.3) + (Val(nil_uas.Text) * 0.5)
        If hasil.Text >= 75 Then
            ket.Text = "Selamat anda lulus!"
        Else
            ket.Text = "Maaf, anda tidak lulus!"
        End If
        hasil.Visible = True
        ket.Visible = True
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        nil_harian.Clear()
        nil_uts.Clear()
        nil_uas.Clear()
        nama.Clear()
        hasil.Visible = False
        ket.Visible = False
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = -1 Then
            ComboBox1.SelectedIndex = 0
        End If
    End Sub
End Class
