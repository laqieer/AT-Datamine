-- このluaスクリプトは、MA_01A110_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
load_image("101030490", "content_still_10103049_image", "101030490_StillImage")
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
tegami = setup_prop_object(10106003)
 --CameraEX = set_camera({11.129,1.548,-26.17,5,66.899,0.239,18})
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002, 1.0, 0.1, 0.3, 0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor001, 1.0, 0.1, 0.3, 0.5)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力

	--★★エレイン★★:先輩…こんにちは
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_090002")

-- ▼直接出力
lookat_weight_default(Actor002)
set_enable_auto_lookat(Actor002,true)
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:誰かを待っているのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_090003")

-- ▼直接出力
setup_small_camera_start(Camera002)
 --setup_small_camera_start(CameraEX)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,2.0)
PlayActionDirect(Actor002,"to LookFor")
se_play("SE_ADV_MA_01B112_49_Cloth")
wait_time(1.5)
PlayActionDirect(Actor002,"to Show")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
show_image("101030490", 0.0, 0.0, 0,true,false)
fadein(1.5)
setup_small_camera_start(Camera001)
wait_time(3.3)
hide_image(0)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
se_play("SE_ADV_MA_01105_28_Paper")
on_active(tegami)
on_parent(tegami,Actor001, "Loc_weapon_constrint_L", {0,0,0,0,0,0})
wait_time(0.8)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:「先輩に　あえたらなと」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_090005")


	--★★ノワール★★:「先輩の教室まで来たのですが<br>中まで入る勇気が出ず」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_090007")


	--★★ノワール★★:「先輩が出てこないかなと<br>待っていました」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_090008")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
 --off_parent(tegami)
 --off_active(tegami)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --setup_small_camera_end()
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
off_parent(tegami)
off_active(tegami)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:………おひる、ご一緒しませんか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_090010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_weight_default(Actor001)
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、もちろん<br>一緒に行こ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_090011")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…あ、ありがとう、ございますっ！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_090012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:わたし、先に行って待ってます…！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A110_090013")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
lookat_weight_reset(Actor001)
setup_small_camera_start(RndCamera006)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:エレイン、別に先に行くことはないのにな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_090014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も食堂に行くか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_090015")

--	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101030490", "content_still_10103049_image", "101030490_StillImage")
setup_prop_object_preload(10106003)
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
