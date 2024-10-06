-- このluaスクリプトは、EA_003_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_002)
	Camera003 = SetTemplate("Actor003",190,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera004 = SetTemplate("Actor004",175,CharaPos110011_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_006)
	Camera005 = SetTemplate("Actor005",147,CharaPos110011_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_007)
	Camera006 = SetTemplate("Actor006",329,CharaPos110011_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_008)
	Camera007 = SetTemplate("Actor007",17,CharaPos110011_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_007)
	Camera008 = SetTemplate("Actor008",180,CharaPos110011_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_008)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
DontChangeRandomCamera(true)
change_face(Actor001,"Sad")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
set_pos(Actor003,{2.325,0,3.94})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
set_pos(Actor004,{1.9,0,4.5})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{1.69,0,-4.34})
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{2.51,0,-4.47})
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{-0.763,0,-1.371})
set_enable_auto_lookat(Actor007,false)
lookat_weight(Actor007,{1.0,0.03,0.8,0.2})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{-0.69,0,-0.661})
set_enable_auto_lookat(Actor008,false)
lookat_weight(Actor007,{1.0,0.03,0.8,0.2})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor007,Actor008,"J_Head")
keep_ik_lookat(Actor008,Actor007,"J_Head")
-- ▲直接出力
-- ▼直接出力
mob01 = get_object("m030")
mob02 = get_object("m031")
set_pos(mob01,{0,-20,0})
set_pos(mob02,{0,-20,0})
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({0.57, 1.45, -3.24,   4.87, 15.334, -0.00101,   23})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({-0.54, 2.92, 4.29,   22.4, 157, 0,   32})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:視線を感じる…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310002")

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:マスター？どうかされましたか
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0310003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ティルフィングは気にならないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310004")

-- ▼直接出力
PlayPartVoice("ティルフィング", "悩む")
-- ▲直接出力

	--★★ティルフィング★★:えーっと…そうですね…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0310005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002,0.55,0.1,0.85,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,0.51,1.47,-3.46,8)
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:マスターをじっと見ていらっしゃいますお話をしたいようですね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0310007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:いや、俺を見ているっていうか…このあいだの感じだと、むしろ――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310008")

-- ▼直接出力
PlayPartVoiceDirect("ティルフィング", "swim_0006")
-- ▲直接出力

	--★★ティルフィング★★:では、また後ほど
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0310009")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor002)
se_play("SE_ADV_MA_01B112_12_Foot")
wait_time(2.0)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:あ…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310011")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
PlayActionDirect(Actor003,"to Std_Loop")
set_pos(Actor003,{CharaPos110011_04_005[1],CharaPos110011_04_005[2],CharaPos110011_04_005[3]})
turn_chara(Actor003,CharaPos110011_04_005[4],0)
set_pos(Actor004,{CharaPos110011_04_006[1],CharaPos110011_04_006[2],CharaPos110011_04_006[3]})
turn_chara(Actor004,CharaPos110011_04_006[4],0)
keep_ik_lookat(Actor001,Actor003,"J_Head")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…呼び戻すか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:…いいわ。今回はノープランだったし呼び戻されても上手く話せる気がしない
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310013")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:プランねぇ…このあいだのヤツみたいな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:そ、そうよ！その件であなたに話があるのよ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:俺に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310016")

-- ▼直接出力
PlayActionDirect(Actor003,"to Pointing")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:妹さんのアドバイスじゃ上手くいかなかったから責任もって兄のあなたが良い案を出してよ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310018")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★ギネヴィア★★:お友達の作りかた、教えてよ！！！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","N","EA_003_0310019")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	close_cutin()
-- ▼直接出力
wait_time(0.2)
se_play("SE_ADV_EA_003_031_Crowd")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor007,Actor002,"J_Head",0.5)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor008,Actor002,"J_Head",0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ちょ、声がでかいから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310021")

-- ▼直接出力
on_active(Actor005)
on_active(Actor006)
turn_lookat_position(Actor005,CharaPos110011_04_007[1],CharaPos110011_04_007[2],CharaPos110011_04_007[3],0)
turn_lookat_position(Actor006,CharaPos110011_04_008[1],CharaPos110011_04_008[2],CharaPos110011_04_008[3],0)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,CharaPos110011_04_007[1],CharaPos110011_04_007[2],CharaPos110011_04_007[3],2.2)
wait_time(0.5)
PlayActionDirect(Actor006,"to Wlk")
slidemove(Actor006,CharaPos110011_04_008[1],CharaPos110011_04_008[2],CharaPos110011_04_008[3],2.2)
wait_time(1.7)
turn_chara(Actor005,CharaPos110011_04_007[4],0.2)
wait_time(0.2)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.3)
turn_chara(Actor006,CharaPos110011_04_008[4],0.2)
wait_time(0.2)
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ガウェイン★★:なんだなんだ、痴話げんかか～？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0040")
-- ▲直接出力

	--★★ノワール★★:違う！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor006,Actor005,"J_Head",0.4)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ラグネル★★:もう、ガウェイン！茶化すんじゃないの
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310024")

-- ▼直接出力
set_enable_auto_lookat(Actor007,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008,false)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor007,Actor008,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor008,Actor007,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,true)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ガウェイン★★:つーかさ、友達なんて作ろうと思って作るもんじゃなくね？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310025")

-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ラグネル★★:そりゃ、あんたはそうかもしれないけどさ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310026")

