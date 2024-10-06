-- このluaスクリプトは、PT2_01_04_007.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:おはよう、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070005")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ディナタン<br>どうした？朝からなにかあったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0070006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:忘れ物を届けに来てあげたの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:今日の授業で使うって言ってたでしょ、これ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0070009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:今朝はドタバタしてたからな…<br>届けてくれてありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0070010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:どういたしまして
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:それにしても<br>よく俺の教室の場所がわかったな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0070012")


	--★★ディナタン★★:何年兄さんの面倒を見てると思ってるの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070013")

-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さんのことで<br>私がわからないことなんてないんだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それはそれは<br>ありがたいことで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0070015")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:…で？<br>逆に聞くけど、兄さんは私の教室知ってる？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070016")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うっ！？<br>それは、その…えーっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0070017")

-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:はぁ<br>そんなことだろうと思った
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:正解は１階！<br>兄さんの教室の下の階でした
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:なにか困ったことがあったら<br>いつでも相談に来ていいよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070020")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:それじゃね<br>授業頑張って
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01_04_0070021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ<br>ディナタンもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0070022")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
