-- このluaスクリプトは、PT2_01C_11_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:フレン、ローラの様子はどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0060002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★フレン★★:命に別状はないみたい
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0060003")

	change_face(Actor002,"Normal")

	--★★フレン★★:だけど、イゾルデちゃんが<br>念のためにもう少し休ませたほうがいいって
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","納得")
-- ▲直接出力

	--★★ノワール★★:そうか<br>それならよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0060005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア","落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラシア★★:ヴェルナルス様は…無事でしょうか
	Talk(Actor003,"CHRNAME_RASIA","speech","L","PT2_01C_11_0060006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン","肯定2")
-- ▲直接出力

	--★★フレン★★:きっと大丈夫だよ、ラシア<br>先生がそんな簡単にやられるわけないもん
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0060007")

-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:今回の相手は魔女だ<br>焦って乗り込んでも返り討ちにされる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0060008")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ラシアが心配する気持ちはよくわかるけど<br>しっかり準備を整えないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0060009")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア","悲しみ")
-- ▲直接出力

	--★★ラシア★★:でも…！
	Talk(Actor003,"CHRNAME_RASIA","speech","L","PT2_01C_11_0060010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ヴェルナルス先生の強さは<br>ラシア、キミが一番よくわかってるはずだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0060011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ローマにその人ありとうたわれた大将軍だ<br>きっと大丈夫
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0060012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ラシア★★:…そうですね<br>こういうときこそ冷静でいなきゃ
	Talk(Actor003,"CHRNAME_RASIA","speech","L","PT2_01C_11_0060013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン","肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ラシア、出撃の準備を進めてるみんなの<br>お手伝いに行こうよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","PT2_01C_11_0060014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア","肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラシア★★:うん！
	Talk(Actor003,"CHRNAME_RASIA","speech","L","PT2_01C_11_0060015")

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
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
