-- このluaスクリプトは、MS_002_054.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100021_03","100021_03_h")
Include("content_adv_advsmall_100021_03","Template100021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_ms0002_01_Controller","to Std_Loop",CameraAssetBundleName100021_03,CameraPos100021_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos100021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_523_01_StdController","to Std_Loop",CameraAssetBundleName100021_03,CameraPos100021_03_003)
	Camera003 = SetPlayerTemplate("Actor003",nil,CharaPos100021_03_012,CameraAssetBundleName100021_03,CameraPos100021_03_012)
	Camera004 = SetTemplate("Actor004",nil,CharaPos100021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100021_03,CameraPos100021_03_001)
	InitializeTemplateRandomCamera100021_03()
	InitializeTemplate100021_03()
-- ▼直接出力
　set_enable_auto_lookat_all(false)


-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
CUT_10 =  cat_template_camera("P10_Cam")
CUT_11 =  cat_template_camera("P11_Cam")
CUT_12 =  cat_template_camera("P12_Cam",Actor003)
CUT_13 =  cat_template_camera("P13_Cam")
CUT_14 =  cat_template_camera("P14_Cam",Actor003)
CUT_15 =  cat_template_camera("P15_Cam")
CUT_16 =  cat_template_camera("P16_Cam")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_10)
-- ▲直接出力
-- ▼直接出力

RndCamera001=CUT_10
shake_camera(CUT_10, 0.72, 3.5)
shake_camera(CUT_11, 0.72, 3.5)
se_play("SE_ADV_MA_01A111_14_Earthquake")
se_play("SE_LoopSE_Stop")
Hide(Actor002)
Hide(Actor001)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{0, 0, -25.307})
set_pos(Actor002,{0, 0, -15.88})
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,0, 0, -9.307,3.5)
-- ▲直接出力
-- ▼直接出力
Ef_WarpOUT = load_particle("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
set_pos(Ef_WarpOUT,{-0.798, 0.21, -6.782})
-- ▲直接出力
-- ▼直接出力
Ef_WarpIN = load_particle("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
set_pos(Ef_WarpIN,{-0.798, 0.21, -6.782})
-- ▲直接出力
-- ▼直接出力
Ef_Over = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Teleport_Killers", false, true)
set_pos(Ef_Over,{0, 0, -5.632})

Ef_Over2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Area", false, true)
set_pos(Ef_Over,{0, 0, -5.632})
-- ▲直接出力
-- ▼直接出力
Ef_fh1 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
set_pos(Ef_Over,{0, 0.21, -5.632})
-- ▲直接出力
-- ▼直接出力
Ef_Over3 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Resonance", false, true)
set_pos(Ef_Over3,{0, 0, -5.762})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Armoury")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100021)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101070","001","101070001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializePlayerCharacter("Actor003")
	Actor004 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力

wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
setup_small_camera_start(CUT_11)
PlayActionDirect(Actor003,"to RunEnd_pose")
wait_time(0.5)
PlayActionDirect(Actor003,"to RunEnd")
wait_time(1.5)
on_active(Ef_WarpOUT)
play_particle(Ef_WarpOUT)
Appear(Actor004)
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,0, 0, -6.034,1.85)
wait_time(1.85)
PlayActionDirect(Actor003,"to Std_Loop")
bgm_play("BGM_ADV_Armoury")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0009")
-- ▲直接出力

	--★★アルハン2★★:
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0540004")


	--★★アルハン2★★:ゆえにキサマは己が傷ついてでも<br>他者を救おうとしている。それは高潔だ
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0540006")

	change_face(Actor004,"Sad")

	--★★アルハン2★★:…だが、以前の潜行から合間がない…<br>キサマの身にどんな異変が起こるかわからぬ
	Talk(Actor004,"NPCNAME_0313","speech","L","MS_002_0540008")

-- ▼直接出力
setup_small_camera_start(CUT_12)
heroId = GetPlayerStyleId()
if heroId == 101003001 or heroId == 101005001 or heroId == 101007001 then
    set_animationcontroller(Actor003,"ms0002_01_m_Controller", "to MS002_054_RaiseHand01_Start")
else
    set_animationcontroller(Actor003,"ms0002_01_f_Controller", "to MS002_054_RaiseHand01_Start")
end
wait_time(1.35)
heroId = GetPlayerStyleId()
if heroId == 101003001 then
    heroIdshort = 101003
    on_parent(Actor001,Actor003,"J_Shoulder_L",0,0,0,0,0,0)
elseif heroId == 101005001 then
    heroIdshort = 101005
    on_parent(Actor001,Actor003,"J_Shoulder_L",0,0,0,0,0,0)
elseif heroId == 101007001 then
    heroIdshort = 101007
    on_parent(Actor001,Actor003,"J_Shoulder_L",0,0,0,0,0,0)
elseif heroId == 101004001 then
    heroIdshort = 101004
    on_parent(Actor001,Actor003,"J_Shoulder_L",-0.023,-0.036,0.013,1.072,9.748,0.536)
elseif heroId == 101006001 then
    heroIdshort = 101006
    on_parent(Actor001,Actor003,"J_Shoulder_L",-0.023,-0.036,0.013,1.072,9.748,0.536)
else
    heroIdshort = 101008
    on_parent(Actor001,Actor003,"J_Shoulder_L",0,-0.038,-0.014,0,0,0)
end
-- ▲直接出力
-- ▼直接出力
Appear(Actor001)
Hide(Actor004)
PlayActionDirect(Actor001,"to MS002_054_RideOn01_StartPose")
PlayActionDirect(Actor001,"to MS002_054_RideOn01_Start")
PlayActionDirect(Actor003,"to MS002_054_RaiseHand01LookShoulder_Start")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0013")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★アルハン★★:長期間の潜行には耐えられまい<br>ワタシがともに行く
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0540010")


	--★★アルハン★★:ワタシがともに行くことでなにかしらの<br>不具合があるかもしれぬが
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0540011")

-- ▼直接出力
PlayPartVoiceDirect("アルハン","0033")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アルハン★★:キサマをひとりで行かせるよりは<br>マシだと判断した
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0540012")


	--★★アルハン★★:ティルフィングの未練…<br>どこへ繋がるかはわからぬが、そこへ潜行し──
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0540013")

-- ▼直接出力
PlayActionDirect(Actor003,"to MS002_054_RaiseHand01LookShoulder_End")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0035")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★アルハン★★:
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0540015")

	change_face(Actor002,"Anger")

	--★★フライクーゲル★★:ダーリン！
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540017")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT_13)
Appear(Actor002)
PlayActionDirect(Actor001,"to MS002_054_RideOn01LookLeft_Start")
PlayActionDirect(Actor003,"to MS002_054_RaiseHand01LookLeft_Start")
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,0, 0, -8.984,   1.9)
wait_time(1.9)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アルハン★★:フライクーゲル…
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0540019")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0058")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フライクーゲル★★:アルハン、さっきはごめん…わたし、あの…
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540020")


	--★★アルハン★★:キサマは世界でなく、ひとりの人間を思いやった<br>ワタシにはできぬ。卑下することではない
	Talk(Actor001,"NPCNAME_0313","speech","L","MS_002_0540021")


	--★★フライクーゲル★★:
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540022")

