-- このluaスクリプトは、MA_01B109_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("MA01B9000701", "content_still_10102009_image", "101020090_StillImage")
load_image("MA01B9000701_2", "content_still_10102009_image", "101020090_StillImage")
load_image("MA01B9000702", "content_still_10102010_image", "101020100_StillImage")
show_image("MA01B9000701", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★アーサー★★:「はじめまして<br>最低の格好だな」
	Talk(Actor001,"CHRNAME_ARTHUR","speech","N","MA_01B109_080002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
show_image("MA01B9000702", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ランスロット★★:『妖精殺し』探索の任<br>是非このランスロットに！
	Talk(Actor002,"CHRNAME_LANCELOT","speech","N","MA_01B109_080004")

	PlayAction(Actor001,"to  Std_No")

	--★★アーサー★★:「不躾で不作法、騎士には到底似合わん<br>なんのためにここまで参った？」
	Talk(Actor001,"CHRNAME_ARTHUR","speech","N","MA_01B109_080005")


	--★★ランスロット★★:円卓の騎士になるために
	Talk(Actor002,"CHRNAME_LANCELOT","speech","N","MA_01B109_080007")


	--★★アーサー★★:「つまみ出せ<br>円卓も今は満席でな」
	Talk(Actor001,"CHRNAME_ARTHUR","speech","N","MA_01B109_080008")


	--★★ランスロット★★:ここで待つと誓ったのです！
	Talk(Actor002,"CHRNAME_LANCELOT","speech","N","MA_01B109_080010")


	--★★アーサー★★:「誓った、誰に？」
	Talk(Actor001,"CHRNAME_ARTHUR","speech","N","MA_01B109_080011")


	--★★ランスロット★★:家族に！！
	Talk(Actor002,"CHRNAME_LANCELOT","speech","N","MA_01B109_080013")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
show_image("MA01B9000701_2", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★アーサー★★:「…その誓いも無用の長物」
	Talk(Actor001,"CHRNAME_ARTHUR","speech","N","MA_01B109_080014")


	--★★アーサー★★:「どうせ間もなく終わりは来る<br>俺が終わらせることになるやもしれぬ」
	Talk(Actor001,"CHRNAME_ARTHUR","speech","N","MA_01B109_080015")


	--★★アーサー★★:「妖精も消えた。奇跡は起こらん<br>もはや生も学園も続くのは惰性でしかない」
	Talk(Actor001,"CHRNAME_ARTHUR","speech","N","MA_01B109_080016")


	--★★アーサー★★:「去れ。最低騎士」
	Talk(Actor001,"CHRNAME_ARTHUR","speech","N","MA_01B109_080017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA01B9000701", "content_still_10102009_image", "101020090_StillImage")
load_image_preload("MA01B9000701_2", "content_still_10102009_image", "101020090_StillImage")
load_image_preload("MA01B9000702", "content_still_10102010_image", "101020100_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110071_01)
end
