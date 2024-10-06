-- このluaスクリプトは、PT2_01B_01_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ブレイズ先生？<br>こんなところに来るなんて珍しいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0030002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "笑い")
-- ▲直接出力

	--★★ブレイズ★★:少し研究が行き詰ってしまってのう<br>ちょっとした気分転換じゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT2_01B_01_0030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:研究のしすぎで体を壊さないでくれよ？<br>マーリンさんも心配してたぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0030004")

-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:あの子は優しいのう…<br>だからこそ、余計に胸が痛む
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT2_01B_01_0030005")


	--★★ブレイズ★★:アーサー王を救う手立てを<br>見つけてやれなかったことが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT2_01B_01_0030006")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:それは先生のせいじゃないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0030007")

-- ▼直接出力
PlayPartVoice("ブレイズ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:こんなことになるのなら<br>ふたりは出会わんほうがよかったかもしれんの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT2_01B_01_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:…いや、俺はそうは思わない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0030009")

-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:ほう？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT2_01B_01_0030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:俺はブレイズ先生ほど<br>ふたりとの付き合いは長くないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0030011")


	--★★ノワール★★:それでもふたりが<br>お互いを大切に思っていたことくらいはわかる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0030012")


	--★★ノワール★★:ふたりがともに過ごした時間は<br>かけがえのないものであり、失われないものだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0030013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:絆は尽きることのない力になってくれるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_01_0030014")

-- ▼直接出力
PlayPartVoice("ブレイズ", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:ノワール…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT2_01B_01_0030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:そうじゃの！<br>そうに違いないわい！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT2_01B_01_0030016")

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
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
