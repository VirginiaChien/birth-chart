<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Birth_Chart
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Birth_Chart))
        Me.btnChartStart = New System.Windows.Forms.Button()
        Me.lblBBirth = New System.Windows.Forms.Label()
        Me.dtpBBirth = New System.Windows.Forms.DateTimePicker()
        Me.lblGBirth = New System.Windows.Forms.Label()
        Me.dtpGBirth = New System.Windows.Forms.DateTimePicker()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtChart = New System.Windows.Forms.TextBox()
        Me.tsChart = New System.Windows.Forms.ToolStrip()
        Me.tsbFile = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbLanguage = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmJapanese = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmChinese = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbOb = New System.Windows.Forms.CheckBox()
        Me.cbOg = New System.Windows.Forms.CheckBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnAboutme = New System.Windows.Forms.Button()
        Me.btnMainpage = New System.Windows.Forms.Button()
        Me.tsChart.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChartStart
        '
        Me.btnChartStart.Location = New System.Drawing.Point(43, 411)
        Me.btnChartStart.Name = "btnChartStart"
        Me.btnChartStart.Size = New System.Drawing.Size(155, 36)
        Me.btnChartStart.TabIndex = 0
        Me.btnChartStart.Text = "命盤演算"
        Me.btnChartStart.UseVisualStyleBackColor = True
        '
        'lblBBirth
        '
        Me.lblBBirth.AutoSize = True
        Me.lblBBirth.Location = New System.Drawing.Point(39, 71)
        Me.lblBBirth.Name = "lblBBirth"
        Me.lblBBirth.Size = New System.Drawing.Size(225, 24)
        Me.lblBBirth.TabIndex = 1
        Me.lblBBirth.Text = "1.輸入男方出生日期:"
        '
        'dtpBBirth
        '
        Me.dtpBBirth.Location = New System.Drawing.Point(297, 59)
        Me.dtpBBirth.MinDate = New Date(1900, 1, 31, 0, 0, 0, 0)
        Me.dtpBBirth.Name = "dtpBBirth"
        Me.dtpBBirth.Size = New System.Drawing.Size(222, 36)
        Me.dtpBBirth.TabIndex = 2
        '
        'lblGBirth
        '
        Me.lblGBirth.AutoSize = True
        Me.lblGBirth.Location = New System.Drawing.Point(39, 130)
        Me.lblGBirth.Name = "lblGBirth"
        Me.lblGBirth.Size = New System.Drawing.Size(225, 24)
        Me.lblGBirth.TabIndex = 3
        Me.lblGBirth.Text = "2.輸入女方出生日期:"
        '
        'dtpGBirth
        '
        Me.dtpGBirth.Location = New System.Drawing.Point(297, 118)
        Me.dtpGBirth.MinDate = New Date(1900, 1, 31, 0, 0, 0, 0)
        Me.dtpGBirth.Name = "dtpGBirth"
        Me.dtpGBirth.Size = New System.Drawing.Size(222, 36)
        Me.dtpGBirth.TabIndex = 4
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(39, 189)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(106, 24)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "演算結果"
        '
        'txtChart
        '
        Me.txtChart.Location = New System.Drawing.Point(43, 216)
        Me.txtChart.Multiline = True
        Me.txtChart.Name = "txtChart"
        Me.txtChart.Size = New System.Drawing.Size(616, 176)
        Me.txtChart.TabIndex = 6
        '
        'tsChart
        '
        Me.tsChart.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFile, Me.tsbLanguage})
        Me.tsChart.Location = New System.Drawing.Point(0, 0)
        Me.tsChart.Name = "tsChart"
        Me.tsChart.Size = New System.Drawing.Size(709, 37)
        Me.tsChart.TabIndex = 7
        Me.tsChart.Text = "ToolStrip1"
        '
        'tsbFile
        '
        Me.tsbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSave, Me.tsmLoad, Me.tsmAbout, Me.tsmExit})
        Me.tsbFile.Image = CType(resources.GetObject("tsbFile.Image"), System.Drawing.Image)
        Me.tsbFile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFile.Name = "tsbFile"
        Me.tsbFile.Size = New System.Drawing.Size(103, 34)
        Me.tsbFile.Tag = ""
        Me.tsbFile.Text = "檔案(F)"
        Me.tsbFile.ToolTipText = "File (Alt + F)"
        '
        'tsmSave
        '
        Me.tsmSave.Name = "tsmSave"
        Me.tsmSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmSave.Size = New System.Drawing.Size(249, 34)
        Me.tsmSave.Text = "儲存(S)"
        Me.tsmSave.ToolTipText = "Save (Ctrl + S)"
        '
        'tsmLoad
        '
        Me.tsmLoad.Name = "tsmLoad"
        Me.tsmLoad.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.tsmLoad.Size = New System.Drawing.Size(249, 34)
        Me.tsmLoad.Text = "讀取(L)"
        Me.tsmLoad.ToolTipText = "Load (Ctrl + L)"
        '
        'tsmAbout
        '
        Me.tsmAbout.Name = "tsmAbout"
        Me.tsmAbout.Size = New System.Drawing.Size(249, 34)
        Me.tsmAbout.Text = "關於"
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(249, 34)
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
        'cbOb
        '
        Me.cbOb.AutoSize = True
        Me.cbOb.Location = New System.Drawing.Point(539, 67)
        Me.cbOb.Name = "cbOb"
        Me.cbOb.Size = New System.Drawing.Size(138, 28)
        Me.cbOb.TabIndex = 8
        Me.cbOb.Text = "農曆舊年"
        Me.cbOb.UseVisualStyleBackColor = True
        '
        'cbOg
        '
        Me.cbOg.AutoSize = True
        Me.cbOg.Location = New System.Drawing.Point(539, 126)
        Me.cbOg.Name = "cbOg"
        Me.cbOg.Size = New System.Drawing.Size(138, 28)
        Me.cbOg.TabIndex = 9
        Me.cbOg.Text = "農曆舊年"
        Me.cbOg.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'btnAboutme
        '
        Me.btnAboutme.Location = New System.Drawing.Point(273, 411)
        Me.btnAboutme.Name = "btnAboutme"
        Me.btnAboutme.Size = New System.Drawing.Size(155, 36)
        Me.btnAboutme.TabIndex = 10
        Me.btnAboutme.Text = "關於"
        Me.btnAboutme.UseVisualStyleBackColor = True
        '
        'btnMainpage
        '
        Me.btnMainpage.Location = New System.Drawing.Point(503, 411)
        Me.btnMainpage.Name = "btnMainpage"
        Me.btnMainpage.Size = New System.Drawing.Size(155, 36)
        Me.btnMainpage.TabIndex = 11
        Me.btnMainpage.Text = "回主頁"
        Me.btnMainpage.UseVisualStyleBackColor = True
        '
        'Birth_Chart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 469)
        Me.Controls.Add(Me.btnMainpage)
        Me.Controls.Add(Me.btnAboutme)
        Me.Controls.Add(Me.cbOg)
        Me.Controls.Add(Me.cbOb)
        Me.Controls.Add(Me.tsChart)
        Me.Controls.Add(Me.txtChart)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.dtpGBirth)
        Me.Controls.Add(Me.lblGBirth)
        Me.Controls.Add(Me.dtpBBirth)
        Me.Controls.Add(Me.lblBBirth)
        Me.Controls.Add(Me.btnChartStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Birth_Chart"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "生肖與五型命盤"
        Me.tsChart.ResumeLayout(False)
        Me.tsChart.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnChartStart As System.Windows.Forms.Button
    Friend WithEvents lblBBirth As System.Windows.Forms.Label
    Friend WithEvents dtpBBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblGBirth As System.Windows.Forms.Label
    Friend WithEvents dtpGBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtChart As System.Windows.Forms.TextBox
    Friend WithEvents tsChart As System.Windows.Forms.ToolStrip
    Friend WithEvents cbOb As System.Windows.Forms.CheckBox
    Friend WithEvents cbOg As System.Windows.Forms.CheckBox
    Friend WithEvents tsbLanguage As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmEnglish As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmJapanese As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmChinese As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbFile As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents btnAboutme As System.Windows.Forms.Button
    Friend WithEvents btnMainpage As System.Windows.Forms.Button
    Friend WithEvents tsmAbout As System.Windows.Forms.ToolStripMenuItem

End Class
