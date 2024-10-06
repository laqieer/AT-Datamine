-- このluaスクリプトは、MA_01A900_45.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114042_01","114042_01_h")
Include("content_adv_advsmall_114042_01","Template114042_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera114042_01()
	InitializeTemplate114042_01()
-- ▼直接出力
load_image("10301007", "content_still_10301007_image", "103010070_StillImage")
-- ▲直接出力
-- ▼直接出力
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301007", 0.0, 0.0, 0.0)
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Tyrfing_Rich")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114042)
	Actor001 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor002 = InitializeCharacter_2DOnly("101001","001","101001001")
	Actor003 = InitializeCharacter_2DOnly("101009","001","101009001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:きっかけは<br>錆びついた剣の軋み
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_450002")


	--★★ギネヴィア★★:誰にも抜けないこの剣は太古から<br>バルバロイの封だとも言われていたわ
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_450004")


	--★★ギネヴィア★★:そもそもキャメリアードは<br>この剣を守護する役目を得た国だったの
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_450006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:カリバーンは土地からエネルギーを奪う魔剣<br>だから資源が吸い取られちゃって…
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_450007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:我が国はビンボーになった…<br>とか嘆く者もいたけど、どうかしらね
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01A900_450008")

-- ▼直接出力
bgm_play("BGM_ADV_Tyrfing_Rich")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
off_cameraframe()
off_screencolor()
fadein(IMAGE_TIME_OUT_IN + 1.0)
wait_time(IMAGE_TIME_OUT_IN + 2.0)
-- ▲直接出力

	--★★ティルフィング★★:劔をご用命ですか？
	Talk(Actor002,"NPCNAME_0117","simple","N","MA_01A900_450010")


	--★★ティルフィング★★:アナタが名前を呼んでくれるのが<br>とてもうれしかった
	Talk(Actor002,"NPCNAME_0117","simple","N","MA_01A900_450012")


	--★★ティルフィング★★:私はアナタを探していたのかもしれない
	Talk(Actor002,"NPCNAME_0117","simple","N","MA_01A900_450013")


	--★★ティルフィング★★:幾千年の孤独を経て<br>再び誰かの力となれることがうれしかった
	Talk(Actor002,"NPCNAME_0117","simple","N","MA_01A900_450014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_To_End")
-- ▲直接出力

	--★★ティルフィング★★:我が本銘は…
	Talk(Actor002,"NPCNAME_0117","simple","N","MA_01A900_450015")

	open_select_window_tag(Actor003,"Normal","MA_01A900_450016")
	if is_select(1) then
		goto BlockMA_01A900_45_1_1
	end

::BlockMA_01A900_45_1_1::
	CloseTalkWindow()
	goto BlockMA_01A900_45_1end

::BlockMA_01A900_45_1end::
-- ▼直接出力
voice_play("VO_101009_sp_0007_2")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Serious")

	--★★ノワール★★:
	Talk(Actor003,"CHRNAME_NOIR","speech","N","MA_01A900_450018")

	close_cutin()
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10301007", "content_still_10301007_image", "103010070_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
preload_sound("BGM_ADV_Tyrfing_Rich")
	InitializeLoad_Preload()
	load_area_scene_preload(114042)
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_2DOnly_Preload("101001","001","101001001")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114042_01)
end
