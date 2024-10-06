-- このluaスクリプトは、AV_01_101035.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_sequence_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力

	--★★リリアーナ★★:あの～、すみません…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いらっしゃい、リリアーナ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0002")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あれっ、ノワールさん！？<br>ここってマルイルさんのお店ですよね…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、そうだよ<br>俺はたまにここで店番をしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0004")

	change_face(Actor002,"Laugh")

	--★★リリアーナ★★:そうだったんですか<br>びっくりしました…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0005")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:それで？<br>今日はなにを買いにきたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力

	--★★リリアーナ★★:は、はい…ナスを栽培してみようと思って<br>種と肥料を買いに来ました
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:種と肥料だな<br>ナスの種はこれで、肥料は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0008")


	--★★ノワール★★:（有機肥料と無機肥料？２つあるけど<br>どっちを渡せばいいんだ…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","AV_01_101035_0009")

	open_select_window_tag(Actor001,"Normal","AV_01_101035_0010","AV_01_101035_0011","AV_01_101035_0012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:有機肥料でいいよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:わあ、ありがとうざいます…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0015")

	change_face(Actor002,"Laugh")

	--★★リリアーナ★★:ノワールさん<br>肥料についても詳しいんですね！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0016")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:（よかった、合ってたみたいだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","AV_01_101035_0017")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:うまく育てられるといいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0018")

-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★リリアーナ★★:は、はい…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★リリアーナ★★:ノワールさん、ナスができたら<br>食べてくれますか？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:もちろんさ<br>楽しみに待ってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0021")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:がんばります！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:無機肥料のほうが効き目がありそうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0024")

-- ▼直接出力
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あ、ご、ごめんなさい…<br>ナスには有機肥料のほうが…いい、です…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0025")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ、そうなのか！？<br>ごめん…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:い、いえ…<br>ちゃんと言わなかった私が悪いんです…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0027")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、知ったかぶりをした俺のほうが悪いよ<br>ちゃんとリリアーナに聞くべきだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0028")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（恥ずかしいところを見せてしまった…<br>もっと勉強しないとな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","AV_01_101035_0029")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺、どっちの肥料が良いのかわからなくて…<br>悪いんだけど、リリアーナが選んでくれるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あっ、はい！<br>それじゃあ、こっちの有機肥料でお願いします
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:かしこまりました、有機肥料ですね<br>お買い上げありがとうございます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0033")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:ふふっ、ノワールさん<br>サマになってますよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0034")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ほんとか？<br>なら、いいんだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0035")

	PlayAction(Actor001,"to Bow")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それじゃあ…またのお越しを<br>お待ちしております
	Talk(Actor001,"CHRNAME_NOIR","speech","L","AV_01_101035_0036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:はい、また来ますね！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","AV_01_101035_0037")

	goto Block1end

::Block1end::
-- ▼直接出力
local commu = system.GetCommu() -- 実行中コミュ
local commuChara = commu.GetCharacter()
kizuna_gaugeup_encount(Actor002,commuChara.CharaName)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_sequence_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
