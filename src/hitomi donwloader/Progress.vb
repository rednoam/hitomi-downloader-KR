Public Class Progress
    Public Sub Setting(name As String, Count As Integer)
        Me.Show()
        Me.Text = name & " 다운로드 중..."
        ProgressBar1.Maximum = Count
    End Sub
End Class