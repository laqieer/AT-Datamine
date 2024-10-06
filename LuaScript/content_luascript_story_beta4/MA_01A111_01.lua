-- このluaスクリプトは、MA_01A111_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:恋文？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:恋文です
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_010003")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力

	--★★ギネヴィア★★:ん。わたしに？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010004")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力

	--★★ギネマウア★★:はい。ギネヴィア様に
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_010005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:なにかの冗談？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010006")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力

	--★★ギネマウア★★:ガチですね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_010007")


	--★★ギネヴィア★★:ガチですか
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010008")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "喜び")
-- ▲直接出力

	--★★ギネマウア★★:お返事を、どうか
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_010009")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:なるほど。困ったわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010011")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor001,Camera001,EntryData110011_01_06,CameraAssetBundleName110011_01,CameraPos110011_01_106)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A111_010013","MA_01A111_010014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:おはよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_010016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:おはよ。ノワール<br>ちゃんと登校してきて偉いね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだよそれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_010018")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:今日も会えて良かったってことよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なにか困ったことでもあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_010021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ん。気づいてくれるんだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010022")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:困った顔してるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_010023")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:困ったことに、嬉しいな
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010024")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネマウア★★:ギネヴィア様<br>それでは私はこれで
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_010026")

-- ▼直接出力
set_common_look_at(Actor001,Actor003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういえばギネマウアさん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_010027")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:なにか
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_010028")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:その『様』付けは変えないんですか？<br>ギネヴィアは王妃ではなくなったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_010029")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "悩む")
-- ▲直接出力

	--★★ギネマウア★★:この子は今も昔もキャメリアードの王女です<br>私はその侍女として学園に入りました
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_010030")


	--★★ギネマウア★★:その頃からの関係性ですからね
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_010031")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ここの王妃は降りたから<br>『殿下』はヤメてもらったんだけどね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010032")


	--★★ギネヴィア★★:あの国に関わることは<br>出来るだけ残しておきたいから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010033")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:ご友人の皆様はご遠慮なく呼び捨てでどうぞ<br>そのほうがこの子も喜びます
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_010035")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
set_common_look_at(Actor001,Actor002)
Hide(Actor003)
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:あのね、ノワール<br>心して聞いてほしいの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010037")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:恋文、もらっちゃった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010038")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_010039")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:にっしっしっしっしっしっしっし♪<br>ほらほらほらほら。始まるよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_010041")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
