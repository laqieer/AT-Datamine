-- このluaスクリプトは、PT5_01_0012.csvから自動生成されました --
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

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:皆が学園に入学してからの最初の目標となる<br>ゲシュタルト・シフトについて話そう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120002")


	--★★ランスロット★★:ＧＳは儀式を経て因子を目覚めさせた２人が<br>絆を育んだ果てに至れるもので
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120003")


	--★★ランスロット★★:ひとりが戦闘に特化した状態<br>通称『キラーズ』に姿を変える能力を
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120004")


	--★★ランスロット★★:そしてもうひとりがキラーズの戦闘力を<br>制御・安定化させる能力『バイブス』を得られる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:後者は『マスター』と呼ばれることもあるな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:ＧＳによって得られる力は<br>バルバロイとの戦いには必要不可欠だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120007")


	--★★ランスロット★★:ノワール<br>なにか質問はあるか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00120009","PT5_01_00120010","PT5_01_00120011","PT5_01_00120012","PT5_01_00120013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	elseif is_select(4) then
		goto Block1_4
	elseif is_select(5) then
		goto Block1_5
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ＧＳの相手は誰でもいいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00120014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ＧＳはいつでも誰とでも<br>できるというわけではない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120015")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:同じ時を過ごし、絆を育み<br>想いが重なる相手が見つかったとき
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ＧＳへ至る扉が開かれることになる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:姿を変えるってのは<br>どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00120018")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:戦闘状態に入ったとき<br>活性化した因子がキラーズの体を包むことで
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:それまでとは<br>異なる姿に見えるようになるんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットも<br>ＧＳを済ませているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00120021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:もちろんだ<br>俺はマスターとしての能力を得ている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ<br>あんたのキラーズはどこにいるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00120023")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…<br>それについては、いずれ話そう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120024")

	goto Block1end

::Block1_4::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キラーズとマスターってのは<br>どうやって決まるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00120025")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺があんたのマスターになりたいと思えば<br>なれるものなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00120026")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:それについては<br>生まれ持った因子の性質による部分が多いらしい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120027")

	goto Block1end

::Block1_5::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ＧＳを経て戦闘能力が向上するのは<br>キラーズだけなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00120028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:いや<br>マスターの戦闘能力も合わせて向上する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120029")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:どう伝えたものか…<br>そうだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120030")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:キラーズの力は確かに優れているが<br>そのままでは抜き身すぎて自身にも負担が大きい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120031")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:同質・同程度の力をもつマスターがそばにいて<br>制御してやる必要がある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120032")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:キラーズを対バルバロイの武器<br>マスターはその鞘
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ふたつが揃って<br>はじめて真の力を発揮できると捉えてくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120034")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ＧＳは「したい」と思って<br>すぐにできるものではない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120035")


	--★★ランスロット★★:これからの学園生活でたくさんの仲間を作り<br>さまざまな経験を積んでほしい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120036")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:焦らなくていい<br>そのときは訪れるはずだからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00120037")

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
