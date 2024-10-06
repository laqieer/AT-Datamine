-- このluaスクリプトは、EA_003_042.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
Include("content_adv_advsmall_112021_04","112021_04_h")
Include("content_adv_advsmall_112021_04","Template112021_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	Camera008 = SetTemplate("Actor009",nil,CharaPos112021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_008)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
lookobj = create_object("kara")
set_pos_object(lookobj,-3,1.5,-1.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Hide(Actor009)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_002)
	Camera005 = SetTemplate("Actor005",155,CharaPos112021_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_001)
	Camera006 = SetTemplate("Actor006",295,CharaPos112021_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos112021_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_004)
	Camera008 = SetTemplate("Actor009",nil,CharaPos112021_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName112021_04,CameraPos112021_04_008)
	InitializeTemplateRandomCamera112021_04()
	InitializeTemplate112021_04()
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101011","005","101011005","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_2DOnly("101011","005","101011005")
	Actor009 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_2DOnly("101011","005","101011005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:わたしの水着が仕上がるのも今日だし<br>受け取るついでに発注してくるわね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:ところでさ、なんで<br>突然水着をデザインしようと思ったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:だって、またルーシャスに命令されて<br>ロジーの里に行くんでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:あなたの故郷が見たいって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、そうだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定")
-- ▲直接出力

	--★★ギネヴィア★★:ロジーの里には湖があるって<br>ディナタンが言ってたわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420007")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:確かにあるけど…もしかして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420008")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そう！非日常での水遊びチャンスよ！<br>この機を逃す手はないの！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420009")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:流行に疎いティルフィングに<br>最先端のオシャレ水着をプレゼントして…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:それで、一緒に水遊びをして絆を深めて<br>お友達になるのよ！！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420011")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:………なるほど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420012")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア","挨拶")
-- ▲直接出力

	--★★ギネマウア★★:ノワール様<br>これでも殿下は精一杯考えたのです
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:あぁ、いいアイデアだとは思うよ<br>でも、なんで俺を呼んだんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420014")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ギネヴィア","悩む")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:それは、ほら…不安じゃない<br>ティルフィングの好みとかもわかんないし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420015")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィングに直接聞けば…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420016")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア","怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:それが出来ないから頼んでるんでしょうが！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420017")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア","落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:ノワール様、殿下は大変意気地がないのです
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420018")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はぁ…そこまでしてティルフィングと<br>仲良くなりたいんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…そうだけど。それがなに？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420020")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その気持ちを、まっすぐ話せばいいのに<br>友達になりたいんだったらさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:今更、無理よ。そんなの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:だって仕方ないじゃない<br>「お友達になって」なんて、言ったことないもの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayPartVoice("ギネヴィア","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:物心ついた頃にはお城に出入りする<br>女の子や男の子と遊んでいたの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420024")


	--★★ギネヴィア★★:わざわざわたしから言わなくても<br>向こうから来てくれたわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420025")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:だってわたし、王女だもの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420026")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネマウア","悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:その割には、お友達ともっと仲良くなりたいと<br>ベッドでうんうん悩んだりしていましたが
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420027")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア","肯定2")
-- ▲直接出力

	--★★ギネマウア★★:あの子と親友になりたいと<br>泣いていたこともありましたっけ
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:こ、子供ってそういうものじゃない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420029")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ギネヴィアは友達に恵まれていたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420030")

-- ▼直接出力
PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:え？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:だって、もっと仲良くなりたいって思うくらいいい友達だったんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:………うん、そうねみんな、大好きだったわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420033")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…今のわたしはもう、お姫様じゃないから待ってるだけじゃお友達は増えない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420034")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:だから、がんばらないといけないのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420035")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィア…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:…じゃ、水着を引き取りに行ってくるから<br>ここで待ってて！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0420037")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
PlayActionDirect(Actor002,"to Run")
--wait_time(0.1)
turn_chara(Actor002,270,0.25)
wait_time(0.25)
slidemove(Actor002,-3.75,0,0.36,1.5)
wait_time(2.5)
PlayActionDirect(Actor002,"to Std_Loop")
Hide(Actor002)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネマウア","落胆")
-- ▲直接出力

	--★★ギネマウア★★:もう、居心地悪くなるとすぐに逃げるんだから
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420039")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…すみません
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420040")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネマウア★★:どうして謝るのですか？
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:なんだか…<br>ギネヴィアが辛そうな表情をしていたから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420042")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:辛いことを、思い出させてしまったかなって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420043")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア","照れ")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネマウア★★:いいんです<br>失ったものを想えば寂しいのは当たり前ですから
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420044")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:でも、だからといって<br>想うことを止めるのはもっと寂しい
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420045")


	--★★ギネマウア★★:あの国の幸せだった日々を想えるのは<br>もう私とあの子だけなのですから
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420046")


	--★★ノワール★★:ギネマウアさん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネマウア","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:…でもいつまでも失ったものに縋りついて<br>立ち止まっているわけにはいかない
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420048")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア","笑い")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネマウア★★:あの子もそれをわかっているから<br>こうやって――…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420049")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_EA_003_042_Break")
wait_time(0.2)
setup_small_camera_start()
wait_time(0.3)
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,240,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
set_enable_auto_lookat(Actor003, false)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("市民中年_男2","0031")
-- ▲直接出力

	--★★屋台の店主★★:な、なんですかあなたたちは！
	Talk(Actor004,"NPCNAME_0372","speech","N","EA_003_0420051")

