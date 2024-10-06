-- このluaスクリプトは、MA_01B900_60.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_06","111016_06_h")
Include("content_adv_advsmall_111016_06","Template111016_06_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_06_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_03_MA01B900_60_Controller","to Std_Loop",CameraAssetBundleName111016_06,CameraPos111016_06_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_06_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_MA01B900_60_Controller","to Std_Loop",CameraAssetBundleName111016_06,CameraPos111016_06_002)
	InitializeTemplateRandomCamera111016_06()
	InitializeTemplate111016_06()
-- ▼直接出力
load_image("101020080", "content_still_10102008_image", "101020080_StillImage")
load_image("101030160", "content_still_10103016_image", "101030160_StillImage")
load_image("101030161", "content_still_10103016_image", "101030161_StillImage")
stillAnime = load_ui_effect("content_still_10102012_anim", "10102012_StillAnim", nil, nil, nil, "Root")
CUT_01 = cat_template_camera("P10_Cam")
CUT_02 = cat_template_camera("P11_Cam")
CUT_03 = cat_template_camera("P12_Cam")
CUT_04 = cat_template_camera("P13_Cam")
CUT_05 = cat_template_camera("P14_Cam")
CUT_06 = cat_template_camera("P15_Cam")
CUT_07 = cat_template_camera("P16_Cam")
CUT_08 = cat_template_camera("P17_Cam")
CUT_09 = cat_template_camera("P18_Cam")
CUT_10 = cat_template_camera("P19_Cam")
CUT_11 = cat_template_camera("P20_Cam")
CUT_12 = cat_template_camera("P21_Cam")
CUT_13 = cat_template_camera("P22_Cam")
CUT_14 = cat_template_camera("P23_Cam")
CUT_15 = cat_template_camera("P24_Cam")
CUT_16 = cat_template_camera("P25_Cam")
CUT_17 = cat_template_camera("P26_Cam")
CUT_18 = cat_template_camera("P27_Cam")
CUT_19 = cat_template_camera("P28_Cam")
CUT_20 = cat_template_camera("P29_Cam")
CUT_21 = cat_template_camera("P30_Cam")
RndCamera001 =  CUT_01
set_camera_nearclip(CUT_17,1.6)
helmet = setup_prop_object(10201005)
load_animpack(helmet, "content_animationpack_201_20101b90060", "MotionPack_20101B90060Prop")
motion(helmet, "throne01_stop_Pro_0060", 0, 1.0, true)
emblem = setup_prop_object(10130002)
set_pos(helmet,{0.000,2.744,-27.940})
set_pos(emblem,{8.000,1.000,-5.500})
set_rot(emblem,{67.9080734,325.695526,17.10009})
off_active(emblem)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"Set_end")
-- ▲直接出力
-- ▼直接出力
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_02)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力

	--★★ガラハッド★★:ガラハッドはここで死ぬ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"TurnHalf01")
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_03)
-- ▲直接出力
-- ▼直接出力
wait_time(7.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_04)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:ガラハッドとして学園で過ごした半年…<br>そこで多くの学びを得た
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600004")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
show_image("101020080", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ガラハッド★★:不潔だと思っていた共同生活<br>不潔だと思っていた慣れあいの関係性…
	Talk(Actor002,"CHRNAME_GALAHAD","simple","L","MA_01B900_600005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
show_image("101030160", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ガラハッド★★:でもすべてがあったからこそ<br>ガラハッドは戦い抜けたのだと思う
	Talk(Actor002,"CHRNAME_GALAHAD","simple","L","MA_01B900_600006")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
show_image("101030161", 0.0, 0.0, 0.0,true,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(1.25,1.25)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(2.5)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
hide_image(0.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_05)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"LookingAway")
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ガラハッド★★:そしてノワール、お前が──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600007")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"LookingAway_end")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_06)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:鎧の奥の僕を、見てくれていた<br>それに誇りを持つことが出来たんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600009")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_07)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002, {0.347,-0.160,-4.123})
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,0,0,0.1)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:『ガラハッドたるべし』とお爺様に言われてきた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600011")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:少し疎ましかったこともあった<br>戒めのようで、呪いのようで
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600012")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:でも、ガラハッドを名乗るときは<br>不思議と心を強く持てたのも事実だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600013")


	--★★ガラハッド★★:僕がかつて…誰になろうとしていたか<br>それはもうわからないが──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
