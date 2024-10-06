-- このluaスクリプトは、CO_101014_0904.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_017_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101010111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401030","001","401030001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "肯定2")
-- ▲直接出力

	--★★汎用王様★★:まさかすべて大臣の企みだったとは…あなた方にはなんと感謝してよいやら
	Talk(Actor004,"NPCNAME_0292","speech","N","CO_101014_09040002")

	open_select_window_tag(Actor001,"Normal","CO_101014_09040004","CO_101014_09040005")
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
	change_face(Actor001,"Laugh")

	--★★ノワール★★:礼にはおよびません騎士として当然のことをしたまでです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_09040007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:さすが<br>こういったやりとりは手慣れたもんだね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09040008")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
lookat_delay_weight(Actor001, {0.4, 0.4, 1, 1} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★イゾルデ★★:トリスタンも<br>少しは見習ってみてはどうかしら
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09040009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:遠慮しとくよむず痒くってかなわない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09040010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いえ、俺はなにもしていませんすべてトリスタンのおかげです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_09040012")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0013")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボクは気に入らないヤツをこらしめたかっただけだけど？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09040013")

-- ▼直接出力
lookat_delay_weight(Actor001, {0.4, 0.4, 1, 1} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,25,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:お前のその想いが<br>みんなを救ったんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_09040014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★イゾルデ★★:そうね誇っていいと思うわ、トリスタン
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09040015")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★トリスタン★★:なんかよくわからんないけどまあ、悪い気はしないかな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09040016")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
turn_chara(Actor001,25,0)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "喜び")
-- ▲直接出力

	--★★汎用王様★★:改めてお礼を申し上げさせてくださいありがとうございました
	Talk(Actor004,"NPCNAME_0292","speech","N","CO_101014_09040018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:いや。こっちもいいものを教えてもらったよ<br>人を信じてみるのも悪くないって思った
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09040019")

-- ▼直接出力
wait_time(0.4)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_09040020")

-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★イゾルデ★★:トリスタン。こういうときになんて言うか<br>知っているでしょう？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09040021")

-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:意地が悪いね相変わらずキミは
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09040022")

-- ▼直接出力
change_face(Actor001,"Laugh")
-- ▲直接出力

	--★★トリスタン★★:あ、あり、ありが…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09040023")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★トリスタン★★:あ～～～～～もう！
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09040024")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ9_5")
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
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401030","001","401030001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
