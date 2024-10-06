-- このluaスクリプトは、PT5_01_0031_1.csvから自動生成されました --
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
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
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
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:ゲシュタルト・シフトを無事済ませ<br>修了として認定されれば、お前たちは卒業となる
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00310002")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:卒業後の進路はさまざまだ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00310003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:ログレスの正式な騎士となる者もいれば<br>家族を守るべく故郷に戻る者もいる
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00310004")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ランスロット★★:ノワール<br>お前ならどうしたい？
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00310005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00310006","PT5_01_00310007","PT5_01_00310008")
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
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:この学園でいろいろ学ばせてもらって<br>騎士とはどうあるべきかを理解したつもりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00310009")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:学園を卒業できたら<br>この国の騎士になるのも悪くないかなと思ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00310010")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ランスロット★★:なるほどな<br>本当にそうなるようなら、歓迎させてもらう
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00310011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここで学んだ知識や技術を活かして<br>家族や仲間を守っていきたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00310012")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ランスロット★★:お前らしい答えだ<br>素晴らしいと思う
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00310013")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:騎士も悪くないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00310014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺は自由気ままに<br>世界を転々とするのが合ってる気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00310015")

	change_face(Actor001,"Smile")

	--★★ノワール★★:だから<br>傭兵に戻ろうかなって考えてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00310016")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:そうか。少々残念ではあるが…<br>それがもっともお前らしい生きかたかもしれない
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00310017")

	goto Block1end

::Block1end::
	change_face(Actor005,"Normal")

	--★★ランスロット★★:卒業後どうするかを<br>俺からお前たちに強要するつもりはない
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00310018")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ランスロット★★:皆が信念のもと、独自の道を進んでくれること<br>俺にとってはそれが一番嬉しい
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00310019")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
