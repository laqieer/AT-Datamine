-- このluaスクリプトは、MA_01B111_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111091_03","111091_03_h")
Include("content_adv_advsmall_111091_03","Template111091_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-32.443,CharaPos111091_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111091_03,CameraPos111091_03_001)
	Camera002 = SetTemplate("Actor002",41.184,CharaPos111091_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111091_03,CameraPos111091_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111091_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111091_03,CameraPos111091_03_011)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111091_03_012,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111091_03,CameraPos111091_03_012)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111091_03_013,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111091_03,CameraPos111091_03_013)
	Camera006 = SetTemplate("Actor006",171.4505,CharaPos111091_03_014,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111091_03,CameraPos111091_03_014)
	InitializeTemplateRandomCamera111091_03()
	InitializeTemplate111091_03()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
 --set_pos(Actor001,{0.08, -0.649,6.673})
 --set_pos(Actor002,{-0.89, -0.642, 7.39})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111091)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101047","001","101047001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★ランスロット★★:『親』というのは<br>どういう存在なんだ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030003")


	--★★ランスロット★★:最近よく思い出す
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030004")

-- ▼直接出力
setup_small_camera_start(RndCamera011)
-- ▲直接出力

	--★★ランスロット★★:師匠とお前と<br>剣の稽古をしていた頃を
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030005")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:お前の母親も優しくて<br>食事もともにした
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030006")


	--★★ランスロット★★:そんな暖かい日々を思い出す
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B111_030008","MA_01B111_030009","MA_01B111_030010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺にとってはあんたも家族だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030012")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:…随分と、紆余曲折のある家族だな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030013")

	change_face(Actor001,"Smile")

	--★★ノワール★★:だから会いに来たんだよ<br>紆余曲折を経て
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:確か、ランスロットの親御さんは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030016")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺は生まれて間もなく<br>コルベニック城に預けられた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030017")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:両親の顔はおろか<br>その存在すら知らない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:フィエナもときどき混ざっていたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030020")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:湖から上がって来てびしょ濡れのままな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:はじめて見たときは父さんも大騒ぎだったよな<br>溺れたのか！？迷子か！？って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030022")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:今になって思えば『巫女』の儀式だったんだな<br>そのおかげで助けられている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030023")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:親…「親がどういうものか」…か<br>うまく言えないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030025")


	--★★ノワール★★:あんたの幼名が『ガラハッド』だった<br>っていうのは本当か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…ああ。名前をあらためたんだよ<br>お前が物心つく少し前にな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030027")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★ランスロット★★:故郷も親もない自分とは何か別の<br>ただ、ただ強く生きられる自分を…ねだった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030028")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:「ねだった」ぁ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030030")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ランスロット★★:駄々っ子だったんだよ。俺も<br>欲しがりで、癇癪を起こして、頑固で…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030032")


	--★★ランスロット★★:そのうち<br>師匠が名前をくれたんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030034")

	change_face(Actor001,"Normal")

	--★★ノワール★★:………だったら、父さんはさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:名付け親じゃないか。あんたの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:………師匠が、俺の──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030040")


	--★★ノワール★★:育ての父だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030042")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…父
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030043")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:父か
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030045")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあ、あんたが名付けられるより先に<br>俺が産まれたってことはだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030047")

	change_face(Actor001,"Smile")

	--★★ノワール★★:父さんの息子としては<br>俺のほうが兄ってことになるけど？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030048")


	--★★ランスロット★★:その師匠の弟子としては<br>俺のほうが兄だが？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:やるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B111_030052")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:やろうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B111_030053")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B111_03_Sword")
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
Appear(Actor006)
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor001, 1, false)
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor002, 1, false)
-- ▲直接出力
-- ▼直接出力
sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
-- ▲直接出力
-- ▼直接出力
sword_02 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
-- ▲直接出力
-- ▼直接出力
weapon_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(sword_01,Actor001, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
on_parent(sword_02,Actor002, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,25.8,0,0.3)
-- ▲直接出力
-- ▼直接出力
 --set_pos(Actor001,{-0.07, -0.585,7.3})
 --set_pos(Actor002,{-1.23, -0.642, 7.32})
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,339.046,0,0.3)
-- ▲直接出力
-- ▼直接出力
barubaroi_taore = setup_prop_object(10130004)
-- ▲直接出力
-- ▼直接出力
barubaroi_taore2 = setup_prop_object(10130004)
-- ▲直接出力
-- ▼直接出力
set_pos(barubaroi_taore,{1.567, -0.612, 8.411})
-- ▲直接出力
-- ▼直接出力
set_pos(barubaroi_taore2,{-1.183, -0.632, 7.526})
-- ▲直接出力
-- ▼直接出力
set_rot(barubaroi_taore,{0,-167.021,0})
-- ▲直接出力
-- ▼直接出力
set_rot(barubaroi_taore2,{0,-218.266,0})
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ティーロノエー★★:………サイテー
	Talk(Actor003,"CHRNAME_SISTERS_6","speech","R","MA_01B111_030055")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111091)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101047","001","101047001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111091_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
