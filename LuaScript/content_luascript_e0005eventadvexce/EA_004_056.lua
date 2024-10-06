-- このluaスクリプトは、EA_004_056.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116101_01","116101_01_h")
Include("content_adv_advsmall_116101_01","Template116101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116101_01()
	InitializeTemplate116101_01()
-- ▼直接出力
load_image("201010040", "content_still_20101004_image", "201010040_StillImage")
show_image("201010040", 0.0, 0.0, 0,true,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116101)
	Actor001 = InitializeCharacter_2DOnly("101034","001","101034001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:選ぶなら最適解よ<br>その考えは変わらない
	Talk(Actor001,"CHRNAME_EXCELIA","simple","N","EA_004_0560029")


	--★★エクセリア★★:でも風向きは常に変わる<br>それは戦場だけじゃないというなら
	Talk(Actor001,"CHRNAME_EXCELIA","simple","N","EA_004_0560030")

-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力

	--★★エクセリア★★:その都度、最適解を選べばいい
	Talk(Actor001,"CHRNAME_EXCELIA","simple","N","EA_004_0560031")


	--★★エクセリア★★:最適解がひとつじゃないのなら<br>そのときの最適解を選べばいいのだと
	Talk(Actor001,"CHRNAME_EXCELIA","simple","N","EA_004_0560032")


	--★★エクセリア★★:そんな青い理想論を掲げられるのが<br>学園のよいところなのかもしれない
	Talk(Actor001,"CHRNAME_EXCELIA","simple","N","EA_004_0560033")

-- ▼直接出力
PlayPartVoice("エクセリア","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★エクセリア★★:そう言ったら、アダンは笑っていたわ<br>なんだか嬉しそうだった
	Talk(Actor001,"CHRNAME_EXCELIA","simple","N","EA_004_0560034")


	--★★エクセリア★★:青い理想論は、今はまだ机上の空論<br>でもきっと私たちが編み出した最適解は
	Talk(Actor001,"CHRNAME_EXCELIA","simple","N","EA_004_0560035")


	--★★エクセリア★★:いつかどこかの戦場で<br>切り札のひとつとなるわ
	Talk(Actor001,"CHRNAME_EXCELIA","simple","N","EA_004_0560036")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010040", "content_still_20101004_image", "201010040_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116101)
	InitializeCharacter_2DOnly_Preload("101034","001","101034001")
	system.PreLoadRequest(CameraAssetBundleName116101_01)
end
