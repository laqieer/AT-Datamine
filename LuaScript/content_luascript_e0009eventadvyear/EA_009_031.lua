-- このluaスクリプトは、EA_009_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
set_enable_auto_lookat(Actor001, false)
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
 --set_pos(Actor007, {1.22, 0, -13.45})
-- ▲直接出力
-- ▼直接出力
Prop_01 = get_object("geo_trayB25")
Prop_02 = get_object("geo_trayA26")
Prop_03 = get_object("geo_trayB27")
Prop_04 = get_object("geo_trayA30")
Prop_05 = get_object("geo_trayB29")
Prop_06 = get_object("geo_trayC28")
Prop_07 = get_object("geo_cutlery25")
Prop_08 = get_object("geo_cutlery26")
Prop_09 = get_object("geo_cutlery27")
Prop_10 = get_object("geo_cutlery28")
Prop_11 = get_object("geo_cutlery29")
Prop_12 = get_object("geo_cutlery30")
set_pos(Prop_01,{-15,0.815,1.25})
set_pos(Prop_02,{-15,0.815,1.25})
set_pos(Prop_03,{-15,0.815,1.25})
set_pos(Prop_04,{-15,0.815,1.25})
set_pos(Prop_05,{-15,0.815,1.25})
set_pos(Prop_06,{-15,0.815,1.25})
set_pos(Prop_12,{-15,0.815,1.25})
set_pos(Prop_07,{-15,0.815,1.25})
set_pos(Prop_08,{-15,0.815,1.25})
set_pos(Prop_09,{-15,0.815,1.25})
set_pos(Prop_10,{-15,0.815,1.25})
set_pos(Prop_11,{-15,0.815,1.25})
-- ▲直接出力
-- ▼直接出力
tegami2 = setup_prop_object(10106003)
off_active(tegami2)
tegami_offset2 = {0,0,0,0,0,0}
tegami3 = setup_prop_object(10106003)
off_active(tegami3)
tegami_offset3 = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
load_image("201010090", "content_still_20101009_image", "201010090_StillImage")
load_image("201010100", "content_still_20101010_image", "201010100_StillImage")
load_image("201010110", "content_still_20101011_image", "201010110_StillImage")
 --tegami2 = setup_prop_object(10106003)
 --set_pos(tegami2,{0.449, 0.818, -10.717})
 --set_rot(tegami2,{0,90, 180})
 --pen = setup_prop_object(10106006)
 --on_parent(pen,Actor003, "Loc_weapon_constrint_R", {0,0,0,0,0,0})
-- ▲直接出力
-- ▼直接出力
load_image("201010140", "content_still_20101014_image", "201010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	Actor009 = InitializeCharacter_2DOnly("101013","001","101013001")
	Actor010 = InitializeCharacter_2DOnly("101018","001","101018001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:力を奪う魔術師？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310004")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
PlayPartVoiceDirect("トリスタン","0008")
-- ▲直接出力

	--★★トリスタン★★:そう。ここ最近、生徒が身体能力の一部を<br>失ったという報告が頻発してる
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310005")


	--★★トリスタン★★:彼らは皆、バルバロイ討伐に出た際に<br>ある魔術師の姿を見ているそうなんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310006")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力

	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_009_0310009","EA_009_0310010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなこと、本当に可能なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310013")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:さぁ？もしできたとしても<br>かなり高度な魔術にはなるだろうね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0034")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:それこそ、王付きの宮廷魔術師くらいの<br>レベルじゃないと難しいんじゃないかな
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310015")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:まあ、そんな人間がそういるとは思えないけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園はなにも対処しないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0034")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:一応、事態収拾のために<br>ケイが調査を始めてはいるけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ただ、後手後手に回っているみたいだね<br>今は対処すべきことが多すぎるからさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310021")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310022")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
force_lipsync(Actor001,"Close2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:（力を奪う魔術師…<br>ディナタンの声を奪ったのもそいつなのか？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_009_0310024")

-- ▼直接出力
force_lipsync(Actor001,"Auto")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:………
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0310025")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:もしその魔術師が力を奪っていたとしたら…<br>そいつを倒せば奪われた力は戻るのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310026")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:<dot>本当に</dot>奪われているのなら<br>取り戻せる可能性は充分あるだろうね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310027")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力

	--★★ディナタン★★:………？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0310031")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
