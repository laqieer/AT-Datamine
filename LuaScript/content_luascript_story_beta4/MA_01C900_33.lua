-- このluaスクリプトは、MA_01C900_33.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera002 = SetTemplate("Actor002",-49,CharaPos110122_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_003)
	Camera003 = SetTemplate("Actor003",-64,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_MardisantEnd")
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:私、消えなくちゃ…
	Talk(Actor004,"telop","narration","L","MA_01C900_320002")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.0)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_MardisantEnd")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:色々あったけど、前向いていかないとな<br>私たちはこうして生きてるんだからさ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_330002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガレス★★:生きてるから兄さんたちのことを覚えていられる<br>…だから、これでよかったんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_330003")

	change_face(Actor002,"Smile")

	--★★ガレス★★:これからもよろしくな、ノワール
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_330004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:…え？ディナタンがどこにいるかって？<br>知らないよ。一緒じゃないのか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C900_330005")

	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★リオネス★★:学園を復興して<br>またガレスと一緒に食堂をやるんだ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","MA_01C900_330007")


	--★★リオネス★★:目標があると前向きになれるよな！<br>ノワールも、色々手伝うんだぞ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","MA_01C900_330008")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_ADV_MardisantEnd")
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
