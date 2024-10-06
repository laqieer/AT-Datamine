-- このluaスクリプトは、MA_01A900_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_image("MA01A9001201", "content_still_10101003_image", "101010030_StillImage")

-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Recollection")
load_sound("VO_story01")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
se_play("SE_ADV_MA_01105_13_Book_Page_Slide")
-- ▲直接出力

	--★★ギネヴィア★★:『リッチな夢の終わり』
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","N","MA_01A900_120002")

-- ▼直接出力
bgm_play("BGM_ADV_Recollection")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

show_image("MA01A9001201", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
set_scale_image(1,1)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★レオデグランス王★★:「ある日、貧しき娘は異国のコインを拾いました<br>しかし自分の国でそれは使えませんでした」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","N","MA_01A900_120005")


	--★★レオデグランス王★★:「娘は願いました<br>リッチになりたい、と」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","N","MA_01A900_120006")


	--★★レオデグランス王★★:「異国のコインは答えました」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","N","MA_01A900_120007")


	--★★レオデグランス王★★:「そういった夢をもてる時点で<br>キミはじゅうぶんにリッチだ」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","N","MA_01A900_120008")


	--★★レオデグランス王★★:「キミが貧しい気持ちでいるのは<br>それに気づかないままだからだ」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","N","MA_01A900_120009")


	--★★レオデグランス王★★:「異国のコインを磨いてごらん<br>そうすれば…」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","speech","N","MA_01A900_120010")

-- ▼直接出力
DontChangeRandomCamera(true)
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)

show_image("101010140", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
set_scale_image(20,20)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ギネヴィア★★:（誰かが話を聞きに来る）
	Talk(Actor001,"CHRNAME_GUINEVERE","mind","N","MA_01A900_120012")


	--★★ギネヴィア★★:（異国のこと、一生懸命な貴方のこと<br>他愛無いおしゃべり、コインをきっかけに）
	Talk(Actor001,"CHRNAME_GUINEVERE","mind","N","MA_01A900_120013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:（キミにお似合いの誰かが）
	Talk(Actor001,"CHRNAME_GUINEVERE","mind","N","MA_01A900_120014")


	--★★ギネヴィア★★:（キミの想いに<br>一致する友達が）
	Talk(Actor001,"CHRNAME_GUINEVERE","mind","N","MA_01A900_120015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("MA01A9001201", "content_still_10101003_image", "101010030_StillImage")
preload_sound("BGM_ADV_Recollection")
preload_sound("VO_story01")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
