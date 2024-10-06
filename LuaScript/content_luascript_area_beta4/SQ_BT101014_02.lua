Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")

function template1()
  ResetCharaCamera()
  ResetRandomCamera()
  Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
  Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
  InitializeTemplateRandomCameraDuelCommonFormation01()
  InitializeTemplateDuelCommonFormation01()
end

function Load()
  InitializeLoad()
  manager = CreateAdvSmallManager()
  load_duel_scene(101000011)
  Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
  Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
  template1()

end

function Play()
  StartPlay()

  Talk(Actor002,"CHRNAME_TRISTAN","speech","L","SQ_BT101014_020001")
  Talk(Actor002,"CHRNAME_TRISTAN","speech","L","SQ_BT101014_020002")
  Talk(Actor002,"CHRNAME_TRISTAN","speech","L","SQ_BT101014_020003")

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
  load_duel_scene_preload(101000011)
  InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
  InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
