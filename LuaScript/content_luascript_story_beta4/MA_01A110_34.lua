-- このluaスクリプトは、MA_01A110_34.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_07","110011_07_h")
Include("content_adv_advsmall_110011_07","Template110011_07_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_07_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_07_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_07_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_07_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_07_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_07_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_07_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_009)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110011_07_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_006)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110011_07_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_007)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110011_07_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_010)
	InitializeTemplateRandomCamera110011_07()
	InitializeTemplate110011_07()
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_weight(Actor001,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
set_pos(Actor004,{-3.082,0,-3.637})
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor005,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
set_pos(Actor007,{-3.447,0,-4.685})
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
set_pos(Actor008,{-2.06,0,-4.38})
-- ▲直接出力
-- ▼直接出力
Hide(Actor009)
set_pos(Actor009,{-3.13,0,-4.38})
-- ▲直接出力
-- ▼直接出力
meal01 = setup_prop_object(10104007)
set_pos(meal01,{-1.347, 0.82, -1.751})
set_rot(meal01,{0,90,0})
meal02 = setup_prop_object(10104007)
set_pos(meal02,{-2.661, 0.82, -1.765})
set_rot(meal02,{0,90,0})
--[[
dish01 = setup_prop_object(10104013)
set_pos(dish01,{-1.013, 0.82, -2.056})
set_rot(dish01,{0,0,180})
]]
fruit01 = setup_prop_object(10104002)
set_pos(fruit01,{-3.06, 0.82, -1.876})
set_rot(fruit01,{0,100,0})
-- ▲直接出力
-- ▼直接出力
bread01 = setup_prop_object(10104014)
set_pos(bread01,{-1.453, 0.82, -2.052})
pot01 = setup_prop_object(10104010)
set_pos(pot01,{-2.769, 0.82, -2.03})
set_rot(pot01,{0,330,0})
cup01 = setup_prop_object(10104008)
set_pos(cup01,{-2.612, 0.82, -2.021})
set_rot(cup01,{0,43,0})
cup02 = setup_prop_object(10104008)
set_pos(cup02,{-2.496, 0.82, -2.102})
set_rot(cup02,{0,295,0})
-- ▲直接出力
-- ▼直接出力
off_active(meal01)
off_active(meal02)
--off_active(dish01)
off_active(fruit01)
off_active(bread01)
off_active(pot01)
off_active(cup01)
off_active(cup02)
-- ▲直接出力
-- ▼直接出力
item01 = get_object("geo_desk_item_03")
set_pos(item01,{0, -20, 0})
item02 = get_object("geo_desk_item_04")
set_pos(item02,{0, -20, 0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor010")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:嗚呼～「ああ、騎士様<br>まさか助けに来てくれるなんて」ハァァ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_340002")


	--★★ギネヴィア★★:「自由に憧れ、何もない平穏に退屈していた<br>こんな身勝手で、ワガママな王女を」およよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_340003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	open_cutin(2,2)
	on_cutin(1,Actor005,"Anger")

	--★★マルディサント★★:このヘタクソがッッ！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","N","MA_01A110_340005")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "苦しみ")
-- ▲直接出力
	on_cutin(2,Actor002,"Pain")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ぎゃあああ！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","MA_01A110_340006")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(Camera003)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "否定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:マァル！！<br>前時代的演出家ヤメて～っ！！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_340007")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01B112_12_Door_Open")
wait_time(0.5)
on_active(Actor008)
on_active(Actor009)
PlayActionDirect(Actor008,"to Wlk")
PlayActionDirect(Actor009,"to Wlk")
turn_lookat_position(Actor008,CharaPos110011_07_006[1],CharaPos110011_07_006[2],CharaPos110011_07_006[3],0)
turn_lookat_position(Actor009,CharaPos110011_07_007[1],CharaPos110011_07_007[2],CharaPos110011_07_007[3],0)
slidemove(Actor008,CharaPos110011_07_006[1],CharaPos110011_07_006[2],CharaPos110011_07_006[3],0.8)
wait_time(0.2)
slidemove(Actor009,CharaPos110011_07_007[1],CharaPos110011_07_007[2],CharaPos110011_07_007[3],0.8)
wait_time(0.1)
setup_small_camera_start()
wait_time(0.5)
turn_chara(Actor008,CharaPos110011_07_006[4],0.3)
wait_time(0.2)
turn_chara(Actor009,CharaPos110011_07_007[4],0.3)
wait_time(0.1)
PlayActionDirect(Actor008,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor009,"to Std_Loop")
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor005,true)
set_enable_auto_lookat(Actor006,true)
set_enable_auto_lookat(Actor003,true)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力

	--★★ガウェイン★★:やってる？
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","MA_01A110_340009")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力

	--★★マルディサント★★:やってねえよ！！<br>テメエらは粗末な出店でB級グルメ作ってろ！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340010")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "納得")
-- ▲直接出力

	--★★ラグネル★★:ずいぶんだなあ<br>店の飾り付けだって大変なんだよお？
	Talk(Actor009,"CHRNAME_RAGNAR","speech","L","MA_01A110_340011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ガウェイン★★:差し入れ持ってきたぜ<br>ノワール、ギネヴィア様
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","MA_01A110_340012")

-- ▼直接出力
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ご、ごはん…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_340013")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
change_face(Actor002,"Sad")
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力

	--★★マルディサント★★:ヘタクソに食わせるメシはねえよ！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_340015")

-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力

	--★★マルディサント★★:代役も同罪だボケ！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340016")

	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラグネル", "照れ")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ラグネル★★:ファイト―！<br>ノワール、ギネヴィア様～
	Talk(Actor009,"CHRNAME_RAGNAR","speech","L","MA_01A110_340017")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor008,"to Wlk")
wait_time(0.3)
PlayActionDirect(Actor009,"to Wlk")
wait_time(1.2)
PlayActionDirect(Actor008,"to Std_Loop")
PlayActionDirect(Actor009,"to Std_Loop")
se_play("SE_ADV_MA_01B112_12_Door_Open")
Hide(Actor008)
Hide(Actor009)
keep_ik_lookat(Actor001,Actor005,"J_Head")
keep_ik_lookat(Actor002,Actor005,"J_Head")
keep_ik_lookat(Actor005,Actor002,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor006,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-0.387,0,-1.815})
turn_chara(Actor003,265,0)
turn_chara(Actor006,225,0)
on_active(meal01)
on_active(meal02)
--on_active(dish01)
on_active(fruit01)
on_active(bread01)
on_active(pot01)
on_active(cup01)
on_active(cup02)
keep_ik_lookat(Actor003,bread01,"Pro_1057")
keep_ik_lookat(Actor006,bread01,"Pro_1057")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:いいか！テメーみたいに何者でもねーヤツが<br>いきなり大舞台で喝采浴びられるわけねえんだ！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340019")

