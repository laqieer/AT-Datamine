-- このluaスクリプトは、MA_01A109_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110131_02","110131_02_h")
Include("content_adv_advsmall_110131_02","Template110131_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",95.5,CharaPos110131_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110131_02,CameraPos110131_02_004)
	Camera002 = SetTemplate("Actor002",-133,CharaPos110131_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110131_02,CameraPos110131_02_002)
	Camera003 = SetTemplate("Actor003",35,CharaPos110131_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110131_02,CameraPos110131_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110131_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110131_02,CameraPos110131_02_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110131_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110131_02,CameraPos110131_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110131_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110131_02,CameraPos110131_02_003)
	Camera007 = SetTemplate("Actor010",nil,CharaPos110131_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110131_02,CameraPos110131_02_007)
	InitializeTemplateRandomCamera110131_02()
	InitializeTemplate110131_02()
-- ▼直接出力
load_image("MA01A1092001", "content_still_10103002_image", "101030020_StillImage")
set_enable_auto_lookat(Actor001,false)
set_common_look_at(Actor001,Actor002,1.0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_common_look_at(Actor003,Actor002,1.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor010,{0.936,0,12.18})
set_rot(Actor010,{0,-14.6,0})
-- ▲直接出力
-- ▼直接出力
mob1_1 = setup_prop_object(10130015)
set_pos(mob1_1,{3.18,0,10.23})
set_rot(mob1_1,{0,-20.5,0})
mob1_2 = setup_prop_object(10130015)
set_pos(mob1_2,{-2.458,0,11.7})
set_rot(mob1_2,{0,20.1,0})
mob1_3 = setup_prop_object(10130015)
set_pos(mob1_3,{2.62,0,8.34})
set_rot(mob1_3,{0,-17.5,0})
mob1_4 = setup_prop_object(10130015)
set_pos(mob1_4,{-1.85,0,9.63})
set_rot(mob1_4,{0,-3.5,0})
mob1_5 = setup_prop_object(10130015)
set_pos(mob1_5,{1.37,0,9.87})
set_rot(mob1_5,{0,5,0})
mob1_6 = setup_prop_object(10130015)
set_pos(mob1_6,{-2.25,0,8.49})
set_rot(mob1_6,{0,0,0})
mob1_7 = setup_prop_object(10130015)
set_pos(mob1_7,{-0.08,0,8.84})
set_rot(mob1_7,{0,0,0})
mob1_8 = setup_prop_object(10130015)
set_pos(mob1_8,{2.63,0,12.33})
set_rot(mob1_8,{0,-27.8,0})
mob1_9 = setup_prop_object(10130015)
set_pos(mob1_9,{-3.26,0,13.13})
set_rot(mob1_9,{0,21.6,0})
mob1_10 = setup_prop_object(10130015)
set_pos(mob1_10,{0.93,0,11.55})
set_rot(mob1_10,{0,-5.88,0})
-- ▲直接出力
-- ▼直接出力
mob2_1 = setup_prop_object(10130016)
set_pos(mob2_1,{-2.2,0,10.55})
set_rot(mob2_1,{0,15,0})
mob2_2 = setup_prop_object(10130016)
set_pos(mob2_2,{1.27,0,8.43})
set_rot(mob2_2,{0,0,0})
mob2_3 = setup_prop_object(10130016)
set_pos(mob2_3,{-0.27,0,9.71})
set_rot(mob2_3,{0,0.46,0})
mob2_4 = setup_prop_object(10130016)
set_pos(mob2_4,{-2.65,0,9.47})
set_rot(mob2_4,{0,16,0})
mob2_5 = setup_prop_object(10130016)
set_pos(mob2_5,{-1.62,0,7.68})
set_rot(mob2_5,{0,6.375,0})
mob2_6 = setup_prop_object(10130016)
set_pos(mob2_6,{-4.28,0,9.22})
set_rot(mob2_6,{0,36.9,0})
mob2_7 = setup_prop_object(10130016)
set_pos(mob2_7,{-5.02,0,10.86})
set_rot(mob2_7,{0,51,0})
mob2_8 = setup_prop_object(10130016)
set_pos(mob2_8,{-4.07,0,11.24})
set_rot(mob2_8,{0,22,0})
mob2_9 = setup_prop_object(10130016)
set_pos(mob2_9,{1.1,0,10.73})
set_rot(mob2_9,{0,-0.665,0})
mob2_10 = setup_prop_object(10130016)
set_pos(mob2_10,{-4.495,0,13.21})
set_rot(mob2_10,{0,45.4,0})
mob2_11 = setup_prop_object(10130016)
set_pos(mob2_11,{2.08,0,12.09})
set_rot(mob2_11,{0,-18.2,0})
-- ▲直接出力
-- ▼直接出力
mob3_1 = setup_prop_object(10130017)
set_pos(mob3_1,{-1.1,0,8.93})
set_rot(mob3_1,{0,0,0})
mob3_2 = setup_prop_object(10130017)
set_pos(mob3_2,{-1.77,0,6.34})
set_rot(mob3_2,{0,5.4,0})
mob3_3 = setup_prop_object(10130017)
set_pos(mob3_3,{-7.14,0,11.73})
set_rot(mob3_3,{0,44.3,0})
mob3_4 = setup_prop_object(10130017)
set_pos(mob3_4,{-3.49,0,8.72})
set_rot(mob3_4,{0,14.2,0})
mob3_5 = setup_prop_object(10130017)
set_pos(mob3_5,{1.05,0,5.94})
set_rot(mob3_5,{0,0,0})
mob3_6 = setup_prop_object(10130017)
set_pos(mob3_6,{-6.22,0,9.66})
set_rot(mob3_6,{0,38.9,0})
mob3_7 = setup_prop_object(10130017)
set_pos(mob3_7,{1.88,0,9.31})
set_rot(mob3_7,{0,-5.6,0})
mob3_8 = setup_prop_object(10130017)
set_pos(mob3_8,{-0.14,0,10.8})
set_rot(mob3_8,{0,0,0})
-- ▲直接出力
-- ▼直接出力
mob4_1 = setup_prop_object(10130012)
set_pos(mob4_1,{0.33,0,10.27})
set_rot(mob4_1,{0,0,0})
mob4_2 = setup_prop_object(10130012)
set_pos(mob4_2,{-2.8,0,7.7})
set_rot(mob4_2,{0,9.54,0})
mob4_3 = setup_prop_object(10130012)
set_pos(mob4_3,{1.85,0,7})
set_rot(mob4_3,{0,-7.8,0})
mob4_4 = setup_prop_object(10130012)
set_pos(mob4_4,{-4.69,0,6.8})
set_rot(mob4_4,{0,9.0,0})
mob4_5 = setup_prop_object(10130012)
set_pos(mob4_5,{-5.94,0,10.94})
set_rot(mob4_5,{0,40,0})
mob4_6 = setup_prop_object(10130012)
set_pos(mob4_6,{-3.38,0,9.89})
set_rot(mob4_6,{0,10,0})
mob4_7 = setup_prop_object(10130012)
set_pos(mob4_7,{2.3,0,10.07})
set_rot(mob4_7,{0,-32.8,0})
mob4_8 = setup_prop_object(10130012)
set_pos(mob4_8,{-2.684,0,12.61})
set_rot(mob4_8,{0,22.9,0})
mob4_9 = setup_prop_object(10130012)
set_pos(mob4_9,{-0.892,0,11.53})
set_rot(mob4_9,{0,-1.6,0})
mob4_10 = setup_prop_object(10130012)
set_pos(mob4_10,{3.092,0,12.82})
set_rot(mob4_10,{0,-36,0})
-- ▲直接出力
-- ▼直接出力
mob5_1 = setup_prop_object(10130013)
set_pos(mob5_1,{-1,0,9.88})
set_rot(mob5_1,{0,0,0})
mob5_2 = setup_prop_object(10130013)
set_pos(mob5_2,{3.93,0,7.09})
set_rot(mob5_2,{0,-16.8,0})
mob5_3 = setup_prop_object(10130013)
set_pos(mob5_3,{1.3,0,3.24})
set_rot(mob5_3,{0,29.6,0})
mob5_4 = setup_prop_object(10130013)
set_pos(mob5_4,{-6.81,0,5.57})
set_rot(mob5_4,{0,58.8,0})
mob5_5 = setup_prop_object(10130013)
set_pos(mob5_5,{-8.13,0,8.27})
set_rot(mob5_5,{0,54.6,0})
mob5_6 = setup_prop_object(10130013)
set_pos(mob5_6,{-7.65,0,10.65})
set_rot(mob5_6,{0,58,0})
mob5_7 = setup_prop_object(10130013)
set_pos(mob5_7,{0.09,0,7.13})
set_rot(mob5_7,{0,7.86,0})
mob5_8 = setup_prop_object(10130013)
set_pos(mob5_8,{2.76,0,10.82})
set_rot(mob5_8,{0,-11.3,0})
mob5_9 = setup_prop_object(10130013)
set_pos(mob5_9,{-4.01,0,13.17})
set_rot(mob5_9,{0,43.7,0})
-- ▲直接出力
-- ▼直接出力
mob6_1 = setup_prop_object(10130014)
set_pos(mob6_1,{0.81,0,9.25})
set_rot(mob6_1,{0,-12,0})
mob6_2 = setup_prop_object(10130014)
set_pos(mob6_2,{-4.6,0,10})
set_rot(mob6_2,{0,49,0})
mob6_3 = setup_prop_object(10130014)
set_pos(mob6_3,{-5.3,0,7.67})
set_rot(mob6_3,{0,38.5,0})
mob6_4 = setup_prop_object(10130014)
set_pos(mob6_4,{-2.16,0,2.5})
set_rot(mob6_4,{0,24.3,0})
mob6_5 = setup_prop_object(10130014)
set_pos(mob6_5,{-2.75,0,7.02})
set_rot(mob6_5,{0,2.38,0})
mob6_6 = setup_prop_object(10130014)
set_pos(mob6_6,{-3.17,0,11.47})
set_rot(mob6_6,{0,16.1,0})
mob6_7 = setup_prop_object(10130014)
set_pos(mob6_7,{-6.78,0,10.29})
set_rot(mob6_7,{0,30,0})
mob6_8 = setup_prop_object(10130014)
set_pos(mob6_8,{1.628,0,11.11})
set_rot(mob6_8,{0,-10.11,0})
mob6_9 = setup_prop_object(10130014)
set_pos(mob6_9,{-4.0,0,12.17})
set_rot(mob6_9,{0,41.2,0})
mob6_10 = setup_prop_object(10130014)
set_pos(mob6_10,{-1.4,0,10.95})
set_rot(mob6_10,{0,10.0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115134)
	Actor001 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","003","101011003","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_2DOnly("101039","001","101039001")
	Actor008 = InitializeCharacter_2DOnly("101037","001","101037001")
	Actor009 = InitializeCharacter_2DOnly("101038","001","101038001")
	Actor010 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_TextOnly()
	Actor012 = InitializeCharacter_TextOnly()
	Actor013 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
	setup_small_camera_start(RndCamera005)	
-- ▲直接出力

	--★★ガウェイン★★:なにが始まんだよノワール<br>殿下から聞いてないのかよ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_200002")

	open_select_window_tag(Actor002,"Normal","MA_01A109_200004","MA_01A109_200005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ノワール★★:なにも教えてくれなかったんだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_200007")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ガウェイン★★:ケチっくせえんだから、殿下は
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_200008")

	change_face(Actor003,"Surprise")

	--★★ラグネル★★:本当？<br>少しも教えてもらえなかったの？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A109_200009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ノワール★★:きっと派手にやってくれるよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_200011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ラグネル★★:私もそう思う！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01A109_200012")

	change_face(Actor001,"Smile")

	--★★ガウェイン★★:なんつーか<br>ツーカーの仲ってヤツ？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_200013")

	goto Block1end

::Block1end::
-- ▼直接出力
	CloseTalkWindow()
	setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
turn_lookat(Actor001,Actor004,0)
turn_lookat(Actor002,Actor004,0)
turn_lookat(Actor003,Actor004,0)
turn_lookat(Actor005,Actor004,0)
turn_lookat(Actor006,Actor004,0)
turn_lookat(Actor010,Actor004,0)
set_common_look_at(Actor001,Actor004,1)
set_common_look_at(Actor002,Actor004,1)
set_common_look_at(Actor003,Actor004,1)
set_common_look_at(Actor005,Actor004,1)
set_common_look_at(Actor006,Actor004,1)
set_common_look_at(Actor010,Actor004,1)
-- ▲直接出力
-- ▼直接出力
	character_in_move_walk_offset(Actor004,CharaPos110131_02_001,3,0,-0.3,1.5)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001, CharaPos110131_02_004[4], 0)
turn_chara(Actor002, CharaPos110131_02_002[4], 0)
turn_chara(Actor003, CharaPos110131_02_006[4], 0)
-- ▲直接出力
-- ▼直接出力
wait_time(WAIT_TIME_NORMAL)
-- ▲直接出力
-- ▼直接出力
	setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")

	--★★ギネヴィア★★:お集まりいただきどうもありがとう<br>わたしは継承者の劔ギネヴィア・アロンダイト
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200015")

-- ▼直接出力
	setup_small_camera_start(Camera005)
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★エレイン★★:（………先輩の選んだ、お相手…）
	Talk(Actor005,"CHRNAME_ELAINE","mind","L","MA_01A109_200017")

-- ▼直接出力
	setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★ギネヴィア★★:いきなり本題で失礼<br>アーサー陛下、いらっしゃいます？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200018")

-- ▼直接出力
	setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to Greet_one")

	--★★アーサー★★:何用かな<br>愛しのワイフ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01A109_200020")

-- ▼直接出力
CloseTalkWindow()
--[[
show_image("MA01A1092001", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER) ]]--

--スチル表示（左から）
	show_image("MA01A1092001", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
	set_position_image(STILL_POS_LEFT,STILL_POS_LENGTH)
	set_scale_image(STILL_SCALE,STILL_SCALE)

	wait_time(STILL_SWITCH_TIME)

	scale_to_image(1,1,STILL_MOVE_TIME2,2)
	move_to_image(0,0,STILL_MOVE_TIME2,2)
	wait_time(STILL_ACTIVE_AFTER)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:離婚、してください
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","N","MA_01A109_200022")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:えええええええええええ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","N","MA_01A109_200024")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:ああ、いいぞ！
	Talk(Actor006,"CHRNAME_ARTHUR","speech","N","MA_01A109_200025")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:えええええええええええ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","N","MA_01A109_200027")

-- ▼直接出力
	CloseTalkWindow()
set_enable_auto_lookat_all(false)
set_common_look_at(Actor002,Actor004,1.0)
set_common_look_at(Actor001,Actor004,1.0)
set_common_look_at(Actor003,Actor004,1.0)
set_common_look_at(Actor006,Actor004,1.0)
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力

	--★★ギネヴィア★★:静粛に願いまーす
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","N","MA_01A109_200028")

-- ▼直接出力
	setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★ガウェイン★★:静粛になれるか！<br>こんなんアーサー様の立場がねえだろ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","MA_01A109_200029")

-- ▼直接出力
	setup_small_camera_start(Camera006)
-- ▲直接出力
	play_head_motion(Actor006, "No", 0.3, 1.0, false)

	--★★アーサー★★:もとより王妃は仮の座だよ<br>周知の事実だろうがな
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01A109_200030")

-- ▼直接出力
	setup_small_camera_start(Camera004)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:ええ。この婚約はわたしの身を保証するための<br>隠れ蓑でしかありませんでした
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:ですが、わたしはその立場に甘えるばかり<br>ぬるま湯の中で誰かに守られてばかり
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200032")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:しかし今<br>わたしは継承者とのＧＳを果たしました
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200033")

	change_face(Actor007,"Anger")

	--★★フレン★★:…ルーシャスくんに<br>目をかけてもらいながら──
	Talk(Actor007,"CHRNAME_FREN","speech","L","MA_01A109_200035")

-- ▼直接出力
	setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")

	--★★ギネヴィア★★:これは惚れた腫れたの話ではありません
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200036")


	--★★ローラ★★:………それは、ほんとう？
	Talk(Actor009,"CHRNAME_LOLA","speech","L","MA_01A109_200038")


	--★★ギネヴィア★★:もはやキャメリアードの王女の過去も<br>ログレスの王妃の席も棄てるのです
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200039")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ギネヴィア★★:貴方たちが欲するは平和<br>ならばわたしが欲するは勝利のみ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200040")


	--★★ギネヴィア★★:家族を、故郷を喰い散らかしたバルバロイに<br>狡猾な策を弄するローマ大帝国に
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラシア★★:狡猾…、そう、でも──
	Talk(Actor008,"CHRNAME_RASIA","speech","L","MA_01A109_200043")

	change_face(Actor004,"Anger")

	--★★ギネヴィア★★:思い知らせてやりましょう
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200045")


	--★★ギネヴィア★★:我らログレス、騎士の誇りにかけて<br>愛しき隣人を暴虐の末に殺すことなどしない
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200046")


	--★★キャメロット騎士学術院（男）★★:…そうだ、その通りだ
	Talk(Actor011,"NPCNAME_0151","speech","N","MA_01A109_200047")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:わたしは信じています<br>敵味方関わらず受け入れ共に歩む学園の姿勢を
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200048")


	--★★ギネヴィア★★:座すべき者はすべてに平等<br>円卓を囲む騎士たちの精神を
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200049")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★ギネヴィア★★:円卓を囲む騎士たちとはすなわち<br>このログレスに生きる貴方たちのことです
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200051")


	--★★キャメロット騎士学術院（女）★★:そうよ…<br>だから、私たちここにいるのよ
	Talk(Actor012,"NPCNAME_0146","speech","N","MA_01A109_200052")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:愛しき隣人と結ぶ強さを知るからこそ<br>武器となりて戦に身を投じられる
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200053")


	--★★エレイン★★:…！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A109_200054")


	--★★キャメロット騎士学術院（男）②★★:そうだよ、だから戦時であっても<br>授業が、お祭りが、学園生活があったんだ…！
	Talk(Actor013,"NPCNAME_0153","speech","N","MA_01A109_200055")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:世界が敵に回ろうと<br>タダでは起きてやらないわ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200056")

