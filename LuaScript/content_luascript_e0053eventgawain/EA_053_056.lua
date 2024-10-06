-- このluaスクリプトは、EA_053_056.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-55,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",-160,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",45,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera004 = SetTemplate("Actor004",5,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera005 = SetTemplate("Actor005",-130,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera007 = SetTemplate("Actor007",-33,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera008 = SetTemplate("Actor008",-145,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
BgProp = setup_prop_object(10102009)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
load_image("201010710", "content_still_20101071_image", "201010710_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("201010710", 0.0, 0.0, 0.8,true,false)
set_scale_image(0.8,0.8)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-1.9, 0, 0.034})
set_pos(Actor004,{-1.54, 0, -0.3})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-0.89, 0, 2.94})
set_pos(Actor007,{-0.71, 0, -0.58})
set_pos(Actor008,{-0.1, 0, 2.39})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005,Actor001,"J_Head")
keep_ik_lookat(Actor006,Actor001,"J_Head")
keep_ik_lookat(Actor007,Actor001,"J_Head")
keep_ik_lookat(Actor008,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401018","001","401018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101033","003","101033003","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.4)
PlayPartVoiceDirect("ガウェイン_004","0054")
-- ▲直接出力

	--★★ガウェイン★★:そうだよな。ヒーローってのは<br>別にひとりでやるもんじゃねーよな
	Talk(Actor001,"CHRNAME_GAWAIN","simple","N","EA_053_0560013")

-- ▼直接出力
PlayActionDirect(Actor005,"to  Std_Worry")
SkipDefaultMotion(Actor005)
-- ▲直接出力

	--★★ガウェイン★★:そんでもって、ヒーローの在り方だって<br>きっとひとつじゃねーんだ
	Talk(Actor001,"CHRNAME_GAWAIN","simple","N","EA_053_0560014")


	--★★ガウェイン★★:誰かを守ること、誰かのピンチを救うこと<br>困っている誰かに手を差し伸べること
	Talk(Actor001,"CHRNAME_GAWAIN","simple","N","EA_053_0560015")


	--★★ガウェイン★★:どんな些細なことだって<br>その先に、誰かの笑顔があるのなら――
	Talk(Actor001,"CHRNAME_GAWAIN","simple","N","EA_053_0560016")

	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:そいつは「ヒーローの仕事」ってヤツなんだ
	Talk(Actor001,"CHRNAME_GAWAIN","simple","N","EA_053_0560017")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
hide_image(0)
wait_time(0.2)
--フェードイン
setup_small_camera_start(Camera001)
wait_time(CHARA_IN_OUT + 0.5)
fadein(CHARA_IN_OUT)
wait_time(1)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0012")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:…よっしゃ！なんか気分が上がってきたぜ！<br>おーい、皆！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0560019")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★ガウェイン★★:ヒーローのお手製のお菓子、まだまだあるぞー！<br>どんどんもらいにきてくれよ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0560020")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("子供_女1","0029")
-- ▲直接出力

	--★★子供（女）②★★:え！？これ、ガウェインが作ったの！？
	Talk(Actor003,"NPCNAME_0140","speech","L","EA_053_0560021")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0029")
-- ▲直接出力

	--★★子供（男）②★★:ガウェイン、すげー！
	Talk(Actor002,"NPCNAME_0141","speech","L","EA_053_0560022")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:へへっ！そうだろそうだろ！<br>すげーだろ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0560023")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0011")
PlayActionDirect(Actor001,"to  Std_Joy")
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0560025")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102009)
load_image_preload("201010710", "content_still_20101071_image", "201010710_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401018","001","401018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401020","001","401020001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101033","003","101033003","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
