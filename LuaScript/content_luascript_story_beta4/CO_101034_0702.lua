-- このluaスクリプトは、CO_101034_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor001,{-1.3,0,3.885})
set_rot(Actor001,{0,150,0})
set_pos(Actor002,{0.3,0,-4})
set_rot(Actor002,{0,80,0})
set_pos(Actor003,{1.5,0,-4})
set_rot(Actor003,{0,-70,0})
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401023","001","401023001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
wait_time(1)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{-0.5,0,2.5},1.2)
wait_time(1)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:エクセリア…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020002")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Greet_one")
wait_time(1)
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor003)
Camera001=setup_small_camera_resetting(Actor001,CharaPos006,CameraPos006)
Camera002=setup_small_camera_resetting(Actor002,CharaPos002,CameraPos002)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今のは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020004")


	--★★エクセリア★★:通りすがりの人よログレスへの道を尋ねられたから教えていたの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…こんな森のなかで？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:そうよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:ところでノワールはどうしてこんなところにいるの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101034_07020012","CO_101034_07020013","CO_101034_07020014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キミが心配で追いかけてきたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:またバルバロイが出現するかもしれないひとりでは行かせられないと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020017")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:バルバロイの発生源はトリスタンが封じたのでしょう？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★エクセリア★★:さっきも言ったとおり心配はいらないはずよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020019")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:でも、心配してくれたことは感謝するわありがとう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:キミの様子がいつもと違う気がしてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020022")

-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:それだけで着いてきたというの？おかしな人ね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020023")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Normal")

	--★★エクセリア★★:私のデータにない思考…少し興味が湧いたわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020024")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:なんでもないわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020026")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺もちょうどこのあたりに用事があったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020028")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…っていうのはウソでエクセリアのことを追いかけてきたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:説明してくれなくてもすぐにわかったわそれがウソだということくらい
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020030")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それでエクセリアはここまでなにをしにきたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020032")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★エクセリア★★:お墓を作ろうと思って
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020033")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:お墓？…あの木こりの？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:ええ。知らない仲ではないでしょう？弔ってあげたいの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020035")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それならなおさら手伝わせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020036")


	--★★ノワール★★:心を込めて作ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:そうね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020040")

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to  Std_Talk")
turn_chara(Actor001,120,0.8)
-- ▲直接出力

	--★★ノワール★★:あの拓けているあたりがいいかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:異論はないわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:それじゃあ次は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020044")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:墓標になりそうな石を探しましょう
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020045")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Camera001=setup_small_camera_resetting(Actor001,CharaPos003,CameraPos003)
Camera002=setup_small_camera_resetting(Actor002,CharaPos002,CameraPos002)
set_pos(Actor001,{0.3,0,-1.2})
set_rot(Actor001,{0,20,0})
set_rot(Actor002,{0,-95,0})
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_start(RndCamera008)
set_enable_auto_lookat_all(true)
wait_time(0.3)
se_play("SE_ADV_CO_101034_0702_Grass_Work")
wait_time(TIME_ELAPSED + 1.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:私が育てた花が咲いたら手向けとしてここに持ってこようと思うの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020047")


	--★★エクセリア★★:芽が出たばかりだから<br>もう少し時間が必要だけど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:名案だと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020049")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか気になることでもあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:魔女の動きが活発になったことによって<br>バルバロイが出現するひん度が増してきている
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020052")


	--★★エクセリア★★:いくら銀卓騎士団や円卓の騎士が強く<br>学園で学びGSを果たす者が増えたとしても
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020053")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エクセリア★★:バルバロイを根絶するなんてこと本当にできるのかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020055")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力

	--★★エクセリア★★:この人のような被害者を<br>減らすことはできるのかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101034_07020058","CO_101034_07020059")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:やり遂げてみせる俺が、必ず
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020061")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:みんながあなたに期待しているわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020062")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:頑張って、継承者
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020063")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:円卓の騎士と銀卓騎士団とが協力すれば魔女に遅れを取ることなんてない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020065")

	change_face(Actor001,"Smile")

	--★★ノワール★★:…だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07020067")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:そうね…そのとおりだわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020068")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(RndCamera008)
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight_reset(Actor002,0.6)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:ごめんなさい。私としたことが少し弱気になってしまったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020070")


	--★★エクセリア★★:こんな顔はアダンに見せられない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★エクセリア★★:導き出さなければ…最適解を
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07020072")

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
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401023","001","401023001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
