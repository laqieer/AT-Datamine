-- このluaスクリプトは、MA_01B900_39.csv の ADV シートから自動生成されました --
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
	Actor001 = InitializeCharacter_2DOnly("101009","005","101009005")
	Actor002 = InitializeCharacter_2DOnly("101021","003","101021003")
	Actor003 = InitializeCharacter_2DOnly("101060","001","101060001")
	template1()
-- ▼直接出力
load_image("MA011080101", "content_still_10101011_image", "101010110_StillImage")
show_image("MA011080101", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力

end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ノワール★★:…もし、手がなくなっちゃったら？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01B900_390002")


	--★★セレスティ★★:残ってる手を使うのよ
	Talk(Actor003,"NPCNAME_0163","speech","N","MA_01B900_390004")


	--★★ブルーノ★★:…なにかを失っても<br>まだ戦うすべはあるはずだ
	Talk(Actor002,"CHRNAME_BRUNO","speech","N","MA_01B900_390006")


	--★★セレスティ★★:生きて、誰かの力になれたなら<br>生き抜いて、ともに歩む道を探し続ければ──
	Talk(Actor003,"NPCNAME_0163","speech","N","MA_01B900_390008")


	--★★ブルーノ★★:手を差し伸べてくれる<br>誰かが、必ず
	Talk(Actor002,"CHRNAME_BRUNO","speech","N","MA_01B900_390009")

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
	InitializeCharacter_2DOnly_Preload("101009","005","101009005")
	InitializeCharacter_2DOnly_Preload("101021","003","101021003")
	InitializeCharacter_2DOnly_Preload("101060","001","101060001")
load_image_preload("MA011080101", "content_still_10101011_image", "101010110_StillImage")
	system.PreLoadRequest(CameraAssetBundleName116102_01)
end
