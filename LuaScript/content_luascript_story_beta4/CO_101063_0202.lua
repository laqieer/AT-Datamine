-- このluaスクリプトは、CO_101063_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",-157,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera005 = SetTemplate("Actor005",-65,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1003_01_Controller","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("402002","001","402002001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:ふう、これで全部片付いたわね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:すごいな…あれだけの量の本を一度に運ぶなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:持ち方のコツさえつかめば誰にでもできることよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020004")

	open_select_window_tag(Actor001,"Normal","CO_101063_02020006","CO_101063_02020007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:コツというかそもそもの筋力が違う気が…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020009")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:そうかしら？ノワールちゃんとたいして違わないわよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020010")

-- ▼直接出力
CloseTalkWindow()
PlayPartVoiceDirect("クリスティーナ","0010")
	change_face(Actor002,"Smile")
wait_time(2)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:あ、あまりジロジロ見ないでほしい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなコツがあるなら聞きたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:１冊ずつ背表紙が逆になるよう積むことね同じ向きで積むと少しずつ傾いて危ないから
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020015")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（それで安定性が増しても<br>量を運ぶには筋力が必要じゃないだろうか…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101063_02020016")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:クリスちゃーん！<br>今、本返してもヘーキ？
	Talk(Actor003,"NPCNAME_0146","speech","L","CO_101063_02020018")

-- ▼直接出力
 --女生徒登場
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
turn_chara(Actor002,-170,0)
turn_chara(Actor001,140,0)
Appear(Actor003)
Appear(Actor004)
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,0.2)
wait_time(0.1)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
setup_small_camera_start(Camera003)
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:クリスちゃんイチオシの本、読み終わったよ！すっごい、よかった！
	Talk(Actor003,"NPCNAME_0146","speech","L","CO_101063_02020019")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
setup_small_camera_end(Camera003)
PlayPartVoice("クリスティーナ", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:でしょぉ～～～っ！？王子様がホーントかっこいいのよねえ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020021")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:あなたもなにか用事があるのかしら？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020023")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:あ、ウチは大丈夫…かなあはは
	Talk(Actor004,"NPCNAME_0147","speech","L","CO_101063_02020024")


	--★★クリスティーナ★★:そう？なにか探している本があるなら聞いてね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020025")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:大図書院の蔵書量はブリテンでもトップクラス！たいていの本は読めるはずよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020026")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:ところで最近出たリップはチェックした？あれ、すっごくイイわよ！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020028")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:え、マジ―！クリスちゃんが言うなら本物じゃん
	Talk(Actor003,"NPCNAME_0146","speech","L","CO_101063_02020029")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:今月ピンチだけど買っちゃおうかなー
	Talk(Actor004,"NPCNAME_0147","speech","L","CO_101063_02020030")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:（クリスさん、女子に人気があるんだな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101063_02020031")

-- ▼直接出力
se_play("SE_ADV_CO_101063_0202_Cat_Barks")
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera090)
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれっなんでこんなところにネコが…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020033")

-- ▼直接出力
lookat_delay_weight_reset(Actor002,0.5)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,115,0.1)
wait_time(0.1)
PlayActionDirect(Actor002,"to  Std_Angry")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "激怒")
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,120,0.15)
wait_time(0.15)
PlayActionDirect(Actor005,"to Run")
slidemove(Actor005, 2, 0, 10, 2)
wait_time(0.7)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クリスティーナ★★:なにぃ、まーた悪さする気か！？<br>つまみ出してやるッ！！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020035")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
set_rot(Actor002,{0,213,0})
Hide(Actor005)
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor001,Actor002,"J_Head")
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:私ったらまたやっちゃった…恥ずかしい
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020037")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:どうやら私のお気に入りの香水がねネコちゃんを引き寄せちゃうみたいなの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020038")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "苦しみ")
-- ▲直接出力

	--★★クリスティーナ★★:ネコちゃんに好かれるのはいいんだけど一度大図書院で走り回られちゃってね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あはは、は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020041")


	--★★キャメロット騎士学術院（女）★★:あはは、うちのお父さんの千倍怖いえっと…じゃあ、そろそろ行こうか
	Talk(Actor003,"NPCNAME_0146","speech","L","CO_101063_02020042")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera004)
end
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（女）②★★:あ、うん…
	Talk(Actor004,"NPCNAME_0147","speech","L","CO_101063_02020044")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
Hide(Actor004)
setup_small_camera_start()
turn_chara(Actor001,100,0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力

	--★★クリスティーナ★★:あら…怖がらせちゃったかしら
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101063_02020048","CO_101063_02020049")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:きっと大丈夫だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020051")

	change_face(Actor001,"Normal")

	--★★ノワール★★:突然だったからちょっと驚いただけじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:そうだといいけど…ありがとう、ノワールちゃん
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020053")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺も…ちょっと、怖かった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020055")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:えええっ、ノワールちゃんも！？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020056")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:そんなつもりはなかったんだけど…ごめんなさいね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020057")

	goto Block2end

::Block2end::
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:もう、私の悪いクセね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020059")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★クリスティーナ★★:本が傷ついたり手荒に扱われたりしそうになるとついつい我を忘れちゃうの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020060")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:い、いいコトだと思う…よ、俺は
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:さて、ノワールちゃん、今日は助かったわまたなにかあったら頼んでいいかしら？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_02020062")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、もちろんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_02020063")

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
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("402002","001","402002001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
