-- このluaスクリプトは、PT3_01B_09_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:ノワール、調子はどうだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01B_09_001002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:おはよう、ランスロット<br>ケガならすっかり治ったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_001003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:むしろ前より元気なくらいだ<br>最強騎士とＧＳしたおかげかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_001004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力

	--★★ランスロット★★:そうか、それはなによりだ<br>ＧＳの影響がどこまであるかはわからないがな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01B_09_001005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:でも、正直に言うと<br>同時にプレッシャーも感じてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_001006")

	change_face(Actor002,"Surprise")

	--★★ランスロット★★:プレッシャー？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01B_09_001007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:最強騎士と言われる完璧なあんたを<br>キラーズにしたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_001008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:このあと、戦いであんたが負けたりなんかしたら<br>間違いなく俺とＧＳしたせいになる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_001009")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そんなことにプレッシャーを感じていたのか<br>大丈夫だ、心配はいらない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01B_09_001010")


	--★★ノワール★★:「最強騎士だから」か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_001011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:俺たちにはあの人が…<br>師匠がついていてくれるからだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01B_09_001012")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロット…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_001013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:ここに誓う<br>お前の武器として全身全霊を賭けてお前を護ると
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01B_09_001014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_001015")

-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:それに、感謝するなら俺のほうだ<br>こうしてお前と肩を並べて歩めるのだからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01B_09_001016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ノワール<br>今後ともよろしく頼む
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT3_01B_09_001017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こちらこそよろしく、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_001018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
