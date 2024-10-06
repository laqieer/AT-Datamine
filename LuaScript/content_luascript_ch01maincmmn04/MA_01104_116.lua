-- このluaスクリプトは、MA_01104_116.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110041_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110041_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_005)
	Camera005 = SetTemplate("Actor005",47.343,CharaPos110041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110041_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_006)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
-- ▼直接出力
DontChangeRandomCamera(true)
CameraEX_6 = set_camera({1.41159,1.63036,-4.4966,3.30148,135.3082,0.01918,22})
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
focus_distance_CameraEX_6 = 0.5
aperture_CameraEX_6 = 1
focal_length_CameraEX_6 = 16
 -- 仮スチル
load_image("101010170", "content_still_10101017_image", "101010170_StillImage")
load_image("103010290", "content_still_10301029_image", "103010290_StillImage")
lookoj_noir = create_object("kara_noir")
lookoj_noir2_1 = create_object("kara_noir2_1")
lookoj_noir2_2 = create_object("kara_noir2_2")
lookoj_lance = create_object("kara_lance")
lookoj_tyr = create_object("kara_tyr")
set_pos_object(lookoj_noir,-0.903,0,-3.871)
set_pos_object(lookoj_noir2_1,12.065,-2.162,-3.195)
set_pos_object(lookoj_noir2_2,5.89011,4.08563,-0.45153)
set_pos_object(lookoj_lance,-1.18,0,-6.329)
set_pos_object(lookoj_tyr,-1.035,0,-7.043)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-2.208,0,-5.633})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-2.001,0,-7.307})
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor003,"Sad")

	--★★ディナタン★★:昨日の襲撃については騒ぎになってたけど<br>…亡くなった人のことは話題に出てなかった
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_1160002")


	--★★ディナタン★★:確かにこの学園の生徒会長代理が<br>「ウレリー」という人なのは──
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_1160003")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:掲示物で見たの<br>だから…いたはずの人、なんだよね…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_1160004")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…そうね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160005")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どうして誰も覚えていないんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160006")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor004,-1.729,0,-5.95,0.8)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor005,-1.528,0,-6.885,0.8)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力

	--★★ランスロット★★:ノワール
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01104_1160008")


	--★★ランスロット★★:<dot>お前は覚えているんだな</dot>
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01104_1160010")

	change_face(Actor003,"Surprise")

	--★★ディナタン★★:ランス兄ちゃん…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_1160012")


	--★★ティルフィング★★:私がお呼びしました
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:バルバロイに襲われた者の末路は様々だ
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01104_1160014")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ランスロット★★:最も多いのは<br>直接<dot>喰われる</dot>こと
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01104_1160015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
on_cameraframe(2)
-- ▲直接出力
-- ▼直接出力
on_screencolor(IMAGE_COLOR, 0, -50)
-- ▲直接出力
-- ▼直接出力
show_image("101010170", 0.0, 0.0, 0.0)
-- ▲直接出力
-- ▼直接出力
fadein(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ランスロット★★:バルバロイは<br>喰った人間の<dot>存在と記憶を栄養にして</dot>、増える
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","MA_01104_1160018")


	--★★ディナタン★★:え…
	Talk(Actor003,"CHRNAME_DINATAN","simple","N","MA_01104_1160020")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:つまり喰われた人は<br><dot>周囲の人たちから忘れられてしまう</dot>の
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01104_1160021")


	--★★ランスロット★★:その人間の存在と記憶が<br>歴史から消し去られてしまうんだ
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","MA_01104_1160024")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_OUT_OUT)
-- ▲直接出力
-- ▼直接出力
hide_image()
-- ▲直接出力
-- ▼直接出力
off_cameraframe()
-- ▲直接出力
-- ▼直接出力
off_screencolor()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,320.6823,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,220.4458,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,287.276,0,0)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Surprise")
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_WAIT_AFTER)
-- ▲直接出力
-- ▼直接出力
fadein(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:消える？歴史から…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット★★:大切な人の死を悲しむことすらできない<br>その人が生きた痕跡は確かにあるのに
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01104_1160026")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:家族が喰われたとして<br>その人の形見が遺ったとしても──
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160027")


	--★★ギネヴィア★★:すべて<br>赤の他人の物のようにしか思えなくなる
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160028")


	--★★ギネヴィア★★:その人からの手紙が遺っていたとしても<br>やりとりを思い出すことはできない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160029")

-- ▼直接出力
SkipDefaultMotion(Actor005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Sad01")
	change_face(Actor005,"Sad")

	--★★ティルフィング★★:見た夢を忘れてしまうように<br>それは現実だったはずなのに
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160030")


	--★★ランスロット★★:その人との思い出だけが<br>すっぽりと抜け落ちる
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01104_1160031")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor001,{1.0,0.03,0.7,0.2},0.2)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat_object(Actor001,nil,"kara_noir")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,162.285,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor005,0,110.652,0,0)
-- ▲直接出力
-- ▼直接出力
on_cameraframe(2)
-- ▲直接出力
-- ▼直接出力
on_screencolor(IMAGE_COLOR, 0, -50)
-- ▲直接出力
-- ▼直接出力
show_image("103010290", 0.0, 0.0, 0.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
fadein(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★テロップ★★:「日記とか見て、父さんを思い出そうとしても<br>やっぱりその実感がなくて」
	Talk(Actor007,"","narration","N","MA_01104_1160033")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:生徒たちはみんな<br>その喪失感を知ってる
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01104_1160035")

	change_face(Actor004,"Normal")

	--★★ランスロット★★:だから戦うんだ
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","MA_01104_1160036")


	--★★テロップ★★:「ワタシね…お父さんをバルバロイに食べられて<br>顔も覚えていないんだ」
	Talk(Actor007,"","narration","N","MA_01104_1160037")


	--★★ノワール★★:そんな、まさか──
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01104_1160038")


	--★★テロップ★★:「忘れちゃったんだ<br>みんな、お父さんのこと」
	Talk(Actor007,"","narration","N","MA_01104_1160039")

	change_face(Actor003,"Sad")

	--★★ディナタン★★:…じゃ、じゃあそのウレリーさんも
	Talk(Actor003,"CHRNAME_DINATAN","simple","N","MA_01104_1160040")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:バルバロイに喰われて<br>わたしたちの記憶から消えた…
	Talk(Actor002,"CHRNAME_GUINEVERE","simple","N","MA_01104_1160041")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_OUT_OUT)
-- ▲直接出力
-- ▼直接出力
hide_image()
-- ▲直接出力
-- ▼直接出力
off_cameraframe()
-- ▲直接出力
-- ▼直接出力
off_screencolor()
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_WAIT_AFTER)
-- ▲直接出力
-- ▼直接出力
fadein(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.4)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…？<br>………まってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160044")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:じゃあ…なんで俺は<br>ウレリーのことを覚えているんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160045")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:何かの記録を見て、知らない人の名前を見て<br>それが誰か思い出せなくて混乱する人はいるわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160046")


	--★★ギネヴィア★★:でも<br>ノワールはそういうことじゃ…ないんだ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160048")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はっきりと覚えてるんだ<br>どうして──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160049")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat_object(Actor004,nil,"kara_lance",0.3)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ランスロット★★:………すまない、ノワール
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01104_1160051")


	--★★ランスロット★★:お前は特別だ<br>だがそれ以上のことを…今は教えられない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01104_1160052")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat_object(Actor004,nil,"kara_lance",0.3)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:何を知ってるんだ、あんたは！！<br>いくつ隠し事をするつもりなんだ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160053")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,266.2104,0,0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:ティルフィング！<br>キミは何か知っているのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160055")

	change_face(Actor005,"Normal")

	--★★ティルフィング★★:はい
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160056")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★ティルフィング★★:ですが、お答えできません
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160058")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor006,Actor001,"J_Head")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…また出し惜しみだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160060")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★ティルフィング★★:私はこの時代とは<br>異なる歴史を生きた遺物です
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160061")


	--★★ティルフィング★★:…私に語れるのは<br>この歴史の方々が<dot>今知り得ることのみ</dot>
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160062")

