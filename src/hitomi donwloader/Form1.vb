Imports System.Runtime.InteropServices
Imports EO.WebBrowser
Public Class Form1
    Dim Page As Integer = 1
    Dim Url As String = "https://hitomi.la/index-korean-"
    Dim Html_Code As String
    Dim Gallery As String
    Public PictureBoxs(24) As PictureBox
    Public CheckBoxs(24) As CheckBox
    Dim line(2) As TableLayoutPanel

    Private Declare Auto Function PostMessage Lib "user32" (ByVal hwnd As Integer, ByVal message As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As Boolean
    Declare Function GetDesktopWindow Lib "user32" Alias "GetDesktopWindow" () As IntPtr
    Declare Function GetClassName Lib "user32" Alias "GetClassNameA" (ByVal hwnd As Integer, ByVal lpClassName As String, ByVal nMaxCount As Integer) As Integer
    <DllImport("user32")>
    Public Shared Function FindWindowEx(ByVal parentHandle As IntPtr, ByVal childAfter As IntPtr, ByVal lclassName As String, ByVal windowTitle As String) As IntPtr
    End Function
    Private Sub WebView1_LoadCompleted(sender As Object, e As LoadCompletedEventArgs) Handles WebView1.LoadCompleted
        Html_Code = WebView1.GetHtml()
        'If html_check(Html_Code) Then
        If Not Gallery_Export(Html_Code) Then
            MsgBox("목록을 추출하는데 실패했습니다")
            Exit Sub
        End If
        Control_Enable()
        Page_Num.Text = Page
        'End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Previous_Page.Enabled = False
        TableLayoutPanel1.Enabled = False
        Dim x As Integer = 0
        Dim n As Integer = 0
        line(0) = line1
        line(1) = line2
        line(2) = line3
        For i As Integer = 0 To 24
            PictureBoxs(i) = New PictureBox
            PictureBoxs(i).CreateControl()
            PictureBoxs(i).Dock = DockStyle.Fill
            PictureBoxs(i).SizeMode = PictureBoxSizeMode.StretchImage
            PictureBoxs(i).Margin = New Padding(1, 1, 1, 1)
            CheckBoxs(i) = New CheckBox
            CheckBoxs(i).CreateControl()
            CheckBoxs(i).Dock = DockStyle.Fill
            CheckBoxs(i).Margin = New Padding(1, 1, 1, 1)
            CheckBoxs(i).Enabled = False
            If x = 9 Then
                line(n).Controls.Add(PictureBoxs(i), x, 0)
                line(n).Controls.Add(CheckBoxs(i), x, 1)
                x = 0
                n += 1
            Else
                line(n).Controls.Add(PictureBoxs(i), x, 0)
                line(n).Controls.Add(CheckBoxs(i), x, 1)
                x += 1
            End If
        Next
    End Sub

    Private Shadows Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If Not Manga_Num.Text.Contains(" ") Then
            ListBox1.Items.Add(Manga_Num.Text)
        End If
    End Sub

    Sub Control_Enable()
        For i As Integer = 0 To 24
            CheckBoxs(i).Enabled = True
        Next
        TableLayoutPanel1.Enabled = True
    End Sub

    Private Sub Previous_Page_Click(sender As Object, e As EventArgs) Handles Previous_Page.Click
        Image_Clear()
        CheckBox_Text_Clear()
        Page -= 1
        WebView1.Url = Url & Page & ".html"
        Page_Num.Text = Page
    End Sub

    Private Sub Next_Page_Click(sender As Object, e As EventArgs) Handles Next_Page.Click
        Image_Clear()
        CheckBox_Text_Clear()
        Page += 1
        WebView1.Url = Url & Page & ".html"
        Page_Num.Text = Page
    End Sub

    Private Sub Move_Page_Click(sender As Object, e As EventArgs) Handles Move_Page.Click
        If Page_Num.Text < 1 Then
            MsgBox("1페이지 이상 설정해주세요")
        Else
            Image_Clear()
            CheckBox_Text_Clear()
            WebView1.Url = Url & Page_Num.Text & ".html"
            Page = Page_Num.Text
        End If
    End Sub

    Private Sub Page_Num_TextChanged(sender As Object, e As EventArgs) Handles Page_Num.TextChanged
        If Page = 1 Then
            Previous_Page.Enabled = False
        Else
            Previous_Page.Enabled = True
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If Not Add_Manga_Number() Then
            MsgBox("저장하는데 문제가 발생했습니다.")
        End If
        CheckBox_Clear()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        Catch ex As Exception

        End Try
    End Sub
    Sub Image_Clear()
        For i As Integer = 0 To 24
            PictureBoxs(i).ImageLocation = ""
        Next
    End Sub

    Sub CheckBox_Clear()
        For i As Integer = 0 To 24
            CheckBoxs(i).Checked = False
        Next
    End Sub

    Sub CheckBox_Text_Clear()
        For i As Integer = 0 To 24
            CheckBoxs(i).Text = ""
        Next
    End Sub

    Sub ListBox_Clear()
        For i As Integer = ListBox1.Items.Count To 0 Step -1
            ListBox1.Items.RemoveAt(i)
        Next
    End Sub

    Private Sub Download_Click(sender As Object, e As EventArgs) Handles Download.Click
        Dim FI As IO.FileInfo = New IO.FileInfo("manga")
        If Not FI.Exists Then
            My.Computer.FileSystem.CreateDirectory("manga")
        End If
        For i As Integer = 0 To ListBox1.Items.Count - 1
            Me.Hide()
            If Not Manga_Download(WebBrowser1, Split(ListBox1.Items.Item(i), "&")(0), Split(ListBox1.Items.Item(i), "&")(1)) Then
                MsgBox("""" & Split(ListBox1.Items.Item(i), "&")(1) & """" & " 다운로드를 실패했습니다. 다음 망가를 다운합니다.")
            End If
        Next
        ListBox_Clear()
        Me.Show()
    End Sub

    Sub aa()
        Dim desktop As IntPtr = GetDesktopWindow
        If Not desktop = IntPtr.Zero Then
            Dim temp As IntPtr = Nothing
            While True
                temp = FindWindowEx(desktop, temp, Nothing, "")
                Dim name As String = Space(100)
                GetClassName(temp, name, 100)
                If name.Contains("eo.nativewnd") Then
                    PostMessage(temp, &H12, 0, 0)
                    Timer1.Enabled = False
                    Exit While
                End If
            End While
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        aa()
    End Sub
End Class