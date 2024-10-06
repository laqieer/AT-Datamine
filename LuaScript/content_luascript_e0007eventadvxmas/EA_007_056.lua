-- このluaスクリプトは、EA_007_056.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",70,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera002 = SetTemplate("Actor002",293,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera003 = SetTemplate("Actor003",165,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-1.46,0,-2.42})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{2.37,0,-6.086})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{3.19,0,-5.89})
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-0.97,0,-1.55})
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
lookobj = create_object("kara")
set_pos(lookobj,{0.56,2.56,-4.92})
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-0.45, 1.54, -2.93,   4.769, 195.6, 0,   26})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({0.85, 2.45, -8.07,   21.9, 316, 0,   22.5})
-- ▲直接出力
-- ▼直接出力
CameraEx_03 = set_camera({0.215, 1.443, -4.079,   8.4, 242.7, 0,   28})
-- ▲直接出力
-- ▼直接出力
CameraKyle = set_camera({-0.25, 2.36, -7.07,   27.1, 341.5, 0,   25})
-- ▲直接出力
-- ▼直接出力
load_image("104000250", "content_still_10400025_image", "104000250_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("201010060", "content_still_20101006_image", "201010060_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115110)
	Actor001 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","003","101023003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0010")
-- ▲直接出力

	--★★モルドレッド★★:まさにサプライズだったな
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:<ruby=あのガキ>カイル</ruby>の両親にとっては、最悪の
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0048")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:…そうでもないさ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0560008")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("モルドレッド","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★モルドレッド★★:
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560009")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
on_active(Actor003)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,CharaPos110101_01_006[1],CharaPos110101_01_006[2],CharaPos110101_01_006[3],0)
slidemove(Actor003,CharaPos110101_01_006[1],CharaPos110101_01_006[2],CharaPos110101_01_006[3],2.0)
wait_time(2.0)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
turn_chara(Actor003,142,0.25)
wait_time(0.25)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★クラリス★★:モルくん
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560011")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,0,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0002")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:ケガねえか
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560012")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:はいっ。ご覧のとおり～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0013")
-- ▲直接出力

	--★★モルドレッド★★:なら、いい
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0011")
-- ▲直接出力

	--★★クラリス★★:はいっ
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560015")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
wait_time(0.3)
keep_delay_ik_lookat_object(Actor001,nil,"kara",0.3)
wait_time(1.2)
-- ▲直接出力

	--★★モルドレッド★★:雪、やんできたから、行くわ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560016")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,{-0.57,1.54,-2.9},8)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0015")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:あの、モルくん
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560018")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0007")
-- ▲直接出力

	--★★モルドレッド★★:んだよ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560019")

-- ▼直接出力
Hide(Actor002)
setup_small_camera_start(CameraEx_02)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★クラリス★★:どうでしょうか、この服
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560021")

	change_face(Actor001,"Anger")

	--★★モルドレッド★★:ああァ～？
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560024")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0008")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:い、いいえ、なんでもないです～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560025")

-- ▼直接出力
Appear(Actor002)
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★モルドレッド★★:………ハーッ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560026")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0010")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:血迷ったかと思って、驚ぇたよ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560028")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:…──さぷら～いず
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560031")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0014")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★モルドレッド★★:
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","EA_007_0560033")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor001,1.0)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat_position(Actor001,-0.403,0,-2.98,0.1)
wait_time(0.1)
slidemove(Actor001,-0.403,0,-1.92,2.6)
wait_time(3.8)
PlayActionDirect(Actor001,"to Std_Loop")
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
on_active(Actor004)
on_active(Actor005)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat_position(Actor004,CharaPos110101_01_002[1],CharaPos110101_01_002[2],CharaPos110101_01_002[3],0)
slidemove(Actor004,CharaPos110101_01_002[1],CharaPos110101_01_002[2],CharaPos110101_01_002[3],1.6)
wait_time(0.2)
PlayActionDirect(Actor005,"to Wlk")
turn_lookat_position(Actor005,CharaPos110101_01_001[1],CharaPos110101_01_001[2],CharaPos110101_01_001[3],0)
slidemove(Actor005,CharaPos110101_01_001[1],CharaPos110101_01_001[2],CharaPos110101_01_001[3],1.6)
wait_time(1.0)
setup_small_camera_start(Camera004)
wait_time(0.4)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1.0)
lookat_delay_weight(Actor002,0.45,0.1,0.85,0.2,1.0)
turn_chara(Actor004,CharaPos110101_01_002[4],0.2)
wait_time(0.2)
PlayActionDirect(Actor004,"to Std_Loop")
turn_chara(Actor005,270,0.2)
wait_time(0.2)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,340,0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,75,0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
lookat_delay_weight(Actor003,0.48,0.1,0.85,0.2,1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ガウェイン★★:いやはや
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0560037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0011")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ラグネル★★:ワケアリドレスを<br>修繕した甲斐があったね！
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_007_0560040")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560041")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:そういえば<br>気になってたんだけどよ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0560042")

