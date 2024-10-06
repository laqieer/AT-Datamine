-- このluaスクリプトは、EA_006_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera003 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera006 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera007 = SetTemplate("Actor009",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-17.61, 0, 10.8})
set_pos(Actor005,{-17.31, 0, 15.31})
set_pos(Actor007,{-19.68, 0, 6.86})
set_pos(Actor008,{-23.29, 0, 10.63})
set_pos(Actor009,{-23.38, 0, 14.69})
-- ▲直接出力
-- ▼直接出力
Camera_EX1 =set_camera({-8.12, 4.77, 3.73,   16.71065, 306.759, 359.6533,   30.36522})
-- ▲直接出力
-- ▼直接出力
Camera_EX2 =set_camera({3.44, 3.14, 7.61,   8.30351, 274.8122, 359.0387,   21.50124})
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor007,1,false)
set_animationbattlecontroller(Actor008,1,false)
set_animationbattlecontroller(Actor009,1,false)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
-- ▲直接出力
-- ▼直接出力
sword_05 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
on_parent(sword_05,Actor007, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
sword_06 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
on_parent(sword_06,Actor008, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
sword_07 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
on_parent(sword_07,Actor009, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
Camera_EX3 =set_camera({-0.64, 2.39, 8.29,   11.06589, 170.6308, 357.0707,   21.50124})
-- ▲直接出力
-- ▼直接出力
load_image("104000320", "content_still_10400032_image", "104000320_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
load_sound("BGM_Battle_Running")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	Actor007 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:数日後
	Talk(Actor001,"telop","simple","N","EA_006_0510003")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ガレス★★:ポカポカ陽気のいい天気！<br>今日は絶好のお花見日和だ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510004")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
setup_small_camera_start(Camera_EX3)
wait_time(0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0007")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:いよいよフラワーグッドフレンド作戦も大詰め<br>気合い入れていくぞ～！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510005")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ランスロット★★:
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ガレス★★:うん！皆のお弁当はリオネスたちが後から<br>持ってきてくれることになってるんだ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510007")

	change_face(Actor002,"Smile")

	--★★ガレス★★:皆が来たらすぐにお花見スタートできるように<br>急いでセッティングするぞ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力

	--★★ランスロット★★:そうなのか<br>じゃあ、ガレスが手に持ってるそれは
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510009")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
ShowImageItem(104000320)
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:え？これ？これは、その…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510010")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
HideImageItem(104000320)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガレス★★:ほ、ほかのとごっちゃにならないように<br>分けておきたいやつだけ先に持ってきたんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510011")

-- ▼直接出力
setup_small_camera_end(Camera_EX3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Surprise")

	--★★ランスロット★★:なるほど…？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510012")

	change_face(Actor002,"Sad")

	--★★ガレス★★:（…一応、作ってみたんだ。兄さんの好物ばかり<br>挟んだ特製サンドウィッチ）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0510013")

	change_face(Actor002,"Normal")

	--★★ガレス★★:（皆でちょっと遠出して、いつもと違う場所で<br>手作りのお弁当を食べながら同じ花を眺めて）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0510014")


	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0510015")

-- ▼直接出力
setup_small_camera_start(Camera_EX3)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ガレス★★:（…きっと、仲直りできるよな。母さん）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0510016")

-- ▼直接出力
setup_small_camera_end(Camera_EX3)
setup_small_camera_start(Camera002)
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ランスロット★★:…！
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510017")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera_EX3)
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,291,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ガレス★★:？どうしたんだ、ランスロット
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510019")

	change_face(Actor003,"Normal")

	--★★ランスロット★★:――どうやら、先客らしい
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510020")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
setup_small_camera_end(Camera_EX3)
setup_small_camera_start(Camera_EX1)
wait_time(0.4)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor005,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
turn_chara(Actor002,327,0)
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★カレドニア兵A★★:なぁ、もういいんじゃないか？<br>奴らのエサは充分集めただろう？
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_006_0510023")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
PlayActionDirect(Actor005,"to Wlk")
turn_lookat(Actor005,Actor004,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_No")

	--★★カレドニア兵B★★:いや、まだだ
	Talk(Actor005,"NPCNAME_0398","speech","N","EA_006_0510024")


	--★★カレドニア兵B★★:ついでにこの辺りの土地一帯を<br>カレドニアの拠点にする準備をしろとのご命令だ
	Talk(Actor005,"NPCNAME_0398","speech","N","EA_006_0510025")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★カレドニア兵A★★:なるほど<br>それじゃあ、更地にしてやらないとな
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_006_0510026")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
setup_small_camera_end(Camera_EX1)
setup_small_camera_start(Camera_EX3)
wait_time(0.8)
-- ▲直接出力

	--★★ガレス★★:あれは――カレドニア兵？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510028")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ガレス★★:花を踏み荒らして、木を蹴って――<br>なんであんなこと…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510029")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0007")
-- ▲直接出力

	--★★ランスロット★★:どうやら軍事上の拠点を作るつもりらしい<br>トリスタンの報告にあった不審な動きはこれか
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:確かにこの場所を押さえれば<br>ログレス侵攻の足掛かりとなるだろう
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510031")


	--★★ランスロット★★:そしてここはログレスの民にとって憩いの場だ<br>家族や友人同士で集まり、花を眺める――
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510032")


	--★★ランスロット★★:そういった場を奪うことで精神的なダメージを<br>与える狙いもあるのだろう
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510033")

-- ▼直接出力
setup_small_camera_end(Camera_EX3)
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")

	--★★ランスロット★★:（こんな卑劣なやり方を取る者の顔は<br>ひとりしか思い浮かばない）
	Talk(Actor003,"CHRNAME_LANCELOT","mind","L","EA_006_0510034")

	change_face(Actor003,"Sad")

	--★★ランスロット★★:（だが、奴は確かにこの手で――<br>それに、「奴らのエサ」とは…？）
	Talk(Actor003,"CHRNAME_LANCELOT","mind","L","EA_006_0510035")

-- ▼直接出力
setup_small_camera_end(Camera003)
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ガレス★★:そんな――そんなの、酷い<br>ここはログレスの有名なお花見スポットで…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510036")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start(Camera_EX3)
-- ▲直接出力

	--★★ガレス★★:わたしが家族との思い出を大切にしているように<br>きっと誰かもこの場所を大切にしているのに
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510037")


	--★★ガレス★★:大切な、思い出の場所で――
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510038")

-- ▼直接出力
CloseTalkWindow()
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
bgm_play("Set_BGM_Bus_LPF_Volume_1")
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★オークニー王妃★★:
	Talk(Actor006,"NPCNAME_0395","simple","N","EA_006_0510041")


	--★★オークニー王妃★★:今はここにいないあの子もいつか…
	Talk(Actor006,"NPCNAME_0395","simple","N","EA_006_0510042")


	--★★オークニー王妃★★:一緒にお花見、できたらいいわね
	Talk(Actor006,"NPCNAME_0395","simple","N","EA_006_0510043")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
hide_image(BLACK_WHITE_TIME)
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0018")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510045")

-- ▼直接出力
setup_small_camera_end(Camera_EX3)
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0008")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ランスロット★★:…同感だ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_006_0510046")

-- ▼直接出力
setup_small_camera_end(Camera002)
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_Running")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:行こう！ランスロット！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510047")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera001)
setup_small_camera_start(Camera_EX3)
wait_time(0.5)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,{-12.08, 0, 6.8}, 2.5)
wait_time(1.0)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,{-9.77, 0, 8.99}, 2.5)
wait_time(1.0)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
set_animationbattlecontroller(Actor002,11,true)
set_animationbattlecontroller(Actor003,1,false)
sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
on_parent(sword_01,Actor003, "Loc_weapon_constrint_R",weapon_offset)
sword_02 = set_object("content_weapon_106010001", "weapon_model_106010001", true)
weapon_offset = {0,0,0,0,0,0}
on_parent(sword_02,Actor002, "Loc_weapon_constrint_R",weapon_offset)
setup_small_camera_start(Camera_EX2)
turn_lookat(Actor004,Actor003,0)
turn_lookat(Actor007,Actor003,0)
turn_lookat(Actor008,Actor003,0)
turn_lookat(Actor005,Actor002,0)
turn_lookat(Actor009,Actor002,0)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(1.0)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(2.4)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")

	--★★カレドニア兵A★★:！？なんだ、テメエら――
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_006_0510049")

	PlayAction(Actor005,"to  Std_Surp")

	--★★カレドニア兵B★★:
	Talk(Actor005,"NPCNAME_0398","speech","N","EA_006_0510050")


	--★★ガレス★★:ただの女と甘く見るなよ～！<br>――わたしは円卓の騎士・六ノ座ガレス
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510051")


	--★★ガレス★★:ろくなご飯食えない人にも<br>笑顔と食卓を届けるよ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0510052")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
load_image_preload("104000320", "content_still_10400032_image", "104000320_StillImage")
preload_sound("BGM_ADV_Reconnaissance")
preload_sound("BGM_Battle_Running")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
