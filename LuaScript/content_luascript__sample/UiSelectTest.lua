-- このluaスクリプトは、MA_01104_07.xlsm の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")

function Load()
	InitializeLoad()

-- サウンド事前設定
	load_sound("VO_kutipaku_test")

	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter("101009","002","101009002",CharaPos005,"101009002","Com_m_SitController","to Sit02_Loop")
	PlayAction(Actor001,"to Sit02_Loop")
	Actor002 = InitializeCharacter("101066","001","101066001",CharaPos017,"101066001","Npc_015_01_StdController","to Std_Loop")
	Actor003 = InitializeCharacter("101013","001","101013001",CharaPos015,"101013001","Chr_003_01_SitController","to Sit02_Loop")
	PlayAction(Actor003,"to Sit02_Loop")
	Actor004 = InitializeCharacter("101018","001","101018001",CharaPos016,"101018001","Com_f_SitController","to Sit02_Loop")
	PlayAction(Actor004,"to Sit02_Loop")
	Actor005 = InitializeCharacter("101011","001","101011001",CharaPos001,"101011001","Com_f_SitController","to Sit02_Loop")
	PlayAction(Actor005,"to Sit02_Loop")
	Actor006 = InitializeCharacter("401005","001","401005001",CharaPos004,"401005001","Com_m_SitController","to Sit02_Loop")
	PlayAction(Actor006,"to Sit02_Loop")
	Actor007 = InitializeCharacter("401006","001","401006001",CharaPos007,"401006001","Com_f_SitController","to Sit02_Loop")
	PlayAction(Actor007,"to Sit02_Loop")
	Actor008 = InitializeCharacter_2DOnly("401007","001","401007001")
	Actor009 = InitializeCharacter_2DOnly("401008","001","401008001")
	Actor010 = InitializeCharacter_2DOnly("401009","001","401009001")
	Actor011 = InitializeCharacter_2DOnly("401005","001","401005001")
	InitializeCharaCamera(CameraAssetBundleName,CameraPos005,Actor001)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos017,Actor002)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos015,Actor003)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos016,Actor004)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos001,Actor005)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos004,Actor006)
	InitializeCharaCamera(CameraAssetBundleName,CameraPos007,Actor007)
	InitializeTemplateRandomCamera()
	InitializeTemplate()
end

function Play()
	StartPlay()
	open_narration_window()
	message_direct("選択肢表示テスト")
	close_narration_window()

	--open_select_window_direct(Actor001,"Normal","<ruby=いち>１</ruby>","２")
	--open_select_window_direct_lock(Actor001,"Normal","１","２","３")
	--open_select_window_direct_lock(Actor001,"Normal","１","２","３","４")
	--open_select_window_direct_lock(Actor001,"Normal","１","２","３","４","５")
	--open_select_window_direct_lock(Actor001,"Normal","１","２","３","４","５","６")
	--open_select_window_direct_lock(Actor001,"Normal","１","２","３","４","５","６","７")
	--open_select_window_direct_lock(Actor001,"Normal","１","２","３","４","５","６","７","８")
	--open_select_window_direct_lock(Actor001,"Normal","１","２","３","４","５","６","７","８","９")
	open_select_window_direct_lock(Actor001,"Normal","１","２","３","４","５","６","７","８","９","１０")

	close_narration_window()
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
	InitializeCharacter_Preload("101009","002","101009002",CharaPos005,"101009002","Com_m_SitController","to Sit02_Loop")
	InitializeCharacter_Preload("101066","001","101066001",CharaPos017,"101066001","Npc_015_01_StdController","to Std_Loop")
	InitializeCharacter_Preload("101013","001","101013001",CharaPos015,"101013001","Chr_003_01_SitController","to Sit02_Loop")
	InitializeCharacter_Preload("101018","001","101018001",CharaPos016,"101018001","Com_f_SitController","to Sit02_Loop")
	InitializeCharacter_Preload("101011","001","101011001",CharaPos001,"101011001","Com_f_SitController","to Sit02_Loop")
	InitializeCharacter_Preload("401005","001","401005001",CharaPos004,"401005001","Com_m_SitController","to Sit02_Loop")
	InitializeCharacter_Preload("401006","001","401006001",CharaPos007,"401006001","Com_f_SitController","to Sit02_Loop")
	InitializeCharacter_2DOnly_Preload("401007","001","401007001")
	InitializeCharacter_2DOnly_Preload("401008","001","401008001")
	InitializeCharacter_2DOnly_Preload("401009","001","401009001")
	InitializeCharacter_2DOnly_Preload("401005","001","401005001")
	system.PreLoadRequest(CameraAssetBundleName)
end
