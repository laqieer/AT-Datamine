-- このluaスクリプトは、EA_002_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera003 = SetTemplate("Actor003",144,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
load_image("EA_002_051", "content_still_20101001_image", "201010010_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
Hide(Actor003)
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001, 0.7, 0.7, 0.7, 0.2,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
CameraEX = set_camera({0.2, 3, -9.5,   -14.6, 180, 0,   45})
FX_Diffusion = load_postprocess("content_adv_postprocess_diffusion", "Ef_C_PP_Diffusion", false)
-- ▲直接出力
-- ▼直接出力
load_image("insert_001", "content_still_10305002_image", "103050020_StillImage")
show_image("insert_001", 0.0, 0.0, 0 ,true,false) 
   set_position_image(-216, 0)
move_to_image(0,0,5.6,2)
-- ▲直接出力
-- ▼直接出力
load_image("insert_002", "content_still_10305003_image", "103050030_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("insert_003", "content_still_10305004_image", "103050040_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("insert_004", "content_still_10305005_image", "103050050_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera005)
se_play("SE_ADV_EA_002_051_Card_Shuffle")
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★イゾルデ★★:<ruby=ディーラー>札の配り手</ruby>も悪くないわね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_051002")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リアム", "肯定2")
-- ▲直接出力

	--★★リアム★★:…致死薬は手に入ったのですね
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_051003")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("insert_002", 0.0, 0.0, 0 ,true,false) 
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:ええ。あの人に渡したわ
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_002_051004")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうか…
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_002_051005")

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:ついでに頼んだの<br>「長生きしてね」って
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_002_051006")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
hide_image()
  
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001, "Surprise")
-- ▲直接出力

	--★★イゾルデ★★:お前のせいよ。ノワール
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_051008")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("insert_003", 0.0, 0.0, 0 ,true,false) 
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★イゾルデ★★:「親しい人から死を勧められるのは<br>死ぬよりつらい」
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_002_051009")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:だからワガママ言ってみたわ
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_002_051010")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, 0.6)
wait_time(1.2)
show_image("insert_004", 0.0, 0.0, 0 ,true,false) 
fadein(0.6)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★イゾルデ★★:賭けの選択を相手に託すのも<br>スリリングで愉しいんじゃないかと思ったの
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_002_051011")

	change_face(Actor002,"Normal")

	--★★イゾルデ★★:死の選択肢を持てることが<br>今を悔いなく生きる覚悟になりえるかもしれない
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_002_051012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera005)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ。きっとそうだ
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_002_051013")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
hide_image()
  
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リアム", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リアム★★:………貴方の師はその手札を──…<br>選択肢を貴方に求めたのかもしれませんね
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_051014")

	change_face(Actor005,"Normal")

	--★★リアム★★:貴方にだからこそ、任せた
	Talk(Actor005,"CHRNAME_LIAM","speech","L","EA_002_051015")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:あの人に試されたのかしら<br>私が死を勧めるような冷血女かどうか
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_051016")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "笑い")
Appear(Actor004)
Appear(Actor003)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:賭けたんだよ<br><ruby=イゾルデ>教え子</ruby>は薬の扱いを誤らないはずだと信じて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_002_051017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:──良い薬になったわ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_051019")


	--★★イゾルデ★★:…私が明日以降も同じ顔色であれば<br>良いほうにコトが進んでいるのだと思ってね
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_051020")

-- ▼直接出力
CloseTalkWindow()
--EntryWalk_2P(Actor003,Camera003,EntryData110101_01_07,CameraAssetBundleName110101_01,CameraPos110101_01_107,Actor004,CharaPos110101_01_006,CharaPos110101_01_106) 
lookat_weight_reset(Actor001)
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
 --PlayActionDirect(Actor003,"to Wlk")
--turn_chara(Actor003,144.1,0.3)
--wait_time(0.3)
--PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:それもポーカーフェイスでは？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_051022")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:それを見抜けんお前じゃないだろう？<br>クレア
	Talk(Actor004,"CHRNAME_BORS","speech","L","EA_002_051023")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:…もう、事件の香りはしないわね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_002_051025")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
crossdissolve(CameraEX,2.0,false)
-- ▲直接出力
-- ▼直接出力
on_active(FX_Diffusion)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
turn(CameraEX,-32.3,180, 0, 10.0)
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★イゾルデ★★:疑いようもないわ<br>名探偵がそう言うなら
	Talk(Actor002,"CHRNAME_ISOLDE","speech","N","EA_002_051028")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.7)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED)

show_image("EA_002_051", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) 
se_play("SE_ADV_EA_002_051_Card")
wait_time(FADE_TIME)
fadein(FADE_TIME)
wait_time(1.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★イゾルデ★★:神は賭けなんてしない御人よ
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_002_051032")


	--★★イゾルデ★★:だとすれば自分で選ぶしかないわね<br>伸るか反るかの大勝負でも
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_002_051033")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:当てにならないんじゃあ、ね？
	Talk(Actor002,"CHRNAME_ISOLDE","simple","N","EA_002_051034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("EA_002_051", "content_still_20101001_image", "201010010_StillImage")
load_postprocess_preload("content_adv_postprocess_diffusion", "Ef_C_PP_Diffusion", false)
load_image_preload("insert_001", "content_still_10305002_image", "103050020_StillImage")
load_image_preload("insert_002", "content_still_10305003_image", "103050030_StillImage")
load_image_preload("insert_003", "content_still_10305004_image", "103050040_StillImage")
load_image_preload("insert_004", "content_still_10305005_image", "103050050_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
