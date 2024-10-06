-- このluaスクリプトは、PT2_01B_10_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:パーシヴァルにヴォールス？<br>珍しい組み合わせだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0040002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力

	--★★ヴォールス★★:…ノワールか
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_10_0040003")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★パーシヴァル★★:やぁ、継承者クン<br>ずいぶん遅いお目覚めだね
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:ふたりでなにを話してたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0040005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:お互いのもつ情報を共有していた
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_10_0040006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:前回の聖杯探索では魔女が現れたんだろう？<br>次もなにが起こるかわからない…
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0040007")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★パーシヴァル★★:いや、きっとなにかが起こる<br>だから万が一に備えておくべきだと思ってね
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0040008")

-- ▼直接出力
PlayPartVoice("ヴォールス", "挨拶")
-- ▲直接出力

	--★★ヴォールス★★:ノワール<br>魔女との戦いについては、お前に一日の長がある
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_10_0040009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ヴォールス★★:わずかでもいい<br>お前のもっている情報を自分たちに共有してくれ
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_10_0040010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0040011")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.6)
wait_time(0.4)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それにしても…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0040012")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:なんだい？<br>ぼくの顔になにか付いているかい？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0040013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:いや…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0040014")

-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴォールス", "納得")
-- ▲直接出力

	--★★ヴォールス★★:ノワールは<br>お前の真剣な表情を見慣れていないのだろう
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_10_0040015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★パーシヴァル★★:わかっていても<br>いちいち説明しなくていい！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0040016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:自分もだがな
	Talk(Actor002,"CHRNAME_BORS","speech","L","PT2_01B_10_0040017")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★パーシヴァル★★:しなくていいと言っているだろう！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","PT2_01B_10_0040018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
