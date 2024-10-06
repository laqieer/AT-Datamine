-- このluaスクリプトは、CO_101001_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★マルイル★★:あっ、ノワールさん！<br>いいところに！
	Talk(Actor003,"CHRNAME_MARIL","speech","L","CO_101001_07020002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:マルイル？<br>どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_07020003")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★マルイル★★:実はぼくの知り合いの古物商が<br>この町へ来ることになっていたんですが
	Talk(Actor003,"CHRNAME_MARIL","speech","L","CO_101001_07020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "悲しみ")
-- ▲直接出力

	--★★マルイル★★:街道に盗賊が出没して<br>足止めを喰らっているそうなんです
	Talk(Actor003,"CHRNAME_MARIL","speech","L","CO_101001_07020005")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それは大変だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_07020006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マルイル★★:ノワールさん、もしよければ<br>盗賊たちを追い払ってくれませんか？
	Talk(Actor003,"CHRNAME_MARIL","speech","L","CO_101001_07020007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マルイル★★:もちろん、報酬は払いますので！
	Talk(Actor003,"CHRNAME_MARIL","speech","L","CO_101001_07020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101001_07020010","CO_101001_07020011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:当然だ<br>困ってる人を見過ごすわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_07020013")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:私も協力いたします<br>マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_07020014")

	change_face(Actor001,"Smile")

	--★★ノワール★★:頼りにしてるよ、ティルフィング！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_07020015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
set_enable_auto_lookat(Actor002, true)
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ティルフィング、どうしよう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_07020017")

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:私の判断を待つ必要などありませんよ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_07020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:こういった状況でアナタがどうなさるか<br>私は理解していますし、もちろん協力いたします
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_07020019")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう<br>迷惑をかけるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_07020020")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.9)
wait_time(0.4)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:引き受けるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_07020022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マルイル★★:ありがとうございます！<br>よろしくお願いしますね～！
	Talk(Actor003,"CHRNAME_MARIL","speech","L","CO_101001_07020023")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ7_3")
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
