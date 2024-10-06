-- このluaスクリプトは、MA_01A112_56.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",90,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera004 = SetTemplate("Actor004",-85,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera005 = SetTemplate("Actor005",120,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{0,0,0})
DontChangeRandomCamera(true)
set_pos(Actor002,{-1.7,0,0.1})
set_pos(Actor004,{-0.78,0,0.5})
set_pos(Actor005,{-3.1,0,1.7})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
keep_ik_lookat(Actor005,Actor002,"J_Head")
keep_ik_lookat(Actor006,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115119)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:旅に出るなら、どこかな
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_560002")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★ラグネル★★:いきなりなにさギネヴィア～<br>あっ、あの出店おいしそう！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_560003")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:考えてみたら平和が間近なわけでしょ？<br>ぜんぶ終わったらさあ、ねえ！どう？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_560004")

-- ▼直接出力
change_face(Actor004,"Normal")
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_560006","MA_01A112_560007","MA_01A112_560008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:どこか遠くに行ってみたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_560010")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
PlayActionDirect(Actor002,"to  Std_Surp")
turn_chara(Actor002,-45,0.3)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:だよね！だよねっ！<br>ずっとずっと遠くだよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_560011")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:見たことない景色いっぱいあるんだよ！<br>わたしずっと憧れ！わたしの夢！ハーッ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_560012")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:いっしょにいこうね、ぜったいだよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_560014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:アストラットでゆっくりしてみたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_560016")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
PlayActionDirect(Actor002,"to  Std_Surp")
turn_chara(Actor002,-45,0.3)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あっ、賛成賛成！<br>わたしもエレインの実家が見てみたい！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_560017")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★エレイン★★:い、いつでも大歓迎です…！<br>あまり見るべきところはが多くありませんが
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A112_560018")

	change_face(Actor005,"Smile")

	--★★エレイン★★:いつでもきれいにして待ってます…先輩
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A112_560020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:外出はしたくないなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_560022")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
change_face(Actor004,"Surprise")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:ノリ悪ッ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_560023")

	PlayAction(Actor004,"to  Std_Sad02")
	change_face(Actor004,"Sad")

	--★★ラグネル★★:ギネヴィア～あそこにノリの悪い人がいるよー<br>困ったもんだねーまいったねー
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_560024")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:言うだけならタダなのにね～
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_560025")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,-45,0.5)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あっ、ヤバいこんな時間！<br>エレインついてきて！ほらノワール行くよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_560027")

-- ▼直接出力
set_enable_auto_lookat_all(false)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ど、どこへ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_560029")

-- ▼直接出力
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Joy")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★エレイン★★:えっえっえっ？？<br>ど、どこへですか？
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A112_560030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Finger")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:平和への旅の切符<br>もらいに行くの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_560032")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor002)
Hide(Actor001)
Hide(Actor005)
Camera003=setup_small_camera_resetting(Actor003,CharaPos003,CameraPos003)
Camera004=setup_small_camera_resetting(Actor004,CharaPos005,CameraPos005)
set_pos(Actor003,{-1.1,0,0.7})
set_rot(Actor003,{0,-45,0})
set_rot(Actor004,{0,20,0})
set_rot(Actor006,{0,-175,0})
change_face(Actor003,"Normal")
change_face(Actor004,"Normal")
change_face(Actor006,"Normal")
keep_ik_lookat(Actor003,Actor006,"J_Head")
keep_ik_lookat(Actor004,Actor006,"J_Head")
keep_ik_lookat(Actor006,Actor003,"J_Head")
set_enable_auto_lookat(Actor006,true)
setup_small_camera_start(RndCamera005)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:買い食いしながら帰ろうぜ、生徒会長
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_560034")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
change_face(Actor003,"Normal")
-- ▲直接出力

	--★★ラヴェイン★★:ついていかないんですか？
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","MA_01A112_560035")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ラグネル★★:会長こそ
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_560036")

	PlayAction(Actor006,"to  Std_No")

	--★★ラヴェイン★★:無粋でしょう
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","MA_01A112_560037")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ラグネル★★:うんうん、わかるよ～
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_560038")

-- ▼直接出力
set_enable_auto_lookat_all(true)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:あとさ、ギネヴィアが言ってたアレ<br>多分アーサー様が話題に出してたハナシだろ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_560040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,-85,0.5)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:『聖域化』…だっけ？<br>初めて聞いたね、なんなんだろ
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_560041")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:あのときのアーサー様の顔さ<br>あんま触れて欲しくないときの顔なんだよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_560042")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ラヴェイン★★:よく見ていらっしゃいますね
	Talk(Actor006,"CHRNAME_LOVEIN","speech","L","MA_01A112_560043")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:…食べて待とっか、あたしたちは
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A112_560044")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102012)
	InitializeLoad_Preload()
	load_area_scene_preload(115119)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
