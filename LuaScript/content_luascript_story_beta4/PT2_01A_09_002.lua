-- このluaスクリプトは、PT2_01A_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:よう、ノワール<br>おはようさん！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01A_09_0020005")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…えっ、アーサー！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_09_0020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "照れ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:そう驚かなくてもいいだろう<br>義兄さんもたまにここに来ていると聞くぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01A_09_0020007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そう言われてみれば<br>何回かここでイヤミを言われたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_09_0020008")


	--★★アーサー★★:イヤミ？<br>…ああ、そうか。義兄さんらしいな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01A_09_0020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで？<br>俺になにか用なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_09_0020010")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:お前だけにというわけじゃないんだが<br>急いで伝えておかねばならないことがあってな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01A_09_0020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_09_0020012")

	change_face(Actor002,"Sad")

	--★★アーサー★★:実はな…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01A_09_0020013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:今日は休校だ！<br>一日自由に過ごしていいぞ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01A_09_0020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…は？<br>休校？なんで？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_09_0020015")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:国葬の準備やらなんやらで<br>みんな疲れているんじゃないかと思ってな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01A_09_0020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:たしかにちょっと疲れてはいるけど<br>ずいぶん急だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_09_0020017")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:昨日思いついたアイデアだからな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01A_09_0020018")

	change_face(Actor002,"Normal")

	--★★アーサー★★:…またすぐ戦いになる<br>だからこそ、今という時間を大事にしてほしい
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","PT2_01A_09_0020019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>この休日、大事に使わせてもらうよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_09_0020020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
