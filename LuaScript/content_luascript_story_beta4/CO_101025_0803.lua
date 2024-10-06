-- このluaスクリプトは、CO_101025_0803.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1002_01_Controller","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
lookoj=create_object("kara")
set_pos_object(lookoj,-1.8,0.5,0)
keep_ik_lookat(Actor001, lookoj, "")
keep_ik_lookat(Actor002, lookoj, "")
keep_ik_lookat(Actor003, lookoj, "")
lookat_weight(Actor001,0.5,0.03,0.4,0)
lookat_weight(Actor002,0.6,0.03,0.4,0)
lookat_weight(Actor003,0.6,0.03,0.4,0)

-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("402001","001","402001001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:スコーン<br>このにおいのする場所に連れて行ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08030002")

-- ▼直接出力
PlayActionDirect(Actor004,"to Tailwag")
se_play("SE_ADV_CO_101025_0803_Dog_Barks")
-- ▲直接出力

	--★★犬★★:ワン！ワン！
	Talk(Actor004,"NPCNAME_0245","speech","N","CO_101025_08030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor004,"to idle01_Loop")
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:「答えが近づいて来たら走れ」<br>だったな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08030005")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera008)
PlayActionDirect(Actor004,"to Run")
turn(Actor004,0,-117,0,0.5)
slidemove(Actor004,{-19.6,0,-9.1},5)
wait_time(0.2)
lookat_delay_weight_reset(Actor002,1)
PlayActionDirect(Actor002,"to Run")
turn(Actor002,0,-121,0,0.5)
slidemove(Actor002,{-18.1,0,-8.8},5)
wait_time(0.5)
lookat_delay_weight_reset(Actor003,1)
PlayActionDirect(Actor003,"to Run")
turn(Actor003,0,-125,0,0.5)
slidemove(Actor003,{-17.7,0,-9.2},5)
wait_time(0.5)
lookat_delay_weight_reset(Actor001,1)
PlayActionDirect(Actor001,"to Run")
turn(Actor001,0,-125,0,0.5)
slidemove(Actor001,{-18.9,0,-8.3},5)
wait_time(3)
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ8_4")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("402001","001","402001001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
