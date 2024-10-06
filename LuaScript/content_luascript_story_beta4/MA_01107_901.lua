-- このluaスクリプトは、MA_01107_901.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",115,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",290,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",315,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101150013)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	template1()
end

function Play()
	StartPlay()


	--★★ノワール★★:その鉱山ってのは<br>どのあたりにあるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_9010002")


	--★★ギネヴィア★★:キャメリアード城から<br>歩いて半日くらいのところよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_9010003")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:結構遠いんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_9010004")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:転移で行ける場所じゃないし<br>どこかで野営する必要があるわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_9010005")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,340,0.5)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネマウア★★:それならご安心を<br>準備はすでに済ませてあります
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01107_9010006")

	PlayAction(Actor002,"to Finger")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:さっすがお姉ちゃん！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_9010007")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…でも、いつもどおりの軽装じゃない？<br>野営の道具を持っているようには見えないけど…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01107_9010008")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor004,Camera004,EntryDataDuelCommonFormation01_07,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_107)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
turn_lookat(Actor002,Actor004,0)
turn_lookat(Actor003,Actor004,0)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor004,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★トリスタン★★:いつまで喋ってんの？<br>さっさと出発しようよ
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01107_9010009")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、すぐ行くよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01107_9010010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101150013)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
