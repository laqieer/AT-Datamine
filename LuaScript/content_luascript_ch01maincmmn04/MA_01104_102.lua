-- このluaスクリプトは、MA_01104_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-107.2,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera003 = SetTemplate("Actor003",77,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	Camera004 = SetTemplate("Actor004",-167.9,CharaPos110011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_002)
	Camera005 = SetTemplate("Actor005",276.7,CharaPos110011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_002)
	Camera006 = SetTemplate("Actor006",-52.65,CharaPos110011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_002)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
 -- キャラ配置
Hide(Actor002)
Hide(Actor003)
Hide(Actor005)
CUT_1 = set_camera({2.46146,1.39406,-1.44904,3.094,223.978,0,22})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002, {1.645,0,-5.2})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-2.338,0,-2.964})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-0.06, 0, 0.5})
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{1.06, 0, -3.1})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{0.1, 0, -0.13})
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,{-1.46,0,-2.8,2.3})
wait_time(2.3)
PlayActionDirect(Actor005,"to Std_Loop")
Hide(Actor005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィア。助かるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1020003")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1020005")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor002,Camera002,EntryData110011_01_06,CameraAssetBundleName110011_01,CameraPos110011_01_106)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:ギネヴィア。助かるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1020006")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
lookat_delay_weight_reset(Actor002,0.8)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-67.7,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力

	--★★ギネヴィア★★:委員長！<br>次の授業はなんだっけ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1020008")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.7)
se_play("SE_ADV_MA_01B112_12_Door_Open")
-- ▲直接出力
-- ▼直接出力
wait_time(1.1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003,0.889,0,-2.964,2.6)
-- ▲直接出力
-- ▼直接出力
wait_time(2.6)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ウレリー★★:ランスロット先生の演習ですよ、殿下
	Talk(Actor003,"CHRNAME_URRIE","speech","L","MA_01104_1020010")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:聞いてのとーりよ！いこいこっ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1020011")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-116.5,0.3)
wait_time(0.3)
slidemove(Actor002,{-3.4, 0, -5.77}, 3.0)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:委員長…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1020013")

-- ▼直接出力
setup_small_camera_start(CUT_1)
-- ▲直接出力
	PlayAction(Actor003,"to Bow")

	--★★ウレリー★★:貴方の失態は我が学級<br>『<ruby=ヴァンデル・ピーク>遥か望む剣</ruby>』の沽券に関わる
	Talk(Actor003,"CHRNAME_URRIE","speech","L","MA_01104_1020014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ウレリー★★:だから期待してるよ<br>ノワールくん
	Talk(Actor003,"CHRNAME_URRIE","speech","L","MA_01104_1020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ウレリー★★:貴方の失態は我が学級<br>『<ruby=ヴァンデル・ピーク>遥か望む剣</ruby>』の沽券に関わる
	Talk(Actor003,"CHRNAME_URRIE","speech","L","MA_01104_1020016")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ウレリー★★:まあ、次の授業で<br>その心配はないだろうけど
	Talk(Actor003,"CHRNAME_URRIE","speech","L","MA_01104_1020018")


	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1020019")

-- ▼直接出力
setup_small_camera_start(CUT_1)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ウレリー★★:実戦形式の演習だよ。傭兵団長
	Talk(Actor003,"CHRNAME_URRIE","speech","L","MA_01104_1020021")

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
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
