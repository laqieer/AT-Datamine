-- このluaスクリプトは、EA_066_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation10","DuelCommonFormation10_h")
Include("content_adv_advsmall_duelcommonformation10","TemplateDuelCommonFormation10_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation10_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation10,CameraPosDuelCommonFormation10_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation10_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation10,CameraPosDuelCommonFormation10_003)
	Camera003 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation10_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation10,CameraPosDuelCommonFormation10_004)
	Camera004 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation10_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation10,CameraPosDuelCommonFormation10_006)
	Camera005 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation10_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation10,CameraPosDuelCommonFormation10_005)
	Camera006 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation10_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation10,CameraPosDuelCommonFormation10_007)
	InitializeTemplateRandomCameraDuelCommonFormation10()
	InitializeTemplateDuelCommonFormation10()
-- ▼直接出力
Hide(Actor002)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("201010850", "content_still_20101085_image", "201010850_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
load_sound("BGM_Outgame_MizugiEvTop")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","003","101025003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor004 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401039","001","401039001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
-- ▲直接出力

	--★★ヴォールス★★:あれから色々調べてみたが…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0220003")


	--★★ヴォールス★★:『妖精』の正体は村一番の美人の噂に<br>尾ひれがついたもの。『継承者』は――
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0220004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0033")
-- ▲直接出力

	--★★ヴォールス★★:なんのことはない。家出していた宿屋の息子が<br>ようやく帰ってきて店を継いだという話
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0220005")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★ヴォールス★★:結局、妖精も継承者もデマだったな
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0220006")

-- ▼直接出力
PlayPartVoiceDirect("クレア","0034")
-- ▲直接出力

	--★★クレア★★:デマ、というのは少し違うわね<br>我が町の妖精、継承者
	Talk(Actor002,"CHRNAME_CLARE","speech","N","EA_066_0220009")


	--★★クレア★★:仲間内で戯れにそう呼んでいただけの話が<br>人の間を伝わっていく中で質が変わっていく
	Talk(Actor002,"CHRNAME_CLARE","speech","N","EA_066_0220010")


	--★★クレア★★:伝承の始まりは、えてして<br>こういうものかもしれないと興味深かったわ
	Talk(Actor002,"CHRNAME_CLARE","speech","N","EA_066_0220011")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア","0010")
-- ▲直接出力

	--★★クレア★★:なんにせよ、なにかを伝えることが出来るのは<br>世界が終わらなかった平和の証ね
	Talk(Actor002,"CHRNAME_CLARE","speech","N","EA_066_0220012")


	--★★クレア★★:伝える先の明日があることを<br>疑う余地がないってことだもの
	Talk(Actor002,"CHRNAME_CLARE","speech","N","EA_066_0220013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0038")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ヴォールス★★:そうだな。戦いの傷跡は各地に残ってはいるが<br>皆、今の平和を信じ…安心して暮らしている
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0220014")


	--★★ヴォールス★★:その平和を切り拓いた物語として、いつか――<br>俺たちのあの戦いも伝承になるのかもな
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0220015")

-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力

	--★★クレア★★:ええ…そうかもしれないわね
	Talk(Actor002,"CHRNAME_CLARE","speech","N","EA_066_0220016")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:…だが、もしそうだとしても――…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0220017")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_1")
CloseTalkWindow()
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★ノワール★★:ああ。世界中を旅してまわりたいんだ<br>俺の中で生きている彼女といっしょに
	Talk(Actor003,"CHRNAME_NOIR","simple","N","EA_066_0220020")


	--★★ノワール★★:…ごめん。こんなこと言われても困るよな<br>分かってるのに
	Talk(Actor003,"CHRNAME_NOIR","simple","N","EA_066_0220021")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101025_sp_0002_1")
-- ▲直接出力

	--★★クレア★★:ヴォールス？
	Talk(Actor002,"CHRNAME_CLARE","speech","N","EA_066_0220023")

	change_face(Actor001,"Sad")

	--★★ヴォールス★★:（…寂しい顔をするあいつを見るたびに思う<br>本当に正しかったのだろうか、と）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0220024")


	--★★ヴォールス★★:（あのときの選択は正しかったのだろうか<br>他にやりようはなかったのだろうか）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0220025")


	--★★ヴォールス★★:（だがそんなことを<br>口にすることができるはずもない）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0220026")


	--★★ヴォールス★★:（俺はあいつの隣にいたはずの人のことを<br>なにひとつ思い出せないのだから）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0220027")

