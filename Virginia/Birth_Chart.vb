Imports System.IO
Imports System.Threading
Public Class Birth_Chart
    'shortcut key input
    Private Sub Birth_Chart_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'showdropdown list when enter alt+F and automatic select the first enabled item   
        If My.Computer.Keyboard.AltKeyDown AndAlso e.KeyCode = Keys.F Then
            tsbFile.ShowDropDown()
            If tsmSave.Enabled = False And tsmLoad.Enabled = True Then
                tsmLoad.Select()
            ElseIf tsmSave.Enabled = False And tsmLoad.Enabled = False Then
                tsmAbout.Select()
            End If
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

    Dim bResult, gResult, bWux, gWux, bgWX, forTune As String
    Dim aniZodiac, wuXing, celStem, earBranch, wuX, bg, fortuneSlip As Array
    Dim aniZb, aniZg As Integer 'animal zodiac
    Dim wuXb, wuXg As Integer 'wu xing
    Dim ceLb, ceLg As Integer 'celestial stem
    Dim earBb, earBg As Integer 'earthly branches
    Dim n, o As Integer

    Private Sub Birth_Chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetLanguagePack() 'every page have to read languagepack first
        tsmSave.Enabled = False
        txtChart.Enabled = False
        txtChart.BackColor = Color.White
    End Sub

    Private Sub Birth_Chart_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        If tsmSave.Enabled = True Then Saving()
        Me.Hide()
        Main_Page.Show()
    End Sub

    Private Sub englishPack()
        tsmEnglish.Enabled = False
        tsmChinese.Enabled = True
        tsmJapanese.Enabled = True
        tsbFile.Text = "File(F)"
        tsmSave.Text = "Save(S)"
        tsmLoad.Text = "Load(L)"
        tsmAbout.Text = "About"
        tsmExit.Text = "Exit(E)        Esc"
        tsbLanguage.Text = "Language(L)"
        tsmEnglish.Text = "English(E)"
        tsmJapanese.Text = "Japanese(J)"
        tsmChinese.Text = "Chinese(C)"
        cbOb.Text = "Lunar Year"
        cbOg.Text = "Lunar Year"
        lblBBirth.Text = "1.Insert D.O.B (Male):"
        lblGBirth.Text = "2.Insert D.O.B (Female):"
        lblResult.Text = "Calculate Result"
        btnChartStart.Text = "Calculate"
        btnAboutme.Text = "About"
        btnMainpage.Text = "Main Page"
        Me.Text = "Wu Xing & Zodiac Chart"
        txtChart.Text = "==============================================" &
