-- このluaスクリプトは、EA_006_042.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",175,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera002 = SetTemplate("Actor002",-30,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera003 = SetTemplate("Actor003",203,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera004 = SetTemplate("Actor004",170,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera005 = SetTemplate("Actor005",175,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
keep_ik_lookat(Actor005,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003, {-1.597,0.128,24})
set_pos(Actor004, {-2.705,0.128,25.7})
set_pos(Actor005, {-2.24,0.128,24.5})
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0008")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0420003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420005")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0034")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420006")

-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0011")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420007")

	change_face(Actor003,"Laugh")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_006_0420009")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-70,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420010")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
Appear(Actor004)
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{-1.597,0.128,22.7}, 1.5)
wait_time(0.1)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{-2.705,0.128,23},1.5)
wait_time(0.1)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005, {-2.24,0.128,22},1.5)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera090)
wait_time(0.7)
PlayActionDirect(Actor003,"to Std_Loop")
turn_lookat(Actor003,Actor001,0.4)
wait_time(0.2)
PlayActionDirect(Actor004,"to Std_Loop")
turn_lookat(Actor004,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
turn_lookat(Actor005,Actor001,0.3)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0002")
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.5)
-- ▲直接出力

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_006_0420012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_006_0420013")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0042")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_006_0420014")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ヴォールス★★:
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_006_0420015")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力

	--★★クレア★★:
	Talk(Actor005,"CHRNAME_CLARE","speech","L","EA_006_0420016")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0010")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★クレア★★:
	Talk(Actor005,"CHRNAME_CLARE","speech","L","EA_006_0420018")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_006_0420020")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
	change_face(Actor003,"Laugh")
-- ▲直接出力

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420022")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0010")
-- ▲直接出力

	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0420023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0006")
-- ▲直接出力

	--★★ランスロット★★:
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","EA_006_0420024")

-- ▼直接出力
lookat_weight(Actor001,0.5,0.5,0.8,1)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,200,0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0007")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420025")

-- ▼直接出力
wait_time(0.4)
PlayPartVoiceDirect("ガレス","0036")
PlayActionDirect(Actor001,"to Greet_one")
wait_time(1)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,170,0.4)
wait_time(0.5)
slidemove(Actor002, {-0.43,0.128,17},2)
-- ▲直接出力
-- ▼直接出力
wait_time(1)
setup_small_camera_start(RndCamera090)
Hide(Actor002)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-70,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0001")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★クレア★★:
	Talk(Actor005,"CHRNAME_CLARE","speech","L","EA_006_0420027")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス★★:
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_006_0420028")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_006_0420029")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0047")
-- ▲直接出力

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420030")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor004)
Hide(Actor005)
Hide(Actor003)
template2()
lookat_weight_reset(Actor001)
setup_small_camera_start(RndCamera090)
--フェードイン
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","mind","L","EA_006_0420032")

	open_select_window_tag(Actor001,"Normal","EA_006_0420034","EA_006_0420035","EA_006_0420036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0034")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:ここはフラワーグッドフレンド作戦<br>スーパーアドバイザーのアーサーに頼むか～？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420039")

-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0051")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガレス★★:いや、でも王様に試食を頼むのは<br>さすがに不敬か～？気にしなさそうだけど…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420040")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガレス★★:ていうか、王様ってどっちかっていうと<br>試食してもらってから食べる人だった…駄目だ
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:やっぱり、いつも通りリオネスに頼むか～？
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420044")

-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0051")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガレス★★:いや、待てよ～。リオネス、確か…<br>お弁当作り中に散々つまみ食いしてたな～
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420045")

	change_face(Actor001,"Normal")

	--★★ガレス★★:すっごく美味しそうに食べてくれるから<br>ついつまみぐいを許しちゃうけど…
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420046")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0033")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガレス★★:試食は別の人に頼んだほうがいいかもだな～
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420047")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101032_sp_0005_3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ガレス★★:兄さん…は、あの円卓会議以来<br>ずっと喧嘩したままだしな～
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420050")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0041")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ガレス★★:試食を頼んだ勢いで仲直りできたり…<br>――いやいや、ここでわたしが折れちゃダメだ！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420051")

-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0033")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ガレス★★:…でも、どうせなら<br>一番に兄さんに食べてほしかったな～
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420052")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to Finger")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0050")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガレス★★:…そうだ！ランスロットに頼もう！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:なんたって、フラワーグッドフレンド作戦の<br>一番の協力者なんだから！
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420055")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:仕事に戻るって言ってたけど<br>そろそろ仕事も終わっただろうし
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420056")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ガレス_002","0035")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガレス★★:よし、ランスロットを探そう～♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0420057")

-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101032","002","101032002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
