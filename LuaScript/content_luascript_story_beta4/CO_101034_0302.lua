-- このluaスクリプトは、CO_101034_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_pos(Actor003,{3.5,0,1})
set_rot(Actor003,{0,-105,0})
Hide(Actor003)
weapon_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_02 = set_object("content_weapon_106020001", "weapon_model_106020001", true)
weapon_offset = {0,0,0,0,0,0}
off_active(weapon_01)
off_active(weapon_02)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",20,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あー…エクセリア、このあいだなんだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:このあいだ？いつのことかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:花の種を渡した日だよあのとき俺さ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020004")

	change_face(Actor001,"Sad")

	--★★ノワール★★:気付かず変なこと言っちゃったみたいで…ごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力

	--★★エクセリア★★:あなたは別に変なことは言っていない気にすることはないわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020006")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか？それだったらいいんだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:そんなことより、最近バルバロイが現れるひん度が増えているわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああつい先日も緊急で対応したって聞いた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020010")


	--★★エクセリア★★:この１週間で７度ね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:１週間で７度だって！？結構な数だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:近隣の街や村の住人は気が気じゃないでしょうね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:近隣の住人だけじゃない兵士や学園の生徒にも負傷者が出てる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力

	--★★エクセリア★★:記憶を失った生徒がいる話も聞くわね…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あぁ…うちのクラスにもいたな記憶の一部がなくなった生徒が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101034_03020018","CO_101034_03020019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイと戦い続けるってことは記憶を失うリスクと背中合わせだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020021")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺たちもいつかはそうなってしまうかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:でも、それを恐れて戦いをやめることは許されないわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020023")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:覚悟のうえで私たちはGSを果たしたのでしょう？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ、もちろんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:バルバロイに記憶を奪われる…きっとつらいことだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020028")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020029")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Normal")

	--★★エクセリア★★:どんな記憶を失ったのかわからないのならつらいとは感じないかもしれない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020030")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…エクセリア？どうした？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020031")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera001)
Camera002=setup_small_camera_resetting(Actor002,CharaPos008,CameraPos008)
set_animationbattlecontroller(Actor002,10,true)
on_active(weapon_02)
on_parent(weapon_02,Actor002, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのさ――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020033")

-- ▼直接出力
se_play("SE_ADV_CO_101034_0602_Gun_Hold")
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
set_animationbattlecontroller(Actor001,1,false)
on_active(weapon_01)
on_parent(weapon_01,Actor001, "Loc_weapon_constrint_R",weapon_offset)
set_pos(Actor001,{0.8,0,-1})
set_rot(Actor001,{0,60,0})
Appear(Actor003)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エクセリア★★:誰！？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020035")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "驚き")
-- ▲直接出力

	--★★市民（中年男）★★:うわっ！！…な、なんだ…人間か
	Talk(Actor003,"NPCNAME_0287","speech","N","CO_101034_03020037")


	--★★ノワール★★:…あなたは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020039")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:この先の村に住む市民（中年男）だよ
	Talk(Actor003,"NPCNAME_0287","speech","N","CO_101034_03020040")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
off_parent(weapon_01)
off_active(weapon_01)
off_parent(weapon_02)
off_active(weapon_02)
set_animationcontroller(Actor001,"Chr_002_01_StdController","to Std_Loop")
set_animationcontroller(Actor002,"Chr_510_01_StdController","to Std_Loop")
Camera001 = setup_small_camera_resetting(Actor001,CharaPosDuelCommonFormation01_005,CameraPosDuelCommonFormation01_005)
Camera002 = setup_small_camera_resetting(Actor002,CharaPosDuelCommonFormation01_006,CameraPosDuelCommonFormation01_006)
Camera003 = setup_small_camera_resetting(Actor003,CharaPosDuelCommonFormation01_002,CameraPosDuelCommonFormation01_002)
set_common_look_at(Actor001,Actor003)
set_common_look_at(Actor002,Actor003)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "悩む")
-- ▲直接出力

	--★★市民（中年男）★★:その格好、学園の生徒さんかこんな森になんの用だい？
	Talk(Actor003,"NPCNAME_0287","speech","N","CO_101034_03020042")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:このあたりでバルバロイが出現した報告を受けて調査に来たんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020043")


	--★★ノワール★★:危ないから仕事は切り上げて村に戻ったほうがいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020044")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "驚き")
-- ▲直接出力

	--★★市民（中年男）★★:このあたりにバルバロイが出たのか？
	Talk(Actor003,"NPCNAME_0287","speech","N","CO_101034_03020045")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "落胆")
-- ▲直接出力

	--★★市民（中年男）★★:うーん、参ったな…村の何人かがもう少し先に行ってるんだよ
	Talk(Actor003,"NPCNAME_0287","speech","N","CO_101034_03020046")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
turn_chara(Actor001,0,0)
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:ノワール…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:その人たちにも危険を報せてやらないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:それなら私とノワールは二手に分かれましょう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020051")


	--★★エクセリア★★:私はこの人を送りがてら村の周囲を見回ってくるわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020052")


	--★★エクセリア★★:ノワールは先行している仲間の方たちに状況を報せてあげて
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エクセリア★★:村の安全が確認できたら私もすぐに追いかけるわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03020054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わかった、そうしよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03020055")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エクセリア_ランクアップ3_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
set_object_preload("content_weapon_106020001", "weapon_model_106020001", true)
weapon_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
