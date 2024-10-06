-- このluaスクリプトは、EA_003_062.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111091_02","111091_02_h")
Include("content_adv_advsmall_111091_02","Template111091_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111091_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_e0003_01_Controller","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_009)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111091_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_07_e0003_01_Controller","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_009)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111091_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111091_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111091_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111091_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111091_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_002)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111091_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_001)
	Camera009 = SetTemplate("Actor009",4.41,CharaPos111091_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_008)
	Camera010 = SetTemplate("Actor010",8.6,CharaPos111091_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_008)
	Camera011 = SetTemplate("Actor011",21.9,CharaPos111091_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_008)
	InitializeTemplateRandomCamera111091_02()
	InitializeTemplate111091_02()
-- ▼直接出力
load_image("101010150_1", "content_still_10101015_image", "101010150_StillImage")
show_image("101010150_1", 0.0, 0.0, 1.0,false,false)
set_scale_image(20,20)
PlayActionDirect(Actor001,"to Std_Loop")
force_eyesync(Actor001, Close)
reserve_eyesync(Actor001,"Close")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor009,{-0.16, -1.05, -15.99})
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor010,{-1.08, -1.05, -15.46})
Hide(Actor010)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor011,{-2.09, -1.05, -16.07})
Hide(Actor011)
-- ▲直接出力
-- ▼直接出力
Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)

set_pos(Ef_0001,{-0.43, -0.46, -15.33})
set_rot(Ef_0001,{0,-28.2,0})

Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)

set_pos(Ef_0002,{-1.03, -0.75, -14.91})
set_rot(Ef_0002,{0,12.4,0})

Ef_0003 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
set_pos(Ef_0003,{-2.59, -0.73, -16.07})
set_rot(Ef_0003,{0,-138.5,0})
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-1.718, -0.009, -11.897,   28.60999, 84.91102, 0,   28})
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({-0.495, 0.731, -9.557,   25.55, 186.105, 0,   28})
-- ▲直接出力
-- ▼直接出力
CameraEx_03 = set_camera({-3.653, 0.921, -12.786,   5.39999, 79.4, 0,   20})
-- ▲直接出力
-- ▼直接出力
CameraEx_04 = set_camera({-0.491, 0.953, -9.114,   7.1, 180, 0,   24})
-- ▲直接出力
-- ▼直接出力
CameraEx_05 = set_camera({-3.381, 1.435, -10.879,   17.6, 117, 0,   28})
-- ▲直接出力
-- ▼直接出力
CameraEx_06 = set_camera({-2.789, 0.219, -11.489,   17.6, 119.9, 0,   20})
-- ▲直接出力
-- ▼直接出力
CameraEx_07 = set_camera({-0.859, 0.32, -12.972,   0.86, 185.3, -0.00399,   26.35839})
-- ▲直接出力
-- ▼直接出力
CameraEx_08 = set_camera({-0.17, 0.66, -14.45,   2.16556, 338.3788, 0.00374,   26.35839})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Ginevia_Theme")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Invasion2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111091)
	Actor001 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101001","004","101001004","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101011","005","101011005","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor011")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ティルフィング", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ティルフィング★★:う…
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620001")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx_01)
force_eyesync(Actor001,"Close")
-- ▲直接出力
-- ▼直接出力
hide_image(2.2)
slidemove(CameraEx_01,-2.476,0.498,-11.965,20)
-- ▲直接出力
-- ▼直接出力
wait_time(2.9)
-- ▲直接出力
-- ▼直接出力
force_eyesync(Actor001, "Auto")
wait_time(0.8)
-- ▲直接出力

	--★★ティルフィング★★:私、は――
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620003")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
setup_small_camera_start(CameraEx_02)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ティルフィング！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:よかった、無事で――
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620006")

	change_face(Actor001,"Surprise")

	--★★ティルフィング★★:ギネヴィア様…？
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620007")

