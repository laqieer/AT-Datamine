-- このluaスクリプトは、EA_053_032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	Camera002 = SetTemplate("Actor002",-40,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	Camera003 = SetTemplate("Actor004",nil,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera004 = SetTemplate("Actor005",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera005 = SetTemplate("Actor006",nil,CharaPos110122_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_005)
	Camera006 = SetTemplate("Actor007",80,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","e0053_01_m_Controller","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	Camera007 = SetTemplate("Actor008",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	Camera008 = SetTemplate("Actor009",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
hideobj01 = get_object("geo_uv03_obj01_foodA")
set_pos(hideobj01, {0,-20, 0})
set_pos(Actor006, {0.79, 0, -7.477})
set_pos(Actor004, {5.791, 0, -1.84})
turn_chara(Actor004,178,0)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
Hide(Actor006)
Hide(Actor007)
PlayActionDirect(Actor008,"to Std_HaveItem")
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor007,"to Std_Whisk01_Loop")
-- ▲直接出力
-- ▼直接出力
meal01 = setup_prop_object(10104006)
set_pos(meal01,{6.908, 1.016, -7.296})
set_rot(meal01,{0,0,0})
-- ▲直接出力
-- ▼直接出力
meal02 = setup_prop_object(10104006)
set_pos(meal02,{6.908, 1.016, -7.911})
set_rot(meal02,{0,0,0})
-- ▲直接出力
-- ▼直接出力
Hide(meal01)
Hide(meal02)
-- ▲直接出力
-- ▼直接出力
Hide(Actor009)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0035")
Hide(Actor001)
Appear(Actor007)
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★コック長★★:よし！それじゃ、まずは生地作りからだ<br>魂込めて、泡立て頼むぜ！！
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320004")

-- ▼直接出力
setup_small_camera_end(Camera001)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0012")
-- ▲直接出力
	change_face(Actor007,"Anger")

	--★★ノワール2★★:まかせてくれ<br>よし――うおおおおおおお！
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_053_0320005")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor007,"to Std_Whisk02do_Start")
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor007,"to Std_Whisk02do_End")
-- ▲直接出力
	change_face(Actor007,"Pain")

	--★★ノワール2★★:ぐああっ…！ 
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_053_0320007")

-- ▼直接出力
DontChangeRandomCamera(false)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0015")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:お、おい！ノワール！？<br>大丈夫か！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320008")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0043")
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★ノワール2★★:う、腕が――つって――…
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_053_0320009")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0015")
-- ▲直接出力

	--★★コック長★★:コラァッ、ノワール！手を止めるんじゃねェ！<br>生地がダマになっちまうだろォ！
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320010")


	--★★ノワール2★★:け、けど腕がもう限界で――…
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_053_0320011")

-- ▼直接出力
CloseTalkWindow() 
fadeout(0,0,0,0.2, 0.2)
wait_time(1 + 0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
Hide(Actor007)
Appear(Actor001)
DontChangeRandomCamera(true)
set_scale_image(20,20)
wait_time(0.8 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0013")
-- ▲直接出力

	--★★コック長★★:仕方ねぇなぁ。貸してみな！<br>――うおおおおおおおおおおっ！
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320012")

-- ▼直接出力
CloseTalkWindow() 
se_play("SE_ADV_EA_053_032_Whisking")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:す、すごい…！ <br>生地があっという間に滑らかになっていく！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0008")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★コック長★★:…ってな感じで<br>一気に決めるのがポイントだ！
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320015")


	--★★コック長★★:お菓子作りは戦いと一緒で<br>ちょっとでも隙を見せたらアウトだからな！
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320016")


	--★★ノワール★★:べ、勉強になります
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320017")

-- ▼直接出力
setup_small_camera_start()
CloseTalkWindow() 
hide_image(BLACK_WHITE_TIME)
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:料理って実は結構体力仕事だよな…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_053_0320020","EA_053_0320021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かに…修行になるかもしれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320024")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:…なんか、そういうところ<br>ランスロットに似てんな、お前って
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320025")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320026")

-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0010")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★コック長★★:いいこと言うじゃないか、ノワール！<br>なんならオレっちがみっちり指導してやるぜ
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0014")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺には向いていない気がするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320030")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:そうか？でもお前裁縫好きなんだろ？<br>意外とハマったりして
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320031")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Normal")

	--★★ノワール★★:裁縫と料理は全く別物だろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320032")

-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0010")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★コック長★★:いやいや！意外と奥深いって意味では<br>通じるものがあるかもしれねぇぞ？
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320033")

	goto Block1end

::Block1end::
-- ▼直接出力
turn_chara(Actor002,120,0.0)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★コック長★★:よし、それじゃ後は<br>さっき教えた通りに仕上げれば完成だ！
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320035")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0042")
-- ▲直接出力

	--★★コック長★★:オレっちは五月祭限定メニューの<br>仕込みに戻るから後は頼んだぜ！
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320036")

