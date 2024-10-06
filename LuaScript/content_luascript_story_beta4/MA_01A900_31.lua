-- このluaスクリプトは、MA_01A900_31.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115144)
	Actor001 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
load_image("10103010", "content_still_10103010_image", "101030100_StillImage")
-- ▲直接出力
-- ▼直接出力
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10103010", 0.0, 0.0, 0.0,true,false)
set_position_image(0,0)
set_scale_image(0.8,0.8)
scale_to_image(1.25,1.25,10.0,"EaseInOut")
move_to_image(0,-50,10.0,"EaseInOut")
-- ▲直接出力

end

function Play()
	StartPlay()


	--★★エレイン★★:「あなたと過ごした毎朝毎昼毎夜は<br>一千年後も私たちの人生の一部として遺る」
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","MA_01A900_310002")


	--★★エレイン★★:「過ぎた時間は取り返しがつかない」
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","MA_01A900_310003")


	--★★エレイン★★:「だから…忘却に奪われることだってありません」
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","MA_01A900_310004")


	--★★エレイン★★:「癒えない気持ちを<br>したためますから」
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","MA_01A900_310006")


	--★★エレイン★★:「終わるまで一緒に戦います<br>キズついてもキズついても」
	Talk(Actor001,"CHRNAME_ELAINE","simple","N","MA_01A900_310008")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115144)
load_image_preload("10103010", "content_still_10103010_image", "101030100_StillImage")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
end
