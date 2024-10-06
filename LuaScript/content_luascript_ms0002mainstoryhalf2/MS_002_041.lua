-- このluaスクリプトは、MS_002_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation04","DuelCommonFormation04_h")
Include("content_adv_advsmall_duelcommonformation04","TemplateDuelCommonFormation04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",0,CharaPosDuelCommonFormation04_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_523_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_021)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation04_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_523_01_ms0002_01_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_021)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_523_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_011)
	InitializeTemplateRandomCameraDuelCommonFormation04()
	InitializeTemplateDuelCommonFormation04()
-- ▼直接出力
CUT_10 =  cat_template_camera("R_Cam11")
CUT_21 =  cat_template_camera("P21_Cam")
CUT_11 =  cat_template_camera("P11_Cam")
CUT_111 =  cat_template_camera("P111_Cam")
CUT_01 =  cat_template_camera("P01_Cam")
RCUT_01 =  set_camera({-1.422, 1.363, -0.497,   3.26, 123.398, 0,   32.31116})
CUT_041 =  cat_template_camera("R_Cam01")
-- ▲直接出力
-- ▼直接出力
RndCamera001=CUT_10
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to MS002_041_Sit10_Loop")
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
Hide(Actor002)
Hide(Actor005)
Hide(Actor001)
set_pos(Actor002,{0.12, 0, 5.44})
-- ▲直接出力
-- ▼直接出力
Ef_Killers = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
set_pos(Ef_Killers,{0.821, 0, -1.986,})
Ef_Killers2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
turn(Ef_Killers2, 0, 180, 0, 0)
set_pos(Ef_Killers2,{0, 0, 1.641,})
-- ▲直接出力
-- ▼直接出力
Ef_KillChan1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
set_pos(Ef_KillChan1,{0.821, 0, -1.986,})
turn(Ef_KillChan1, 0, -50, 0, 0)
Ef_KillChan2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true) 
turn(Ef_KillChan2, 0, 200, 0, 0)
set_pos(Ef_KillChan2,{0, 0, 1.641,})
-- ▲直接出力
-- ▼直接出力
Ef_Emblem01 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem23",false,true)
turn(Ef_Emblem01, 0,120, 0, 0)
set_pos(Ef_Emblem01,{0.821, 0.9, -1.986,})
Ef_Emblem02 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Emblem22",false,true)
turn(Ef_Emblem02, 0,180, 0, 0)
set_pos(Ef_Emblem02,{0, 1, 1.641,})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_LTeinn")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060012)
	Actor001 = InitializeCharacter_3D("101070","001","101070001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101070","001","101070001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101070","002","101070002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101002","001","101002001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.5)　　--しばらく空を写す
setup_small_camera_start(CUT_21)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0057")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フライクーゲル3★★:
	Talk(Actor003,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410005")


	--★★フライクーゲル3★★:でも…わたしと逃げたって<br>きみは、あんまり自由じゃないかな
	Talk(Actor003,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410006")


	--★★フライクーゲル3★★:
	Talk(Actor003,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410007")


	--★★フライクーゲル3★★:………
	Talk(Actor003,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410008")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0013")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★フライクーゲル3★★:…あっはは。ヤバいなぁ<br>アブないオンナって感じするね？
	Talk(Actor003,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410009")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor002)
PlayActionDirect(Actor002,"to Wlk")
wait_time(2.55)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フライクーゲル3★★:レーヴァ
	Talk(Actor003,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410012")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera090)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,0, 0, 1.641,3.05)
wait_time(1.5)
setup_small_camera_start(CUT_111)
wait_time(1.55)

PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★レーヴァテイン★★:前からずっと、危なげだったよ
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410013")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0053")
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410015")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0014")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フライクーゲル3★★:オーバーだなあ
	Talk(Actor003,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410016")


	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410017")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0040")
-- ▲直接出力

	--★★レーヴァテイン★★:こんな状況で<%player>を<br>ひとり歩きさせるわけにはいかない
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410018")

-- ▼直接出力
PlayActionDirect(Actor003,"to MS002_041_Sit10_End")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フライクーゲル3★★:
	Talk(Actor003,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410019")

-- ▼直接出力
setup_small_camera_start(CUT_11)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★レーヴァテイン★★:あなたの思いもわかる
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410020")


	--★★レーヴァテイン★★:私だってこれ以上<br><%player>に負担はかけたくない
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410021")

	change_face(Actor003,"Surprise")

	--★★フライクーゲル3★★:
	Talk(Actor003,"CHRNAME_FREIKUGEL","speech","L","MS_002_0411001")

-- ▼直接出力
CloseTalkWindow()
Hide(Actor003)
Appear(Actor001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410022")

	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:………<br>…そう、かも…ね
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410023")

-- ▼直接出力
setup_small_camera_start(RCUT_01)
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,0.821, 0, -1.986,3.35)
wait_time(3.35)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0056")
-- ▲直接出力

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410024")


	--★★フライクーゲル★★:「望まれたら応えなきゃ」<br>その姿勢はきっと正しいし尊いし推せるよ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410025")

-- ▼直接出力
voice_play("VO_101070001_sp_0001_3")
-- ▲直接出力

	--★★フライクーゲル★★:だけどダーリンが命懸けで戦って<br>例えば万一イミテーションを退けられたとして
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410026")

	PlayAction(Actor001,"to  Std_Angry")

	--★★フライクーゲル★★:そのあとは…っ？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410027")


	--★★フライクーゲル★★:そのあとも<br>戦いはずっと続く
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410028")

-- ▼直接出力
setup_small_camera_start(CUT_041)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0053")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410029")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410031")

-- ▼直接出力
CloseTalkWindow()
on_active(Ef_Emblem01)
play_particle(Ef_Emblem01)
wait_time(1.5)
on_active(Ef_Killers)
play_particle(Ef_Killers)
-- ▲直接出力

	--★★フライクーゲル★★:
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410032")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:…自由に生きる人生が、いい？
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410033")


	--★★レーヴァテイン★★:だから私を撃って<br><%player>と逃げる？
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410034")


	--★★フライクーゲル★★:少なくとも<br>わたしは
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410035")

-- ▼直接出力
setup_small_camera_start(RCUT_01)
CloseTalkWindow()
on_active(Ef_KillChan1)
play_particle(Ef_KillChan1)

wait_time(0.7)

fadeout(255,255,255,1.0,0.4)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor004)
Hide(Actor001)

fadein(FADE_TIME)
stop_particle(Ef_Killers)
	
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0041")
setup_small_camera_start(CUT_041)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor004,"Anger")
	change_face(Actor004,"Normal")

	--★★フライクーゲル2★★:ダーリンに犠牲を強いる世界なんかじゃ<br>息できない
	Talk(Actor004,"CHRNAME_FREIKUGEL","speech","N","MS_002_0410037")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
setup_small_camera_start(CUT_11)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0008")
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410039")

-- ▼直接出力

CloseTalkWindow()
on_active(Ef_Emblem02)
play_particle(Ef_Emblem02)
wait_time(1.5)
on_active(Ef_Killers2)
play_particle(Ef_Killers2)
-- ▲直接出力

	--★★レーヴァテイン★★:それが<br>あなたのエゴなんかじゃないことも
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410041")

-- ▼直接出力
setup_small_camera_start(CUT_041)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★フライクーゲル2★★:
	Talk(Actor004,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410042")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0053")
-- ▲直接出力

	--★★レーヴァテイン★★:私だって、あなたの友達だから
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410043")

	change_face(Actor004,"Surprise")

	--★★フライクーゲル2★★:………！
	Talk(Actor004,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410044")

	change_face(Actor002,"Anger")

	--★★レーヴァテイン★★:あなたは自ら<br>『自由』という選択肢に成ろうとしてる
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410045")


	--★★レーヴァテイン★★:<%player>のために…<br>「『自由』を選んでもいいよ」と
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410046")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Sad")

	--★★フライクーゲル2★★:
	Talk(Actor004,"CHRNAME_FREIKUGEL","speech","L","MS_002_0410047")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★レーヴァテイン★★:だったら<br>私は最後まで──
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410048")

-- ▼直接出力
bgm_play("BGM_Battle_LTeinn")
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor002,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410050")

-- ▼直接出力
setup_small_camera_start(CUT_11)
CloseTalkWindow()
--セリフが入る場合あり
on_active(Ef_KillChan2)
play_particle(Ef_KillChan2)

wait_time(0.7)

fadeout(255,255,255,1.0,0.4)
wait_time(TIME_ELAPSED + FADE_TIME)
Appear(Actor005)
Hide(Actor002)
fadein(FADE_TIME)

stop_particle(Ef_Killers2)
	
wait_time(2.0)

-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0010")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★レーヴァテイン2★★:「一緒に傷つく」って<br>約束してもらったから
	Talk(Actor005,"CHRNAME_LAEVATEIN","speech","L","MS_002_0410052")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Killers_Lop", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Change_Killers", false, true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem23",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Emblem22",false,true)
preload_sound("BGM_Battle_LTeinn")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060012)
	InitializeCharacter_3D_Preload("101070","001","101070001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101002","002","101002002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101070","001","101070001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101070","002","101070002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101002","001","101002001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