-- ▼直接出力
keep_delay_ik_lookat_object(Actor005,nil,"kara_tyr",0.3)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ティルフィング★★:それ以上は──
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160064")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:「この歴史の流れを濁らせてしまう」<br>…だっけ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160066")

-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.3)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ティルフィング★★:ゆえに<ruby=ランスロット>今を知るであろうかた</ruby>を<br>お連れするのが精一杯…
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160068")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:何も知らないわたしが言うのもアレだけど<br>そうやって誰も彼もさァ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160070")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:ノワールの気持ちも考えようよ<br>なんで…なんで教えてあげられないの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01104_1160071")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",0.2)
-- ▲直接出力

	--★★ランスロット★★:…『本当』を伝えられるようになるまで<br>俺にできることはする。だから
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01104_1160073")

	open_select_window_tag(Actor001,"Normal","MA_01104_1160075","MA_01104_1160076")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:………わかった<br>何か理由があるんだろうってことも、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160078")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:「<dot>今は</dot>教えられない」<br>その言葉を、信じる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160079")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたは『本当』を知ってるってことだ<br>だったら、いつか聞き出すまでだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160081")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Anger")

	--★★ノワール★★:信じられると思うのか！？そんな言葉！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160083")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:ら、ランス兄ちゃんが<br>意地悪で言ってるわけじゃないのはわかるよ…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_1160085")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★ディナタン★★:でも、教えてくれない理由も<br>話してくれないの…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_1160086")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…答えがないのはわかってる<br>もう、いいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160087")

	goto Block1end