-- ▼直接出力
setup_small_camera_start()
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,-130,0.8)
wait_time(0.8)
slidemove(Actor005,3.55, 0, -9.88, 1.0)
wait_time(1.35)
PlayActionDirect(Actor005,"to Std_Loop")
setup_small_camera_end()
Hide(Actor005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:頼むって言われても…<br>なぁ、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(1.3)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-40,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:――よし、完成！！<br>ちょっと食ってみ、ノワール
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320039")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:早！？もう作り終わったのか！？<br>俺なんてまだ生地作りの途中なのに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320040")


	--★★ノワール★★:しかもすごく美味しい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:だろ？<br>結構いい感じだよな～
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320042")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0047")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:リオネスが言ってた通り<br>本当にガウェインも料理が得意なんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力

	--★★ガウェイン★★:まぁ、ガレスほどじゃねーけどな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガウェイン★★:…昔、ちょっと練習したんだよ<br>作った飯を食ってもらいたい人がいたから
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320045")

	change_face(Actor001,"Normal")

	--★★ノワール★★:飯を？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320046")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ガキの頃、住んでた街が襲われたことがあってさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:そのとき、たったひとりで街を守ってくれた<br>すげえかっこいいひとがいて
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320048")


	--★★ガウェイン★★:しばらく街に滞在するっていうから<br>その間、飯作っては差し入れしてたんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320049")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:お礼にって修行つけてくれるのが嬉しくてさ<br>ほぼ毎日
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320050")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力

	--★★ノワール★★:それで料理が上手くなったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320051")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:かもな～
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320052")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0014")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:今思えば下手くそな料理だったし<br>割に合わねえはずなのにさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:「飯の礼はしなくてはな」って<br>ガキの戯れに付き合ってくれて
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320054")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:…ああいうのが<br>本当の『ヒーロー』ってやつだよな――
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320055")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:………
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:ガウェイン…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320057")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
Appear(Actor006)
wait_time(0.3)
PlayActionDirect(Actor006,"to Wlk")
slidemove(Actor006,{5.375, 0, -7.477},2.0)
wait_time(2.0)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力

	--★★ログレス兵★★:ここにいたか、ガウェイン<br>アーサー様がさがしていたぞ
	Talk(Actor006,"NPCNAME_0124","speech","N","EA_053_0320059")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-70,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320060")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:盗賊？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320061")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力

	--★★ガウェイン★★:ここ最近、五月祭の盛り上がりに乗じた<br>盗賊連中が頻繁に悪さしてるんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320062")


	--★★ガウェイン★★:で、アーサー様の命を受けた俺が<br>対処にあたってんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320064")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0037")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:てわけで…悪い、ノワール！<br>俺、ちょっと行ってくるわ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320065")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力

	--★★ノワール★★:ああ、わかった<br>コック長には俺から伝えておく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320066")

	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320067")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:サンキュー！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0320068")

