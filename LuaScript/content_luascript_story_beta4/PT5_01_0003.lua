-- このluaスクリプトは、PT5_01_0003.csvから自動生成されました --
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
	load_area_scene(115020)
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

	--★★ブレイズ★★:前回の授業で<br>バルバロイは人間の記憶を喰らうこと述べたが…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:彼奴らも<br>手当たり次第に人間を襲うわけではない
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030003")


	--★★ブレイズ★★:ノワールに質問じゃ<br>バルバロイが好むのはどんな人間じゃと思う？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030004")

	open_select_window_tag(Actor001,"Normal","PT5_01_00030005","PT5_01_00030006","PT5_01_00030007")
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
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:たくさんの記憶をもっている人間のほうが<br>狙われやすいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00030008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:たとえば子供よりも大人とか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00030009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:残念、ちょっと違うのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん…<br>新鮮な記憶を求めて子供を狙うとか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00030011")

-- ▼直接出力
PlayPartVoice("ブレイズ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:はっきり言うと間違いなんじゃが…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:お主、なかなか怖いことを考えるのう…<br>ワシ、ちょっとゾクッとしちゃったぞい
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030013")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、なんだろう？<br>…キラーズとか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00030014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:正確には少し違うのじゃが<br>特別に正解としておいてやろう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030015")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:これまでの記録を見てみるとじゃな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030016")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:体内にキラーズ因子を多くもつ者が<br>バルバロイに狙われやすい傾向にある
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030017")


	--★★ブレイズ★★:端的に言えばキラーズやマスター<br>およびその候補生じゃな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:また、聞くところによれば<br>バルバロイは大きな記憶…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030019")

-- ▼直接出力
PlayPartVoice("ブレイズ", "悩む")
-- ▲直接出力

	--★★ブレイズ★★:大切な記憶を多くもつ者を優先的に狙う<br>ともいわれておる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030020")


	--★★ブレイズ★★:お主らは優れたキラーズ因子をもつとして<br>この学園へ入学することとなり
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030021")


	--★★ブレイズ★★:そして力となる記憶や絆を育むため<br>日々、青春を謳歌しておる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:つまり、バルバロイにとって天敵であると同時に<br>これ以上ないご馳走であるというわけじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:バルバロイのエサになどならぬよう<br>鍛錬を怠らぬようにの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00030024")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
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
