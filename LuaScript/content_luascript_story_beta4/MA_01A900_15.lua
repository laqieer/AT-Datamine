-- このluaスクリプトは、MA_01A900_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_002)
	Camera002 = SetTemplate("Actor002",0,CharaPos110011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_003)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
lookat_weight(Actor001,0.6,0.03,0.7,0.3)
keep_delay_ik_lookat(Actor001,Actor002, "J_Head", 0.8)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
set_pos(Actor002,{-0.116, 0, -2.979})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera003)
character_in_move_walk(Actor002,CharaPos110011_04_003,2.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor002, "J_Head", 0.6)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:行こ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_150002")


	--★★ノワール★★:ギネヴィア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_150003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:つきあって、くれるよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A900_150004")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
