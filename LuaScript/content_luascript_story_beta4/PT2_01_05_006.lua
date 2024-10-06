-- このluaスクリプトは、PT2_01_05_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
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

-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:ねえ、ノワール<br>ギネヴィア様…今日も学園に来てない
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01_05_0060006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ<br>そうみたいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0060007")

-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力

	--★★ラグネル★★:キャメリアードから戻って来て<br>ずっとだよ？
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01_05_0060008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★ラグネル★★:ギネマウア先輩も一緒に<br>欠席してるっていうし…心配だよ
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01_05_0060009")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:信じよう、ギネヴィアのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0060010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラグネル★★:…うん、そうだね
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01_05_0060011")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラグネル★★:でも、いざとなったら<br>ノワールがなんとかしてくれるんでしょ？
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01_05_0060012")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0060013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:ノワールは<br>ギネヴィア様に雇われてるんだし
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","PT2_01_05_0060014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだよな<br>雇われてるんだよな、俺。ギネヴィアに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0060015")

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
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
