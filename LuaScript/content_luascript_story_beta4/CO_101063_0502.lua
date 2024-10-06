-- このluaスクリプトは、CO_101063_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_02","110161_02_h")
Include("content_adv_advsmall_110161_02","Template110161_02_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110161_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110161_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_002)
	InitializeTemplateRandomCamera110161_02()
	InitializeTemplate110161_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子1", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:げ…、ノワールもしかして、本の催促じゃないよな
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_05020002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:そのもしかしてだよわかってるなら滞納するなって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05020003")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）★★:こ、今回は違うんだーっ！
	Talk(Actor002,"NPCNAME_0001","speech","L","CO_101063_05020004")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,260,0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002, -3, 0, 4, 1)
wait_time(0.4)
Hide(Actor002)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-140,0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なっ…おい、待て！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05020006")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-110,0.2)
wait_time(0.2)
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001, -4, 0, 2, 1.4)
wait_time(1.4)
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ5_3")
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
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
