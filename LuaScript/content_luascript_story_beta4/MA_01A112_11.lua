-- このluaスクリプトは、MA_01A112_11.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_003)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115034)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	template1()
-- ▼直接出力
change_face(Actor001,"Sad")
Hide(Actor001)
-- ▲直接出力

end

function Play()
	StartPlay()

-- ▼直接出力
EntryWalk(Actor001,Camera001,EntryData110031_01_03,CameraAssetBundleName110031_01,CameraPos110031_01_103)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………良くなったかな、もう会えるかな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A112_110002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")

	--★★ギネヴィア★★:…お礼、できるかな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A112_110003")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115034)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
