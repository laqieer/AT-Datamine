-- このluaスクリプトは、MA_01104_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor006",nil,CharaPos110011_03_018,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_018)
	Camera002 = SetTemplate("Actor007",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor008",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera004 = SetTemplate("Actor009",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera005 = SetTemplate("Actor010",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera006 = SetTemplate("Actor011",nil,CharaPos110011_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_004)
	Camera007 = SetTemplate("Actor012",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
load_image("MA_01104_03_1", "content_still_10301003_image", "103010030_StillImage")
load_image("10301001", "content_still_10301001_image", "103010010_StillImage")
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image("101010270", "content_still_10101027_image", "101010270_StillImage")
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("MA_01104_03_1", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon")
load_sound("VO_story01_op")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor008,Actor006,1.25)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor012,Actor006,1.25)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_2DOnly("101012","001","101012001")
	Actor002 = InitializeCharacter_2DOnly("401038","001","401038001")
	Actor003 = InitializeCharacter_2DOnly("401038","001","401038001")
	Actor004 = InitializeCharacter_2DOnly("101021","001","101021001")
	Actor005 = InitializeCharacter_2DOnly("101060","001","101060001")
	Actor006 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor012")
	Actor013 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★東方諸国連合軍兵_下位_2★★:張りつめてんなあ、坊主
	Talk(Actor002,"NPCNAME_0068","simple","N","MA_01104_030002")


	--★★東方諸国連合軍兵_下位★★:ンな気負うなよ、ノワールの大将ォ<br>ようやく念願が叶うってだけじゃねえか
	Talk(Actor003,"NPCNAME_0069","simple","N","MA_01104_030004")


	--★★東方諸国連合軍兵_下位_2★★:良かったな、オイ<br>初体験の楽しみが増えて
	Talk(Actor002,"NPCNAME_0068","simple","N","MA_01104_030006")


	--★★ディナタン★★:私、兄さんについていくから<br>どういう結果になっても
	Talk(Actor001,"CHRNAME_DINATAN","simple","N","MA_01104_030008")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("10301001", 0.0, 0.0, 0.0)
 --フェードイン
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ブルーノ★★:急がなくていいんだ、ノワール<br>お前の武器をゆっくり見つければいい
	Talk(Actor004,"CHRNAME_BRUNO","simple","N","MA_01104_040002")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("101010270", 0.0, 0.0, 0.0,true,true)
 --フェードイン
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★セレスティ★★:置き去りにしちゃうね
	Talk(Actor005,"NPCNAME_0163","simple","N","MA_01104_050002")

-- ▼直接出力
bgm_play("BGM_Area_Noon")
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
-- カメラ
DontChangeRandomCamera(true)
on_camera(RndCamera090)
 --エフェクト終了
hide_image()
 --スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
wait_time(1.0)
-- ▲直接出力

	--★★ランスロット★★:………彼は
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","MA_01104_060002")


	--★★テロップ★★:『世界平和の願いを叶える聖杯を探し求め<br>その聖杯へ導く妖精さんを守る騎士…！』
	Talk(Actor013,"telop","narration","N","MA_01104_060004")

-- ▼直接出力
set_enable_auto_lookat(Actor007,true)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
on_camera(Camera001)
-- ▲直接出力

	--★★ノワール★★:ノワールです
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01104_060006")


	--★★テロップ★★:『俺は、円卓の騎士になるんだ！』
	Talk(Actor013,"telop","narration","N","MA_01104_060008")


	--★★ノワール★★:追いつけるように、がんばります
	Talk(Actor006,"CHRNAME_NOIR","speech","L","MA_01104_060009")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA_01104_03_1", "content_still_10301003_image", "103010030_StillImage")
load_image_preload("10301001", "content_still_10301001_image", "103010010_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010270", "content_still_10101027_image", "101010270_StillImage")
preload_sound("BGM_Area_Noon")
preload_sound("VO_story01_op")
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_2DOnly_Preload("101012","001","101012001")
	InitializeCharacter_2DOnly_Preload("401038","001","401038001")
	InitializeCharacter_2DOnly_Preload("401038","001","401038001")
	InitializeCharacter_2DOnly_Preload("101021","001","101021001")
	InitializeCharacter_2DOnly_Preload("101060","001","101060001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor012")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
