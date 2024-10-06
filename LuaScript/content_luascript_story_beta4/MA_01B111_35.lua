-- このluaスクリプトは、MA_01B111_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation05","DuelCommonFormation05_h")
Include("content_adv_advsmall_duelcommonformation05","TemplateDuelCommonFormation05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation05,CameraPosDuelCommonFormation05_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation05_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_018_01_MA01B111_35_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation05,CameraPosDuelCommonFormation05_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation05,CameraPosDuelCommonFormation05_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation05_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation05,CameraPosDuelCommonFormation05_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation05,CameraPosDuelCommonFormation05_005)
	InitializeTemplateRandomCameraDuelCommonFormation05()
	InitializeTemplateDuelCommonFormation05()
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
CUT_10 = cat_template_camera("P10_Cam")
CUT_11 = cat_template_camera("P11_Cam")
CUT_12 = cat_template_camera("P12_Cam")
CUT_13 = cat_template_camera("P13_Cam")
CUT_14 = cat_template_camera("P14_Cam")
CUT_15 = cat_template_camera("P15_Cam")
CUT_16 = cat_template_camera("P16_Cam")
CUT_17 = cat_template_camera("P17_Cam")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001 = CUT_10
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101200051)
	Actor001 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101056","002","101056002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.0)
setup_small_camera_start(CUT_11)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:お爺様、お爺様、待って…！お爺様…！！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_350002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CUT_12)
wait_time(0.2)
-- ▲直接出力

	--★★ペレス★★:ようやく迎えに来られた
	Talk(Actor002,"CHRNAME_PEREZ","speech","R","MA_01B111_350003")

	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:………お爺様？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_350004")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"Std01_end")
wait_time(2.3)
fadeout(0,0,0,1.0,0.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_13)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"Sit01_Start")
set_pos(Actor002,{CharaPosDuelCommonFormation05_007[1],CharaPosDuelCommonFormation05_007[2],CharaPosDuelCommonFormation05_007[3]})
turn_chara(Actor002,CharaPosDuelCommonFormation05_007[4],0)
set_pos(Actor001,{CharaPosDuelCommonFormation05_006[1],CharaPosDuelCommonFormation05_006[2],CharaPosDuelCommonFormation05_006[3]})
turn_chara(Actor001,CharaPosDuelCommonFormation05_006[4],0)
wait_time(0.1)
fadein(0.2)
wait_time(2.57)
-- ▲直接出力

	--★★ペレス★★:ノワール卿<br>ランスロット卿
	Talk(Actor002,"CHRNAME_PEREZ","speech","R","MA_01B111_350006")

-- ▼直接出力
wait_time(0.2)
setup_small_camera_start(CUT_14)
wait_time(0.2)
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","MA_01B111_350007","MA_01B111_350008","MA_01B111_350009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★ノワール★★:…ランスロットから、離れろ<br>どういうつもりだ…！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_350011")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CUT_15)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ペレス★★:どういうつもりもなにも<br>最初からそのつもりであった
	Talk(Actor002,"CHRNAME_PEREZ","speech","R","MA_01B111_350012")

	change_face(Actor004,"Anger")

	--★★ランスロット★★:要求は端的に願おう…！
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_350013")

	change_face(Actor002,"Normal")

	--★★ペレス★★:故郷へお帰り願うべく
	Talk(Actor002,"CHRNAME_PEREZ","speech","R","MA_01B111_350014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★ノワール★★:ほかに迎えるべき者がいるはずだ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_350016")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CUT_15)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ペレス★★:ガラハッドは良かろう
	Talk(Actor002,"CHRNAME_PEREZ","speech","R","MA_01B111_350017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ガラハッド★★:お爺様…！？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B111_350018")

	change_face(Actor002,"Normal")

	--★★ペレス★★:あれはフィエナに任せておる
	Talk(Actor002,"CHRNAME_PEREZ","speech","R","MA_01B111_350019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★ノワール★★:兵を退け…！<br>銀卓と円卓が争う理由は──
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_350021")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CUT_15)
wait_time(0.2)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ペレス★★:ないであろうな<br>ランスロット卿とノワール卿がおいでになれば
	Talk(Actor002,"CHRNAME_PEREZ","speech","R","MA_01B111_350022")

	change_face(Actor004,"Anger")

	--★★ランスロット★★:俺たちまでバルバロイに喰わせるつもりか？<br>銀卓騎士団と同様に
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01B111_350023")

	change_face(Actor002,"Normal")

	--★★ペレス★★:だとすれば必ずや拒否することもわかっておる<br>そこが争点であろうな、ゆえにこうして参った
	Talk(Actor002,"CHRNAME_PEREZ","speech","R","MA_01B111_350025")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
wait_time(0.3)
setup_small_camera_start(CUT_16)
wait_time(0.6)
-- ▲直接出力

	--★★アーサー★★:王同士、慎ましやかに行きませんか
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01B111_350027")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CUT_17)
wait_time(0.4)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:アー、サー…！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B111_350029")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101200051)
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101056","002","101056002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
