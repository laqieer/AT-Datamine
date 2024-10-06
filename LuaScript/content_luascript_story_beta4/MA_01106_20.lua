-- このluaスクリプトは、MA_01106_20.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114061_01","114061_01_h")
Include("content_adv_advsmall_114061_01","Template114061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera114061_01()
	InitializeTemplate114061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114061)
	Actor001 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力

end

function Play()
	StartPlay()


	--★★ディナタン★★:風が強い日 /湖の水音が怖くて
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_200002")


	--★★ディナタン★★:お母さんはそんなときにいつも /私たち兄妹を抱きしめてくれて──
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_200003")


	--★★ディナタン★★:にこやかに歌を /口ずさんでくれていた
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_200004")


	--★★ディナタン★★:病でどんどんか細く、張れなくなっていく声 /いつもそれでも笑顔で、虚勢を張った声
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_200005")


	--★★ディナタン★★:いつも兄さんはすぐ /安心して眠ってしまって
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_200006")


	--★★ディナタン★★:いつも私はお母さんが眠りに落ちるまで /その歌に聞き入っていた
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_200007")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,1.0)
wait_time(1.0)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ディナタン★★:<dot>良いお母さん</dot>だなあと<br>子供心に、無責任に思ってた
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_200009")


	--★★ディナタン★★:ああなるには<br>いつもにこやかで、笑顔でいようと
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_200011")


	--★★ディナタン★★:良い子をサボらずにいようと
	Talk(Actor001,"CHRNAME_DINATAN","speech","N","MA_01106_200012")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114061)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	system.PreLoadRequest(CameraAssetBundleName114061_01)
end