-- ▼直接出力
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("山賊","笑い")
-- ▲直接出力

	--★★強盗1★★:おい、さっさと金目のものを出せ！
	Talk(Actor005,"NPCNAME_0373","speech","N","EA_003_0420053")

-- ▼直接出力
PlayPartVoice("山賊","肯定2")
-- ▲直接出力

	--★★強盗2★★:とっととこのかばんに詰めろ！
	Talk(Actor006,"NPCNAME_0374","speech","N","EA_003_0420054")

	change_face(Actor003,"Surprise")

	--★★ギネマウア★★:強盗…！？
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0420056")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0015")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:行きましょう、ギネマウアさん！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420057")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:決まってるでしょうこのまま放っておくわけにはいかないですよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420058")

-- ▼直接出力
 --場面転換
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
template2()
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor003)
set_pos(Actor001,{-6.37,0,0.08})
set_pos(Actor003,{-6.135,0,0.658})
set_pos(Actor007,{-10.85,0,-7.24})
Actor010 = set_chara("content_chr_101011_101011005_model", "101011005_Model", "content_animationpack_101_101guin","MotionPack_101Guin", "content_animationpack__common", "FacialPack", CharaPos112021_04_004,"Com_Std01_Loop_f" , "Normal")
set_rot(Actor010,{0,325,0})
Hide(Actor010)
Hide(Actor001)
Hide(Actor003)
Appear(Actor004)
Appear(Actor005)
Appear(Actor006)
Appear(Actor009)
set_pos(Actor009,{-11.3,0,-0.66})
set_rot(Actor009,{0,175,0})
PlayActionDirect(Actor004,"to  Std_Sad02")
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
PlayActionDirect(Actor005,"to  Std_Angry")
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
IN_RUN_2P(Actor001,CharaPos112021_04_006,Actor003,CharaPos112021_04_007)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール","怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:おい、止めろお前ら！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor009,"to Wlk")
turn_lookat(Actor009,Actor001,0.4)
wait_time(0.1)
PlayActionDirect(Actor005,"to Wlk")
turn_lookat(Actor005,Actor001,0.4)
wait_time(0.2)
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor001,0.4)
wait_time(0.1)
PlayActionDirect(Actor009,"to Std_Loop")
wait_time(0.1)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("山賊","激怒")
-- ▲直接出力

	--★★強盗1★★:なんだぁ！？お前ら、学生か？<br>どうする？
	Talk(Actor005,"NPCNAME_0373","speech","N","EA_003_0420061")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊","怒り")
-- ▲直接出力

	--★★強盗2★★:構うことはねぇ、たったふたりだ！<br>とっとと片付けちまえ！
	Talk(Actor006,"NPCNAME_0374","speech","N","EA_003_0420062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0016")
-- ▲直接出力
	change_face(Actor008,"Laugh")

	--★★水着ギネヴィア2★★:残念、ふたりじゃないわよ！！
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0420063")

-- ▼直接出力
on_active(Actor007)
PlayActionDirect(Actor007,"to Run")
turn_lookat_position(Actor007,CharaPos112021_04_004[1],CharaPos112021_04_004[2],CharaPos112021_04_004[3],0)
slidemove(Actor007,CharaPos112021_04_004[1],CharaPos112021_04_004[2],CharaPos112021_04_004[3],1.0)
setup_small_camera_start()
wait_time(0.75)
CameraEx_01 = set_camera({-10.256, 1.479, -1.793,   7.4, 194.112, 0,   28})
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,-10.257,1.521,-1.799,5)
wait_time(0.25)
PlayActionDirect(Actor007,"to Std_Loop")
turn_chara(Actor007,CharaPos112021_04_004[4],0.1)
wait_time(0.1)
keep_delay_ik_lookat(Actor001,Actor007,"J_Head",1.0)
turn_lookat(Actor001,Actor007,0)
turn_lookat(Actor003,Actor007,0)
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Surprise")
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ギネヴィア！？なにしてる、下がってろ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420065")

-- ▼直接出力
lookat_delay_weight(Actor007,0.45,0.1,0.8,0.2,1.0)
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","否定")
-- ▲直接出力

	--★★水着ギネヴィア★★:嫌よ！<br>ふたりだけに戦わせるわけにはいかないわ
	Talk(Actor007,"CHRNAME_GUINEVERE","speech","L","EA_003_0420066")

-- ▼直接出力
CameraEx_02 = set_camera({-11.84, 2.06, -3.28,   17.80722, 66.45428, 0.00465,   28})
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,-11.85,2.06,-3.25,5.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","苦しみ")
-- ▲直接出力

	--★★ノワール★★:そうは言っても、なんか見てるこっちが<br>落ち着かないんだって――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420067")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:…ああ、もう！とっとと終わらせるぞ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0420068")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
Hide(Actor007)
Hide(Actor006)
Appear(Actor010)
motion_inloop(Actor010,"Com_Std_Bebattle01_Start_f", "Com_Std_Bebattle01_Loop_f", 0.3, 1.0)
wait_time(0.2)
CameraEx_03 = set_camera({-11.007, 1.73, -0.75,   7.39999, 153.8096, 0,   28})
setup_small_camera_start(CameraEx_03)
slidemove(CameraEx_03,-11.8,1.73,-1.14,5.0)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,CharaPos112021_04_006[4],0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(5.8)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Antagonism")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101011","005","101011005","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("101011","005","101011005")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_2DOnly_Preload("101011","005","101011005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest(CameraAssetBundleName112021_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
