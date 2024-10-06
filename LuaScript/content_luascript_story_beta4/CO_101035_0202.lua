-- このluaスクリプトは、CO_101035_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
set_rot(Actor002,{0,40,0})
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:こんなところで<br>なにをしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020002")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:ひゃああああああ！？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,-100,0.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
-- ▲直接出力

	--★★リリアーナ★★:ノ、ノ、ノワールさん！？どうしてここに…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020005")

	open_select_window_tag(Actor001,"Normal","CO_101035_02020007","CO_101035_02020008","CO_101035_02020009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:このあいだに続いて今日も避けられている気がしてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:もしも俺がなにか悪いことをしたのなら理由を聞かせてもらいたいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:いえいえいえっ！ノワールさんはなにも悪くないです！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020013")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それならいいんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここのところずっとコソコソしてるから気になっちゃってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020016")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:えぇっ！私、コソコソしてました？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああクレアが怪しむほどに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020018")

-- ▼直接出力
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あ、怪しむ…？私、そんなに変なことしてたでしょうか…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺から見てもちょっと怪しかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020020")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:うぅ…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020021")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Talk")
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:散歩の途中に偶然ここを通りかかったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020023")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:えっ？こんな場所まで、おひとりで散歩に…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020024")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:今日はやることもないし遠くまで行ってみようかな、なんて思って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020025")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ごめんリリアーナが気になって、あとをつけてきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020027")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:そうだったんですか…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020028")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:いつもひとりで来てるのか？ここにはなにがあるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020030")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:えっと、あの、その…畑…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020031")


	--★★ノワール★★:うん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020032")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★リリアーナ★★:少し離れたところに畑があるんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、確かに小さな畑があるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020035")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力

	--★★リリアーナ★★:畑を作らせてもらって、えっと…<br>野菜を育てているんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020036")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_No")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:お、おかしいですよね！こんなところに畑なんて…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020038")

-- ▼直接出力
PlayPartVoice("リリアーナ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:私、戦いは好きじゃないですし<br>…バルバロイが、怖いし…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020039")


	--★★リリアーナ★★:そんな私が少しでもお役に立てることってなんだろうって考えて…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020040")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:それで野菜を？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("リリアーナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:私、ローマの農村の生まれで子供の頃から畑仕事を手伝ってたんです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020043")


	--★★リリアーナ★★:コルベニック城にいたときも空いてる土地に畑を作らせてもらってました
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:あっ、すみません！どうでもいいことを長々と喋っちゃって
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020045")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:どうでもよくないよすごいことじゃないか！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020046")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力

	--★★リリアーナ★★:えっ？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020047")

	change_face(Actor001,"Normal")

	--★★ノワール★★:小さな畑とはいえひとりで耕して、ひとりで種を植えたんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020048")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:は、はい…そうです…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020049")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:みんなのために、というだけでそこまではなかなかできないと思う！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020050")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:よかったら、俺にもなにか手伝わせてくれひとりよりもふたりのほうがはかどるだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:えっ…いいんですか…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020052")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020054")

	open_select_window_tag(Actor001,"Normal","CO_101035_02020056","CO_101035_02020057")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:さあ、なにから手伝えばいい？どんなことでも言ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020059")

-- ▼直接出力
PlayPartVoice("リリアーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★リリアーナ★★:ええっ？今日からもう、ですか…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020060")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そりゃそうさこういうのは始めが肝心だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020061")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:そ、そうは言っても…なにがお願いできるか、考えさせてください
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020062")

	change_face(Actor002,"Normal")

	--★★リリアーナ★★:お手伝いしていただくのは次回からで結構ですよ
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020063")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか？わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020064")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、次に来たときからリリアーナの仕事を手伝うことにする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020066")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:はいお願いできそうなこと、考えておきますね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020067")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:力仕事を中心に振ってくれて構わないからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101035_02020068")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リリアーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:ふふっ畑仕事がこれまで以上に楽しみになってきました
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020070")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:でも、やろうと思っていたことはもう終わっちゃいましたので
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:今日は帰りましょう
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","CO_101035_02020072")

-- ▼直接出力
local trustParam = set_communication_rankup("リリアーナ_コミュランク", "リリアーナ_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
