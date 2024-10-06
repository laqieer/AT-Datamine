-- このluaスクリプトは、PT5_01_0022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:今日は<br>継承者と呼ばれる存在について話していく
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220002")


	--★★ランスロット★★:…といっても継承者については伝承が残る程度で<br>俺もほとんど知らないのだがな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:さて、以前<br>ＧＳは一銘一命と説明したことがあると思う
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:継承者はマスターに分類される存在なのだが<br>先ほどのルールから少々逸脱している
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:ひとりで<br>複数のキラーズをもつことができるのだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220006")


	--★★ランスロット★★:また、都度ＧＳを経る必要もないらしい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220007")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:そういった意味では一般的なマスターの<br>亜種や変異種といった扱いになるのかもな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00220009","PT5_01_00220010","PT5_01_00220011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そう特別扱いされると<br>なんだか照れるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00220012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…<br>俺はお前を特別扱いしているつもりはない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん<br>そんな自覚はないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00220014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は学生のひとりでしかないし<br>みんなと違うなんてつもりはない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00220015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ、それでいい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220016")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:自分だけが特別なのだとは思うな<br>皆とともに学び、歩んでいけばいい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:亜種？<br>上位種とくらい言ってほしいところだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00220018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…笑えない冗談だな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220019")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:キラーズを複数もてる<br>それは継承者の特異性のひとつではあるが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220020")


	--★★ランスロット★★:継承者の能力においてもっとも重要なのは<br>そこではないと俺は考えている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220021")


	--★★ランスロット★★:継承者はその名のとおり<br>なにかを継承する存在だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:過去からなにかを現在に継承するのか<br>それとも未来へなにかを継承するのか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220023")


	--★★ランスロット★★:どちらにせよ、そのために<br>複数のキラーズをもたされているのではないか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220024")


	--★★ランスロット★★:複数のキラーズを<br>もつ必要があるのではないか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220025")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ランスロット★★:その真相が判明するのは<br>いつになるのだろうな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00220026")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
