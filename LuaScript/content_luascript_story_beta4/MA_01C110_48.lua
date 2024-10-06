-- このluaスクリプトは、MA_01C110_48.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Prop_01 = get_object("geo_cutlery25")
Prop_02 = get_object("geo_cutlery26")
Prop_03 = get_object("geo_cutlery27")
Prop_04 = get_object("geo_trayB25")
Prop_05 = get_object("geo_trayA26")
Prop_06 = get_object("geo_trayB27")
set_pos(Prop_01,{0.384,0.815,-11.111})
set_pos(Prop_02,{0.361,0.815,-11.525})
set_pos(Prop_03,{0.379,0.815,-11.924})
set_pos(Prop_04,{0.384,0.815,-11.111})
set_pos(Prop_05,{0.361,0.815,-11.525})
set_pos(Prop_06,{0.379,0.815,-11.924})
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:おまちどー！<br>Ａランチを３つだ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","MA_01C110_480002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:あぁ、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480003")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:一応聞くけど<br>それひとりで食べるのか？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","MA_01C110_480004")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そのつもりだけど<br>駄目か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480005")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★リオネス★★:駄目じゃないけど…
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","MA_01C110_480006")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor002,Camera002,EntryData110122_01_01,CameraAssetBundleName110122_01,CameraPos110122_01_101)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:にゃはは！食欲旺盛なのはいいことだぞ<br>たくさん食べなきゃ元気も出ないからな～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:１ヶ月、ろくに食べてなかったから<br>体がわたしのご飯を求めているんだ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_480010","MA_01C110_480011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうかもしれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なんかすごくハラが減ってるんだ<br>このあいだまで全然感じなかったのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:それもいいことだ<br>お腹が空かないなんて人間じゃない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ああ、しまった<br>ディナタンも誘えばよかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480017")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ガレス★★:ディナタンとは<br>一緒じゃなかったのか～？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マルディサントと<br>話したかったみたいでさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480019")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あまりお腹が空いているように<br>見えなかったってのもあるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480020")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:でも、学園がめちゃくちゃになって<br>しばらくは皆もそうだった
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480022")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ガレス…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480024")


	--★★ノワール★★:ガレスは大丈夫なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:大丈夫って？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480027")

-- ▼直接出力
setup_small_camera_start(Camera002)
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:その…ガウェインがいなくなって――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480028")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:うーん…離れていても<br>兄妹なのは変わんないだろう？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:兄妹だからって意見が同じって<br>決まりはないし
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480031")

-- ▼直接出力
 --PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:向こうでは、ちゃんと<br>ご飯食べてくれてるといいけどさ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…そっか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:食べなきゃ始まらないからな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480034")


	--★★ガレス★★:だからノワールも<br>いっぱい食べるんだぞ～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480035")


	--★★ガレス★★:美味しいご飯を食べて頭に栄養回さなきゃ<br>悪いことばかり考えるな！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480037")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:よし<br>俺もいっぱい食って、頭に栄養回すぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_480038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガレス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:そうそう！あ、でも…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480039")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガレス★★:いっぱい食べるのはいいとして<br>メニューくらい変えてもいいと思うぞ～？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C110_480040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
