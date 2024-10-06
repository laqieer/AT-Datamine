-- このluaスクリプトは、CO_101030_0203.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",45,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",-20,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera003 = SetTemplate("Actor003",80,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera004 = SetTemplate("Actor004",95,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",-10,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera006 = SetTemplate("Actor006",135,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera007 = SetTemplate("Actor007",-132,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera008 = SetTemplate("Actor008",165,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{0.27,0,-0.7})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-0.45,0,-0.75})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{0.63,0,-0.54})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{0,0,-0.2})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor007,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005,Actor008,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{0.34,0,0.33})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{0.85,0,-1.45})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101010111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor010 = InitializeCharacter_2DOnly("101014","001","101014001")
	Actor011 = InitializeCharacter_2DOnly("101031","001","101031001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor009,"Surprise")

	--★★ノワール2★★:すごい人気だな、エレイン
	Talk(Actor009,"CHRNAME_NOIR","speech","L","CO_101030_02030002")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン2★★:彼女、人見知りなんじゃなかったっけ？
	Talk(Actor010,"CHRNAME_TRISTAN","speech","L","CO_101030_02030003")

-- ▼直接出力
PlayPartVoice("ラヴェイン", "悩む")
PlayActionDirect(Actor007,"to  Std_Yes")
-- ▲直接出力
	change_face(Actor011,"Laugh")

	--★★ラヴェイン2★★:もともとエレインは元気で明るい子だったんですよ
	Talk(Actor011,"CHRNAME_LOVEIN","speech","L","CO_101030_02030004")

-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor002,"to  Std_Yes")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to  Std_Talk")
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor007,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,1)
-- ▲直接出力
	change_face(Actor011,"Normal")

	--★★ラヴェイン2★★:ただ…数年前にちょっと、ありましてね人の目を見て話すのを避けるようになったんです
	Talk(Actor011,"CHRNAME_LOVEIN","speech","L","CO_101030_02030005")

-- ▼直接出力
PlayPartVoice("トリスタン", "納得")
PlayActionDirect(Actor007,"to  Std_Joy")
-- ▲直接出力

	--★★トリスタン2★★:…ふぅん
	Talk(Actor010,"CHRNAME_TRISTAN","speech","L","CO_101030_02030006")


	--★★ラヴェイン2★★:子供の純粋な瞳であれば平気なようですけれどね
	Talk(Actor011,"CHRNAME_LOVEIN","speech","L","CO_101030_02030007")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor006)
Hide(Actor007)
Appear(Actor001)
Appear(Actor005)
Appear(Actor003)
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
Camera001 = setup_small_camera_resetting(Actor001,CharaPosDuelCommonFormation01_005,CameraPosDuelCommonFormation01_005)
Camera002 = setup_small_camera_resetting(Actor002,CharaPosDuelCommonFormation01_002,CameraPosDuelCommonFormation01_002)
Camera003 = setup_small_camera_resetting(Actor003,CharaPosDuelCommonFormation01_006,CameraPosDuelCommonFormation01_006)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
change_face(Actor002,"Normal")
set_pos(Actor002,{1.35,0,-0.86})
turn_chara(Actor002,-28,0)
set_pos(Actor008,{0.95,0,0.13})
turn_chara(Actor008,-78,0)
keep_ik_lookat(Actor002,Actor004, "J_Head")
keep_ik_lookat(Actor008,Actor004, "J_Head")
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:イゾルデさん、この子です
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02030009")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:この子は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02030011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:この街に住む子供でトビーくんといいます
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02030012")

	change_face(Actor002,"Sad")

	--★★エレイン★★:このあいだの戦いで怪我をして<br>目がほとんど見えなくなってしまったんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02030013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なるほど。それを診てもらうためにイゾルデを連れてきたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02030014")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0034")
-- ▲直接出力

	--★★イゾルデ★★:外傷が原因ではなさそうね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101030_02030015")

-- ▼直接出力
wait_time(1)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_weight(Actor004,0.5,0.5,0.5,1)
-- ▲直接出力

	--★★イゾルデ★★:私はそっちの専門家ではないから正しいかどうかはわからないけれど
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101030_02030016")


	--★★イゾルデ★★:精神的なものではないかしら
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101030_02030017")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★イゾルデ★★:たとえば、このあいだの戦争で見たくないものを目撃してしまっただとか
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101030_02030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:心に負った傷が原因で身体に支障をきたすケースはよく耳にするよね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030019")

-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor008,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,1)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★イゾルデ★★:…そうね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","CO_101030_02030020")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0002")
-- ▲直接出力

	--★★トリスタン★★:そういうときってどうするのが一番だと思う？ノワール
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_02030023","CO_101030_02030024","CO_101030_02030025")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん…ゆっくり体と心を休ませてやる、とか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02030027")

-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:残酷な話かもしれないけどさ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030028")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★トリスタン★★:心の傷を癒してくれるのって時間なんだよね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030029")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:誰かが隣にいて話を聞いてあげながら癒えていくのを待つ。それが一番さ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:そう、ですね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02030031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ショック療法はどうだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02030033")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:もっとショッキングな目に遭わせてみるとか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02030034")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★トリスタン★★:キミさ…冗談でも言っていいことと悪いことがあるって、わかってる？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030035")

-- ▼直接出力
PlayPartVoice("エレイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:ひどいです、先輩…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02030036")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ご、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02030037")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:イゾルデもお手上げなんだとしたらあきら…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02030039")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン_002","0056")
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★トリスタン★★:ストップそれ以上は口にしないほうがいい
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030040")

	change_face(Actor003,"Serious")

	--★★トリスタン★★:少なくともここにいる子供たちの前ではね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030041")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:本当にこのあいだの戦いで見たくもないものを見たのだとしたら
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030043")


	--★★トリスタン★★:事件現場にいるのはトビーにとって良くないことかもしれない
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030044")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:どこか落ち着いた場所で休ませてあげるのが得策じゃないかな
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030046")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:落ち着いた、場所…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_02030047")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.5,0.5,0.5,1)
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:おせっかいを焼くのはキミの得意とするところだろ、ノワール？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030048")


	--★★トリスタン★★:じゃ、あとは任せたボクたちはこれで失礼するよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101030_02030049")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
turn_chara(Actor008,150,0)
Hide(Actor003)
Hide(Actor004)
set_enable_auto_lookat(Actor008, false)
keep_ik_lookat(Actor008,Actor002,"J_Head")
wait_time(0.3)
setup_small_camera_start(RndCamera003)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:心の傷を癒してやる、か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_02030051")

-- ▼直接出力
local trustParam = set_communication_rankup("エレイン_コミュランク", "エレイン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101010111)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	InitializeCharacter_2DOnly_Preload("101014","001","101014001")
	InitializeCharacter_2DOnly_Preload("101031","001","101031001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
