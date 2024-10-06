-- このluaスクリプトは、EA_053_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",0,CharaPos110111_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_006)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力

	--★★ノワール★★:五月祭か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0110005")


	--★★ノワール★★:言われてみれば街の様子がすっかりお祭りムードな気もするな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0110006")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:祭りなんて傭兵には縁がないものだって思ってたけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0110007")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:せっかくだしちょっと色々見てみるとするか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0110008")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001, 7.35,0,-4.14, 2)
wait_time(1)
PlayActionDirect(Actor001,"to Std_Loop")
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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
