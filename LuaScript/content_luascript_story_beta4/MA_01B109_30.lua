-- このluaスクリプトは、MA_01B109_30.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	Camera002 = SetTemplate("Actor002",64.4,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Speculation")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115024)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:<ruby=シルバタブラナイツ>銀卓騎士団</ruby>の絆を信じたいガラハッドの言葉は<br>アステラによって冷たく突き放されるのだった
	Talk(Actor008,"telop","narration","N","MA_01B109_301001")


	--★★テロップ★★:
	Talk(Actor008,"telop","narration","N","MA_01B109_301002")


	--★★テロップ★★:
	Talk(Actor008,"telop","narration","N","MA_01B109_301004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:言い訳はある？アーサー？
	Talk(Actor008,"telop","narration","N","MA_01B109_301005")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★モルガン★★:言い訳はある？アーサー？
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300002")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("アーサー", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★アーサー★★:生徒や友人が困ってるのなら<br>助けに行くのがオトコであるからして
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300003")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor003, 1, false)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"ToAbnormal")
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B109_30_Wheelchair")
-- ▲直接出力

	--★★モルガン★★:やあっ
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Pain")

	--★★アーサー★★:うわー！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300006")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マーリン★★:モルガン、それはさすがに
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B109_300007")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "怒り")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★モルガン★★:戦い詰めでしょう<br>安静にしていてと言ったはずよ
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300008")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★アーサー★★:戦い詰めなのは騎士たちも同じだし…
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300009")

-- ▼直接出力
 --PlayPartVoice("モルガン", "激怒")
-- ▲直接出力

	--★★モルガン★★:言い訳しない！！
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_300011","MA_01B109_300012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_animationcontroller(Actor003, "Chr_005_01_StdController", "to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのへんで許してやってください…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_300014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:アーサーが来なければ<br>魔女を取り逃がしてしまっていた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_300015")

-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★モルガン★★:みんなアーサーの味方をするの？<br>ガラハッド、貴方はどう？
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300016")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ガラハッド★★:が、ガラハッドか…！？<br>ガラハッドは、ど、どちらとも…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
set_animationcontroller(Actor003, "Chr_005_01_StdController", "to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もっとやっちゃってください
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_300019")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★アーサー★★:ノ、ノワール！？<br>俺は一生懸命みんなのためにだなあ！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300020")

-- ▼直接出力
 --PlayPartVoice("モルガン", "怒り")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★モルガン★★:ノワールくんもああ言ってるじゃない<br>しっかり反省しなさい！
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300021")

	goto Block1end

::Block1end::
	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★モルガン★★:アーサー…貴方は王様、この国の要よ<br>進んで傷つきにいくことはないわ
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300023")


	--★★モルガン★★:誰よりも面倒事を引き受けていること<br>貴方のカラダを診ている私にわからないとでも？
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300024")


	--★★モルガン★★:8月に魔女姉妹全員の刃を一身に受けて<br>臓腑の一部は使い物にもならない
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300025")

	open_cutin(3,2)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor007,"Surprise")
	on_cutin(3,Actor005,"Surprise")
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:かすり傷だ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300027")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★モルガン★★:マーリンのサポートなしでは<br>満足に戦えるかどうか…
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300028")


	--★★アーサー★★:…ランスと約束したんだよ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300029")

-- ▼直接出力
 --PlayPartVoice("モルガン", "驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★モルガン★★:なあに、オトコ同士の約束？
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300030")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:ノワールを焚きつけたのは俺たちだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300031")


	--★★アーサー★★:学園は継承者を探し出し、重荷を背負わせた<br>ノワールは歩み続け、今や己の武器を選び出した
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:なら俺たちは終わりまで<br>その選択に報いる義務がある
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300033")

	open_select_window_tag(Actor001,"Normal","MA_01B109_300034","MA_01B109_300035")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気持ちは嬉しいけど<br>だからといって無理はしてほしくない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_300037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:その通りだ<br>配下の騎士にすべて任せるくらいの覚悟でいい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_300038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーだけじゃない<br>ランスロットにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_300039")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:…だそうだぞ？<br>弟想いだからな、俺の配下の騎士の筆頭は
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300040")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:む…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_300041")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:重荷だなんて思ってないよ<br>俺は自分の知りたいことを追いかけてるだけだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_300043")

	change_face(Actor001,"Normal")

	--★★ノワール★★:その背中を押してもらっていることに<br>ずっと感謝してる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_300044")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:そうか<br>少し、気が楽になったよ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300045")

	goto Block2end

::Block2end::
	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★モルガン★★:…なんにしても、王様としては失格よ
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300047")

-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★モルガン★★:さびしい想いをする家族がいるのも<br>忘れないで
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300048")

	PlayAction(Actor003,"to  Std_Sad02")
	change_face(Actor003,"Sad")

	--★★アーサー★★:面目ない
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン", "怒り")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★モルガン★★:お義姉さんに謝りなさい！！<br>気苦労絶えないマーリンにも！！
	Talk(Actor006,"CHRNAME_MORGAN","speech","L","MA_01B109_300050")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力

	--★★アーサー★★:ウッ！ゴメンナサッ！！
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B109_300052")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("マーリン", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マーリン★★:あらあら<br>義姉様には素直なんですねえ
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B109_300053")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(CHARA_IN_IN)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,80,0,0.3)
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,110,0,0.3)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
wait_time(CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
fadein(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(CHARA_IN_OUT + 1.0)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Speculation")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:………なぜだ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300055")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力

	--★★フィエナ★★:ガラハッド？
	Talk(Actor007,"CHRNAME_VIENA","speech","L","MA_01B109_300056")


	--★★ガラハッド★★:円卓は『妖精殺し』をかばい<br>その息子を祀り上げる汚らわしい集団と聞いてた
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ガラハッド★★:姉上…、ガラハッドは、もうわからない…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300058")

	PlayAction(Actor007,"to  Std_Sad01")
	change_face(Actor007,"Sad")

	--★★フィエナ★★:…そう、だね
	Talk(Actor007,"CHRNAME_VIENA","speech","L","MA_01B109_300059")

	change_face(Actor005,"Normal")

	--★★ガラハッド★★:「円卓に聖杯をあげてはならない」<br>お爺様はそう言った
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ぺレス王が？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_300061")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:そう言い、銀卓の皆もまた<br>その様子が変わりだした
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300062")


	--★★ガラハッド★★:あなたがＧＳしてからだ<br>ランスロット
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300063")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:な、に…？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_300065")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺とランスロットとのＧＳが<br>銀卓騎士が変わった原因だって言うのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_300066")

	PlayAction(Actor005,"to  Std_Angry")
	change_face(Actor005,"Anger")

	--★★ガラハッド★★:わからない、わからないんだ…！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ガラハッド★★:お爺様が何を仰せになりたかったのかも…<br>銀卓の真意も、なにもかも、今は…！！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300068")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:結局聖杯の行方もわからなくなってしまった…<br>すべては魔女の手の内のようにもみえた…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300069")

	PlayAction(Actor007,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "悲しみ")
-- ▲直接出力

	--★★フィエナ★★:…うん、ごめんね<br>あれから聖杯の反応が感じられなくなって…
	Talk(Actor007,"CHRNAME_VIENA","speech","L","MA_01B109_300070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Sad01")

	--★★ガラハッド★★:姉上のせいではない…<br>だが、もう──
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300071")


	--★★ガラハッド★★:奇跡など<br>本当に起こり得るのか？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B109_300072")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_ADV_Speculation")
	InitializeLoad_Preload()
	load_area_scene_preload(115024)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
