<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Matrik1 = New System.Windows.Forms.TextBox()
        Me.tb_Matrik2 = New System.Windows.Forms.TextBox()
        Me.tb_Hasil = New System.Windows.Forms.TextBox()
        Me.cb_Operasi = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matrik 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operasi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Matrik 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'tb_Matrik1
        '
        Me.tb_Matrik1.Location = New System.Drawing.Point(92, 21)
        Me.tb_Matrik1.Multiline = True
        Me.tb_Matrik1.Name = "tb_Matrik1"
        Me.tb_Matrik1.Size = New System.Drawing.Size(337, 80)
        Me.tb_Matrik1.TabIndex = 4
        '
        'tb_Matrik2
        '
        Me.tb_Matrik2.Location = New System.Drawing.Point(92, 134)
        Me.tb_Matrik2.Multiline = True
        Me.tb_Matrik2.Name = "tb_Matrik2"
        Me.tb_Matrik2.Size = New System.Drawing.Size(337, 82)
        Me.tb_Matrik2.TabIndex = 5
        '
        'tb_Hasil
        '
        Me.tb_Hasil.Location = New System.Drawing.Point(92, 226)
        Me.tb_Hasil.Multiline = True
        Me.tb_Hasil.Name = "tb_Hasil"
        Me.tb_Hasil.ReadOnly = True
        Me.tb_Hasil.Size = New System.Drawing.Size(337, 113)
        Me.tb_Hasil.TabIndex = 6
        '
        'cb_Operasi
        '
        Me.cb_Operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_Operasi.FormattingEnabled = True
        Me.cb_Operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.cb_Operasi.Location = New System.Drawing.Point(92, 107)
        Me.cb_Operasi.Name = "cb_Operasi"
        Me.cb_Operasi.Size = New System.Drawing.Size(337, 21)
        Me.cb_Operasi.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(354, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 376)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_Operasi)
        Me.Controls.Add(Me.tb_Hasil)
        Me.Controls.Add(Me.tb_Matrik2)
        Me.Controls.Add(Me.tb_Matrik1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_Matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_Matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_Hasil As System.Windows.Forms.TextBox
    Friend WithEvents cb_Operasi As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
