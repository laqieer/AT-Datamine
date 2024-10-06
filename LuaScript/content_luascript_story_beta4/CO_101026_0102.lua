-- このluaスクリプトは、CO_101026_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_004)
	Camera003 = SetTemplate("Actor003",187,CharaPos110061_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110061_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_006)
	Camera005 = SetTemplate("Actor005",-98,CharaPos110061_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_008)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
prop002 = setup_prop_object(10103001)
-- ▲直接出力
-- ▼直接出力
set_pos(prop002 , {3.601,0.822,10.554})
-- ▲直接出力
-- ▼直接出力
prop003 = setup_prop_object(10103002)
-- ▲直接出力
-- ▼直接出力
set_pos(prop003 , {3.601,0.86,10.554})
-- ▲直接出力
-- ▼直接出力
set_rot(prop003, {0,22.98,0})
-- ▲直接出力
-- ▼直接出力
prop004 = setup_prop_object(10103003)
-- ▲直接出力
-- ▼直接出力
set_rot(prop004, {0,-30.916,0})
-- ▲直接出力
-- ▼直接出力
set_pos(prop004, {3.389,0.819,10.49})
-- ▲直接出力
-- ▼直接出力
prop005 = setup_prop_object(10103004)
-- ▲直接出力
-- ▼直接出力
set_pos(prop005, {3.614,0.899,10.535})
-- ▲直接出力
-- ▼直接出力
set_rot(prop005, {0,13.826,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
prop006 = setup_prop_object(10103005)
-- ▲直接出力
-- ▼直接出力
set_pos(prop006 , {3.23,0.82,10.453})
-- ▲直接出力
-- ▼直接出力
set_rot(prop006, {-0.633,177.812,-16.121})
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10103005)
prop001_offset = {-0.081,0.019,0.005,9.026,3.401,-22.847}
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Reading")
-- ▲直接出力
-- ▼直接出力
on_parent(prop001,Actor001, "Loc_weapon_constrint_L", prop001_offset)
-- ▲直接出力
-- ▼直接出力
off_active(prop006)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002, {1.941,0,13.509})
set_rot(Actor002, {0,180,0})
set_pos(Actor003, {2.272,0,14.384})
set_rot(Actor003, {0,180,0})
set_pos(Actor004, {1.414,0,14.216})
set_rot(Actor004, {0,180,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
lookat_delay_weight(Actor005,1.0,0.08,0.4,0.35,1)
keep_ik_lookat(Actor005, Actor001, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:えーと、なになに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020002")


	--★★ノワール★★:妖精と人間とに<br>外見的な差異はほとんどない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:ブリテンにおいて、かつて妖精たちは<br>森や湖の周りに住んでいたとされる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020005")


	--★★ノワール★★:バルバロイの増加と反比例するかのように<br>妖精たちが人間の前に姿を現す機会は減少した
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020006")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor002)
Appear(Actor003)
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力

	--★★パーシヴァル★★:ほう？妖精について調べているのかい<br>勤勉なのはいいことだよ。庶民ならなおさらにね
	Talk(Actor002,"CHRNAME_NAMELES","speech","N","CO_101026_01020008")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor002,"to Wlk")
PlayActionDirect(Actor003,"to Wlk")
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor002,{1.941,0,10.509}, 3)
slidemove(Actor003,{2.272,0,11.384}, 3)
slidemove(Actor004,{1.414,0,11.216}, 3)

wait_time(3.0)
turn_chara(Actor002,114,0.5)
turn_chara(Actor003,-173,0.5)
turn_chara(Actor004,126,0.5)

wait_time(0.5)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
on_active(prop006)
wait_time(1.5)

setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor001,"to Sit01_Loop")
wait_time(0.2)
off_parent(prop001)
off_active(prop001)
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookWeight = {0.8, 0, 0.7, 0.35}
lookat_delay_weight(Actor001, lookWeight,1.0)
-- ▲直接出力

	--★★ノワール★★:ん…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020010")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101026_01020012","CO_101026_01020013","CO_101026_01020014")
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
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:パーシヴァルじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020016")

-- ▼直接出力
--パーシヴァル,CHRNAME_PERCIVAL @名前変更
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:そう！ボクこそはもっとも気高く<br>そしてもっとも高貴なる円卓の騎士！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（意味かぶってないか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101026_01020018")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:はるかに響け、ボクのノブリス・オブリージュ<br>円卓の騎士・八ノ座パーシヴァル！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020019")

	open_cutin(1,2)
	on_cutin(1,Actor002,"Smile")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "気合い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:華麗～～～～～～に、推・参！！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","N","CO_101026_01020020")

	close_cutin()
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Appl")
wait_time(0.2)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Appl")
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか俺に用か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020022")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:お、おい、なんかこう、あるだろう！<br>「おおー」とか「ふーん」とか！！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020023")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（ふーん、でいいのか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101026_01020024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:五月祭のとき<br>ＭＣをやってた、えーと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020026")

-- ▼直接出力
--パーシヴァル,CHRNAME_PERCIVAL @名前変更
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:どんな大舞台にも物怖じしない胆力！<br>溢れる語彙力！にじみ出るタレント性！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020027")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ボクがやらずに誰がやる！<br>いや、誰もやれるわけがないのだよ！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020028")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:ボクはマスター・オブ・セレモニーを超えた<br>プリンス・オブ・セレモニー…
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:…って、違う！<br>パーシヴァルだ、円卓の騎士・八ノ座の！！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020030")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（うるさいな、こいつ…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101026_01020031")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 1)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなことより次の本だ<br>えーと、なになに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020033")

