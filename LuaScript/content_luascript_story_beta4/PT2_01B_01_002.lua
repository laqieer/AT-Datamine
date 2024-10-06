-- このluaスクリプトは、PT2_01B_01_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:よう、ノワール！<br>あけましておめでとさん
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","PT2_01B_01_0020002")

-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:…おめでと
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01B_01_0020003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:おめでとう、ふたりとも！<br>っていうか、トリスタンは予想外だったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:連れてこられたんだよ、無理矢理
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01B_01_0020005")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Anger")

	--★★トリスタン★★:でもさ、「予想外だった」なんて<br>本人を目の前にして言わないと思うよ、ふつう
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01B_01_0020006")

-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力

	--★★ノワール★★:ははは、ごめんごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0020007")

-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:…まったく<br>別にいいけどさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01B_01_0020008")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:それよりよ<br>もうすぐすべてに決着がつくんだよな？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","PT2_01B_01_0020009")


	--★★ガウェイン★★:お前にばっか<br>面倒ゴト押し付けてるようで申しわけねーけどさ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","PT2_01B_01_0020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:俺たちもできるだけ協力すっからよ<br>よろしく頼むぜ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","PT2_01B_01_0020011")

-- ▼直接出力
PlayPartVoice("トリスタン", "怒り")
-- ▲直接出力

	--★★トリスタン★★:ちょっと<br>勝手にボクも含めないでくれる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01B_01_0020012")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:なんだよお前<br>ノワールに協力しねーってのか？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","PT2_01B_01_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:そんなこと言ってないでしょ<br>ボクはボクなりにやらせてもらうってだけ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01B_01_0020014")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.6)
wait_time(0.5)
-- ▲直接出力

	--★★トリスタン★★:キミに危険が及ばないかは視ていてあげるからさ<br>…せいぜい頑張ってよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01B_01_0020015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ありがとう、ふたりとも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0020016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
