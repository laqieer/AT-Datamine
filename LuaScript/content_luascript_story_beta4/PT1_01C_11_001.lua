-- このluaスクリプトは、PT1_01C_11_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_02","110071_02_h")
Include("content_adv_advsmall_110071_02","Template110071_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_006)
	InitializeTemplateRandomCamera110071_02()
	InitializeTemplate110071_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115080)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★真面目な男子生徒★★:それにしても<br>ハロウィンのパレードには驚いたね
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01C_11_0010004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "肯定2")
-- ▲直接出力

	--★★気取った男子生徒★★:ああ<br>まさか本物の魔女が紛れ込んでいるなんてな
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01C_11_0010005")


	--★★気取った男子生徒★★:あのとき、マーリンさんが<br>魔女を退けてくれたって話だけど
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01C_11_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "悩む")
-- ▲直接出力

	--★★気取った男子生徒★★:ひょっとしてマーリンさんも魔女だったりして<br>あの人、すごい魔法いっぱい使えるんだろ？
	Talk(Actor002,"NPCNAME_0174","speech","L","PT1_01C_11_0010007")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★真面目な男子生徒★★:まさか！
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01C_11_0010008")

	PlayAction(Actor003,"to  Std_Talk")

	--★★真面目な男子生徒★★:…とは言いいたいところだけど<br>ここのところ信じられないことが連続してるよね
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01C_11_0010009")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★真面目な男子生徒★★:僕もそんな気がちょっぴりしてるんだ
	Talk(Actor003,"NPCNAME_0113","speech","L","PT1_01C_11_0010010")

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
	load_area_scene_preload(115080)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
