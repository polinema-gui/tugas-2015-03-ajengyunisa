Public Class Form3
    Dim tesKolom As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim barisMatriks1 As Integer = tb_Matrik1.Lines.Count
            Dim kolomMatriks1 As Integer = tb_Matrik1.Lines.ElementAt(0).Split(" ").Length
            Dim barisMatriks2 As Integer = tb_Matrik1.Lines.Count
            Dim kolomMatriks2 As Integer = tb_Matrik1.Lines.ElementAt(0).Split(" ").Length
            Dim copyMatriks1(barisMatriks1, kolomMatriks1) As Integer
            Dim copyMatriks2(barisMatriks2, kolomMatriks2) As Integer
            cek(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2)
            copyToArray(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2, copyMatriks1, copyMatriks2)
            operasi(copyMatriks1, copyMatriks2, barisMatriks1, kolomMatriks2)
        Catch ex As Exception
            MsgBox("Masukan Bukan Angka")
        End Try
    End Sub
    Private Sub copyToArray(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (Me.tesKolom) Then
            For baris As Integer = 0 To baris1 - 1
                For kolom As Integer = 0 To kolom1 - 1
                    nilai1(baris, kolom) = tb_Matrik1.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                    nilai2(baris, kolom) = tb_Matrik2.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                Next
            Next
        End If
    End Sub
    Private Sub cek(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer)
        Dim tmp As Boolean = True
        For baris = 0 To baris1 - 2
            If (tb_Matrik1.Lines.ElementAt(baris).Split(" ").Length <> tb_Matrik1.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        For baris = 0 To baris2 - 2
            If (tb_Matrik2.Lines.ElementAt(baris).Split(" ").Length <> tb_Matrik2.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        If (tmp = False) Then
            Me.tesKolom = False
            Convert.ToInt32(tb_Matrik1.Text)
            Convert.ToInt32(tb_Matrik2.Text)
            MsgBox("Matriks Tidak Valid")
        ElseIf (baris1 = baris2 And kolom1 = kolom2) Then
            Me.tesKolom = True
        Else
            Me.tesKolom = False
            MsgBox("Baris dan Kolom Semua Matriks Harus Sama")
        End If
    End Sub
    Private Sub operasi(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batasBaris As Integer, batasKolom As Integer)
        Dim hasil As String = ""
        If (Me.tesKolom) Then
            Select Case cb_Operasi.Text
                Case "Tambah"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) + matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case "Kurang"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) - matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case Else
                    MsgBox("Anda Belum Memilih Operasi")
            End Select
            tb_Hasil.Text = hasil
        End If
    End Sub

    Private Sub cb_Operasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Operasi.SelectedIndexChanged
    End Sub
End Class