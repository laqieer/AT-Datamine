-- このluaスクリプトは、PT2_01C_12_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ルーシャス？<br>なにしてるんだ、朝からこんなところで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_12_0020002")

-- ▼直接出力
PlayPartVoice("ルーシャス","肯定")
-- ▲直接出力

	--★★ルーシャス★★:怪我をしたローマの民を<br>休ませる場所がないということだったのでな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ルーシャス★★:余の寝床を開放してやったところ<br>自分の休む場所がなくなってしまったのだ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ルーシャス","悩む")
-- ▲直接出力

	--★★ルーシャス★★:余としたことが迂闊であった
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:意外だな<br>自分以外の人間はどうでもいいと思ってるかと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_12_0020006")

	change_face(Actor002,"Anger")

	--★★ルーシャス★★:…フン
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:張り合いというのは大事だな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_12_0020009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ルーシャス","肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ルーシャス★★:駒を根こそぎ奪ってしまったあとのゲームは<br>退屈でかなわなかったよ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ルーシャス★★:あの竪琴の小僧風に言えば<br>「縛りプレイ」という遊び方をするしかなくなる
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020011")


	--★★ノワール★★:（竪琴の小僧ってトリスタンのことか？<br>…小僧ってほどの年齢差はないと思うけど）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01C_12_0020012")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:で？<br>縛りプレイしてみての感想はどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01C_12_0020013")

-- ▼直接出力
PlayPartVoice("ルーシャス","肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ルーシャス★★:自分の駒の動かしかたを考えているときは<br>心が躍る
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:実に愉しい<br>眠る時間すら惜しいよ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ルーシャス★★:大きな達成感を得るためには<br>あえて遠回りすることが必要なのだな
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020016")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ルーシャス","笑い")
-- ▲直接出力

	--★★ルーシャス★★:感謝せねば<br>それを教えてくれたヤツらに
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","PT2_01C_12_0020017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
