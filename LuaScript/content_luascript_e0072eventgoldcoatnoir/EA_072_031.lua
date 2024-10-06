-- このluaスクリプトは、EA_072_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_01","116102_01_h")
Include("content_adv_advsmall_116102_01","Template116102_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116102_01()
	InitializeTemplate116102_01()
-- ▼直接出力
load_image("201010950", "content_still_20101095_image", "201010950_StillImage")
-- ▲直接出力
-- ▼直接出力
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("201010950", 0.0, 0.0, 0.0) --回想スチルを表示
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor002 = InitializeCharacter_2DOnly("101009","002","101009002")
	Actor003 = InitializeCharacter_2DOnly("401015","001","401015001")
	Actor004 = InitializeCharacter_2DOnly("401016","001","401016001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
off_cameraframe()
off_screencolor()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("子供_女1","0002")
-- ▲直接出力

	--★★少女★★:わたし、王妃様の影武者になってあげようか？
	Talk(Actor004,"NPCNAME_0275","simple","N","EA_072_0310003")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0028")
-- ▲直接出力

	--★★ギネヴィア★★:ええっ、なんで？
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310004")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力

	--★★ノワール★★:影武者？
	Talk(Actor002,"CHRNAME_NOIR","simple","N","EA_072_0310005")


	--★★少年★★:偉いひとの<br>身代わりのことだよ
	Talk(Actor003,"NPCNAME_0401","simple","N","EA_072_0310006")


	--★★少年★★:顔とか服とかを似せて<br>ニセモノを作ることがあるんだって
	Talk(Actor003,"NPCNAME_0401","simple","N","EA_072_0310007")


	--★★ギネヴィア★★:あとは、こー…万が一権力者本人が死んだとき<br>それを隠して士気を保ったり…するらしいわ
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310008")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0002")
-- ▲直接出力

	--★★ギネヴィア★★:どうしてわたしの影武者に立候補を？
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310009")


	--★★少女★★:だって王妃様…<br><ruby=キャメリアード>故郷の国</ruby>を取り戻すために戦ってるんでしょ？
	Talk(Actor004,"NPCNAME_0275","simple","N","EA_072_0310010")


	--★★少女★★:死んじゃうかもしれないよ？
	Talk(Actor004,"NPCNAME_0275","simple","N","EA_072_0310012")


	--★★少女★★:だからワタシが影武者になって<br>暗殺者とかが、来たら身代わりに──
	Talk(Actor004,"NPCNAME_0275","simple","N","EA_072_0310013")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0018")
-- ▲直接出力

	--★★ギネヴィア★★:ダーメ！<br>溢れる愛国精神は受け取ったけど、ダメ！
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310014")

-- ▼直接出力
PlayPartVoiceDirect("子供_女1","0019")
-- ▲直接出力

	--★★少女★★:でも…<br>王妃様、いなくなっちゃったら…ヤダ
	Talk(Actor004,"NPCNAME_0275","simple","N","EA_072_0310015")


	--★★ギネヴィア★★:いなくなんないから
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310016")


	--★★少女★★:…ほんと？
	Talk(Actor004,"NPCNAME_0275","simple","N","EA_072_0310017")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0007")
-- ▲直接出力

	--★★ギネヴィア★★:ほんと！
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310018")


	--★★ギネヴィア★★:それに…誰かに代わりをやってもらおーなんて<br>ちょっとイヤだし
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310019")

-- ▼直接出力
PlayPartVoiceDirect("子供_女1","0046")
-- ▲直接出力

	--★★少女★★:そっ、かぁ
	Talk(Actor004,"NPCNAME_0275","simple","N","EA_072_0310020")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0055")
-- ▲直接出力

	--★★ギネヴィア★★:あっ、えと、あなたがイヤ…とかじゃなくて<br>わたしじゃない誰かがわたしの言葉を語るのは…
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310021")


	--★★ギネヴィア★★:…うまく言えないケド<br>ちがう気がするんだ
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310022")


	--★★ギネヴィア★★:わたしとゆーひとは<br>ひとりしかいないからね
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0310023")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010950", "content_still_20101095_image", "201010950_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	InitializeCharacter_2DOnly_Preload("401015","001","401015001")
	InitializeCharacter_2DOnly_Preload("401016","001","401016001")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
