-- このluaスクリプトは、MA_01A112_20.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_08","111012_08_h")
Include("content_adv_advsmall_111012_08","Template111012_08_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111012_08_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_012)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111012_08_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111012_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111012_08_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111012_08_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111012_08_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111012_08_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_012)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111012_08_011,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_011)
	Camera009 = SetTemplate("Actor009",nil,CharaPos111012_08_012,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_012)
	InitializeTemplateRandomCamera111012_08()
	InitializeTemplate111012_08()
-- ▼直接出力
lookat_weight(Actor001,0.6,0.03,0.7,0)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
change_face(Actor007,"Anger")
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{-2.12,0,-8.45})
set_rot(Actor008,{0,20.5,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor009,{2.38,0,-8.8})
set_rot(Actor009,{0,-42,0})
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
Ef_Emblem01 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem13", false)
Ef_Emblem02 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem13", false)
Ef_Emblem03 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
set_pos(Ef_Emblem03,CharaPos111012_08_011)
Ef_Emblem04 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
set_pos(Ef_Emblem04,CharaPos111012_08_012)
Ef_Emblem05 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
set_pos(Ef_Emblem05,{CharaPos111012_08_012[1],1.21,CharaPos111012_08_012[3]})
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_AfterGinevia_General1_Start")
-- ▲直接出力
-- ▼直接出力
CameraEX = set_camera({0.07, 1.26, -7.65,   9.728, 182.2, 359.98,   35})
-- ▲直接出力
-- ▼直接出力
CameraEX2 = set_camera({0.736, 1.478, -9.21,   9.728, 180, 359.98,   18})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101037","002","101037002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_TextOnly()
	Actor011 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Talk")

	--★★ガウェイン★★:ガキめいた夢もってたぜ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★ガウェイン★★:世のなかにはさ<br>正義と悪がいてよ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200003")

	PlayAction(Actor005,"to  Std_Angry")
	change_face(Actor005,"Smile")

	--★★ガウェイン★★:正義ってのはめちゃくちゃに強くて格好いい<br>ンな奴になりてえって──アンタに憧れてた
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
change_face(Actor005,"Normal")
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:私はローマの軍人だ<br>属した組織が腐ろうが務めを果たす義務がある
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_200005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Anger")

	--★★ラグネル★★:逃げないでよ、ヴェルナルス
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_200006")

	change_face(Actor001,"Anger")

	--★★ラシア★★:…ヴェルナルス様が、いつ、逃げました…？
	Talk(Actor001,"CHRNAME_RASIA","speech","R","MA_01A112_200008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★ラグネル★★:黙って聞いてよドラゴンキラー
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_200009")

	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Normal")

	--★★ガウェイン★★:世のなか正義と悪だけじゃねーってことぐらい<br>ちょっとすりゃあわかってきたんだ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200010")


	--★★ガウェイン★★:だからさヴェルナルス<br>あんたがそっち行ったのだって、わかるよ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200011")


	--★★ガウェイン★★:あんたらには国への忠誠があって<br>軍人武人の務めと役割があって
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200013")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★ガウェイン★★:それがあんたらの正義なんだろうぜ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200014")

	PlayAction(Actor006,"to  Std_No")

	--★★ラグネル★★:だけどね、世のなかには<br>『やっちゃいけないこと』ってのがあるの
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_200015")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ガウェイン★★:それこそシンプル<br>ガキに教える倫理のハナシだ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200016")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力

	--★★ラグネル★★:『誰かをキズつけること』よ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_200017")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ギネヴィア★★:…！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A112_200018")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEX)
slidemove(CameraEX,{0.07, 1.7, -7.65},5.8)
PlayActionDirect(Actor001,"to Bow")
wait_time(0.5)
effect_at_character(Actor002, "Chest", Ef_Emblem01, 0.0, 0.15, 0.0)
effect_at_character(Actor001, "Chest", Ef_Emblem02, 0.0, 0.15, 0.0)
on_active(Ef_Emblem03)
play_particle(Ef_Emblem03)
on_active(Ef_Emblem04)
play_particle(Ef_Emblem04)
wait_time(1.0)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.4)
on_active(Ef_Emblem05)
play_particle(Ef_Emblem05)
wait_time(0.5)
fadeout(255,255,255,1,0.5)
wait_time(0.5)
Hide(Actor001)
Appear(Actor007)
lookat_weight_reset(Actor007)
wait_time(0.5)
fadein(0.5)
wait_time(1.5)
off_active(Ef_Emblem01)
off_active(Ef_Emblem02)
stop_particle(Ef_Emblem03)
stop_particle(Ef_Emblem04)
stop_particle(Ef_Emblem05)
setup_small_camera_start(CameraEX2)
on_active(FX_DoF)
slidemove(CameraEX2,{0.736, 1.54, -9.21},5)
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Anger")

	--★★ラシア2★★:幼稚な論理は、もう…いい
	Talk(Actor007,"CHRNAME_RASIA2","speech","R","MA_01A112_200020")

