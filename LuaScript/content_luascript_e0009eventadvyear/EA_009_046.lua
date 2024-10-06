-- このluaスクリプトは、EA_009_046.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114042_01","114042_01_h")
Include("content_adv_advsmall_114042_01","Template114042_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",98,CharaPos114042_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114042_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_002)
	Camera003 = SetTemplate("Actor003",35,CharaPos114042_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_004)
	Camera004 = SetTemplate("Actor004",-55,CharaPos114042_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_003)
	InitializeTemplateRandomCamera114042_01()
	InitializeTemplate114042_01()
-- ▼直接出力
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("103050160", "content_still_10305016_image", "103050160_StillImage")
-- ▲直接出力
-- ▼直接出力
tegami = setup_prop_object(10106003)
off_active(tegami)
tegami_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
lookobj = create_object("kara")
set_pos_object(lookobj,0.2,1.048,-16.08)
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-1.047, 1.401, -14.79,   4.596, 127.3, 0,   32})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({0.785, 1.472, -13.856,   6.70387, 182.925, 359.9915,   32})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114042)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","002","101031002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460001")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★エレイン★★:…この人、もしかしたら<br>本当に世界を救いたかったんでしょうか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0460002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0021")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:そうかもしれません<br><dot>もし自分が継承者であったなら</dot>
	Talk(Actor003,"CHRNAME_LOVEIN2","speech","L","EA_009_0460003")

	open_select_window_tag(Actor001,"Normal","EA_009_0460006","EA_009_0460007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…もとは悪い奴じゃなかったのかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:ただ、自分の大切なものを守るために<br>力を求めていただけで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460012")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0008")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:けれどバルバロイと同調したことで<br>すべてが狂ってしまった
	Talk(Actor003,"CHRNAME_LOVEIN2","speech","L","EA_009_0460013")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラヴェイン★★:…人としての自我を最後に取り戻せたのは<br>せめてもの救いでしょうか
	Talk(Actor003,"CHRNAME_LOVEIN2","speech","L","EA_009_0460014")

	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0018")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:…それでも、俺は許せない<br>あいつが言ったこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460018")

	change_face(Actor001,"Anger")

	--★★ノワール★★:なにを勝手な…なにも知らないくせにって<br>怒りでどうにかなりそうだった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460019")

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんなこと言ってもしかたないのに<br>俺だってなにも知らなかったんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460020")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460021")

	change_face(Actor002,"Sad")

	--★★エレイン★★:先輩…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0460023")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…でも、俺がなにか言うより先に<br>ふたりが怒ってくれたから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460024")

	change_face(Actor004,"Sad")

	--★★ディナタン★★:………
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0460025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だから、なんか気持ちがすっとした<br>ありがとう、ふたりとも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0460026")

	goto Block1end

::Block1end::
	change_face(Actor004,"Sad")

	--★★ディナタン★★:………
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0460028")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,1.0)
wait_time(1.4)
se_play("SE_ADV_MA_01A900_30_Pen_Writing_01")
on_parent(tegami,Actor004, "Loc_weapon_constrint_L", tegami_offset)
on_active(tegami)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to ReadLetter")
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(2.0)
setup_small_camera_start(CameraEx_01)
fadein(1.0)
wait_time(1.5)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat_position(Actor002,{0.9,0,-15.8},0.35)
wait_time(0.3)
slidemove(Actor002,{0.9,0,-15.8},0.5)
wait_time(0.5)
turn_chara(Actor002,-86.5,0.3)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
lookat_delay_weight(Actor002,0.5,0.1,0.85,0.2,0.8)
keep_delay_ik_lookat_object(Actor002,nil,"kara",1.0)
set_enable_auto_lookat(Actor002, false)
wait_time(1.6)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エレイン★★:…届けないんですか？その手紙
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0460031")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_1")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight(Actor004,0.45,0.1,0.85,0.2,0.8)
wait_time(0.5)
play_head_motion(Actor004, "No", 0.3, 1.0, false)
wait_time(1.8)
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103050160", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0007")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ディナタン★★:ふたりのことが、心配なんです<br>兄さんと、ギネヴィアさんのことが
	Talk(Actor004,"CHRNAME_DINATAN","simple","N","EA_009_0460036")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","simple","N","EA_009_0460037")

-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0021")
-- ▲直接出力

	--★★ディナタン★★:だって…あんなギネヴィアさん<br>私、見たことなかったんです
	Talk(Actor004,"CHRNAME_DINATAN","simple","N","EA_009_0460038")


	--★★ディナタン★★:ギネヴィアさんはいつだって<br>自分の気持ちに正直な人で
	Talk(Actor004,"CHRNAME_DINATAN","simple","N","EA_009_0460039")


	--★★ディナタン★★:
	Talk(Actor004,"CHRNAME_DINATAN","simple","N","EA_009_0460040")


	--★★エレイン★★:………
	Talk(Actor002,"CHRNAME_ELAINE","simple","N","EA_009_0460041")

-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0025")
-- ▲直接出力

	--★★ディナタン★★:なにがあったか、聞けない<br>なにがあるのか、聞けない
	Talk(Actor004,"CHRNAME_DINATAN","simple","N","EA_009_0460042")


	--★★ディナタン★★:
	Talk(Actor004,"CHRNAME_DINATAN","simple","N","EA_009_0460043")


	--★★ディナタン★★:きっと、もっと…辛い<br>だから――
	Talk(Actor004,"CHRNAME_DINATAN","simple","N","EA_009_0460044")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image() 
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
setup_small_camera_start(RndCamera001)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力

	--★★テロップ★★:
	Talk(Actor005,"","simple","L","EA_009_0460047")


	--★★テロップ★★:ふたりのために<br>私にできることはないかって考えて
	Talk(Actor005,"","simple","L","EA_009_0460048")


	--★★エレイン★★:…うん
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0460049")


	--★★テロップ★★:でも、私だってあの人と同じで<br>全然、なにも知らないから
	Talk(Actor005,"","simple","L","EA_009_0460050")


	--★★テロップ★★:なにも知らないくせに<br>勝手なことを言うわけにはいかなくて
	Talk(Actor005,"","simple","L","EA_009_0460051")


	--★★テロップ★★:ふたりのことが、だいすきだから
	Talk(Actor005,"","simple","L","EA_009_0460052")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx_01)
wait_time(0.4)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.4)
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0002")
-- ▲直接出力

	--★★エレイン★★:…なら、届けましょう
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0460054")

	change_face(Actor004,"Surprise")

	--★★ディナタン★★:
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0460055")

-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0038")
-- ▲直接出力

	--★★エレイン★★:ちゃんと届けないと、伝わらないから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0460056")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,45,0.3)
wait_time(0.2)
off_parent(tegami)
off_active(tegami)
wait_time(0.1)
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ディナタン★★:…！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0460057")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
change_face(Actor002,"Smile")
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
wait_time(1.6)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ディナタン★★:………
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_009_0460061")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103050160", "content_still_10305016_image", "103050160_StillImage")
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(114042)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101031","002","101031002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114042_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
