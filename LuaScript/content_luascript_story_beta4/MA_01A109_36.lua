-- このluaスクリプトは、MA_01A109_36.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("104000140", "content_still_10400014_image", "104000140_StillImage")
tegami = setup_prop_object(10106003)
CameraEX = set_camera({-0.878,1.591,-0.166,8.35817,134.6594,357.2139,28.22622})
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
-- ▲直接出力
-- ▼直接出力
mob1 = setup_prop_object(10130024)
-- ▲直接出力
-- ▼直接出力
mob2 = setup_prop_object(10130025)
-- ▲直接出力
-- ▼直接出力
mob3 = setup_prop_object(10130012)
-- ▲直接出力
-- ▼直接出力
mob4 = setup_prop_object(10130013)
-- ▲直接出力
-- ▼直接出力
mob5 = setup_prop_object(10130015)
-- ▲直接出力
-- ▼直接出力
set_pos(mob1,{2.29, 0, -9.42})
set_rot(mob1,{0,320,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob2,{-4.64, 0, -7.27})
set_rot(mob2,{0,0,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob3,{-7.13, 0, -3.56})
set_rot(mob3,{0,291.3538,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob4,{-7.23, 0, 1.48})
set_rot(mob4,{0,202.7133,0})
-- ▲直接出力
-- ▼直接出力
set_pos(mob5,{9.01, 0, -3.18})
set_rot(mob5,{0,254.8817,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-0.46, 0, -5.4})
set_rot(Actor003,{0,275.3804,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-2.11, 0, -4.75})
set_rot(Actor004,{0,106.2227,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{3.25, 0, 5.28,   284.2421}	)
set_rot(Actor005,{0,284.2421,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{3.69, 0, 6.76,   230.8243})
set_rot(Actor006,{0,230.8243,0})
-- ▲直接出力
-- ▼直接出力
CAMERAEX001 = set_camera({-0.27, 1.61, -1.94,   7.86471, 185.5585, 0,   37})
-- ▲直接出力
-- ▼直接出力
CAMERAEX002 = set_camera({0.52, 1.86, 4.7,   10.95969, 256.8026, 359.0699,   37})
-- ▲直接出力
-- ▼直接出力
keep_turn_lookat(Actor001,Actor002,100)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000013)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
on_active(FX_DoF)
setup_small_camera_start(CameraEX)
PlayActionDirect(Actor002,"to LookFor")
-- ▲直接出力
-- ▼直接出力
wait_time(0.9)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Show")
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
ShowImageItem("104000140")
wait_time(1.3)
HideImageItem()
-- ▲直接出力
-- ▼直接出力
off_active(FX_DoF)
setup_small_camera_start(Camera001)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor001,"to ReadLetter")
on_active(tegami)
on_parent(tegami,Actor001, "Loc_weapon_constrint_L", {0,0,0,0,0,0})
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:「こんばんは、先輩」…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360002")


	--★★ノワール★★:「おひとりですか」…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360004")

-- ▼直接出力
off_parent(tegami)
off_active(tegami)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はぐれちゃって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:そうなんですか？<br>私もです、気が合いますね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360007")

-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:………いえ<br>気が、合っているわけでは…ありませんね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360008")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED + FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to LookFor")
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Show")
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to ReadLetter")
on_active(tegami)
on_parent(tegami,Actor001, "Loc_weapon_constrint_L", {0,0,0,0,0,0})
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:「手紙、書きませんか」…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360010")

-- ▼直接出力
setup_small_camera_start(Camera002)
off_parent(tegami)
off_active(tegami)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:花火が、上がる…そうです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:炎は…あの世への道しるべです<br>誰かに送りたい言葉があれば、お手紙で──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360013")


	--★★エレイン★★:先輩が、花を手向けた人へ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…………ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:書きますか！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360017")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ………ああ、うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Normal")

	--★★エレイン★★:どんな便せんにしましょう？宛先は？<br>年齢や性別、好みや性格に沿ったものを──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360021")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…………じゃあ、とうさんに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360022")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…おとうさま
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…皆、忘れてしまったから<br>どう整理をつけたらいいかわからなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360026")

	change_face(Actor002,"Sad")

	--★★エレイン★★:…………聖遺物化
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:言えなかったこと、ありますか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360031")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:全部、残せますよ<br>どれも思い起こせますよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:「さびしい」も「あいたい」も「さよなら」も<br>「ありがとう」も「あいしている」も
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360033")


	--★★エレイン★★:貴方が筆を走らせた時間が、頭を悩ませた期間が<br>大切な人への想いに変わるはずですから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:必ず伝わりますから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360035")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:………泣いているんですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360037")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:花畑で会ったキミとは<br>別人みたいだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:君は…誰なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A109_360039")

-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:誰──…なんでしょうか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:私は、私の意味を知りたくて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_360041")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000140", "content_still_10400014_image", "104000140_StillImage")
setup_prop_object_preload(10106003)
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
setup_prop_object_preload(10130024)
setup_prop_object_preload(10130025)
setup_prop_object_preload(10130012)
setup_prop_object_preload(10130013)
setup_prop_object_preload(10130015)
	InitializeLoad_Preload()
	load_duel_scene_preload(101000013)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