-- ▼直接出力
setup_small_camera_start()
off_active(FX_DoF)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネヴィア★★:そう、ね
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A112_200021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
lookat_weight(Actor007,0.6,0.03,0.7,0)
set_enable_auto_lookat(Actor007,true)
set_enable_auto_lookat(Actor003,false)
lookat_weight(Actor003,0.5,0.03,0.8,0)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",2)
-- ▲直接出力

	--★★ノワール★★:ギネヴィア？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_200022")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:…誰かにキズをつけたなら<br>報いを受けなきゃならないわね
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A112_200023")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
lookat_delay_weight_reset(Actor003,0.5)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_No")

	--★★ラシア2★★:わかっています、わかりきったことです…！
	Talk(Actor007,"CHRNAME_RASIA2","speech","R","MA_01A112_200024")

	PlayAction(Actor006,"to  Std_Sad02")
	change_face(Actor006,"Sad")

	--★★ラグネル★★:あたし、バルバロイに喰われた友達いっぱいいる<br>キズつけられて泣いてる子、いっぱい知ってる
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_200025")

	PlayAction(Actor007,"to  Std_Talk")

	--★★ラシア2★★:覚悟して戦いに臨んだはずです<br>いまさら──
	Talk(Actor007,"CHRNAME_RASIA2","speech","R","MA_01A112_200026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Angry")
	change_face(Actor006,"Anger")

	--★★ラグネル★★:ただただそんなの見るのは悲しいっつってんの<br>おまえらにどんな理由があろうとさァ…ッ！
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_200027")


	--★★ガウェイン★★:ヴェルナルス、なんであんたが<br>俺らから逃げ続けてんのか、考えたんだよ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200029")


	--★★ガウェイン★★:…後ろめたいんだろ、あんた
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Angry")
-- ▲直接出力

	--★★ラシア2★★:２度目の侮辱ですッ！！<br>ヴェルナルス様と旧知の仲とはいえ、もう──
	Talk(Actor007,"CHRNAME_RASIA2","speech","R","MA_01A112_200031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ヴェルナルス大将軍★★:そうだったよ、ずっと
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_200033")

-- ▼直接出力
PlayActionDirect(Actor007,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★ラシア2★★:ヴェルナルス様！！
	Talk(Actor007,"CHRNAME_RASIA2","speech","R","MA_01A112_200034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★ヴェルナルス大将軍★★:憧れに目を輝かせるお前たちに追われるほど<br>なぜだか背を向けてしまいたくなった
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_200035")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:………ヒーローに追われたからね
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A112_200036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス大将軍★★:そう、か…<br>…そうして背を向け逃げる私は──
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_200038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","MA_01A112_200040","MA_01A112_200041")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ただの悪党だ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_200043")

	PlayAction(Actor007,"to  Std_Angry")
	change_face(Actor007,"Anger")

	--★★ラシア2★★:継承者！！
	Talk(Actor007,"CHRNAME_RASIA2","speech","R","MA_01A112_200044")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:あなたも承知でそちらについたはずよ<br>いまさら憤る筋合いはないわ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01A112_200045")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:背を見せて語る師でもあったはずだ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_200047")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★ガウェイン★★:…そうかもしんねーな
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200048")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ヴェルナルス大将軍★★:いいや…ただの悪党だよ<br>承知のうえでこちらについたのだがな
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_200049")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:そしてガウェインとラグネルは…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_200051")


	--★★テロップ★★:「立てよ。転校生の悪口言ったヤツは」<br>「俺たちが護衛してやんなきゃあ」
	Talk(Actor010,"telop","narration","N","MA_01A112_200052")


	--★★ノワール★★:俺が出会ったあのときから<br>ここで一緒に戦った最初から
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_200053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")

	--★★ノワール★★:とっくにヒーローだったから
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_200054")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ヴェルナルス大将軍★★:後ろめたくて当然だ
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_200055")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_AfterGinevia_General1_Start")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
change_face(Actor007,"Anger")
-- ▲直接出力
	change_face(Actor005,"Serious")

	--★★ガウェイン★★:もうアンタを追わねえ<br>だけどもう、引きもしねえ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200057")

	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat(Actor007,false)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ラグネル★★:腐っても憧れだったよ<br>それも過去に置いてきたけど
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_200058")

	PlayAction(Actor005,"to  Std_Angry")

	--★★ガウェイン★★:手合わせしようぜ、悪党！
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200059")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
set_pos(Ef_Emblem03,CharaPos111012_08_002)
set_pos(Ef_Emblem04,CharaPos111012_08_003)
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:…断る口実が見つからん
	Talk(Actor002,"CHRNAME_VERNARTH","speech","R","MA_01A112_200060")

-- ▼直接出力
bgm_play("BGM_To_Main")
-- ▲直接出力
-- ▼直接出力
on_active(Ef_Emblem03)
play_particle(Ef_Emblem03)
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ガウェイン★★:陽よ昇れ、夜に差せ、暗きを<ruby=い>出</ruby>で
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200062")

-- ▼直接出力
on_active(Ef_Emblem04)
play_particle(Ef_Emblem04)
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★ラグネル★★:来たる光を三重に宿せ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01A112_200064")

-- ▼直接出力
lookat_weight(Actor005,0.5,0.03,0.8,0)
keep_delay_ik_lookat(Actor005,Actor006,"J_Head",1)
-- ▲直接出力

	--★★ガウェイン★★:ラグネル──
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","MA_01A112_200066")

-- ▼直接出力
CloseTalkWindow()
show_image("101010150", 0.0, 0.0,0.3,false,false)
set_scale_image(20,20)
wait_time(0.5)
-- ▲直接出力
	open_cutin(2,2)
	on_cutin(1,Actor006,"Anger")
	on_cutin(2,Actor005,"Anger")

	--★★ガウェイン／ラグネル★★:因枢分解・ガラティン！！
	Talk(Actor011,"CHRNAME_GAWAIN_RAGNAR","simple","N","MA_01A112_200067")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem13", false)
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem13", false)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
preload_sound("BGM_Battle_AfterGinevia_General1_Start")
	InitializeLoad_Preload()
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101037","002","101037002","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111012_08)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