-- ▼直接出力
SkipDefaultMotion(Actor004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")

	--★★ガウェイン★★:カイルの叔父を追い詰める作戦…<br>なんで俺たちに教えてくれなかったんだ？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0560043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★クラリス★★:ああ～それは…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560044")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0007")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ラグネル★★:「どこかから作戦が漏れたらヤバいから」でしょ<br>あと、あたしたちが慌てて騒いだらヤバいから
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_007_0560045")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:…やっぱ精神、高めねーとだな
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0560046")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:そういえば、カイルのプレゼントの件って──
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0560047")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★クラリス★★:ああ、あれはですねえ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560048")

-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0002")
-- ▲直接出力

	--★★カイル★★:クラリスお姉ちゃん！！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560050")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,40,0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
on_active(Actor006)
turn_lookat_position(Actor006,CharaPos110101_01_007[1],CharaPos110101_01_007[2],CharaPos110101_01_007[3],0)
PlayActionDirect(Actor006,"to Run")
slidemove(Actor006,CharaPos110101_01_007[1],CharaPos110101_01_007[2],CharaPos110101_01_007[3],1.5)
wait_time(1.5)
turn_chara(Actor006,245,0.1)
keep_delay_ik_lookat(Actor003,Actor006,"J_Head",1.0)
wait_time(0.1)
PlayActionDirect(Actor006,"to Std_Loop")
keep_delay_ik_lookat(Actor006,Actor003,"J_Head",1.0)
lookat_delay_weight(Actor006,0.5,0.1,0.85,0.2,1.0)
wait_time(0.2)
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★クラリス★★:もう行かれますか
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560053")

-- ▼直接出力
setup_small_camera_start(CameraKyle)
slidemove(CameraKyle,{-0.12,2.36,-7.03},9)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0007")
-- ▲直接出力

	--★★カイル★★:うんっ、ママとパパといっしょに<br>ロンディニウムに帰るよ！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560054")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0009")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:…あの、カイルくん<br>今回のこと、ごめんなさい、いろいろと
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560055")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0028")
-- ▲直接出力

	--★★カイル★★:ええ？
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560056")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力

	--★★クラリス★★:色んなことに巻き込んでしまいました<br>怖い思いもさせてしまって
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560057")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0010")
-- ▲直接出力

	--★★カイル★★:ううん<br>クラリスお姉ちゃん、ありがとう！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560058")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:………カイルくん？
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560059")

-- ▼直接出力
set_pos(CameraKyle,{-0.25, 2.36, -7.07})
setup_small_camera_start(CameraKyle)
slidemove(CameraKyle,{-0.12,2.36,-7.03},9)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0007")
-- ▲直接出力

	--★★カイル★★:ママとパパにね、<dot>あのプレゼント</dot>したら<br>すっごく驚いて…喜んでくれたんだ！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560060")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ガウェイン★★:あのプレゼント？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0560062")

-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat(Actor003, false)
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★カイル★★:クラリスお姉ちゃんがね<br>『押し花』を作ってくれたんだ！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560063")

	change_face(Actor003,"Normal")

	--★★クラリス★★:マルイルさんから買った花束は<br>バラバラになってしまいましたが──
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560065")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★クラリス★★:なんとか綺麗な部分だけでも<br>残せないかと思いまして～トライだけでもと…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560066")

