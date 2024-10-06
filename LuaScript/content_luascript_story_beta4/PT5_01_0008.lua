-- このluaスクリプトは、PT5_01_0008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
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
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
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
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力

	--★★ブレイズ★★:今日は…そうじゃな<br>魔女について語っていこうかの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:お主らのうちの何人かは<br>見た者もおるかと思うが…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080003")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:魔女は空中を自在に飛び回り<br>円卓の騎士すら苦しめるほどの戦闘能力を誇る
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力

	--★★ブレイズ★★:魔女は見た目こそ<br>ワシら人間によく似ておるが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080005")


	--★★ブレイズ★★:バルバロイを使役する姿が<br>確認されておることから
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:バルバロイに近い存在…<br>むしろバルバロイの上位種ではともいわれる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080007")


	--★★ブレイズ★★:ただ…ワシはその説には<br>今のところ異を唱えておる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "驚き")
-- ▲直接出力

	--★★ブレイズ★★:ノワール<br>なぜじゃと思う？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080009")

	open_select_window_tag(Actor001,"Normal","PT5_01_00080010","PT5_01_00080011","PT5_01_00080012")
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
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん<br>ちょっとわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00080013")

-- ▼直接出力
PlayPartVoice("ブレイズ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:素直なのは悪いことではないが<br>もう少し考えてみても良いと思うがのう…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイと違って<br>魔女には自我がある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00080015")

-- ▼直接出力
PlayPartVoice("ブレイズ", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:バルバロイ憑きの例もあるし<br>一概にそうとは言えぬが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:まあ、当たらずとも遠からずじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:魔女たちの目的は<br>バルバロイとは違うんじゃないかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00080018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:さすがはノワール<br>良い目の付けどころじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080019")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:魔女たちは<br>確かにバルバロイを使役してはいるものの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080020")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力

	--★★ブレイズ★★:人間の記憶を欲しているような<br>素振りは見せていないと聞く
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080021")


	--★★ブレイズ★★:バルバロイよりも上位な存在であることに<br>間違いはないじゃろうが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力

	--★★ブレイズ★★:バルバロイと同種ではなく<br>かつバルバロイとは異なる目的をもっている
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:…ワシはそう考えておる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00080024")

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
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
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
