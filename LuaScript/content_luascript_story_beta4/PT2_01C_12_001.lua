-- このluaスクリプトは、PT2_01C_12_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","挨拶")
-- ▲直接出力

	--★★トリスタン★★:おはよう<br>…少し表情が明るくなったようだね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_12_0010004")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:そうか？<br>自分じゃわからないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_12_0010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:でも、降誕祭でみんなと話したことで<br>少し気持ちがラクになったことは確かだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_12_0010006")

-- ▼直接出力
PlayPartVoice("トリスタン","納得")
-- ▲直接出力

	--★★トリスタン★★:そう<br>それはなによりだね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_12_0010007")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:…ところで、なにかあったのか？<br>お前がわざわざ来るなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_12_0010008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","肯定")
-- ▲直接出力

	--★★トリスタン★★:ランスロットたちの行方について<br>新しい情報が入ったんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_12_0010009")


	--★★トリスタン★★:休日の朝から悪いんだけど<br>円卓の間まで来てくれる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_12_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本当か！？<br>すぐに行く
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_12_0010011")


	--★★トリスタン★★:ボクは先に行って待ってる
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_12_0010012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:すぐに出発することになるかもしれないから<br>そのつもりでね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01C_12_0010013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
