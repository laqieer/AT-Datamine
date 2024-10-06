-- このluaスクリプトは、BASE_AC_01_WORK_A.xlsm の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advinst_110151_01","110151_01_h")
Include("content_adv_advinst_110151_01","Template110151_01_h")

function Load()

	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)

--	Template_Load()
	Direct_Load()

end

function Play()
	StartPlay()

--	Template_Play()
	Direct_Play()

	EndPlay()
end

-- ------------------------------------------------------------------------------------------------

function Template_Load()

	Actor001 = InitializeCharacter("101009","002","101009002",CharaPos001,"101009002","Com_m_SitController","to Sit01_Loop")
	Actor002 = InitializeCharacter("101009","002","101009002",CharaPos004,"101009002","Com_m_SitController","to Sit01_Loop")
	Actor003 = InitializeCharacter("101009","002","101009002",CharaPos005,"101009002","Com_m_SitController","to Sit01_Loop")
	Actor004 = InitializeCharacter("101009","002","101009002",CharaPos006,"101009002","Com_m_SitController","to Sit01_Loop")
	InitializeCharaCamera(CameraAssetBundleName,CameraPos001,Actor001)
	InitializeTemplateRandomCamera()
	InitializeTemplate()

end

function Template_Play()

	Talk(Actor001,"","mind","L","TRUST_RELEASE_TITLE")

end

-- ------------------------------------------------------------------------------------------------

function Direct_Load()

	setup_101009_Noir({6.104, 3.75, -25.452,   41}, "Com_Std_DogCare_Loop_Chr_002_01", 0, true, "content_animationpack_201_201noir", "MotionPack_201NoirWork")
--	MobM = setup_MOB01_CitizenM({1.1, 0, 2.809,   270}, "Mob_Std_Arguing_Loop_m", 2, "content_animationpack_201_201noir", "MotionPack_201NoirWork")
--	MobF = setup_MOB01_CitizenF({-0.026, 0, 2.809,   90}, "Mob_Std_Arguing_Loop_f", 2, "content_animationpack_201_201noir", "MotionPack_201NoirWork")

	Dog1 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", {6.227, 3.75, -24.937,   126}, "Dog_Care_loop", "Normal")
	Dog2 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", {6.522, 3.75, -25.375,   198}, "Dog_Sleep_loop", "Normal")
	Dog3 = set_chara("content_chr_402001_402001001_model", "402001001_Model", "content_animationpack_201_201dog", "MotionPack_201Dog", "content_animationpack__common", "FacialPack", {5.188, 3.75, -24.938,   94.99999}, "Dog_Tailwag_loop", "Normal")

--	Hammer = set_object("content_prop_10105001", "10105001_PropModel", true)
--	on_parent(Hammer, Noir, "Loc_weapon_constrint_R", 0,0,0, 0,180,0)

	MAIN_CAMERA = set_camera(8.8237, 3.79165, -23.41712,   351.0505, 236.5748, 0,   26.99147)
	on_camera(MAIN_CAMERA)

end

function Direct_Play()

	open_narration_window()
		message_direct("★★★★★表示テスト開始")
		message_direct("表示テスト終了★★★★★")
	close_narration_window()

end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110151)
end