-- ▼直接出力
voice_play("VO_101025_sp_0002_2")
-- ▲直接出力

	--★★クレア★★:ヴォールス？ねえ、聞いてる？
	Talk(Actor002,"CHRNAME_CLARE","speech","N","EA_066_0220028")

	change_face(Actor001,"Normal")

	--★★ヴォールス★★:（ただ記録と事実が残る）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0220029")


	--★★ヴォールス★★:（元王妃がいた記録、前線に出て戦ったその人が<br>今はいないという事実）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0220030")

	change_face(Actor001,"Sad")

	--★★ヴォールス★★:（そして俺が聖杯を得る任も果たせず、すべてを<br>継承者とその劔に担わせてしまった事実も――）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0220031")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)

Appear(Actor002)
Appear(Actor004)
Appear(Actor005)
Appear(Actor006)
Appear(Actor007)
turn_lookat(Actor001,Actor004,0)
turn_lookat(Actor002,Actor004,0)
-- ▲直接出力

	--★★クレア★★:とう！
	Talk(Actor002,"CHRNAME_CLARE","speech","N","EA_066_0220032")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_EA_066_022_BeachBall")
fadeout(0,0,0,1.0, 0.0)
wait_time(IMAGE_TIME_WAIT_BEFORE)
show_image("201010850", 0.0, 0.0, 0.0 ,true,false)
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0043")
-- ▲直接出力

	--★★ヴォールス★★:ぶっ！？
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0220044")

-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0012")
-- ▲直接出力

	--★★クレア★★:必中ね。街で買ったこの水着のおかげで<br>機動性もバッチリ
	Talk(Actor002,"CHRNAME_CLARE","simple","N","EA_066_0220045")


	--★★ヴォールス★★:い、いきなりなにをするんだ！
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0220046")


	--★★クレア★★:何度呼んでも応えてくれないから<br>やむなく強硬手段をとったまで
	Talk(Actor002,"CHRNAME_CLARE","simple","N","EA_066_0220047")

-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0014")
-- ▲直接出力

	--★★クレア★★:わたしが狙っているのに<br>気を抜くあなたが悪いのよ
	Talk(Actor002,"CHRNAME_CLARE","simple","N","EA_066_0220048")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0037")
-- ▲直接出力

	--★★ヴォールス★★:…悪かった<br>少し考えごとをしていたんだ
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0220049")

-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0013")
-- ▲直接出力

	--★★クレア★★:見てればわかるわ<br>なにを考えているか、当ててあげましょうか
	Talk(Actor002,"CHRNAME_CLARE","simple","N","EA_066_0220050")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0040")
-- ▲直接出力

	--★★ヴォールス★★:…いや、いい
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0220051")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0051")
-- ▲直接出力

	--★★ヴォールス★★:それより、俺になにか話でもあるのか？
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0220052")

-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力

	--★★クレア★★:ええ。せっかくの海で浮かない顔をした助手を<br>水遊びにでも誘うつもりだったんだけど
	Talk(Actor002,"CHRNAME_CLARE","simple","N","EA_066_0220053")


	--★★ヴォールス★★:けど？
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0220054")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★クレア★★:けど、遊びの時間はここまでみたい
	Talk(Actor002,"CHRNAME_CLARE","simple","N","EA_066_0220055")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
wait_time(1.5)
setup_small_camera_end()
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("市民_男2","0031")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★男性B★★:ひ、ひいい！助けて――
	Talk(Actor004,"NPCNAME_0179","speech","N","EA_066_0220059")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ローマ兵A★★:静かにしろ！<br>大人しく貴様の知る情報をすべて話せ
	Talk(Actor005,"NPCNAME_0122","speech","N","EA_066_0220060")

	change_face(Actor001,"Normal")

	--★★ヴォールス★★:あの男は、さっきの…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0220062")


	--★★クレア★★:どうする？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0220063")

-- ▼直接出力
bgm_play("BGM_Outgame_MizugiEvTop")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス★★:決まっている。彼を助けるぞ
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0220064")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("201010850", "content_still_20101085_image", "201010850_StillImage")
preload_sound("BGM_ADV_Reconnaissance")
preload_sound("BGM_Outgame_MizugiEvTop")
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","003","101025003","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401039","001","401039001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation10)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
