-- このluaスクリプトは、PT3_01B_11_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:おはようございます、ノワールさん
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_11_004002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、ディンドランさん<br>これから司書の仕事ですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_004003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:いえ、遠征が近そうですのでその準備を<br>主にパーシヴァル様のものを、ですけれど
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_11_004004")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なるほど…<br>俺もいろいろ準備しておいたほうがいいかなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_004005")

-- ▼直接出力
PlayPartVoice("ディンドラン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:出かける直前に「あれがない」と騒ぎ立てては<br>ご同行される皆さんに迷惑がかかりますからね
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_11_004006")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ああ～…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_004007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディンドラン★★:今、「パーシヴァルがやりそう」<br>と思われましたね？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_11_004008")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:い、いえ！<br>そういうわけじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_004009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:そういう表情をしていらっしゃいましたよ？<br>ふふっ
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_11_004010")

	change_face(Actor002,"Normal")

	--★★ディンドラン★★:ノワールさん、ありがとうございます<br>あの子…パーシヴァル様と仲良くしてくださって
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_11_004011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:あなたが学園にいらっしゃってから<br>パーシヴァル様はとても明るくなりました
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_11_004012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ、そうなんですか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_11_004013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★ディンドラン★★:あっ！私がこんなことを言ってたって<br>パーシヴァル様には黙っていてくださいね？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_11_004014")

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
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
