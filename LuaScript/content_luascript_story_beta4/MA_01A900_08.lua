-- このluaスクリプトは、MA_01A900_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116101_01","116101_01_h")
Include("content_adv_advsmall_116101_01","Template116101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera116101_01()
	InitializeTemplate116101_01()
-- ▼直接出力
load_image("103020050", "content_still_10302005_image", "103020050_StillImage")
load_sound("VO_story01")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116101)
	Actor001 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor002 = InitializeCharacter_2DOnly("401011","001","401011001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --エフェクト開始
fadeout(255,255,255,1.0, 0)
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103020050", 0.0, 0.0, 0,true,false)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ギネヴィア★★:ヤケよ、ヤケ買いよ
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_080002")


	--★★ギネヴィア★★:キャメリアードで育ったもと王女が<br>ログレスでも元気よ、って
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_080004")


	--★★市民（男）★★:一番の安物ですよ、イミテーションですし<br>もっと高価な、本物の貴石もございますが…
	Talk(Actor002,"NPCNAME_0157","simple","N","MA_01A900_080006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:うん、でも<br>これがいいです
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_080007")

-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
--エフェクト終了
hide_image()
--スチル終了
off_cameraframe()
off_screencolor()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103020050", "content_still_10302005_image", "103020050_StillImage")
preload_sound("VO_story01")
	InitializeLoad_Preload()
	load_area_scene_preload(116101)
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_2DOnly_Preload("401011","001","401011001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName116101_01)
end
