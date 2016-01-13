Imports System.Threading
Public Class Main_Page
   'shortcut key input
    Private Sub Main_Page_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'showdropdown list when enter alt+F and automatic select the first enabled item   
        If My.Computer.Keyboard.AltKeyDown AndAlso e.KeyCode = Keys.F Then
            tsbFile.ShowDropDown()
            tsmAbout.Select()
        End If
        'showdropdown list when enter alt+L and automatic select the first enabled item   
        If My.Computer.Keyboard.AltKeyDown AndAlso e.KeyCode = Keys.L Then
            tsbLanguage.ShowDropDown()
            If tsmEnglish.Enabled = False Then
                tsmJapanese.Select()
            ElseIf tsmJapanese.Enabled = False Or tsmChinese.Enabled = False Then
                tsmEnglish.Select()
            End If
        End If
        'escape when enter esc key
        If e.KeyCode = Keys.Escape Then tsmExit.PerformClick()
    End Sub

    Private Sub Main_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLanguagePack() 'every page have to read languagepack first
    End Sub

    Private Sub englishPack()
        tsmEnglish.Enabled = False
        tsmChinese.Enabled = True
        tsmJapanese.Enabled = True
        tsbFile.Text = "File(F)"
        tsmAbout.Text = "About"
        tsmExit.Text = "Exit(E)        Esc"
        tsbLanguage.Text = "Language(L)"
        tsmEnglish.Text = "English(E)"
        tsmJapanese.Text = "Japanese(J)"
        tsmChinese.Text = "Chinese(C)"
        btnBirthChart.Text = "Birth Chart"
        btnExit.Text = "Exit"
        Me.Text = "English Version Main Page"
    End Sub

    Private Sub japanesePack()
        tsmJapanese.Enabled = False
        tsmChinese.Enabled = True
        tsmEnglish.Enabled = True
        tsbFile.Text = "ファイル(F)"
        tsmAbout.Text = "について"
        tsmExit.Text = "出口(E)         Esc"
        tsbLanguage.Text = "言語(L)"
        tsmEnglish.Text = "英語(E)"
        tsmJapanese.Text = "日本語(J)"
        tsmChinese.Text = "中国語(C)"
        btnBirthChart.Text = "干支五行"
        btnExit.Text = "出口"
        Me.Text = "日本語版メインページ"
    End Sub

    Private Sub chinesePack()
        tsmChinese.Enabled = False
        tsmJapanese.Enabled = True
        tsmEnglish.Enabled = True
        tsbFile.Text = "檔案(F)"
        tsmAbout.Text = "關於"
        tsmExit.Text = "結束          Esc"
        tsbLanguage.Text = "語言(L)"
        tsmEnglish.Text = "英文(E)"
        tsmJapanese.Text = "日文(J)"
        tsmChinese.Text = "中文(C)"
        btnBirthChart.Text = "生肖五型"
        btnExit.Text = "結束"
        Me.Text = "中文版主頁"
    End Sub

    Private Sub btnBirthChart_Click(sender As Object, e As EventArgs) Handles btnBirthChart.Click
        Me.Hide()
        Birth_Chart.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If tsmEnglish.Enabled = False Then
            If MsgBox("Are your sure to exit?", vbYesNo, "Exit") = MsgBoxResult.Yes Then Application.Exit()
        ElseIf tsmJapanese.Enabled = False Then
            If MsgBox("プログラムを終了すですか？", vbYesNo, "終了") = MsgBoxResult.Yes Then Application.Exit()
        ElseIf tsmChinese.Enabled = False Then
            If MsgBox("確定要結束程式?", vbYesNo, "結束") = MsgBoxResult.Yes Then Application.Exit()
        End If
    End Sub
    'below for most of page need
    Private Sub SetLanguagePack()
        Select Case (Thread.CurrentThread.CurrentCulture.Name)
            Case "zh-TW" 'traditional chinese
                chinesePack()
                Return
            Case "zh-HK"
                chinesePack()
                Return
            Case "zh-CN" 'simplefied chinese
                Return
            Case "zh-SG"
                Return
            Case "ja-JP" 'japanese
                japanesePack()
                Return
            Case "ko-KR" 'korean
                Return
            Case "th-TH" 'thai
                Return
            Case Else 'else to english
                englishPack()
                Return
        End Select
    End Sub

    Private Sub tsmAbout_Click(sender As Object, e As EventArgs) Handles tsmAbout.Click
        If tsmChinese.Enabled = False Then
            MessageBox.Show("此程式儘供參考，若有疑問請來信（E-Mail:Virginia.chien@gmail.com）" & vbCrLf & "或點擊""說明""按鈕進入個人網頁，謝謝。", "關於", MessageBoxButtons.OK, 0, MessageBoxDefaultButton.Button1, 0, "https://github.com/VirginiaChien", "")
        ElseIf tsmJapanese.Enabled = False Then
            MessageBox.Show("このプログラムは参照専用、質問は（E-Mail:Virginia.chien@gmail.com）" & vbCrLf & "またはプレス情報ボタンをウェブサイトへ入します、ありがとう。", "紹介", MessageBoxButtons.OK, 0, MessageBoxDefaultButton.Button1, 0, "https://github.com/VirginiaChien", "")
        Else
            MessageBox.Show("This program for reference only, qustion me to(E-Mail:Virginia.chien@gmail.com)" & vbCrLf & "or click ""information""to entry website Thanks.", "About", MessageBoxButtons.OK, 0, MessageBoxDefaultButton.Button1, 0, "https://github.com/VirginiaChien", "")
        End If
    End Sub

    Private Sub tsmEnglish_Click(sender As Object, e As EventArgs) Handles tsmEnglish.Click
        englishPack()
    End Sub

    Private Sub tsmJapanese_Click(sender As Object, e As EventArgs) Handles tsmJapanese.Click
        japanesePack()
    End Sub

    Private Sub tsmChinese_Click(sender As Object, e As EventArgs) Handles tsmChinese.Click
        chinesePack()
    End Sub

    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        If tsmEnglish.Enabled = False Then
            If MsgBox("Are your sure to exit?", vbYesNo, "Exit") = MsgBoxResult.Yes Then Application.Exit()
        ElseIf tsmJapanese.Enabled = False Then
            If MsgBox("プログラムを終了すですか？", vbYesNo, "終了") = MsgBoxResult.Yes Then Application.Exit()
        ElseIf tsmChinese.Enabled = False Then
            If MsgBox("確定要結束程式?", vbYesNo, "結束") = MsgBoxResult.Yes Then Application.Exit()
        End If
    End Sub

End Class

