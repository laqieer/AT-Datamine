-- このluaスクリプトは、MA_01107_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",-75,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",-45,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera005 = SetTemplate("Actor005",-55,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("10301005", "content_still_10301005_image", "103010050_StillImage")
load_image("MA011073101", "content_still_10101008_image", "101010080_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000021)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ランスロット★★:…師匠が妖精ニニアンを殺した<br>それは本当だ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01107_310002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ノワール★★:…父さんは妖精を守護する騎士だった<br>母さんは妖精に仕える巫女だった
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310004")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:どうしてそんなことをする必要がある？<br>なにかの間違いじゃないのか…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310005")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301005", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ランスロット★★:俺の、目の前でだ
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01107_310007")


	--★★ノワール★★:…なにを、いってんだ…？
	Talk(Actor002,"CHRNAME_NOIR","simple","N","MA_01107_310008")


	--★★ランスロット★★:ブルーノ──<br>俺たちの剣の師、お前たちの父親は…
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01107_310009")


	--★★ランスロット★★:妖精を殺し、その姿を消した
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01107_310010")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image()
off_cameraframe()
off_screencolor()
setup_small_camera_start()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力

	--★★ランスロット★★:…『妖精殺し』事件のあとログレス関係者は<br>聖杯城…コルベニック城から撤収した
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01107_310012")


	--★★ランスロット★★:そのあとコルベニック城主ぺレスが<br>あらたに結成したのが『銀卓騎士団』だ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01107_310013")

-- ▼直接出力
CloseTalkWindow()
show_image("MA011073101", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力

	--★★ランスロット★★:聖杯城を守護する<br>円卓の騎士に劣らぬ精鋭との噂だが…
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01107_310015")


	--★★ランスロット★★:先ほどの戦況報告を聞くに<br>噂以上の強さだな
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01107_310016")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME) 
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01107_310018","MA_01107_310019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:少数精鋭ってことか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310021")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ノワール★★:学園やログレスの助力なく<br>どう集めたのかは気になるところだな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310022")

	change_face(Actor002,"Sad")

	--★★ノワール★★:妖精もいなくなったのに<br>騎士団が必要な理由もわからないな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310023")

	change_face(Actor002,"Normal")

	--★★ノワール★★:別になにか守るべきものがあるのか<br>もしくは円卓へのあてつけか…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:そうはいっても<br>『最強騎士』ほどじゃないだろ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310026")

	change_face(Actor001,"Normal")

	--★★ランスロット★★:どうだろうな<br>俺も以前より鍛錬の時間が減ってしまった
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01107_310027")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Smile")

	--★★ランスロット★★:…弟弟子の相手で忙しくてな
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01107_310028")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ノワール★★:…あんたなあ！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310029")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Normal")

	--★★ノワール★★:父さんに代わって<br>あの地を守ることになった連中か…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310031")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ランスロット★★:言葉は悪いが、師匠の『妖精殺し』により<br>聖杯城が混乱しログレスが締め出されたのは事実
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01107_310033")


	--★★ランスロット★★:だから、俺が行かなくてはならない
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01107_310034")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:家族のディナタンはともかく、わたしもいるのに<br>ペラペラ喋ってちゃっていいの？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_310035")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
set_rot(Actor004,{0,-10,0})
set_rot(Actor005,{0,-35,0})
lookat_weight(Actor002,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
set_common_look_at(Actor004,Actor002)
set_common_look_at(Actor005,Actor002)
-- ▲直接出力

	--★★ランスロット★★:殿下にはケイが漏らしてしまっていたからな<br>姉君あたりから近い話を聞いているのでは？
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01107_310036")

	PlayAction(Actor003,"to Finger")
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:名答
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_310037")

	change_face(Actor002,"Smile")

	--★★ノワール★★:…ついてきてくれたんだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310038")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Anger")

	--★★ディナタン★★:…私も、本当のことが知りたい<br>兄さんと一緒に受け止めたいの
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01107_310039")

-- ▼直接出力
set_common_look_at(Actor003,Actor002)
change_face(Actor002,"Normal")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ディナタン★★:一緒に抱えさせて、兄さん
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01107_310040")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,-135,0.5)
-- ▲直接出力

	--★★ギネヴィア★★:プライベートならちゃあんと耳を塞ぐわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_310041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:でも、聞いた現実が辛くて泣きそうになったら<br>ノワールのそばにいてあげようと思って
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01107_310042")

-- ▼直接出力
change_face(Actor002,"Smile")
-- ▲直接出力

	--★★ノワール★★:…ありがとう
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01107_310043")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★ランスロット★★:見えたぞ、銀甲冑だ！
	Talk(Actor001,"CHRNAME_LANCELOT","simple","N","MA_01107_310044")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10301005", "content_still_10301005_image", "103010050_StillImage")
load_image_preload("MA011073101", "content_still_10101008_image", "101010080_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000021)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
