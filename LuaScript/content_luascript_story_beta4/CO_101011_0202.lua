-- このluaスクリプトは、CO_101011_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101011","001","101011001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:このあいだも来たけど<br>アストラット郷はのどかでいいですね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力

	--★★ギネマウア★★:そうですね<br>ログレスのような都会も賑やかでいいですけれど
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020004")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Surprise")

	--★★ギネマウア★★:田舎育ちの私としては<br>このくらいのほうが落ち着きます
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:あの子は<br>「退屈でつまんない！」と思っているかも
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020006")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はは<br>ありえますね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020007")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:…でも、キャメリアードって<br>昔は炭鉱で賑わっていたと聞きますし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020008")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★ノワール★★:田舎ってほどでもないんじゃないですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020009")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…あっ！？あの、すみません<br>なんか余計なこと聞いちゃって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020010")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "照れ")
-- ▲直接出力

	--★★ギネマウア★★:いえ、お気になさらないでください
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020011")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネマウア★★:賑やかといえば賑やかでしたけど<br>荒っぽい肉体労働者ばかりでしたからね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020012")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ギネマウア★★:ログレスやロンディニウムと比べたら<br>都会的だなんてとても言えませんよ
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも…いい国だったんですよね？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020014")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:はい、それはもう
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020015")

-- ▼直接出力
set_common_look_at(Actor003,Actor002)
set_common_look_at(Actor001,Actor002)
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネヴィア2D★★:買って来たわよー<br>特産のミルクを使ったソフトクリー…
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020017")

-- ▼直接出力
change_face(Actor003, "Surprise")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")
	change_face(Actor004,"Surprise")

	--★★ギネヴィア2D★★:ムッ！？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","N","CO_101011_02020018")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_IN_OUT)
se_play("SE_ADV_CO_101011_0202_Bodyfall")
wait_time(IMAGE_TIME_WAIT_BEFORE) 
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
Appear(Actor002)
change_face(Actor002,"Sad")
setup_small_camera_start()
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image()
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:いたた…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020020")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:ああ<br>せっかくのソフトクリームが地面に…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020021")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:調子に乗ってはしゃぐから<br>転ぶんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020022")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:少しくらい<br>いたわってくれたっていいじゃない！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:だいたいどうして<br>わたしがお使いに行くのよ！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020024")

	open_select_window_tag(Actor001,"Normal","CO_101011_02020026","CO_101011_02020027")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ソフトクリームを食べようって言いだしたのは<br>キミだからだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020029")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は食べたいとは言ってないし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:私はダイエット中ですし
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キミがジャンケンで負けたからだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:負けた人がおごるって約束だったし<br>おごる人が買いに行って当然だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020034")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:１０戦全敗でしたわね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020035")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:「泣きの１回！」をあそこまで<br>連発されたのは初めてだったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020036")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Angry")

	--★★ギネヴィア★★:うるさいうるさーい！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020038")


	--★★ギネヴィア★★:せっかく<br>今日はプレゼントを持ってきたのに
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020039")


	--★★ギネヴィア★★:あげるのやめようっと
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020040")

	open_select_window_tag(Actor001,"Normal","CO_101011_02020042","CO_101011_02020043","CO_101011_02020044")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ごめん！<br>俺が悪かった！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…心から謝っている気が<br>しないんだケド
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020047")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:まあいいわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020048")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにをくれるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020050")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あげるのやめようって言ったの<br>聞いてなかった！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020051")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…ま、今日のところは<br>許したげるけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020052")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:そもそもノワール様が<br>怒られる理由はありませんしね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020053")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:別にいらない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020055")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ムッ。そういわれると<br>あげたくなっちゃうじゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020056")

-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:単純ですこと
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_02020057")

	goto Block2end

::Block2end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:はい、これ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020059")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…コイン？<br>このあたりで使われてるものじゃないっぽいけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020061")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:ラッキーコインの一種でね<br>持ち主に幸運をもたらしてくれるの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:幸せな出来事がつづけば<br>ノワールの笑顔も増えるんじゃないかなって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020063")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:いいのか？<br>こんなのもらっちゃって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020064")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:ダイジョウブよ<br>ぜんぜん珍しいものじゃないから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020065")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう、嬉しい<br>大切にするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020067")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…さっそく笑顔になってくれた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020068")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_02020069")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:にししっ♪<br>また今度、遊びに行こうね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_02020070")

-- ▼直接出力
local trustParam = set_communication_rankup("ギネヴィア_コミュランク", "ギネヴィア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
