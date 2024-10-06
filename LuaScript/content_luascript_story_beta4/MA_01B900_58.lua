-- このluaスクリプトは、MA_01B900_58.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
Ef_VanishDust_EXCELIA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
Ef_VanishDust_ASTERA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
Ef_VanishDust_LILIANA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
local EXCELIA_EfPos = get_pos(Actor002)
local ASTERA_EfPos = get_pos(Actor003)
local LILIANA_EfPos = get_pos(Actor004)
set_pos(Ef_VanishDust_EXCELIA, EXCELIA_EfPos)
set_pos(Ef_VanishDust_ASTERA, ASTERA_EfPos)
set_pos(Ef_VanishDust_LILIANA, LILIANA_EfPos)
set_enable_auto_lookat_all(false)
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor001)
set_common_look_at(Actor004,Actor001)
Hide(Actor003)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
load_image("still01", "content_still_10102019_image", "101020190_StillImage")
-- ▲直接出力
-- ▼直接出力
Ef_C_Adv_VanishDust_Disappear_EXCELIA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true)
set_pos(Ef_C_Adv_VanishDust_Disappear_EXCELIA,{-0.478,0.128,21.841})
Ef_C_Adv_VanishDust_Disappear_ASTERA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true)
set_pos(Ef_C_Adv_VanishDust_Disappear_ASTERA,{-0.433,0.128,20.7741})
Ef_C_Adv_VanishDust_Disappear_LILIANA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true)
set_pos(Ef_C_Adv_VanishDust_Disappear_LILIANA,{-1.401,0.128,20.254})
-- ▲直接出力
-- ▼直接出力
Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Lop_Duel", false, true)
set_pos(Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA,{-0.433,0,20.7741})
set_scale(Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA,{0.8,1.5,0.8})
Ef_C_Adv_VanishGlow_Lop_Duel_ASTERA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Lop_Duel", false, true)
set_pos(Ef_C_Adv_VanishGlow_Lop_Duel_ASTERA,{-0.415,0,21.841})
set_scale(Ef_C_Adv_VanishGlow_Lop_Duel_ASTERA,{0.45,1.5,0.45})
Ef_C_Adv_VanishGlow_Lop_Duel_LILIANA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Lop_Duel", false, true)
set_pos(Ef_C_Adv_VanishGlow_Lop_Duel_LILIANA,{-1.401,0,20.254})
set_scale(Ef_C_Adv_VanishGlow_Lop_Duel_LILIANA,{0.8,1.3,0.8})
-- ▲直接出力
-- ▼直接出力
Ef_C_Adv_VanishGlow_Duel_EXCELIA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Duel", false, true)
set_pos(Ef_C_Adv_VanishGlow_Duel_EXCELIA,{-0.433,0,20.7741})
set_scale(Ef_C_Adv_VanishGlow_Duel_EXCELIA,{0.8,1.5,0.8})
Ef_C_Adv_VanishGlow_Duel_ASTERA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Duel", false, true)
set_pos(Ef_C_Adv_VanishGlow_Duel_ASTERA,{-0.415,0,21.841})
set_scale(Ef_C_Adv_VanishGlow_Duel_ASTERA,{0.45,1.5,0.45})
Ef_C_Adv_VanishGlow_Duel_LILIANA = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Duel", false, true)
set_pos(Ef_C_Adv_VanishGlow_Duel_LILIANA,{-1.401,0,20.254})
set_scale(Ef_C_Adv_VanishGlow_Duel_LILIANA,{0.8,1.3,0.8})
-- ▲直接出力
-- ▼直接出力
Ef_C_Adv_Killers_Area = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Area", false, true)
set_pos(Ef_C_Adv_Killers_Area,{-0.659,0,21.259})
set_rot(Ef_C_Adv_Killers_Area,{0,-50,0})
Ef_C_Adv_Killers_Area2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Area", false, true)
set_pos(Ef_C_Adv_Killers_Area2,{3.8,0,14.57})
-- ▲直接出力
-- ▼直接出力
movie_load("MA_01B900_58")
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★エクセリア★★:我ら銀卓<br>四脚なれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B900_580002")


	--★★リリアーナ★★:想いの天板はひとつ
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B900_580003")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★エクセリア★★:世界の片隅でひっそり<br>病とともに消えんとしていた我らに
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B900_580004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★エクセリア★★:ひとたび家族とともに戦える場所をくれたこと<br>心より感謝するわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B900_580005")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★リリアーナ★★:遅かれ早かれ銀卓騎士団は喪われる運命でした<br>残されるガラハッドだけが…心配でした
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B900_580006")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★リリアーナ★★:でも、もうだいじょうぶ
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B900_580008")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor003,Camera003,EntryData110071_01_05,CameraAssetBundleName110071_01,CameraPos110071_01_105)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アステラ★★:あの子は銀卓の誰よりも<br>最も強く輝き始めたわ
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","MA_01B900_580010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アステラ★★:もう、敵は無い
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","MA_01B900_580011")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★エクセリア★★:学園とは不思議な場所だったわね<br>戦いだけが生活の私たちには刺激ばかり
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B900_580012")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★リリアーナ★★:あの子が熱中するわけです<br>みんな暖かかった
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B900_580013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アステラ★★:平和ボケも<br>気持ちいいものなのね
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","MA_01B900_580014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
on_active(Ef_VanishDust_EXCELIA) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_VanishDust_EXCELIA)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_VanishDust_ASTERA) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_VanishDust_ASTERA)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_VanishDust_LILIANA) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_VanishDust_LILIANA)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力

	--★★ノワール★★:………どこへ行くんだ、これから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_580016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エクセリア★★:どこへも
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B900_580017")


	--★★リリアーナ★★:<ruby=ペレス>我らの主</ruby>が待つ寝床へ
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B900_580018")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★アステラ★★:そして<br><ruby=ガラハッド>あの子</ruby>に寄り添う思い出として
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","MA_01B900_580020")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★エクセリア★★:別れは告げないで行く<br>あの子の新しい門出のために
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B900_580022")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★リリアーナ★★:『父なる彼』と『その遺児』…
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B900_580023")


	--★★リリアーナ★★:<dot>忘れ去られた彼ら</dot>の存在の証──<br>それこそがあなたとガラハッドです
	Talk(Actor004,"CHRNAME_LILIANA","speech","L","MA_01B900_580024")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA) 
