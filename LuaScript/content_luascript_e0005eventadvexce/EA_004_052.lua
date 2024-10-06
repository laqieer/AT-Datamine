-- このluaスクリプトは、EA_004_052.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_03","110122_03_h")
Include("content_adv_advsmall_110122_03","Template110122_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",260,CharaPos110122_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_004)
	Camera002 = SetTemplate("Actor002",250,CharaPos110122_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110122_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110122_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110122_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_03,CameraPos110122_03_008)
	InitializeTemplateRandomCamera110122_03()
	InitializeTemplate110122_03()
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_pos(Actor003,{5.908,0,-4.121})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
set_pos(Actor004,{5.674,0,-3.232})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera002
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_EA_004_052_Crowds_Loop")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
IN_WALK_2P(Actor003,CharaPos110122_03_002,Actor004,CharaPos110122_03_001)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガレス","喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:やっほ～♪<br>ガレスちゃんのスペシャルメニューだぞ！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","EA_004_0520005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★リオネス★★:懇親会をやるっていうから<br>張り切ってたくさん作ったぞ！ガレスが！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_004_0520006")

-- ▼直接出力
PlayPartVoice("男子1","驚き")
-- ▲直接出力

	--★★男子生徒A★★:テイクアウトも頼んだのかよ！<br>準備が良すぎる
	Talk(Actor005,"NPCNAME_0151","speech","N","EA_004_0520007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1","納得")
-- ▲直接出力

	--★★女子生徒B★★:そういえばノワールって傭兵団上がりだっけ<br>飲み会への意欲がすごい
	Talk(Actor008,"NPCNAME_0147","speech","N","EA_004_0520008")

-- ▼直接出力
PlayPartVoice("男子2","肯定3")
-- ▲直接出力

	--★★男子生徒B★★:ていうか、旨そ～！！
	Talk(Actor006,"NPCNAME_0153","speech","N","EA_004_0520009")

	change_face(Actor004,"Surprise")

	--★★リオネス★★:あ、一応言っておくけど、<br>飲み物はもちろんノンアルコールだからな！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_004_0520010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス","肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガレス★★:酔うのは雰囲気だけにするんだぞ～♪<br>それじゃ、みんな楽しんで！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","EA_004_0520011")

-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,5.908,0,-4.121,0.5)
wait_time(0.3)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat_position(Actor004,5.674,0,-3.232,0.5)
wait_time(0.2)
slidemove(Actor003,5.908,0,-4.121,2.0)
slidemove(Actor004,5.674,0,-3.232,2.0)
wait_time(1.5)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
Hide(Actor003)
Hide(Actor004)
lookat_delay_weight_reset(Actor001,1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:さて、せっかくの旨い飯が冷める前に<br>さっそく始めるとするか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520013")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,7,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ほら、エクセリアも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:…理解できない<br>不適解にもほどがあるわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0520018")


	--★★エクセリア★★:最適解の戦術を実行するには<br>このチームは明らかに技量が不足している
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0520019")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:このままでは彼らは必ず<br>これからの戦いで苦しむことになるわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0520020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:だからこそ今、厳しい訓練を積み<br>戦う力を磨くこと彼らには必要なの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0520021")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("エクセリア","0033")
-- ▲直接出力

	--★★エクセリア★★:それなのに限られた訓練時間を返上して<br>懇親会を開くだなんて…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0520022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も昔はそう思ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520023")

-- ▼直接出力
PlayPartVoice("エクセリア","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:え？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0520025")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:傭兵ってのはなにかにつけて飲んでばっかでさ<br>なんの意味があるんだって思ってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:そんなことする暇があったら<br>鍛錬したほうがいいって、直接言ったこともある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そしたら笑われたよ<br>「そんなのいつでも出来るだろ」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:「それより今、一緒にいる相手のことを見ろ<br>一緒に飲んだ相手のツラを覚えとけ」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520030")


	--★★ノワール★★:「戦場ではそいつに背中を預けることになる<br>ツラを覚えときゃ安心できるだろ」って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…今思えば、俺たち兄妹が馴染めるように<br>場を作ってくれてたのかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ま、ただ飲み会が好きだっただけ<br>かもしれないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520033")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:…尊敬しているのね、その人のこと
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0520034")

-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:あぁ<br>大切なことをたくさん教えてもらった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520035")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:…って、そろそろ俺たちも食べようか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0520036")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera002
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
