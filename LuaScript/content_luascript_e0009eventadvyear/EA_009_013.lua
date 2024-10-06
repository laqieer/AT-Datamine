-- このluaスクリプトは、EA_009_013.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_02","110901_02_h")
Include("content_adv_advsmall_110901_02","Template110901_02_h")
-- ▼直接出力
Include("content_adv_advsmall_110901_01","110901_01_h")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_006)
	InitializeTemplateRandomCamera110901_02()
	InitializeTemplate110901_02()
-- ▼直接出力
set_pos(Actor001,{3.7, 0.011, -6.21})
turn_lookat(Actor002,Actor003,0)
turn_lookat(Actor003,Actor002,0)
turn_chara(Actor001,-19,0)
-- ▲直接出力
-- ▼直接出力
Camera001 = InitializeCharaCamera(CameraAssetBundleName110901_01, CameraPos110901_01_006, Actor001)
-- ▲直接出力
-- ▼直接出力
Camera_EX = set_camera({2.06, 1.34, 2.7,   0, 190.377, 0,   25})
-- ▲直接出力
-- ▼直接出力
Camera_EX2 = set_camera({4.9, 1.51, -0.54,   0, 280.9737, 0,   23.25889})
-- ▲直接出力
-- ▼直接出力
Camera_EX3 = set_camera({-3.112, 1.345, 2.963,   0, 257.574, 0,   20})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor002)
set_common_look_at(Actor002,Actor003)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Comical")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115911)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.4)
setup_small_camera_start(Camera_EX)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,CharaPos110901_01_006[1],CharaPos110901_01_006[2],CharaPos110901_01_006[3],2.8)
wait_time(2.8)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…結局、また逃げてきちゃったな<br>なにやってんだ、俺…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0130002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0130003")

-- ▼直接出力
setup_small_camera_end(Camera_EX)
setup_small_camera_start()
wait_time(0.4)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Comical")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0034")
-- ▲直接出力

	--★★エレイン★★:ヒソヒソ…それなら、大聖堂…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0130006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0034")
-- ▲直接出力

	--★★ディナタン★★:ヒソヒソ…ならアーサー様に…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130007")

-- ▼直接出力
setup_small_camera_end()
setup_small_camera_start(Camera_EX3)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:ヒソヒソ…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0130008")

-- ▼直接出力
setup_small_camera_end(Camera_EX3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:ヒソヒソ…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130009")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ものすごくヒソヒソ話してる…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0130010")

-- ▼直接出力
setup_small_camera_start(Camera_EX2)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_009_0130012","EA_009_0130013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふたりとも、なんの話をしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0130016")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:！？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0130017")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.8)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor001,0.4)
wait_time(0.4)
set_common_look_at(Actor003,Actor001)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.4)
wait_time(0.4)
set_common_look_at(Actor002,Actor001)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★エレイン★★:ヒエッ！？せせせせんぱい！？<br>どどどどうしましょうディディディナタンさん！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0130018")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor002,0.4)
wait_time(0.4)
set_common_look_at(Actor003,Actor002)
set_common_look_at(Actor002,Actor003)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130019")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130020")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0130021")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor001,0.4)
wait_time(0.4)
set_common_look_at(Actor003,Actor001)
set_common_look_at(Actor002,Actor001)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:（もう少し話を聞いてみよう）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_009_0130024")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★エレイン★★:ヒソヒソ…根回しはお兄ちゃんに頼んで…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0130025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:ヒソヒソ…トリスタンさんならきっと…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130026")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（ラヴェイン？トリスタン？<br>ふたりにいったいなにを頼むつもりなんだ…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_009_0130027")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.8)
lookat_weight_reset(Actor002)
lookat_weight_reset(Actor003)
wait_time(0.4)
PlayActionDirect(Actor003,"to  Std_Sad02")
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor002,"to  Std_No")
wait_time(4.0)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor001,0.4)
wait_time(0.4)
set_common_look_at(Actor003,Actor001)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.6)
PlayActionDirect(Actor003,"to  Std_Joy")
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、しまった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0130029")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0020")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ディナタン★★:兄さん！？そんなところでなにしてるの！？<br>盗み聞きなんてサイテー！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130030")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.4)
wait_time(0.4)
set_common_look_at(Actor002,Actor001)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そ、そんなつもりじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0130031")

	goto Block1end

::Block1end::
-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0019")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ディナタン★★:悪いけど、兄さんにはまだヒミツなの<br>なにを聞かれても一切お答えいたしません！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130033")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera_EX2)
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:兄さんはなにも気にしなくていいから<br>今はギネヴィアさんと一緒にいてあげて
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130034")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130035")

-- ▼直接出力
wait_time(0.4)
setup_small_camera_end(Camera003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0130036")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor002,0.4)
wait_time(0.4)
set_common_look_at(Actor003,Actor002)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ディナタン★★:さ、行こうエレインさん！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130037")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003,0.4)
wait_time(0.4)
set_common_look_at(Actor002,Actor003)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:はい！根回し作戦ですね！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0130038")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Sad")

	--★★ディナタン★★:シーッ！シーッ！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0130039")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Worry")
SkipDefaultMotion(Actor001)
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…気になる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0130041")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.8)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Comical")
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_area_scene_preload(115911)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
