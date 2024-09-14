Imports System
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization


Public Class f_mhs

    Private Sub btnTampil_Click(sender As System.Object, e As System.EventArgs) Handles btnTampil.Click

        ' URL yang ingin Anda minta
        Dim url As String = "http://localhost:8080"

        ' Data yang ingin Anda kirim (dalam format JSON dalam contoh ini)
        Dim data As String = "{""data"":{""perintah"":""tampilMHS"",""filter"":""" & txtFilter.Text & """},""kunci"":""12345""}"

        ' Membuat objek HttpWebRequest
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)

        ' Menetapkan metode permintaan (POST dalam contoh ini)
        request.Method = "POST"

        ' Menetapkan jenis konten
        request.ContentType = "application/json"

        ' Mengirim data
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(data)
        request.ContentLength = byteArray.Length
        Dim dataStream As System.IO.Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Try
            ' Mendapatkan respons dari server
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

            ' Membaca respons dari server
            Using stream As System.IO.Stream = response.GetResponseStream()
                Using reader As New System.IO.StreamReader(stream)
                    Dim responseText As String = reader.ReadToEnd()
                    'MsgBox(responseText)
                    Dim jss As New JavaScriptSerializer()

                    ' Decode JSON string to User object
                    Dim odmhs As ODataMHS = jss.Deserialize(Of ODataMHS)(responseText)

                    'Membersihkan listview
                    lvMHS.Items.Clear()
                    btnUbah.Enabled = False
                    btnHapus.Enabled = False
                    If Not IsNothing(odmhs.data) Then
                        btnUbah.Enabled = True
                        btnHapus.Enabled = True
                        'Mempopulate data listview
                        For Each mhs As Mhs In odmhs.data
                            Dim item As New ListViewItem(mhs.nim)
                            item.SubItems.Add(mhs.nama)
                            item.SubItems.Add(mhs.jenis_kelamin)
                            item.SubItems.Add(mhs.tempat_lahir)
                            item.SubItems.Add(mhs.tanggal_lahir)
                            item.SubItems.Add(mhs.masuk)
                            item.SubItems.Add(mhs.keluar)
                            lvMHS.Items.Add(item)
                        Next
                    End If
                End Using
            End Using

            If lvMHS.Items.Count > 0 Then
                lvMHS.Focus()
                lvMHS.Items(0).Selected = True
            End If
            'Menutup(respons)
            response.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try


    End Sub


    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnHapus.Click
        If MsgBox("Apakah akan menghapus data " & lvMHS.Items(lvMHS.FocusedItem.Index).SubItems(0).Text, vbYesNo, "Konfirmasi") = vbNo Then
            Exit Sub
        End If
        ' URL yang ingin Anda minta
        Dim url As String = "http://localhost:8080"

        ' Data yang ingin Anda kirim (dalam format JSON dalam contoh ini)
        Dim data As String = "{""data"":{""perintah"":""hapusMHS"",""nim"":""" & lvMHS.Items(lvMHS.FocusedItem.Index).SubItems(0).Text & """},""kunci"":""12345""}"

        ' Membuat objek HttpWebRequest
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)

        ' Menetapkan metode permintaan (POST dalam contoh ini)
        request.Method = "POST"

        ' Menetapkan jenis konten
        request.ContentType = "application/json"

        ' Mengirim data
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(data)
        request.ContentLength = byteArray.Length
        Dim dataStream As System.IO.Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Try
            ' Mendapatkan respons dari server
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

            ' Membaca respons dari server
            Using stream As System.IO.Stream = response.GetResponseStream()
                Using reader As New System.IO.StreamReader(stream)
                    Dim responseText As String = reader.ReadToEnd()
                    'MsgBox(responseText)
                    Dim jss As New JavaScriptSerializer()

                    ' Decode JSON string to User object
                    Dim odmhs As ODataMHS = jss.Deserialize(Of ODataMHS)(responseText)

                    If odmhs.status = "SUKSES" Then
                        MsgBox("Penghapusan SUKSES", vbOKOnly, "Informasi")
                        btnTampil_Click(sender, e)
                    Else
                        MsgBox(odmhs.pesan, MsgBoxStyle.Critical, "Penghapusan GAGAL")
                    End If

                End Using
            End Using

            ' Menutup respons
            response.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSisip_Click(sender As System.Object, e As System.EventArgs) Handles btnSisip.Click
        f_addedit_MHS.Show()
        Me.Close()
    End Sub

    Private Sub btnUbah_Click(sender As System.Object, e As System.EventArgs) Handles btnUbah.Click
        With f_addedit_MHS
            .Show()
            .oldmhs.nim = lvMHS.Items(lvMHS.FocusedItem.Index).SubItems(0).Text
            .oldmhs.nama = lvMHS.Items(lvMHS.FocusedItem.Index).SubItems(1).Text
            .oldmhs.jenis_kelamin = lvMHS.Items(lvMHS.FocusedItem.Index).SubItems(2).Text
            .oldmhs.tempat_lahir = lvMHS.Items(lvMHS.FocusedItem.Index).SubItems(3).Text
            .oldmhs.tanggal_lahir = lvMHS.Items(lvMHS.FocusedItem.Index).SubItems(4).Text
            .oldmhs.masuk = lvMHS.Items(lvMHS.FocusedItem.Index).SubItems(5).Text
            .oldmhs.keluar = lvMHS.Items(lvMHS.FocusedItem.Index).SubItems(6).Text

            If .oldmhs.keluar = "0000-00-00" Or .oldmhs.keluar = "" Then
                .oldmhs.keluar = ""
                .dtpKeluar.Checked = False
            Else
                .dtpKeluar.Checked = True
            End If

            .txtNIM.Text = .oldmhs.nim
            .txtNama.Text = .oldmhs.nama
            If .oldmhs.jenis_kelamin = "L" Then
                .rbL.Checked = True
                .rbP.Checked = False
            Else
                .rbL.Checked = False
                .rbP.Checked = True
            End If
            .txtTempat_Lahir.Text = .oldmhs.tempat_lahir
            .dtpTanggal_Lahir.Text = .oldmhs.tanggal_lahir
            .dtpMasuk.Text = .oldmhs.masuk
            .dtpKeluar.Text = .oldmhs.keluar
        End With
        Me.Close()
    End Sub

    Private Sub f_mhs_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Membentuk Listview secara 
        lvMHS.View = View.Details
        lvMHS.Columns.Clear()
        lvMHS.Columns.Add("Nim", 100, HorizontalAlignment.Center)
        lvMHS.Columns.Add("Nama", 200, HorizontalAlignment.Left)
        lvMHS.Columns.Add("Jenis Kelamin", 100, HorizontalAlignment.Center)
        lvMHS.Columns.Add("Tempat Lahir", 150, HorizontalAlignment.Left)
        lvMHS.Columns.Add("Tanggal Lahir", 100, HorizontalAlignment.Center)
        lvMHS.Columns.Add("Masuk", 100, HorizontalAlignment.Center)
        lvMHS.Columns.Add("Keluar", 100, HorizontalAlignment.Center)
        btnTampil_Click(sender, e)
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTampil_Click(sender, e)
        End If
    End Sub

End Class
