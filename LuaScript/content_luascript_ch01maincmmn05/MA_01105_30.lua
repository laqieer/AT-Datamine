-- このluaスクリプトは、MA_01105_30.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115024)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:お供いたします。マスター
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01105_300002")


	--★★ノワール★★:ティルフィング
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_300003")


	--★★ティルフィング★★:「誰かがやってくれればいいのに」<br>そうは思わないのですね
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01105_300004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:仇討ちも、救済も、守護も、戦も
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01105_300005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01105_300007","MA_01105_300008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ノワール★★:やれることをやってるだけだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_300010")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Normal")

	--★★ノワール★★:俺の手の届く範囲で<br>やれることを、できる限り
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_300011")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ティルフィング★★:…ご立派です、マスター
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01105_300012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ノワール★★:誰かが代わってくれるのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_300014")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Sad")

	--★★ティルフィング★★:…いいえ。それは
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01105_300015")

	change_face(Actor004,"Normal")

	--★★ティルフィング★★:ですが強いることもできません<br>戦いに出向くも背くも、マスターの選択です
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01105_300016")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to Bow")
	change_face(Actor004,"Normal")

	--★★ティルフィング★★:私の命はご随意に<br>アナタの願いのために振るってください
	Talk(Actor004,"CHRNAME_TYRFING","speech","L","MA_01105_300018")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_300019")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115024)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
MobsNo = 0
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
