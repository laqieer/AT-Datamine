-- このluaスクリプトは、CO_101026_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110271_51","110271_51_h")
Include("content_adv_advsmall_110271_51","Template110271_51_h")
Include("content_adv_advsmall_110271_51","110271_51_h")
Include("content_adv_advsmall_110271_51","Template110271_51_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110271_51_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110271_51_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110271_51_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110271_51_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_007)
	Camera005 = SetTemplate("Actor005",-22,CharaPos110271_51_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_005)
	Camera006 = SetTemplate("Actor006",45,CharaPos110271_51_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_004)
	Camera007 = SetTemplate("Actor007",-24,CharaPos110271_51_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_510_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110271_51_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_003)
	InitializeTemplateRandomCamera110271_51()
	InitializeTemplate110271_51()
-- ▼直接出力
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110271_51_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110271_51_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110271_51_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110271_51_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110271_51_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110271_51_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110271_51_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_510_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110271_51_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110271_51,CameraPos110271_51_006)
	InitializeTemplateRandomCamera110271_51()
	InitializeTemplate110271_51()
-- ▼直接出力
Ef_0002     = load_particle("content_effect3d_common_adv", "Ef_C_Adv_WaterSplash", false, false)
 --set_pos(Ef_0002,{-1,1.373,7.199})Camera002用
 --set_rot(Ef_0002,{6.521,1.355,11.768})Camera002用
set_scale(Ef_0002,{0.05,0.05,0.05})
set_pos(Ef_0002,{-0.933,1.372,7.116})
set_rot(Ef_0002,{6.66,-0.013,-0.106})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
tray001 = setup_prop_object(10104006)
set_pos(tray001 , {-0.139,0,7.117})
set_rot(tray001,{0,14.438, 0})
-- ▲直接出力
-- ▼直接出力
teacup001 = setup_prop_object(10104008)
set_pos(teacup001 , {0.072,0.077,7.211})
set_rot(teacup001,{168.676, -50.442, 4.692})
-- ▲直接出力
-- ▼直接出力
saucer001 = setup_prop_object(10104009)
set_pos(saucer001 , {-0.144,0,7.023})
-- ▲直接出力
-- ▼直接出力
teapot001 = setup_prop_object(10104010)
set_pos(teapot001 , {-0.170,0.066,7.582})
set_rot(teapot001,{-21.068, -27.623, 90})
-- ▲直接出力
-- ▼直接出力
teacup002 = setup_prop_object(10104008)
set_pos(teacup002 , {-0.171,0.074,7.146})
set_rot(teacup002,{9.505, -33.701, 176.984})
-- ▲直接出力
-- ▼直接出力
saucer002 = setup_prop_object(10104009)
set_pos(saucer002 , {0.150,0.03,7.545})
-- ▲直接出力
-- ▼直接出力
off_active(teacup001)
-- ▲直接出力
-- ▼直接出力
off_active(saucer001)
-- ▲直接出力
-- ▼直接出力
off_active(teapot001)
-- ▲直接出力
-- ▼直接出力
off_active(teacup002)
-- ▲直接出力
-- ▼直接出力
off_active(saucer002)
-- ▲直接出力
-- ▼直接出力
off_active(tray001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110271)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401023","001","401023001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401024","001","401024001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なあ、これ…<br>なんのパーティなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04020002")

