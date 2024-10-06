-- このluaスクリプトは、EA_066_044.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation11","DuelCommonFormation11_h")
Include("content_adv_advsmall_duelcommonformation11","TemplateDuelCommonFormation11_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation11_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_001)
	Camera002 = SetTemplate("Actor002",15,CharaPosDuelCommonFormation11_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_003)
	Camera003 = SetTemplate("Actor003",-5,CharaPosDuelCommonFormation11_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_002)
	Camera004 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation11_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_004)
	InitializeTemplateRandomCameraDuelCommonFormation11()
	InitializeTemplateDuelCommonFormation11()
-- ▼直接出力
load_sound("BGM_Battle_Nature_Start")
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Anger")
-- ▲直接出力
-- ▼直接出力
load_image("201010900","content_still_20101090_image","201010900_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101030011)
	Actor001 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ローマ兵★★:グウッ――ルーシャス、様――…
	Talk(Actor004,"NPCNAME_0122","speech","L","EA_066_0440001")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
hide_image(BLACK_WHITE_TIME)
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
se_play("BGM_Battle_Nature_Start")
PlayPartVoiceDirect("ラロゥ","0030")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラロゥ★★:なんだ、こいつら…外で見かけた奴らより様子が変っていうか…
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0440003")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ラロゥ★★:いくら聖杯が願いを叶えるかもっていったってさすがに鬼気迫りすぎじゃない…？
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0440004")

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoiceDirect("ヴォールス_002","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:…もしかすると、遺跡の中に漂う妙な空気にあてられているのかもしれない
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0440005")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★クレア★★:………
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440006")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-105,0.5)
wait_time(0.45)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0015")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラロゥ★★:妙な空気？なにそれ
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0440007")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0019")
-- ▲直接出力

	--★★ヴォールス★★:…感じないのか？この息苦しさ、切迫感を
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0440008")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラロゥ★★:そりゃ、ちょっと空気悪いなぁくらいは思うけど別にそこまでは…
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0440009")

-- ▼直接出力
setup_small_camera_start(Camera003)
PlayPartVoiceDirect("クレア_003","0007")
-- ▲直接出力

	--★★クレア★★:…ええあなたが言うほどの違和感はないわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440010")

-- ▼直接出力
setup_small_camera_start(Camera002)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.02)
lookat_delay_weight(Actor002,0.45,0.1,0.85,0.2,1.02)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0030")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ヴォールス★★:な――
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0440011")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera090)
PlayPartVoiceDirect("ラロゥ","0002")
-- ▲直接出力

	--★★ラロゥ★★:ていうか、アンタちょっと顔色悪いよ大丈夫？
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0440012")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:…問題ない
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0440013")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ヴォールス★★:（どういうことだ…？俺とローマの残党兵だけがこの空気にあてられているのか）
	Talk(Actor002,"CHRNAME_BORS","mind","L","EA_066_0440014")


	--★★ヴォールス★★:（だとすればいったい、なぜ…？）
	Talk(Actor002,"CHRNAME_BORS","mind","L","EA_066_0440015")

-- ▼直接出力
setup_small_camera_start(Camera003)
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★クレア★★:……
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440017")

-- ▼直接出力
wait_time(0.1)--クレア歩く
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-10,0.3)
slidemove(Actor003, 0.15, 0, -2.5, 1.2)
setup_small_camera_start(Camera003)
wait_time(1.5)--クレア歩く続き
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
PlayPartVoiceDirect("ラロゥ","0028")
--ラロゥ、ヴォールスがクレア見る
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,10,0.4)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,25,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.1)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラロゥ★★:え、ちょっと！？
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0440019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★クレア★★:行きましょう。本当に聖杯があるのなら<br>もっと奥にあるはず
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440020")


	--★★クレア★★:第二の聖杯なんてあるとは思えない<br>あっていいとも思わない
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440021")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0020")
-- ▲直接出力

	--★★クレア★★:けれどなにもないで片付けられないくらいには<br>ここには謎が満ちている
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440022")


	--★★クレア★★:もし聖杯と謳われるなにかしらがあるなら<br>わたしはその謎を解き明かしたい
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440023")


	--★★クレア★★:…それに、もし本当に<br>願いを叶える聖杯があるなら――
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440024")

-- ▼直接出力
force_eyesync(Actor003,"Close")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クレア★★:………
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440025")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101024_sp_0002_3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ヴォールス★★:クレア…？
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0440026")

-- ▼直接出力
force_eyesync(Actor003,"Auto")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★クレア★★:…早く行きましょう<br>先を越されたくないわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0440027")

-- ▼直接出力
wait_time(0.1)--クレア歩く
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003, 0, 0, 20, 10)
wait_time(2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0002")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラロゥ★★:…あの人、大丈夫？
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0440029")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★ラロゥ★★:ローマの残党兵みたいにちょっとおかしくなっちゃってるんじゃ…
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0440030")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ヴォールス★★:………いや
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0440031")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
on_cameraframe(2) --カメラ四隅にエフェクトを出す
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("201010900", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
fadein(FADE_TIME)
wait_time(FADE_TIME)

se_play("Set_BGM_Bus_LPF_Volume_1")
wait_time(0.5)

fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(FADE_TIME+0.7)
wait_time(FADE_TIME+0.7)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クレア★★:そうかもね<br>でも、伝説ってそういうものでしょ
	Talk(Actor003,"CHRNAME_CLARE","simple","N","EA_066_0440033")


	--★★クレア★★:それに縋ることで安らぐ気持ちがあることを<br>否定はしないわ
	Talk(Actor003,"CHRNAME_CLARE","simple","N","EA_066_0440034")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)

hide_image(0)

--フェードイン
hide_image()

wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
se_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:…不甲斐ないのは、俺だ
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0440036")

-- ▼直接出力
se_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Battle_Nature_Start")
load_image_preload("201010900","content_still_20101090_image","201010900_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101030011)
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation11)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
