-- このluaスクリプトは、PT3_01C_09_001.csv の ADV シートから自動生成されました --
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
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さん、おはよう！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_09_001002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おはよう、ディナタン<br>朝からなにを急いでるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_001003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:私、兄さんのキラーズになったから<br>今まで以上に強くならきゃいけないでしょ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_09_001004")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ディナタン★★:だからランス兄ちゃんに<br>剣の稽古をつけてもらおうと思って！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_09_001005")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:あっ、兄さんも一緒にくる？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_09_001006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:ランス兄ちゃんも<br>喜んで相手してくれると思うよ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_09_001007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、今はやめとくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_001008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ディナタン、頑張るのはいいけど<br>あまり無理はするなよ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_09_001009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:…ありがとう<br>でも決めたんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_09_001010")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:これからは私が兄さんを守るんだって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_09_001011")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…あっと！ランス兄ちゃんを待たせちゃう<br>じゃ、私はこれで行くね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_09_001012")

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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
