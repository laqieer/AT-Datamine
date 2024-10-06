-- このluaスクリプトは、MS_002_065.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_02","110021_02_h")
Include("content_adv_advsmall_110021_02","Template110021_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110021_02,CameraPos110021_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110021_02,CameraPos110021_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110021_02,CameraPos110021_02_002)
	InitializeTemplateRandomCamera110021_02()
	InitializeTemplate110021_02()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
cam = {}
local num = 0
local camera
for i = 1 , 6 do
    num = i + 9
    camera = "P" .. num .. "_Cam"
    cam["CUT" .. num] = cat_template_camera(camera)
end
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001 = cam.CUT10
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_object("content_mob_110021_01_mobs_0001", "110021_01_mobs_0001", true)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0002")
-- ▲直接出力

	--★★ティルフィング★★:クラスの配属希望ですか？
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650004")

-- ▼直接出力
setup_small_camera_start(cam.CUT11)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0065")
-- ▲直接出力

	--★★？？？★★:そうなの！基本的にはいつも<br>そのひとの資質に合わせて決まるんだけどね
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650006")


	--★★？？？★★:ティルフィングさんの転入はかなり特殊<br>…って聞いたんだ
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650007")


	--★★？？？★★:ケイ卿も貴方を<br>どのクラスにしようか検討中みたい
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650008")


	--★★？？？★★:で、せっかくだから<ruby=ワタシ>この生徒会長代理</ruby>が<br>ティルフィングさんの希望を聞いておこうかなと
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650009")

	change_face(Actor001,"Sad")

	--★★ティルフィング★★:………
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650011")

-- ▼直接出力
setup_small_camera_start(cam.CUT12)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0008")
-- ▲直接出力

	--★★ティルフィング★★:…ノワール卿と<br>別のクラスでお願いできますか
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650012")

-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0085")
-- ▲直接出力

	--★★？？？★★:えっ、あー…うん？<br>じゃあ『遥か望む剣』…<dot>以外</dot>ってこと？
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650013")

	change_face(Actor001,"Normal")

	--★★ティルフィング★★:できれば、教室自体は<br>近い位置が好ましいのですが
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650016")

-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0002")
-- ▲直接出力

	--★★？？？★★:ティルフィングさん…<br>ノワールくんのキラーズなんだよね？
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","0007")
-- ▲直接出力

	--★★ティルフィング★★:…はい。そのようなものです
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650018")


	--★★？？？★★:『<ruby=いっしょのクラス>遥か望む剣</ruby>』じゃなくていいの？
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650019")

-- ▼直接出力
setup_small_camera_start(cam.CUT13)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","0008")
-- ▲直接出力

	--★★ティルフィング★★:私はノワール卿の人生にとって<br>武器以上の意味をなしてはならない存在です
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650021")


	--★★ティルフィング★★:来たるときまで彼を導くだけ…<br>彼は彼の歴史のみで選択肢を得ねばなりません
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650022")

-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0020")
-- ▲直接出力

	--★★？？？★★:…んン～っ？ちょっと話が難しいケド<br>なんかワケありな感じ？
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650023")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","0037")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ティルフィング★★:申し訳ありません<br>詳しくはお話できませんが──
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650024")

-- ▼直接出力
PlayPartVoiceDirect("ウレリー","0066")
-- ▲直接出力

	--★★？？？★★:わかった！
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650025")

-- ▼直接出力
setup_small_camera_start(cam.CUT14)
-- ▲直接出力

	--★★？？？★★:じゃあ『<ruby=いっしょのクラス>遥か望む剣</ruby>』になろう
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650026")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ティルフィング★★:………あの、えっ？
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650029")

	PlayAction(Actor003,"to  Std_No")

	--★★？？？★★:あ～っ、違うよ？ノワールくんと無理矢理<br>仲良くなれってことじゃないよ？
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650030")


	--★★？？？★★:<ruby=ゲシュタルト・シフト>ＧＳ</ruby>も色々！個々人の事情も様々！<br>ワタシが立ち入れるようなものじゃないもんね
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MS_002_0650031")

	change_face(Actor001,"Normal")

	--★★ティルフィング★★:でしたら、なぜ──
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","MS_002_0650033")

-- ▼直接出力
setup_small_camera_start(cam.CUT15)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
Appear(Actor002)
PlayPartVoiceDirect("ウレリー","0107")
-- ▲直接出力

	--★★ウレリー★★:教えてあげる
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0650035")


	--★★ウレリー★★:<dot>ワタシと</dot><br>一緒のクラスになろうよ
	Talk(Actor002,"CHRNAME_URRIE","speech","L","MS_002_0650036")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
cam = {}
local num = 0
local camera
for i = 1 , 6 do
    num = i + 9
    camera = "P" .. num .. "_Cam"
end
set_object_preload("content_mob_110021_01_mobs_0001", "110021_01_mobs_0001", true)
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
