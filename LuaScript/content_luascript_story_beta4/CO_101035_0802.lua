-- このluaスクリプトは、CO_101035_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
set_common_look_at(Actor001,Actor003)
set_common_look_at(Actor002,Actor003)
prop001=setup_prop_object(10112001)
set_pos(prop001,{-2.7,0,1})
set_rot(prop001,{0,70,0})
prop002= set_object("content_weapon_101016001", "weapon_model_101016001", true)
set_pos(prop002,{-2.24,0.85,0.26})
set_rot(prop002,{70,-45,0})
prop003=setup_prop_object(10201019)
set_pos(prop003,{-1.8,0,1.1})
prop004=setup_prop_object(30101001)
set_pos(prop004,{-2,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:マルコさん<br>もう立って大丈夫なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_08020002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定3")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:はい、もうすっかり
	Talk(Actor003,"NPCNAME_0250","speech","N","CO_101035_08020003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男2", "挨拶")
-- ▲直接出力

	--★★東方諸国連合軍兵_下位★★:よくしていただいたお礼と言ってはなんですが<br>私に畑仕事を手伝わせていただけませんか？
	Talk(Actor003,"NPCNAME_0250","speech","N","CO_101035_08020004")


	--★★東方諸国連合軍兵_下位★★:重いものを運んだりはできないかもしれませんが<br>種まきや収穫物の泥を取るくらいはできます
	Talk(Actor003,"NPCNAME_0250","speech","N","CO_101035_08020005")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:えっ？でも…<br>どうしましょう、ノワールさん？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_08020006")

	open_select_window_tag(Actor001,"Normal","CO_101035_08020008","CO_101035_08020009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
lookat_weight(Actor001,0.6,0.03,0.7,0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいんじゃないか？<br>お願いしよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_08020011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:マルコさんもそろそろ<br>体を動かしたくなってきた頃だろうし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_08020012")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ほら、前に言ってたじゃないか<br>気分転換だよ、気分転換
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_08020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_weight(Actor002,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",2)
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:そうか…そうですね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_08020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まだ休んでいたほうがいいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_08020017")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★東方諸国連合軍兵_下位★★:大丈夫です<br>具合が悪くなったらすぐ休ませてもらいますから
	Talk(Actor003,"NPCNAME_0250","speech","N","CO_101035_08020018")

-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:そこまでおっしゃるなら…お願いします
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_08020019")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:では、畑まで移動しましょう<br>マルコさんは無理なさらないでくださいね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_08020021")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リリアーナ_ランクアップ8_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10112001)
set_object_preload("content_weapon_101016001", "weapon_model_101016001", true)
setup_prop_object_preload(10201019)
setup_prop_object_preload(30101001)
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
