-- このluaスクリプトは、MA_01A111_26.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
load_image("102030040_StillImage", "content_still_10203004_image", "102030040_StillImage")
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor007)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
	load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor011,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:聖杯が顕現する兆しを感知したとのこと<br>間違いないな、フィエナ嬢
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01A111_260002")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	play_head_motion(Actor010, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:うん…っ
	Talk(Actor010,"CHRNAME_VIENA","speech","L","MA_01A111_260003")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
show_image("102030040_StillImage", 0.0, 0.0, 0.3,false,false)
-- ▲直接出力
-- ▼直接出力
movie_load("MA_01A111_26")
movie_set_active(true)
movie_play()
movie_wait_playing()
movie_stop()

--ムービー後待機
wait_time(MOVIE_AFTER)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A111_260009","MA_01A111_260010","MA_01A111_260011")
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
hide_image(0.3)
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あの期間で４ヶ所をまわったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_260013")

	PlayAction(Actor011,"to  Std_Talk")
	change_face(Actor011,"Normal")

	--★★ガラハッド★★:魔女姉妹がひとりひとりブリテン東部に散って<br>聖杯の出現を抑えていたみたいなんだ
	Talk(Actor011,"CHRNAME_GALAHAD","speech","L","MA_01A111_260014")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★パーシヴァル★★:だからボクらが魔女姉妹が潜んでいた４ヶ所を<br>潰してまわったんだよ、もうヘトヘトさ
	Talk(Actor007,"CHRNAME_PERCIVAL","speech","L","MA_01A111_260015")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ヴォールス★★:おかげでマゾエー、ティーロノエー<br>ティーテン、ティートンの４人を討てた
	Talk(Actor008,"CHRNAME_BORS","speech","L","MA_01A111_260016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:聖杯を抑えるものはなくなり<br>その顕現をフィエナが感知できたというわけだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_260017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
hide_image(0.3)
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:聖杯探索班のおかげで学園祭が行えた<br>…ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_260019")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:ローマ対策班が長城を攻略してくれたおかげで<br>探索の足を伸ばせたんだ、感謝する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_260020")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:エレインが直談判してくれなければ<br>祭りはなかっただろう
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A111_260021")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★トリスタン★★:学園の生徒たちも、国民たちも<br>ロンディニウムの人たちも…英気を養えたよね
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A111_260022")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
hide_image(0.3)
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:登山になるのか…<br>ローマに遅れは取れないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_260024")

	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor009,"Laugh")

	--★★ギネヴィア★★:ちょっとした遠足よね<br>障害はまあまあ多いけれど
	Talk(Actor009,"CHRNAME_GUINEVERE","speech","L","MA_01A111_260025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:頼もしい限りだぜ、ギネヴィア
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_260026")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ギネヴィア★★:おやつ持参で、行きましょ
	Talk(Actor009,"CHRNAME_GUINEVERE","speech","L","MA_01A111_260027")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★パーシヴァル★★:スノードンをずっと見張っていられれば<br>楽だったんだけどね
	Talk(Actor007,"CHRNAME_PERCIVAL","speech","L","MA_01A111_260029")

	change_face(Actor008,"Normal")

	--★★ヴォールス★★:しかしローマ領のど真ん中に我らが<br>長期に渡って陣を布くのは困難だっただろう
	Talk(Actor008,"CHRNAME_BORS","speech","L","MA_01A111_260030")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:後手に回るしかなかったというわけだ
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01A111_260032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★パーシヴァル★★:ま、仮にローマが先に聖杯を見つけたとしても<br>それをボクらが奪えばいいわけだよね
	Talk(Actor007,"CHRNAME_PERCIVAL","speech","L","MA_01A111_260034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A111_260036","MA_01A111_260037")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:必ずこちらが先に見つけてみせるよ<br>フィエナもついてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_260039")

	PlayAction(Actor011,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor011, false)
-- ▲直接出力
	change_face(Actor011,"Normal")

	--★★ガラハッド★★:広大な雪山で導きなしに杯ひとつを見つけるなど<br>いかにローマといえど出来はしない
	Talk(Actor011,"CHRNAME_GALAHAD","speech","L","MA_01A111_260040")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor011 , 0.6)
PlayActionDirect(Actor011,"to Wlk")
turn_chara(Actor011,126.634,0.8)
wait_time(0.8)
PlayActionDirect(Actor011,"to Std_Loop")
play_head_motion(Actor011, "Nod", 0.3, 1.0, false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor011,"Normal")

	--★★ガラハッド★★:姉上、僕らが守ります
	Talk(Actor011,"CHRNAME_GALAHAD","speech","L","MA_01A111_260041")

	PlayAction(Actor010,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor010,"Smile")

	--★★フィエナ★★:うん、お願いね！
	Talk(Actor010,"CHRNAME_VIENA","speech","L","MA_01A111_260042")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