-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:俺もよくは知らないけど<br>いろんな国の貴族やお偉いさんが集まって
	Talk(Actor004,"NPCNAME_0246","speech","N","CO_101026_04020003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）③★★:円卓の騎士の活動を支援する<br>動きがあるそうでさ
	Talk(Actor004,"NPCNAME_0246","speech","N","CO_101026_04020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:それに向けての<br>顔合わせみたいなもんなんだって
	Talk(Actor003,"NPCNAME_0243","speech","N","CO_101026_04020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04020006")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("貴族_男1", "納得")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★貴族（男）★★:あなたがパーシヴァル様ですか<br>お父上のご高名は聞き及んでおります
	Talk(Actor005,"NPCNAME_0354","speech","N","CO_101026_04020008")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
template2()
turn_chara(Actor005, -134, 0)
turn_chara(Actor006, -130, 0)
turn_chara(Actor007, -101, 0)
wait_time(0.2)
setup_small_camera_start()
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_男1", "喜び")
-- ▲直接出力

	--★★貴族（男）★★:あなたご自身も円卓の騎士のひとりだそうで<br>さすがの血統といえますな！
	Talk(Actor005,"NPCNAME_0354","speech","N","CO_101026_04020009")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:はっはっは！<br>いやあ、まあ、それほどでもありませんよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020010")

-- ▼直接出力
lookat_delay_weight(Actor001, {0.7, 0.08, 0.7, 0.6} , 1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力

	--★★ノワール★★:（それほどでもあるって顔をしているな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101026_04020011")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("貴族_男2", "納得")
-- ▲直接出力

	--★★貴族（男）②★★:それで、ひとつ相談がありましてな<br>今回の計画がうまくいった暁には
	Talk(Actor006,"NPCNAME_0355","speech","N","CO_101026_04020012")


	--★★貴族（男）②★★:円卓の騎士の皆さまで<br>私の家族や屋敷を優先的に守ってもらえるよう
	Talk(Actor006,"NPCNAME_0355","speech","N","CO_101026_04020013")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("貴族_男2", "照れ")
-- ▲直接出力

	--★★貴族（男）②★★:アーサー王にはたらきかけていただきたいのです<br>もちろん、そのぶんの色はお付けいたしますので
	Talk(Actor006,"NPCNAME_0355","speech","N","CO_101026_04020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★パーシヴァル★★:………
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020016")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor008)
turn_chara(Actor008, -3.79, 0)
turn_chara(Actor007,-174.125, 0)
turn_chara(Actor005, 131.37, 0)
turn_chara(Actor006, -199.02, 0)
wait_time(0.2)
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to  Std_Surp")
on_active(teacup001)
on_active(saucer001)
on_active(teapot001)
on_active(teacup002)
on_active(saucer002)
on_active(tray001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:パーシヴァル？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04020017")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
se_play("SE_ADV_CO_101026_0402_Tableware_Drop")
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor008, false)
setup_small_camera_start()
lookat_delay_weight_reset(Actor001 , 0.6)
-- ▲直接出力
	PlayAction(Actor008,"to Bow")
-- ▼直接出力
PlayPartVoice("現代男子", "驚き")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★キャメロット騎士学術院（男）★★:あああっ、すみません！
	Talk(Actor008,"NPCNAME_0269","speech","L","CO_101026_04020019")

	PlayAction(Actor007,"to  Std_Angry")
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("貴族_女2", "驚き")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★貴族（女）★★:ななな、なんてこと！？<br>ワタクシのドレスが汚れてしまったじゃないの！
	Talk(Actor007,"NPCNAME_0356","speech","N","CO_101026_04020020")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("現代男子", "落胆")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★キャメロット騎士学術院（男）★★:す、すぐお拭きいたしますので…！
	Talk(Actor008,"NPCNAME_0269","speech","L","CO_101026_04020021")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_女2", "激怒")
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★貴族（女）★★:やめて！<br>汚らしい手で触らないでちょうだい！
	Talk(Actor007,"NPCNAME_0356","speech","N","CO_101026_04020022")

-- ▼直接出力
keep_ik_lookat(Actor007, Actor008, "J_Head")
lookat_delay_weight(Actor007, {0.7, 0.08, 0.7, 0.6} , 1.0)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Angry")

	--★★貴族（女）★★:このドレスがいくらするか知っているの！？<br>あなたなどが一生働いても稼げない金額なのよ！
	Talk(Actor007,"NPCNAME_0356","speech","N","CO_101026_04020023")

	PlayAction(Actor008,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("現代男子", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:あ、あああ…
	Talk(Actor008,"NPCNAME_0269","speech","L","CO_101026_04020024")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("貴族_女2", "怒り")
-- ▲直接出力

	--★★貴族（女）★★:あなた、どう落とし前をつけるつもりなの！？
	Talk(Actor007,"NPCNAME_0356","speech","N","CO_101026_04020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101026_04020027","CO_101026_04020028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:いくら高いドレスだからって<br>言っていいことと悪いことがあるだろう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04020030")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Anger")

	--★★ノワール★★:ひとこと言ってやらないと気が済まない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04020031")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera003)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,198,0.5)
wait_time(0.5)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
lookat_delay_weight(Actor001, {0.7, 0.08, 0.7, 0.6} , 1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:パーシヴァル…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04020033")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:キミは黙って見ているだけでいい
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020034")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんて言い草だ<br>これだから貴族ってやつは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04020036")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:「貴族ってやつは好きになれない」<br>かい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020037")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
lookat_delay_weight(Actor001, {0.7, 0.08, 0.7, 0.6} , 1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04020038")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera003)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,92.977,0.5)
turn_chara(Actor005, -115, 1)
turn_chara(Actor006, -125.887, 0)
lookat_delay_weight_reset(Actor003 , 1)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_delay_weight(Actor003, {0.7, 0.08, 0.7, 0.6} , 1.0)
lookat_delay_weight_reset(Actor007 , 1)
turn_chara(Actor007, -98.927, 0)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
on_active(Ef_0002)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor008,"to Wlk")
turn_chara(Actor008, -74.865,0.5)
wait_time(0.5)
PlayActionDirect(Actor008,"to  Std_Talk")
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_delay_weight(Actor004, {0.7, 0.08, 0.7, 0.6} , 1.0)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("現代男子", "驚き")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★キャメロット騎士学術院（男）★★:えっ！？<br>な、なにをなさっているのです！
	Talk(Actor008,"NPCNAME_0269","speech","N","CO_101026_04020064")


	--★★キャメロット騎士学術院（男）★★:ご自分の制服に<br>飲み物をかけるだなんて！！ 
	Talk(Actor008,"NPCNAME_0269","speech","N","CO_101026_04020040")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:あああ、なんということだ！<br>ボクのお気に入りの制服が汚れてしまった！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020042")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★パーシヴァル★★:オーダーメイドの一着で<br>城をひとつ建てられるくらい高価なものなのに！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020043")

	PlayAction(Actor008,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("現代男子", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:えええっ！？
	Talk(Actor008,"NPCNAME_0269","speech","N","CO_101026_04020044")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えええっ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_04020045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:でも、こんなものは洗えばどうにでもなる<br>すぐにもとどおりさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020047")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ただね。もしもこんなことのために<br>キミの心がキズついてしまったとしよう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020048")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力

	--★★パーシヴァル★★:心のキズは洗い流すことはできない<br>すぐにはもとどおりにならない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020049")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★パーシヴァル★★:だから、キミが気に病む必要などないのさ<br>いいね？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020050")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("現代男子", "落胆")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★キャメロット騎士学術院（男）★★:は、はい…
	Talk(Actor008,"NPCNAME_0269","speech","N","CO_101026_04020051")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:あなたは<br>なにか勘違いしているようだな
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020053")

-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 1)
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★貴族（女）★★:えっ？
	Talk(Actor007,"NPCNAME_0356","speech","N","CO_101026_04020054")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:貴族が偉いのではない<br>ボクらはたまたま貴族に生まれただけだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:額に汗して働く彼らのような存在がいるから<br>貴族は貴族でいられる
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力

	--★★パーシヴァル★★:彼らは自分が自分であるために<br>新しい自分を見つけるために努力をし続けている
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020057")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★パーシヴァル★★:本当に讃えられるべきは彼らなのだ<br>彼らへの感謝の気持ちを忘れてはならない
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020058")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★パーシヴァル★★:彼らを虐げたり、自分だけ守ってもらおうなど<br>恥ずかしい行為であると知るべきだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_04020060")

-- ▼直接出力
setup_small_camera_start()
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Sad02")
	change_face(Actor005,"Sad")

	--★★貴族（男）★★:………
	Talk(Actor005,"NPCNAME_0354","speech","N","CO_101026_04020061")

-- ▼直接出力
SkipDefaultMotion(Actor006)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Worry")
	change_face(Actor006,"Sad")

	--★★貴族（男）②★★:………
	Talk(Actor006,"NPCNAME_0355","speech","N","CO_101026_04020062")

-- ▼直接出力
SkipDefaultMotion(Actor007)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Sad01")
	change_face(Actor007,"Sad")

	--★★貴族（女）★★:………
	Talk(Actor007,"NPCNAME_0356","speech","N","CO_101026_04020063")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ4_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_WaterSplash", false, false)
setup_prop_object_preload(10104006)
setup_prop_object_preload(10104008)
setup_prop_object_preload(10104009)
setup_prop_object_preload(10104010)
setup_prop_object_preload(10104008)
setup_prop_object_preload(10104009)
	InitializeLoad_Preload()
	load_area_scene_preload(110271)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401023","001","401023001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401024","001","401024001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110271_51)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
