-- このluaスクリプトは、PT5_01_0043_2.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:この島の東側に広がる<br>『果てなき森』と呼ばれる樹海は知ってる？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430002")

	change_face(Actor005,"Sad")

	--★★クリスティーナ★★:鬱蒼とした木々が立ち並び<br>日の光が差し込むことはほとんどなく
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430003")

	PlayAction(Actor005,"to  Std_Sad01")

	--★★クリスティーナ★★:一度足を踏み入れたが最後<br>生きて外に出ることはできないとされる
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:…そんな恐ろしい場所よ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430005")

	PlayAction(Actor005,"to  Std_Joy")
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:でもね、そんな果てなき森にも<br>ロマンティックな伝承が遺されているの
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430006")

	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:ノワールちゃん<br>なんだと思う？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00430008","PT5_01_00430009","PT5_01_00430010")
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
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ロマンティックな伝承…？<br>妖精にまつわるなにかとか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00430011")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "納得")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:正解！<br>さすが、ノワールちゃんってばロマンティストね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:森の奥には<br>素敵な王子様が住んでいる、とか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00430013")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:あら素敵！
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430014")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:ノワールちゃん<br>童話でも書いてみたらどう？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430015")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:あなた、きっと才能あるわよ！
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430016")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:果てなき森と言われているけど<br>実は果てがある、とか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00430017")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:…プッ！
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430018")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:すごく面白い冗談だけど<br>それはロマンティックではないわよね
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430019")

	goto Block1end

::Block1end::
	change_face(Actor005,"Normal")

	--★★クリスティーナ★★:果てなき森の奥にはね<br>妖精たちが住む里があるとされているの
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430020")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:だから<br>危険な場所といわれながらも
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430021")


	--★★クリスティーナ★★:真偽を確かめようと<br>森に足を踏み入れる者が後を絶たないそうよ
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★クリスティーナ★★:みんなは真似をしないようにしてね？
	Talk(Actor005,"CHRNAME_CHRISTINA","speech","L","PT5_01_00430023")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
