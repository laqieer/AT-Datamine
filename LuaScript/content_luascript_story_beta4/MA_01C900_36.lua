-- このluaスクリプトは、MA_01C900_36.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera003 = SetTemplate("Actor003",-133,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_004)
	Camera003 = SetTemplate("Actor003",-133,CharaPos110111_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_001)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
-- ▼直接出力
CameraEx = set_camera({2.3,1.7,-17.79,8.478,280, 0,28.22622})
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★知将ケイ★★:避難はマーリンが言い出した<br>胸騒ぎがすると言ってな
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_360002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★知将ケイ★★:おかげで被害は最小限に食い止められた<br>…まったく、世話の焼ける愚弟だ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_360003")

	change_face(Actor002,"Smile")

	--★★知将ケイ★★:これから復興のために色々動かねばな<br>貴公にも手伝ってもらうぞ
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_360004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★知将ケイ★★:もちろん、貴公の妹にもな<br>…そういえば、彼女はどうしたんだ？
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C900_360005")

	change_face(Actor003,"Sad")

	--★★マーリン★★:ノワール様、ありがとうございます<br>…あの人を止めてくれて
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C900_360007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★マーリン★★:己の決断を悔いる必要はありません<br>あなたはただ、選んだだけ
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C900_360008")

	change_face(Actor003,"Sad")

	--★★マーリン★★:あなたも、あの人も<br>選んだ道をまっすぐ生き抜いた
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C900_360009")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マーリン★★:その記憶を森は忘れないでしょう<br>例えあなたが、忘れたとしても
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C900_360010")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
wait_time(1.0)
template2()
setup_small_camera_start(RndCamera004)
Hide(Actor003)
Hide(Actor002)
set_pos(Actor001,{0.31,0,-17.6,106.3905})
turn_chara(Actor001,125,0)
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight_reset(Actor001,1.0)
PlayActionDirect(Actor001,"to  Std_Sad02")
fadein(FADE_TIME)
wait_time(FADE_TIME + 2)
setup_small_camera_start(CameraEx)
slidemove2(CameraEx,{2.26,1.7,-18.01,6.0,3})
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:ディナタンがいない――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_360012")

	change_face(Actor001,"Serious")

	--★★ノワール★★:どこだ――<br>どこにいるんだ、ディナタン…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_360013")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 1.6)
wait_time(3.0)
se_play("SE_ADV_MA_01C900_36_Baby")
wait_time(3.9)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
fadein(1.0)
wait_time(1.0)
-- ▲直接出力
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
