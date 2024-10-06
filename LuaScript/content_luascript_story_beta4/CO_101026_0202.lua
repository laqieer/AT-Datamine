-- このluaスクリプトは、CO_101026_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_02","110191_02_h")
Include("content_adv_advsmall_110191_02","Template110191_02_h")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110191_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110191_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110191_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110191_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110191_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_02,CameraPos110191_02_007)
	InitializeTemplateRandomCamera110191_02()
	InitializeTemplate110191_02()
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110191_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_003)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:やあやあ、庶民のみんな<br>元気してるかい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020002")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("現代男子", "肯定")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★キャメロット騎士学術院（男）★★:あっ、パーシヴァルくん！
	Talk(Actor005,"NPCNAME_0151","speech","L","CO_101026_02020003")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Smile")

	--★★キャメロット騎士学術院（男）★★:パーシヴァルくんこそ元気だったかい？<br>最近、学園で姿を見ないこと多いし心配したよ
	Talk(Actor005,"NPCNAME_0151","speech","L","CO_101026_02020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力

	--★★パーシヴァル★★:心配ありがとう<br>たしかにここのところ多忙だったけれど
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★パーシヴァル★★:ボクは円卓の騎士だからね<br>そうカンタンに体調を崩したりはしないさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020007")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020009")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子2", "肯定3")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★キャメロット騎士学術院（女）★★:少し前の乗馬の授業、１着おめでとう！<br>手に汗握る展開だったね～
	Talk(Actor006,"NPCNAME_0146","speech","L","CO_101026_02020010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力

	--★★パーシヴァル★★:なあに、当然の結果だよ<br>ボクとゴーン・ウィズ・ザ・ウィンドは人馬一体
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★パーシヴァル★★:どんなに荒れた地でも、どんなに険しい谷でも<br>風より疾く駆け抜けてみせよう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ゴーン・ウィズ…ってなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020015")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:パーシヴァルくんの愛馬の名前だよ
	Talk(Actor003,"NPCNAME_0217","speech","L","CO_101026_02020016")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:パーシヴァルくん、聞いてよ！
	Talk(Actor007,"NPCNAME_0147","speech","L","CO_101026_02020017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("現代女子", "怒り")
-- ▲直接出力
	change_face(Actor008,"Anger")

	--★★キャメロット騎士学術院（女）③★★:待って、私の話が先よ！
	Talk(Actor008,"NPCNAME_0148","speech","L","CO_101026_02020018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:おいおい、焦る必要はないよ<br>順番に全員の話を聞くからさ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020019")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.0)
lookat_delay_weight(Actor004, {1.0, 0.08, 0.5, 0.3} , 1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:どうしたの、ノワール？
	Talk(Actor004,"NPCNAME_0218","speech","L","CO_101026_02020021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101026_02020023","CO_101026_02020024")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、なんというか、意外だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020026")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あいつ、妙に気取ってるし<br>貴族がどうとか庶民がどうとかうるさいし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020027")

	change_face(Actor001,"Sad")

	--★★ノワール★★:みんなから<br>よく思われてないんじゃないかと思ってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020028")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★キャメロット騎士学術院（男）③★★:あははっ！
	Talk(Actor004,"NPCNAME_0218","speech","L","CO_101026_02020029")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor003 , 0.6)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,24,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子2", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★キャメロット騎士学術院（男）②★★:それは勘違いだよ、ノワール
	Talk(Actor003,"NPCNAME_0217","speech","L","CO_101026_02020030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ、パーシヴァルって人気者なんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020032")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor003 , 0.6)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,24,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★キャメロット騎士学術院（男）②★★:意外か？
	Talk(Actor003,"NPCNAME_0217","speech","L","CO_101026_02020033")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えっ？あー、いや…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020034")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★キャメロット騎士学術院（男）③★★:勘違いされることもたまにあるけど<br>パーシヴァルくんは学園の人気者だよ
	Talk(Actor004,"NPCNAME_0218","speech","L","CO_101026_02020035")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺にはやたらと上から目線だから<br>みんなに対してそうなのかと思ってたよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020037")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★キャメロット騎士学術院（男）②★★:上から目線？<br>それは違うなあ、ノワール
	Talk(Actor003,"NPCNAME_0217","speech","L","CO_101026_02020038")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:パーシヴァルくんはいつも俺たちのことを<br>同じ目線で見てくれてる
	Talk(Actor003,"NPCNAME_0217","speech","L","CO_101026_02020039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★キャメロット騎士学術院（男）③★★:僕たちのことを第一に考えてくれるよ
	Talk(Actor004,"NPCNAME_0218","speech","L","CO_101026_02020040")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）③★★:強くて、明るくて、優しい<br>円卓の騎士に名を連ねているのは伊達じゃない
	Talk(Actor004,"NPCNAME_0218","speech","L","CO_101026_02020041")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:そうなのか…<br>あいつのことを誤解してたな、俺
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020042")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
set_enable_auto_lookat_all(true)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
lookat_delay_weight_reset(Actor003 , 1)
lookat_delay_weight_reset(Actor004 , 1)
template2()
--キャメロット騎士学術院（男）②,NPCNAME_0243 @名前変更
--キャメロット騎士学術院（男）③,NPCNAME_0246 @名前変更
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:待たせてしまってすまない<br>彼らに挨拶をしないとと思ってね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020044")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

	--★★パーシヴァル★★:では、見回りに戻ろうか<br>ダニー、ジャン
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020045")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★キャメロット騎士学術院（男）③★★:わかったよ、パーシヴァルくん
	Talk(Actor004,"NPCNAME_0246","speech","L","CO_101026_02020047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:そういえば食堂のほうで揉め事が起きてるって<br>さっき誰かが言ってたよ
	Talk(Actor003,"NPCNAME_0243","speech","L","CO_101026_02020049")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:やれやれ。心が余裕のない人間は<br>すぐにケンカで解決しようとするねえ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020050")

-- ▼直接出力
PlayPartVoice("パーシヴァル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:よし、ボクが話を聞いてやろうじゃないか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ノワール。キミは大図書院に行って<br>義姉さんにおやつの準備をするよう伝えてくれ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020053")


	--★★パーシヴァル★★:食堂のトラブルを片付けたら<br>おやつの時間にしたいからね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020054")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:………は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_02020055")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★パーシヴァル★★:なにをボーッとしているんだ<br>「行動は迅速に」は、付き人の鉄則だろう！？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_02020056")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:（なんか、俺だけ扱いが違わないか…？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101026_02020057")

-- ▼直接出力
local trustParam = set_communication_rankup("パーシヴァル_コミュランク", "パーシヴァル_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_02)
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
