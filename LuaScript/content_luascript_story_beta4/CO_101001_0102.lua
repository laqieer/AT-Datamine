-- このluaスクリプトは、CO_101001_0102.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_002)
	Camera002 = SetTemplate("Actor002",40,CharaPos110191_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110191_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_008)
	InitializeTemplateRandomCamera110191_02()
	InitializeTemplate110191_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor004,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor004,Actor003,0)
-- ▲直接出力

end

function Play()
	StartPlay()

-- ▼直接出力
 --ティルフィング登場のためカメラを指定
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ひとりで心細いかと思って声かけたけど<br>余計なお世話だったかなぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01020002")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:俺がもうちょっとうまく喋れていたら<br>良かったんだろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01020003")

-- ▼直接出力
Appear(Actor002)
setup_small_camera_start()
PlayActionDirect(Actor003,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01020005")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
setup_small_camera_start(Camera002)
wait_time(1.5)
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ティルフィング…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_01020007")

-- ▼直接出力
local trustParam = set_communication_acquired("ティルフィング_コミュランク", "ティルフィング_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
