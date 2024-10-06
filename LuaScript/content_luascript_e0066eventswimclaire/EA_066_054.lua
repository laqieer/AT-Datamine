-- このluaスクリプトは、EA_066_054.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation11","DuelCommonFormation11_h")
Include("content_adv_advsmall_duelcommonformation11","TemplateDuelCommonFormation11_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation11_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation11_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation11_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_003)
	Camera004 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation11_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_010)
	InitializeTemplateRandomCameraDuelCommonFormation11()
	InitializeTemplateDuelCommonFormation11()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{1.268,0,-8.022})
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
--黒背景の表示
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
seihai = setup_prop_object(10201022)
set_pos(seihai , {0,0.074,16.381})
Ef_Holy_Grail01 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", true, false)
Ef_Holy_Grail02 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail02", true, false)
set_pos(Ef_Holy_Grail01, {0,0.074,16.381})
set_pos(Ef_Holy_Grail02, {0,0.074,16.381})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101030011)
	Actor001 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
se_play("SE_ADV_MA_01A111_14_sword_01")
wait_time(4.8)
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
local gopos = {1.268, 0, -5.667}
setup_small_camera_start(Camera001)
turn_lookat_position(Actor001, gopos, 0)
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001, gopos, 0.8)
wait_time(0.8)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラロゥ★★:や、やった！倒した！<br>あとは聖杯を――
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0540005")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
local camera = {RndCamera090,RndCamera001,RndCamera002,RndCamera003,RndCamera007,RndCamera011,Camera001,Camera002,Camera003,Camera004}
for i = 1 , #camera do
    shake_camera(camera[i],1.0,-1)
end
se_play("SE_ADV_EA_066_054_Collapse_Loop")
wait_time(2)
setup_small_camera_end()
-- ▲直接出力
	open_cutin(3,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor002,"Surprise")
	on_cutin(3,Actor003,"Surprise")

	--★★全員★★:！！！
	Talk(Actor004,"NPCNAME_0394","speech","L","EA_066_0540007")

	close_cutin()
-- ▼直接出力
se_play("SE_LoopSE_Stop")
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0028")
-- ▲直接出力

	--★★ラロゥ★★:なに、また揺れるの！？
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0540008")

-- ▼直接出力
PlayPartVoiceDirect("クレア","0028")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:もしかして、あの魔獣を倒したことで<br>遺跡のバランスが――？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0540009")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0015")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ヴォールス★★:いかん…崩れる！<br>早くここから出るぞ！！
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540010")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0007")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ラロゥ★★:わかってる！<br>とりあえず聖杯を持って帰って――
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0540011")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_EA_066_054_Collapse_Loop")
wait_time(1)
se_play("SE_LoopSE_Stop")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Surp")
PlayPartVoiceDirect("ラロゥ","0029")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラロゥ★★:わあ！ウソでしょ…地面が割れた！？
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0540013")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_EA_066_054_Metal")
wait_time(0.4)
-- ▲直接出力

	--★★ラロゥ★★:…ああ！聖杯が、裂け目に――
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0540015")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★クレア★★:…！！
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0540016")

-- ▼直接出力
CloseTalkWindow()
local pos = {0,0,-2.997}
local gopos = {0,0,-2.938}
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002, gopos, 0.4)
wait_time(0.4)
setup_small_camera_end(Camera002)
setup_small_camera_start(Camera003)
PlayActionDirect(Actor002,"to Std_Loop")
slidemove(Actor002, pos, 0)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor002,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
PlayPartVoiceDirect("ヴォールス","0016")
-- ▲直接出力

	--★★ヴォールス★★:クレア！？なにをしている！！
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540019")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_end(Camera003)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★クレア★★:まだそこに引っ掛かってる<br>今ならまだ間に合うわ。手を伸ばせば、届く
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0540020")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ヴォールス★★:クレア…！
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540021")

-- ▼直接出力
setup_small_camera_end(Camera003)
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:聖杯が本物かどうか、願えばわかるわ<br>もし本物なら――
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0540022")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:…いいんだ、クレア
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540023")

-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:…！
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0540024")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ヴォールス★★:もう、いいんだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540025")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0041")
-- ▲直接出力

	--★★ヴォールス★★:あの選択が正しかったかどうかは<br>誰にもわからない。だが…これだけはわかる
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540026")


	--★★ヴォールス★★:あいつらの覚悟をなかったことにすべきじゃない<br>少なくとも…俺たちだけは
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540027")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoiceDirect("クレア","0029")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:…あなたは、それでいいのね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0540028")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start(Camera003)
PlayPartVoiceDirect("ヴォールス","0038")
-- ▲直接出力

	--★★ヴォールス★★:ああ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540029")


	--★★ヴォールス★★:この罪悪感も思い出だというのなら――<br>抱えて前に進むべきなんだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540030")

-- ▼直接出力
setup_small_camera_end(Camera003)
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:…それが遺された者として<br>俺の生きる道だ
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0540031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0025")
-- ▲直接出力

	--★★クレア★★:…そう。わかった
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0540032")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, 0.5,false,false)
set_scale_image(20,20)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:なら、わたしも一緒に行くわ<br>その道を
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0540034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10201022)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", true, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail02", true, false)
preload_sound("BGM_ADV_Antagonism")
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_duel_scene_preload(101030011)
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation11)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
