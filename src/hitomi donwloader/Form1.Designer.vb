<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebControl1 = New EO.WinForm.WebControl()
        Me.WebView1 = New EO.WebBrowser.WebView()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.main = New System.Windows.Forms.TableLayoutPanel()
        Me.line3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Save = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Manga_Num = New System.Windows.Forms.TextBox()
        Me.Download = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Previous_Page = New System.Windows.Forms.Button()
        Me.Next_Page = New System.Windows.Forms.Button()
        Me.Move_Page = New System.Windows.Forms.Button()
        Me.line2 = New System.Windows.Forms.TableLayoutPanel()
        Me.line1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Page_Num = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.main.SuspendLayout()
        Me.line3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebControl1
        '
        Me.WebControl1.BackColor = System.Drawing.Color.White
        Me.WebControl1.Location = New System.Drawing.Point(1004, 510)
        Me.WebControl1.Name = "WebControl1"
        Me.WebControl1.Size = New System.Drawing.Size(284, 261)
        Me.WebControl1.TabIndex = 0
        Me.WebControl1.Text = "WebControl1"
        Me.WebControl1.WebView = Me.WebView1
        '
        'WebView1
        '
        Me.WebView1.InputMsgFilter = Nothing
        Me.WebView1.ObjectForScripting = Nothing
        Me.WebView1.Title = Nothing
        Me.WebView1.Url = "https://hitomi.la/index-korean-1.html"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(-268, 80)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(250, 250)
        Me.WebBrowser1.TabIndex = 2
        Me.WebBrowser1.Url = New System.Uri("https://www.google.com", System.UriKind.Absolute)
        '
        'main
        '
        Me.main.ColumnCount = 1
        Me.main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.main.Controls.Add(Me.line3, 0, 2)
        Me.main.Controls.Add(Me.line2, 0, 1)
        Me.main.Controls.Add(Me.line1, 0, 0)
        Me.main.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.main.Location = New System.Drawing.Point(0, 0)
        Me.main.Margin = New System.Windows.Forms.Padding(0)
        Me.main.Name = "main"
        Me.main.RowCount = 4
        Me.main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.main.Size = New System.Drawing.Size(1072, 562)
        Me.main.TabIndex = 8
        '
        'line3
        '
        Me.line3.ColumnCount = 6
        Me.line3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.line3.Controls.Add(Me.TableLayoutPanel1, 5, 0)
        Me.line3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.line3.Location = New System.Drawing.Point(0, 358)
        Me.line3.Margin = New System.Windows.Forms.Padding(0)
        Me.line3.Name = "line3"
        Me.line3.RowCount = 2
        Me.line3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.line3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.line3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.line3.Size = New System.Drawing.Size(1072, 179)
        Me.line3.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(536, 1)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.line3.SetRowSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(535, 177)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(357, 0)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(178, 177)
        Me.ListBox1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Save, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Add, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Delete, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Manga_Num, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Download, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(178, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(177, 177)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Save
        '
        Me.Save.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Save.Location = New System.Drawing.Point(0, 50)
        Me.Save.Margin = New System.Windows.Forms.Padding(0)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(88, 127)
        Me.Save.TabIndex = 4
        Me.Save.Text = "저장하기"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Add.Location = New System.Drawing.Point(88, 0)
        Me.Add.Margin = New System.Windows.Forms.Padding(0)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(89, 25)
        Me.Add.TabIndex = 0
        Me.Add.Text = "추가 ->"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Delete.Location = New System.Drawing.Point(88, 25)
        Me.Delete.Margin = New System.Windows.Forms.Padding(0)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(89, 25)
        Me.Delete.TabIndex = 1
        Me.Delete.Text = "<- 삭제"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Manga_Num
        '
        Me.Manga_Num.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Manga_Num.Location = New System.Drawing.Point(0, 2)
        Me.Manga_Num.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Manga_Num.Name = "Manga_Num"
        Me.Manga_Num.Size = New System.Drawing.Size(88, 21)
        Me.Manga_Num.TabIndex = 2
        '
        'Download
        '
        Me.Download.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Download.Location = New System.Drawing.Point(88, 50)
        Me.Download.Margin = New System.Windows.Forms.Padding(0)
        Me.Download.Name = "Download"
        Me.Download.Size = New System.Drawing.Size(89, 127)
        Me.Download.TabIndex = 3
        Me.Download.Text = "다운로드"
        Me.Download.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Previous_Page, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Next_Page, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Move_Page, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(177, 177)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Previous_Page
        '
        Me.Previous_Page.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Previous_Page.Location = New System.Drawing.Point(0, 0)
        Me.Previous_Page.Margin = New System.Windows.Forms.Padding(0)
        Me.Previous_Page.Name = "Previous_Page"
        Me.Previous_Page.Size = New System.Drawing.Size(177, 59)
        Me.Previous_Page.TabIndex = 0
        Me.Previous_Page.Text = "이전 페이지"
        Me.Previous_Page.UseVisualStyleBackColor = True
        '
        'Next_Page
        '
        Me.Next_Page.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Next_Page.Location = New System.Drawing.Point(0, 59)
        Me.Next_Page.Margin = New System.Windows.Forms.Padding(0)
        Me.Next_Page.Name = "Next_Page"
        Me.Next_Page.Size = New System.Drawing.Size(177, 59)
        Me.Next_Page.TabIndex = 1
        Me.Next_Page.Text = "다음 페이지"
        Me.Next_Page.UseVisualStyleBackColor = True
        '
        'Move_Page
        '
        Me.Move_Page.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Move_Page.Location = New System.Drawing.Point(0, 118)
        Me.Move_Page.Margin = New System.Windows.Forms.Padding(0)
        Me.Move_Page.Name = "Move_Page"
        Me.Move_Page.Size = New System.Drawing.Size(177, 59)
        Me.Move_Page.TabIndex = 2
        Me.Move_Page.Text = "페이지 이동"
        Me.Move_Page.UseVisualStyleBackColor = True
        '
        'line2
        '
        Me.line2.ColumnCount = 10
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.line2.Location = New System.Drawing.Point(0, 179)
        Me.line2.Margin = New System.Windows.Forms.Padding(0)
        Me.line2.Name = "line2"
        Me.line2.RowCount = 2
        Me.line2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.line2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.line2.Size = New System.Drawing.Size(1072, 179)
        Me.line2.TabIndex = 1
        '
        'line1
        '
        Me.line1.BackColor = System.Drawing.SystemColors.Control
        Me.line1.ColumnCount = 10
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.line1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.line1.Location = New System.Drawing.Point(0, 0)
        Me.line1.Margin = New System.Windows.Forms.Padding(0)
        Me.line1.Name = "line1"
        Me.line1.RowCount = 2
        Me.line1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.line1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.line1.Size = New System.Drawing.Size(1072, 179)
        Me.line1.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Page_Num, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 537)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1072, 25)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'Page_Num
        '
        Me.Page_Num.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Page_Num.Location = New System.Drawing.Point(518, 0)
        Me.Page_Num.Margin = New System.Windows.Forms.Padding(0)
        Me.Page_Num.Name = "Page_Num"
        Me.Page_Num.Size = New System.Drawing.Size(36, 21)
        Me.Page_Num.TabIndex = 0
        Me.Page_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 562)
        Me.Controls.Add(Me.main)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.WebControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Hitomi Downloader"
        Me.main.ResumeLayout(False)
        Me.line3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebControl1 As EO.WinForm.WebControl
    Friend WithEvents WebView1 As EO.WebBrowser.WebView
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents main As TableLayoutPanel
    Friend WithEvents line1 As TableLayoutPanel
    Friend WithEvents line2 As TableLayoutPanel
    Friend WithEvents line3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Add As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Manga_Num As TextBox
    Friend WithEvents Download As Button
    Friend WithEvents Save As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Previous_Page As Button
    Friend WithEvents Next_Page As Button
    Friend WithEvents Move_Page As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Page_Num As TextBox
    Friend WithEvents Timer1 As Timer
End Class