wait_time(3.0)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
force_lipsync(Actor003,"Close1")
PlayPartVoiceDirect("トリスタン","0002")
-- ▲直接出力

	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310033")

	change_face(Actor003,"Surprise")

	--★★ディナタン★★:！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0310034")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
force_lipsync(Actor003,"Auto")
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力

	--★★トリスタン★★:コンサート、中止にするなら早めに教えてよ<br>ボクも暇じゃないんだから
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0015")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:…っ！<br>おい、なんだよその言いかた―
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ディナタン★★:～～！！！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0310037")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
se_play("SE_ADV_MA_01A900_30_Pen_Writing_01")
wait_time(1.5)
se_play("SE_ADV_MA_01105_28_Paper")
wait_time(0.7)
on_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
on_active(tegami2)
PlayActionDirect(Actor001,"to ReadLetter")
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
change_face(Actor001,"Surprise")
fadein(0.5)
show_image("201010140", 0.0, 0.0, 0.0)
wait_time(2.0)
wait_time(CHARA_IN_OUT + 0.5)
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
setup_small_camera_start(Camera001)
hide_image()
fadein(1.0)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:これを読めって？なになに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310041")

-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:「トリスタンさんにそんなこと言わないで<br>コンサートのために曲を作ってくれたんだから」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:そうなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0034")
-- ▲直接出力

	--★★トリスタン★★:…まあ、それくらいは別に
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310045")


	--★★ノワール★★:「そのうえ当日は演奏もしてくれる予定なの<br>歌の練習にもたくさんつきあってくれて」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310047")


	--★★ノワール★★:「最初に相談したときからコンサートのこと<br>なにかと気にかけてくれて、感謝してるの」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310048")


	--★★ノワール★★:「歌う私が歌いやすいかどうか気にして<br>何度も曲の微調整してくれて。それに――」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310049")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:…もういい、もういいから<br>そのくらいにしてくれる
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310050")

-- ▼直接出力
setup_small_camera_end()
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0037")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…そうだったのか。ごめん、トリスタン<br>俺、なにもわかっていなくて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310051")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
off_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
off_active(tegami2)
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力

	--★★トリスタン★★:…ああ、もう本当に<br>キミたち兄妹の相手をすると調子狂う
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310052")

-- ▼直接出力
force_lipsync(Actor001,"Close1")
force_lipsync(Actor003,"Close1")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor003,"Surprise")

	--★★ノワール／ディナタン★★:？
	Talk(Actor008,"CHRNAME_NOIR_DINATAN","speech","L","EA_009_0310053")

-- ▼直接出力
setup_small_camera_start(Camera001)
lookat_delay_weight_reset(Actor001,0.2)
-- ▲直接出力
-- ▼直接出力
 --force_lipsync(Actor001,"Auto")
 --force_lipsync(Actor003,"Auto")
PlayPartVoiceDirect("ガウェイン","0013")
-- ▲直接出力
	close_cutin()
	change_face(Actor009,"Laugh")

	--★★ガウェイン2★★:そんなこと言って放っておけないくせに～
	Talk(Actor009,"CHRNAME_GAWAIN","speech","L","EA_009_0310054")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力
	change_face(Actor010,"Laugh")

	--★★ラグネル2★★:ね～
	Talk(Actor010,"CHRNAME_RAGNAR","speech","L","EA_009_0310055")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
force_lipsync(Actor001,"Auto")
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力

	--★★ノワール★★:ガウェイン、ラグネル！<br>それにラヴェインも…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310058")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor006)
Appear(Actor004)
Appear(Actor005)
set_enable_auto_lookat(Actor005, false)
lookat_weight(Actor005,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor005,Actor003,"J_Head")
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0004")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:よう。様子を見に来たぜ、ダチ公
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310059")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0002")
setup_small_camera_end()
-- ▲直接出力

	--★★ラグネル★★:ディナタンちゃん、具合はどう？<br>声が出なくなったって聞いたけど――
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310060")

