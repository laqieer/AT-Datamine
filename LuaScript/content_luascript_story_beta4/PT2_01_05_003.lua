-- このluaスクリプトは、PT2_01_05_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115907)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力

	--★★クリスティーナ★★:あら、ノワールちゃんじゃない
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT2_01_05_0030006")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:クリスさん？どうしてここに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0030007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:ちょっと、聞いてよ～<br>本の返却を３週間も延滞してるコがいてね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT2_01_05_0030008")

	change_face(Actor002,"Anger")

	--★★クリスティーナ★★:たっぷりお灸を据えてやろうかと…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT2_01_05_0030009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:…じゃない<br>返してくれるようお願いに来たの?
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT2_01_05_0030010")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そ、それは…ご苦労様
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ノワールちゃんも大図書院で本を借りるときは<br>返却日を守るようにしてね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT2_01_05_0030012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:期日までに<br>大図書院の受付に持ってきてくれればいいから
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT2_01_05_0030013")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:守ってくれないと…イタズラしちゃうわよ?
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT2_01_05_0030014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ま、まもるよ、ぜったい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0030015")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:お願いよ？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","PT2_01_05_0030016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ま、まもらなきゃ、ぜったい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0030018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115907)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
