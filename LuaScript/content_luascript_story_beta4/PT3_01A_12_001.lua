-- このluaスクリプトは、PT3_01A_12_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ラグネル","挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:おはよう、ノワール！<br>ああ～、寒いー！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01A_12_0010003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ラグネル<br>今日も冷えるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_12_0010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラグネル★★:ホントにねー！<br>どうにかして暖かくする方法はないかなあ～
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01A_12_0010005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:手芸サークルで<br>手袋とかマフラーを編んでみるのはどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_12_0010006")


	--★★ノワール★★:自分たちで使うだけじゃなくて<br>兵士たちにあげたら喜ばれるだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_12_0010007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:もうすぐ降誕祭だしさ<br>プレゼントにもぴったりじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_12_0010008")

-- ▼直接出力
PlayPartVoice("ラグネル","納得")
-- ▲直接出力

	--★★ラグネル★★:手芸サークルで手袋やマフラーか…<br>うん、いいかもしれないね
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01A_12_0010009")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:ノワール<br>おもしろいアイデア、ありがとう！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT3_01A_12_0010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:どういたしまして<br>出来上がるのを楽しみにしてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_12_0010011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
