-- このluaスクリプトは、EA_003_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",173.853,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera009 = SetTemplate("Actor009",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera010 = SetTemplate("Actor010",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera011 = SetTemplate("Actor011",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera012 = SetTemplate("Actor012",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-1.097,0,8.456})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-1.228,0,-1.136})
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008, {-1.22,0,-0.90})
set_rot(Actor008,{0,-265.7,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor009, {-0.83,0,0.64})
set_rot(Actor009,{0,-218.7,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor010, {-1.57,0,0.10})
set_rot(Actor010,{0,-254.3,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor011, {-1.95,0,-1.60})
set_rot(Actor011,{0,87.2,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor012, {-0.77,0,-2.16})
set_rot(Actor012,{0,-312,0})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Running")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","002","101001002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","002","101018002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101016","002","101016002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor012")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力

	--★★ランスロット★★:ではこれより、実地での訓練に入る各々、対戦相手を選んでくれ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","EA_003_0210002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Appear(Actor002)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
Appear(Actor006)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008, {1.94,0,-4.18})
set_rot(Actor008,{0,-265.7,0})
set_pos(Actor009, {2.45,0,-3.15})
set_rot(Actor009,{0,-218.7,0})
set_pos(Actor010, {3.5,0,-4.2})
set_rot(Actor010,{0,-76,0})
set_pos(Actor011, {-4.11,0,-3.86})
set_rot(Actor011,{0,46.8,0})
set_pos(Actor012, {-3.17,0,-3.11})
set_rot(Actor012,{0,-138.5,0})
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ノワール、俺と組もうぜ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_003_0210004")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:あぁ、いいけど――
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0210005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Run")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor004,{-1.097,0,0.446},1.6)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア", "swim_0017")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ギネヴィア★★:だめー！ノワールはわたしと組むんだから！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","EA_003_0210007")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:え？そうなのか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_003_0210008")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
Appear(Actor007)
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,95,0,0.1)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:いや、聞いてないけど…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0210009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:わ、わたしはあなたを買い上げたんだから！授業だってわたしと組むに決まってるでしょ！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","EA_003_0210010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:そんな無茶苦茶な
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0210011")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ノワール★★:ていうかギネマウアさんはクラスが違わないか？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0210012")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:いいのよ！王妃の特権よ！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","EA_003_0210013")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:そんな横暴な
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0210014")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア", "swim_0021")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:うっ…い、いいじゃないちょっとくらい協力してくれたってぇ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","EA_003_0210015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:えっと…悪い、ガウェイン
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0210017")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:おう、別にいいぜ！またな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_003_0210018")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor004,"J_Head")
keep_ik_lookat(Actor005,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ギネヴィア★★:対戦相手になってくれるのね！…ふふふ、これで準備は整ったわ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","EA_003_0210020")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Normal")

	--★★ノワール★★:準備？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0210021")

-- ▼直接出力
SkipDefaultMotion(Actor004)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Pointing")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_Running")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ギネヴィア★★:さあ、ティルフィング！覚悟なさい！<ruby=マジバト>本気のぶつかり合い</ruby>を始めるわよ！！！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","EA_003_0210023")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Battle_Running")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101001","002","101001002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","002","101018002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101016","002","101016002","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor012")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