turn_chara(Actor011,1,0)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor011, true)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★トリスタン★★:「先に見つけさせて奪うほうがイイ」…<br>ローマ側はそう思ってるかもしれないけどね
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A111_260043")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:見つけさせてから奪ったほうがラクか<br>騎士としてはあまり良い方法じゃないが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_260045")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ローマ側に先に発見されてしまえば<br>奪うのは難しくなるだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_260046")

	play_head_motion(Actor011, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor011,"Normal")

	--★★ガラハッド★★:正面衝突となれば姉上が危うい<br>理想は早期発見だ
	Talk(Actor011,"CHRNAME_GALAHAD","speech","L","MA_01A111_260047")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★トリスタン★★:「先に見つけさせて奪うほうがイイ」<br>そう思ってるのはローマも同じかもしれないけど
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A111_260048")

	goto Block2end

::Block2end::
	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:確かに<br>その聖杯に秘められた力は未知数…
	Talk(Actor008,"CHRNAME_BORS","speech","L","MA_01A111_260050")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:魔女は命を賭してその聖杯に迫った<br>そして4人の魔女姉妹のあっけない死…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_260051")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力

	--★★パーシヴァル★★:万象の力が宿る器…なにが起きてもおかしくない<br>先に見つけさせて様子見も策のひとつだよ
	Talk(Actor007,"CHRNAME_PERCIVAL","speech","L","MA_01A111_260052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor011,"to  Std_Angry")
	change_face(Actor011,"Anger")

	--★★ガラハッド★★:いいや！どちらにせよ得なければならない！<br>敵の手に渡してはならない！先に見つけるんだ！
	Talk(Actor011,"CHRNAME_GALAHAD","speech","L","MA_01A111_260053")

	change_face(Actor004,"Normal")

	--★★トリスタン★★:けどあっちには圧倒的物量とともに魔女もいて<br>ログレスから離反した生徒もいる…
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A111_260054")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:やりづれえな…ずっと
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_260055")

	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ギネヴィア★★:わたしたちが聖杯を発見した途端<br>兵力で押しつぶされる可能性も高いってわけね
	Talk(Actor009,"CHRNAME_GUINEVERE","speech","L","MA_01A111_260056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:総力戦だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_260057")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:ローマ対策班・聖杯探索班は５日後<br>総員を束ね、スノードンへ出陣してくれ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A111_260058")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:ボクやケイはログレスの守りを<br>アーサー王もモルガン先生の言いつけで待機
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A111_260060")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★アーサー★★:面目ないな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A111_260062")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:王とは普通そういうものだ<br>待っていてくれ、アーサー
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01A111_260063")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:リハビリ中のアーサーに<br>俺たちで朗報を持ち帰ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_260064")


	--★★パーシヴァル★★:継承者が聖杯を得られれば<br>この戦いのすべてが終わる…だろう？
	Talk(Actor007,"CHRNAME_PERCIVAL","speech","L","MA_01A111_260065")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定2")
-- ▲直接出力

	--★★ヴォールス★★:わずかな伝承を信用するのならな<br>聖杯取得のあとのことは誰もわからん
	Talk(Actor008,"CHRNAME_BORS","speech","L","MA_01A111_260066")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:細かいこと考えたって仕方ねえ<br>結局はバルバロイに勝てるかどうかだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_260067")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:ブリテンからバルバロイを殲滅し<br>ローマを追い出す…
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01A111_260068")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:ローマとの喧嘩もここまでね
	Talk(Actor009,"CHRNAME_GUINEVERE","speech","L","MA_01A111_260069")


	--★★ギネヴィア★★:円卓の騎士は勝利を継承者に<br>継承者は笑顔を円卓の騎士に
	Talk(Actor009,"CHRNAME_GUINEVERE","speech","L","MA_01A111_260070")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:抜き身の劔とともに<br>終わりの続きを斬り拓く
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_260071")

	open_cutin(1,1)
	on_cutin(1,Actor001,"Normal")

	--★★ノワール★★:スタンド・バイ・ユアラウンド！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01A111_260073")

	close_cutin()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★一同★★:フォー・ラウンド！
	Talk(Actor012,"NPCNAME_0126","speech","N","MA_01A111_260074")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102030040_StillImage", "content_still_10203004_image", "102030040_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor011")
	load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor011,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
