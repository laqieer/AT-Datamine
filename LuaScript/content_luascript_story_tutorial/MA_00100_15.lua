-- このluaスクリプトは、MA_00100_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100011_01","100011_01_h")
Include("content_adv_advsmall_100011_01","Template100011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_MA00100_15_Controller","to Std_Loop",CameraAssetBundleName100011_01,CameraPos100011_01_002)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPos100011_01_001,CameraAssetBundleName100011_01,CameraPos100011_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos100011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_009_01_StdController","to Std_Loop",CameraAssetBundleName100011_01,CameraPos100011_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos100011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_509_01_StdController","to Std_Loop",CameraAssetBundleName100011_01,CameraPos100011_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos100011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_009_02_StdController","to Std_Loop",CameraAssetBundleName100011_01,CameraPos100011_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos100011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_509_02_StdController","to Std_Loop",CameraAssetBundleName100011_01,CameraPos100011_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos100011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_009_01_StdController","to Std_Loop",CameraAssetBundleName100011_01,CameraPos100011_01_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPos100011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_509_02_StdController","to Std_Loop",CameraAssetBundleName100011_01,CameraPos100011_01_006)
	InitializeTemplateRandomCamera100011_01()
	InitializeTemplate100011_01()
-- ▼直接出力
ShowGlobalMenuButton(false)
CUT_01 = cat_template_camera("P10_Cam")
CUT_02 = cat_template_camera("P11_Cam")
CUT_03 = cat_template_camera("P12_Cam")
CUT_04 = cat_template_camera("P13_Cam")
CUT_05 = cat_template_camera("P14_Cam")
CUT_06 = cat_template_camera("P15_Cam")
-- ▲直接出力
-- ▼直接出力
RndCamera001 =  CUT_01
-- ▲直接出力
-- ▼直接出力
Chair_01 = get_object("geo_chair_26")
set_pos(Chair_01, {2.7, 0.0, -2.68})
set_rot(Chair_01, {0, 0, 0})
-- ▲直接出力
-- ▼直接出力
Chair_02 = get_object("geo_chair_31")
set_pos(Chair_02, {4.32, 0.0, -3.8})
set_rot(Chair_02, {0.0, -30.32, 0.0})
-- ▲直接出力
-- ▼直接出力
door = get_object("geo_door_R_01")
set_pos(door, {7.27, 1.227, -5.4,   0})
set_rot(door, {0.0, 0, 0.0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
heroId = GetPlayerStyleId()
if heroId == 101003001 or heroId == 101005001 or heroId == 101007001 then
	set_animationcontroller(Actor002,"Chr_000_01_MA00100_15_Controller", "to Sit01_Loop")
else
	set_animationcontroller(Actor002,"Chr_500_01_MA00100_15_Controller", "to Sit01_Loop")
end
debug_print(heroId)
-- ▲直接出力
-- ▼直接出力
force_eyesync(Actor002,"Close")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{CharaPos007[1],CharaPos007[2],CharaPos007[3]})
set_rot(Actor007,{0,CharaPos007[4],0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{CharaPos008[1],CharaPos008[2],CharaPos008[3]})
set_rot(Actor008,{0,CharaPos008[4],0})
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
PlayActionDirect(Actor003,"to  Std_Worry")
PlayActionDirect(Actor006,"to  Std_Sad01")
PlayActionDirect(Actor008,"to  Std_Angry")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100011)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	Actor003 = InitializeCharacter_3D("401001","001","401001001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401002","001","401002001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401003","001","401003001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401004","001","401004001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401001","001","401001001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401004","001","401004001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(3.5)
setup_small_camera_start(CUT_02)
-- ▲直接出力

	--★★テロップ★★:『バルバロイによる被害、拡大』
	Talk(Actor009,"telop","simple","L","MA_00100_150002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
change_face(Actor002,"Sad")
force_eyesync(Actor002,"Auto")
wait_time(0.3)
PlayActionDirect(Actor002,"to_LookBangle")
wait_time(0.6)
-- ▲直接出力

	--★★テロップ★★:『〇日8時頃<br>×××市上空に<ruby=ひずみ>歪</ruby>が発生』
	Talk(Actor009,"telop","simple","L","MA_00100_150004")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_03)
wait_time(0.3)
-- ▲直接出力

	--★★テロップ★★:『バルバロイ３体が出現し<br>出勤途中のサラリーマンなどを襲った』
	Talk(Actor009,"telop","simple","L","MA_00100_150006")


	--★★テロップ★★:『政府が派遣したキラーズ部隊により<br>30分後にはバルバロイは撃退されたが』
	Talk(Actor009,"telop","simple","L","MA_00100_150008")


	--★★テロップ★★:『大人７人が負傷<br>うち２人は<dot>記憶</dot>不明の重体となっている』
	Talk(Actor009,"telop","simple","L","MA_00100_150010")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
change_face(Actor002,"Normal")
PlayActionDirect(Actor002,"to_LookArhan")
wait_time(2.4)
change_face(Actor002,"Surprise")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to_Sit")
setup_small_camera_start(CUT_04)
wait_time(4.0)
PlayActionDirect(Actor001,"Yawn")
setup_small_camera_start(CUT_05)
wait_time(2.5)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アルハン_1★★:ファァァ…
	Talk(Actor001,"NPCNAME_0312","simple","L","MA_00100_150012")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
PlayActionDirect(Actor001,"WalkAway")
setup_small_camera_start(CUT_06)
wait_time(5.2)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
heroId = GetPlayerStyleId()
if heroId == 101003001 or heroId == 101005001 or heroId == 101007001 then
else
end
	InitializeLoad_Preload()
	load_area_scene_preload(100011)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401001","001","401001001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401002","001","401002001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401003","001","401003001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401004","001","401004001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401001","001","401001001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401004","001","401004001","content_animationpack__common","FacialPack","Actor008")
	system.PreLoadRequest(CameraAssetBundleName100011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