-- ▼直接出力
CloseTalkWindow() 
fadeout(0,0,0,0.2, 0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
wait_time(1.0)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
setup_small_camera_start(Camera001)
set_scale_image(20,20)
Hide(Actor006)
wait_time(0.8 + 0.2)--0.6秒+0.5秒
DontChangeRandomCamera(true)
PlayActionDirect(Actor002,"to Std_Loop")
Hide(Actor002)
fadein(0.2)
wait_time(0.2)
hide_image(BLACK_WHITE_TIME)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320070")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(1 + 0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
turn_chara(Actor001,-93,0.0)
set_scale_image(20,20)
wait_time(0.8 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
hide_image(BLACK_WHITE_TIME)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0320072")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(1 + 0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
setup_small_camera_start(Camera002)
Hide(Actor001)
Appear(Actor008)
PlayActionDirect(Actor008,"to Std_HaveItem_Eat")
se_play("SE_ADV_EA_053_046_Oven")
wait_time(0.8 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
hide_image(BLACK_WHITE_TIME)
wait_time(3.0)
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★ノワール3★★:びっくりするほど固い！歯の鍛錬になる！！<br>――なってどうする！？
	Talk(Actor008,"CHRNAME_NOIR","speech","L","EA_053_0320074")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0.2, 0.2)
wait_time(1 + 0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
Hide(Actor008)
Appear(Actor009)
set_scale_image(20,20)
wait_time(0.8 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★ノワール4★★:…なんか、色合いが地味だな<br>もっと見た目かわいく、こう――…
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320076")

-- ▼直接出力
setup_small_camera_start()
CloseTalkWindow()
wait_time(1.0)
se_play("SE_ADV_EA_053_032_Explosion_Comedy")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0031")
-- ▲直接出力
	change_face(Actor009,"Surprise")

	--★★ノワール4★★:うわー！爆発した！！！！！
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320079")

-- ▼直接出力
CloseTalkWindow()
wait_time(3.0)
-- ▲直接出力

	--★★テロップ★★:しばらくして
	Talk(Actor003,"","simple","L","EA_053_0320081")

-- ▼直接出力
CloseTalkWindow() 
Appear(meal01)
Appear(meal02)
hide_image(BLACK_WHITE_TIME)
DontChangeRandomCamera(false)
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor009,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0012")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ノワール4★★:…で、できたー！！
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320082")


	--★★ノワール4★★:
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320083")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
set_pos(Actor005,{1.39, 0, -8.39})
turn_chara(Actor005,90,0)
Appear(Actor005)
wait_time(0.3)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,{5.795, 0, -8.318},2.5)
wait_time(2.5)
turn_chara(Actor005,60,0.5)
wait_time(0.5)
PlayActionDirect(Actor005,"to Std_Loop")
setup_small_camera_end()
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0037")
-- ▲直接出力

	--★★コック長★★:よぉ、ワリーワリー！放っておいちまって<br>…ん？ガウェインの奴は？
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320085")

	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ノワール4★★:
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320086")


	--★★ノワール4★★:でも、今日作る分のお菓子はちゃんと<br>仕上げていったから
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320087")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★コック長★★:ああ、これか…
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320088")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
Appear(Actor004)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{5.791, 0, -6.664},3.0)
wait_time(3.0)
turn_chara(Actor004,120,0.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0045")
PlayActionDirect(Actor005,"to Std_HaveItem")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★リオネス★★:おおっ！お菓子がたくさんだー！<br>さすがガウェイン、超美味しそうだ！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_053_0320089")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★リオネス★★:
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_053_0320090")

	PlayAction(Actor009,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★ノワール4★★:ごめん、そっちのは俺が作った
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320091")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0014")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★リオネス★★:…なんていうか、一生懸命さを感じるな！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_053_0320092")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール4★★:フォローありがとう<br>沁みるよ
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320093")

-- ▼直接出力
PlayActionDirect(Actor005,"to Std_HaveItem_Eat")
wait_time(1.0)
se_play("SE_ADV_EA_053_046_Cookie_Eat")
-- ▲直接出力

	--★★コック長★★:………
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320094")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0034")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★リオネス★★:ま、まぁノワールのも悪くないと思うぞ！ <br>相手が悪かっただけだ
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_053_0320096")

	change_face(Actor009,"Normal")

	--★★ノワール4★★:そうだよな。美味しそうなのはどう考えても<br>ガウェインが作った方だよな
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320097")

-- ▼直接出力
PlayPartVoiceDirect("リオネス","0008")
-- ▲直接出力

	--★★リオネス★★:ガウェインは料理上手だからな！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_053_0320098")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★コック長★★:――いや
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320099")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★コック長★★:オレっちは<br>ノワールが作ったお菓子のほうがいいな
	Talk(Actor005,"NPCNAME_0260","speech","L","EA_053_0320100")

	change_face(Actor009,"Surprise")

	--★★ノワール4★★:…え？
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_053_0320101")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end

