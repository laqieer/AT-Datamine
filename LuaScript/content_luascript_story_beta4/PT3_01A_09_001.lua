-- このluaスクリプトは、PT3_01A_09_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ギネヴィア","挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:おはようございます、マスター
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_09_0010003")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0010004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:なによ、その顔！<br>似合ってないとでも言いたいわけ！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_09_0010005")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:それは違うっていうか<br>違わないっていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア","怒り")
-- ▲直接出力

	--★★ギネヴィア★★:まったくもう！<br>マスターとキラーズって関係になったんだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_09_0010007")


	--★★ギネヴィア★★:お姉ちゃんを見習って<br>少しはしおらしくしてあげようと思ったのに！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_09_0010008")

-- ▼直接出力
PlayPartVoice("ノワール","否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアは今までどおりでいいよ<br>今までどおりがいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0010009")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:そ、そう？<br>ノワールがそういうなら…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_09_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:他のみんなもＧＳ前と後で<br>話しかたを変えたなんて聞いたことないしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0010011")


	--★★ノワール★★:ガウェインのとことか<br>トリスタンのとかとかさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0010012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…ああ、そう<br>そういうことね、ハイハイ、わかったわ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","PT3_01A_09_0010013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
