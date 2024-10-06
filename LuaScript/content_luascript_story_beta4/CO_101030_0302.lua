-- このluaスクリプトは、CO_101030_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-110,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor002,Actor003,"J_Head")
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101010111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:…それでね、トビーくん
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03020002")


	--★★エレイン★★:体の調子が良くなって目が見えるようになるまで
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03020003")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:私がよく知っている村で少しお休みしてみない？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03020004")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:…ぼく、ここにあんまりいたくないお姉ちゃんについていくよ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_03020006")

-- ▼直接出力
setup_small_camera_end(RndCamera090)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_03020008","CO_101030_03020009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺も行ったことあるけどなすごくいいところだぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03020011")

	change_face(Actor001,"Smile")

	--★★ノワール★★:空気も水も、食べ物もおいしいすぐ体も良くなるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03020012")

-- ▼直接出力
PlayPartVoice("子供_男2", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）②★★:ほんとう？
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_03020013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、本当だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03020014")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:私も保証する！期待していいからね！！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:トビーがＯＫしてくれてよかったな、エレイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_03020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:はい…ありがとう、トビーくん
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03020018")

	change_face(Actor002,"Normal")

	--★★エレイン★★:ゆっくり休めばきっと目も見えるようになるはずだから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03020019")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★エレイン★★:馬車の手配をしておきました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03020021")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:今からここを出れば今日中にアストラットに着けるはずです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_03020022")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エレイン_ランクアップ3_3")
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
	load_duel_scene_preload(101010111)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
