-- このluaスクリプトは、PT3_01_04_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:よう、ノワール
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_04_0030003")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:おはよう、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_04_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:確認なんだけどよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_04_0030005")


	--★★ガウェイン★★:お前とティルフィングって<br>あのときに初めて会ったんだよな？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_04_0030006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_04_0030007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:まあ、そうだよな<br>剣から出てきた女の子と面識あるわけねーよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_04_0030008")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:でもなあ。初めて会った相手と<br>その場でＧＳってできるもんなのか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_04_0030009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:そういうもんだったかなあ…？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_04_0030010")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガウェイン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_04_0030011")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:ああ、悪い悪い<br>こっちのこと
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_04_0030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:なんにしても<br>ティルフィングはお前のキラーズだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_04_0030013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:あの子との絆は大事にしろよ？<br>これは先輩マスターとしての忠告だ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_04_0030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ありがとう<br>肝に銘じておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_04_0030015")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
