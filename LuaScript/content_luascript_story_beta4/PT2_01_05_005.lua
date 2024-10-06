-- このluaスクリプトは、PT2_01_05_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
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

	--★★ティルフィング★★:マスター、おかえりなさい
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_05_0050005")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ティルフィング？<br>…ただいま
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0050006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:このあいだの任務はお疲れ様<br>おかげで助かったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0050007")

-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:いえ<br>みなさんもご無事でなによりでした
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_05_0050008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:なあ、キミはどう思う？<br>ギネヴィアのお父さん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0050009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、キャメリアード城が<br>現在どうなっているかについて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0050010")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:私があの祭壇にいた頃に比べて<br>バルバロイの気配が増している気がします
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_05_0050011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:…生存者がいる可能性は<br>かぎりなくゼロに近いかと
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_05_0050012")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0050013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:でも、まだゼロじゃないよな？<br>どこかに逃げ延びてることもありえるよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0050014")


	--★★ティルフィング★★:マスター…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT2_01_05_0050015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:力になってやりたいんだ<br>ギネヴィアの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_05_0050016")

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
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
