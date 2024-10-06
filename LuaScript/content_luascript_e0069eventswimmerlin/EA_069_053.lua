-- このluaスクリプトは、EA_069_053.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-83,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",-86,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",-80,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera005 = SetTemplate("Actor005",184,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor005)
Hide(Actor006)
set_pos(Actor005,{-16.42,0.0,4,63})
set_pos(Actor006,{-19.14,0.0,9.1})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","002","101016002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","005","101020005","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0055")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:勝った…？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0530002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0007")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:ああ。この場のバルバロイはすべて倒し切った<br>ふたりのおかげだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0530003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
Appear(Actor005)
PlayActionDirect(Actor005,"to Run")
slidemove(Actor005,{-17.12, 0.0,-5.43},2.0)
wait_time(2.0)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.5)
Appear(Actor006)
PlayActionDirect(Actor006,"to Run")
slidemove(Actor006,{-17.25,0.0,-1.62},2.0)
PlayActionDirect(Actor005,"to Run")
turn_chara(Actor005,357,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(1.6)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor005,"to std01yell02")
wait_time(0.8)
PlayActionDirect(Actor006,"to std01yell02")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:これで棲み処を奪われた動物たちにも<br>きっと平穏が戻るだろう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0530005")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ギネマウア★★:…！！
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","EA_069_0530006")

-- ▼直接出力
setup_small_camera_start()
turn_chara(Actor003,9.0,0.6)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:やりましたね、殿下
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","EA_069_0530007")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor002,-4,0.4)
turn_chara(Actor004,70,0.6)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:…ねえ、お姉ちゃん
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0530008")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0057")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:なに？
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","EA_069_0530009")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:いつか…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0530010")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:いつか、わたしたちもこんなふうに<br>故郷を取り戻せるかな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0530011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0008")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネマウア★★:…ええ<br>あなたが前を向いていれば、きっと
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","EA_069_0530012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:…うん
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0530013")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("マーリン_005","0012")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マーリン★★:幼い頃から深い絆で結ばれた番が<br>GSを果たしたときの力がこれほどとは
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0530014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン_005","0010")
-- ▲直接出力

	--★★マーリン★★:…GSの力は絆の力<br>改めて思い知らされましたね
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0530015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0034")
-- ▲直接出力
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:居残りまでして頑張っても駄目だったのに<br>夏休みになってできちゃうとか
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0530016")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:気晴らしの成果ってやつじゃないか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0530017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…そうかも
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0530018")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0048")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:よーし！夏休みが明けたら、GSして<br>一皮むけたわたしを皆にお披露目するわ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0530019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:二学期が楽しみだな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0530020")

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
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","002","101016002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","005","101020005","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
