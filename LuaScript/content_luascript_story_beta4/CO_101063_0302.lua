-- このluaスクリプトは、CO_101063_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-78,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_pos(Actor003,{-4.079,0,-0.200})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
Hide(Actor006)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_005)
	Camera005 = SetTemplate("Actor005",25,CharaPos110111_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_007)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ん～どのメンズも素敵だけどそろそろカワイイ男のコが来そうな予感！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020002")

	open_select_window_tag(Actor001,"Normal","CO_101063_03020004","CO_101063_03020005","CO_101063_03020006")
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
lookat_delay_weight(Actor001,0.8,0,0.5,0,0.8)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いつもこうやって<br>通行人の観察をしてるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020008")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:そうよ、素敵なメンズを見つけたときのトキメキがたまらなくって
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020009")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:どんな疲れも一瞬で吹き飛んでいくわ！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight(Actor001,0.8,0,0.5,0,0.8)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どういう男がタイプなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020012")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ノワールちゃんみたいな正統派もいいし女の子みたいにちっちゃい子もキューってなるし
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020013")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:たまには鬼畜メガネに苛めてほしいしリードしてくれそうなオジサマも悪くないわね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020014")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:へ、へえ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020015")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ここに俺は必要なのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020017")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ノワールちゃんにもこの趣味の良さをわかってほしくてね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020018")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（わからなくてもいい…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101063_03020019")

	goto Block1end

::Block1end::
-- ▼直接出力
wait_time(0.6)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あ、ほら、見て見て！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020021")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.8)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、トリスタンか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020022")

-- ▼直接出力
 --トリスタン登場
CloseTalkWindow()
IN_WALK(Actor003,CharaPos110111_01_006)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("トリスタン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★トリスタン★★:ノワールか、こんなところでなにを…って、うわあああああ！
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101063_03020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:あらぁ～、トリスタンちゃん<br>今日も可愛いわね～
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020025")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ゆっくりお話しましょう？今日はノワールちゃんもいるのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020027")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0031")
-- ▲直接出力

	--★★トリスタン★★:ボクはあなたにもノワールにも用事はない！好きなだけふたりで話せばいいじゃないか！
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101063_03020028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101014_sp_0001_2")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★トリスタン★★:ノワール、キミからもなんとか言ってくれボクまで道連れにするな！
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101063_03020029")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:も～、照れちゃって?そういうところもいいわぁ～?
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020031")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★トリスタン★★:…あっ！向こうからランスロットが歩いてくる！
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","CO_101063_03020033")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor002,1.0)
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,18,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
turn_chara(Actor003,150,0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:ええっ、ランスロットさまっ？どこどこ？どこなのっ！？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020034")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
 --トリスタン退場
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003, 0, 0, -15, 3)
wait_time(0.7)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,235,0.5)
wait_time(0.7)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:もうっ！どこにもいないじゃない！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020036")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:トリスタンちゃんったらノワールちゃんがいたから照れてたのかしら
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020037")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:…それともヤキモチかしら<br>私って罪なオンナねえ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020038")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あのトリスタンがたじたじとは…恐ろしい人だ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020039")

-- ▼直接出力
 --暗転して時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_delay_weight(Actor001,0.8,0,0.5,0,0.8)
keep_ik_lookat(Actor001, Actor002, "J_Head")
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:今日も素敵なメンズを<br>たくさん見られて幸せだったわ～
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それは、なにより…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020043")

-- ▼直接出力
PlayPartVoice("子供_男1", "悲しみ")
-- ▲直接出力

	--★★子供（男）★★:うわああ～ん…
	Talk(Actor006,"CHRNAME_NAMELES","speech","N","CO_101063_03020045")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力

	--★★ノワール★★:ん…？<br>こどもの泣き声が…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あっちから聞こえるみたい！<br>行ってみましょう
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020048")

