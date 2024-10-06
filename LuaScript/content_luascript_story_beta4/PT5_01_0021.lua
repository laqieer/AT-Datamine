-- このluaスクリプトは、PT5_01_0021.csvから自動生成されました --
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
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:今回の話を皆にしようかどうかは<br>ずっと悩んでいたんだが…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:やはり、しておくべきだという結論に至った
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210003")


	--★★ランスロット★★:『聖遺物化』についてだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:前にも説明したとおり<br>キラーズの力は無尽蔵ではない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210005")


	--★★ランスロット★★:マスターとともにあったとしても<br>戦い続けていれば少しずつすり減っていく
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210006")


	--★★ランスロット★★:そしてすべての力を使い果たしたとき<br>キラーズは文字どおりの武器へとその姿を変え…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210007")


	--★★ランスロット★★:周囲の人間からその存在を忘れられる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00210009","PT5_01_00210010","PT5_01_00210011")
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
	change_face(Actor001,"Sad")

	--★★ノワール★★:武器になって世界から忘れられてしまう…<br>それは避けられない運命なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00210012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:すべての力を使い果たした場合の話だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210013")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:そういった最期を迎えないのであれば<br>他の人間と同じ一生を過ごすこともできる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:誰もキラーズのことを<br>覚えていられないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00210015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:例外はある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210016")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:マスターと継承者は<br>キラーズについての記憶を失うことはない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:そんな事実を隠して<br>俺たちにＧＳへの道を強要していたのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00210018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…すまない<br>そういうことになる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210019")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ランスロット★★:キラーズとなった者には<br>聖遺物化の運命が待ち受ける
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ランスロット★★:だが、これをただの悲しい運命と<br>とらえないでほしい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210021")


	--★★ランスロット★★:キラーズとして戦う資格をもって生まれ<br>ＧＳを経て、命を共有する者と出会えたこと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:そして<br>仲間とともに世界のために戦うこと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:これは<br>素晴らしきことなのだと思ってほしい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","PT5_01_00210024")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