-- ▼直接出力
CloseTalkWindow()
--フェードアウト
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
set_animationcontroller(Actor002,"Chr_502_01_StdController","to Std_Loop")
set_animationcontroller(Actor001,"Chr_521_01_StdController","to Std_Loop")
Camera001 = setup_small_camera_resetting(Actor002,CharaPos111091_02_001,CameraPos111091_02_001)
Camera002 = setup_small_camera_resetting(Actor001,CharaPos111091_02_002,CameraPos111091_02_002)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
change_face(Actor001,"Normal")
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
keep_ik_lookat(Actor005,Actor001,"J_Head")
keep_ik_lookat(Actor006,Actor001,"J_Head")
set_enable_auto_lookat_all(false)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT + 1.0)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:魔女の罠に捕らえられそうになったキミをギネヴィアが助けてくれたんだ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620008")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ティルフィング★★:そうだったんですか…
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620009")


	--★★ノワール★★:ティルフィング…キミは危険が隠されているかもと知っていたのか
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ティルフィング★★:…はい。魔女たちが早々に退いたことが<br>気になっていましたので
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ティルフィング★★:奴らならなにか奥の手を潜ませているのではと思っていました
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620012")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Pain")

	--★★ノワール★★:なら、どうしてひとりで――
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620013")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ディナタン★★:そうだよ。体調もよくなさそうなのに…！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_003_0620014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力

	--★★マルディサント★★:自分じゃ気づいてないのかもしんねーけどアンタそうとう顔色悪いぞ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","EA_003_0620015")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ディナタン★★:熱中症になりかかってるかもしれないとにかく、もう少し横になって…
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_003_0620016")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力

	--★★ティルフィング★★:…いえ、このくらいなんでもありませんそれよりも、湖を調べなくては
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620017")

	PlayAction(Actor004,"to  Std_Angry")
	change_face(Actor004,"Surprise")

	--★★ディナタン★★:ティルフィングさん！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_003_0620018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ティルフィング★★:私はバルバロイの脅威から<br>この地を守らねばなりません
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:もう二度と、奪わせてはならないんです
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620020")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…キャメリアードみたいに？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620021")

-- ▼直接出力
set_enable_auto_lookat_all(false)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:ギネヴィア
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620023")

	change_face(Actor001,"Sad")

	--★★ティルフィング★★:………
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620024")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx_03)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.3)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:…なにそれ。ふざけないでよ<br>そうやって全部ひとりで抱えて…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620025")


	--★★ギネヴィア★★:自分だけが、悪いみたいな顔して<br>わたしの八つ当たりを受け入れて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620026")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:そんなの…おかしいって怒ってよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620027")

-- ▼直接出力
setup_small_camera_start(CameraEx_04)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ティルフィング★★:…アナタには憤る権利がありますから
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620028")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力

	--★★ギネヴィア★★:ひとりで勝手に納得して<br>それで終わりにしないでよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620029")

-- ▼直接出力
setup_small_camera_start(CameraEx_05)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:そんなんじゃいつまでたってもわたし、あなたと仲良くなれない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620030")

	open_cutin(2,2)
	on_cutin(1,Actor002,"Shy")
-- ▼直接出力
wait_time(0.22)
-- ▲直接出力

	--★★ギネヴィア★★:わたしは――あなたとお友達になりたいのに…！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","N","EA_003_0620031")

	on_cutin(2,Actor001,"Surprise")
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101001_swim1_sp_0001_4")
-- ▲直接出力

	--★★ティルフィング★★:…え？
	Talk(Actor001,"CHRNAME_TYRFING","speech","N","EA_003_0620032")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start(CameraEx_03)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:そのためにノワールに付き合ってもらって水着のプレゼントも買ってきたのよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620033")

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:なのにそんな暗い顔をして！ひとりで思い詰めたりなんかして！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620034")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "激怒")
-- ▲直接出力

	--★★ギネヴィア★★:ほんとふざけないでよ！！もうちょっと夏を楽しもうとしてよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:わたしはもう準備万端なんだからちょっと付き合ってくれてもいいじゃない！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620036")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ギネマウア", "挨拶")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ギネマウア★★:ギネヴィア、言ってることがめちゃくちゃよ
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0620037")

	PlayAction(Actor002,"to  Std_Joy")

	--★★ギネヴィア★★:知ってる！！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620038")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:知ってるけど<br>もう、なんかぐちゃぐちゃなんだもん！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ギネマウア★★:もう…
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0620041")

