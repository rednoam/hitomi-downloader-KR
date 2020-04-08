Imports System.IO

Module hitomi
    Dim defualt_path As String = "manga\"
    Dim Reader_url As String = "https://hitomi.la/reader/"
    Function Hash_From_Image(WB As WebBrowser, ByRef URL() As String) As Boolean
        Dim Length As Integer = 0
        Dim argv(0) As Object
        Dim hash As String = ""
        Try
            If Not Gallery_Image_length(WB, Length) Then
                MsgBox("이미지 갯수를 가져오지 못했습니다.")
                Return False
            End If
            ReDim URL(Length - 1)
            For i As Integer = 0 To Length - 1
                argv(0) = i
                hash = WB.Document.InvokeScript("hash", argv).ToString
                URL(i) = Url_From_Hash(hash)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function URL_From_URL(url As String) As String
        Return Replace(url, "a.hitomi.la", Subdomain_From_URL(url) & ".hitomi.la")
    End Function

    Function Subdomain_From_URL(url As String) As String
        Try
            Dim retval As String = "a"
            Dim number_of_frontends As Integer = 3
            Dim b As Integer = 16
            Dim m() As String = url.Split("/")
            Dim g As Integer = Convert.ToInt32("0x" & m(4), b)
            If g < &H30 Then
                number_of_frontends = 2
            End If
            If g < &H9 Then
                g = 1
            End If
            retval = Subdomain_From_Galleryid(g, number_of_frontends) & retval
            Return retval
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function Subdomain_From_Galleryid(g As Integer, number_of_frontends As Integer) As String
        Dim o As Integer = g Mod number_of_frontends
        Return Chr(97 + o)
    End Function

    Function Url_From_Hash(hash As String) As String
        Dim Url As String = ""
        Url = "https://a.hitomi.la/" & "webp/" & Right(hash, 1) & "/" & Left(Right(hash, 3), 2) & "/" & hash & ".webp"
        Return URL_From_URL(Url)
    End Function

    Function Manga_Download(WB As WebBrowser, manga_num As String, name As String) As Boolean
        Try
            Dim URL() As String
            Dim Data() As Byte
            Dim WC As New Net.WebClient
            Dim BM As Bitmap
            My.Computer.FileSystem.CreateDirectory(defualt_path & name.Replace("\", " ").Replace("/", " ").Replace("*", " ").Replace("?", " ").Replace("""", " ").Replace("<", " ").Replace(">", " ").Replace("|", " "))
            name = name.Replace("\", " ").Replace("/", " ").Replace("*", " ").Replace("?", " ").Replace("""", " ").Replace("<", " ").Replace(">", " ").Replace("|", " ")
            GalleryInfo_Puts(WB, manga_num)
            Hash_From_Image(WB, URL)
            Progress.Setting(name, URL.Count)
            For i As Integer = 0 To URL.Count - 1
                WC.Headers.Item(Net.HttpRequestHeader.Referer) = Reader_url & manga_num & ".html"
                Data = WC.DownloadData(URL(i))
                BM = Webp_to_Png(Data)
                BM.Save(defualt_path & name & "\" & i + 1 & ".png", Imaging.ImageFormat.Png)
                BM.Dispose()
                Progress.ProgressBar1.PerformStep()
            Next
            Progress.Close()
            Return True
        Catch ex As Exception
            Progress.Close()
            MsgBox(ex.Message)
            My.Computer.FileSystem.DeleteDirectory(defualt_path & name, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Return False
        End Try
    End Function
End Module
