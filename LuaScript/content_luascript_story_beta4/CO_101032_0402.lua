-- このluaスクリプトは、CO_101032_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
lookat_weight(Actor003,0.45,0.1,0.8,0.2)
lookobj = create_object("kara")
set_pos_object(lookobj,0.283,1.085,-10.7)
keep_ik_lookat_object(Actor003,nil,"kara")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_003)
	Camera003 = SetTemplate("Actor003",150,CharaPos110122_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110122_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_008)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110122_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_007)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(7,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:お待ちどう～♪炭鉱産の伝説のキノコと<br>村の畑で採れた特産野菜を使った…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガレス★★:『炭鉱のキノコスープ』！<br>さあ、召しあがれ！！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020003")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:うまい！<br>うまいぞ、ガレス！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_04020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:味わいだけじゃなく香りも素晴らしい<br>これならどんな料理にも合いそうだ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_04020006")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor007,"J_Head",0.9)
keep_delay_ik_lookat(Actor003,Actor006,"J_Head",0.9)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男1", "驚き")
-- ▲直接出力

	--★★市民（男）★★:こ、これは…
	Talk(Actor006,"NPCNAME_0188","speech","N","CO_101032_04020007")

-- ▼直接出力
PlayPartVoice("市民中年_男1", "驚き")
-- ▲直接出力

	--★★市民（中年男）★★:この、スープは…！
	Talk(Actor007,"NPCNAME_0189","speech","N","CO_101032_04020008")

-- ▼直接出力
PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:ええっ、みんな泣いてる！？<br>どうしたんだ、まずかったのか！？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_04020010")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)

	--★★市民（男）★★:違う、違うんだよ<br>当時味わったあのスープのままなんだ
	Talk(Actor006,"NPCNAME_0188","speech","N","CO_101032_04020011")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定2")
-- ▲直接出力

	--★★市民（中年男）★★:あのスープがまた味わえたことが<br>嬉しくてさ…
	Talk(Actor007,"NPCNAME_0189","speech","N","CO_101032_04020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女2", "肯定2")
-- ▲直接出力

	--★★市民（中年女）②★★:兄は料理の達人ってわけじゃなかったけど<br>優しい人でね
	Talk(Actor005,"NPCNAME_0255","speech","N","CO_101032_04020014")


	--★★市民（中年女）②★★:仕事に疲れた鉱夫のみんなを労いたい
	Talk(Actor005,"NPCNAME_0255","speech","N","CO_101032_04020015")

-- ▼直接出力
PlayPartVoice("市民中年_女2", "肯定")
-- ▲直接出力

	--★★市民（中年女）②★★:そんな気持ちを込めて<br>いつもこのスープを作っていたよ
	Talk(Actor005,"NPCNAME_0255","speech","N","CO_101032_04020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --女の人の首を調整
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女2", "笑い")
-- ▲直接出力

	--★★市民（中年女）②★★:兄のスープを蘇らせるなんて<br>お嬢ちゃんはたいした料理人だよ
	Talk(Actor005,"NPCNAME_0255","speech","N","CO_101032_04020017")

-- ▼直接出力
keep_delay_ik_lookat(Actor006,Actor002,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor007,Actor002,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:わたしはレシピを再現しただけだ<br>すごいのはおばあちゃんのお兄さんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020019")


	--★★ガレス★★:作っている途中で味見をしたとき<br>お兄さんの想いを感じた
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:優しさやあたたかさがこのスープを通して心と体に広がった
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020021")

	change_face(Actor002,"Normal")

	--★★ガレス★★:このスープは確かに美味しい<br>でも、それだけじゃないんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力

	--★★ガレス★★:スープを飲む人のことを<br>あの村に住む人のことを想って作られてる
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020023")


	--★★ガレス★★:おばあちゃんたちが飲んだとき<br>その美味しさは数倍、数十倍になるはずだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020024")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力

	--★★ガレス★★:ねえ、おばあちゃん<br>マイントリュフの採取はわたしたちが手伝う
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:だから、このスープの味を<br>これからも伝えていってほしいんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020026")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女2", "肯定2")
-- ▲直接出力

	--★★市民（中年女）②★★:そうだね兄の想いを伝えていかなきゃね
	Talk(Actor005,"NPCNAME_0255","speech","N","CO_101032_04020028")


	--★★市民（中年女）②★★:ありがとう、お嬢ちゃん
	Talk(Actor005,"NPCNAME_0255","speech","N","CO_101032_04020029")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:うん、きっとお兄さんも喜ぶに違いないぞ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020031")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
template2()
Appear(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
--首の向きを調整
set_enable_auto_lookat(Actor001, true)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.55,0.1,0.8,0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor004,Actor001,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,0.2)
setup_small_camera_start()
set_pos(Actor008,{5.24,0,-3.2})
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力

	--★★ガレス★★:…♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_04020035","CO_101032_04020036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガレス、おつかれさま村のみんなも喜んでたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_04020038")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ありがとう<br>ノワールとリオネスのおかげだよ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020039")

