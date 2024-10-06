-- このluaスクリプトは、CO_101034_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_01","110161_01_h")
Include("content_adv_advsmall_110161_01","Template110161_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110161_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_01,CameraPos110161_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110161_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110161_01,CameraPos110161_01_002)
	InitializeTemplateRandomCamera110161_01()
	InitializeTemplate110161_01()
-- ▼直接出力
load_image("104000120", "content_still_10400012_image", "104000120_StillImage")
DontChangeRandomCamera(true)
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:そのノート…<br>またなにかのデータを整理してたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:ええ、そうよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:さすがだな<br>今日はなにについて調べてたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020004")


	--★★エクセリア★★:私自身について
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020005")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:エクセリア自身について？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:記憶が消えるのなら<br>こうして書いておけばいいのよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020007")


	--★★エクセリア★★:そうすれば<br>あとで読み返せるでしょう？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なるほど、日記か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020009")

-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:それにどうやら私<br>こういう作業が向いているみたいなの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020011")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:なにかを調べたり、まとめたりして<br>最適解を導き出せたとき、頭がスッキリするのよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020012")

-- ▼直接出力
setup_small_camera_start(Camera001)
Prop_01 = get_object("geo_chair_02")
set_pos(Prop_01, {0.7,0,-1})
set_rot(Prop_01,{0,-45,0})
set_animationcontroller(Actor002,"Chr_510_01_StdController","to Std_Loop")
Camera002=setup_small_camera_resetting(Actor002,CharaPos004,CameraPos004)
set_pos(Actor002,{1.45,0,-1})
set_rot(Actor002,{0,-160,0})
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それって<br>リフレッシュしてるってこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020013")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:リフレッシュ？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020014")

-- ▼直接出力
PlayPartVoice("エクセリア", "納得")
-- ▲直接出力

	--★★エクセリア★★:なるほど、これがリフレッシュなのね…<br>みんながやっていたこととは少し違うけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エクセリア★★:書き留めておかなくちゃ…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なるほどな<br>そうやってエクセリアの心はほぐれるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020017")


	--★★ノワール★★:だから花について調べているときも<br>すごくのめり込んでいたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:そうかもしれないでも花を育てるのも楽しんでいるわよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020019")

	PlayAction(Actor002,"to  Std_Worry")

	--★★エクセリア★★:育てかたを調べて、それを実践して…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020021")


	--★★エクセリア★★:それがより良い花を咲かせることに繋がるのは素直に面白いと思う
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Appl")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:すごくいい<br>すごく普通だよ、エクセリア
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020023")

-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:え？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020024")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:こっちのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはそうとケイがエクセリアにお礼を言ってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020027")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:エクセリアが集めてくれたデータのおかげで<br>バルバロイの出没区域を予測できるようになって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020028")


	--★★ノワール★★:警備体制を見直すきっかけにもなったって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そう喜んでもらえたのなら、なによりだわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:エクセリア…。よかったら今後も俺たちと一緒に戦ってくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020031")


	--★★エクセリア★★:それもケイが？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020032")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:いや、俺の個人的な気持ちだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
PlayPartVoice("エクセリア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エクセリア★★:そうだ、このあいだくれた種は紫苑だったのね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020035")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:さすがエクセリア<br>調べたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020036")


	--★★エクセリア★★:「あなたを忘れない」
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020037")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:花言葉まで調べてたんださすがだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020038")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:ありがとう、ノワールあなたの気持ちもちゃんと受け取ったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020039")

	PlayAction(Actor002,"to LookFor")
	change_face(Actor002,"Shy")

	--★★エクセリア★★:…お礼と言ってはなんだけど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020040")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Show")
wait_time(2)
setup_small_camera_start()
ShowImageItem("104000120")
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…押し花をあしらったしおり？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020042")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
PlayActionDirect(Actor001,"to  Std_Talk")
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:マーガレットよ<br>初めてにしては上手くできたと思う
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020043")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:エクセリアの手作りか大切に使わせてもらうよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020044")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:それで、マーガレットの花言葉は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_10020045")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:それは自分で調べてみて
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_10020046")

-- ▼直接出力
local trustParam = set_communication_rankup("エクセリア_コミュランク", "エクセリア_親密度")
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
load_image_preload("104000120", "content_still_10400012_image", "104000120_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
