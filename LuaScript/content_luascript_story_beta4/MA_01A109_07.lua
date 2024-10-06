-- このluaスクリプトは、MA_01A109_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_008)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{-1.09, -0.003, -8.95})
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
-- ▲直接出力
-- ▼直接出力
set_pos_object(lookoj,CharaPos110111_02_001[1],1.5,CharaPos110111_02_001[3])
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor004,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
character_in_move_walk(Actor001,CharaPos001,3,0.25)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("市民_女1", "挨拶")
-- ▲直接出力

	--★★市民（女）★★:見て
	Talk(Actor002,"NPCNAME_0159","speech","N","MA_01A109_070002")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor003,Actor001,0.5)
turn_lookat(Actor004,Actor001,0.5)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★エレイン★★:………
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A109_071001")

-- ▼直接出力
OpenFirstAppearance(Actor001)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("市民_女2", "怒り")
-- ▲直接出力

	--★★市民（女）②★★:キャメロット学園の制服よ<br>よくものうのうと…
	Talk(Actor003,"NPCNAME_0160","speech","N","MA_01A109_070003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("市民_男1", "悩む")
-- ▲直接出力

	--★★市民（男）★★:だけどログレスがやったとは<br>限らないんだろう…？
	Talk(Actor004,"NPCNAME_0161","speech","N","MA_01A109_070004")

-- ▼直接出力
 --PlayPartVoice("市民_女1", "苦しみ")
-- ▲直接出力

	--★★市民（女）★★:じゃあどこにぶつければいいのよ<br>やるせないじゃない
	Talk(Actor002,"NPCNAME_0159","speech","N","MA_01A109_070005")

	PlayAction(Actor003,"to  Std_Angry")

	--★★市民（女）②★★:どこに吐き出せばいいのよ…！
	Talk(Actor003,"NPCNAME_0160","speech","N","MA_01A109_070006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")

	--★★エレイン★★:…──っ
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A109_070007")

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
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
