-- このluaスクリプトは、MA_01105_39.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_02","113011_02_h")
Include("content_adv_advsmall_113011_02","Template113011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera113011_02()
	InitializeTemplate113011_02()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113011)
	Actor001 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor002 = InitializeCharacter_2DOnly("101057","001","101057001")
	Actor003 = InitializeCharacter_2DOnly("101016","001","101016001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
se_play("SE_ADV_MA_01105_39_Break")
-- ▲直接出力

	--★★レオデグランス王★★:「異国のコインは答えました」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","L","MA_01105_390002")


	--★★レオデグランス王★★:「そういった夢をもてる時点で<br>キミはじゅうぶんにリッチだ」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","L","MA_01105_390003")


	--★★レオデグランス王★★:「キミが貧しい気持ちでいるのは<br>それに気づかないままだからだ」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","L","MA_01105_390004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★レオデグランス王★★:「異国のコインを磨いてごらん<br>そうすれば──…」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","L","MA_01105_390005")


	--★★ギネヴィア★★:…──「誰かが話を聞きに来る」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_390007")


	--★★ギネマウア★★:「異国のこと、一生懸命な貴方のこと<br>他愛無いおしゃべり、コインをきっかけに」
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01105_390008")


	--★★ギネヴィア★★:「キミにお似合いの誰かが」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_390009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネマウア★★:「キミの想いに<br>一致する友達が」
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01105_390010")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………ずっと思い出そうとしてた<br>話のおわり
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_390012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(113011)
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_2DOnly_Preload("101057","001","101057001")
	InitializeCharacter_2DOnly_Preload("101016","001","101016001")
	system.PreLoadRequest(CameraAssetBundleName113011_02)
end
