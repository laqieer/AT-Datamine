-- このluaスクリプトは、MA_01B109_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
 -- set_animationbattlecontroller(Actor001, 1, false)
 -- set_animationbattlecontroller(Actor002, 2, false)
 -- set_animationbattlecontroller(Actor003, 1, false)
 -- set_animationbattlecontroller(Actor004, 2, false)
set_animationbattlecontroller(Actor005, 1, false)
set_animationbattlecontroller(Actor006, 2, true)
set_animationbattlecontroller(Actor007, 3, false)
set_animationbattlecontroller(Actor008, 4, true)
 -- sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
 -- sword_02 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
sword_03 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
sword_04 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
spear_01 = set_object("content_weapon_104020001", "weapon_model_104020001", true)
 -- bow_01 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
 -- bow_02 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
bow_03 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,0}
 -- on_parent(sword_01,Actor001, "Loc_weapon_constrint_R",weapon_offset)
 -- on_parent(sword_02,Actor002, "Loc_weapon_constrint_R",weapon_offset)
 -- on_parent(bow_01,Actor003, "Loc_weapon_constrint_R",weapon_offset)
 -- on_parent(bow_02,Actor004, "Loc_weapon_constrint_R",weapon_offset)
on_parent(sword_03,Actor005, "Loc_weapon_constrint_R",weapon_offset)
on_parent(sword_04,Actor006, "Loc_weapon_constrint_R",weapon_offset)
on_parent(spear_01,Actor007, "Loc_weapon_constrint_R",weapon_offset)
on_parent(bow_03,Actor008, "Loc_weapon_constrint_R",weapon_offset)
PlayActionDirect(Actor005,"ToAbnormal")
PlayActionDirect(Actor006,"ToAbnormal")
PlayActionDirect(Actor007,"ToAbnormal")
PlayActionDirect(Actor008,"ToAbnormal")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-0.96,0,1.11})
set_rot(Actor005,{0,-183,0})
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{0.9,0,-2.6})
set_rot(Actor006,{0,-57.5,0})
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{-1.92,0,0.38})
set_rot(Actor007,{0,50.8,0})
set_enable_auto_lookat(Actor007,false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{2.21,0,-2.48})
set_rot(Actor008,{0,-97.6,0})
set_enable_auto_lookat(Actor008,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000012)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:………正直に言えばだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150002")


	--★★ノワール★★:…なんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_150003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:俺ひとりでは心もとなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:よく言うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_150006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:お前にしか<br>頼めないお願いだったんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150007")


	--★★ランスロット★★:師匠のように<br>誰かになにかを伝えていきたい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150008")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ランスロット★★:生きた証を残したい<br>できるかぎり多く、できるかぎり強く
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_150010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:ちょっぴり後ろ向きな動機で、情けないな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_150013","MA_01B109_150014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺が力になるよ<br>そのためにあんたの手を取ったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_150016")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150017")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:まずは俺が、あんたの生きた証になる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_150018")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:………ははは
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150019")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:なにかおかしいことを言ったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_150020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…いや
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ランスロット★★:うれしいことを、言われたよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:巻き込まれた身にもなって欲しいよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_150024")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…すまないな<br>付き合わせてしまったようだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150025")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:無配慮が過ぎたようだ<br>少し甘えていたな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150026")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まだ、教えてもらいたいことが山ほどある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_150028")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_150029")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:最後なんかにさせないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_150030")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★トリスタン★★:………なんだろ、ランスロット
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_150032")

	PlayAction(Actor004,"to  Std_Worry")

	--★★トリスタン★★:なにかに、焦ってる？
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01B109_150033")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
set_object_preload("content_weapon_104020001", "weapon_model_104020001", true)
set_object_preload("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_duel_scene_preload(101000012)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
