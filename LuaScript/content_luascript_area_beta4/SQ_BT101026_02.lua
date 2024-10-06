Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111061_02","111061_02_h")
Include("content_adv_advsmall_111061_02","Template111061_02_h")

function template1()
  ResetCharaCamera()
  ResetRandomCamera()
  Camera001 = SetTemplate("Actor001",-90,CharaPos111061_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111061_02,CameraPos111061_02_005)
  Camera002 = SetTemplate("Actor002",nil,CharaPos111061_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111061_02,CameraPos111061_02_003)
  InitializeTemplateRandomCamera111061_02()
  InitializeTemplate111061_02()
end

function Load()
  InitializeLoad()
  manager = CreateAdvSmallManager()
  load_area_scene(111061)
  Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
  Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
  template1()

end

function Play()
  StartPlay()

  Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","SQ_BT101026_020001")
  Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","SQ_BT101026_020002")
  Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","SQ_BT101026_020003")

  open_subquest_window_complete()

  EndPlay()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  InitializeLoad_Preload()
  load_area_scene_preload(111061)
  InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
  InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName111061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
