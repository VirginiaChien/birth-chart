<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Page
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Page))
        Me.btnBirthChart = New System.Windows.Forms.Button()
        Me.tsChart = New System.Windows.Forms.ToolStrip()
        Me.tsbFile = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbLanguage = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmJapanese = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmChinese = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tsChart.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBirthChart
        '
        Me.btnBirthChart.Location = New System.Drawing.Point(43, 411)
        Me.btnBirthChart.Name = "btnBirthChart"
        Me.btnBirthChart.Size = New System.Drawing.Size(155, 36)
        Me.btnBirthChart.TabIndex = 1
        Me.btnBirthChart.Text = "生肖五型"
        Me.btnBirthChart.UseVisualStyleBackColor = True
        '
        'tsChart
        '
        Me.tsChart.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFile, Me.tsbLanguage})
        Me.tsChart.Location = New System.Drawing.Point(0, 0)
        Me.tsChart.Name = "tsChart"
        Me.tsChart.Size = New System.Drawing.Size(709, 37)
        Me.tsChart.TabIndex = 8
        Me.tsChart.Text = "ToolStrip1"
        '
        'tsbFile
        '
        Me.tsbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAbout, Me.tsmExit})
        Me.tsbFile.Image = CType(resources.GetObject("tsbFile.Image"), System.Drawing.Image)
        Me.tsbFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFile.Name = "tsbFile"
        Me.tsbFile.Size = New System.Drawing.Size(103, 34)
        Me.tsbFile.Tag = ""
        Me.tsbFile.Text = "檔案(F)"
        Me.tsbFile.ToolTipText = "File (Alt + F)"
        '
        'tsmAbout
        '
        Me.tsmAbout.Name = "tsmAbout"
        Me.tsmAbout.Size = New System.Drawing.Size(230, 34)
        Me.tsmAbout.Text = "關於"
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(230, 34)
        Me.tsmExit.Text = "結束          Esc"
        Me.tsmExit.ToolTipText = "Exit (Esc)"
        '
        'tsbLanguage
        '
        Me.tsbLanguage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbLanguage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEnglish, Me.tsmJapanese, Me.tsmChinese})
        Me.tsbLanguage.Image = CType(resources.GetObject("tsbLanguage.Image"), System.Drawing.Image)
        Me.tsbLanguage.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLanguage.Name = "tsbLanguage"
        Me.tsbLanguage.Size = New System.Drawing.Size(102, 34)
        Me.tsbLanguage.Text = "語言(L)"
        Me.tsbLanguage.ToolTipText = "Language (Alt + L)"
        '
        'tsmEnglish
        '
        Me.tsmEnglish.Name = "tsmEnglish"
        Me.tsmEnglish.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.tsmEnglish.Size = New System.Drawing.Size(253, 34)
        Me.tsmEnglish.Text = "英文(E)"
        Me.tsmEnglish.ToolTipText = "English (Ctrl + E)"
        '
        'tsmJapanese
        '
        Me.tsmJapanese.Name = "tsmJapanese"
        Me.tsmJapanese.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.tsmJapanese.Size = New System.Drawing.Size(253, 34)
        Me.tsmJapanese.Text = "日文(J)"
        Me.tsmJapanese.ToolTipText = "Japanese (Ctrl + J)"
        '
        'tsmChinese
        '
        Me.tsmChinese.Name = "tsmChinese"
        Me.tsmChinese.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsmChinese.Size = New System.Drawing.Size(253, 34)
        Me.tsmChinese.Text = "中文(C)"
        Me.tsmChinese.ToolTipText = "Chinese (Ctrl + C)"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(503, 411)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(155, 36)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "結束"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Main_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 469)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tsChart)
        Me.Controls.Add(Me.btnBirthChart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Main_Page"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_Page"
        Me.tsChart.ResumeLayout(False)
        Me.tsChart.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBirthChart As System.Windows.Forms.Button
    Friend WithEvents tsChart As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbFile As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbLanguage As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmEnglish As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmJapanese As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmChinese As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
