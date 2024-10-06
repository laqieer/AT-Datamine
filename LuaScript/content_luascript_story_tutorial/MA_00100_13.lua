-- このluaスクリプトは、MA_00100_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100031_01","100031_01_h")
Include("content_adv_advsmall_100031_01","Template100031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera100031_01()
	InitializeTemplate100031_01()
-- ▼直接出力
ShowGlobalMenuButton(false)
CUT_01 = cat_template_camera(CameraPos002)
CUT_02 = cat_template_camera(CameraPos003)
-- ▲直接出力
-- ▼直接出力
RndCamera001 =  CUT_01
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100031)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力

	--★★テロップ★★:現在　20XX年<br>日本　東京　六千年学園
	Talk(Actor001,"","simple","N","MA_00100_130002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT_02)
wait_time(1.0)
-- ▲直接出力

	--★★先生★★:転校生の<br><Player Name>くんだ
	Talk(Actor002,"NPCNAME_0067","speech","N","MA_00100_130004")


	--★★先生★★:仲良くしてやってくれ
	Talk(Actor002,"NPCNAME_0067","speech","N","MA_00100_130006")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
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
	load_area_scene_preload(100031)
	system.PreLoadRequest(CameraAssetBundleName100031_01)
end
