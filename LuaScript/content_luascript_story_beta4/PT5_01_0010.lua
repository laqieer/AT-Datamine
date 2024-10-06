-- このluaスクリプトは、PT5_01_0010.csvから自動生成されました --
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
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_004)
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
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:全員、席に着いているな？<br>キラーズ学の授業を始める
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100002")


	--★★ランスロット★★:キラーズ学では<br>ゲシュタルト・シフトに至るまでの流れや
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100003")


	--★★ランスロット★★:ゲシュタルト・シフトを果たしたあと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:キラーズとして、マスターとして<br>どう世界と向き合っていくべきなのか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:そのための知識を<br>お前たちに示していこうと思っている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100006")

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:…ん？<br>どうした、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00100008","PT5_01_00100009","PT5_01_00100010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや…本当にランスロットが<br>先生をやってるんだなと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00100011")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100012")

-- ▼直接出力
PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:授業が始まれば<br>俺とお前は教師と生徒の関係だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100013")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:今回は大目に見るが<br>以後、その境界線を曖昧にするな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:悪い<br>今のこの状況がまだ理解できてなくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00100015")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ずっと傭兵をやっていたところに<br>突然学生をやれと言われたもんだからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00100016")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:焦る必要はない<br>ゆっくりと覚え、ゆっくりと慣れていけばいい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:別に<br>なんでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00100019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:さっさと授業を進めてくれよ<br>ランスロット先生
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00100020")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…<br>そうか、わかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100021")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ノワールだけに<br>意見を求めるのはよくないな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:…よし<br>本格的な授業は次回からにするとして
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100023")


	--★★ランスロット★★:今日は皆からＧＳや学生生活について<br>感じていることや不安に思っていることを聞こう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:…皆が無事ＧＳを果たし
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100025")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:キラーズやマスターとして<br>世に羽ばたいていくことを願っている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00100026")

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
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
