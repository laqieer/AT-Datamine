-- このluaスクリプトは、MA_01A900_23.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111061_01","111061_01_h")
Include("content_adv_advsmall_111061_01","Template111061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111061_01,CameraPos111061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111061_01,CameraPos111061_01_005)
	InitializeTemplateRandomCamera111061_01()
	InitializeTemplate111061_01()
-- ▼直接出力
load_image("MA01A9002301", "content_still_10103011_image", "101030110_StillImage")
-- ▲直接出力
-- ▼直接出力
kisspoint = {0.842, 0, 0.191,   129.6688}
-- ▲直接出力
-- ▼直接出力
kisspointstart = {0.65, 0, 0.35,   129.6688}
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002,100)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111061)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
lookat_delay_weight(Actor002,0.8, 0.05, 0.6, 0.5,0.8)
keep_ik_lookat(Actor002,Actor001, "J_Head")
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
turn_lookat_position(Actor001,kisspointstart[1],kisspointstart[2]+1.6,kisspointstart[3],0)
character_in_move_walk(Actor002,kisspointstart,0.6)
wait_time(0.6)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
slidemove(Actor002,kisspoint[1],kisspoint[2],kisspoint[3],0.7)
change_face(Actor001,"Surprise")
wait_time(0.2)
set_lookat_offset(Actor002,0,0.25,0)
PlayActionDirect(Actor002,"to  Std_Surp")
wait_time(0.2)
fadeout(0.0, 0.0, 0.0, 1.0, 0.3)
wait_time(0.3 + BLACK_WHITE_WAIT_TIME)
show_image("MA01A9002301", 0.0, 0.0, 0,true,false)
wait_time(2.0)
fadein(BLACK_WHITE_WAIT_TIME)
wait_time(1.5 + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:さよなら、しよ？
	Talk(Actor002,"CHRNAME_GUINEVERE2","simple","L","MA_01A900_230010")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA01A9002301", "content_still_10103011_image", "101030110_StillImage")
kisspoint = {0.842, 0, 0.191,   129.6688}
kisspointstart = {0.65, 0, 0.35,   129.6688}
	InitializeLoad_Preload()
	load_area_scene_preload(111061)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName111061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
