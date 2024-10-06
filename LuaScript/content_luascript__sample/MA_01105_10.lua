-- このluaスクリプトは、MA_01105_10.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("101009001",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("101011001",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera003 = SetTemplate("101016001",nil,CharaPos112021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_004)
	Camera004 = SetTemplate("101051002",nil,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	Camera005 = SetTemplate("101052001",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera006 = SetTemplate("101037001",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera007 = SetTemplate("",nil,CharaPos112021_01_,"content_motion3d_advarea_common_adv_templatecontroller","","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("101009001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("101011001",nil,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	Camera003 = SetTemplate("101016001",nil,CharaPos112021_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_005)
	Camera004 = SetTemplate("101051002",nil,CharaPos112021_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_008)
	Camera005 = SetTemplate("101052001",nil,CharaPos112021_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_007)
	Camera006 = SetTemplate("101037001",nil,CharaPos112021_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_006)
	Camera007 = SetTemplate("",nil,CharaPos112021_03_,"content_motion3d_advarea_common_adv_templatecontroller","","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack")
	Actor004 = InitializeCharacter_3D("101051","002","101051002","content_animationpack__common","FacialPack")
	Actor005 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack")
	Actor006 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
Hide(Actor003)

-- ▲直接出力
-- ▼直接出力
Hide(Actor004)

-- ▲直接出力
-- ▼直接出力
Hide(Actor005)

-- ▲直接出力
-- ▼直接出力
Hide(Actor006)

-- ▲直接出力
-- ▼直接出力
Hide(Actor003)

-- ▲直接出力
-- ▼直接出力
Hide(Actor004)

-- ▲直接出力
-- ▼直接出力
Hide(Actor005)

-- ▲直接出力
-- ▼直接出力
Hide(Actor006)

-- ▲直接出力
end

function Play()
	StartPlay()

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ヤケよ、ヤケ買いよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100002")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
template2()

on_camera(RndCamera011)
--フェードイン
fadein(CHARA_IN_OUT)
 --on_camera(RndCamera009)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor002,"Sad")


	--★★ギネヴィア★★:…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_100072")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★皇帝ルーシャス★★:なるほど。そなたが彼女の飾りか
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01105_100073")

	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Smile")

	--★★皇帝ルーシャス★★:苦労するだろう。わかるよ<br>クッククク…
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01105_100075")


	--★★皇帝ルーシャス★★:そなたとは<br>良いトモダチになれそうだ
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01105_100076")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack")
	InitializeCharacter_3D_Preload("101051","002","101051002","content_animationpack__common","FacialPack")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
