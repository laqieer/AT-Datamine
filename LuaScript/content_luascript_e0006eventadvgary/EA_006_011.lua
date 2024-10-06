-- このluaスクリプトは、EA_006_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:ノワールが<ruby=ゲシュタルト・シフト>ＧＳ</ruby>の相手にディナタンを<br>選んでから２ヶ月ほどが経った
	Talk(Actor001,"","simple","L","EA_006_0110002")


	--★★テロップ★★:学園、そして世界に迫る危機<br>その重苦しく暗い影を感じながら
	Talk(Actor001,"","simple","L","EA_006_0110004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★テロップ★★:それでも、ノワールをはじめ<br>学園の生徒たちは前を向こうとしていた
	Talk(Actor001,"","simple","L","EA_006_0110005")


	--★★テロップ★★:まるで振り返ることすら<br>罪であるかのように
	Talk(Actor001,"","simple","L","EA_006_0110006")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
CloseTalkWindow() --疑似バトルならclose_speech_window(
hide_image(BLACK_WHITE_TIME)
wait_time(1.5)
bgm_play("BGM_Area_Noon")
-- ▲直接出力

	--★★ノワール★★:ガレスはすごいな<br>あんなことがあった後なのに元気で
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0110009")


	--★★ノワール★★:いつもみたいに、笑って――
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0110010")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ノワール★★:………
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0110011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:…でも、本当に大丈夫かななんか、無理に明るく振る舞っていたような…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0110012")


	--★★ノワール★★:様子を見に行ってみるか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0110013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
preload_sound("BGM_Area_Noon")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
