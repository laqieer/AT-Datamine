-- このluaスクリプトは、MA_01A109_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-84,CharaPos110031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_005)
	Camera003 = SetTemplate("Actor003",103,CharaPos110031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_002)
	Camera004 = SetTemplate("Actor004",175,CharaPos110031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_003)
	Camera005 = SetTemplate("Actor005",135,CharaPos110031_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_007)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{8.79, 0, -24.93})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{10.34, 0, -23.85})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{9.31, 0, -24.13})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110031)
	Actor001 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:『アストラットの美姫』？
	Talk(Actor003,"NPCNAME_0151","speech","N","MA_01A109_080002")

-- ▼直接出力
 --PlayPartVoice("女子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:ホラ、生徒会長の妹さん
	Talk(Actor004,"NPCNAME_0146","speech","N","MA_01A109_080003")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("女子2", "肯定3")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:声かけてみようか
	Talk(Actor005,"NPCNAME_0147","speech","N","MA_01A109_080004")

	PlayAction(Actor004,"to  Std_Talk")

	--★★キャメロット騎士学術院（女）★★:ロンディニウム虐殺の生き残りだって
	Talk(Actor004,"NPCNAME_0146","speech","N","MA_01A109_080005")

	PlayAction(Actor005,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("女子2", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）③★★:結局ログレスがやったっていうのは本当なの？
	Talk(Actor005,"NPCNAME_0147","speech","N","MA_01A109_080006")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("男子1", "否定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:だとしたら…<br>どうしたらいいんだよ俺たち
	Talk(Actor003,"NPCNAME_0151","speech","N","MA_01A109_080007")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("女子1", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:真偽は明らかじゃないけど<br>彼女らはなんにもできず逃げ帰ってきたんでしょ
	Talk(Actor004,"NPCNAME_0146","speech","N","MA_01A109_080008")

	PlayAction(Actor005,"to  Std_Talk")

	--★★キャメロット騎士学術院（女）③★★:『美姫』なんて名前だけで、結局さ──
	Talk(Actor005,"NPCNAME_0147","speech","N","MA_01A109_080009")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★エレイン★★:………っ！
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A109_080010")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
character_in_move_run_offset(Actor002,CharaPos005,5.0,0,0,1.5,0.15)
turn_lookat(Actor002,Actor001,0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(2,Actor002,"Anger")

	--★★ラシア★★:こっち
	Talk(Actor002,"CHRNAME_RASIA","speech","N","MA_01A109_080012")

-- ▼直接出力
turn_lookat(Actor001,Actor002,0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor002,"Anger")

	--★★エレイン★★:え…？
	Talk(Actor001,"CHRNAME_ELAINE","speech","N","MA_01A109_080013")

-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(110031)
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor005")
MobsNo = 1
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
