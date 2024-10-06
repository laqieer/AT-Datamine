-- このluaスクリプトは、EA_006_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera002 = SetTemplate("Actor003",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera003 = SetTemplate("Actor004",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
turn_lookat(Actor004,Actor002,0)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003, {-3.68, 0.128, 25.73})
set_pos(Actor004,{-2.09, 0.128, 28.8})
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Camera_EX1 =set_camera({-5.27, 2.03, 17.35,   11.62867, 42.94366, 359.9001,   25.02756})
Camera_EX_GAW =set_camera({-2.595, 2.167, 19.903,   15.83158, 8.46713, 0.53814,   25.02756})
Camera_EX_RAG =set_camera({-2.44, 2.164, 20.215,   16.74329, 18.54732, 0.00001,   24.40976})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:――１年前――
	Talk(Actor001,"telop","simple","N","EA_006_0220002")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
wait_time(2.6)
-- ▲直接出力

	--★★ガレス★★:（ここが、キャメロット騎士学術院…<br>バルバロイと戦う術を学ぶ場所――）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0220003")


	--★★ガレス★★:（絆を育み、<ruby=ゲシュタルト・シフト>ＧＳ</ruby>を目指す…<br>――兄さんが戦っている場所…）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0220004")

-- ▼直接出力
setup_small_camera_start(Camera_EX1)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:（わたしも戦う力を手に入れるんだ<br>もうなにも失わないために）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0220006")

	change_face(Actor002,"Anger")

	--★★ガレス★★:（大切なものを、人を<br>わたしの手で守れるように――）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0220007")


	--★★？？？★★:ガレス！！
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","EA_006_0220009")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:！？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220010")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
Appear(Actor003)
wait_time(0.4)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,{-2.235, 0.128, 22.255}, 1.0)
wait_time(1.0)
set_common_look_at(Actor003,Actor002)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:うわ！マジでガレスだ…！<br>本当に入学したんだなぁ！！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220012")

	PlayAction(Actor002,"to  Std_No")

	--★★ガレス★★:え？え？？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220013")

-- ▼直接出力
setup_small_camera_end(Camera_EX1)
setup_small_camera_start(Camera_EX_GAW)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:来たのはガレスだけだよな？<br>アーサー様がそう言ってたし
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:因子量が多くて資質があるって――あ、そうだ<br>なぁ、あれから家族皆元気にしてたか？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220015")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:あのときの怪我は皆よくなったか？<br>母さんは――
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220016")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera_EX_GAW)
setup_small_camera_start(Camera_EX1)
wait_time(0.4)
Appear(Actor004)
wait_time(0.4)
PlayActionDirect(Actor004,"to Run")
slidemove(Actor004,{-1.597, 0.128, 22.656}, 1.5)
wait_time(1.5)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor003,0.4)
wait_time(0.4)
set_common_look_at(Actor004,Actor003)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0033")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:落ち着きなってガウェイン！<br>ガレスちゃん、引いてるよ
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220018")

	PlayAction(Actor003,"to  Std_Surp")

	--★★ガウェイン★★:え！？マジか！？<br>悪い、ついテンションが上がっちまって
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220019")

	change_face(Actor003,"Sad")

	--★★ガウェイン★★:アーサー様から俺の妹が入学してくるって<br>聞いてたからさ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220020")


	--★★ガレス★★:アーサー様…この間<br>オークニーでわたしたちを助けてくれた――
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220021")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor002,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0008")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:あのとき、実は俺もいたんだぜ<br>バルバロイをぶっ倒すのに手一杯だったけどな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220022")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:それに戦闘が終わった後すぐに次に行かなきゃで<br>まともに顔も見せられなかったけど
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220023")

