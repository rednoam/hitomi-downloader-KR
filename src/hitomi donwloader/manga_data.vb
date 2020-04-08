Module manga_data
    Dim List(24, 2) As String
    Function Save_Manga_Data(Number() As String, Title() As String, Preview() As String) As Boolean
        Try
            For i As Integer = 0 To 24
                List(i, 0) = Number(i)
                List(i, 1) = Title(i)
                List(i, 2) = "https://" & Preview(i)
            Next
            If Not Puts_Manga_Data() Then
                MsgBox("데이터를 불러오는데 실패했습니다.")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Puts_Manga_Data() As Boolean
        Try
            For i As Integer = 0 To 24
                Form1.PictureBoxs(i).ImageLocation = List(i, 2)
                Form1.CheckBoxs(i).Text = List(i, 1)
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function Add_Manga_Number() As Boolean
        Try
            For i As Integer = 0 To 24
                If Form1.CheckBoxs(i).Checked Then
                    If Form1.ListBox1.Items.Count = 0 Then
                        Form1.ListBox1.Items.Add(List(i, 0) & "&" & List(i, 1))
                    Else
                        For check As Integer = 0 To Form1.ListBox1.Items.Count - 1
                            If Split(Form1.ListBox1.Items.Item(check), "&")(0) = List(i, 0) Then
                                Exit For
                            ElseIf check = Form1.ListBox1.Items.Count - 1 Then
                                Form1.ListBox1.Items.Add(List(i, 0) & "&" & List(i, 1))
                            End If
                        Next
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Module
