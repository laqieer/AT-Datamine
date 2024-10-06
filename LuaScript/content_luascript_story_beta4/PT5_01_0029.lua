-- このluaスクリプトは、PT5_01_0029.csvから自動生成されました --
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
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110011_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_004)
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
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:今日は円卓の騎士について話していこう
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290002")


	--★★ランスロット★★:円卓の騎士は前王ユーサーが生前発足した組織で
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290003")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:この国でも選りすぐりの騎士たちの総称だ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:円卓の騎士は<br>ログレスやこの島全体の平和の維持および
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290005")


	--★★ランスロット★★:伝説の秘宝『聖杯』と<br>それへ導く『妖精』とを探し、守ること
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290006")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:この２点を目的としている
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290007")


	--★★ランスロット★★:俺と、このクラスでいえばガウェインも<br>円卓の一席に数えられる
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:へへっ…
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","PT5_01_00290009")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力

	--★★ランスロット★★:円卓の騎士には行動の自由権が与えられており<br>政治や軍事への口出しも認められる
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290010")


	--★★ランスロット★★:ただし、そのぶん円卓の騎士の行動には<br>常に責任が問われる
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:国の大事のさいには<br>円卓の間に集まり
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290012")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:上座も下座もないという前提で<br>意見を戦わせたり、意思決定を行うことになる
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","PT5_01_00290014","PT5_01_00290015","PT5_01_00290016")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:本当に円卓には上座も下座もないのか？<br>アーサーも円卓の騎士のひとりなんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00290017")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:座につけば<br>アーサー王も円卓の騎士のひとりだ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290018")

	change_face(Actor005,"Normal")

	--★★ランスロット★★:円卓の総意に反するのであれば<br>アーサーの意見すら却下される
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290019")

	change_face(Actor005,"Normal")

	--★★ランスロット★★:これはアーサー直々の発案なんだ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今、円卓の騎士は何人いるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00290021")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:円卓には全部で１３の席があるが<br>そのすべてが埋まっているわけではない
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290022")

	change_face(Actor005,"Normal")

	--★★ランスロット★★:優れた騎士を選ぶことが大事なのであって<br>席を埋めることは重要ではないからな
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290023")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:円卓の騎士になるには<br>どうしたらいいんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT5_01_00290024")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:円卓の騎士は、戦闘技術はもちろんのこと<br>日々の振る舞いや人格なども評価される
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290025")

	change_face(Actor005,"Normal")

	--★★ランスロット★★:自薦、他薦などがあったあと<br>円卓会議にかけられ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290026")

	change_face(Actor005,"Normal")

	--★★ランスロット★★:相応しい人材であると評価されれば<br>円卓の騎士に任命される
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290027")

	goto Block1end

::Block1end::
	change_face(Actor005,"Normal")

	--★★ランスロット★★:円卓の騎士の名は他国にも響き渡っている<br>もしも円卓入りを果たしたのであれば
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290028")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:その名に恥じぬ行いを心掛けてほしい
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","PT5_01_00290029")

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
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
