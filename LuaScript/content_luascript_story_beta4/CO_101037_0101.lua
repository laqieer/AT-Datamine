-- このluaスクリプトは、CO_101037_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
	PlayAction(Actor001,"to  Std_No")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラシア★★:まずいまずいまずい～～～っ！
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_01010002")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:落ち着いて…深呼吸…<br>すーっ、はーっ…
	Talk(Actor001,"CHRNAME_RASIA","speech","L","CO_101037_01010004")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ1_1_1")
-- ▲直接出力
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
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