vbCrLf & "To Users:" & vbCrLf & vbTab & "This program is purely for reference." &
vbCrLf & vbTab & "If in doubt, please let us know, thank you!" & vbCrLf &
vbCrLf & vbTab & vbTab & vbTab & vbTab & "Virginia Chien" &
vbCrLf & "=============================================="
        bResult = "(Male)D.O.B and Zodiac is:"
        gResult = "(Female)D.O.B and Zodiac is:"
        aniZodiac = {"(Rat)", "(Ox)", "(Tiger)", "(Rabbit)", "(Dragon)", "(Snake)",
                     "(Horse)", "(Goat)", "(Monkey)", "(Rooster)", "(Dog)", "(Pig)"}
        wuXing = {"Earth", "Earth", "Metal", "Metal", "Fire", "Fire", "Water", "Water", "Earth", "Earth",
                  "Metal", "Metal", "Wood", "Wood", "Water", "Water", "Earth", "Earth", "Fire", "Fire",
                  "Wood", "Wood", "Water", "Water", "Metal", "Metal", "Fire", "Fire", "Wood", "Wood",
                  "Earth", "Earth", "Metal", "Metal", "Fire", "Fire", "Water", "Water", "Earth", "Earth",
                  "Metal", "Metal", "Wood", "Wood", "Water", "Water", "Earth", "Earth", "Fire", "Fire",
                  "Wood", "Wood", "Water", "Water", "Metal", "Metal", "Fire", "Fire", "Wood", "Wood"}
        celStem = {"first H.S ", "2nd H.S ", "3rd H.S ", "4th H.S ", "5th H.S ",
                   "6th H.S ", "7th H.S ", "8th H.S ", "9th H.S ", "last H.S "}
        earBranch = {"first E.B", "2nd E.B", "3rd E.B", "4th E.B", "5th E.B", "6th E.B",
                     "7th E.B", "8th E.B", "9th E.B", "10th E.B", "11th E.B", "last E.B"}
        wuX = {"Metal", "Wood", "Water", "Fire", "Earth"}
        bg = {"Male", "Female"}
        fortuneSlip = {"兩金夫妻硬對硬、有女無男守空房、日夜爭打語不合、各人各心各白眼。", "金木夫妻不多年、整天吵打哭連連、原來二命都有害、半世婚姻守寡缘。", "水金夫妻坐高堂、錢財積聚喜洋洋、子女兩個生端正、個個聰明學文章。", "未有姻缘亂成親、娶得妻來也是貧、若無子女家財散、金火原來害本命。", "金土夫妻好姻缘、吃穿不愁福自然、子孫興旺家富貴、福祿双全萬萬年。",
                       "夫妻和好宜相交、錢財六畜滿山庄、撫養子女姓名揚、木金萬貴共一床。", "雙木夫妻福滿多、錢財有多事事樂、原來兩木多福星、生來兒女聰明多。", "男木女水大吉利、家中財運常進室、常為寶貴重如山、生來兒女披青衫。", "木火夫妻大吉昌、此門天定好姻缘、六畜奴作满成行、男女聰明福自隆。", "土木夫妻本不宜、災難疾病來侵之、兩合相克各分散、一世孤單晝夜啼。",
                       "金水夫妻富高強、錢財積聚百歲長、婚姻和合前程輝、禾倉田宅福壽長。", "木水夫妻好姻缘、財寶貴富旺兒郎、朱馬禾倉積滿院、男女端正學文章。", "兩水夫妻喜洋洋、兒女聰明家興旺、姻缘美滿福双全、滿倉財產好風光。", "水火夫妻不相配、在家吃飯在外睡、原因二命相克害、半世姻缘半世愁。", "水土夫妻不久存、三六九五見瘟王、兩命相克亦難過、别處他鄉嫁别克。",
                       "金火夫妻克六親、不知刑元在何身、若是穩有不孝顺、禍及子孫守孤貧。", "火木夫妻好婚配、子孫孝順家興旺、六畜錢糧皆豐盈、一世富貴大吉昌。", "水火夫妻雖有情、结啼姻缘亦不深、兒女若是有富貴、到老還是孤獨人。", "兩火夫妻日夜愁、妻離子散淚水流、二命相克宜不聚、四季狐獨度春秋。", "火土夫妻好相配、高官祿位眼前風、兩人合來無克害、兒女聰明永富貴。",
                       "土金夫妻很姻缘、兩口相愛至百年、内宅平安六畜福、生來女兒均團圓。", "土木夫妻意不同、反眼無情相克沖、有食無兒克夫主、半世姻緣家財空。", "土水夫妻定有獸、接到家中定有災、妻離子散各東西、家中冷落財不来。", "土火夫妻大昌吉、財糧不愁福壽長、兒女聰明生端正、富貴榮華好時光。", "雙土夫妻好姻緣、共歡一世福雙全、兒女聰明多興旺、富貴榮華好家園。"}
    End Sub

    Private Sub japanesePack()
        tsmJapanese.Enabled = False
        tsmChinese.Enabled = True
        tsmEnglish.Enabled = True
        tsbFile.Text = "ファイル(F)"
        tsmSave.Text = "セーブ(S)"
        tsmLoad.Text = "ロード(L)"
        tsmAbout.Text = "について"
        tsmExit.Text = "出口(E)         Esc"
        tsbLanguage.Text = "言語(L)"
        tsmEnglish.Text = "英語(E)"
        tsmJapanese.Text = "日本語(J)"
        tsmChinese.Text = "中国語(C)"
        cbOb.Text = "太陰年"
        cbOg.Text = "太陰年"
        lblBBirth.Text = "1.男の子の誕生日："
        lblGBirth.Text = "2.女の子の誕生日："
        lblResult.Text = "計算の結果"
        btnChartStart.Text = "計算"
        btnAboutme.Text = "紹介"
        btnMainpage.Text = "メインページ"
        Me.Text = "干支と五行チャート"
        txtChart.Text = "==============================================" &
