-- このluaスクリプトは、MA_01B112_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-91.1,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★クレア★★:『父なる彼』のことを<br>ガラハッドは？
	Talk(Actor001,"CHRNAME_CLARE","speech","L","MA_01B112_080002")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:知りません…。銀卓騎士団に<br>いちばん最後に加わったのがあの子ですから
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","MA_01B112_080003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★リリアーナ★★:銀卓に加わるまでのあの子は戦いを知らず<br>『父なる彼』と接する機会もありませんでした
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","MA_01B112_080004")


	--★★クレア★★:話を戻すけれど、リリアーナ？
	Talk(Actor001,"CHRNAME_CLARE","speech","L","MA_01B112_080005")

	PlayAction(Actor001,"to  Std_Talk")

	--★★クレア★★:『父なる彼の遺児』というのはつまり<br>貴方たち銀卓のことを言うのかしら？
	Talk(Actor001,"CHRNAME_CLARE","speech","L","MA_01B112_080006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:いいえ…私たちはあくまで<br>『彼』を父と崇めているのみ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","MA_01B112_080007")


	--★★リリアーナ★★:恐れ多いことです<br>本当の遺児は他にいます
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","MA_01B112_080008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★クレア★★:…銀卓騎士団は誰を護ろうとしているの？
	Talk(Actor001,"CHRNAME_CLARE","speech","L","MA_01B112_080009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
