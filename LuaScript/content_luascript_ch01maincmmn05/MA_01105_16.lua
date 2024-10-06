-- このluaスクリプトは、MA_01105_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
turn_lookat(Actor002,Actor001, 0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ランスロット★★:あくまで偵察だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:心得てるわ。ランスロット
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_160003")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:本来ならばお前たちのような人材を<br>行かせるような作戦ではない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:わかったって
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_160006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ランスロット★★:犠牲や捨て石になる必要もない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160008")

	PlayAction(Actor003,"to Greet_one")
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:あのォ、もう行っていい？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_160009")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:…ノワール<br>気をつけて行ってきてくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………そんなことを言うために来てくれたのか？<br>どうして──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_160011")


	--★★ランスロット★★:…お前が大切、だからだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160013")

	open_select_window_tag(Actor001,"Normal","MA_01105_160015","MA_01105_160016","MA_01105_160017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:この学園にとって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_160019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160020")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:せっかくの転校生を手放したくはないな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたにとって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_160023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ずっとそうだ。ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160024")

	change_face(Actor002,"Sad")

	--★★ランスロット★★:今も、昔も<br>…変わらずな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160025")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:戦力として？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_160027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160028")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:新人円卓の騎士が<br>すぐいなくなられては困るからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160029")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は必ず『本当』を知る<br>あんたから聞かせてもらう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_160031")


	--★★ノワール★★:父のこと、世界のこと、自分のこと<br>ランスロット──あんたが隠しているすべてを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_160032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ。そのつもりだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺にはまだ知らないことが多すぎる<br>あんたが黙っているのはなにか理由があるからだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_160034")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたが話してくれるまで、待つから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_160035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:ああ。頼むよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_160037")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネヴィア★★:あのォ、もう行っていい？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_160038")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor004,Camera004,EntryData110071_01_06,CameraAssetBundleName110071_01,CameraPos110071_01_106,Actor007,CharaPos110071_01_008,CharaPos110071_01_108)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:いい朝だな！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01105_160039")

	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:ガウェイン…？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_160041")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:俺はまだ転校生の円卓入りに納得がいかねえ<br>殿下やマーリン様に剣を向けねーとも限らねえ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01105_160042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ガウェイン★★:朝の俺は誰にも負ける気がしねえ！<br>ノワール…仮にお前が裏切ろうとしてもな！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01105_160043")

	PlayAction(Actor004,"to Greet_one")
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:ということで俺らもついてくから<br>ヨロシクー！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01105_160044")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:…我らの主様は過保護でいらっしゃいますね
	Talk(Actor006,"CHRNAME_MERLIN","speech","L","MA_01105_160045")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Laugh")

	--★★ラグネル★★:ですねえ
	Talk(Actor007,"CHRNAME_RAGNAR","speech","L","MA_01105_160046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor008,"to  Std_Talk")
turn_chara(Actor008,-144,0.5)
set_common_look_at(Actor008,Actor003,1.0)
-- ▲直接出力
	change_face(Actor008,"Laugh")

	--★★ギネマウア★★:賑やかな帰郷になりそうですね
	Talk(Actor008,"NPCNAME_0070","speech","L","MA_01105_160048")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Joy")
turn_chara(Actor003,100,0.5)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:にっしっし…♪<br>大騒ぎしてパパを喜ばせたげるの
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_160049")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Smile")

	--★★ギネマウア★★:…ええ。嬉しいはずです<br>キャメリアード国王陛下…レオデグランス王も
	Talk(Actor008,"NPCNAME_0070","speech","L","MA_01105_160050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:孝行娘ねえ。わたし
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01105_160052")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
