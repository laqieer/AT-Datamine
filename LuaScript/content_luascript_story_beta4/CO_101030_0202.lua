-- このluaスクリプトは、CO_101030_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",160,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003, "J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン_002","0002")
-- ▲直接出力

	--★★トリスタン★★:おまたせ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02020002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力

	--★★ノワール★★:トリスタンとイゾルデ？ふたりも行くのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:はいイゾルデさんにお願いしたいことがありまして
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02020004")

	open_select_window_tag(Actor001,"Normal","CO_101030_02020006","CO_101030_02020007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:なんだ、トリスタンはおまけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02020009")

-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★トリスタン★★:イゾルデが今日の主役なんだとしたらキミはボク以上におまけだと思うけどね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02020010")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0029")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:ふ、ふたりとも仲良くしましょう、ね…？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02020011")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:エレイン、心配する必要はないわいつものことだから
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101030_02020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:賑やかな道中になりそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02020014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:円卓の騎士がふたりも来てくれたら子供たち、きっと大喜びです！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02020015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン_002","0033")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:別に子供に喜んでほしくて行くわけじゃないけどさ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02020016")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:いつもやっていることだものね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101030_02020017")

-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0009")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…いつも？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02020018")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン_002","0003")
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★トリスタン★★:あのさ。ボク、嫌いなんだよねプライベートを詮索されるの
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02020019")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0037")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:す、すみません…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02020020")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
voice_play("VO_101009_sp_0006_2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おい、トリスタン！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02020021")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
PlayPartVoiceDirect("ノワール","0037")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめんな、エレインこういうヤツなんだ、許してやってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02020022")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン_002","0015")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:…どういうヤツ？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02020023")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラヴェイン★★:では、暗くならないうちに出発しましょう
	Talk(Actor005,"CHRNAME_LOVEIN","speech","L","CO_101030_02020025")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_エレイン_ランクアップ2_3")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
