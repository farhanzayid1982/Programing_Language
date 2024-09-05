Imports System
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization

Public Class f_addedit_MHS
    Public Property oldmhs As New Mhs

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Apakah akan menyimpan data " & txtNIM.Text, vbYesNo, "Konfirmasi") = vbNo Then
            Exit Sub
        End If
        ' URL yang ingin Anda minta
        Dim url As String = "http://localhost:8080"
        Dim perintah As String

        'Pemelihan perintah berdasarkan data yg dikirimkan
        If IsNothing(oldmhs.nim) Then
            perintah = "sisipMHS"
        Else
            perintah = "ubahMHS"
        End If

        ' Data yang ingin Anda kirim (dalam format JSON dalam contoh ini)
        Dim data As String = "{""data"":{""perintah"":""" & perintah & """" '& _
        If perintah = "ubahMHS" Then
            data = data & ",""oldnim"":""" & oldmhs.nim & """"
        End If
        data = data & _
            ",""nim"":""" & txtNIM.Text & """" & _
            ", ""nama"":""" & txtNama.Text & """" & _
            ", ""tempat_lahir"":""" & txtTempat_Lahir.Text & """" & _
            ", ""tanggal_lahir"":""" & dtpTanggal_Lahir.Text & """" & _
            ", ""jenis_kelamin"":""" & IIf(rbL.Checked, "L", "P") & """" & _
            ", ""masuk"":""" & dtpMasuk.Text & """" & _
            ", ""keluar"":""" & IIf(dtpKeluar.Checked, dtpKeluar.Text, "") & """" & _
            "},""kunci"":""12345""}"

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
                        MsgBox("Penyimpanan SUKSES", vbOKOnly, "Informasi")

                        f_mhs.Show()
                        Me.Close()
                    Else
                        MsgBox(odmhs.pesan, MsgBoxStyle.Critical, "Penyimpanan GAGAL")
                    End If

                End Using
            End Using

            ' Menutup respons
            response.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As System.Object, e As System.EventArgs) Handles btnBatal.Click
        f_mhs.Show()
        Me.Close()
    End Sub
End Class