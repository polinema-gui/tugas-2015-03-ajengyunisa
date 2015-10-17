Public Class Form2
    Dim jumlah As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
        Try
            Select Case combo_Pola.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(tb_Baris.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(tb_Baris.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(tb_Baris.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(tb_Baris.Text))
                Case Else
                    tb_Hasil.Text = "Anda Belum Memilih Pola"
            End Select
        Catch ex As Exception
            tb_Hasil.Text = "Masukan Bukan Angka"
        End Try
    End Sub
    Private Sub pyramid(target As Integer)
        Dim targetKolom1 As Integer = target
        Dim targetKolom2 As Integer = target
        For baris As Integer = 1 To target
            For kolom As Integer = 1 To target * 2 - 1
                If (kolom < targetKolom1 Or kolom > targetKolom2) Then
                    Me.jumlah &= "  "
                Else
                    Me.jumlah &= "*"
                End If
            Next
            targetKolom1 -= 1
            targetKolom2 += 1
            Me.jumlah &= vbCrLf
        Next
        tb_Hasil.Text = jumlah
        jumlah = ""
    End Sub
    Private Sub hollowPyramid(target As Integer)
        Dim targetKolom1 As Integer = target
        Dim targetKolom2 As Integer = target
        For baris As Integer = 1 To target
            For kolom As Integer = 1 To target * 2 - 1
                If (baris < target) Then
                    If (kolom = targetKolom1 Or kolom = targetKolom2) Then
                        Me.jumlah &= "*"
                    Else
                        Me.jumlah &= "  "
                    End If
                Else
                    Me.jumlah &= "*"
                End If
            Next
            targetKolom1 -= 1
            targetKolom2 += 1
            Me.jumlah &= vbCrLf
        Next
        tb_Hasil.Text = jumlah
        jumlah = ""
    End Sub
    Private Sub invertedPyramid(target As Integer)
        Dim targetKolom1 As Integer = 0
        Dim targetKolom2 As Integer = target * 2
        For baris As Integer = 1 To target
            For kolom As Integer = 1 To target * 2 - 1
                If (kolom > targetKolom1 And kolom < targetKolom2) Then
                    Me.jumlah &= "*"
                Else
                    Me.jumlah &= "  "
                End If
            Next
            Me.jumlah &= vbCrLf
            targetKolom1 += 1
            targetKolom2 -= 1
        Next
        tb_Hasil.Text = jumlah
        Me.jumlah = ""
    End Sub
    Private Sub hollowInvertedPyramid(target As Integer)
        Dim targetKolom1 As Integer = 1
        Dim targetKolom2 As Integer = target * 2 - 1
        For baris As Integer = 1 To target
            For kolom As Integer = 1 To target * 2 - 1
                If (baris = 1) Then
                    Me.jumlah &= "*"
                Else
                    If (kolom = targetKolom1 Or kolom = targetKolom2) Then
                        Me.jumlah &= "*"
                    Else
                        Me.jumlah &= "  "
                    End If
                End If
            Next
            targetKolom1 += 1
            targetKolom2 -= 1
            Me.jumlah &= vbCrLf
        Next
        tb_Hasil.Text = jumlah
        Me.jumlah = ""
    End Sub
End Class