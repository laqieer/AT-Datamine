-- このluaスクリプトは、MA_01C111_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
DontChangeRandomCamera(true)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
   prop_001    = load_particle("content_prop_10104007", "10104007_PropModel", false, false)
    set_pos(prop_001,{-0.331, 0.815, -11.246})
    set_rot(prop_001,{0,22.6,0})
-- ▲直接出力
-- ▼直接出力
   prop_002    = load_particle("content_prop_10104007", "10104007_PropModel", false, false)
    set_pos(prop_002,{0.231, 0.815, -12.005})
    set_rot(prop_002,{0,-89.8,0})
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
   prop_003    = load_particle("content_prop_10104007", "10104007_PropModel", false, false)
    set_pos(prop_003,{0.268, 0.815, -11.17})
    set_rot(prop_003,{0,-13.87,0})
-- ▲直接出力
-- ▼直接出力
   prop_004    = load_particle("content_prop_10104007", "10104007_PropModel", false, false)
    set_pos(prop_004,{-0.032, 0.815, -11.759})
    set_rot(prop_004,{0,-89.8,0})
-- ▲直接出力
-- ▼直接出力
Prop_size = {0.8,0.8,0.8}
set_scale(prop_001,Prop_size)
set_scale(prop_002,Prop_size)
set_scale(prop_003,Prop_size)
set_scale(prop_004,Prop_size)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("リオネス","挨拶")
-- ▲直接出力

	--★★リオネス★★:お、ノワールとディナタン<br>いいところに
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01C111_060002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("リオネス","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★リオネス★★:今、ガレスがメニュー開発してるんだ<br>ハロウィン限定のやつ！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01C111_060003")

	PlayAction(Actor004,"to Finger")

	--★★リオネス★★:おまえらも味見係していけ！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01C111_060004")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060005")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:楽しみ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_060006")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
setup_small_camera_start(Camera004)
 --PlayPartVoice("リオネス","喜び")
-- ▲直接出力

	--★★リオネス★★:そうこなくちゃ！<br>それじゃ、そこに座って待て！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01C111_060007")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Appear(Actor003)
PlayActionDirect(Actor004,"to Std_Loop")
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor004,"Normal")
template2()
lookoj = create_object("kara")
set_pos_object(lookoj,0,0,-11.65)
set_pos(Actor003,{3.68,0,-13.4})
set_rot(Actor003,{0,-90,0})
change_face(Actor004,"Smile")
set_enable_auto_lookat_all(true)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
setup_small_camera_start(RndCamera004)
wait_time(TIME_ELAPSED)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{0.48,0,-13.4},2)
fadein(FADE_TIME)
wait_time(1.7)
turn_chara(Actor003,-6,0.3)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
change_face(Actor004,"Normal")
 --PlayPartVoice("ガレス","照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:おっ、ノワールたちも味見してくれるの？<br>嬉しいな～
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
setup_template_moveobj_110122_01(3,true)
setup_template_moveobj_110122_01(4,true)
on_active(prop_001)
on_active(prop_002)
on_active(prop_003)
on_active(prop_004)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("ガレス","気合い")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガレス★★:それじゃいくよ！まずは～<br>ガレスちゃん特製パンプキンパイ！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060010")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
lookat_weight(Actor004,0.8,0.03,0.7,0)
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",1.0)
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",1.0)
 --PlayPartVoice("ノワール","肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おお～
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060011")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
change_face(Actor002,"Smile")
 --PlayPartVoice("ディナタン","喜び")
-- ▲直接出力

	--★★ディナタン★★:すごい！<br>全部おいしそう！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_060012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Talk")
 --PlayPartVoice("ガレス","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:あとパンプキンキッシュにパンプキンプリン<br>パンプキンケーキにパンプキングラタン
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060013")


	--★★ガレス★★:それからパンプキン…
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060014")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:ちょ、ちょっと待ってくれ！<br>まだあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C111_060015")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ガレス","喜び")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Smile")

	--★★ガレス★★:まだまだあるよ！
	Talk(Actor003,"CHRNAME_GARETH","speech","N","MA_01C111_060016")

-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	open_cutin(3,2)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor003,"Smile")
	on_cutin(3,Actor002,"Surprise")

	--★★ノワール★★:まだまだ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C111_060017")

	close_cutin()
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ガレス","照れ")
-- ▲直接出力

	--★★ガレス★★:なんかアイデアが湧いてきちゃってさ～
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060018")

	change_face(Actor003,"Normal")

	--★★ガレス★★:料理に没頭してると<br>余計なこと考えずにすむからな
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060019")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ガレス…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガレス","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:…へへ。それじゃ…全部食べたうえで<br>忌憚なき意見を頼むぞ！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060021")

	open_select_window_tag(Actor001,"Normal","MA_01C111_060022","MA_01C111_060023")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:全部は無理だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060025")

