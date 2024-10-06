-- このluaスクリプトは、MA_01A112_32.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
DontChangeRandomCamera(true)
change_face(Actor002,"Sad")
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101011","001","101011001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
se_play("SE_ADV_MA_01105_24_Knock")
wait_time(2.0)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア2D★★:…さむいから、いれてくれない？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:………どうぞ
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320003")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
lookat_weight(Actor001,0.7,0.03,0.7,0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
setup_small_camera_start(Camera001)
wait_time(TIME_ELAPSED)
Appear(Actor002)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★エレイン★★:………なんて顔、してるんです
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320005")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…こっちのセリフ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★エレイン★★:見みせたくありませんでした<br>ギネヴィアさんには
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320008")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:…どうして？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320009")


	--★★エレイン★★:思い出させたくない
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:気に病まないで…ほしいんです
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320011")

	change_face(Actor001,"Normal")

	--★★エレイン★★:あのときは体が勝手に動いて<br>…私はむしろ「良かった」とすら
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…わたしね<br>エレインの気持ち、ちょっとわかったよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320013")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力

	--★★ギネヴィア★★:言葉がね、出ないの…どうしても
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:うまく口が開かない<br>笑ってなんかいられない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320016")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:だけどエレインは初めから<br>必死に伝えようとしてたんだね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320017")


	--★★ギネヴィア★★:手紙は…あなたが書き連ねる文字は<br>あなたの叫び声だったんだね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:一生懸命、ずっと一生懸命だったんだね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320019")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★エレイン★★:…買いかぶり過ぎです
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:あなたのキズに報いるよ。わたし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320021")

	change_face(Actor001,"Surprise")

	--★★エレイン★★:ギネヴィアさん…？
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:わたし、きっとすぐ聖遺物化しちゃうだろうけど<br>あの人が覚えててくれればいいと言い聞かせてた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わたし、だめなのかもしんない<br>選ばれるべきじゃなかったのかもしんない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:あなたの悲鳴が耳から離れない<br>怯えたわたしを守って上げた、あなたの悲鳴が
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320026")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:でもわたし…それも思い出すよ<br>覚えているかぎり、何度でも思い出すよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:あんな声<br>もう誰にも上げさせない
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320029")


	--★★ギネヴィア★★:なにも遺せないほど弱かったとしても<br>誰にも傷跡が残らないようにしたいよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:もう一度、あなたの顔を見せて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320031")


	--★★ギネヴィア★★:わたしに──覚悟させて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320032")


	--★★エレイン★★:ギネヴィアさん
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:あなたの代わりに喚くから、わたし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★エレイン★★:ギネヴィアさん
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320037")


	--★★ギネヴィア★★:だからわたしの代わりに、いつかあなたは──
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★エレイン★★:え…？
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A112_320040")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…ううん。この話はまた今度<br>元気になったらしよ。一緒いっしょに笑お
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:癒えるまでは、いいんだよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_320042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101011","001","101011001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
