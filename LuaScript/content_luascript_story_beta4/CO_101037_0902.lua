-- このluaスクリプトは、CO_101037_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor001,0.9,0.05,0.5,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…えっ？<br>まだお見舞いに一度も行ってない？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09020002")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴェルナルス先生が戻ってきて<br>しばらく経ってるだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:そうなんですけど…<br>なにを話そうとか、いろいろ考えてしまって…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09020004")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:気持ちはわからないでもないけど<br>きっと先生は待ってるぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09020005")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ラシア★★:そうでしょうか…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09020006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お見舞いに行ってないってことは<br>約束のヨーグルトもまだ渡してないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:そうなんです…<br>作ってはいますけど…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09020008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:よし、じゃあそれを持っていこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09020009")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ9_3")
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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