-- ▼直接出力
 --PlayPartVoice("ガレス","悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガレス★★:そうか？<br>兄さんだったら食べてくれるのにな～
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060026")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad01")
 --PlayPartVoice("ガレス","悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガレス★★:あ…もしかして<br>兄さんも無理してたのかな
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんなことは…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060028")

-- ▼直接出力
setup_small_camera_start(Camera003)
PlayActionDirect(Actor003,"to Std_Loop")
 --PlayPartVoice("ガレス","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:冗談だ。兄さんは嘘が下手だから<br>無理してたらすぐにわかる
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060029")

-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,30,0.3)
slidemove(Actor003,{1.6,0,-12.3},1.5)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガレス★★:ほらほら！余計なこと言ってないで<br>さっさと食べる食べる！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060030")

-- ▼直接出力
shake_camera(Camera003,1.5,1)
change_face(Actor004,"Smile")
 --PlayPartVoice("ノワール","苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:モゴモゴモゴッ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","気合い")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:こうなったら乗りかかった船だ<br>とことん食ってやる！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060034")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ガレス","喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:おお！さすがノワール
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060036")

	change_face(Actor003,"Smile")

	--★★ガレス★★:兄さんの次くらいにいい食いっぷりだよ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060037")

-- ▼直接出力
 --PlayPartVoice("ノワール","悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ガレス…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060038")

-- ▼直接出力
setup_small_camera_start(Camera003)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,30,0.3)
slidemove(Actor003,{1.6,0,-12.3},1.5)
 --PlayPartVoice("ガレス","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガレス★★:…おっと？フォークが止まってるぞ～！<br>ほら、次はこっちの料理食べてくれ！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060039")

-- ▼直接出力
shake_camera(Camera003,1.5,1)
change_face(Actor004,"Smile")
 --PlayPartVoice("ノワール","苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:モゴモゴモゴッ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060041")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
	--ちょっと特殊な対応
	set_pos(Actor003,CharaPos110122_01_001)
	set_rot(Actor003,{0,CharaPos110122_01_001[4],0}) 
	Camera003 = InitializeCharaCamera(CameraAssetBundleName110122_01, CameraPos110122_01_001, Actor003)
	--ここまでPlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
change_face(Actor001,"Sad")
change_face(Actor002,"Sad")
change_face(Actor003,"Normal")
change_face(Actor004,"Normal")
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
lookat_weight_default(Actor004)
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",1.0)
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",1.0)
setup_small_camera_start(RndCamera004)
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
off_active(prop_001)
off_active(prop_002)
off_active(prop_003)
off_active(prop_004)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:一生ぶんのカボチャを食べた気がする…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_060043")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:口の中の水分がなくなった気がする…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_060044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
 --PlayPartVoice("ガレス","照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:ありがとう、ノワール、ディナタン<br>おかげでハロウィンのメニューも決まりそうだ♪
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060045")

-- ▼直接出力
change_face(Actor004,"Smile")
PlayActionDirect(Actor004,"to  Std_Joy")
turn_chara(Actor004,30,0.3)
 --PlayPartVoice("リオネス","笑い")
-- ▲直接出力

	--★★リオネス★★:ハロウィンに向けて<br>ガレスは気合いが入ってるんだよな！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01C111_060046")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
change_face(Actor004,"Normal")
 --PlayPartVoice("ガレス","肯定")
-- ▲直接出力

	--★★ガレス★★:うん♪みんなを元気にするために<br>出来ることはなんでもしたい
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060047")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガレス★★:どんなときでも<br>食卓だけは明るくなくちゃいけないんだ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060048")


	--★★ガレス★★:明るい食卓にはみんなが集まってくる
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060049")

	change_face(Actor003,"Sad")

	--★★ガレス★★:…帰りにくい人だって、<br>光に寄せられて帰ってこれるかも
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060050")

-- ▼直接出力
set_enable_auto_lookat_all(false)
change_face(Actor004,"Surprise")
-- ▲直接出力

	--★★ディナタン★★:ガレス…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_060051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
set_common_look_at(Actor003,Actor001)
 --PlayPartVoice("ガレス","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:…なんて<br>なしなし！今のは忘れてくれ！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060052")

	change_face(Actor003,"Sad")

	--★★ガレス★★:…妹だからって、家族だからって<br>なんでも許してやれるわけじゃないよ
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to Finger")
 --PlayPartVoice("ガレス","喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:まあお前たちは心配なさそうだけどな♪
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_060055")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
   load_particle_preload("content_prop_10104007", "10104007_PropModel", false, false)
   load_particle_preload("content_prop_10104007", "10104007_PropModel", false, false)
   load_particle_preload("content_prop_10104007", "10104007_PropModel", false, false)
   load_particle_preload("content_prop_10104007", "10104007_PropModel", false, false)
Prop_size = {0.8,0.8,0.8}
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
