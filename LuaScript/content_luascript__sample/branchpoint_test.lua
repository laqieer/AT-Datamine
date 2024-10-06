Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")


function Load()
	InitializeLoad()

	manager = CreateAdvSmallManager()
	load_area_scene(110071)

	Actor001 = InitializeCharacter("101009","001","101009001",CharaPos001,"101009001","Chr_002_01_StdController","to Std_Loop")
	Actor002 = InitializeCharacter("101010","001","101010001",CharaPos005,"101010001","Chr_001_01_StdController","to Std_Loop")
	Actor003 = InitializeCharacter("101026","001","101026001",CharaPos007,"101026001","Chr_008_01_StdController","to Std_Loop")
	Actor004 = InitializeCharacter("101024","001","101024001",CharaPos003,"101024001","Chr_010_01_StdController","to Std_Loop")
	Actor005 = InitializeCharacter("101025","001","101025001",CharaPos008,"101025001","Chr_515_01_StdController","to Std_Loop")
	InitializeCharaCamera(CameraAssetBundleName,CameraPos001,Actor001)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos005,Actor002)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos007,Actor003)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos003,Actor004)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos008,Actor005)
	InitializeTemplateRandomCamera()
	InitializeTemplate()
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Std_Joy")

	Talk(Actor001,"CHRNAME_NOIR","speech","R","分岐ポイントてすとです")

	Talk(Actor001,"CHRNAME_NOIR","speech","R","1人出て1ポイント")

	Talk(Actor001,"CHRNAME_NOIR","speech","R","4人出て2ポイント")

	Talk(Actor001,"CHRNAME_NOIR","speech","R","5人出て4ポイント")

	Talk(Actor001,"CHRNAME_NOIR","speech","R","どうだったでしょう")

	EndPlay()

end

function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_Preload("101009","001","101009001",CharaPos001,"101009001","Chr_002_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101010","001","101010001",CharaPos005,"101010001","Chr_001_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101026","001","101026001",CharaPos007,"101026001","Chr_008_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101024","001","101024001",CharaPos003,"101024001","Chr_010_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101025","001","101025001",CharaPos008,"101025001","Chr_515_01_StdController","to Std_Loop")
	system.PreLoadRequest(CameraAssetBundleName)
end