::Block1end::
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:こんな想い、もうたくさんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160090")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",0.3)
-- ▲直接出力

	--★★ノワール★★:ティルフィング
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160092")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:はい。マスター
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160093")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:キミは、俺の『本当の武器』を見つけるための<br>キッカケになると言った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160094")


	--★★ノワール★★:俺は、こんな現実と戦う武器が欲しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160096")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力

	--★★ティルフィング★★:…いなくなってしまった人のことを<br>「アナタだけが覚えている」という孤独…
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160098")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Anger")

	--★★ティルフィング★★:置いていかれてしまう寂しさ…<br>終わらせましょう
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160099")

	change_face(Actor005,"Normal")

	--★★ティルフィング★★:記憶が侵され、不確かになる世界です
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160100")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ティルフィング★★:だからこそ人との繋がりが<br>最も<ruby=レアな>かけがえのない</ruby>ものとなる
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160101")


	--★★ティルフィング★★:ゆえにバルバロイは<br>思い出を喰らおうとする
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160103")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ティルフィング★★:戦うことができるのは<br>強き<dot>思い</dot>から<dot>出</dot>る武器のみ
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160105")

-- ▼直接出力
SkipDefaultMotion(Actor005)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:果たしてください<br>アナタのゲシュタルト・シフトを
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160109")


	--★★ティルフィング★★:思い出を重ねるほど<br>その<ruby=つるぎ>劔</ruby>は強さを増していく
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160110")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Laugh")

	--★★ティルフィング★★:<ruby=ここ>学園</ruby>はそのための場所です
	Talk(Actor005,"CHRNAME_TYRFING","speech","L","MA_01104_1160111")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:ゲシュタルト・シフト………
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01104_1160113")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001,1.0)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,26.53282,0,0.4)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,1.856,0,-5.102,4.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor006,Actor001,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor001,"J_Head",0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Bokeh")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,71.943,0,1.0)
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,43.06161,0,0.9)
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,67.8707,0,0.6)
-- ▲直接出力
-- ▼直接出力
turn(Actor005,0,61.63026,0,0.7)
-- ▲直接出力
-- ▼直接出力
turn(Actor006,0,66.67622,0,0.8)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力

	--★★ノワール★★:傭兵団は俺の居場所だった<br>…<ruby=ウレリー>彼女</ruby>は、誰にでも親切な人だった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160115")

-- ▼直接出力
lookat_delay_weight(Actor001,{1.0,0.03,0.7,0.2},0.2)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat_object(Actor001,nil,"kara_noir2_1",0.25)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なのにみんないなくなった<br>俺はまた、何もできなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160117")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CameraEX_6)
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "focusDistance", focus_distance_CameraEX_6)
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "focalLength", focal_length_CameraEX_6)
-- ▲直接出力
-- ▼直接出力
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "aperture", aperture_CameraEX_6)
-- ▲直接出力
-- ▼直接出力
on_active(FX_DoF)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat_object(Actor001,nil,"kara_noir2_2",0.2)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こんな現実、終わらせるよ。必ず
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1160119")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
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
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
load_image_preload("101010170", "content_still_10101017_image", "101010170_StillImage")
load_image_preload("103010290", "content_still_10301029_image", "103010290_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
