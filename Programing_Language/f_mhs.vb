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

                End Using
            End Using

            ' Menutup respons
            response.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try


    End Sub
End Class
