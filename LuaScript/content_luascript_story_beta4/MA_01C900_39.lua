-- このluaスクリプトは、MA_01C900_39.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
movie_load("MA_01C900_39")
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor002 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

	change_face(Actor001,"Serious")

	--★★ノワール★★:思い出した……<br>思い出したんだ、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_390002")

	change_face(Actor001,"Pain")

	--★★ノワール★★:どこにいるんだ、ディナタン！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_390003")

-- ▼直接出力
wait_time(0.3)
-- ▲直接出力

	--★★ノワール★★:ディナタン…！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_390004")

-- ▼直接出力
CloseTalkWindow()
movie_set_active(true)
movie_play()
movie_wait_playing()
fadeout(0,0,0,1.0,0)
movie_stop()
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
fadein(0.5)
wait_time(1.0)
-- ▲直接出力

	--★★テロップ★★:あなたは忘れてしまう
	Talk(Actor002,"telop","simple","N","MA_01C900_390016")


	--★★テロップ★★:でも世界はずっと覚えている
	Talk(Actor002,"telop","simple","N","MA_01C900_390017")

-- ▼直接出力
 reserve_next_script("1章/メイン/エピローグ_マルディサント2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
movie_load_preload("MA_01C900_39")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
