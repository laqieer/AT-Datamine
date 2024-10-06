-- このluaスクリプトは、CO_101032_0704.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_2DOnly("101009","002","101009002")
	Actor002 = InitializeCharacter_2DOnly("101032","001","101032001")
	Actor003 = InitializeCharacter_2DOnly("101033","001","101033001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
se_play("SE_ADV_CO_101032_0704_Fishing_Keep")
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うぐぐ、これは大物だぞ…！体が持っていかれる…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07040002")

-- ▼直接出力
PlayPartVoice("リオネス", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:ガ、ガレス！因枢分解だ、因枢分解して釣りあげよう！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_07040003")

-- ▼直接出力
PlayPartVoice("ガレス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:ファ、因枢分解はこういうときに使うものじゃないんじゃないのか～！？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07040005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:い、いいからみんな竿を引け～～～～～～！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07040006")

-- ▼直接出力
se_play("SE_ADV_Loop_Stop")
se_play("SE_ADV_CO_101032_0704_Fishing_Finish")
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガレス_ランクアップ7_5")
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
	load_area_scene_preload(116102)
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	InitializeCharacter_2DOnly_Preload("101032","001","101032001")
	InitializeCharacter_2DOnly_Preload("101033","001","101033001")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
