-- このluaスクリプトは、EA_066_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_006)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
Hide(Actor003)
set_pos(Actor003,{4.253, 0, 1.445})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_LarowShop")
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
-- ▼直接出力
hideobj01 = get_object("Npc_501_03_Nbl_Std01_Loop")
set_pos(hideobj01, {0,-20, 0})
hideobj02 = get_object("Npc_001_02_Com_Std01_Loop")
set_pos(hideobj02, {0,-20, 0})
hideobj03 = get_object("Npc_001_03_Bad_Std01")
set_pos(hideobj03, {0,-20, 0})
hideobj04 = get_object("Npc_001_01_Imp_Std02_Loop")
set_pos(hideobj04, {0,-20, 0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0019")
-- ▲直接出力

	--★★ヴォールス★★:連中の足取りをたどってみたが…<br>いまいち要領を得ないな
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0310003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0007")
-- ▲直接出力

	--★★クレア★★:彼らはこの辺りの伝承について調べていたようね<br>もしかしてあなたと同じものを探しているのかも
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0310005")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ヴォールス★★:同じもの？
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0310006")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0002")
-- ▲直接出力

	--★★クレア★★:『山をも打ち砕く力』を秘めし伝説級の武具<br>この街を最初の目的地に選んだ理由でしょう？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0310007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス★★:ああ――
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0310008")

-- ▼直接出力
setup_small_camera_start()
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ラロゥ★★:へーアンタたちも伝説級の武具が目当てなんだ
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","EA_066_0310009")

	open_cutin(2,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor002,"Surprise")
	change_face(Actor004,"Surprise")

	--★★ヴォールス／クレア★★:
	Talk(Actor004,"CHRNAME_BORS_CLARE","speech","N","EA_066_0310010")

	close_cutin()
-- ▼直接出力
Appear(Actor003)
wait_time(0.1)
turn_chara(Actor003, 270,0.2)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{0.601, 0, 1.835},4)
wait_time(1.5)
bgm_play("BGM_ADV_LarowShop")
wait_time(2.5)
PlayActionDirect(Actor003,"to Std_Loop")
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0001")
-- ▲直接出力

	--★★クレア★★:あなた、確かログレスの街にいた…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0310012")

-- ▼直接出力
--ラロゥ,CHRNAME_LAROU @名前変更
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラロゥ★★:ラロゥだよ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310013")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラロゥ★★:アンタたちとはあんまり話したことなかったよねノワールとはよく話してたんだけどさ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310014")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0028")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0310015")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ラロゥ★★:まぁ、利害の一致ってヤツ？<br>お宝探しには人手が必要でしょ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310016")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラロゥ★★:
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310017")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ラロゥ★★:だから活動範囲を広げてみようと思ってさ<br>狙いは伝説級の武具『山をも打ち砕く力』
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310018")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	PlayAction(Actor003,"to TakeHand")
	change_face(Actor003,"Normal")

	--★★ラロゥ★★:けど、いざこの街に来てみたら<br>ちょっと聞き逃せない話があってさ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310019")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0015")
-- ▲直接出力

	--★★ヴォールス★★:？
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0310020")

-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0002")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラロゥ★★:
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310021")

	open_select_window_tag(Actor001,"Normal","EA_066_0310023","EA_066_0310024")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:海賊か？
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0310027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:お宝探しのライバルの話を聞くわね<br>無い話じゃない、とは思うけど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0310028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Normal")

	--★★ラロゥ★★:ハズレ。バルバロイが暴れてたときに<br>名のある海賊団の多くは壊滅したって聞いたよ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310029")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ラロゥ★★:少しは持ち直してきたかもしれないけど<br>宝探しなんて夢を追う余裕はないんじゃない？
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310030")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0013")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:魔物か？
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0310033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:伝説級の武具を守る魔物<br>ありそうな話ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0310034")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0010")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラロゥ★★:実際それも聞くから半分正解になるのかな<br>求めてた解答とは違うんだけど
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310035")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★ラロゥ★★:ずばり――『聖杯』だよ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0310037")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ヴォールス★★:
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0310038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0046")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:そういえば、あの人が話していたわね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0310039")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:ああ…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0310040")

	EndPlay()
end