-- ▼直接出力
setup_small_camera_end(Camera_EX1)
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ガレス★★:（オークニーがバルバロイに襲われたとき<br>円卓の騎士が助けに来てくれた…）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0220024")

	change_face(Actor002,"Normal")

	--★★ガレス★★:（街をめちゃくちゃにしたバルバロイを<br>円卓の騎士がやっつけてくれて――）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0220025")


	--★★ガレス★★:（…あのとき、兄さんも一緒にいたんだ…）
	Talk(Actor002,"CHRNAME_GARETH","mind","L","EA_006_0220026")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start(Camera_EX1)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:だから、ようやくちゃんと話せて嬉しいんだ<br>よろしくな、ガレス
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ガレス★★:う、うん…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220028")

	PlayAction(Actor003,"to  Std_Joy")

	--★★ガウェイン★★:よし――それじゃ、学園の案内でもすっか<br>その後は談話室で歓迎パーティだ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220029")


	--★★ガウェイン★★:な、ラグネル！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220030")

	PlayAction(Actor004,"to  Std_Joy")
	change_face(Actor004,"Smile")

	--★★ラグネル★★:うん、そうだね！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220031")

	change_face(Actor002,"Sad")

	--★★ガレス★★:………
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220032")

-- ▼直接出力
setup_small_camera_end(Camera_EX1)
setup_small_camera_start(Camera_EX_RAG)
set_common_look_at(Actor004,Actor002)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:？ガレスちゃん、どうかした？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220033")

-- ▼直接出力
setup_small_camera_end(Camera_EX_RAG)
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ガレス★★:あ、えっと…<br>たいしたことじゃないんだけど…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220034")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0034")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:…なんで、そんなに構うのかな、と思って
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220035")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start(Camera_EX1)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:へ？なんでって…
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220036")

	change_face(Actor002,"Sad")

	--★★ガレス★★:だってわたしたち、会ったことないんだぞ～<br>わたし、初めて会う妹なのに
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220037")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:なんだ、そんなことかよ<br>そんなの決まってる
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220038")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:家族を大事にするのは当然だろ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220040")

	change_face(Actor002,"Surprise")

	--★★ガレス★★:…！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220041")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ラグネル★★:相変わらず家族想いだよねぇ<br>ガウェインは
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220042")

-- ▼直接出力
setup_small_camera_end(Camera_EX1)
setup_small_camera_start(Camera001)
change_face(Actor003,"Normal")
-- ▲直接出力

	--★★ガレス★★:相変わらず？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220043")

-- ▼直接出力
setup_small_camera_start(Camera_EX_RAG)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ラグネル★★:さっきは何でもない風に言ってたけどさ<br>本当に大変だったんだから、あのとき
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220044")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Laugh")

	--★★ラグネル★★:オークニーが襲われるって知って<br>アーサー様に談判したの
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220045")

-- ▼直接出力
setup_small_camera_end(Camera_EX_RAG)
setup_small_camera_start(Camera_EX1)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ラグネル★★:「自分を行かせてくれ」<br>「あそこには家族がいるんだ」…って
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220046")


	--★★ラグネル★★:あんなガウェイン、初めて見たよ<br>すごく必死で
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220047")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ラグネル★★:それでアーサー様に同行を許可してもらったの<br>他の任務もあったのにさ～
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220048")

	PlayAction(Actor002,"to  Std_Surp")

	--★★ガレス★★:そうだったんだ…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220049")

-- ▼直接出力
set_common_look_at(Actor003,Actor004)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★ガウェイン★★:おい！いちいち言わなくていーんだよ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_006_0220050")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Laugh")

	--★★ラグネル★★:えー？いいじゃん。いい兄さんエピソード<br>ガレスちゃんだって知りたいもんね？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","EA_006_0220051")

-- ▼直接出力
setup_small_camera_end(Camera_EX1)
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガレス★★:…うん。知りたい
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220052")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ガレス★★:わたし、もっと知りたいな<br>兄さんのこと
	Talk(Actor002,"CHRNAME_GARETH","speech","L","EA_006_0220053")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