-- ▼直接出力
bgm_play("BGM_ADV_Ginevia_Theme")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ティルフィング★★:あの、プレゼントって…
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620042")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:キミと一緒に水遊びをして<br>仲良くなりたいんだってさ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ノワール★★:そのために、水着をプレゼントして<br>遊びに誘うつもりだったんだ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620044")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:…キミと仲良くなりたい一心で<br>一生懸命選んでた
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620045")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア", "swim_0033")
-- ▲直接出力

	--★★ギネヴィア★★:なんでノワールが言っちゃうの！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620047")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ギネマウア★★:あなたがぐちゃぐちゃに<br>なっちゃってるからでしょう
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0620048")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ううう～～～！！！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620049")


	--★★ティルフィング★★:…あの、ギネヴィア様
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:な、なに…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0620051")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ティルフィング★★:もしよければ、そのプレゼント…<br>見せていただいてもよろしいですか？
	Talk(Actor001,"CHRNAME_TYRFING","speech","L","EA_003_0620052")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
wait_time(0.3)
se_play("SE_ADV_EA_003_062_Cloth")
setup_small_camera_start()
Hide(Actor001)
Appear(Actor007)
Hide(Actor002)
Appear(Actor008)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor008,Actor007,"J_Head")
keep_ik_lookat(Actor007,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor007,"J_Head")
keep_ik_lookat(Actor004,Actor007,"J_Head")
keep_ik_lookat(Actor005,Actor007,"J_Head")
keep_ik_lookat(Actor006,Actor007,"J_Head")
set_enable_auto_lookat(Actor007, true)
change_face(Actor008,"Smile")
setup_small_camera_start(CameraEx_06)
wait_time(6.7)
--フェードイン
fadein(CHARA_IN_OUT)
slidemove(CameraEx_06,-2.789,1.347,-11.489,4.8)
wait_time(5.8)
CameraEx_05 = set_camera({-3.086, 1.33, -11.029,   17.6, 117, 0,   28})
setup_small_camera_start(CameraEx_05)
slidemove(CameraEx_05,-3.154,1.354,-10.995,2.0)
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン", "0047")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ディナタン★★:わあ！<br>ティルフィングさん、かわいい！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_003_0620054")

-- ▼直接出力
setup_small_camera_start()
keep_delay_ik_lookat(Actor004,Actor008,"J_Head",1.0)
set_enable_auto_lookat(Actor008, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力

	--★★ディナタン★★:…あ、もちろんギネヴィア様もですよ！！<br>さっきはバタバタして言えませんでしたが！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_003_0620055")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor008,"Laugh")

	--★★ギネヴィア2★★:できた妹さんね
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620057")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★マルディサント★★:ふーん。まぁ、悪くはねぇかな～なかなかセンスあんじゃん
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","EA_003_0620058")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ギネヴィア2★★:にっしっし…♪まぁねまぁね～
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620059")

	change_face(Actor004,"Normal")

	--★★ディナタン★★:兄さんはどう思う？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_003_0620060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","EA_003_0620062","EA_003_0620063")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor007,"J_Head",1.0)
PlayPartVoiceDirect("ノワール", "0047")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール★★:似合ってるよ、ティルフィング<br>すごくかわいい
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620065")

	PlayAction(Actor007,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング", "swim_0048")
-- ▲直接出力
	change_face(Actor007,"Shy")

	--★★ティルフィング2★★:そ、そうですか…？
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","EA_003_0620067")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor008,"Laugh")

	--★★ギネヴィア2★★:わたしが選んだんだから当然でしょ！
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620068")

-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ギネマウア★★:殿下、今はちょっと黙りましょうか
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0620069")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor008,"J_Head",0.8)
wait_time(0.1)
PlayPartVoiceDirect("ノワール", "0047")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:お店でも思ったけど…<br>やっぱり似合うな、その水着
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620071")

	PlayAction(Actor008,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor008,"Shy")

	--★★ギネヴィア2★★:へ！？そ、そう…！？
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620072")

	PlayAction(Actor008,"to  Std_Worry")
	change_face(Actor008,"Shy")

	--★★ギネヴィア2★★:ま、まぁ、そうよね！似合うわよね<br>わたしもめっちゃ気に入ってるし、うんうん
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620073")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ギネマウア★★:殿下、顔が真っ赤です
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0620074")

	PlayAction(Actor008,"to  Std_Angry")
	change_face(Actor008,"Anger")

	--★★ギネヴィア2★★:うううう、うるさぁい！
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620075")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:ふたりの水着って、どっちもギネヴィア様が選んだんですよね？
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","EA_003_0620077")

	change_face(Actor008,"Surprise")

	--★★ギネヴィア2★★:ええ、そうよ。自分のはすぐにコレって<br>決まったんだけど…
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620078")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア", "0012")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ギネヴィア2★★:でもティルフィングのを選ぶのは難しかったわ
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620079")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:確かに、散々迷ってたもんな<br>その水着にした決め手はなんだったんだ？
	Talk(Actor003,"CHRNAME_NOIR","mind","L","EA_003_0620080")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア", "0007")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★ギネヴィア2★★:いくら考えてもわたしには<br>ティルフィングの好みがわからなかったわ
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620081")

	change_face(Actor008,"Laugh")

	--★★ギネヴィア2★★:だから、わたしの好みで選んだの<br>…ティルフィングをどう飾ってあげたいかって
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620082")

	change_face(Actor007,"Surprise")

	--★★ティルフィング2★★:どう飾ってあげたいか…
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","EA_003_0620083")

	PlayAction(Actor008,"to  Std_Sad01")
	change_face(Actor008,"Sad")

	--★★ギネヴィア2★★:お、押しつけがましかったかな…
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620084")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ティルフィング2★★:いいえ。こうした飾りの多いものは<br>普段あまり選ばないのですが…
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","EA_003_0620085")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor007,"Laugh")

	--★★ティルフィング2★★:自分では選ばないからこそ着る機会が無くて<br>…素敵なきっかけになりました
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","EA_003_0620086")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ティルフィング2★★:ありがとうございます、ギネヴィア様
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","EA_003_0620087")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ギネヴィア2★★:…にしし
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620088")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
set_enable_auto_lookat_all(true)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor007,"Anger")
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力

	--★★ティルフィング2★★:…！
	Talk(Actor007,"CHRNAME_TYRFING","speech","N","EA_003_0620089")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor007,"to Wlk")