-- ▼直接出力
setup_small_camera_start(CUT_14)
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","MS_002_0540024","MS_002_0540025")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力

on_active(Ef_Over3)
play_particle(Ef_Over3)
wait_time(1.9)
setup_small_camera_start(CUT_15)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0066")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フライクーゲル★★:あっ、えと、ダーリン…！
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540028")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★フライクーゲル★★:わたし、ここにいるから
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540029")

	change_face(Actor002,"Anger")

	--★★フライクーゲル★★:だから、だから──
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力

on_active(Ef_Over3)
play_particle(Ef_Over3)
wait_time(1.9)
setup_small_camera_start(CUT_15)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0066")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フライクーゲル★★:お泊り会も、そうなんだけど…
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540033")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★フライクーゲル★★:まだしゃべり足りないんだ
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540034")

	change_face(Actor002,"Anger")

	--★★フライクーゲル★★:帰って、くるよね…？
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540035")

	goto Block1end

::Block1end::
	change_face(Actor002,"Anger")

	--★★フライクーゲル★★:
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540037")


	--★★フライクーゲル★★:忘れたりしないよね…！？
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0540038")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_MidFade")
stop_particle(Ef_Over3)
on_active(Ef_Over)
set_scale(Ef_Over, {1.8, 1.8, 1.8})
play_particle(Ef_Over)
on_active(Ef_Over2)
play_particle(Ef_Over2)
Hide(Actor003)
Hide(Actor001)
wait_time(1.0)
setup_small_camera_start(CUT_16)
wait_time(2.0)
shake_camera(CUT_16, 0.72, 3.5)
se_play("SE_ADV_MA_01A111_14_Earthquake")
se_play("SE_LoopSE_Stop")
wait_time(0.8)
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0031")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フライクーゲル★★:
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0541001")

	change_face(Actor002,"Sad")

	--★★フライクーゲル★★:
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0541002")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to  Std_Sad01")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101070001_sp_0001_3")
-- ▲直接出力

	--★★フライクーゲル★★:
	Talk(Actor002,"CHRNAME_FREIKUGEL","speech","L","MS_002_0541003")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv","Ef_C_Cmn_Warp_OUT_ADV",false,true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Cmn_Warp_IN_ADV", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Teleport_Killers", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Area", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White03",false,true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Resonance", false, true)
preload_sound("BGM_ADV_Armoury")
	InitializeLoad_Preload()
	load_area_scene_preload(100021)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101070","001","101070001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName100021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
