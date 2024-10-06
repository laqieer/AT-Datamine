-- このluaスクリプトは、AK_01_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100021_01","100021_01_h")
Include("content_adv_advsmall_100021_01","Template100021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1001_01_Controller","to Std_Loop",CameraAssetBundleName100021_01,CameraPos100021_01_005)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPos100021_01_001,CameraAssetBundleName100021_01,CameraPos100021_01_001)
	InitializeTemplateRandomCamera100021_01()
	InitializeTemplate100021_01()
-- ▼直接出力
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
initialize_MA0010023(heroIdshort)
set_enable_auto_lookat_all(false)
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
set_pos(Actor002, {0, 0, -24.41})
Camera_EX =set_camera({0, 1.25, -15.5,   0, 0, 0,   27.83262})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100021)
	Actor001 = InitializeCharacter_3D("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{0, 0, -16.579},3.0)
wait_time(1.2)
setup_small_camera_start(RndCamera005)
wait_time(1.8)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.6)
setup_small_camera_start(Camera_EX)
wait_time(0.4)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アルハン★★:見事だ<br>予想通り…いや、予想以上の強さだな
	Talk(Actor001,"NPCNAME_0313","speech","L","AK_01_0020002")

	change_face(Actor001,"Normal")

	--★★アルハン★★:だが、慢心するな<br>実戦経験は積むに越したことはない
	Talk(Actor001,"NPCNAME_0313","speech","L","AK_01_0020003")

-- ▼直接出力
setup_small_camera_end(Camera_EX)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アルハン","0048")
-- ▲直接出力

	--★★アルハン★★:引き続き、頑張ってくれ
	Talk(Actor001,"NPCNAME_0313","speech","L","AK_01_0020004")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
	InitializeLoad_Preload()
	load_area_scene_preload(100021)
	InitializeCharacter_3D_Preload("101059","001","101059001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName100021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