-- ▼直接出力
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,-0.43,2.81,4.04,8)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ギネマウア★★:殿下は本当に友達作りが下手でいらっしゃいますので
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0310027")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:ハッキリ言わないでよ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310028")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:それに、誰だっていいわけじゃないのよただ――
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィングと上手くやりたい、だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310030")

	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:…！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310031")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…もしかして、キャメリアードでのこと気にしてるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:…うん
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310033")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")

	--★★ギネヴィア★★:本当は、彼女が悪いわけじゃないってわかってたのに、でも止められなくて…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310034")


	--★★ギネヴィア★★:ティルフィングは優しいからなにもなかったみたいな顔してくれてる
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア", "swim_0021")
-- ▲直接出力

	--★★ギネヴィア★★:でも、わたし…このままじゃ駄目だと思って
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310036")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ギネマウア★★:殿下は確かにお友達作りが下手ですが心根は素直ないい子なのです
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0310037")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ラグネル★★:ですねぇ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310038")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:べ、別にそんなんじゃないわ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310039")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:彼女はわたしが買い上げた傭兵のキラーズなわけだし！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310040")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:だったら仲良くすべきでしょ！？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうしてくれると助かるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310043")

-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "納得")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ガウェイン★★:なるほどなそういう話なら俺らも一肌脱ぐぜ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310044")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力

	--★★ラグネル★★:役に立つかはわかりませんけどねま、相談くらいなら乗れるかも
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310045")

-- ▼直接出力
CloseTalkWindow()
--カメラを初期位置に
CameraEx_02 = set_camera({-0.54, 2.92, 4.29,   22.4, 157, 0,   32})
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,-0.43,2.81,4.04,8)
lookat_delay_weight_reset(Actor003, 0.6)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-125,0.5)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:やった！ありがとう、ふたりとも
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310046")

-- ▼直接出力
SkipDefaultMotion(Actor005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ガウェイン★★:けど、どう友達になるかって言われると意外と難しいよな
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310047")


	--★★ガウェイン★★:友達って気づいたら増えてるもんだしさ一緒に遊んで、帰るときはもうダチみたいな
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310048")

-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:あんたはそんな感じだよね
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310049")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん…でも俺もそんな感じかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310050")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor003, 0.6)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,14,0.5)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア", "swim_0034")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:じゃあ、なにして遊べばいいの？友達になれるくらい楽しい遊びって？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310051")

	open_select_window_tag(Actor001,"Normal","EA_003_0310053","EA_003_0310054")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:えーっと…剣の稽古、とか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310056")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:それと似たようなことやってダメだったじゃない！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310057")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、あれはやりかたにも問題があったっていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310058")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:わたしには「本気のぶつかり合い」戦法は向いてないの。他の手にするわ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310059")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだなぁ…ボードゲームとか？コミュニケーションに良いって聞くぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310061")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:ボードゲームかぁ…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310062")

-- ▼直接出力
PlayPartVoice("ガウェイン", "否定")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ガウェイン★★:あー、俺ダメ！ああいうの、なんか途中でルールがわかんなくなるんだよなぁ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310063")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ガウェイン★★:それに、頭で色々ぐちゃぐちゃ考えるより体動かすほうがよっぽど楽しいって
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310064")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ラグネル★★:ガウェインはそうだろうねぇ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310065")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:他には…そうだな、昔の話になるけど湖で遊ぶのは楽しかったかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310067")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:昔住んでた村の近くに湖があってよくランスロットとかと遊んでてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310068")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:近くに住んでる女の子もたまに遊びに来て仲良くなったりもしたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:へぇ…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310071")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ガウェイン★★:確かに水遊びは楽しいよな～！俺らもよくやったわ
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310072")

-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ラグネル★★:あたしたち、海辺の町で育ったからね
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310073")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:なんか開放感があるっていうかさ普通に遊ぶよりテンション上がるよな
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310074")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:水遊び…なるほど、そのテンション任せで上手いこと持ち込めばいいってワケね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310075")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ラグネル★★:言いかた、言いかた
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310076")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:水遊びだったら、学園の近くのあの湖とかがいいんじゃないか？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310077")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、確かにあそこならちょうどいいかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310078")

	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0019")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ラグネル★★:えー！そんなの駄目だよ！近すぎだって！
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310079")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:近いと駄目なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310080")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★ラグネル★★:子供じゃないんだからそんなんじゃテンション上がらないよ！
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310081")

	PlayAction(Actor006,"to  Std_Talk")

	--★★ラグネル★★:まして相手はティルちゃんなんだよ？もっと非日常感をプラスしないと！
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310082")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera003)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力

	--★★ギネヴィア★★:非日常感…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310083")

-- ▼直接出力
 --カメラを初期位置に
CameraEx_02 = set_camera({-0.54, 2.92, 4.29,   22.4, 157, 0,   32})
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,-0.43,2.81,4.04,8)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:とにかく！一緒に遊びにいけばそこで仲も深められるんじゃないかな！
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","EA_003_0310084")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",0.2)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ガウェイン★★:問題は、遊びに誘う段階まで行けてないってことなんだけどな
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_003_0310085")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア", "swim_0021")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:うっ…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310086")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…そう構えたりせず普通に接すればいいと思うぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310087")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:それができたら苦労しないわよ…だってわたし、友達作りが下手だもん
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310088")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア", "怒り")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ギネマウア★★:拗ねないの昔はそんなことなかったでしょうに
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0310089")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:…わかってるわこのままじゃ駄目だってことくらい
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310090")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうやって考えられるだけえらいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310091")

	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:ノワール…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310092")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィングを誘う機会はきっとあるさ俺も協力するしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310093")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:どこか遠出するタイミングがあればそのときにでも考えよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0310094")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:…ありがと、ノワール
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_003_0310095")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
