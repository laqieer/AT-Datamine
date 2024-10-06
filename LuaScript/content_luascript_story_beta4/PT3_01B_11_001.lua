-- このluaスクリプトは、PT3_01B_11_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:よう、ノワール！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001002")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:聖杯見つからなかったみてーだけど<br>魔女をやっつけられたのはよかったな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そっちこそ<br>ローマの策略を打ち破ったそうじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_001004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:あの程度、朝メシ前だぜ<br>太陽が昇ってなくたってラクショーラクショー
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001005")

	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:学園祭も控えてたしな！…って悪い<br>お前は参加できなかったんだったっけ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:しかたないさ<br>ガウェインたちは楽しめたんだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_001007")


	--★★ノワール★★:劇をやったって聞いたけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_001008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:そうそう！すっげー盛り上がったぜ！<br>俺も出させてもらったんだ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001009")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ…なんの役だったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_001010")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:太陽だ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:は…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_001012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガウェイン★★:だーかーら！太陽！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:太陽って…空にある、あの？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_001014")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:そう！その太陽！<br>俺にピッタリだろ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001015")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:太陽の役って…その場にいるだけなんじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_001016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:芝居ナメんなッ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001017")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え、ええ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_001018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:役に大小はねーっ！<br>舞台の上にはリアルが溢れてンだ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001019")


	--★★ガウェイン★★:生い立ちから未来への人生設計まで考えなきゃ<br>芝居はできねー！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001020")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:そう教えてくれたのさ、演出家が…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:だから俺も役者の端くれとして<br>精一杯やらせてもらったぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01B_11_001022")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ノワール★★:（どこから突っ込んでいいのかわからない…！）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT3_01B_11_001023")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
