-- このluaスクリプトは、MA_01105_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_007)
	Camera006 = SetTemplate("Actor006",282.9,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110071_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_004)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
set_pos(Actor006,{-2.505,0.128,23.679})
set_pos(Actor007,{-3.28,0.128,23.76})
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor008,"telop","narration","N","MA_01105_291001")


	--★★テロップ★★:
	Talk(Actor008,"telop","narration","N","MA_01105_291002")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:円卓騎士見習いノワール。王妃誘拐で不敬罪！<br>これは死刑確実だぜ！
	Talk(Actor008,"telop","narration","N","MA_01105_291003")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Serious")

	--★★ガウェイン★★:円卓騎士見習いノワール。王妃誘拐で不敬罪！<br>これは死刑確実だぜ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_290002")

	open_select_window_tag(Actor002,"Normal","MA_01105_290004","MA_01105_290005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor002,"Serious")

	--★★ノワール★★:通してくれ<br>行かなきゃならないところがある
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290007")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:…ん？<br>なんか、勘違いしてねーか
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_290008")

	change_face(Actor004,"Normal")

	--★★ラグネル★★:キミたちを止めようなんて<br>思ってないよ
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01105_290009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:…あっ！<br>後ろ、後ろ！！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290011")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:えっ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_290012")

	change_face(Actor004,"Surprise")

	--★★ラグネル★★:なに？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01105_290013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:よし、今のうちに…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290014")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:…なんてな。待てって<br>お前らを捕まえに来たわけじゃねーよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_290015")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ラグネル★★:コトの重大さ、わかってる？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01105_290017")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:国賊となれば──
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_290019")

-- ▼直接出力
lookat_delay_weight(Actor001, {0.8, 0, 0.7, 0.35} ,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力

	--★★ギネヴィア★★:火あぶりの刑に処す！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_290020")

	change_face(Actor002,"Normal")

	--★★ノワール★★:自分で言うのか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290021")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ラグネル★★:それは大変だね！<br>じゃあそうならないよーに
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01105_290022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_default(Actor001, 0.5)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:俺たちが護衛してやんねーとな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_290023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01105_290025","MA_01105_290026")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ノワール★★:…ありがとう
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290028")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:よせやい
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_290029")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Smile")

	--★★ラグネル★★:よせやい
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01105_290030")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:いらないよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290032")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:それが任務なんだよっ！<br>黙って連れてけ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_290033")

	change_face(Actor004,"Smile")

	--★★ラグネル★★:ガウェインが変なフリしたのが<br>悪いんじゃないの～？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01105_290034")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:…置いてくんじゃねーよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_290036")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor005,Camera005,EntryData110071_04_07,CameraAssetBundleName110071_04,CameraPos110071_04_107)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor005, {1.0, 0.5, 1.0, 0.5} ,1.0)
keep_ik_lookat(Actor005,Actor002,"J_Head")
-- ▲直接出力
	change_face(Actor005,"Serious")

	--★★ランスロット★★:必ず帰って来い
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01105_290038")

-- ▼直接出力
lookat_delay_weight(Actor002, {1.0, 0.5, 1.0, 0.5} ,1.0)
keep_ik_lookat(Actor002,Actor005,"J_Head")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:ランスロット…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290040")

	open_select_window_tag(Actor002,"Normal","MA_01105_290042","MA_01105_290043")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	end

::Block3_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:ソールズベリーでの戦いのこと聞いた<br>バルバロイを引き付けてくれるって
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290045")

	change_face(Actor002,"Normal")

	--★★ノワール★★:…頼む
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290046")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ランスロット★★:頼まれなくとも
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01105_290048")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ノワール★★:死ぬなよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290050")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:あんたにはまだ聞かなきゃならないことが<br>山ほどあるんだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_290051")

	goto Block3end

::Block3end::
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_default(Actor005, 1.0)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:俺は死なない
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01105_290053")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
CloseTalkWindow()
wait_time(0.52)
-- ▲直接出力

	--★★ランスロット★★:火あぶりは見たくない
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01105_290055")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
