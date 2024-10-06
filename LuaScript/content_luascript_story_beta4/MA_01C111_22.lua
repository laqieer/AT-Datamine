-- このluaスクリプトは、MA_01C111_22.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_03","111013_03_h")
Include("content_adv_advsmall_111013_03","Template111013_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_03,CameraPos111013_03_001)
	InitializeTemplateRandomCamera111013_03()
	InitializeTemplate111013_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("ルーシャス","悩む")
-- ▲直接出力

	--★★ルーシャス★★:ノワールとその妹を呼べ、か
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C111_220002")

	PlayAction(Actor001,"to Bow")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス","肯定3")
-- ▲直接出力

	--★★ヴェルナルス★★:すぐにでも使いの者を出します
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01C111_220003")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス","否定")
-- ▲直接出力

	--★★ルーシャス★★:いや、構わん
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C111_220004")

	change_face(Actor001,"Surprise")

	--★★ヴェルナルス★★:は？<br>しかし、それでは…
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01C111_220005")

-- ▼直接出力
 --PlayPartVoice("ルーシャス","激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ルーシャス★★:継承者に泣きつくなど<br>ローマ皇太子にできるか
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C111_220006")


	--★★ルーシャス★★:そんな生き恥を晒すくらいなら<br>この首、魔女にくれてやる
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C111_220007")


	--★★ルーシャス★★:…ローラを追え<br>貴公が直々に行って、連れ戻してこい
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C111_220009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ヴェルナルス★★:い、いえ、それは御身が心配です
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01C111_220010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス","否定")
-- ▲直接出力

	--★★ルーシャス★★:何度も口答えするな<br>いいから行け
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C111_220011")


	--★★ルーシャス★★:ローラが「ログレスに戻る」と言い出したら<br>捨て置け…それから
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C111_220012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:ロンディニウムの民によろしくな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01C111_220013")

	PlayAction(Actor001,"to Bow")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス","肯定3")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ヴェルナルス★★:…御意?
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01C111_220014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
