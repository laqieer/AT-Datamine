-- このluaスクリプトは、PT2_01A_12_001.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やれやれ。戦いを終えて夜に帰還しても<br>翌日の授業が免除になったりはしないんだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_12_0010004")

-- ▼直接出力
PlayPartVoice("ランスロット","肯定3")
-- ▲直接出力

	--★★ランスロット2★★:疲弊しているのは理解しているつもりだが<br>だからといって特別扱いはしてやれない
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","PT2_01A_12_0010006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロット！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_12_0010007")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:もう動いて大丈夫なのか？<br>スノードンの戦いで重傷を負ったって聞いたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_12_0010008")

-- ▼直接出力
PlayPartVoice("ランスロット","笑い")
-- ▲直接出力

	--★★ランスロット★★:言っただろう？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT2_01A_12_0010009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:疲弊していようがケガをしていようが<br>特別扱いはない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT2_01A_12_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ…あんたらしいっていうか<br>そんだけ元気なら心配はいらないみたいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_12_0010011")

-- ▼直接出力
PlayPartVoice("ランスロット","肯定")
-- ▲直接出力

	--★★ランスロット★★:ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT2_01A_12_0010012")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、無理はするなよ<br>皆、心配してたんだからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_12_0010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット","笑い")
-- ▲直接出力

	--★★ランスロット★★:お前こそ。休めるときは<br>しっかり体を休めておくんだぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT2_01A_12_0010014")

-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:じゃあ、今日くらい授業は…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_12_0010015")

-- ▼直接出力
PlayPartVoice("ランスロット","否定")
-- ▲直接出力

	--★★ランスロット★★:くどい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT2_01A_12_0010016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ハイハイ、わかりましたよ<br>ランスロット先生
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_12_0010017")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
