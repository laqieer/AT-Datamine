-- このluaスクリプトは、CO_101063_1003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_006)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
turn_lookat(Actor003,Actor002,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
keep_ik_lookat(Actor005,Actor002,"J_Head")
lookat_weight(Actor005,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:あ、クリスちゃんだ！みんな、クリスちゃん来たよ！
	Talk(Actor004,"NPCNAME_0146","speech","L","CO_101063_10030002")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:クリスさん、あの、これ…
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_10030004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:本は俺からだよ<br>あのあと自分で何冊か本を買って読んで
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10030006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
wait_time(0.1)
play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
wait_time(0.1)
play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
wait_time(1)
-- ▲直接出力

	--★★クリスティーナ★★:本と…コスメグッズ？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10030008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:本は俺からだよ<br>あのあと自分で何冊か本を買って読んで
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_10030009")


	--★★キャメロット騎士学術院（男）★★:面白かったヤツを持ってきた大図書院に寄贈するよ
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_10030010")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:他のみんなにも読んでもらいたいからさ
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_10030011")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.6)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子1", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:コスメグッズはあたしたちから<br>ロンディニウムで買ってきた新作だよ！
	Talk(Actor004,"NPCNAME_0146","speech","L","CO_101063_10030012")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:みんな、ありがとう…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10030013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:お礼を言うのはこっちだよ
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_10030014")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("男子1", "喜び")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:アストラット郷ではかっこよかったよ！野盗たちをバッタバッタやっつけてさ！
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_10030015")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子1", "喜び")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:クリスちゃん、あんなこともできるんだね！マジでシビれちゃった～！
	Talk(Actor004,"NPCNAME_0146","speech","L","CO_101063_10030016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あ、あなたたち…！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10030017")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.7)
wait_time(0.4)
-- ▲直接出力

	--★★ノワール★★:化粧とか過去とか関係ないんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10030018")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:みんなのなかにいたのはクリスさんなんだ胸を張って。司書『クリスティーナ』
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10030019")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子2", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:あー、クリスちゃんあの、これ…ごめんなさい！
	Talk(Actor005,"NPCNAME_0147","speech","L","CO_101063_10030021")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
wait_time(0.1)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:これは…未返却の本ね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10030023")

-- ▼直接出力
PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:期限過ぎたのに返し損ねちゃって怒られるの怖いから黙ってようと思ったけど…
	Talk(Actor005,"NPCNAME_0147","speech","L","CO_101063_10030024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:クリスちゃんが本をすごく大切にしているのわかったから…
	Talk(Actor005,"NPCNAME_0147","speech","L","CO_101063_10030025")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("女子2","0037")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:やっぱりちゃんと返さなきゃ、って思ったの！　本当にごめんなさい！！
	Talk(Actor005,"NPCNAME_0147","speech","L","CO_101063_10030026")

-- ▼直接出力
PlayPartVoiceDirect("クリスティーナ","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ふふ、ありがとう次から気を付けてくれればいいのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10030028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:え、うそ、優しい！俺のときと対応が違いすぎない！？
	Talk(Actor003,"NPCNAME_0001","speech","L","CO_101063_10030029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クリスティーナ★★:あなた、自分が何度延滞したかわかってる？<br>仏の顔もなんとやら、って言うでしょ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10030030")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ10_4")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
