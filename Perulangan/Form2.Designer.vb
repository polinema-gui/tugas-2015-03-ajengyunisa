<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.label_Pola = New System.Windows.Forms.Label()
        Me.label_Baris = New System.Windows.Forms.Label()
        Me.combo_Pola = New System.Windows.Forms.ComboBox()
        Me.tb_Baris = New System.Windows.Forms.TextBox()
        Me.btn_Ok = New System.Windows.Forms.Button()
        Me.tb_Hasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label_Pola
        '
        Me.label_Pola.AutoSize = True
        Me.label_Pola.Location = New System.Drawing.Point(12, 19)
        Me.label_Pola.Name = "label_Pola"
        Me.label_Pola.Size = New System.Drawing.Size(34, 13)
        Me.label_Pola.TabIndex = 0
        Me.label_Pola.Text = "Pola :"
        '
        'label_Baris
        '
        Me.label_Baris.AutoSize = True
        Me.label_Baris.Location = New System.Drawing.Point(12, 51)
        Me.label_Baris.Name = "label_Baris"
        Me.label_Baris.Size = New System.Drawing.Size(75, 13)
        Me.label_Baris.TabIndex = 1
        Me.label_Baris.Text = "Inputan Baris :"
        '
        'combo_Pola
        '
        Me.combo_Pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Pola.FormattingEnabled = True
        Me.combo_Pola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.combo_Pola.Location = New System.Drawing.Point(93, 19)
        Me.combo_Pola.Name = "combo_Pola"
        Me.combo_Pola.Size = New System.Drawing.Size(356, 21)
        Me.combo_Pola.TabIndex = 2
        '
        'tb_Baris
        '
        Me.tb_Baris.Location = New System.Drawing.Point(93, 51)
        Me.tb_Baris.Name = "tb_Baris"
        Me.tb_Baris.Size = New System.Drawing.Size(259, 20)
        Me.tb_Baris.TabIndex = 3
        '
        'btn_Ok
        '
        Me.btn_Ok.Location = New System.Drawing.Point(374, 51)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_Ok.TabIndex = 4
        Me.btn_Ok.Text = "OK"
        Me.btn_Ok.UseVisualStyleBackColor = True
        '
        'tb_Hasil
        '
        Me.tb_Hasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Hasil.Location = New System.Drawing.Point(15, 80)
        Me.tb_Hasil.Multiline = True
        Me.tb_Hasil.Name = "tb_Hasil"
        Me.tb_Hasil.Size = New System.Drawing.Size(434, 212)
        Me.tb_Hasil.TabIndex = 5
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 306)
        Me.Controls.Add(Me.tb_Hasil)
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.tb_Baris)
        Me.Controls.Add(Me.combo_Pola)
        Me.Controls.Add(Me.label_Baris)
        Me.Controls.Add(Me.label_Pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_Pola As System.Windows.Forms.Label
    Friend WithEvents label_Baris As System.Windows.Forms.Label
    Friend WithEvents combo_Pola As System.Windows.Forms.ComboBox
    Friend WithEvents tb_Baris As System.Windows.Forms.TextBox
    Friend WithEvents btn_Ok As System.Windows.Forms.Button
    Friend WithEvents tb_Hasil As System.Windows.Forms.TextBox
End Class
