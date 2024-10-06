-- このluaスクリプトは、PT2_01C_11_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
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
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力

	--★★パーシヴァル★★:やぁ、ノワール<br>ディナタンの具合はどうだい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01C_11_0030002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:おかげさまで、もうすっかりよくなったよ<br>まだ無理はさせられないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "納得")
-- ▲直接出力

	--★★パーシヴァル★★:それはなにより<br>急に倒れたときは、どうなることかと思ったよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01C_11_0030004")


	--★★ノワール★★:あのときはありがとう<br>ディナタンの救助を手伝ってくれて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0030005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:なあに、礼にはおよばない<br>貴族として当然の務めを果たしたまでさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01C_11_0030006")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ま、しかし、最後に少しハプニングはあったけど<br>学園祭は概ね成功したと言っていいだろう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01C_11_0030007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★パーシヴァル★★:ひとえに、通しでＭＣを務めた<br>ぼくの貢献が大きいだろうがね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01C_11_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタンのステージ以外も<br>お前がＭＣをやってたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_11_0030009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:もちろんだとも<br>ぼく以外に誰に務まるね？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01C_11_0030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ぼくの軽妙なトークに<br>社交界ならず市井の人々も大満足！拍手喝采！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","PT2_01C_11_0030011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（暇なのかな？パーシヴァル…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01C_11_0030012")

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
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
