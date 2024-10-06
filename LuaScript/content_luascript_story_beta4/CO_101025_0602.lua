-- このluaスクリプトは、CO_101025_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
prop001=setup_prop_object(10120003)
on_active(prop001)
set_pos(prop001,{-0.3,0,0})
set_rot(prop001,{0,-150,0})
set_pos(Actor004,{-3.4,0,0})
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Kneeling")
DontChangeRandomCamera(true)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookoj=create_object("kara")
set_pos_object(lookoj,0,0,0)
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",1.0)
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",1.0)
keep_delay_ik_lookat_object(Actor003,lookoj,"kara",1.0)
lookat_weight_default(Actor001)
lookat_weight_default(Actor002)
lookat_weight_default(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:ここが現場だ
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_06020002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:この人は…以前依頼をくれた<br>ロンディニウムの郵便配達人ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06020004")

-- ▼直接出力
setup_small_camera_start(Camera001)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どうしてこんなことに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06020005")

-- ▼直接出力
Appear(Actor004)
keep_ik_lookat(Actor004,Actor001,"J_Head")
PlayPartVoice("兵士1", "挨拶")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:おっと、誰かと思えば探偵サンか<br>また調査に首を突っ込もうってか？
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_06020007")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{-1.8,0,0},1)
setup_small_camera_start()
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.8)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:また？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06020008")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力

	--★★ヴォールス★★:以前ちょっと、な
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_06020009")

-- ▼直接出力
SkipDefaultMotion(Actor004)
 PlayActionDirect(Actor004,"to  Std_Worry")
PlayPartVoice("兵士1", "笑い")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:だが、あいにくこれは事故さ<br>バルバロイに襲われるとは不幸な男だね
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_06020010")

-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:いいえ…これは<br>バルバロイの仕業に見せかけた殺人事件よ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06020012")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("兵士1", "肯定2")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:はぁ？バルバロイが逃げてくのを見たって<br>目撃者がいるんだぜ
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_06020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力

	--★★クレア★★:人間を殺害したことを目撃されて<br>逃げ出すバルバロイなんていないわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06020015")


	--★★クレア★★:その目撃者はどこにいるの？<br>詳しく話を聞きたいわね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06020016")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
set_enable_auto_lookat_all(true)
PlayPartVoice("兵士1", "苦しみ")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:連絡をくれてすぐどっか行っちまったから<br>顔も確認してな…って、とにかくだ！
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_06020018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("兵士1", "激怒")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:もうじき遺族が引き取りにくる<br>これ以上引っ掻き回したら、逮捕すんぞ！
	Talk(Actor004,"NPCNAME_0270","speech","N","CO_101025_06020019")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ6_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10120003)
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
