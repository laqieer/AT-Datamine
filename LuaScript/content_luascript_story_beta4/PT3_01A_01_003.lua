-- このluaスクリプトは、PT3_01A_01_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("リリアーナ","挨拶")
-- ▲直接出力

	--★★リリアーナ★★:ノワールさん<br>あけましておめでとうございます
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_01_0030003")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:あけましておめでとう、リリアーナ<br>今年もよろしくな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0030004")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ","肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:は、はい！<br>こちらこそよろしくお願いします…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_01_0030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:リリアーナもエクセリアも<br>ずっとログレスにいてくれてるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0030006")


	--★★ノワール★★:たまにはコルベニック城に帰りたいって<br>思ったりしないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0030007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ","肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:ないって言ったらウソになりますけど<br>お城のみんなとは、時折手紙でお話してますし
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_01_0030008")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:帰ろうって思えば<br>帰れない距離でもないですからね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_01_0030009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ","悩む")
-- ▲直接出力

	--★★リリアーナ★★:それに<br>マターヤ…私のマスターからも
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_01_0030010")


	--★★リリアーナ★★:「今はログレスのみんなを助けてあげて」<br>って頼まれていますから
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_01_0030011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そっか<br>ありがとう、心強いよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0030012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ","肯定3")
-- ▲直接出力

	--★★リリアーナ★★:円卓の騎士と銀卓騎士団とで力を合わせて<br>この戦いに勝ちましょう！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_01_0030013")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:そして全部が終わったら<br>胸を張ってコルベニック城に凱旋です！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_01_0030014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★リリアーナ★★:そのときは、よかったら<br>ノワールさんも一緒に
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_01_0030015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…そうだな<br>それもいいかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_01_0030016")

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
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
