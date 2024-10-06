-- このluaスクリプトは、CO_101001_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定3")
-- ▲直接出力

	--★★ディンドラン★★:あら、ふたり一緒とは珍しいですね<br>今日はどのような本をお探しに？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101001_06020002")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
set_enable_auto_lookat(Actor002, true)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:そうだな…ティルフィングは<br>なにか読みたい本とかないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力

	--★★ティルフィング★★:私に気を遣わず<br>マスターの希望を優先してください
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それが、実はまだなにを読むか<br>決めてなくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06020005")

	change_face(Actor001,"Smile")

	--★★ノワール★★:だから、ティルフィングに希望があるなら<br>まずはそっちを優先したい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06020006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:…わかりました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06020008")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.8)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.8)
-- ▲直接出力

	--★★ティルフィング★★:では、歴史上に名を残す英雄や武器について<br>書かれた書物はありますか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06020009")

-- ▼直接出力
PlayPartVoice("ディンドラン", "悩む")
-- ▲直接出力

	--★★ディンドラン★★:うーん…
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101001_06020010")


	--★★ディンドラン★★:英雄伝承であれば<br>ある程度の数が揃っていると思うのですが
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101001_06020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディンドラン★★:武器については<br>期待に沿えるほどのものはないかもしれません
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101001_06020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい<br>それでも構いません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06020014")


	--★★ディンドラン★★:クリスティーナなら私よりも詳しいはず<br>聞いてきましょうか？
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101001_06020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:あ、いえ！<br>そこまでしていただかなくても大丈夫です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06020016")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:伝記の棚の場所を教えていただけますか？<br>自分で探してみますので
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06020017")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力

	--★★ディンドラン★★:それなら、こちらへ
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","CO_101001_06020018")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ6_3")
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
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
