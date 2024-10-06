-- このluaスクリプトは、PT2_01A_10_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:遅え！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01A_10_0020005")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんだよ朝からいきなり…？<br>とりあえず、おはようマルディサント
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_10_0020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:おはよーさん
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01A_10_0020007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★マルディサント★★:…じゃねえ！<br>ゆっくりしてる時間なんてねえんだよ！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01A_10_0020008")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:さっさと準備しな<br>出かけんぞ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01A_10_0020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:出掛けるって、どこへ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_10_0020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:学園だよ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01A_10_0020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力

	--★★マルディサント★★:衣装とか舞台の立ち位置とか<br>打ち合わせすることが山ほどあんだ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01A_10_0020012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:え？<br>いや、俺は木の役でセリフもあんまりないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_10_0020013")


	--★★ノワール★★:時間まで会場を<br>見て回ろうと思ってたんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_10_0020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:役の大小を逃げ道にすんな！<br>芝居ってのは、全員で作ってくもんだ！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01A_10_0020015")


	--★★マルディサント★★:ひとりでもタルんでるヤツがいたら<br>そこから芝居全体がタルんじまう
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01A_10_0020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★マルディサント★★:さっさと学園に来い！<br>アタシがオニーサンの根性を叩き直してやる
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT2_01A_10_0020017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ハ、ハイ…<br>（さすが当日。いつもにも増して怖い…）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_10_0020018")

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
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
