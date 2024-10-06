-- このluaスクリプトは、PT2_01B_09_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:おはよう、フィエナにガラハッド<br>なにしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0030002")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:おはよう、ノワール！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_09_0030003")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:………
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","PT2_01B_09_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フィエナ★★:ガラハッド！<br>騎士は礼儀正しくしなきゃ！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_09_0030005")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")

	--★★ガラハッド★★:…おはよう
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","PT2_01B_09_0030006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:よろしい！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_09_0030007")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★フィエナ★★:えっとね、このあとどうやって<br>ノワールたちに協力するか相談してたんだ
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_09_0030008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そのことなんだけどさ<br>本当に聖杯まで案内できるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0030009")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガラハッド★★:お前！<br>姉上のことを疑うのか！？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","PT2_01B_09_0030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★フィエナ★★:どうどう<br>ガラハッド、どうどう
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_09_0030011")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フィエナ★★:ノワールが信じられない気持ちもわかるよ
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_09_0030012")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★フィエナ★★:（私もどうなるか、まだわかんないし）
	Talk(Actor002,"CHRNAME_VIENA","mind","L","PT2_01B_09_0030013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0030014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "否定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:なんでもないなんでもない、こっちのこと！<br>でもね…
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_09_0030015")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力

	--★★フィエナ★★:信じられないことが起こるから奇跡なんだよ！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_09_0030016")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガラハッド★★:なるほど！<br>そのとおりですね、さすが姉上！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","PT2_01B_09_0030017")

	PlayAction(Actor002,"to  Std_Appl")
-- ▼直接出力
PlayPartVoice("フィエナ", "喜び")
-- ▲直接出力

	--★★フィエナ★★:でしょ？でしょ！？<br>だから期待してていいよ、ノワール！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT2_01B_09_0030018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:あ、ああ、うん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_09_0030019")

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
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
