-- このluaスクリプトは、PT2_01_04_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:おはようございます、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_04_0030006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ティルフィング<br>なにしてたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0030007")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:学園内にある遺跡に行こうと思っていました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_04_0030008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:遺跡？<br>…ああ、食堂の先にあるあそこか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0030009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:はい<br>あの場所にいると、不思議と気持ちが安らぎます
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_04_0030010")


	--★★ティルフィング★★:物思いにふけりながら歩いていて<br>気付いたらあの場所にいたこともあるくらいです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_04_0030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:へえ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0030012")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:そこまで行くと<br>遺跡がキミを呼んでいるような気すらするな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0030013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力

	--★★ティルフィング★★:ふふっ<br>そうかもしれません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_04_0030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:今度、俺も心を落ち着けたいときは<br>遺跡に行ってみようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0030015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい、ぜひ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_04_0030016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:（ティルフィングは<br>遺跡にいることが多いのか）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01_04_0030017")


	--★★ノワール★★:（今度見かけたら<br>声をかけてみようかな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01_04_0030018")

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
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