-- ▼直接出力
	setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:…ギネヴィア
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A109_200057")

-- ▼直接出力
	setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Anger")

	--★★ギネヴィア★★:わたしは継承者の劔<br>ギネヴィア・アロンダイト！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200058")


	--★★ギネヴィア★★:王の寵愛を裏切り、王妃の座を降り<br>着飾るものは何もなくとも
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:勝利を、飾りましょ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A109_200060")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor010,"J_Head",1.0)
set_enable_auto_lookat(Actor010, true)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★エレイン★★:お兄ちゃん
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A109_200062")


	--★★ラヴェイン★★:なんですか、エレイン？
	Talk(Actor010,"CHRNAME_LOVEIN","speech","L","MA_01A109_200063")

-- ▼直接出力
	setup_small_camera_start(Camera005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★エレイン★★:…私も、あんなふうに、なれるかな
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A109_200064")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA01A1092001", "content_still_10103002_image", "101030020_StillImage")
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130015)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130016)
setup_prop_object_preload(10130017)
setup_prop_object_preload(10130017)
setup_prop_object_preload(10130017)
setup_prop_object_preload(10130017)
setup_prop_object_preload(10130017)
setup_prop_object_preload(10130017)
setup_prop_object_preload(10130017)
setup_prop_object_preload(10130017)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130014)
setup_prop_object_preload(10130014)
	InitializeLoad_Preload()
	load_area_scene_preload(115134)
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","003","101011003","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_2DOnly_Preload("101039","001","101039001")
	InitializeCharacter_2DOnly_Preload("101037","001","101037001")
	InitializeCharacter_2DOnly_Preload("101038","001","101038001")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110131_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