turn_chara(Actor007,-173,0.5)
wait_time(0.5)
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★ノワール★★:ティルフィング？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620091")

-- ▼直接出力
CloseTalkWindow()
set_animationbattlecontroller(Actor007,1,true)
PlayActionDirect(Actor007,"ToIdle")
wait_time(0.8)
setup_small_camera_start(Camera007)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング", "swim_0017")
-- ▲直接出力

	--★★ティルフィング2★★:皆さま、お気を付けください
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","EA_003_0620092")

-- ▼直接出力
bgm_play("BGM_ADV_Invasion2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEx_07)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_0001)
on_active(Ef_0002)
on_active(Ef_0003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
Appear(Actor009)
Appear(Actor010)
Appear(Actor011)
turn_lookat(Actor008,Actor009,0)
turn_lookat(Actor003,Actor009,0)
turn_lookat(Actor004,Actor009,0)
turn_lookat(Actor005,Actor009,0)
turn_lookat(Actor006,Actor009,0)
set_animationbattlecontroller(Actor003,1,false)
PlayActionDirect(Actor003,"ToIdle")
wait_time(0.2)
set_animationbattlecontroller(Actor004,8,true)
PlayActionDirect(Actor004,"ToIdle")
wait_time(0.1)
set_animationbattlecontroller(Actor005,1,true)
PlayActionDirect(Actor005,"ToIdle")
wait_time(0.2)
set_animationbattlecontroller(Actor008,1,false)
PlayActionDirect(Actor008,"ToIdle")
wait_time(0.1)
set_animationbattlecontroller(Actor006,8,true)
PlayActionDirect(Actor006,"ToIdle")
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
	change_face(Actor008,"Anger")

	--★★ギネヴィア2★★:…ッ！バルバロイ…！
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","EA_003_0620094")


	--★★ティルフィング2★★:やはり伏兵を隠していましたか
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","EA_003_0620095")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ティルフィングの読みが当たったわけださすがだな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_003_0620096")

-- ▼直接出力
PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:コイツを片付ければ、ディーナの故郷は守れるってコトか？ならやってやるよ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","EA_003_0620097")

-- ▼直接出力
setup_small_camera_start(CameraEx_08)
slidemove(CameraEx_08,-0.02,0.67,-14.85,5)
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★ティルフィング2★★:ええ。もう二度と、誰かの大切な場所を奪わせたりはしない――！
	Talk(Actor007,"CHRNAME_TYRFING","speech","L","EA_003_0620098")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150_1", "content_still_10101015_image", "101010150_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
preload_sound("BGM_Area_Acoustic")
preload_sound("BGM_ADV_Ginevia_Theme")
preload_sound("BGM_ADV_Invasion2")
	InitializeLoad_Preload()
	load_area_scene_preload(111091)
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101001","004","101001004","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101011","005","101011005","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor011")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111091_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