-- ▼直接出力
 --場面転換
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
template2()
set_pos(Actor001,{3.779,0,-16.049})
set_pos(Actor002,{4.090,0,-16.729})
lookat_weight_reset(Actor001)
lookat_weight_reset(Actor002)
Hide(Actor001)
Hide(Actor002)
Appear(Actor004)
Appear(Actor006)
PlayActionDirect(Actor006,"to  Std_Sad02")
SkipDefaultMotion(Actor006)
--子供（男）,NPCNAME_0077 @名前変更
keep_ik_lookat(Actor004,Actor006,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,0.2)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ヴォールス★★:参った<br>こうなってはどうにも…
	Talk(Actor004,"CHRNAME_BORS","speech","L","CO_101063_03020050")

-- ▼直接出力
CloseTalkWindow()
IN_RUN_2P(Actor002,CharaPos110111_03_002,Actor001,CharaPos110111_03_001)
keep_ik_lookat(Actor002,Actor004,"J_Head")
lookat_delay_weight(Actor002,0.5,0.1,0.8,0.2,1.0)
wait_time(0.2)
keep_ik_lookat(Actor001,Actor004,"J_Head")
lookat_delay_weight(Actor001,0.5,0.1,0.8,0.2,1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "激怒")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")

	--★★クリスティーナ★★:オイ！<br>てめえ、子供になにしとんじゃああ！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","N","CO_101063_03020052")

	close_cutin()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0022")
-- ▲直接出力

	--★★子供（男）★★:う、うわああああああああん！<br>お母さああああああああああああん！
	Talk(Actor006,"NPCNAME_0077","speech","L","CO_101063_03020054")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:…って、ヴォールスちゃんじゃなあい
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020056")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",0.8)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ヴォールス", "驚き")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ヴォールス★★:む。大図書院の…？<br>ノワールもいるのか
	Talk(Actor004,"CHRNAME_BORS","speech","L","CO_101063_03020057")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ヴォールス", "悲しみ")
-- ▲直接出力

	--★★ヴォールス★★:迷子を見つけたので保護しようとしたんだが<br>怖がられてしまってな
	Talk(Actor004,"CHRNAME_BORS","speech","L","CO_101063_03020058")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",0.8)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:坊や、大丈夫よ<br>このお兄さんは悪い人じゃないわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020059")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor006,"J_Head",0.8)
wait_time(0.2)
keep_delay_ik_lookat(Actor004,Actor006,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0022")
-- ▲直接出力

	--★★子供（男）★★:うわあああああああん！<br>オジサン怖いよ、近寄らないでえええええ！！
	Talk(Actor006,"NPCNAME_0077","speech","L","CO_101063_03020060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:オ、オジッ…！？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020061")

-- ▼直接出力
 --母親登場
CloseTalkWindow()
setup_small_camera_start()
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, true)
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("市民_女2","0012")
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Angry")
-- ▲直接出力

	--★★市民（女）★★:あぁっ、坊や、おいで！
	Talk(Actor005,"NPCNAME_0078","speech","L","CO_101063_03020063")

	PlayAction(Actor006,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0022")
PlayActionDirect(Actor006,"to Wlk")
turn_chara(Actor006,225,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to  Std_Sad02")                     
-- ▲直接出力

	--★★子供（男）★★:お母さあああああああああああん！
	Talk(Actor006,"NPCNAME_0077","speech","L","CO_101063_03020064")

-- ▼直接出力
 --母親＆子供退場
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor005)
Hide(Actor006)
setup_small_camera_start()
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:まあ、なんというか…<br>母親が見つかってよかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020066")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:…うむ
	Talk(Actor004,"CHRNAME_BORS","speech","L","CO_101063_03020067")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力

	--★★クリスティーナ★★:あの子、ギャン泣きしてたわね…<br>悪いことしちゃった…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020069")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力

	--★★クリスティーナ★★:やっぱりどれだけ化粧したところで<br>人間の本質は変えられないのかしら…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020070")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:本質…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03020071")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:あ、ううん！なんでもないわ<br>さ、今日のところは解散しましょ♪
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03020072")

-- ▼直接出力
local trustParam = set_communication_rankup("クリスティーナ_コミュランク", "クリスティーナ_親密度")
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
