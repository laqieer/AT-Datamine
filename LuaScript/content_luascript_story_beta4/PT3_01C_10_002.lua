-- このluaスクリプトは、PT3_01C_10_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_10_002002")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ノワールか、おはよう<br>…すまん、これから出なければならなくてな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01C_10_002003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:出撃か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_10_002004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:いや<br>花を買いに行ってくる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01C_10_002005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:花？<br>誰かへの贈りものか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_10_002006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…ヴォールスに
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01C_10_002007")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_10_002008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:ここしばらく学園や城下のことで手一杯だったが<br>お前も戻ってきて少しは落ち着いたからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01C_10_002009")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:あらためて<br>花でも供えてやってくる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01C_10_002010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も折を見て行くことにするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_10_002011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:そうしてやってくれ<br>ヴォールスもきっと喜ぶ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01C_10_002012")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
