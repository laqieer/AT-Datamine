-- このluaスクリプトは、MA_01A112_47.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
load_sound("VO_story01")
load_image("10302003", "content_still_10302003_image", "103020030_StillImage")
change_face(Actor001,"Sad")
change_face(Actor002,"Sad")
change_face(Actor003,"Sad")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_No")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101041","001","101041001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("マルディサント", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルディサント★★:…ざけんな
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A112_470002")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:マァル
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01A112_470003")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力

	--★★マルディサント★★:ざけんなよおお…<br>まじでえええ…
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A112_470005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
-- ▲直接出力

	--★★ディナタン★★:…くさってなんか、ないよ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01A112_470006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:…っったりめえだ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A112_470007")


	--★★ディナタン★★:優しかったもの<br>ずっと
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01A112_470008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:…ああ。最期まで
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_470009")

	PlayAction(Actor002,"to  Std_Angry")

	--★★マルディサント★★:あれが仮にウソでも構やしねえ<br>アタシにとっちゃ大好きな人に変わりねえ…！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01A112_470010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:うん…<br>それで、それで少しだけ、ね…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01A112_470011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ディナタン★★:母さんに似てたんだ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01A112_470012")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10302003", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{-4.5,0,14.7})
set_rot(Actor001,{0,96,0})
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
change_face(Actor001,"Sad")
force_eyesync(Actor001,"Close")
set_pos(Actor002,{-4.3,0,15})
set_rot(Actor002,{7,-167,0})
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
change_face(Actor002,"Sad")
force_eyesync(Actor002,"Close")
-- ▲直接出力

	--★★モルガン★★:わたしはうまく動けないから
	Talk(Actor004,"CHRNAME_MORGAN","simple","N","MA_01A112_470014")


	--★★モルガン★★:些細なことでしか<br>学園の子たちの力になれないけど
	Talk(Actor004,"CHRNAME_MORGAN","simple","N","MA_01A112_470015")


	--★★モルガン★★:抗うすべ、選び抜く道、その先の平和に…<br>ノワールくん。貴方の武器が要るわ
	Talk(Actor004,"CHRNAME_MORGAN","simple","N","MA_01A112_470017")


	--★★モルガン★★:ふんばろうねっ<br>どんなに辛いことがあっても
	Talk(Actor004,"CHRNAME_MORGAN","simple","N","MA_01A112_470019")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image()
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
setup_small_camera_start(RndCamera007)
fadein(IMAGE_TIME_OUT_IN)
wait_time(5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("VO_story01")
load_image_preload("10302003", "content_still_10302003_image", "103020030_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115061)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101041","001","101041001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
