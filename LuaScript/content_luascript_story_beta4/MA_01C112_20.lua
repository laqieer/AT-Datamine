-- このluaスクリプトは、MA_01C112_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation04","DuelCommonFormation04_h")
Include("content_adv_advsmall_duelcommonformation04","TemplateDuelCommonFormation04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation04_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_013)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_005)
	InitializeTemplateRandomCameraDuelCommonFormation04()
	InitializeTemplateDuelCommonFormation04()
-- ▼直接出力
pr_001= setup_prop_object(10130007)
set_pos(pr_001,{0.417, 0, -1.025})
set_rot(pr_001,{0, -134.9, 0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_common_look_at(Actor001,Actor003)
set_common_look_at(Actor002,Actor003)
set_common_look_at(Actor005,Actor001)
set_common_look_at(Actor004,Actor001)
Hide(Actor006)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Ef_0001     = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
set_pos(Ef_0001,{-0.66,0,1.22})
set_scale(Ef_0001,{1.1,1.1,1.1})
-- ▲直接出力
-- ▼直接出力
Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
set_pos(Ef_0002,{-0.74,0,1.41})
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-0.558, 1.85, -5.86,   8.32, 10.02, 0,   28})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101200011)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","003","101015003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","002","101013002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","002","101018002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ランスロット★★:…俺たちにそれを命じるのか
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C112_200002")

	PlayAction(Actor003,"to  Std_Talk")

	--★★アーサー★★:命じているわけじゃない<br>お願いしてるんだよ。友人として
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200003")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Anger")

	--★★ランスロット★★:…だが…！
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C112_200004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:そんなこと…わたしたちにできるの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C112_200005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:だから俺は破壊したんだ、学園を
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200006")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ランスロット★★:ほかの友を裏切ることになる
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C112_200007")


	--★★アーサー★★:世界のためだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200008")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ギネヴィア★★:………世界――…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C112_200009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Serious")

	--★★アーサー★★:俺たちはこの世界を支配している<br>なにかから解放されねばならない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:犠牲はつきものってこと？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C112_200012")

	PlayAction(Actor003,"to  Std_Talk")

	--★★アーサー★★:王と最強騎士は犠牲の上に<br>世界を救わねばならない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200013")


	--★★アーサー★★:それが本当の伝説だ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200014")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")

	--★★アーサー★★:魔女も妖精も聖杯もいらない<br>不確かな伝説よりも信じるべきものがある
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200016")


	--★★アーサー★★:例えば、俺とお前の友情とか
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")

	--★★アーサー★★:それから――大切な家族と共に過ごした日々
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200019")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ランスロット★★:…俺は――…
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C112_200021")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★アーサー★★:さあまた役者がそろったようだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200023")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(true)
Hide(Actor001)
Hide(Actor002)
Hide(Actor004)
Hide(Actor005)
Hide(Actor003)
off_active(pr_001)
EntryWalk_2P(Actor006,Camera006,EntryDataDuelCommonFormation04_06,CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_106,Actor007,CharaPosDuelCommonFormation04_005,CharaPosDuelCommonFormation04_105) 
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
Hide(Actor007)
Appear(Actor001)
Appear(Actor002)
Appear(Actor004)
Appear(Actor005)
Appear(Actor003)
on_active(pr_001)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…ノワール！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C112_200024")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,-0.51,1.82,-5.63,10)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_0002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
PlayActionDirect(Actor001,"to  Std_Surp")
--PlayActionDirect(Actor002,"to  Std_Surp")
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:お前たちにはいったん<br>消えていてもらおう
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200025")

-- ▼直接出力
CloseTalkWindow()
on_active(Ef_0001)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
Hide(Actor002)
Hide(Actor001)
off_active(Ef_0002)
-- ▲直接出力
-- ▼直接出力
wait_time(2.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★アーサー★★:舞台袖から見ていてくれよ<br>古き伝説が壊れる様を?
	Talk(Actor003,"CHRNAME_ARTHUR","speech","R","MA_01C112_200026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130007)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	InitializeLoad_Preload()
	load_duel_scene_preload(101200011)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","003","101015003","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","002","101013002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","002","101018002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
