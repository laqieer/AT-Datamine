-- このluaスクリプトは、MS_002_032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100011_05","100011_05_h")
Include("content_adv_advsmall_100011_05","Template100011_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100011_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_523_01_StdController","to Std_Loop",CameraAssetBundleName100011_05,CameraPos100011_05_002)
	Camera002 = SetPlayerTemplate("Actor002",180,CharaPos100011_05_012,CameraAssetBundleName100011_05,CameraPos100011_05_012)
	InitializeTemplateRandomCamera100011_05()
	InitializeTemplate100011_05()
-- ▼直接出力
CUT11 =  cat_template_camera("P11_Cam")
CUT12 =  cat_template_camera("P12_Cam", Actor002)
CUT13 =  cat_template_camera("P13_Cam")
CUT14 =  cat_template_camera("P14_Cam")
CUT10 =  cat_template_camera("P10_Cam")
-- ▲直接出力
-- ▼直接出力
load_image("201010250", "content_still_20101025_image", "201010250_StillImage")
load_image("201010720", "content_still_20101072_image", "201010720_StillImage")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
--RndCamera001=CUT10
-- ▲直接出力
-- ▼直接出力
show_image("201010250", 0.0, 0.0, 0, true, false)
set_scale_image(0.9,0.9)
-- ▲直接出力
-- ▼直接出力
set_object("content_mob_100011_02_mobs_0001", "100011_02_mobs_0001", true)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_LTeinn")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100011)
	Actor001 = InitializeCharacter_3D("101070","001","101070001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0049")
-- ▲直接出力

	--★★フライクーゲル★★:きみと、隣の席だったんだよ
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320003")


	--★★フライクーゲル★★:入学直後のきみを守るために<br>継守会であるわたしがそばにいる役割だった
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320004")


	--★★フライクーゲル★★:そうしたら、えーと…あるとききみがね…言ってくれたんだ
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320005")


	--★★フライクーゲル★★:「『はじめての友達』だ」って
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320006")


	--★★フライクーゲル★★:それからはね、こうやって<br>同じ時間に登校…して、下校して…
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320007")

	open_select_window_tag(Actor002,"Normal","MS_002_0320009")
	if is_select(1) then
		goto Block1_1
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0060")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:強いひとじゃなかったけど<br>だからこそ、ひとに誠実だったよ
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320013")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:ひとを見て、ひとと生きてた<br>困ってるひとは見逃せないひとだった
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320014")


	--★★フライクーゲル★★:わたしのおしゃべりに静かに耳を傾けてくれてた
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320015")


	--★★フライクーゲル★★:それで
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320016")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0013")
-- ▲直接出力

	--★★フライクーゲル★★:ケンカすることなんて、ぜんぜんなかった
	Talk(Actor001,"CHRNAME_FREIKUGEL","simple","N","MS_002_0320017")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
hide_image(0)
wait_time(0.2)
show_image("201010720", 0.0, 0.0, 0, true, false)
--フェードイン
wait_time(CHARA_IN_OUT + 0.5)
fadein(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(2)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
hide_image(0)
setup_small_camera_start(CUT10)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT11)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101070001_sp_0001_1")
-- ▲直接出力

	--★★フライクーゲル★★:ダーリンは「自由になりたい」<br>と思ったこと…ない？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320019")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0010")
-- ▲直接出力
	change_face(Actor001,"Shy")

	--★★フライクーゲル★★:えへへ<br>ちょっとポエミー
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320020")

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★フライクーゲル★★:好きなひとと、好きなところにいって好きなことをして毎日をエンジョイするの
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320021")

	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:誰かの言うことを聞いて<br>縛られたりしないようなさ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320022")

-- ▼直接出力
setup_small_camera_start(CUT12)
lookat_delay_weight_default(Actor002, 1)
keep_ik_lookat(Actor002, Actor001, "J_Head")
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,105,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MS_002_0320024","MS_002_0320025")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT13)
lookat_delay_weight_default(Actor001, 1)
keep_ik_lookat(Actor001, Actor002, "J_Head")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-90,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0028")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★フライクーゲル★★:そう思う？きみも
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★フライクーゲル★★:誰でも一度は思うよね<br>でも、やっぱり自由って怖かったりして
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320029")

	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:一度は諦めたりして
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320030")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT13)
lookat_delay_weight_default(Actor001, 1)
keep_ik_lookat(Actor002, Actor001, "J_Head")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-90,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:こう…縛られたままでいい、と思う？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320033")

	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:居心地がいい場所だとね<br>…そうかも
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320034")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0009")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★フライクーゲル★★:きみにとっては<br>この学園がそういう場所になりつつあるのかな
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320035")

	goto Block2end

::Block2end::
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★フライクーゲル★★:わたし、ずぅーっと考えてたことがあるんだ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320037")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0049")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:どっちが幸せなんだろうって<br>どっちも不幸せなのかなって
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320038")

	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:世界を救うために親しい人を傷つけるのと親しい人を救うために世界を傷つけるのと
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320039")

	PlayAction(Actor001,"to Finger")
	change_face(Actor001,"Normal")

	--★★フライクーゲル★★:でも、きみの人生はきみだけのものだから
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320040")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:きみに、みんなに…<br>ケーベツされるかもしれないけど
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320041")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
setup_small_camera_start(CUT12)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:わたしは<dot>今度こそ</dot><br>きみを自由にしたいんだよ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320043")

-- ▼直接出力
voice_play("VO_101070001_sp_0001_1")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★フライクーゲル★★:ダーリン
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320046")

-- ▼直接出力
setup_small_camera_start(CUT14)
-- ▲直接出力

	--★★フライクーゲル★★:学園を抜け出して──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320048")

	PlayAction(Actor001,"to TakeHand")
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0013")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★フライクーゲル★★:──わたしと一緒に、逃げない？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320049")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_MidFade")
shake_camera(CUT14, 0.42, 3)
se_play("SE_ADV_MA_01A111_14_Earthquake")
se_play("SE_LoopSE_Stop")
wait_time(0.2)
PlayActionDirect(Actor002,"to  Std_Surp")
wait_time(0.1)
PlayActionDirect(Actor001,"to  Std_Surp")
wait_time(1)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,195,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
----
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-180,0.25)
wait_time(0.25)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1)
bgm_play("BGM_Battle_LTeinn")
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0057")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:………そうもいかないね。すぐには
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0320053")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010250", "content_still_20101025_image", "201010250_StillImage")
load_image_preload("201010720", "content_still_20101072_image", "201010720_StillImage")
set_object_preload("content_mob_100011_02_mobs_0001", "100011_02_mobs_0001", true)
preload_sound("BGM_Battle_LTeinn")
	InitializeLoad_Preload()
	load_area_scene_preload(100011)
	InitializeCharacter_3D_Preload("101070","001","101070001","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName100011_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
