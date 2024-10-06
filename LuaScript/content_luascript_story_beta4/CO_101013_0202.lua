-- このluaスクリプトは、CO_101013_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("市民_男1", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★市民（男）②★★:よう、ガウェイン！こないだは仕事手伝ってくれてありがとな！
	Talk(Actor004,"NPCNAME_0193","speech","N","CO_101013_02020002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:大したことねーってまた困ったら言ってくれ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02020003")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_女2", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★市民（中年女）②★★:ガウェインちゃん、この前はありがとうね重い荷物をうちまで運んでくれて
	Talk(Actor005,"NPCNAME_0194","speech","N","CO_101013_02020004")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力

	--★★ガウェイン★★:なーに。あの程度お礼言われるほどのことじゃねーよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02020005")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:人気者だな、ガウェインは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02020007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ラグネル★★:そりゃあログレスのヒーローだもんね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_02020008")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:俺なんかまだまだあの人らには全然追いついてねーよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02020009")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor006,Camera006,EntryData112021_01_05,CameraAssetBundleName112021_01,CameraPos112021_01_105)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002,{1.0, 0.03,1.0,0.6},0.4)
keep_delay_ik_lookat(Actor002,Actor006,"J_Head",0.4)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:…ん？あの人どうしたんだろう
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002,{0.4,0.03,0.7,0.6},0.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:声をかけてみようよ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_02020012")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_女1", "悲しみ")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★市民（女）★★:あの…男の子を見かけませんでしたか？<br>息子なんですが、はぐれてしまって…
	Talk(Actor006,"NPCNAME_0182","speech","N","CO_101013_02020014")


	--★★ラグネル★★:見てないですね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_02020015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いなくなったのはこのあたりですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_女1", "肯定2")
-- ▲直接出力

	--★★市民（女）★★:マーケットで買い物をしていたんですけど気づいたら姿が見えなくなっていたんです
	Talk(Actor006,"NPCNAME_0182","speech","N","CO_101013_02020017")

	PlayAction(Actor006,"to  Std_Sad01")

	--★★市民（女）★★:実はこの街には最近来たばかりで息子が行きそうな場所もわからなくて…
	Talk(Actor006,"NPCNAME_0182","speech","N","CO_101013_02020018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:迷子さがしならまかせろ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02020020")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:ストーップ！！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_02020021")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:おい、ラグネル！止めんなよ！？俺は今すぐ迷子をさがしに…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02020023")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ラグネル★★:その迷子のことなーんも知らないのにどうさがすっていうの？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_02020024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ラグネルの言うとおりだまずはその子の特徴を聞かないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02020025")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:んー…たしかにそうかよし、息子さんのことを教えてくれ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02020026")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:私たち、キャメロット騎士学術院の生徒でこのあたりのことは詳しいんです
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_02020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お役に立てると思います
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02020028")

-- ▼直接出力
PlayPartVoice("市民_女1", "驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★市民（女）★★:いいんですか？
	Talk(Actor006,"NPCNAME_0182","speech","N","CO_101013_02020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:あぁ、まかせてくれ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02020030")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_女1", "悩む")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★市民（女）★★:息子の名前はトム、年齢は７歳です髪の色は――
	Talk(Actor006,"NPCNAME_0182","speech","N","CO_101013_02020031")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:よし、じゃあトムをさがすとするか！お母さんはここで待っててくれ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02020033")

	PlayAction(Actor006,"to  Std_Sad02")

	--★★市民（女）★★:でも…
	Talk(Actor006,"NPCNAME_0182","speech","N","CO_101013_02020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:もしかするとトムが戻ってくるかもしれない誰か知っている人が待っていたほうが安心です
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02020035")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_女1", "肯定2")
-- ▲直接出力

	--★★市民（女）★★:そうですね…それでは私はここで待たせていただきますね
	Talk(Actor006,"NPCNAME_0182","speech","N","CO_101013_02020036")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ2_3")
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
