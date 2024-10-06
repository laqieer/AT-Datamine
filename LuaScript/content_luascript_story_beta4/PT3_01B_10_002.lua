-- このluaスクリプトは、PT3_01B_10_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:クレア？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_002002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:おはよう、珍しいな<br>朝からこんなところでなにをしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_002003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:調査よ<br>継承者と、そのキラーズの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_10_002004")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_002005")


	--★★クレア★★:私の仮説は正しいのか<br>ランスロットがひた隠しにしているものはなにか
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_10_002006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:好奇心がうずくの<br>あなたたちから一時も目を離したくないほどに
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_10_002007")


	--★★ノワール★★:そ、そうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_002008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あっ！<br>えーと、俺、授業があるからこれで…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_002009")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:待って、ノワール<br>あなたにひとつ言い忘れていたことがあるの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_10_002010")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:言い忘れていたこと…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_002011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:おはよう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","PT3_01B_10_002012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:あ、ああ、おはよう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_10_002013")

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
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
