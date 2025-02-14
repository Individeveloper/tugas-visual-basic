<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        nama = New TextBox()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        nil_harian = New TextBox()
        hasil = New Label()
        Label2 = New Label()
        Label5 = New Label()
        nil_uts = New TextBox()
        Label6 = New Label()
        nil_uas = New TextBox()
        btn_proses = New Button()
        btn_clear = New Button()
        ket = New Label()
        SuspendLayout()
        ' 
        ' nama
        ' 
        nama.Location = New Point(219, 74)
        nama.Name = "nama"
        nama.Size = New Size(100, 29)
        nama.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(157, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 21)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(413, 74)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 29)
        ComboBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(253, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 21)
        Label3.TabIndex = 6
        Label3.Text = "Nilai Harian"
        ' 
        ' nil_harian
        ' 
        nil_harian.Location = New Point(351, 130)
        nil_harian.Name = "nil_harian"
        nil_harian.Size = New Size(100, 29)
        nil_harian.TabIndex = 5
        ' 
        ' hasil
        ' 
        hasil.AutoSize = True
        hasil.Location = New Point(309, 251)
        hasil.Name = "hasil"
        hasil.Size = New Size(0, 21)
        hasil.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(351, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 21)
        Label2.TabIndex = 8
        Label2.Text = "Kelas"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(253, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 21)
        Label5.TabIndex = 11
        Label5.Text = "Nilai UTS"
        ' 
        ' nil_uts
        ' 
        nil_uts.Location = New Point(351, 165)
        nil_uts.Name = "nil_uts"
        nil_uts.Size = New Size(100, 29)
        nil_uts.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(253, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 21)
        Label6.TabIndex = 13
        Label6.Text = "Nilai UAS"
        ' 
        ' nil_uas
        ' 
        nil_uas.Location = New Point(351, 200)
        nil_uas.Name = "nil_uas"
        nil_uas.Size = New Size(100, 29)
        nil_uas.TabIndex = 12
        ' 
        ' btn_proses
        ' 
        btn_proses.Location = New Point(254, 331)
        btn_proses.Name = "btn_proses"
        btn_proses.Size = New Size(75, 35)
        btn_proses.TabIndex = 14
        btn_proses.Text = "Proses"
        btn_proses.UseVisualStyleBackColor = True
        ' 
        ' btn_clear
        ' 
        btn_clear.Location = New Point(389, 331)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(75, 35)
        btn_clear.TabIndex = 15
        btn_clear.Text = "Hapus"
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' ket
        ' 
        ket.AutoSize = True
        ket.Location = New Point(309, 284)
        ket.Name = "ket"
        ket.Size = New Size(0, 21)
        ket.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ket)
        Controls.Add(btn_clear)
        Controls.Add(btn_proses)
        Controls.Add(Label6)
        Controls.Add(nil_uas)
        Controls.Add(Label5)
        Controls.Add(nil_uts)
        Controls.Add(Label2)
        Controls.Add(hasil)
        Controls.Add(Label3)
        Controls.Add(nil_harian)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(nama)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nil_harian As TextBox
    Friend WithEvents hasil As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nil_uts As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nil_uas As TextBox
    Friend WithEvents btn_proses As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents ket As Label

End Class
