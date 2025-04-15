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
        Label1 = New Label()
        inp_name = New TextBox()
        inp_tgl = New TextBox()
        tgl = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Button1 = New Button()
        ket = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(335, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' inp_name
        ' 
        inp_name.Location = New Point(380, 95)
        inp_name.Name = "inp_name"
        inp_name.Size = New Size(100, 23)
        inp_name.TabIndex = 1
        ' 
        ' inp_tgl
        ' 
        inp_tgl.Location = New Point(380, 135)
        inp_tgl.Name = "inp_tgl"
        inp_tgl.Size = New Size(100, 23)
        inp_tgl.TabIndex = 3
        ' 
        ' tgl
        ' 
        tgl.AutoSize = True
        tgl.Location = New Point(297, 138)
        tgl.Name = "tgl"
        tgl.Size = New Size(77, 15)
        tgl.TabIndex = 2
        tgl.Text = "Tanggal Lahir"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(380, 178)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(308, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 15)
        Label2.TabIndex = 6
        Label2.Text = "Bulan Lahir"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(335, 235)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "Proses"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ket
        ' 
        ket.AutoSize = True
        ket.Location = New Point(308, 296)
        ket.Name = "ket"
        ket.Size = New Size(19, 15)
        ket.TabIndex = 8
        ket.Text = "...."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ket)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(inp_tgl)
        Controls.Add(tgl)
        Controls.Add(inp_name)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents inp_name As TextBox
    Friend WithEvents inp_tgl As TextBox
    Friend WithEvents tgl As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ket As Label

End Class
