-- このluaスクリプトは、EA_003_061.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111091_01","111091_01_h")
Include("content_adv_advsmall_111091_01","Template111091_01_h")
Include("content_adv_advsmall_111091_02","111091_02_h")
Include("content_adv_advsmall_111091_02","Template111091_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111091_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111091_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_007)
	Camera008 = SetTemplate("Actor010",nil,CharaPos111091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName111091_01,CameraPos111091_01_002)
	InitializeTemplateRandomCamera111091_01()
	InitializeTemplate111091_01()
-- ▼直接出力
Hide(Actor006)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
load_image("still001", "content_still_10305007_image", "103050070_StillImage")
-- ▲直接出力
-- ▼直接出力
 load_image("101010150_1", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_MagicBind_Single", false, false)

set_pos(Ef_0001,{-1.95, 0.6, -9.16})
set_rot(Ef_0001,{270.75,-28.2,0})
set_scale(Ef_0001,{0.5,0.5,0.5})

Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_MagicBind", false, false)

set_pos(Ef_0002,{-1.178,-0.284,-12.013})
set_rot(Ef_0002,{0,328,0})
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor010,1,true)
Hide(Actor010)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111091_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_001)
	Camera002 = SetTemplate("Actor002",-183.9,CharaPos111091_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111091_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111091_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111091_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111091_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111091_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_007)
	Camera008 = SetTemplate("Actor010",-183.9,CharaPos111091_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName111091_02,CameraPos111091_02_002)
	InitializeTemplateRandomCamera111091_02()
	InitializeTemplate111091_02()
-- ▼直接出力
set_animationbattlecontroller(Actor010,1,true)
Hide(Actor010)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Unrest")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111091)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_2DOnly("101051","001","101051001")
	Actor009 = InitializeCharacter_2DOnly("101011","001","101011001")
	Actor010 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor010")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0047")
-- ▲直接出力

	--★★ランスロット★★:綺麗だな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_003_0610002")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:コルベニック城の湖にも負けないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット","笑い")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ランスロット★★:勝負するものではないと思うが…――まぁ、そうだな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_003_0610004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:もうバルバロイもいない…はずだきっと母さんも静かに眠れる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610005")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_1")
-- ▲直接出力
-- ▼直接出力
 --回想スチル
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(true)
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("still001", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ルーシャス★★:…まあ、いずれその静寂を未来永劫取り戻すのが継承者の役目だろうからな、精々励め
	Talk(Actor008,"CHRNAME_LUCIUS","simple","N","EA_003_0610007")

	change_face(Actor006,"Surprise")

	--★★ディナタン★★:え…
	Talk(Actor006,"CHRNAME_DINATAN","simple","N","EA_003_0610008")


	--★★ルーシャス★★:ここはバルバロイの発生源なのだろう？しばらくすればまた騒がしくなる。今のうちだ
	Talk(Actor008,"CHRNAME_LUCIUS","simple","N","EA_003_0610009")


	--★★ルーシャス★★:…まあ、いずれその静寂を未来永劫取り戻すのが継承者の役目だろうからな、精々励め
	Talk(Actor008,"CHRNAME_LUCIUS","simple","N","EA_003_0610010")


	--★★ルーシャス★★:母君に良き眠りを
	Talk(Actor008,"CHRNAME_LUCIUS","simple","N","EA_003_0610011")

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
setup_small_camera_start(Camera001)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

 wait_time(1.6)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…アイツ、本当に帰っていったな結局、ルーシャスはなにがしたかったんだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:湖から湧くバルバロイを見てなにか考えている様子だったけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット","悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ランスロット★★:さぁな。気になるならルーシャスを追いかけて問い詰める他あるまい
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_003_0610015")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(2.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット","挨拶")
-- ▲直接出力

	--★★ランスロット★★:…そろそろ戻るか？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_003_0610017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:あー…いや、もう少しだけいさせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Surprise")

	--★★ランスロット★★:なにか用事でもあるのか？
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_003_0610019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:あー、まぁ、そんな感じ、かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット","肯定2")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ランスロット★★:…わかったじゃあ俺たちは辺りを見回ってくるとしよう
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_003_0610021")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ランスロット★★:バルバロイの残党がいないとも限らないからな
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","EA_003_0610022")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

setup_small_camera_start()

PlayActionDirect(Actor003,"to Wlk")
wait_time(0.2)
PlayActionDirect(Actor004,"to Wlk")
wait_time(0.2)
PlayActionDirect(Actor005,"to Wlk")
wait_time(2.0)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")

Hide(Actor003)
Hide(Actor004)
Hide(Actor005)

Appear(Actor006)
Appear(Actor007)
turn_chara(Actor001,-51.3,0)
turn_chara(Actor002,-40.1,0)
wait_time(0.5)

--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン","挨拶")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ディナタン★★:ギネヴィア様を待ってるんだよね？
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","EA_003_0610024")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あぁ。あとから来るって言ってたんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610025")

	PlayAction(Actor007,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルディサント","悩む")
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★マルディサント★★:間に合うのかぁ？
	Talk(Actor007,"CHRNAME_MALADISANT","speech","L","EA_003_0610026")

-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どうかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610027")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング","挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:マスターせっかくの機会です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0610029")


	--★★ティルフィング★★:ディナタン様とゆっくりお母様のお墓参りをされてきては？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0610030")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え。いや、でもキミは――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング","肯定")
