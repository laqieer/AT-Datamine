-- このluaスクリプトは、PT3_01A_09_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("エクセリア","挨拶")
-- ▲直接出力

	--★★エクセリア★★:ノワール、おはよう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT3_01A_09_0020003")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:やあ、エクセリア<br>おはよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:どうだ、ログレスや学園での生活は？<br>やっていけそうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0020005")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エクセリア","否定")
-- ▲直接出力

	--★★エクセリア★★:慣れるにはもう少し時間がかかりそうよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT3_01A_09_0020006")


	--★★エクセリア★★:コルベニック城とこことでは<br>住んでいる人の数が違いすぎるから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT3_01A_09_0020007")


	--★★エクセリア★★:でも、授業や大図書館にある本から<br>新しい知識を得られるのはとても楽しいわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT3_01A_09_0020008")

-- ▼直接出力
PlayPartVoice("エクセリア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:アダンが私をここに来させた理由が<br>なんとなくわかってきた
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT3_01A_09_0020009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:そうか<br>それはよかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:こんな経験はめったにできるものではないし<br>いろいろと勉強させてもらうわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT3_01A_09_0020011")


	--★★エクセリア★★:その代わりと言ってはなんだけど<br>私にできることならなんでも協力するから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT3_01A_09_0020012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力

	--★★ノワール★★:ありがとう<br>頼りにさせてもらうよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:それから…よかったら<br>リリアーナのことも気にかけてあげてほしいの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT3_01A_09_0020014")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:あの子はちょっと人見知りだから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","PT3_01A_09_0020015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>見かけたら、声をかけてみるようにするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0020016")

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
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