-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★エレイン★★:いただきまーす
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_340021")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:お先に～
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_340022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ああっ、平らげられてしまう
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_340023")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力

	--★★マルディサント★★:付け焼き刃でうまくいくほど甘くねえぞ！<br>わかってんのか！？あ！？
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340024")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01B112_12_Door_Open")
wait_time(0.5)
on_active(Actor004)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,CharaPos110011_07_008[1],CharaPos110011_07_008[2],CharaPos110011_07_008[3],0.4)
wait_time(0.1)
setup_small_camera_start()
wait_time(0.3)
PlayActionDirect(Actor004,"to Std_Loop")
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
set_enable_auto_lookat(Actor005,true)
set_enable_auto_lookat(Actor006,true)
set_enable_auto_lookat(Actor003,true)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルガン★★:やってる～？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A110_340026")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "喜び")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★マルディサント★★:やってます！！<br>どうぞどうぞどうぞ！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340027")

-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力

	--★★モルガン★★:お構いなく～、続けて続けて～♪<br>あ、ジャンクフードだあ差し入れ？？
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A110_340029")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:食べます？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01A110_340030")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力

	--★★モルガン★★:食べる食べる～
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A110_340031")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
se_play("SE_ADV_MA_01B112_12_Door_Open")
wait_time(0.5)
on_active(Actor007)
PlayActionDirect(Actor007,"to Wlk")
turn_lookat_position(Actor007,CharaPos110011_07_009[1],CharaPos110011_07_009[2],CharaPos110011_07_009[3],0)
--フェードイン
fadein(CHARA_IN_IN)
slidemove(Actor007,CharaPos110011_07_009[1],CharaPos110011_07_009[2],CharaPos110011_07_009[3],0.4)
wait_time(0.4)
turn_chara(Actor007,CharaPos110011_07_009[4],0.2)
wait_time(0.2)
PlayActionDirect(Actor007,"to Std_Loop")
set_enable_auto_lookat_all(true)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ラヴェイン★★:やってますか？
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_340033")

-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor007,true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★マルディサント★★:やり合ってる最中だよボケ！<br>テメ―は運営で多忙だろ、帰れ！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★エレイン★★:お兄ちゃん、ご飯食べる？
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_340035")

-- ▼直接出力
set_enable_auto_lookat(Actor007,false)
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力

	--★★ラヴェイン★★:美味しそうですね<br>ではお言葉に甘えていただきましょうか
	Talk(Actor007,"CHRNAME_LOVEIN","speech","L","MA_01A110_340036")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:お、俺たちのご飯が…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_340037")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1.0)
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor005,"Pain")

	--★★マルディサント★★:観客は誰も見たことねーモンが見てえんだ<br>てめーごとき素人が演技でンなモン見せられねえ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340039")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:じゃあ…どーすんのよぉ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_340040")

-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★マルディサント★★:てめーしか持ってねえモノがなにか、考えろ！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340041")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
change_face(Actor001,"Normal")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:び、美貌？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_340042")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力

	--★★マルディサント★★:バーカ！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340043")

-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力

	--★★モルガン★★:あるじゃない、あなたには
	Talk(Actor004,"CHRNAME_MORGAN","speech","L","MA_01A110_340044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:え？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_340045")

-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor002,0.5)
wait_time(0.2)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor001,0.5)
wait_time(0.3)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★エレイン★★:…ありますね<br>ギネヴィア様にしかないモノ
	Talk(Actor006,"CHRNAME_ELAINE","speech","L","MA_01A110_340046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:ええ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_340047")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マルディサント★★:客が物語の虚構を信じるためには<br>登場人物本人のリアルが必要なんだ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340048")


	--★★マルディサント★★:飾り立てない部分、そいつの唯一の部分──<br>そーゆーのがさ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340050")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★マルディサント★★:そーゆー誰も見たことねーモノを<br>抱えながら全力でやれ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340051")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定3")
-- ▲直接出力

	--★★マルディサント★★:そうすりゃ身内のお情け程度の拍手は<br>もらえるんじゃねーの
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_340052")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:………お情け、ジョートーよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_340054")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10104007)
setup_prop_object_preload(10104007)
setup_prop_object_preload(10104002)
setup_prop_object_preload(10104014)
setup_prop_object_preload(10104010)
setup_prop_object_preload(10104008)
setup_prop_object_preload(10104008)
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_07)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
