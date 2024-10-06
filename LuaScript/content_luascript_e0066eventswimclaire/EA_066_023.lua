-- このluaスクリプトは、EA_066_023.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation09","DuelCommonFormation09_h")
Include("content_adv_advsmall_duelcommonformation09","TemplateDuelCommonFormation09_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation09_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation09,CameraPosDuelCommonFormation09_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation09_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation09,CameraPosDuelCommonFormation09_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation09_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation09,CameraPosDuelCommonFormation09_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation09_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation09,CameraPosDuelCommonFormation09_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation09_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation09,CameraPosDuelCommonFormation09_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation09_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation09,CameraPosDuelCommonFormation09_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation09_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation09,CameraPosDuelCommonFormation09_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation09_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation09,CameraPosDuelCommonFormation09_006)
	Camera009 = SetTemplate("Actor009",nil,CharaPosDuelCommonFormation09_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation09,CameraPosDuelCommonFormation09_002)
	InitializeTemplateRandomCameraDuelCommonFormation09()
	InitializeTemplateDuelCommonFormation09()
-- ▼直接出力
Hide(Actor007)
Hide(Actor008)
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Squareoff_Loop")
PlayActionDirect(Actor002,"to Std_Squareoff_Loop")
PlayActionDirect(Actor004,"to Std_Squareoff_Loop")
PlayActionDirect(Actor005,"to Std_Squareoff_Loop")
PlayActionDirect(Actor006,"to Std_Squareoff_Loop")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","003","101025003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401039","001","401039001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101025","003","101025003","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力

	--★★ローマ兵A★★:クッ…撤収！撤収だ！
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0230001")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor004,"to Run")
turn_chara(Actor004,50,0.4)
PlayActionDirect(Actor005,"to Run")
turn_chara(Actor005,50,0.4)
PlayActionDirect(Actor006,"to Run")
turn_chara(Actor006,50,0.4)
wait_time(0.4)
slidemove(Actor004,{4.0, 0, 8.13}, 1.5)
slidemove(Actor005,{4.6, 0, 7.38}, 1.5)
slidemove(Actor006,{3.5, 0, 8.84}, 1.5)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

Hide(Actor001)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Appear(Actor007)
Appear(Actor008)
Appear(Actor009)

wait_time(2.0)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")

	--★★ヴォールス2★★:大丈夫か？
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0230003")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)

	--★★男性B2★★:あんたたち、さっきの――<br>…ありがとう、助かったよ
	Talk(Actor009,"NPCNAME_0179","speech","N","EA_066_0230004")

-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	open_select_window_tag(Actor007,"Normal","EA_066_0230006","EA_066_0230007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor007,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0054")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ヴォールス2★★:
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0230010")

	play_head_motion(Actor009, "No", 0.3, 1.0, false)

	--★★男性B2★★:わ、わからない…
	Talk(Actor009,"NPCNAME_0179","speech","N","EA_066_0230011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor009,"to  Std_Talk")

	--★★男性B2★★:いきなり取り囲まれて<br>とにかく知っていることを話せと言われたんだ
	Talk(Actor009,"NPCNAME_0179","speech","N","EA_066_0230012")

-- ▼直接出力
PlayPartVoiceDirect("市民_男2","0025")
-- ▲直接出力

	--★★男性B2★★:わけがわからないよ
	Talk(Actor009,"NPCNAME_0179","speech","N","EA_066_0230013")

	PlayAction(Actor008,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0034")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★クレア2★★:…よほど必死みたいね
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0230014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor007,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ヴォールス2★★:
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0230017")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Normal")

	--★★クレア2★★:あの兵装はローマのものね<br>ずいぶんくたびれてはいたけど
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0230018")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0059")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★クレア2★★:恐らく本国の方針に反対している<br>ルーシャス派の残党じゃないかしら
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0230019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア","0034")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★クレア2★★:でも、いったいなにがしたいのかしら
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0230020")

	goto Block1end

::Block1end::
	change_face(Actor008,"Normal")

	--★★クレア2★★:逃げた兵士たちは港へ向かったわ
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0230022")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0062")
-- ▲直接出力
	change_face(Actor008,"Anger")

	--★★クレア2★★:…どうやら、事件の匂いね
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0230023")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ヴォールス2★★:ああ。奴らの動きを探る必要があるな
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0230024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor008, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0033")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★クレア2★★:水遊びはまた今度誘うわ
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0230025")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0025")
-- ▲直接出力

	--★★ヴォールス2★★:…そうしてくれ
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0230026")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Reconnaissance")
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","003","101025003","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401039","001","401039001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101025","003","101025003","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation09)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
