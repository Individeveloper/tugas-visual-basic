Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Januari")
        ComboBox1.Items.Add("Februari")
        ComboBox1.Items.Add("Maret")
        ComboBox1.Items.Add("April")
        ComboBox1.Items.Add("Mei")
        ComboBox1.Items.Add("Juni")
        ComboBox1.Items.Add("Juli")
        ComboBox1.Items.Add("Agustus")
        ComboBox1.Items.Add("September")
        ComboBox1.Items.Add("Oktober")
        ComboBox1.Items.Add("November")
        ComboBox1.Items.Add("Desember")
    End Sub

    Private Sub inp_tgl_TextChanged(sender As Object, e As EventArgs) Handles inp_tgl.TextChanged
        inp_tgl.MaxLength = 2
        If Val(inp_tgl.Text) > 31 Then
            MsgBox("Tanggal tidak valid")
            inp_tgl.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(inp_tgl.Text) Then
            Dim bulan As String = ComboBox1.SelectedItem.ToString()
            Dim tanggal As Integer = Val(inp_tgl.Text)
            Dim zodiak As String = GetZodiac(bulan, tanggal)
            ket.Text = "Hai " & inp_name.Text & " ,zodiak kamu adalah " & zodiak

        Else
            MsgBox("Please select a month and enter a valid date.")
        End If
    End Sub

    Private Function GetZodiac(bulan As String, tanggal As Integer) As String
        Select Case bulan
            Case "Januari"
                If tanggal <= 19 Then
                    Return "Capricorn"
                Else
                    Return "Aquarius"
                End If
            Case "Februari"
                If tanggal <= 18 Then
                    Return "Aquarius"
                Else
                    Return "Pisces"
                End If
            Case "Maret"
                If tanggal <= 20 Then
                    Return "Pisces"
                Else
                    Return "Aries"
                End If
            Case "April"
                If tanggal <= 19 Then
                    Return "Aries"
                Else
                    Return "Taurus"
                End If
            Case "Mei"
                If tanggal <= 20 Then
                    Return "Taurus"
                Else
                    Return "Gemini"
                End If
            Case "Juni"
                If tanggal <= 20 Then
                    Return "Gemini"
                Else
                    Return "Cancer"
                End If
            Case "Juli"
                If tanggal <= 22 Then
                    Return "Cancer"
                Else
                    Return "Leo"
                End If
            Case "Agustus"
                If tanggal <= 22 Then
                    Return "Leo"
                Else
                    Return "Virgo"
                End If
            Case "September"
                If tanggal <= 22 Then
                    Return "Virgo"
                Else
                    Return "Libra"
                End If
            Case "Oktober"
                If tanggal <= 22 Then
                    Return "Libra"
                Else
                    Return "Scorpio"
                End If
            Case "November"
                If tanggal <= 21 Then
                    Return "Scorpio"
                Else
                    Return "Sagittarius"
                End If
            Case "Desember"
                If tanggal <= 21 Then
                    Return "Sagittarius"
                Else
                    Return "Capricorn"
                End If
            Case Else
                Return "Invalid"
        End Select
    End Function

    Private Sub inp_name_TextChanged(sender As Object, e As EventArgs) Handles inp_name.TextChanged

    End Sub
End Class
