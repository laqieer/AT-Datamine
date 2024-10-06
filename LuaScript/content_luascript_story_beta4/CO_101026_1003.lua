-- このluaスクリプトは、CO_101026_1003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",92.4,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera002 = SetTemplate("Actor002",112,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SleepController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_001)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor003,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_huton_110141_02()
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:やあ、ジャン<br>体の調子はどうだい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030002")

-- ▼直接出力
lookWeight = {0.5, 0, 0.7, 0.35}
lookat_delay_weight(Actor003, lookWeight,0.5)
keep_ik_lookat(Actor003, Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:ああ、パーシヴァルさん<br>いつも来てくれてありがとう
	Talk(Actor003,"NPCNAME_0243","speech","N","CO_101026_10030003")


	--★★キャメロット騎士学術院（男）②★★:体はすっかりよくなったみたいです<br>でも…
	Talk(Actor003,"NPCNAME_0243","speech","N","CO_101026_10030005")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:そうか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:体がよくなったのなら食べられるだろう<br>見舞いの品だよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030009")


	--★★キャメロット騎士学術院（男）②★★:これは…
	Talk(Actor003,"NPCNAME_0243","speech","N","CO_101026_10030011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★キャメロット騎士学術院（男）②★★:ローストポーク！<br>僕、これ大好物なんです
	Talk(Actor003,"NPCNAME_0243","speech","N","CO_101026_10030013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:そうだね<br>キミは昔からそれが大好物だった
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030015")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ボクはそれをよく知ってる
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030016")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:療養院を出ていいくらいまで回復したら<br>お祝いにもっとたくさんご馳走してやろう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030018")

-- ▼直接出力
PlayPartVoice("男子2", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★キャメロット騎士学術院（男）②★★:えっ、本当に？
	Talk(Actor003,"NPCNAME_0243","speech","N","CO_101026_10030020")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ああ、本当さ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:いろんな店のローストポークを食べよう<br>そこからボクたちの新しい思い出を作っていこう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:パーシヴァル…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_10030023")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★キャメロット騎士学術院（男）②★★:なんだかパーシヴァルさんには<br>ずっとこうして優しくしてもらっていた気がする
	Talk(Actor003,"NPCNAME_0243","speech","N","CO_101026_10030025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ああ、そうだとも<br>キミはボクの付き人だったんだからね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030026")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:付き人は大切にすべし<br>ノブレス・オブリージュの基本だよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_10030028")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ10_4")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
