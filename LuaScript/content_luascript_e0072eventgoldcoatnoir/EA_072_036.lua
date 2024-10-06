-- このluaスクリプトは、EA_072_036.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_113011_03","113011_03_h")
Include("content_adv_advsmall_113011_03","Template113011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-80,CharaPos113011_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName113011_03,CameraPos113011_03_002)
	Camera002 = SetTemplate("Actor002",90,CharaPos113011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName113011_03,CameraPos113011_03_001)
	InitializeTemplateRandomCamera113011_03()
	InitializeTemplate113011_03()
-- ▼直接出力
load_image("104000360","content_still_10400036_image","104000360_StillImage")
load_image("101030250","content_still_10103025_image","101030250_StillImage")
load_image("101010150","content_still_10101015_image","101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{-1.3,0,-3.1})
set_pos(Actor002,{-2.72,0,-2.7})
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
on_screencolor(IMAGE_COLOR, 0, -50)
on_cameraframe(2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(113011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
off_cameraframe()
off_screencolor()
wait_time(0.3)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera003)
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B112_49_Cloth")
PlayPartVoiceDirect("ギネヴィア","swim_0002")
PlayActionDirect(Actor001,"to EatIdle")
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:もらっちゃったんだあ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_072_0360005")

-- ▼直接出力
ShowImageItem("104000360")
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0028")
-- ▲直接出力

	--★★ギネマウア★★:ノワール様の…傭兵時代の服？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0360006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:そ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_072_0360007")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Std_Loop")
HideImageItem()
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0046")
-- ▲直接出力

	--★★ギネマウア★★:それを繕ってどうするの？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0360009")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………たぶん、ノワールってさ<br>卒業するでしょ？この学園を
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_072_0360010")


	--★★ギネヴィア★★:それでさ、ノワールって<br>ろくな私服持ってなさそうで
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_072_0360011")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0008")
-- ▲直接出力

	--★★ギネマウア★★:お忙しいでしょうからね<br>衣服を新調するヒマすらないほど
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0360012")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to Finger")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0049")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネヴィア★★:だからね、卒業のあとも<br>着られる服が残ってたほうがいいかなって！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_072_0360013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ギネマウア★★:…そうね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0360014")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:それに、この服は彼にとっては<br><ruby=ブライアン>育ての父親</ruby>との思い出でしょ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_072_0360015")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:…いなくなった御方を思い出してしまうから<br>手放したいのかもしれないわよ？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0360017")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0038")
-- ▲直接出力

	--★★ギネヴィア★★:捨てたきゃ捨てていいのよ。それは彼の自由<br>これ繕って、わたしが彼に渡したあとで
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_072_0360018")


	--★★ギネヴィア★★:でも、わたしにとっては──
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_072_0360019")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
wait_time(0.5)
show_image("101030250", 0.0, 0.0, 0.8,true,true)
set_scale_image(0.9,0.9)
wait_time(0.7)
fadein(0.4)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:わたしが彼と<br>はじめて出会ったときの服だから
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0360021")


	--★★テロップ★★:「ノワール様へ」
	Talk(Actor003,"","narration","N","EA_072_0360022")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力

	--★★ギネマウア★★:…繕うの、手伝う？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","simple","N","EA_072_0360023")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0051")
-- ▲直接出力

	--★★ギネヴィア★★:ありがと<br>でも手出しムヨーよ
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0360024")


	--★★テロップ★★:「修繕トラブルのお詫び！」
	Talk(Actor003,"","narration","N","EA_072_0360025")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0055")
-- ▲直接出力

	--★★ギネヴィア★★:あ、でも一回練習させて<br>お姉ちゃんの制服で
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","EA_072_0360026")


	--★★テロップ★★:「あなたの服、勝手に繕いました<br>姉の手を借りずに、がんばりました」
	Talk(Actor003,"","narration","N","EA_072_0360027")


	--★★テロップ★★:「でも、はじめてのことだったから──」
	Talk(Actor003,"","narration","N","EA_072_0360028")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_MidFade")
wait_time(CHARA_IN_IN)
fadeout(255,255,255,1.0, CHARA_IN_IN)--ホワイトアウト
wait_time(1)
show_image("101010150", 0.0, 0.0, 0.8,true,true)
set_scale_image(20,20)
wait_time(1)
fadein(1)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0034")
-- ▲直接出力
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:不格好に、なっちゃった
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_072_0360032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000360","content_still_10400036_image","104000360_StillImage")
load_image_preload("101030250","content_still_10103025_image","101030250_StillImage")
load_image_preload("101010150","content_still_10101015_image","101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(113011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName113011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
