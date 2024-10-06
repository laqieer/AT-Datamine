-- このluaスクリプトは、MA_01108_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera012 = SetTemplate("Actor012",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
load_image("102010090_StillImage", "content_still_10201009_image", "102010090_StillImage")
load_image("MA011080201", "content_still_10101013_image", "101010130_StillImage")
Hide(Actor008)
set_enable_auto_lookat_all(false)
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
DontCameraOffset(Actor010)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor011)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor012)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101028","003","101028003","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor012")
	Actor013 = InitializeCharacter_TextOnly()
	Actor014 = InitializeCharacter_TextOnly()
	Actor015 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor016 = InitializeCharacter_2DOnly("101012","001","101012001")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガラハッド★★:騒がしいものなのですね<br>学園とは
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020002")


	--★★ケイ★★:…今でなければもう少し<br>もてなしもできたでしょうな
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020004")

	PlayAction(Actor009,"to  Std_Talk")
	change_face(Actor009,"Sad")

	--★★アステラ★★:どこも大変ななか…<br>面倒事を持ち込んでごめんなさいね
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:そこはお互いサマだ。言いっこなしとしよう<br>歓迎するよ、ガラハッド卿、アステラ殿
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_020007")


	--★★ケイ★★:先に申したとおり、慌ただしいなかでね<br>早速だがわざわざ参られた理由をお聞かせ願おう
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020009")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("102010090_StillImage", 0.0, 0.0, STILL_SWITCH_TIME ,false,false)
-- ▲直接出力
-- ▼直接出力
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力

	--★★ガラハッド★★:…ガラハッドはブリテン北部の島にある<br>コルベニック城より海を渡り来ました
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020011")


	--★★ガラハッド★★:ここのところ城の周囲で、カレドニア軍や<br>バルバロイの姿を見かけることが多くなりました
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020012")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
hide_image(STILL_SWITCH_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★パーシヴァル★★:それで<br>ボクたちに退治を頼みに来たわけ？
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01108_020013")


	--★★トリスタン★★:…ボクたち円卓の騎士が信用ならないから<br>銀卓騎士団を結成したんでしょ？
	Talk(Actor011,"CHRNAME_TRISTAN","speech","L","MA_01108_020014")


	--★★モルドレッド★★:過去、妖精を守るべく派遣されたヤツが<br>消えちまったとなれば、信用なんて出来ねえよな
	Talk(Actor012,"CHRNAME_MORDRED","speech","L","MA_01108_020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")

	--★★ガラハッド★★:………『ハドリアヌス・ウォール』が<br>カレドニアの進軍を阻んでいます
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020017")


	--★★ガラハッド★★:ですがコルベニック城主ペレス王は<br>長期間の籠城に耐えられる体ではありません
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020018")


	--★★ガラハッド★★:外界からの薬や物資が足らなくなれば──
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020019")


	--★★ガウェイン★★:『ハドリアヌス・ウォール』ってのは？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01108_020020")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("MA011080201", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
-- ▲直接出力
-- ▼直接出力
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
	change_face(Actor009,"Normal")

	--★★アステラ★★:外敵の侵入を防ぐべく建てられた高い壁よ<br>ぺレス王が加護の魔法をかけているの
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020021")


	--★★アステラ★★:たとえ空からでも<br>バルバロイが壁を越えることはできないわ
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020022")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
hide_image(STILL_SWITCH_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力

	--★★ノワール★★:ライエンスがガラハッドを追っていたのは<br>壁を越えるための方法を知るためだったのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01108_020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★パーシヴァル★★:どうだろうね。コルベニック城とその周辺には<br>聖杯や妖精にまつわる秘密があるっていうけど
	Talk(Actor005,"CHRNAME_PERCIVAL","speech","L","MA_01108_020024")


	--★★ガラハッド★★:世界が混乱に覆われるとき<br>聖杯はその姿を現す、とされています
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020025")

	PlayAction(Actor007,"to  Std_No")

	--★★ガラハッド★★:どこに、どのような条件で現れるか<br>それは妖精と伝承しか知らぬままです
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020026")


	--★★ガラハッド★★:…妖精は去り、守護者の消えた聖杯城に<br>どんな価値があるのか僕にはわかりません
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:だけどガラハッドは<br>故郷を見放さない
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020029")


	--★★ガラハッド★★:そしてノワール卿、ランスロット卿<br>あなた方は故郷へ帰る義務がある…そうですね
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020031")


	--★★テロップ★★:「言葉は悪いが、師匠の『妖精殺し』により<br>聖杯城が混乱しログレスが締め出されたのは事実0」
	Talk(Actor013,"telop","narration","N","MA_01108_020032")


	--★★テロップ★★:「だから、俺が行かなきゃならない」
	Talk(Actor013,"telop","narration","N","MA_01108_020033")

	open_select_window_tag(Actor002,"Normal","MA_01108_020035","MA_01108_020036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:俺からもお願いするよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01108_020038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ランスロット★★:ガラハッド卿の言うとおりだ<br>俺たちには義務がある
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01108_020039")

	change_face(Actor002,"Normal")

	--★★ノワール★★:故郷を守らなきゃならない義務が
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01108_020040")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:少し帰りづらいけど
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01108_020042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ランスロット★★:ガラハッド卿の言うとおだ<br>俺たちには義務がある
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01108_020043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:…ああ<br>連れて行ってくれるか、ガラハッド
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01108_020044")

	goto Block1end

::Block1end::
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
on_camera(Camera007)
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:恩に着る
	Talk(Actor007,"CHRNAME_GALAHAD","speech","L","MA_01108_020046")

-- ▼直接出力
CloseTalkWindow(Camera)
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, CHANGE_STYLE_TIME_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
se_play("SE_ADV_MA_01108_02_Helmet_TakeOff")
wait_time(CHANGE_STYLE_TIME_OUT)
-- ▲直接出力
-- ▼直接出力
Appear(Actor008)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
wait_time(CHANGE_STYLE_TIME_WAIT)
-- ▲直接出力
-- ▼直接出力
fadein(CHANGE_STYLE_TIME_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(CHANGE_STYLE_TIME_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor008,"to Bow")

	--★★ガラハッド／兜なし★★:…ありがとう
	Talk(Actor008,"CHRNAME_GALAHAD","speech","L","MA_01108_020048")

	change_face(Actor009,"Laugh")

	--★★アステラ★★:勇ましき銀騎士が<br>女の子で驚きかしら？
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド／兜なし★★:勇ましさに女も男もないだろう<br>アステラ
	Talk(Actor008,"CHRNAME_GALAHAD","speech","L","MA_01108_020051")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
	change_face(Actor009,"Smile")

	--★★アステラ★★:そうよガラハッド<br>あなたのそういう考えが好き
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020052")

	change_face(Actor009,"Normal")

	--★★アステラ★★:それで皆様、図々しいのは承知で<br>もうふたつだけ…お願いなんだけど
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020053")


	--★★アステラ★★:ガラハッドはGSして間もないから<br>しばらく学園で学ばせてほしいっていうのと
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★アステラ★★:…ぺレス王の体調がよくないの<br>彼が衰えればスクトゥムの加護も消えてしまう
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020055")

	change_face(Actor009,"Normal")

	--★★アステラ★★:薬草を摘みにコーンウォールへ行くために<br>その道案内を頼めるかしら
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020056")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★アーサー★★:『ガラハッド卿の短期留学』と『薬草採取』か<br>お安い御用だ、人を付けよう
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_020057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:カレドニア侵攻準備を進めるのが先だ、王よ<br>協力を申し出てくれた皇太子殿下の顔を立てねば
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020058")


	--★★トリスタン★★:逃げた敵軍の傭兵も<br>追わなくちゃならないよね
	Talk(Actor011,"CHRNAME_TRISTAN","speech","L","MA_01108_020060")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:手分けして<br>同時にあたるというのは？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01108_020062")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★アーサー★★:いい考えだ！実にな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01108_020064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ケイ★★:…人手は必要になるがな<br>ノワールも暇なしで悪いが例外ではないぞ
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020065")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ケイ★★:では、整理する<br>ぺレス王のための薬草を採取に向かうのは
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020067")

	open_cutin(3,1)
	on_cutin(1,Actor001,"Normal")
	on_cutin(2,Actor011,"Normal")
	on_cutin(3,Actor008,"Normal")

	--★★ケイ★★:ランスロット、トリスタン<br>それにガラハッド卿の３名
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020068")

	close_cutin()
	open_cutin(2,1)
	on_cutin(1,Actor015,"Normal")
	on_cutin(2,Actor003,"Normal")
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:ローマと協力してのカレドニア侵攻は<br>ギネヴィア王妃とガウェインが準備を進める
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020069")

	close_cutin()
	open_cutin(1,1)
	on_cutin(1,Actor010,"Normal")

	--★★ケイ★★:脱走したブライアンの行方を追う<br>ガレスと…
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020070")

	close_cutin()
	open_cutin(1,1)
	on_cutin(1,Actor016,"Normal")
	play_head_motion(Actor010, "Nod", 0.3, 1.0, false)
	change_face(Actor010,"Laugh")

	--★★ガレス★★:ブライアンと仲の良い人にも来てほしいな<br>ディナタンとか！
	Talk(Actor010,"CHRNAME_GARETH","speech","L","MA_01108_020071")

	close_cutin()

	--★★ケイ★★:よかろう<br>して、ノワール。貴公はどうしたい？
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
open_select_window_tag(Actor002,"Normal","MA_01108_020074","MA_01108_020075","MA_01108_020076")
wait_time(0.5)
	if is_select(1) then
		
	elseif is_select(2) then
		
	elseif is_select(3) then
		
	end
-- ▲直接出力

	--★★ケイ★★:承知した
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020078")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
	change_face(Actor009,"Laugh")

	--★★アステラ★★:ガラハッドの学園案内もお願いできると嬉しいわ<br>どなたか──
	Talk(Actor009,"CHRNAME_ASTERA","speech","L","MA_01108_020079")

	PlayAction(Actor008,"to  Std_Talk")
	change_face(Actor008,"Sad")

	--★★ガラハッド／兜なし★★:お前。多忙ななかで悪いが
	Talk(Actor008,"CHRNAME_GALAHAD","speech","L","MA_01108_020081")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:銀卓騎士団のゲスト直々の指名となれば<br>断れぬな。ノワール
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01108_020083")

	open_cutin(1,1)
	on_cutin(1,Actor004,"Normal")

	--★★アーサー★★:スタンド・バイ・ユアラウンド
	Talk(Actor004,"CHRNAME_ARTHUR","speech","N","MA_01108_020084")

	close_cutin()

	--★★一同★★:フォー・ラウンド！
	Talk(Actor014,"NPCNAME_0126","speech","N","MA_01108_020086")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102010090_StillImage", "content_still_10201009_image", "102010090_StillImage")
load_image_preload("MA011080201", "content_still_10101013_image", "101010130_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101028","003","101028003","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor012")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_2DOnly_Preload("101012","001","101012001")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