-- ▲直接出力

	--★★ティルフィング★★:私なら大丈夫ですから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0610032")


	--★★ティルフィング★★:マルディサント様もご一緒に
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0610034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:わかったよじゃあ、お言葉に甘えさせてもらう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0610035")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
wait_time(0.2)
PlayActionDirect(Actor006,"to Wlk")
wait_time(0.2)
PlayActionDirect(Actor007,"to Wlk")
wait_time(2.0)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
PlayActionDirect(Actor007,"to Std_Loop")


--テンプレ切替
template2()

setup_small_camera_start(RndCamera003)

Hide(Actor001)
Hide(Actor006)
Hide(Actor007)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
  --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
wait_time(2.6)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Unrest")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:（…やはり、感じる人ならざる者の力の残滓――）
	Talk(Actor002,"CHRNAME_TYRFING","mind","L","EA_003_0610038")


	--★★ティルフィング★★:（悪しき力ではない…けれどそれ故、魔女に目を付けられかねない）
	Talk(Actor002,"CHRNAME_TYRFING","mind","L","EA_003_0610039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:（先の戦いにおける魔女の退き際…あまりにもあっさりしすぎていた）
	Talk(Actor002,"CHRNAME_TYRFING","mind","L","EA_003_0610040")


	--★★ティルフィング★★:（魔女は執念深く狡猾なにかまだ、奥の手を残しているかも）
	Talk(Actor002,"CHRNAME_TYRFING","mind","L","EA_003_0610041")

-- ▼直接出力
CloseTalkWindow()
CameraEx_01 = set_camera({0.688, 0.73, -13.289,   6.1, 291.35, 0,   28})
CameraEx_02 = set_camera({-0.156, 0.864, -14.071,   8.7, 333.29, 0.001,   28}) 
Hide(Actor002)
Appear(Actor010)
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,0.648,0.73,-13.391,8)
PlayActionDirect(Actor010,"ToAbnormal")
change_face(Actor010,"Pain")
wait_time(1.7)
-- ▲直接出力
	change_face(Actor010,"Pain")

	--★★ティルフィング2★★:（…力が薄れ始めている残された時間はもうあまり多くない）
	Talk(Actor010,"CHRNAME_TYRFING","mind","L","EA_003_0610043")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx_02)
slidemove(CameraEx_02,-0.115,0.878,-14.153,8)
PlayActionDirect(Actor010,"ToIdle")
wait_time(0.8)
-- ▲直接出力

	--★★ティルフィング2★★:（それでも、マスターが自分の武器を見つけるまで、私は私の使命を果たす）
	Talk(Actor010,"CHRNAME_TYRFING","mind","L","EA_003_0610044")


	--★★ティルフィング2★★:（二度とバルバロイに奪わせないもう二度と――…）
	Talk(Actor010,"CHRNAME_TYRFING","mind","L","EA_003_0610045")

-- ▼直接出力
CloseTalkWindow()
CameraEx_03 = set_camera({-4.507, 1.167, -8.569,   16, 101.278, 0,   28})
setup_small_camera_start(CameraEx_03)
on_active(Ef_0001)
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor010)
Appear(Actor002)
change_face(Actor002,"Pain")
-- ▲直接出力
-- ▼直接出力
CameraEx_04 = set_camera({-4.463, 1.522, -6.206,   13, 145.258, 1.373,   22})
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,345,0.5)
wait_time(0.2)
setup_small_camera_start(CameraEx_04)
slidemove(CameraEx_04,-4.324,1.518,-6.109,8)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(1.0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:これは、やはり――
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","EA_003_0610047")

-- ▼直接出力
CloseTalkWindow()
turn_chara(Actor010,345,0)
set_pos(Actor010,{-1.09,-0.715,-11.94})
change_face(Actor002,"Normal")
wait_time(0.8)
PlayActionDirect(Actor002,"to Wlk")
wait_time(0.1)
slidemove(Actor002,{-1.09,-0.715,-11.94},0.3)
wait_time(0.1)
on_active(Ef_0002)
se_play("SE_ADV_EA_003_061_Spark_Loop")
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --wait_time(0.2)
CameraEx_05 = set_camera({-1.82, 0.953, -9.041,   7.34832, 164.6954, 0,   28})
setup_small_camera_start(CameraEx_05)
Hide(Actor002)
Appear(Actor010)
change_face(Actor010,"Anger")
wait_time(1.2)
-- ▲直接出力
	change_face(Actor010,"Anger")

	--★★ティルフィング2★★:（ッ！？しまった二重に罠を仕掛けていたか――）
	Talk(Actor010,"CHRNAME_TYRFING","mind","L","EA_003_0610049")

	change_face(Actor010,"Pain")

	--★★ティルフィング2★★:（まずい、このままでは――）
	Talk(Actor010,"CHRNAME_TYRFING","mind","L","EA_003_0610050")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("101010150_1", 0.0, 0.0, 3,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(3.5)
se_play("SE_ADV_Loop_Stop")
wait_time(3.8)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_EA_003_061_Footstep")
wait_time(1.9)
-- ▲直接出力
	change_face(Actor009,"Anger")

	--★★ギネヴィア★★:――ティルフィング！！
	Talk(Actor009,"CHRNAME_GUINEVERE","speech","L","EA_003_0610052")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("still001", "content_still_10305007_image", "103050070_StillImage")
 load_image_preload("101010150_1", "content_still_10101015_image", "101010150_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_MagicBind_Single", false, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_MagicBind", false, false)
preload_sound("BGM_ADV_Unrest")
	InitializeLoad_Preload()
	load_area_scene_preload(111091)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("101051","001","101051001")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111091_01)
	system.PreLoadRequest(CameraAssetBundleName111091_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
