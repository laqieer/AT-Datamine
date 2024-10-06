-- このluaスクリプトは、PT2_01B_10_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
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

	--★★ディナタン★★:長旅おつかれさま、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_10_0020004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンか…お疲れ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:まだ眠そうだね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_10_0020006")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:昨日ログレスに帰ってこれたのが<br>深夜だったからな。あんまり眠れてないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0020007")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力

	--★★ディナタン★★:そうなんだ<br>…で、成果はどうだったの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_10_0020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあまあってところかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0020009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:聖杯は見つからなかったけど<br>探索に進展がなかったわけじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0020010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:ふうん…<br>ランス兄ちゃんたちの班も昨日戻って来て
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_10_0020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:今日<br>円卓会議で情報を共有するって言ってたよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_10_0020012")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:そうなのか<br>ありがとう、教えてくれて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:うっかり<br>眠っちゃわないよう気をつけてね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_10_0020014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はは…あそこで寝たら<br>全員から怒鳴られそうだな。気をつけるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…でね。円卓会議が終わってからでいいんだけど<br>私の話も聞いてくれる？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_10_0020016")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタンの話？なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:ふふ…いろいろ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_10_0020018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:なんだよ、気になるじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01B_10_0020019")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力

	--★★ディナタン★★:楽しみにしてて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT2_01B_10_0020020")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
