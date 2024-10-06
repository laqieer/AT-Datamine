-- このluaスクリプトは、MA_01C112_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
on_cameraframe(2) 
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor003)
set_common_look_at(Actor002,Actor003)
turn_lookat(Actor003,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ランスロット★★:スノードンで待つ、か…
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C112_010002")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:本当にアーサーは敵なの？<br>まだ信じられない…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C112_010003")

-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力

	--★★パーシヴァル★★:信じたくないのはわかるけどさ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01C112_010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★パーシヴァル★★:でもアーサーは<br>バルバロイとともに行動していたんだろう？
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01C112_010005")

	change_face(Actor003,"Sad")

	--★★パーシヴァル★★:だったらボクたちの敵だよ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01C112_010006")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ランスロット★★:…とにかくいったん学園に戻ろう<br>一度、態勢を立て直して――
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C112_010008")

	PlayAction(Actor003,"to  Std_No")
	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★パーシヴァル★★:いいや、駄目だね！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","N","MA_01C112_010009")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor003, 0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:パーシヴァル？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C112_010010")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★パーシヴァル★★:せっかく尻尾を掴んだんだ<br>ここで逃がすわけにはいかないだろ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01C112_010011")


	--★★パーシヴァル★★:スノードンにて待っている？<br>フン、だったら行ってやろうじゃないか
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01C112_010012")

	PlayAction(Actor003,"to  Std_Joy")

	--★★パーシヴァル★★:堕ちた王に<br>ボクたちで引導を渡してやるんだ！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01C112_010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-224,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ちょっと待ってよ！罠かもしれないのに…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C112_010015")

-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor001, 1.0, 0, 0.5, 0.2,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力

	--★★ランスロット★★:行こう、ギネヴィア
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C112_010016")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,160.3,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 1.0, 0, 0.5, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力

	--★★ギネヴィア★★:ランスロットまで！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01C112_010017")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ランスロット★★:パーシヴァルを<ruby=ほう>放</ruby>ってはおけないだろう<br>それに…
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C112_010018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ランスロット★★:俺もあいつと話がしたい
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01C112_010020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