-- ▼直接出力
--パーシヴァル,CHRNAME_PERCIVAL @名前変更
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:おおい、無視するな！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020034")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
lookWeight = {0.8, 0, 0.7, 0.35}
lookat_delay_weight(Actor001, lookWeight,100)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:円卓の騎士・八ノ座、パーシヴァルが<br>話しかけてやっているんだぞ！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020035")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	goto Block1end

::Block1end::
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:…失敬<br>ボクとしたことが取り乱してしまったよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020037")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★パーシヴァル★★:貴族として恥ずべき行為だ<br>反省しなくては、庶民とは違うのだから
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020038")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:で、なんの用だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:キミが庶民なりに頑張って<br>妖精のことを調べているようだから
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020040")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力

	--★★パーシヴァル★★:妖精について詳しいこのボクが<br>貴族のこのボクが力になってあげようかとね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101026_01020043","CO_101026_01020044","CO_101026_01020045")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ、本当か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:図書館で調べものとか得意じゃなくてさ<br>協力してもらえると助かるよ、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:大変結構<br>庶民はそうであるべきさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020049")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あんたが妖精に詳しいだって…？<br>本当かなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020051")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:失敬な庶民だなキミは<br>ボクの言葉が信じられないというのか？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020052")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020053")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:どこが！？<br>どのへんがっ！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020054")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんというか<br>全体的に胡散臭いじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020055")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:ギーッ！<br>言うにことかいて胡散臭いだと！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020056")

-- ▼直接出力
PlayPartVoice("男子2", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★キャメロット騎士学術院（男）②★★:パーシヴァルくん、落ち着いて
	Talk(Actor003,"NPCNAME_0217","speech","L","CO_101026_01020058")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★キャメロット騎士学術院（男）②★★:彼は突然の申し出に動転して<br>言葉を選び間違えたんだよ、きっと
	Talk(Actor003,"NPCNAME_0217","speech","L","CO_101026_01020059")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★キャメロット騎士学術院（男）③★★:フォロー！<br>フォロー頼むよ！
	Talk(Actor004,"NPCNAME_0218","speech","L","CO_101026_01020061")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？あ、ああ<br>それじゃ、そういうことにしておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020062")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:他にも妖精について書かれた本はないかな？<br>ディンドランさんに聞いてみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020064")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:おい！おいぃっ！無視するなって！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020065")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:相手にしてくれないと<br>ボクにだって考えがあるぞ？拗ねるぞ？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020066")

-- ▼直接出力
keep_ik_lookat(Actor001, Actor002, "J_Head")
lookWeight = {0.8, 0, 0.7, 0.35}
lookat_delay_weight(Actor001, lookWeight,0.8)
-- ▲直接出力
	goto Block2end

::Block2end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんであんたが<br>突然話しかけてきたのかはわからないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020068")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:妖精について<br>知っていることを教えてほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020069")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:わかった<br>では、ボクの付き人としてしばらく働くといい
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001 , 0.5)
-- ▲直接出力

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020071")

-- ▼直接出力
wait_time(1.8)
lookWeight = {0.8, 0, 0.7, 0.35}
lookat_delay_weight(Actor001, lookWeight,2)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020072")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:キミが付き人として相応しいと認められたなら<br>教えてあげよう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020073")


	--★★パーシヴァル★★:妖精についての情報に加え<br>貴族としてのたしなみまでね！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020074")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "気合い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:凡庸な庶民を導く<br>まさに、ノブレス・オブリージュ！！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020075")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")

	--★★パーシヴァル★★:これにて契約は結ばれた！<br>ではまた会おう！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_01020076")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
lookat_delay_weight_reset(Actor001 , 2)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
Appear(Actor005)
setup_small_camera_start(RndCamera004)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…え、どういう、こと…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020078")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディンドラン", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ディンドラン★★:ノワールさん、パー坊…いえ、パーシヴァル様と<br>仲良くしてあげてね？
	Talk(Actor005,"CHRNAME_DINDRANE","speech","L","CO_101026_01020080")

-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ディンドラン★★:ときどき調子に乗りすぎてしまうこともあるけど<br>とてもいい子だから、あの子…
	Talk(Actor005,"CHRNAME_DINDRANE","speech","L","CO_101026_01020081")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor005 ,1.0)
PlayActionDirect(Actor005,"to Bow")
wait_time(2.5)
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,180,0.5)
wait_time(0.5)
slidemove(Actor005,{5.355,0, 7}, 3)
wait_time(3.0)
Hide(Actor005)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:俺が？<br>パーシヴァルの付き人？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020083")


	--★★ノワール★★:なんで？<br>本当にどういうこと…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_01020084")

-- ▼直接出力
local trustParam = set_communication_acquired("パーシヴァル_コミュランク", "パーシヴァル_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10103001)
setup_prop_object_preload(10103002)
setup_prop_object_preload(10103003)
setup_prop_object_preload(10103004)
setup_prop_object_preload(10103005)
setup_prop_object_preload(10103005)
prop001_offset = {-0.081,0.019,0.005,9.026,3.401,-22.847}
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
