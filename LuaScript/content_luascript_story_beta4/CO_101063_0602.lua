-- このluaスクリプトは、CO_101063_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera002 = SetTemplate("Actor002",90,CharaPos112021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera004 = SetTemplate("Actor004",210,CharaPos112021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_004)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
turn_lookat(Actor001,Actor003,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:あ、こっちこっち！
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_06020002")


	--★★ノワール★★:マーケットにあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_06020003")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:どうやらここで売られていたらしいのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_06020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:行商人の売り物のなかにあったんだけど<br>そのとき、ちょっと手持ちが足りなくて
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_06020005")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）★★:お金を家に取りに戻ってたら<br>商人が消えちゃったんだ
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_06020006")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:間違いなく、失くした本だったのか？<br>同じ内容だけど別の本って可能性もあるだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_06020007")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）★★:いいや。カバーの汚れが同じ場所にあった<br>あれは絶対に大図書院で借りた本だよ
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_06020008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なるほどな。でも、行商人か…<br>よそに流れたら見つけるのは大変になるぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_06020009")

-- ▼直接出力
 --マルイルの向きを調整
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,310,0.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★マルイル★★:それって、そこにいた悪そうな商人ですよね<br>大図書院の本の横流しですか？ひどい話だ
	Talk(Actor004,"CHRNAME_MARIL","speech","L","CO_101063_06020011")

-- ▼直接出力
keep_ik_lookat(Actor001,Actor004,"J_Head")
lookat_delay_weight(Actor001,0.5,0.1,0.8,0.2,1.0)
wait_time(0.2)
keep_ik_lookat(Actor002,Actor004,"J_Head")
lookat_delay_weight(Actor002,0.5,0.1,0.8,0.2,1.0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:マルイル！<br>見てたのなら、行商人の行き先を知らないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_06020012")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルイル★★:ほんの少し前に荷物をまとめて移動したようです<br>アストラット郷へ行く、って言ってたかなあ
	Talk(Actor004,"CHRNAME_MARIL","speech","L","CO_101063_06020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:マルイルちゃん、ありがとう！<br>あとでお礼にコスメを山ほど買ってあげるわ～
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_06020014")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera004)
end
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マルイル★★:はい、たくさん仕入れておきますね！
	Talk(Actor004,"CHRNAME_MARIL","speech","L","CO_101063_06020015")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ちょっと面倒な話になりそうね<br>ノワールちゃん、ついてきてくれる？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_06020017")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>それじゃ、ここからは俺たちに任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_06020018")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ごめん、俺のせいで…
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_06020019")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★クリスティーナ★★:いいえ、気にしないでこれも司書の仕事よ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_06020021")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ6_3")
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
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
