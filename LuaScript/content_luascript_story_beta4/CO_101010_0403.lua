-- このluaスクリプトは、CO_101010_0403.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("201002","001","201002001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201003","001","201003001","content_animationpack__common","FacialPack","Actor005")
	template1()
-- ▼直接出力
set_battlecontroller(Actor001,"fig_swd","AC_TL_Fig_Swd_Idle_Run","ToIdle")
-- ▲直接出力
-- ▼直接出力
set_battlecontroller(Actor002,"fig_swd","AC_TL_Fig_Swd_Idle_Run","ToIdle")
-- ▲直接出力
-- ▼直接出力
sword001 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
-- ▲直接出力
-- ▼直接出力
sword001_offset  = {-0.015,0.001,-0.001,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(sword001,Actor001, "Loc_weapon_constrint_R", sword001_offset)
-- ▲直接出力
-- ▼直接出力
sword002 = set_object("content_model_weapon_01_swd_wpn_01_swd_022", "Wpn_01_swd_022", true)
-- ▲直接出力
-- ▼直接出力
sword002_offset  = {0,-0.0119,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(sword002,Actor002, "Loc_weapon_constrint_R", sword002_offset)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"ToIdle")
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"ToIdle")
-- ▲直接出力

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力

	--★★ランスロット★★:今日の補習だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04030002")


	--★★ランスロット★★:俺の授業が必要ないと言うなら<br>俺より多くバルバロイを倒してみろ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:望むところだ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04030004")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ4_4")
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
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("201002","001","201002001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201003","001","201003001","content_animationpack__common","FacialPack","Actor005")
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
sword001_offset  = {-0.015,0.001,-0.001,0,0,0}
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_022", "Wpn_01_swd_022", true)
sword002_offset  = {0,-0.0119,0,0,0,0}
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
