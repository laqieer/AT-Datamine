-- このluaスクリプトは、CO_101063_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
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
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あら、ちょーどいいとこにノワールちゃん、手が空いてたりしな～い？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01010002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:今？ま、まあ、空いてるといえば空いてるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ホント！？それじゃあちょっと頼まれてちょうだい
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01010004")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:本の返却を１週間以上忘れている子がいてね貸出予約も何件か入ってるから
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01010005")


	--★★クリスティーナ★★:返してくれるようにお願いに行こうと思ってたんだけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01010006")

	PlayAction(Actor002,"to  Std_Worry")

	--★★クリスティーナ★★:急な用事ができちゃってここから離れられないのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01010007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:ノワールちゃん私の代わりに行ってきてもらえないかしら？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_01010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:そのくらいならお安い御用だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_01010009")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ1_2")
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
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
