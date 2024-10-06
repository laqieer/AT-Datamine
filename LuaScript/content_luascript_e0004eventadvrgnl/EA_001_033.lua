-- このluaスクリプトは、EA_001_033.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114042_01","114042_01_h")
Include("content_adv_advsmall_114042_01","Template114042_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",0,CharaPos114042_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_001)
	Camera002 = SetTemplate("Actor002",0,CharaPos114042_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_002)
	Camera003 = SetTemplate("Actor003",0,CharaPos114042_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_001)
	Camera004 = SetTemplate("Actor004",147,CharaPos114042_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_006)
	Camera005 = SetTemplate("Actor005",152,CharaPos114042_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_007)
	Camera006 = SetTemplate("Actor006",135,CharaPos114042_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_008)
	InitializeTemplateRandomCamera114042_01()
	InitializeTemplate114042_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
set_animationbattlecontroller(Actor003, 4, true)
set_pos(Actor001,{-0.514,0,-19.93})
Ef_Emblem01 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem05", false)
Ef_Emblem02 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
set_pos(Ef_Emblem02,{-0.514,0,-18.035})
Ef_Emblem03 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
set_pos(Ef_Emblem03,{-0.514,0,-18.035})
CUT_1 = set_camera({0.13061,1.56363,-19.8265,3.95401,340.438,0,22})
axe001 = set_object("content_weapon_102010001", "weapon_model_102010001", true)
 --axe001 = set_object("content_model_weapon_03_axh_wpn_03_axh_009", "Wpn_03_axh_009", true)
axe001_offset  = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{0.41,0,-19.956})
lookat_weight(Actor002,{1.0,0.03,1.0,0.2})
sword001 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
sword001_offset  = {0,0,0,0,0,0}
on_parent(sword001,Actor002, "Loc_weapon_constrint_R", sword001_offset)
set_animationbattlecontroller(Actor002, 1, false)
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor001, 11, true)
set_pos(Actor003,{-0.514,0,-18.035})
Hide(Actor003)
gun001 = set_object("content_weapon_106010001", "weapon_model_106010001", true)
 --gun001 = set_object("content_model_weapon_11_gun_wpn_11_gun_001", "Wpn_11_gun_001", true)
gun001_offset  = {0,0,0,0,0,0}
on_parent(gun001,Actor001, "Loc_weapon_constrint_R", gun001_offset)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{0.007,0,-14.249})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{1.482,0,-15.591})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-1.677,0,-15.247})
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"ToIdle")
wait_time(0.3)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"ToIdle")
wait_time(0.3)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"ToIdle")
-- ▲直接出力
-- ▼直接出力
CameraEX_01 = set_camera({-6.94,3.05,-29.77,4.389,23.256,-1.38,28.8})
CameraEX_02 = set_camera({-0.5,1.46,-15.12,7.274,-181.1,-0.2,28})
CameraEX_03 = set_camera({-0.43,1.47,-16.24,3.187,-178.029,1.45,22})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Running")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114042)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","002","101018002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"ToWalk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,-0.514,0,-18.035,2.0)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"ToIdle")
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.2)
-- ▲直接出力

	--★★ラグネル★★:…ちょっとの光が嬉しかったりするよね<br>曇ってるとき、ちょっと太陽が見えたりしてさ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_033002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0007")
-- ▲直接出力

	--★★ラグネル★★:君はそんなヤツだよ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_033003")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEX_01)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:バケモンにやられっぱなしの<br>あたしたちに差した、ちょっとしたキラキラ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_033004")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:ガウェインとかアーサー様、笑ってたんだよ？<br>この学園、なにかが変わりそうだって騒いでたの
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_033005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_1)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:あたしもそれに乗っかりたくって<br>ぶっちゃけ空回ってるけど──
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_033006")

-- ▼直接出力
setup_small_camera_start(CameraEX_02)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
effect_at_character(Actor001, "Chest", Ef_Emblem01, 0.0, 0.15, 0.0)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_Emblem02)
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_Emblem02)
-- ▲直接出力
-- ▼直接出力
wait_time(2.3)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_Emblem03)
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_Emblem03)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1,0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
on_parent(axe001,Actor003, "Loc_weapon_constrint_R", axe001_offset)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
fadein(0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_Emblem01)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_Emblem02)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_Emblem03)
-- ▲直接出力
-- ▼直接出力
stop_particle(Ef_Emblem02)
-- ▲直接出力
-- ▼直接出力
stop_particle(Ef_Emblem03)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_Running")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0008")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル_キラーズ★★:腕づくは得意だよ
	Talk(Actor003,"CHRNAME_RAGNAR2","speech","L","EA_001_033008")

	change_face(Actor003,"Laugh")

	--★★ラグネル_キラーズ★★:つらくてもまだまだ楽しいことあるんだーってさ<br>みんなに思ってもらえるお祭り騒ぎにしたいの
	Talk(Actor003,"CHRNAME_RAGNAR2","speech","L","EA_001_033010")

-- ▼直接出力
setup_small_camera_start(CameraEX_03)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0026")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル_キラーズ★★:シラけさせたくないもんね
	Talk(Actor003,"CHRNAME_RAGNAR2","speech","L","EA_001_033012")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem05", false)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
set_object_preload("content_weapon_102010001", "weapon_model_102010001", true)
axe001_offset  = {0,0,0,0,0,0}
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
sword001_offset  = {0,0,0,0,0,0}
set_object_preload("content_weapon_106010001", "weapon_model_106010001", true)
gun001_offset  = {0,0,0,0,0,0}
preload_sound("BGM_Battle_Running")
	InitializeLoad_Preload()
	load_area_scene_preload(114042)
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","002","101018002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114042_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
