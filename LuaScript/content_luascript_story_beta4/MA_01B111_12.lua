-- このluaスクリプトは、MA_01B111_12.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_05","110011_05_h")
Include("content_adv_advsmall_110011_05","Template110011_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_001)
	Camera002 = SetTemplate("Actor002",129.5096,CharaPos110011_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110011_05,CameraPos110011_05_003)
	InitializeTemplateRandomCamera110011_05()
	InitializeTemplate110011_05()
-- ▼直接出力
set_pos(Actor002,{-2.555, 0.315, -0.31})
Hide(Actor003)
se_play("SE_ADV_MA_01B112_41_Crowds")
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,{0.4,0.03,1.0,0.2})
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,{0.4,0.03,1.0,0.2})
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start()
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:お行儀悪いよ、マァル
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_120002")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力

	--★★マルディサント★★:それがウリなんでね
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B111_120003")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:並んで座って…お勉強したいなあ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_120004")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:なあんだよそれぇ<br>お安い御用だよそれぇ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B111_120006")

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
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B112_12_Door_Open")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-2.737, 0, 0.371})
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,155,0,0.3)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
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
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:あなたは…、確か…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_120008")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:見下ろしてンじゃねえぞコラあ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B111_120010")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:ひっ
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B111_120011")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.4)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:マァル
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_120012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルディサント★★:はいはいはい
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01B111_120013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガラハッド★★:ノワールの、妹
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B111_120014")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.4)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:はい。兄さんの妹ですが
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01B111_120015")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:………べんきょうを、教えてくれないか　
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01B111_120016")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
