Module html
    Dim galleryinfo_url As String = "https://ltn.hitomi.la/galleries/"
    Dim HTML_Element As String
    Dim Gallery As String
    Dim WB As WebBrowser
    Function Gallery_Export(Html_Code As String) As Boolean
        Try
            HTML_Element = Html_Code
            Gallery = Split(Html_Code, "<div class=""gallery-content"">")(1)
            Gallery = Split(Gallery, "<div id=""loader-content"" style=""display: none;"">")(0)
            If Not List_Split() Then
                MsgBox("데이터를 나누는데 실패했습니다.")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function List_Split() As Boolean
        Dim Title(24), Number(24), Preview(24) As String
        Dim temp_list() As String
        Dim a As Boolean = True
        Dim i As Integer = 0
        Try
            temp_list = Split(Gallery, "<h1 class=""lillie"">")
            For Each manga In temp_list
                If a Then
                    a = False
                    Continue For
                End If
                Dim temp As String = Split(manga, "</a>")(0)
                Title(i) = Split(temp, ">")(1)
                Number(i) = Split(temp, ">")(0).Split("-")(Split(temp, ">")(0).Split("-").Count - 1).Split(".")(0)
                i += 1
            Next
            temp_list = Split(Gallery, "-img1""> <img class=""lazy"" data-srcset=""//")
            a = True
            i = 0
            For Each manga In temp_list
                If a Then
                    a = False
                    Continue For
                End If
                Preview(i) = Split(manga, " 2x,")(0)
                i += 1
            Next
            If Not Save_Manga_Data(Number, Title, Preview) Then
                MsgBox("데이터를 저장하는데 실패했습니다.")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function GalleryInfo_Puts(WB As WebBrowser, manga_num As String) As Boolean
        Try
            Dim GalleryInfo As String = ""
            Dim GalleryData() As Byte
            Using WC As New Net.WebClient
                GalleryData = WC.DownloadData(galleryinfo_url & manga_num & ".js")
                GalleryInfo = Text.Encoding.UTF8.GetString(GalleryData) & ";"
            End Using
            Dim head As HtmlElement = WB.Document.GetElementsByTagName("head")(0)
            Dim script As HtmlElement = WB.Document.CreateElement("script")
            script.SetAttribute("text", "function hash(num) { " & GalleryInfo & " return galleryinfo[""files""][num].hash;" & " }")
            head.AppendChild(script)
            head = WB.Document.GetElementsByTagName("head")(0)
            script = WB.Document.CreateElement("script")
            script.SetAttribute("text", "function gallery_Length() { " & GalleryInfo & " return galleryinfo[""files""].length;" & " }")
            head.AppendChild(script)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Gallery_Image_length(WB As WebBrowser, ByRef Int As Integer) As Boolean
        Try
            Int = WB.Document.InvokeScript("gallery_Length").ToString
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function html_check(Html_Code As String) As Boolean
        Dim a As String = Html_Code
        Dim b As String = Split(a, "<div class=""gallery-content"">")(1)
        b = Split(b, "<div id=""loader-content"" style=""display: none;"">")(0)
        Dim temp_list() As String
        temp_list = Split(Gallery, "<h1 class=""lillie"">")
        If temp_list.Count = 26 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module