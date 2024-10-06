-- このluaスクリプトは、MA_01A112_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera002 = SetTemplate("Actor003",nil,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	Camera003 = SetTemplate("Actor004",nil,CharaPos110141_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_005)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image("101010150_start", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101030390", "content_still_10103039_image", "101030390_StillImage")
-- ▲直接出力
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10103008_anim", "10103008_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor003,0.6,0.1,0.9,0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{2.568, 0, 2.627})
set_rot(Actor004,{0,313.6539,0})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
show_image("101010150_start", 0.0, 0.0,0,true,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,-0.203, 1.643, 1.068)
-- ▲直接出力
-- ▼直接出力
lookoj2 = create_object("kara2")
set_pos_object(lookoj2,2.146, 1.276, 2.886)
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({0.33, 2.322, 1.74,   26.39999, 64.17599, 0,   33})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({0.406, 2.28, 1.487,   21.7, 55.99999, 0,   28})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115144)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor003 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
stillAnime.SetActive(true)
signal_anim = play_ui_timeline_controller_in(stillAnime)
hide_image(0.5)
while signal_anim.IsProccessing() do
coroutine.yield()
	end
-- ▲直接出力

	--★★エレイン★★:これは勲章
	Talk(Actor003,"CHRNAME_ELAINE","simple","N","MA_01A112_120002")


	--★★エレイン★★:ギネヴィアさんを守ることができた勲章です
	Talk(Actor003,"CHRNAME_ELAINE","simple","N","MA_01A112_120003")


	--★★エレイン★★:先輩も守ることが出来ます<br>ギネヴィアさんみたいに
	Talk(Actor003,"CHRNAME_ELAINE","simple","N","MA_01A112_120004")


	--★★エレイン★★:先輩に、やっと近づける
	Talk(Actor003,"CHRNAME_ELAINE","simple","N","MA_01A112_120005")

-- ▼直接出力
CloseTalkWindow()
signal_anim = play_ui_timeline_controller_out(stillAnime, true)
while signal_anim.IsProccessing() do
coroutine.yield()
	end
fadeout(255,255,255, 1.0, STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
stillAnime.SetActive(false)
setup_small_camera_start(RndCamera001)
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…立たなくていい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_120007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:みんなの助けになりたい<br>先輩みたいに
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_120008")


	--★★エレイン★★:沢山の人の前で強くありたい<br>ギネヴィアさんみたいに
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_120009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★エレイン★★:先輩の隣に、立ちたい──…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A112_120010")

-- ▼直接出力
CloseTalkWindow()
show_image("101010150", 0.0, 0.0, 0.5,false,false)
set_scale_image(20,20)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(BLACK_WHITE_WAIT_TIME)
Hide(Actor003)
Appear(Actor004)
set_enable_auto_lookat(Actor004,false)
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001, {0.8, 0.2, 0.5, 0.5})
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
setup_small_camera_start(Camera001)
se_play("SE_ADV_CO_101035_0702_Hug")
change_face(Actor001,"Surprise")
wait_time(0.5)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:エレイン！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_120012")

-- ▼直接出力
CloseTalkWindow()
show_image("101030390", 0.0, 0.0, 0,true,false)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_120014")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
hide_image(0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat_object(Actor004,nil,"kara2",0.3)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★エレイン_2★★:………なのに<br>外に出られないんです
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120016")


	--★★エレイン_2★★:口を開くことすら痛くて<br>笑うことは辛くて…
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120017")

-- ▼直接出力
change_face(Actor001,"Sad")
-- ▲直接出力
	change_face(Actor004,"Pain")

	--★★エレイン_2★★:一度キズがついただけで足がすくんで<br>本当に、どうしようもなく、いくじなし…！
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120019")

	change_face(Actor004,"Anger")

	--★★エレイン_2★★:先輩に出会って<br>ギネヴィアさんを見て！
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120020")

	change_face(Actor004,"Sad")

	--★★エレイン_2★★:やっと私は変われたと…<br>変えてもらえたと思えて！
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120021")


	--★★エレイン_2★★:それを誰かに見てもらいたかった！<br>兄に「もう心配ないよ」って言いたかった！
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120023")


	--★★エレイン_2★★:がんばろう、がんばろう、がんばろうって…！<br>ごめんなさい、弱音ばっかり、ごめんなさい…！
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120024")


	--★★エレイン_2★★:ちゃんと、笑って、話せなくて………！
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120025")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01B109_11_Door")
wait_time(0.5)
change_face(Actor001,"Surprise")
keep_delay_ik_lookat_object(Actor001,nil,"kara",0.28)
wait_time(0.2)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,185,0.1)
slidemove(Actor001,2.05,0,2.869,0.38)
wait_time(0.38)
PlayActionDirect(Actor001,"to Std_Loop")
lookat_delay_weight(Actor004,0.8,0.1,0.9,0.9,0.5)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_120027")

-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★エレイン_2★★:…どうか、しました…？
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120028")

	change_face(Actor001,"Normal")

	--★★ノワール★★:今、外でなにか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_120029")

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★エレイン_2★★:行かないで…
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120030")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…え
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_120031")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor004,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat_object(Actor004,nil,"kara2",0.3)
wait_time(1.0)
-- ▲直接出力

	--★★エレイン_2★★:外に行かないで…今、だけでも…<br>近くに、もう少し、いて…
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120032")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",0.3)
wait_time(1.0)
-- ▲直接出力

	--★★エレイン_2★★:今だけ何も言わずに<br>私を見ていてくれませんか
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120033")

-- ▼直接出力
setup_small_camera_start(CameraEx_02)
wait_time(0.2)
-- ▲直接出力

	--★★エレイン_2★★:そばにいてくれませんか………？
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","MA_01A112_120034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010150_start", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101030390", "content_still_10103039_image", "101030390_StillImage")
load_ui_effect_preload("content_still_10103008_anim", "10103008_StillAnim", nil, nil, nil, "Root")
	InitializeLoad_Preload()
	load_area_scene_preload(115144)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