-- ▼直接出力
setup_small_camera_start(Camera003)
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:………
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0310062")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
setup_small_camera_start(Camera005)
on_parent(tegami3,Actor005, "Loc_weapon_constrint_L", tegami_offset3)
on_active(tegami3)
PlayActionDirect(Actor005,"to ReadLetter")
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to ReadLetter")
lookat_delay_weight_reset(Actor005,0.7)
se_play("SE_ADV_MA_01A900_30_Pen_Writing_01")
wait_time(1.5)
se_play("SE_ADV_MA_01105_28_Paper")
wait_time(1.0)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力

	--★★ラグネル★★:
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310064")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0026")
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラグネル★★:衣装合わせはもうバッチリ終わってるしさ<br>いざとなったらファッションショーもできるよ！
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310065")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:年明け一発目のイベントがファッションショーか<br>まぁ悪くはねーけど…
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310066")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
off_parent(tegami3,Actor005, "Loc_weapon_constrint_L", tegami_offset3)
off_active(tegami3)
set_enable_auto_lookat(Actor005,true)
PlayActionDirect(Actor005,"to Sit01_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:もしかして、<br>ラグネルもコンサートを手伝っているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310067")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0007")
-- ▲直接出力

	--★★ラグネル★★:うん。衣装制作担当<br>かわいいステージ衣装、楽しみにしててね！
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310068")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310069")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:なんたってアーサー様のＧＯサインが出てっから<br>もちろん、生徒会も全面協力だ！すげーだろ！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310070")

-- ▼直接出力
setup_small_camera_end()
change_face(Actor003,"Normal")
change_face(Actor005,"Normal")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_009_0310072","EA_009_0310073","EA_009_0310074")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0047")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:すごいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310077")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0008")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:だろ！そうだよなぁ！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310078")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:皆がそれだけ協力してくれるなんて…<br>きっとディナタンの熱意が皆に通じたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310079")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ガウェイン★★:あれ、そっち？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310080")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0025")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ラグネル★★:逆にどっちだと思ったのよ
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310081")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:生徒会も協力してくれているのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310084")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0007")
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ラヴェイン★★:ええ<br>アーサー様から直々にお願いもされましたし…
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310085")

	change_face(Actor006,"Smile")

	--★★ラヴェイン★★:学園が盛り上がることには、生徒会としても<br>ぜひ協力させていただきたいですから
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310086")

	change_face(Actor007,"Normal")

	--★★エレイン★★:お兄ちゃん…
	Talk(Actor007,"CHRNAME_ELAINE","speech","L","EA_009_0310087")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Laugh")

	--★★ラヴェイン★★:それに新しい年が良いものになるようにと願って<br>皆で一緒に歌う時間は素敵なものです
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310088")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0010")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ラヴェイン★★:ですよね、エレイン
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310089")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0007")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★エレイン★★:…うん！
	Talk(Actor007,"CHRNAME_ELAINE","speech","L","EA_009_0310090")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0036")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ラグネル、協力してくれてありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310093")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ラグネル★★:どういたしまして<br>でも、感謝してるのはあたしのほうだったり
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310094")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310095")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0034")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ラグネル★★:正直なところさ<br>なにかしてないと落ち着かないんだよね
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310096")

	change_face(Actor005,"Sad")

	--★★ラグネル★★:じゃないと、油断すると気が滅入っちゃうから
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310097")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
force_lipsync(Actor003,"Close1")
PlayPartVoiceDirect("ラグネル","0036")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラグネル★★:だから…あたしこそありがと<br>ディナタンちゃん
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310098")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ディナタン★★:…！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0310099")

	change_face(Actor004,"Normal")

	--★★ガウェイン★★:おーい、俺をスルーしないでもらっていいか？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310101")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:この流れでよく割って入れるね、キミ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310102")

	goto Block2end