-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
set_enable_auto_lookat(Actor006, true)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★カイル★★:それでね、マルイルさんから額を買って<br>ママとパパにプレゼントしたんだ！！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560067")

	change_face(Actor003,"Normal")

	--★★クラリス★★:あまり…うまくできたかは、わかりませんが～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560068")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","EA_007_0560070","EA_007_0560071")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:カイルの望みどおりになったじゃないか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0560074")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:え？
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560075")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:クラリスに<br>プレゼントを考えて欲しかったんだろ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0560076")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガウェイン★★:そーいやそうだったな！！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0560077")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:無事な花があったのも幸運だったな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0560080")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★クラリス★★:…ただ、運が良かっただけですよ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560081")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0007")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ラグネル★★:暴漢に襲われたとき、クラリスちゃんが<br>率先して動いたからこそ無事だったんだよ
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_007_0560082")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:それはローマ軍残党との戦いのときもそうだ<br>クラリスがみんなを守ったんだよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0560083")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
set_pos(CameraKyle,{-0.25, 2.36, -7.07})
setup_small_camera_start(CameraKyle)
slidemove(CameraKyle,{-0.12,2.36,-7.03},9)
keep_delay_ik_lookat(Actor006,Actor003,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★カイル★★:それに、お姉ちゃんがいてくれなかったら<br>あんな風にママとパパに喜んでもらえなかったよ
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560085")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:………
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560086")

-- ▼直接出力
set_pos(CameraKyle,{-0.25, 2.36, -7.07})
setup_small_camera_start(CameraKyle)
slidemove(CameraKyle,{-0.12,2.36,-7.03},9)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0011")
-- ▲直接出力

	--★★カイル★★:
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560087")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:…どういたしまして
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560089")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★カイル★★:………あと、これは<br>ボクからお姉ちゃんたちにプレゼント！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560090")

-- ▼直接出力
set_enable_auto_lookat_all(false)
ShowImageItem("104000250")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:これは…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560092")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:これも…『天使の贈り物』の、押し花…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0560093")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:お母様用と、お父様用のふたつを<br>カイルくんにお渡ししたはずですが…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560095")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0007")
-- ▲直接出力

	--★★カイル★★:ウチはひとつでいいんだ！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560096")

-- ▼直接出力
set_pos(CameraKyle,{-0.25, 2.36, -7.07})
setup_small_camera_start(CameraKyle)
slidemove(CameraKyle,{-0.12,2.36,-7.03},9)
-- ▲直接出力

	--★★カイル★★:ママもパパも、ボクをお仕事に<br>連れてってくれるんだってさ
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560097")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0010")
-- ▲直接出力

	--★★カイル★★:これで家族全員、ずっといっしょにいられる<br>ボクは大商人の跡継ぎとして将来安泰！
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560098")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ラグネル★★:ちゃっかりしてるね～
	Talk(Actor005,"CHRNAME_RAGNAR","speech","L","EA_007_0560099")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ガウェイン★★:そうだな！<br>将来が楽しみだぜ！
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","EA_007_0560100")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★カイル★★:だからもうひとつの押し花は<br>クラリスお姉ちゃんに持ってて欲しいんだ
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0560101")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:驚いた？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0560102")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx_03)
slidemove(CameraEx_03,{0.09,1.42,-4.14},6)
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★クラリス★★:………
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","EA_007_0560103")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor003,"Smile")
wait_time(1.3)
fadeout(0,0,0,1.0,1.0)
wait_time(1.0)
show_image("201010060",0,0,0,true,false)
fadein(1.0)
wait_time(1.7)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:ずっと<br>ついてないなと思ってました
	Talk(Actor003,"CHRNAME_CLARICE","simple","N","EA_007_0560113")


	--★★クラリス★★:不幸が視えて<br>それを告げたら怖がられて
	Talk(Actor003,"CHRNAME_CLARICE","simple","N","EA_007_0560114")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0025")
-- ▲直接出力

	--★★クラリス★★:
	Talk(Actor003,"CHRNAME_CLARICE","simple","N","EA_007_0560115")


	--★★クラリス★★:でも今、わたしが贈ったプレゼントが<br>幸せを運んできた
	Talk(Actor003,"CHRNAME_CLARICE","simple","N","EA_007_0560116")


	--★★クラリス★★:これには驚き？<br>いえ…もっと、それ以上に──
	Talk(Actor003,"CHRNAME_CLARICE","simple","N","EA_007_0560117")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力

	--★★クラリス★★:ハートに<br>火がツキました
	Talk(Actor003,"CHRNAME_CLARICE","simple","N","EA_007_0560118")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000250", "content_still_10400025_image", "104000250_StillImage")
load_image_preload("201010060", "content_still_20101006_image", "201010060_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115110)
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","003","101023003","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