vbCrLf & "ごユーザーさま：" & "このプログラムは、参考のために純粋です。" &
"疑わしい場合は、私たちに知らせてください、ありがとうございました！" & vbCrLf &
vbCrLf & vbTab & vbTab & vbTab & vbTab & "Virginia Chien" &
vbCrLf & "=============================================="
        bResult = "男の子の誕生日とゾディアックは："
        gResult = "女の子の誕生日とゾディアックは："
        aniZodiac = {"(鼠)", "(牛)", "(虎)", "(兎)", "(龍)", "(蛇)",
                     "(馬)", "(羊)", "(猿)", "(鶏)", "(狗)", "(猪)"}
        wuXing = {"土行", "土行", "金行", "金行", "火行", "火行", "水行", "水行", "土行", "土行",
                  "金行", "金行", "木行", "木行", "水行", "水行", "土行", "土行", "火行", "火行",
                  "木行", "木行", "水行", "水行", "金行", "金行", "火行", "火行", "木行", "木行",
                  "土行", "土行", "金行", "金行", "火行", "火行", "水行", "水行", "土行", "土行",
                  "金行", "金行", "木行", "木行", "水行", "水行", "土行", "土行", "火行", "火行",
                  "木行", "木行", "水行", "水行", "金行", "金行", "火行", "火行", "木行", "木行"}
        celStem = {"甲", "乙", "丙", "丁", "戊",
                   "己", "庚", "辛", "壬", "癸"}
        earBranch = {"子年", "丑年", "寅年", "卯年", "辰年", "巳年",
                     "午年", "未年", "申年", "酉年", "戍年", "亥年"}
        wuX = {"金", "木", "水", "火", "土"}
        bg = {"男", "女"}
        fortuneSlip = {"兩金夫妻硬對硬、有女無男守空房、日夜爭打語不合、各人各心各白眼。", "金木夫妻不多年、整天吵打哭連連、原來二命都有害、半世婚姻守寡缘。", "水金夫妻坐高堂、錢財積聚喜洋洋、子女兩個生端正、個個聰明學文章。", "未有姻缘亂成親、娶得妻來也是貧、若無子女家財散、金火原來害本命。", "金土夫妻好姻缘、吃穿不愁福自然、子孫興旺家富貴、福祿双全萬萬年。",
                       "夫妻和好宜相交、錢財六畜滿山庄、撫養子女姓名揚、木金萬貴共一床。", "雙木夫妻福滿多、錢財有多事事樂、原來兩木多福星、生來兒女聰明多。", "男木女水大吉利、家中財運常進室、常為寶貴重如山、生來兒女披青衫。", "木火夫妻大吉昌、此門天定好姻缘、六畜奴作满成行、男女聰明福自隆。", "土木夫妻本不宜、災難疾病來侵之、兩合相克各分散、一世孤單晝夜啼。",
                       "金水夫妻富高強、錢財積聚百歲長、婚姻和合前程輝、禾倉田宅福壽長。", "木水夫妻好姻缘、財寶貴富旺兒郎、朱馬禾倉積滿院、男女端正學文章。", "兩水夫妻喜洋洋、兒女聰明家興旺、姻缘美滿福双全、滿倉財產好風光。", "水火夫妻不相配、在家吃飯在外睡、原因二命相克害、半世姻缘半世愁。", "水土夫妻不久存、三六九五見瘟王、兩命相克亦難過、别處他鄉嫁别克。",
                       "金火夫妻克六親、不知刑元在何身、若是穩有不孝顺、禍及子孫守孤貧。", "火木夫妻好婚配、子孫孝順家興旺、六畜錢糧皆豐盈、一世富貴大吉昌。", "水火夫妻雖有情、结啼姻缘亦不深、兒女若是有富貴、到老還是孤獨人。", "兩火夫妻日夜愁、妻離子散淚水流、二命相克宜不聚、四季狐獨度春秋。", "火土夫妻好相配、高官祿位眼前風、兩人合來無克害、兒女聰明永富貴。",
                       "土金夫妻很姻缘、兩口相愛至百年、内宅平安六畜福、生來女兒均團圓。", "土木夫妻意不同、反眼無情相克沖、有食無兒克夫主、半世姻緣家財空。", "土水夫妻定有獸、接到家中定有災、妻離子散各東西、家中冷落財不来。", "土火夫妻大昌吉、財糧不愁福壽長、兒女聰明生端正、富貴榮華好時光。", "雙土夫妻好姻緣、共歡一世福雙全、兒女聰明多興旺、富貴榮華好家園。"}
    End Sub

    Private Sub chinesePack()
        tsmChinese.Enabled = False
        tsmJapanese.Enabled = True
        tsmEnglish.Enabled = True
        tsbFile.Text = "檔案(F)"
        tsmSave.Text = "儲存(S)"
        tsmLoad.Text = "讀取(L)"
        tsmAbout.Text = "關於"
        tsmExit.Text = "結束          Esc"
        tsbLanguage.Text = "語言(L)"
        tsmEnglish.Text = "英文(E)"
        tsmJapanese.Text = "日文(J)"
        tsmChinese.Text = "中文(C)"
        cbOb.Text = "農曆舊年"
        cbOg.Text = "農曆舊年"
        lblBBirth.Text = "1.輸入男方出生日期:"
        lblGBirth.Text = "2.輸入女方出生日期:"
        lblResult.Text = "演算結果"
        btnChartStart.Text = "命盤演算Ｓ"
        btnAboutme.Text = "關於"
        btnMainpage.Text = "回主頁"
        Me.Text = "生肖與五行命盤"
        txtChart.Text = "==============================================" &
     vbCrLf & "致使用者:" & vbCrLf & vbTab & "此程式純屬參考." &
     vbCrLf & vbTab & "若有疑問,請來信告知,謝謝!" & vbCrLf &
     vbCrLf & vbTab & vbTab & vbTab & vbTab & "Virginia Chien" &
     vbCrLf & "=============================================="
        bResult = "男方的出生日期及生肖五型為:"
        gResult = "女方的出生日期及生肖五型為:"
        aniZodiac = {"(鼠)", "(牛)", "(虎)", "(兔)", "(龍)", "(蛇)",
                     "(馬)", "(羊)", "(猴)", "(雞)", "(狗)", "(豬)"}
        wuXing = {"屬土", "屬土", "屬金", "屬金", "屬火", "屬火", "屬水", "屬水", "屬土", "屬土",
                  "屬金", "屬金", "屬木", "屬木", "屬水", "屬水", "屬土", "屬土", "屬火", "屬火",
                  "屬木", "屬木", "屬水", "屬水", "屬金", "屬金", "屬火", "屬火", "屬木", "屬木",
                  "屬土", "屬土", "屬金", "屬金", "屬火", "屬火", "屬水", "屬水", "屬土", "屬土",
                  "屬金", "屬金", "屬木", "屬木", "屬水", "屬水", "屬土", "屬土", "屬火", "屬火",
                  "屬木", "屬木", "屬水", "屬水", "屬金", "屬金", "屬火", "屬火", "屬木", "屬木"}
        celStem = {"甲", "乙", "丙", "丁", "戊",
                   "己", "庚", "辛", "壬", "癸"}
        earBranch = {"子年", "丑年", "寅年", "卯年", "辰年", "巳年",
                     "午年", "未年", "申年", "酉年", "戍年", "亥年"}
        wuX = {"金", "木", "水", "火", "土"}
        bg = {"男", "女"}
        fortuneSlip = {"兩金夫妻硬對硬、有女無男守空房、日夜爭打語不合、各人各心各白眼。", "金木夫妻不多年、整天吵打哭連連、原來二命都有害、半世婚姻守寡缘。", "水金夫妻坐高堂、錢財積聚喜洋洋、子女兩個生端正、個個聰明學文章。", "未有姻缘亂成親、娶得妻來也是貧、若無子女家財散、金火原來害本命。", "金土夫妻好姻缘、吃穿不愁福自然、子孫興旺家富貴、福祿双全萬萬年。",
                       "夫妻和好宜相交、錢財六畜滿山庄、撫養子女姓名揚、木金萬貴共一床。", "雙木夫妻福滿多、錢財有多事事樂、原來兩木多福星、生來兒女聰明多。", "男木女水大吉利、家中財運常進室、常為寶貴重如山、生來兒女披青衫。", "木火夫妻大吉昌、此門天定好姻缘、六畜奴作满成行、男女聰明福自隆。", "土木夫妻本不宜、災難疾病來侵之、兩合相克各分散、一世孤單晝夜啼。",
                       "金水夫妻富高強、錢財積聚百歲長、婚姻和合前程輝、禾倉田宅福壽長。", "木水夫妻好姻缘、財寶貴富旺兒郎、朱馬禾倉積滿院、男女端正學文章。", "兩水夫妻喜洋洋、兒女聰明家興旺、姻缘美滿福双全、滿倉財產好風光。", "水火夫妻不相配、在家吃飯在外睡、原因二命相克害、半世姻缘半世愁。", "水土夫妻不久存、三六九五見瘟王、兩命相克亦難過、别處他鄉嫁别克。",
                       "金火夫妻克六親、不知刑元在何身、若是穩有不孝顺、禍及子孫守孤貧。", "火木夫妻好婚配、子孫孝順家興旺、六畜錢糧皆豐盈、一世富貴大吉昌。", "水火夫妻雖有情、结啼姻缘亦不深、兒女若是有富貴、到老還是孤獨人。", "兩火夫妻日夜愁、妻離子散淚水流、二命相克宜不聚、四季狐獨度春秋。", "火土夫妻好相配、高官祿位眼前風、兩人合來無克害、兒女聰明永富貴。",
                       "土金夫妻很姻缘、兩口相愛至百年、内宅平安六畜福、生來女兒均團圓。", "土木夫妻意不同、反眼無情相克沖、有食無兒克夫主、半世姻緣家財空。", "土水夫妻定有獸、接到家中定有災、妻離子散各東西、家中冷落財不来。", "土火夫妻大昌吉、財糧不愁福壽長、兒女聰明生端正、富貴榮華好時光。", "雙土夫妻好姻緣、共歡一世福雙全、兒女聰明多興旺、富貴榮華好家園。"}
    End Sub

    Private Sub btnChartStart_Click(sender As Object, e As EventArgs) Handles btnChartStart.Click
        txtChart.Clear()
        'check if was old year in lunar calendar
        n = dtpBBirth.Value.Year
        If cbOb.Checked Then n -= 1
        o = dtpGBirth.Value.Year
        If cbOg.Checked Then o -= 1
        If n <= 1900 Then n = 1900
        If o <= 1900 Then o = 1900
        aniZb = (n - 1900) Mod 12
        ceLb = (n - 1900 + 6) Mod 10
        earBb = (n - 1900) Mod 12
        wuXb = (n - 1900) Mod 60
        aniZg = (o - 1900) Mod 12
        ceLg = (o - 1900 + 6) Mod 10
        earBg = (o - 1900) Mod 12
        wuXg = (o - 1900) Mod 60
        'find out male and femal wu xing and declare new string
        If wuXing(wuXb) = "屬金" Or wuXing(wuXb) = "Metal" Or wuXing(wuXb) = "金行" Then bWux = wuX(0)
        If wuXing(wuXb) = "屬木" Or wuXing(wuXb) = "Wood" Or wuXing(wuXb) = "木行" Then bWux = wuX(1)
        If wuXing(wuXb) = "屬水" Or wuXing(wuXb) = "Water" Or wuXing(wuXb) = "水行" Then bWux = wuX(2)
        If wuXing(wuXb) = "屬火" Or wuXing(wuXb) = "Fire" Or wuXing(wuXb) = "火行" Then bWux = wuX(3)
        If wuXing(wuXb) = "屬土" Or wuXing(wuXb) = "Earth" Or wuXing(wuXb) = "土行" Then bWux = wuX(4)
        If wuXing(wuXg) = "屬金" Or wuXing(wuXg) = "Metal" Or wuXing(wuXg) = "金行" Then gWux = wuX(0)
        If wuXing(wuXg) = "屬木" Or wuXing(wuXg) = "Wood" Or wuXing(wuXg) = "木行" Then gWux = wuX(1)
        If wuXing(wuXg) = "屬水" Or wuXing(wuXg) = "Water" Or wuXing(wuXg) = "水行" Then gWux = wuX(2)
        If wuXing(wuXg) = "屬火" Or wuXing(wuXg) = "Fire" Or wuXing(wuXg) = "火行" Then gWux = wuX(3)
        If wuXing(wuXg) = "屬土" Or wuXing(wuXg) = "Earth" Or wuXing(wuXg) = "土行" Then gWux = wuX(4)
        'connect wu xing to fortune slip
        bgWX = bg(0) & bWux & bg(1) & gWux
        If bgWX = "男金女金" Or bgWX = "MaleMetalFemaleMetal" Then forTune = fortuneSlip(0)
        If bgWX = "男金女木" Or bgWX = "MaleMetalFemaleWood" Then forTune = fortuneSlip(1)
        If bgWX = "男金女水" Or bgWX = "MaleMetalFemaleWater" Then forTune = fortuneSlip(2)
        If bgWX = "男金女火" Or bgWX = "MaleMetalFemaleFire" Then forTune = fortuneSlip(3)
        If bgWX = "男金女土" Or bgWX = "MaleMetalFemaleEarth" Then forTune = fortuneSlip(4)
        If bgWX = "男木女金" Or bgWX = "MaleWoodFemaleMetal" Then forTune = fortuneSlip(5)
        If bgWX = "男木女木" Or bgWX = "MaleWoodFemaleWood" Then forTune = fortuneSlip(6)
        If bgWX = "男木女水" Or bgWX = "MaleWoodFemaleWater" Then forTune = fortuneSlip(7)
        If bgWX = "男木女火" Or bgWX = "MaleWoodFemaleFire" Then forTune = fortuneSlip(8)
        If bgWX = "男木女土" Or bgWX = "MaleWoodFemaleEarth" Then forTune = fortuneSlip(9)
        If bgWX = "男水女金" Or bgWX = "MaleWaterFemaleMetal" Then forTune = fortuneSlip(10)
        If bgWX = "男水女木" Or bgWX = "MaleWaterFemaleWood" Then forTune = fortuneSlip(11)
        If bgWX = "男水女水" Or bgWX = "MaleWaterFemaleWater" Then forTune = fortuneSlip(12)
        If bgWX = "男水女火" Or bgWX = "MaleWaterFemaleFire" Then forTune = fortuneSlip(13)
        If bgWX = "男水女土" Or bgWX = "MaleWaterFemaleEarth" Then forTune = fortuneSlip(14)
        If bgWX = "男火女金" Or bgWX = "MaleFireFemaleMetal" Then forTune = fortuneSlip(15)
        If bgWX = "男火女木" Or bgWX = "MaleFireFemaleWood" Then forTune = fortuneSlip(16)
        If bgWX = "男火女水" Or bgWX = "MaleFireFemaleWater" Then forTune = fortuneSlip(17)
        If bgWX = "男火女火" Or bgWX = "MaleFireFemaleFire" Then forTune = fortuneSlip(18)
        If bgWX = "男火女土" Or bgWX = "MaleFireFemaleEarth" Then forTune = fortuneSlip(19)
        If bgWX = "男土女金" Or bgWX = "MaleEarthFemaleMetal" Then forTune = fortuneSlip(20)
        If bgWX = "男土女木" Or bgWX = "MaleEarthFemaleWood" Then forTune = fortuneSlip(21)
        If bgWX = "男土女水" Or bgWX = "MaleEarthFemaleWater" Then forTune = fortuneSlip(22)
        If bgWX = "男土女火" Or bgWX = "MaleEarthFemaleFire" Then forTune = fortuneSlip(23)
        If bgWX = "男土女土" Or bgWX = "MaleEarthFemaleEarth" Then forTune = fortuneSlip(24)
        'display the resualt
        txtChart.Text = "1." & bResult & vbCrLf & dtpBBirth.Text & vbTab & celStem(ceLb) & earBranch(earBb) & vbTab & wuXing(wuXb) & " " & aniZodiac(aniZb) &
            vbCrLf & "2." & gResult & vbCrLf & dtpGBirth.Text & vbTab & celStem(ceLg) & earBranch(earBg) & vbTab & wuXing(wuXg) & " " & aniZodiac(aniZg) &
            vbCrLf & "『" & bgWX & "』:" &
            vbCrLf & vbTab & "      「" & forTune & "」"
        checkequals()
    End Sub

    Private Sub checkequals()
        'check if ckecktext equal to txtchart
        Dim filereader As New StreamReader("C:\ShiaoChien\Birth_chart.txt")
        Dim checktext As String
        checktext = filereader.ReadToEnd()
        checktext = Microsoft.VisualBasic.Left(checktext, 134)
        filereader.Close()
        'if the data saved same as result then disabled save tag
        If checktext = txtChart.Text Then
            tsmSave.Enabled = False
            tsmLoad.Enabled = False
        Else
            'if the data saved different as result then enablaed save tag
            tsmSave.Enabled = True
            tsmLoad.Enabled = True
        End If
    End Sub

    Private Sub tsmSave_Click(sender As Object, e As EventArgs) Handles tsmSave.Click
        If tsmSave.Enabled = True Then
            Saving()
        End If
    End Sub

    Private Sub Saving()
        Dim saveask, savetitle, saveresult, saveresulttitle As String
        If tsmEnglish.Enabled = False Then
            saveask = "Do you want save file?"
            savetitle = "Save"
            saveresult = "Data has been saved."
            saveresulttitle = "Saved"
        ElseIf tsmJapanese.Enabled = False Then
            saveask = "ファイルをセーブしますか？"
            savetitle = "セーブ"
            saveresult = "データがセーブしています。"
            saveresulttitle = "セーブした"
        ElseIf tsmChinese.Enabled = False Then
            saveask = "要儲存檔案嗎?"
            savetitle = "儲存"
            saveresult = "資料已存檔。"
            saveresulttitle = "已儲存"
        Else
            saveask = ""
            savetitle = ""
            saveresult = ""
            saveresulttitle = ""
        End If
        'Append the details to the end of the file 
        If MsgBox(saveask, vbYesNo, savetitle) = MsgBoxResult.Yes Then
            Dim filewriter As New StreamWriter("C:\ShiaoChien\Birth_chart.txt", False)
            filewriter.WriteLine(txtChart.Text)
            MsgBox(saveresult, , saveresulttitle)
            tsmSave.Enabled = False
            filewriter.Close()
        End If
    End Sub

    Private Sub tsmLoad_Click(sender As Object, e As EventArgs) Handles tsmLoad.Click
        If tsmSave.Enabled = True Then
            Saving()
        End If
        txtChart.Clear()
        Dim filereader As New StreamReader("C:\ShiaoChien\Birth_chart.txt")
        txtChart.Text = filereader.ReadToEnd()
        filereader.Close()
        tsmSave.Enabled = False
        tsmLoad.Enabled = False
    End Sub

    Private Sub btnMainpage_Click(sender As Object, e As EventArgs) Handles btnMainpage.Click
        If tsmSave.Enabled = True Then Saving()
        If tsmEnglish.Enabled = False Then
            If MsgBox("Back to Main page?", vbYesNo, "Main page") = MsgBoxResult.Yes Then
                Me.Hide()
                Main_Page.Show()
            End If
        ElseIf tsmJapanese.Enabled = False Then
            If MsgBox("メインページに帰りますか？", vbYesNo, "メインページ") = MsgBoxResult.Yes Then
                Me.Hide()
                Main_Page.Show()
            End If
        ElseIf tsmChinese.Enabled = False Then
            If MsgBox("回上一頁?", vbYesNo, "主頁") = MsgBoxResult.Yes Then
                Me.Hide()
                Main_Page.Show()
            End If
        End If
    End Sub

    Private Sub btnAboutme_Click(sender As Object, e As EventArgs) Handles btnAboutme.Click
        If tsmChinese.Enabled = False Then
            MessageBox.Show("此", "關於", MessageBoxButtons.OK)
        ElseIf tsmJapanese.Enabled = False Then
            MessageBox.Show("こ", "紹介", MessageBoxButtons.OK)
        Else
            MessageBox.Show("This", "About", MessageBoxButtons.OK)
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
        tsmLoad.Enabled = True
    End Sub

    Private Sub tsmJapanese_Click(sender As Object, e As EventArgs) Handles tsmJapanese.Click
        japanesePack()
        tsmLoad.Enabled = True
    End Sub

    Private Sub tsmChinese_Click(sender As Object, e As EventArgs) Handles tsmChinese.Click
        chinesePack()
        tsmLoad.Enabled = True
    End Sub

    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        If tsmSave.Enabled = True Then Saving()
        If tsmEnglish.Enabled = False Then
            If MsgBox("Are your sure to exit?", vbYesNo, "Exit") = MsgBoxResult.Yes Then Application.Exit()
        ElseIf tsmJapanese.Enabled = False Then
            If MsgBox("プログラムを終了すですか？", vbYesNo, "終了") = MsgBoxResult.Yes Then Application.Exit()
        ElseIf tsmChinese.Enabled = False Then
            If MsgBox("確定要結束程式?", vbYesNo, "結束") = MsgBoxResult.Yes Then Application.Exit()
        End If
    End Sub

End Class