::Block2end::
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor005, true)
set_enable_auto_lookat(Actor003, true)
PlayPartVoiceDirect("ガウェイン","0008")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:衣装ラグネル、作詞エレイン、作曲トリスタン<br>んでもってステージ総合演出はマルディサント！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310104")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0011")
-- ▲直接出力

	--★★ガウェイン★★:こいつはかなり豪華な布陣じゃねーか！？<br>なんかドキドキしてきちまった！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310105")


	--★★ガウェイン★★:これは最高なコンサートになりそうだぜ！<br>そう思うよな！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310106")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:あ、ああ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310107")

	change_face(Actor003,"Sad")

	--★★ディナタン★★:………
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0310109")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0028")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ラグネル★★:…？ディナタンちゃん、どうかした？
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310110")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
force_lipsync(Actor003,"Close1")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:！！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0310111")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
setup_small_camera_start(Camera005)
on_parent(tegami3,Actor005, "Loc_weapon_constrint_L", tegami_offset3)
on_active(tegami3)
PlayActionDirect(Actor005,"to ReadLetter")
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to ReadLetter")
lookat_delay_weight_reset(Actor005,0.7)
se_play("SE_ADV_MA_01A900_30_Pen_Writing_01")
wait_time(1.5)
se_play("SE_ADV_MA_01105_28_Paper")
wait_time(1.0)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力

	--★★ラグネル★★:「大丈夫、なんでもないです」…そう？<br>それならいいんだけど…
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310113")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:とにかく、新年コンサートは学園の重い空気を<br>ぶち破ってくれる催しになること間違いなしだ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310114")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガウェイン★★:
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310115")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
off_parent(tegami3,Actor005, "Loc_weapon_constrint_L", tegami_offset3)
off_active(tegami3)
PlayActionDirect(Actor005,"to Sit01_Loop")
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わからない。ただ…『力を奪う魔術師』が<br>カギを握ってるんじゃないかと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310116")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0034")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ラヴェイン★★:…確かに、そうした事例が学園で<br>増えているのは間違いありませんね
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310117")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0016")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ガウェイン★★:そいつがディナタンの声を奪ったってのか！<br>許せねえ！必ず見つけてやる！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310118")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0025")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ラグネル★★:…と言いたいところだけど、あたしたちも<br>これから見回りがあるんだよね
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310119")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボクも別件があってね。そろそろ出ないと
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","EA_009_0310120")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0037")
-- ▲直接出力

	--★★ラグネル★★:ごめんね、協力できなくて…
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310121")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いいんだ。その気持ちだけで充分だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310122")


	--★★ラヴェイン★★:では、私がお手伝いいたしますよ
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310123")

	PlayAction(Actor007,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0028")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★エレイン★★:
	Talk(Actor007,"CHRNAME_ELAINE","speech","L","EA_009_0310124")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0007")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ラヴェイン★★:幸い、生徒会の仕事はひと段落していますし<br>学園を騒がす問題を放置できませんから
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310125")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0036")
-- ▲直接出力

	--★★ノワール★★:助かるよ。ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310126")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ガウェイン★★:そういや<br>マルディサントは一緒じゃねぇのか？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_009_0310127")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、マルディサントは<br>コンサートの演出で忙しいらしくて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310128")

-- ▼直接出力
setup_small_camera_start(Camera007)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Angry")
	change_face(Actor007,"Anger")

	--★★エレイン★★:「アタシが演出でキバッてる間<br>ディーナのことしっかり守れよゴルァ！！」
	Talk(Actor007,"CHRNAME_ELAINE","speech","L","EA_009_0310129")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0030")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ラヴェイン★★:エレイン！？
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310130")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0010")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★エレイン★★:…と言われているので、私がんばります！
	Talk(Actor007,"CHRNAME_ELAINE","speech","L","EA_009_0310131")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0025")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ラヴェイン★★:マルディサントさんのお言葉ですか…<br>心臓が止まるかと思いました
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310132")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラグネル★★:それじゃ…<br>ディナタンちゃん、無理しないでね
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_009_0310133")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
force_lipsync(Actor003,"Close1")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0310135")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Hide(Actor004)
Hide(Actor005)
change_face(Actor007,"Normal")
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★ラヴェイン★★:では、まずは情報を集めましょうか<br>敵を知らねば対処のしようがありません
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","EA_009_0310137")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力

	--★★ノワール★★:そうだな。手分けして<br>『力を奪う魔術師』のことを調べよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0310138")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
wait_time(1.0)
show_image("201010090", 0.0, 0.0, 0.0)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
show_image("201010100", 0.0, 0.0, 0.0)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
show_image("201010110", 0.0, 0.0, 0.0)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106003)
tegami_offset2 = {0,0,0,0,0,0}
setup_prop_object_preload(10106003)
tegami_offset3 = {0,0,0,0,0,0}
load_image_preload("201010090", "content_still_20101009_image", "201010090_StillImage")
load_image_preload("201010100", "content_still_20101010_image", "201010100_StillImage")
load_image_preload("201010110", "content_still_20101011_image", "201010110_StillImage")
load_image_preload("201010140", "content_still_20101014_image", "201010140_StillImage")
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("101013","001","101013001")
	InitializeCharacter_2DOnly_Preload("101018","001","101018001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
