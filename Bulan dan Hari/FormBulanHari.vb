Public Class FormBulanHari

    Private Sub tombolTampil_Click(sender As Object, e As EventArgs) Handles tombolTampil.Click
        Dim strBulan() As String = {"Januari", "Februari", "Maret",
         "April", "Mei", "Juni", "Juli", "Agustus", "September",
         "Oktober", "November", "Desember"}

        'array dengan banyak hari tiap bulan
        Dim intHari() As Integer = {31, 28, 31, 30, 31, 30,
        31, 31, 30, 31, 30, 31}

        'menampilkan daftar bulan dengan banyak hari
        Dim i As Integer
        For i = 0 To strBulan.Length - 1
            listKeluaran.Items.Add(strBulan(i) & " memiliki " &
            intHari(i).ToString() & " hari.")
        Next
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