play_particle(Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA)
on_active(Ef_C_Adv_VanishGlow_Lop_Duel_ASTERA) 
play_particle(Ef_C_Adv_VanishGlow_Lop_Duel_ASTERA)
on_active(Ef_C_Adv_VanishGlow_Lop_Duel_LILIANA) 
play_particle(Ef_C_Adv_VanishGlow_Lop_Duel_LILIANA)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アステラ★★:その軌跡を継いで
	Talk(Actor003,"CHRNAME_ASTERA","speech","L","MA_01B900_580026")

-- ▼直接出力
CloseTalkWindow()
close_textbox_base()
disableTextBox = true
on_active(Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA) 
set_particle_speed(Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA, 1.5)
play_particle(Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA)
on_active(Ef_C_Adv_VanishGlow_Lop_Duel_ASTERA) 
set_particle_speed(Ef_C_Adv_VanishGlow_Lop_Duel_ASTERA, 1.5)
wait_time(1.0)
on_active(Ef_C_Adv_VanishGlow_Duel_EXCELIA) 
set_particle_speed(Ef_C_Adv_VanishGlow_Duel_EXCELIA, 1.5)
play_particle(Ef_C_Adv_VanishGlow_Duel_EXCELIA)
on_active(Ef_C_Adv_VanishGlow_Duel_ASTERA) 
set_particle_speed(Ef_C_Adv_VanishGlow_Duel_ASTERA, 1.5)
play_particle(Ef_C_Adv_VanishGlow_Duel_ASTERA)
on_active(Ef_C_Adv_VanishGlow_Duel_LILIANA) 
set_particle_speed(Ef_C_Adv_VanishGlow_Duel_LILIANA, 1.5)
play_particle(Ef_C_Adv_VanishGlow_Duel_LILIANA)
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
movie_set_active(true)
movie_play()
movie_wait_playing()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_VanishDust_EXCELIA)
off_active(Ef_C_Adv_VanishGlow_Duel_EXCELIA) 
off_active(Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA)
stop_particle(Ef_VanishDust_EXCELIA)
stop_particle(Ef_C_Adv_VanishGlow_Duel_EXCELIA)
stop_particle(Ef_C_Adv_VanishGlow_Lop_Duel_EXCELIA)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_VanishDust_ASTERA)
off_active(Ef_C_Adv_VanishGlow_Duel_ASTERA) 
off_active(Ef_C_Adv_VanishGlow_Lop_Duel_ASTERA)
stop_particle(Ef_VanishDust_ASTERA)
stop_particle(Ef_C_Adv_VanishGlow_Duel_ASTERA) 
stop_particle(Ef_C_Adv_VanishGlow_Lop_Duel_ASTERA)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_VanishDust_LILIANA)
off_active(Ef_C_Adv_VanishGlow_Duel_LILIANA) 
off_active(Ef_C_Adv_VanishGlow_Lop_Duel_LILIANA)
stop_particle(Ef_VanishDust_LILIANA)
stop_particle(Ef_C_Adv_VanishGlow_Duel_LILIANA) 
stop_particle(Ef_C_Adv_VanishGlow_Lop_Duel_LILIANA)
-- ▲直接出力
-- ▼直接出力
 --[[
on_active(Ef_C_Adv_VanishDust_Disappear_EXCELIA) 
set_particle_speed(Ef_C_Adv_VanishDust_Disappear_EXCELIA, 0.25)
play_particle(Ef_C_Adv_VanishDust_Disappear_EXCELIA)
on_active(Ef_C_Adv_VanishDust_Disappear_ASTERA) 
set_particle_speed(Ef_C_Adv_VanishDust_Disappear_ASTERA, 0.25)
play_particle(Ef_C_Adv_VanishDust_Disappear_ASTERA)
on_active(Ef_C_Adv_VanishDust_Disappear_LILIANA) 
set_particle_speed(Ef_C_Adv_VanishDust_Disappear_LILIANA, 0.25)
play_particle(Ef_C_Adv_VanishDust_Disappear_LILIANA)
]]
on_active(Ef_C_Adv_Killers_Area) 
play_particle(Ef_C_Adv_Killers_Area)
movie_stop()
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_C_Adv_Killers_Area2) 
play_particle(Ef_C_Adv_Killers_Area2)
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
load_image_preload("still01", "content_still_10102019_image", "101020190_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust_Disappear", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Lop_Duel", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Lop_Duel", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Lop_Duel", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Duel", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Duel", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishGlow_Duel", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Area", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Area", false, true)
movie_load_preload("MA_01B900_58")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
