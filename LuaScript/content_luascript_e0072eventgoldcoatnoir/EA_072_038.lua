-- このluaスクリプトは、EA_072_038.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116101_01","116101_01_h")
Include("content_adv_advsmall_116101_01","Template116101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116101_01()
	InitializeTemplate116101_01()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image("201010920", "content_still_20101092_image", "201010920_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("201010920", 0.0, 0.0, 0.8,true,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116101)
	Actor001 = InitializeCharacter_2DOnly("101009","003","101009003")
	Actor002 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★ノワール★★:もしまだここに、キミがいたなら
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380007")


	--★★ノワール★★:「見ろよ。すごい景色だなあ」<br>「旅先ではどんな食べ物がおいしいんだろう」
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380008")


	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380009")


	--★★ノワール★★:想像するしかなくなってく<br>だんだんとわからなくなってく
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380010")


	--★★ノワール★★:ふたりでいたら<br>どこへいくだろうか
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380011")

-- ▼直接出力
CloseTalkWindow()
wait_time(3.6)
-- ▲直接出力

	--★★ノワール★★:………そうして思い返してるうちに、いずれ
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380013")


	--★★ノワール★★:素敵なキミ以外を<br>忘れてしまう気がする
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380014")


	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380015")


	--★★ノワール★★:だから、ひとりでいくよ
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380016")


	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0380017")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(0.6)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★ノワール★★:キミがいないことを、大切にするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0380019")


	--★★テロップ★★:「ノワール、いける？」
	Talk(Actor002,"telop","simple","N","EA_072_0380021")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0380022")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0380023")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0380024")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_LongFade")
fadeout(0,0,0,1.0,6)
wait_time(6)
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
fadein(2)
wait_time(2)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("201010920", "content_still_20101092_image", "201010920_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116101)
	InitializeCharacter_2DOnly_Preload("101009","003","101009003")
	system.PreLoadRequest(CameraAssetBundleName116101_01)
end