-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:あたしはなにもしてないぞぜんぶガレスの頑張りだ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_04020040")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:嬉しそうな顔してるななにか掴めたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_04020042")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ノワールにはわかっちゃうか～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020043")

-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:あ、あたしにもわかったぞ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_04020044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:うんうんもちろんリオネスにもね
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020045")

	goto Block1end

::Block1end::
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:よく聞く言葉だけどさやっぱり想いに勝る調味料はないんだね
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020047")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:わたし、ちょっと料理が上手くなって技術に溺れてたのかもしれない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020048")

	change_face(Actor002,"Normal")

	--★★ガレス★★:みんなが驚くような新しい料理を作りたいってことばかり考えて
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:ひとりよがりの料理を作ってたんだと思う兄さんはそれを教えてくれたんだ、きっと
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_04020052","CO_101032_04020053")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:うん、きっとそうだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_04020055")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リオネス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:うーん、ガウェインのヤツがそこまで考えてるかな～？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_04020056")

-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ははっ！わかんないけど、そういうことにしとこう♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020057")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうかなあ？そこまで深く考えてなかった気もするけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_04020059")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★リオネス★★:あたしもそう思うぞ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_04020060")

	change_face(Actor002,"Anger")

	--★★ガレス★★:もう、ふたりとも！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガレス★★:ああ見えて結構いい奴なんだぞ兄さんは？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020062")

	goto Block2end

::Block2end::
-- ▼直接出力
 --料理人の首を調整
CloseTalkWindow()
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
setup_small_camera_start(Camera004)
keep_delay_ik_lookat(Actor004,Actor008,"J_Head",1)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("グリフレット", "肯定2")
-- ▲直接出力

	--★★料理人★★:ガウェイン、そろそろ入ったらどうだハラ減ってんだろ？
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_04020064")

-- ▼直接出力
 --ガウェイン入場
CloseTalkWindow()
IN_WALK(Actor008,CharaPos110122_02_007)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
lookat_delay_weight_reset(Actor001,1.0)
lookat_delay_weight_reset(Actor003,1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor008,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor008,"J_Head",1.0)
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor001,330,0.4)
turn_chara(Actor003,290,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor008,"J_Head",1.0)
keep_delay_ik_lookat(Actor003,Actor008,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★ガウェイン★★:あ、ああ…
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","CO_101032_04020065")

	PlayAction(Actor008,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力

	--★★ガウェイン★★:ハ、ハラ減っちまってよなんでもいーから食わしてくんね？
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","CO_101032_04020067")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ガウェイン★★:そのスープでもいいぜ
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","CO_101032_04020068")

-- ▼直接出力
PlayPartVoice("グリフレット", "肯定")
-- ▲直接出力

	--★★料理人★★:俺が作ったサンドイッチが残ってるからよこれでも食っとけ
	Talk(Actor004,"NPCNAME_0260","speech","L","CO_101032_04020069")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★ガウェイン★★:え？あ、ああ、サンキュ
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","CO_101032_04020070")

-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:兄さん
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020071")

	change_face(Actor008,"Normal")

	--★★ガウェイン★★:…ん？
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","CO_101032_04020072")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:今、兄さんのために<br>フルコースを用意してるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020073")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定3")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★ガウェイン★★:へえ、そうなのか
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","CO_101032_04020075")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:それでな、兄さんなにか食べたい料理があるなら教えてほしい
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020076")

	PlayAction(Actor008,"to  Std_Worry")

	--★★ガウェイン★★:食べたい料理？そうだなあ…
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","CO_101032_04020077")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ガウェイン★★:昔食ったナイトカジキのグリルが美味かったなあれをまた食べてみたい
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","CO_101032_04020078")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ナイトカジキのグリルだな、わかった！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020079")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力

	--★★ガレス★★:今度は絶対に「美味い！」って言わせてやるからな！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_04020081")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:楽しみに待ってるぜ
	Talk(Actor008,"CHRNAME_GAWAIN","speech","L","CO_101032_04020082")

-- ▼直接出力
local trustParam = set_communication_rankup("ガレス_コミュランク", "ガレス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