on_active(emblem) 
-- ▲直接出力
-- ▼直接出力
turn(emblem,67.9080658,325.695526,40.6512413,2.0)
-- ▲直接出力
-- ▼直接出力
set_camera_farclip(CUT_08,2.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_08)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:ノワール、お前が<br>兄のように慕っていた者だと聞いた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
off_active(emblem)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"WalkIN01")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"LookDown01")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_09)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ガラハッド★★:だとすれば僕からすれば…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600016")


	--★★ガラハッド★★:目指すべき先であり、越えようとした壁であり<br>『ガラハッド』を生み出した存在──
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600017")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:『父』のような<br>存在なのかもしれないな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600018")


	--★★ノワール★★:…多くを、教えてくれた人だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_600019")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_10)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ガラハッドの名前が<br>弱い僕を護る鎧でもあった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600020")


	--★★ガラハッド★★:でももう銀卓騎士はいない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600021")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_11)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:姉上も、
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600048")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_12)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:お爺様もいない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600049")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_13)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:僕を好きと言ってくれた人は<br>みんな僕を置いていった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600022")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:だから<br>ひとり立ちするよ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600024")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_14)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:『<dot>ガラハッド</dot>』をやめて<br>──<dot>僕</dot>に戻ろうと思うんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600025")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_15)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:そして聖杯の伝説を継承したいんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600027")


	--★★ノワール★★:聖遺物化されたフィエナ──カリスが<br>俺たちを聖杯に導いてくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_600028")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:姉上を覚えているのはもう<br>僕とノワールしかいない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600029")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"LookUp")
-- ▲直接出力

	--★★ガラハッド★★:だからこそ、フィエナ・カリスが聖杯として<br>この地を平和に導いた歴史を遺そう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600030")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_16)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:ガラハッド…のことは<br>これからなんて呼べばいいんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_600031")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:あ、ああ、そうだな<br>ガラハッドはガラハッドをやめるんだった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600032")

	change_face(Actor002,"Smile")

	--★★ガラハッド★★:これから僕は<br><dot>本当</dot>の僕を『好き』になれそうな気がする
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B900_600033")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
--ガラハッド,CHRNAME_MAIA @名前変更
-- ▲直接出力
-- ▼直接出力
set_camera_nearclip(CUT_17,3.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_17)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:僕の本当の名前は『マイア』だ
	Talk(Actor002,"CHRNAME_MAIA","speech","L","MA_01B900_600035")


	--★★ノワール★★:マイア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_600036")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_18)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:『ガラハッド』は銀卓として生き<br>姉上とともに昇天した
	Talk(Actor002,"CHRNAME_MAIA","speech","L","MA_01B900_600037")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"LookUp_end")
-- ▲直接出力

	--★★ガラハッド★★:『マイア』は………<br>だから、マイアは、だな
	Talk(Actor002,"CHRNAME_MAIA","speech","L","MA_01B900_600038")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"LookUp")
-- ▲直接出力

	--★★ガラハッド★★:マイアはノワールとともに生きたい
	Talk(Actor002,"CHRNAME_MAIA","speech","L","MA_01B900_600040")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_19)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002, {0.347,-0.160,-3.246})
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"WalkIN02")
-- ▲直接出力

	--★★ガラハッド★★:お前も僕も『父』から引き継いだものは多く<br>ひとりで抱えきれるものではない
	Talk(Actor002,"CHRNAME_MAIA","speech","L","MA_01B900_600042")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力

	--★★ガラハッド★★:だけど絶対に捨てたり忘れたりしてはならない<br>どれだけ重荷だとしても最後の最後まで
	Talk(Actor002,"CHRNAME_MAIA","speech","L","MA_01B900_600043")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_20)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"WalkIN03")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ガラハッド★★:互いに杯を交わし、卓を囲み<br>同じ道を…歩んでいきたい
	Talk(Actor002,"CHRNAME_MAIA","speech","L","MA_01B900_600045")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
 -- setup_small_camera_start(CUT_21)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"HoldHand01")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"HoldHand01")
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
fadeout(255, 255, 255, 255,1.0,STILL_SWITCH_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
stillAnime.SetActive(true)
-- ▲直接出力
-- ▼直接出力
fadein(0.5)
-- ▲直接出力
-- ▼直接出力
local signal = play_ui_timeline_controller_in(stillAnime)
-- ▲直接出力
-- ▼直接出力
while signal.IsProccessing() do
-- ▲直接出力
-- ▼直接出力
coroutine.yield()
-- ▲直接出力
-- ▼直接出力
end
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:同じ道を…歩んでいきたい
	Talk(Actor002,"CHRNAME_MAIA","simple","L","MA_01B900_600050")


	--★★ガラハッド★★:お前と僕、ふたりの脚を揃えれば
	Talk(Actor002,"CHRNAME_MAIA","simple","L","MA_01B900_600046")


	--★★ガラハッド★★:４本脚なら<br>ぐらついたって倒れない
	Talk(Actor002,"CHRNAME_MAIA","simple","L","MA_01B900_600047")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101020080", "content_still_10102008_image", "101020080_StillImage")
load_image_preload("101030160", "content_still_10103016_image", "101030160_StillImage")
load_image_preload("101030161", "content_still_10103016_image", "101030161_StillImage")
load_ui_effect_preload("content_still_10102012_anim", "10102012_StillAnim", nil, nil, nil, "Root")
setup_prop_object_preload(10201005)
load_animpack_preload(helmet, "content_animationpack_201_20101b90060", "MotionPack_20101B90060Prop")
setup_prop_object_preload(10130002)
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName111016_06)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
