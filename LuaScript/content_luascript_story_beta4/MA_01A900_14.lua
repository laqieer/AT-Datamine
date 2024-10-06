-- このluaスクリプトは、MA_01A900_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_03","110061_03_h")
Include("content_adv_advsmall_110061_03","Template110061_03_h")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",75,CharaPos110061_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_004)
	Camera003 = SetTemplate("Actor003",-73,CharaPos110061_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_001)
	InitializeTemplateRandomCamera110061_03()
	InitializeTemplate110061_03()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101063","001","101063001")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:そんな仲間たちの想いを受けて<br>ギネヴィアは少しだけ勇気づけられたのだった
	Talk(Actor005,"telop","narration","N","MA_01A900_141001")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01A900_141002")


	--★★テロップ★★:…ノワール様？<br>その節は大変お世話になりました
	Talk(Actor005,"telop","narration","N","MA_01A900_141003")


	--★★テロップ★★:ご丁寧にどうも
	Talk(Actor005,"telop","narration","N","MA_01A900_141004")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	PlayAction(Actor003,"to Bow")
-- ▼直接出力
 --PlayPartVoice("マーリン", "挨拶")
-- ▲直接出力

	--★★マーリン★★:…ノワール様？<br>その節は大変お世話になりました
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140002")

	open_select_window_tag(Actor001,"Normal","MA_01A900_140004","MA_01A900_140005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ご、ご丁寧にどうも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140007")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:御礼を幾度繰り返しても足らぬほど<br>ノワール様には重責を背負わせています
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140008")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★マーリン★★:むしろ言葉のみでは申し訳ないほど
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なにか調べものですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140011")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:…貴方の調べものは<br>ギネヴィア様の救済策、でしょうか？
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:諦め切れません
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140013")

-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:…となれば、これは残酷な報せかもしれません
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140014")

	goto Block1end

::Block1end::
	change_face(Actor003,"Anger")

	--★★マーリン★★:もうすぐ<br>『サラスの都』への門が開きます
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140016")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:サラス…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140017")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:私が儀式により開門させます<br>継承者はサラスにて聖杯を安置するのです
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:開門の儀式とは…どうやって？<br>ルーシャスですら入れなかったのに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140020")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:…ノワール様<br>あなたの日頃の行いによるもの、です
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140021")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:徳を積むような？<br>…いや、それはないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140022")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:似たようなものです。あなたの戦いの結果が<br>私に儀式を行う決意をさせました
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140024")

	change_face(Actor003,"Sad")

	--★★マーリン★★:サラスに至れば聖杯は継承者の帰還を歓迎し<br>貴方のキラーズは聖域化の義務を負う
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★マーリン★★:…確かなのは、貴方は多くの者と絆を結び<br>聖杯から力を借りられる存在になったということ
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:継承者として<br>相応しい存在であるということです
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ギネヴィアや仲間のおかげです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140029")


	--★★マーリン★★:ですから私もエクスカリバーとして<br>この歴史に遺る決意が出来た
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140031")


	--★★マーリン★★:こっそりですけど<br>本当を言えばですよ？
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140033")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:コワくて仕方なかったんです<br>いろいろと
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140035")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それはそうですよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140036")


	--★★マーリン★★:それに、アーサー様はこの図書院の本<br>「全部俺のだ」と大威張りされますがね？
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140038")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Normal")

	--★★マーリン★★:半分くらい私のですからぁーーっ！<br>私はここで本の虫でいたかったあーーーっ！
	Talk(Actor003,"CHRNAME_MERLIN","speech","N","MA_01A900_140040")

	close_cutin()
-- ▼直接出力
 --PlayPartVoice("クリスティーナ", "怒り")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor004,"Anger")

	--★★クリスティーナ★★:ちょっとぉー！うるさいわよ！<br>図書院内ではお静かに！！
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","N","MA_01A900_140042")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,93.6,1.0)
wait_time(1.0)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マーリン★★:………もうしわけ、ございませんでした
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140044")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クリスティーナ", "肯定3")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor004,"Anger")

	--★★クリスティーナ★★:謝罪がなってないわよ！<br>ホラ、もっとしっかり！
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","N","MA_01A900_140045")

	close_cutin()
	open_cutin(1,3)
	on_cutin(1,Actor003,"Sad")

	--★★マーリン★★:も、申し訳ございませんでしたぁーーーっ！！
	Talk(Actor003,"CHRNAME_MERLIN","speech","N","MA_01A900_140046")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-73,1.0)
wait_time(1.0)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力

	--★★マーリン★★:…私の本なのになぁ
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:平和になれば、また読めます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140049")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:ええ。それは待ち遠しくもあり<br>待望するのは残酷なようでもあり
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140050")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140051")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:そんな顔をしないでください
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140052")

	change_face(Actor003,"Normal")

	--★★マーリン★★:貴方の選択が必要です<br>抗うすべ、選び抜く道、その先の平和に
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140053")


	--★★マーリン★★:悔いなき選択をなされること、祈っています
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A900_140056","MA_01A900_140057")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140059")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いってきます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140060")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:はい<br>お気をつけて
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140061")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:選択してきます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140063")

	change_face(Actor001,"Normal")

	--★★ノワール★★:みんなと一緒に<br>悔いのないように
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_140064")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:あなたなら大丈夫ですよ<br>きっと
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140065")

	goto Block2end

::Block2end::
-- ▼直接出力
　--フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor001)
turn_chara(Actor003,93.6,0)
setup_small_camera_start()
wait_time(0.5)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:いって、らっしゃい
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140067")

	change_face(Actor003,"Sad")

	--★★マーリン★★:あなたが継承者で、本当に良かった
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140068")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
wait_time(1.0)
template2()
setup_small_camera_start()
Appear(Actor002)
change_face(Actor003,"Normal")
lookat_delay_weight_default(Actor003, 1)
keep_ik_lookat(Actor003,Actor002, "J_Head")
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:これでいいんだな、マーリン？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_140070")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:私が選んだことです<br>あなたこそ、よろしいので？
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140071")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:本懐とは異なる道を生きるのも<br>それはそれで悪くないように思える…だが
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_140072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:私としては<br>もっとも幸せな道です、きっと
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140073")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★マーリン★★:土の下では眠れずとも<br>そのように語り継ぎください
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140074")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:…後世に伝えていくよ、マーリン
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_140075")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:お前は真なる魔法使いであり<br>アーサー王を支えたと
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_140076")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:湖の妖精に連れ去られし者のことなど<br>どうか心に留めず
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140077")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:王に聖剣エクスカリバーを与え<br>王を勝利へ導いた無二の予言者であると
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_140078")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:私が去ろうとあなたが残る<br>学園が残る
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140079")


	--★★マーリン★★:継承者が世界を<br>後世へ託してくれると信じています
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140080")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("マーリン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:私のような石頭が世界を救う礎となれるなら<br>聖なる剣としてこれ以上にない幸福
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140081")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:…誰もが忘れても
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_140082")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:あなたが覚えていてくれる<br>私の存在があなたの中では不死となる
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140083")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:さよなら、アーサー<br>我が主──
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140084")

-- ▼直接出力
wait_time(0.8)
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:──魔法のような、日々でした
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A900_140086")

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
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101063","001","101063001")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_03)
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
