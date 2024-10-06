-- このluaスクリプトは、MA_01A110_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_02","111013_02_h")
Include("content_adv_advsmall_111013_02","Template111013_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111013_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111013_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_007)
	InitializeTemplateRandomCamera111013_02()
	InitializeTemplate111013_02()
-- ▼直接出力
set_pos(Actor001,{3.5,0,19})
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{2.2,0,16})
set_rot(Actor003,{0,36,0})
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-2.26,0,16})
set_rot(Actor004,{0,0,0})
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-2.5,0,17.5})
set_rot(Actor005,{0,94,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{3.1,0,16.25})
set_rot(Actor006,{0,264,0})
set_enable_auto_lookat(Actor006, false)
PlayActionDirect(Actor006,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
CameraEX_1 = 
set_camera(2.73,2.48,21.42,23.15,-139.5,0,28)
CameraEX_2 = set_camera(-1.65,2.11,21.48,10.9,137.6,0,22)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,2.5,0,17.5,2.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001,CharaPos111013_02_002[1],CharaPos111013_02_002[2],CharaPos111013_02_002[3],0.9)
wait_time(0.9)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.4)
setup_small_camera_start(CameraEX_1)
wait_time(0.8)
PlayActionDirect(Actor005,"to Std_Loop")
Hide(Actor005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Sad")

	--★★フレン★★:家族を探しているの！
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A110_210002")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
wait_time(0.1)
turn_chara(Actor001,330,0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★フレン★★:誰か知らない！？私にそっくりの…<br>双子の妹が、学園では一緒だった──
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A110_210004")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEX_2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor003,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to  Std_Angry")
-- ▲直接出力

	--★★フレン★★:姿が見えないの…！誰か答えて！ねえ！<br>なんでもいいから！教えて！？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A110_210005")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor006,"to Wlk")
PlayActionDirect(Actor003,"to Greet_one")
turn_lookat_position(Actor006,5.25,0,18.5,0.3)
wait_time(0.3)
slidemove(Actor006,5.25,0,18.5,1.8)
wait_time(0.7)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,0,0,16,0.3)
wait_time(0.3)
slidemove(Actor003,0,0,16,1.2)
wait_time(0.5)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
wait_time(0.7)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
Hide(Actor003)
Hide(Actor006)
-- ▲直接出力

	--★★フレン★★:…！<br>どうして…
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A110_210007")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Bow")
PlayActionDirect(Actor001,"to Std_Loop")
EntryWalk(Actor002,Camera002,EntryData111013_02_05,CameraAssetBundleName111013_02,CameraPos111013_02_105)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:そう騒ぐものではない、愛しき小鳥
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01A110_210009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-93,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to  Std_Surp")
-- ▲直接出力

	--★★フレン★★:ルーシャスくん、ローラはどこ…！
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A110_210010")


	--★★ルーシャス★★:フレン、そなたの夢はなんだ？
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01A110_210011")


	--★★フレン★★:え……？<br>妹と、安心して暮らす…こと
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01A110_210012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ルーシャス★★:余はそなたの悲しむ顔を見たくはない<br>胸が痛む、心が軋む、だが言わせてくれ
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01A110_210014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ルーシャス★★:叶わんな、それは
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","MA_01A110_210016")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
CameraEX_1 = 
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
