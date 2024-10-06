-- このluaスクリプトは、MA_01B112_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111031_02","111031_02_h")
Include("content_adv_advsmall_111031_02","Template111031_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111031_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111031_02,CameraPos111031_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111031_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111031_02,CameraPos111031_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111031_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111031_02,CameraPos111031_02_003)
	InitializeTemplateRandomCamera111031_02()
	InitializeTemplate111031_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor003,0.8, 0.3, 0.6, 0.3,0.8)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera090)
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:見舞いに、来てくれるころだと…思ってたよ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:傷の具合は？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_190003")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:生憎…不死身でね
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:よく言う
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_190006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★アーサー★★:連れて行ってくれるんだろう？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190008")

	open_select_window_tag(Actor001,"Normal","MA_01B112_190009","MA_01B112_190010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どうしてそこまでして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_190012")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:理由はないよ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190013")

	change_face(Actor003,"Normal")

	--★★アーサー★★:理由を探したら、キツくないか？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:付き合ってもらう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_190017")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,257.3,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:ノワール──…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_190018")

	change_face(Actor003,"Normal")

	--★★アーサー★★:ノワール、お前は俺を王としてでなく<br>ひとりの騎士として見てくれるな
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190019")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
turn_chara(Actor002,157,0)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:…ありがとう、ノワール
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190020")

	goto Block1end

::Block1end::
-- ▼直接出力
wait_time(0.2)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★アーサー★★:王にしかできないこともある
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190022")


	--★★アーサー★★:ペレス王が餌をちらつかせているのもわかる<br>だが、行かねば餌すら息絶える
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190023")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺は止めに来たんだ、アーサー
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B112_190024")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★アーサー★★:ハッハッハッハッハ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_190025")


	--★★アーサー★★:つれないことを言うなよ、ランス
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_9030002")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★アーサー★★:そうと決まれば善は急げだ<br>すぐにでもここを発とう
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_9030004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:会議が待ってる
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B112_9030006")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111031_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
