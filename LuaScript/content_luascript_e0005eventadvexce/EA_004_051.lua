-- このluaスクリプトは、EA_004_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor004,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor005,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor006,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor007,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor008,Actor002,0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor009)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{-1.67, 0.128, 24.12,   121.1232})
set_pos(Actor007,{-3.36, 0.128, 22.39,   165.4253})
turn_lookat(Actor008,Actor002,0)
turn_lookat(Actor007,Actor002,0)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101054","005","101054005","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_TextOnly()
	Actor011 = InitializeCharacter_TextOnly()
	Actor012 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アダン","肯定")
-- ▲直接出力

	--★★アダン★★:では、この授業最後の演習試合を行います
	Talk(Actor002,"CHRNAME_ADAM","speech","L","EA_004_0510005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アダン★★:授業の締めくくりということで、これまでより<br>更に実戦を意識した戦闘を心がけてください
	Talk(Actor002,"CHRNAME_ADAM","speech","L","EA_004_0510006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★生徒たち★★:はい！
	Talk(Actor010,"NPCNAME_0116","speech","N","EA_004_0510007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アダン","肯定2")
-- ▲直接出力

	--★★アダン★★:
	Talk(Actor002,"CHRNAME_ADAM","speech","L","EA_004_0510008")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor002)
turn_lookat(Actor001,Actor003,0)

turn_lookat(Actor005,Actor003,0)
turn_lookat(Actor006,Actor003,0)
turn_chara(Actor008,170,0)
turn_lookat(Actor003,Actor001,0)
turn_lookat(Actor007,Actor003,0)
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
lookat_weight(Actor004,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor004,Actor003,"J_Head")
keep_ik_lookat(Actor005,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT +　0.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayPartVoice("パーシヴァル","挨拶")
-- ▲直接出力

	--★★パーシヴァル★★:やぁ、ノワール<br>ぼくの対戦相手はキミたちみたいだね
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","EA_004_0510011")

-- ▼直接出力
PlayPartVoice("パーシヴァル","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★パーシヴァル★★:キミがどういう最適解を繰り出すか<br>楽しみにしてるよ
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","EA_004_0510012")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★パーシヴァル★★:それとエクセリア…キミも<br>せいぜいチームの仲間と上手くやることだね
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","EA_004_0510013")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,-2.377,0,17.387,0.3)
wait_time(0.3)
slidemove(Actor003,-2.377,0,17.387,3.0)
wait_time(3.0)
PlayActionDirect(Actor003,"to Std_Loop")
Hide(Actor003)
keep_delay_ik_lookat_object(Actor006,Actor004,"J_Head",0.2)
keep_delay_ik_lookat_object(Actor007,Actor001,"J_Head",0.2)
keep_delay_ik_lookat_object(Actor008,Actor001,"J_Head",0.2)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:（気遣い下手か～！？<br>それじゃ伝わらないって――）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_004_0510015")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor004, true)
set_enable_auto_lookat(Actor005, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("エクセリア","0015")
-- ▲直接出力

	--★★エクセリア★★:わざわざ声をかけてきたかと思えば…<br>なにかしら、今の
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","EA_004_0510016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:（ほら～～～）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_004_0510017")

	open_select_window_tag(Actor001,"Normal","EA_004_0510019","EA_004_0510020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キミのことを気にしてるんじゃないか<br>ああやって強く言った手前さ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510023")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★エクセリア★★:つまり、どんな戦術を執るか<br>探りにきたってこと？
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","EA_004_0510024")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、そういうわけじゃなくて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510025")

	change_face(Actor004,"Normal")

	--★★エクセリア★★:…？
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","EA_004_0510026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:悪い。素直じゃない奴なんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:とりあえず、<br>嫌味を言いに来たとかじゃないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510030")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★エクセリア★★:…よくわからないけど、ノワールがそう言うなら<br>気にしないことにするわ
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","EA_004_0510031")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★エクセリア★★:
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","EA_004_0510033")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:指揮はノワールに任せるけど<br>私からも最適解の戦術を助言させてもらうわ
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","EA_004_0510034")

	PlayAction(Actor006,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("男子1","悲しみ")
-- ▲直接出力

	--★★男子生徒A★★:つまり、鬼教官の指導からは<br>逃げられないってことか…
	Talk(Actor006,"NPCNAME_0151","speech","N","EA_004_0510035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2","落胆")
-- ▲直接出力

	--★★男子生徒B★★:自主練はしたけど…でもやっぱり俺たちじゃ<br>エクセリアの最適解を実行するのは…
	Talk(Actor007,"NPCNAME_0153","speech","N","EA_004_0510036")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ","挨拶")
-- ▲直接出力

	--★★リリアーナ★★:あの、ノワール…<br>本当に大丈夫でしょうか
	Talk(Actor005,"CHRNAME_LILIANA","speech","L","EA_004_0510039")


	--★★リリアーナ★★:向こうのチームは練習を重ね<br>動きもだいぶ良くなっているようです
	Talk(Actor005,"CHRNAME_LILIANA","speech","L","EA_004_0510040")

-- ▼直接出力
PlayPartVoice("リリアーナ","悩む")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★リリアーナ★★:それに、その…チームの雰囲気も…
	Talk(Actor005,"CHRNAME_LILIANA","speech","L","EA_004_0510041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、わかってる<br>だから俺もひとつ秘策を準備してきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510042")

	change_face(Actor005,"Surprise")

	--★★リリアーナ★★:秘策？
	Talk(Actor005,"CHRNAME_LILIANA","speech","L","EA_004_0510043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:それじゃさっそく<br>試合に向けた訓練を始めましょう
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","EA_004_0510044")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:待ってくれ。訓練の前に、ひとつ<br>やるべきことがあると思うんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510045")

-- ▼直接出力
PlayPartVoiceDirect("エクセリア","0015")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★エクセリア★★:やるべきこと？なにかしら
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","EA_004_0510046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★エクセリア★★:最後の試合に向けた訓練を差し置いてでも<br>なんて、よほど大事なことなのよね
	Talk(Actor004,"CHRNAME_EXCELIA","speech","L","EA_004_0510047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ。指揮を執る者として<br>いま、俺たちに一番必要なこと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510048")


	--★★エクセリア／生徒たち★★:ゴクリ…
	Talk(Actor011,"CHRNAME_EXCELIA_STUDENTS","speech","N","EA_004_0510049")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール","喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:懇親会をやろう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510050")

-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力

	--★★一同★★:………へ？
	Talk(Actor012,"NPCNAME_0126","speech","N","EA_004_0510051")

	PlayAction(Actor008,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1","驚き")
-- ▲直接出力

	--★★女子生徒A★★:…なんで、今になって？
	Talk(Actor008,"NPCNAME_0146","speech","N","EA_004_0510052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そういえばやってなかったなと思ってさ<br>新人が入ったら、まずは飲む！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510053")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:で、腹割って話して仲良くなる！<br>これが鉄則だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0510054")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101054","005","101054005","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
