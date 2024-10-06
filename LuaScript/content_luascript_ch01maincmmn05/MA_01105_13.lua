-- このluaスクリプトは、MA_01105_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_02","113011_02_h")
Include("content_adv_advsmall_113011_02","Template113011_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos113011_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName113011_02,CameraPos113011_02_003)
	InitializeTemplateRandomCamera113011_02()
	InitializeTemplate113011_02()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_image("MA011051201", "content_still_10101003_image", "101010030_StillImage")


-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Recollection")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_TextOnly()
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:『せめて、リッチな夢を』
	Talk(Actor001,"CHRNAME_GUINEVERE","narration","N","MA_01105_110002")

-- ▼直接出力
CloseTalkWindow()
fadeout(255, 255, 255, 0, STILL_SWITCH_TIME )
wait_time(STILL_SWITCH_TIME)
show_image("MA011051201", 0.0, 0.0, 0.0)
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Recollection")
-- ▲直接出力

	--★★妹★★:パパ！パパ！お話！お話して！！
	Talk(Actor004,"NPCNAME_0167","simple","N","MA_01105_120002")


	--★★レオデグランス王★★:ギネヴィア、パパは疲れてるんだよ<br>お姉ちゃんに遊んでもらいなさい
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_120003")


	--★★姉★★:遊び道具もろくにないから<br>タダで済む童話をねだる──
	Talk(Actor003,"NPCNAME_0139","simple","N","MA_01105_120005")


	--★★姉★★:そんな親思いの姉妹の気持ち<br>おわかりになりませんか、お父様
	Talk(Actor003,"NPCNAME_0139","simple","N","MA_01105_120006")


	--★★レオデグランス王★★:…ママに似て来たのう、ギネマウア<br>同じお話しかないぞ？
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_120007")


	--★★妹★★:パパがお話してくれるなら<br>わたし、なんでもいー！！
	Talk(Actor004,"NPCNAME_0167","simple","N","MA_01105_120008")

-- ▼直接出力
se_play("SE_ADV_MA_01105_13_Book_Page_Slide")
wait_time(0.3)
-- ▲直接出力

	--★★レオデグランス王★★:「ある日、貧しき娘は異国のコインを拾いました<br>しかし自分の国でそれは使えませんでした」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_120010")


	--★★レオデグランス王★★:「娘は願いました<br>リッチになりたい、と」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_120011")


	--★★妹★★:ビンボくさいゆめ！
	Talk(Actor004,"NPCNAME_0167","simple","N","MA_01105_120012")


	--★★姉★★:ロマンがありませんね
	Talk(Actor003,"NPCNAME_0139","simple","N","MA_01105_120013")


	--★★レオデグランス王★★:いつもここで突っ込むのう…<br>「異国のコインは答えました」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_120014")


	--★★レオデグランス王★★:「そういった夢を持てる時点で<br>キミは十分にリッチだ」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_120015")


	--★★レオデグランス王★★:「キミが貧しい気持ちでいるのは<br>それに気づかないままだからだ」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_120016")


	--★★妹★★:話の通じないコインね！
	Talk(Actor004,"NPCNAME_0167","simple","N","MA_01105_120017")


	--★★姉★★:貧しくて困ってるからリッチになりたいのに<br>コインの分際で生意気ですね
	Talk(Actor003,"NPCNAME_0139","simple","N","MA_01105_120018")


	--★★レオデグランス王★★:「異国のコインを磨いてごらん<br>そうすれば──…」
	Talk(Actor002,"CHRNAME_LEODEGRAINS","simple","N","MA_01105_120019")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
fadeout(255, 255, 255, 0, STILL_SWITCH_TIME)
hide_image(STILL_SWITCH_TIME)	
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
on_camera(RndCamera090)
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER + 1)
-- ▲直接出力

	--★★ギネヴィア★★:すぐ帰るからね。パパ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_130002")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…コインを磨いたら、なんだっけ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_130003")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("MA011051201", "content_still_10101003_image", "101010030_StillImage")
preload_sound("BGM_ADV_Recollection")
	InitializeLoad_Preload()
	load_area_scene_preload(113011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName113011_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
