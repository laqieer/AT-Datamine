-- このluaスクリプトは、MA_01B109_22.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",27,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera004 = SetTemplate("Actor004",-31,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("103030010", "content_still_10303001_image", "103030010_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("VO_story01_op")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガラハッド★★:姉上<br>ガラハッドたちは今どこへ向かって？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220002")

	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フィエナ★★:クイズ！<br>どこでしょうっ？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220003")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガラハッド★★:姉上ぇ～？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★フィエナ★★:私はあくまで妖精の受け皿だから<br>聖杯の場所もぼんやりとしかわからないの
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220005")


	--★★フィエナ★★:ブリテンという空間に生じる僅かな歪み…<br>それをおぼろげに感じ取れるだけ
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220006")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力

	--★★フィエナ★★:湖に石を落としてできる波紋が<br>水面に浮かんだ異物によってかたちを変える…
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220007")


	--★★フィエナ★★:その変化を探知する…みたいな感じかなっ
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_220009","MA_01B109_220010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その異物のある場所が<br>聖杯の所在地だってわけか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フィエナ★★:うん、そう
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220013")

	change_face(Actor004,"Normal")

	--★★フィエナ★★:波紋の反応が早くやってきてるから<br>目的地は近づいてきてるはず
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:頼もしいことだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_220015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:驚きだ<br>フィエナにこんな力があったなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…すごいな、フィエナは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220018")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガラハッド★★:そうだろう！すごいだろう姉上は！！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220019")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★フィエナ★★:もっと言ってもっと褒めて～
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220020")

	change_face(Actor003,"Normal")

	--★★ガラハッド★★:姉上がこの力を発揮するのを見るのは初めてだ<br>詳しくは知らなかったが…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220021")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガラハッド★★:どうだ！すごいぞ姉上は！！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220022")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★フィエナ★★:ただ、ちょっと気になることもあって
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220024")


	--★★フィエナ★★:ノワールがGSを果たした瞬間<br>ブリテンで聖杯が顕現するのを感じたの
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220025")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:継承者の覚醒とともに<br>聖杯が現れたと？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フィエナ★★:だけど今はその場所がちゃんと特定できないの<br>異物感が何か所にも分散しているような感じ
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:とすると俺たちが今向かっている場所は<br>聖杯があるかもしれない候補地のひとつか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_220029")

	PlayAction(Actor004,"to  Std_Angry")

	--★★フィエナ★★:わああ！！だぁってだってはじめてなんだもん！<br>もお聖杯探すとかフツーの人しないでしょお！？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_220032","MA_01B109_220033")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:フィエナのおかげですごく助かってるよ<br>ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220035")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★フィエナ★★:そ、そう？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220036")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガラハッド★★:そうだ<br>姉上の助けなしでは聖杯のもとへ行けない
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220037")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:泣かせるなよ、ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220039")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:責めたつもりなどないが…<br>そうとられてしまったのなら謝る
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_220040")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:すまん、フィエナ<br>たしかに聖杯を探すなんてめったにない経験だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_220041")

	goto Block2end

::Block2end::
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★フィエナ★★:フィエナちゃんなりに頑張ってるんだからッ！<br>妖精がいればもっと正確にわかるかもだけども！
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220043")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:姉上…ガラハッドはまだ納得し切れていません
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220044")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★フィエナ★★:が、がらはっどぉ…！<br>あなたも私のガイドが不満なのぉ…？？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガラハッド★★:妖精は誰が殺したのです？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220047")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:！<br>それ、は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220048")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:ガラハッドはそれが知りたい
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220050")


	--★★ガラハッド★★:世の混乱を避けるために秘匿された話だとしても<br>銀卓騎士団は聞かされてきた話のはず
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220051")


	--★★ガラハッド★★:我らの結成は『妖精殺し』がキッカケなのだから<br>お爺様も銀卓の皆もその代わりになるべく集った
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:………ああ、そうだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_220054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガラハッド★★:けど、だけど！<br>『妖精殺し』が誰か…思い、出せない
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220055")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220057")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガラハッド★★:どうして妖精が殺される必要があった？<br>『妖精殺し』の弟子とその息子が負う責は？
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")

	--★★フィエナ★★:ガラハッド、もういいでしょ…？<br>きっと彼らも──
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B109_220061")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "怒り")
-- ▲直接出力

	--★★ガラハッド★★:妖精が生きていれば<br>姉上が戦場に駆り出されることもなかったはずだ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220062")


	--★★ガラハッド★★:『妖精殺し』がいなければ<br>聖杯はすぐ見つかって、バルバロイも根絶出来て
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220063")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:…コルベニック城が落ちることも<br>なかったんだ…！
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_220065","MA_01B109_220066")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰がバルバロイの手引きをしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220068")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:ライエンス王だ<br>身も心もバルバロイの化け物になっていた
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220069")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:なんだって！？<br>俺たちが倒し切れていなかったということか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_220070")

	change_face(Actor003,"Normal")

	--★★ガラハッド★★:最強騎士がそんなヘマをするとは思っていない<br>恐らくはライエンスの遺体を蘇生した者がいる
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220071")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺たちが力不足なばかりに…すまない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220073")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:うぬぼれるな<br>お前たちの強さはわかっているつもりだ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220074")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:原因はむしろ<br>ガラハッドたちにあるのかもしれない…
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220075")

	goto Block3end

::Block3end::
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:もうガラハッドに帰る故郷はない
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220077")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:ガラハッドが銀卓騎士として<br>どうすればよかったのか、それもわからない
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B109_220078")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_220079")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103030010", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたの口から<br>本当のことが聞きたくて
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01B109_230002")


	--★★ノワール★★:家族で卓を囲める<br>それだけの日常に帰りたくて
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01B109_230003")


	--★★ノワール★★:あんたを追って<br>ここまで来たんだ…！！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01B109_230004")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103030010", "content_still_10303001_image", "103030010_StillImage")
preload_sound("VO_story01_op")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
