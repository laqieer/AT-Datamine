-- このluaスクリプトは、CO_101011_0502.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_005)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401018","001","401018001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Sad02")
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("子供_女2", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★子供（女）②★★:うわーん！/おねえちゃんのいじわるー！
	Talk(Actor004,"NPCNAME_0167","speech","N","CO_101011_05020002")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_女1", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★子供（女）★★:もうっ、うるさいっ！/泣いたらここに置いてっちゃうから
	Talk(Actor003,"NPCNAME_0139","speech","N","CO_101011_05020003")

	PlayAction(Actor004,"to  Std_Sad01")

	--★★子供（女）②★★:なくのやめたら/わたしのおねがい、きいてくれる？
	Talk(Actor004,"NPCNAME_0167","speech","N","CO_101011_05020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★子供（女）★★:…うん<br>聞いたげるから
	Talk(Actor003,"NPCNAME_0139","speech","N","CO_101011_05020005")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("子供_女2", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★子供（女）②★★:えへへっ/おねえちゃん、だーいすき
	Talk(Actor004,"NPCNAME_0167","speech","N","CO_101011_05020007")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
Hide(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力

	--★★ギネヴィア★★:おねえちゃん、だーいすき/…かぁ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_05020010")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:なんでもない/にししっ♪
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_05020011")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ギネヴィア_ランクアップ5_3")
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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401018","001","401018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
