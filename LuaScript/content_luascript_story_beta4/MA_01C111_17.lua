-- このluaスクリプトは、MA_01C111_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111015_01","111015_01_h")
Include("content_adv_advsmall_111015_01","Template111015_01_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111015_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111015_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111015_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111015_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_006)
	InitializeTemplateRandomCamera111015_01()
	InitializeTemplate111015_01()
-- ▼直接出力
movie_load("MA_01C111_17")
movie_set_active(true)
movie_play()
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("10104022", "content_still_10104022_image", "101040220_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Arthur_Start")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111015)
	Actor001 = InitializeCharacter_3D("101015","003","101015003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","002","101013002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
movie_wait_playing()
movie_stop()
--ムービー後待機
wait_time(MOVIE_AFTER)
setup_small_camera_start(RndCamera001)
hide_image(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_Arthur_Start")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アーサー★★:ガウェイン…本当によかったのか？<br>俺についてきて
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_170007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:俺が王と認めるのはあなただけですから<br>あのときから、ずっと
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01C111_170008")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ガウェイン★★:王様のくせして自分が前に出てきちまう<br>皆のためにひとりで戦って、傷ついて
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01C111_170009")


	--★★ガウェイン★★:昔からそうだ。あなたはなにも変わっちゃいない<br>そんな王様、放っておけないでしょ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01C111_170010")

	change_face(Actor001,"Normal")

	--★★アーサー★★:ガウェイン…
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_170012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Serious")

	--★★ガウェイン★★:俺があなたの騎士になる<br>血生臭い仕事も全部引き受ける
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01C111_170013")


	--★★ガウェイン★★:だからあなたは王として――
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01C111_170014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10104022", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
 voiceSignalS = voice_play("VO_story01_D_0362")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
movie_load_preload("MA_01C111_17")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("10104022", "content_still_10104022_image", "101040220_StillImage")
preload_sound("BGM_Battle_Arthur_Start")
	InitializeLoad_Preload()
	load_area_scene_preload(111015)
	InitializeCharacter_3D_Preload("101015","003","101015003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","002","101013002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111015_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
