-- このluaスクリプトは、CO_101015_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit02_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_014,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_014)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力

	--★★アーサー★★:…さて、キリのいいところまで片付けたし<br>今日はこのくらいにしておこう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04020002")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:俺はちょっと外に出てくる！<br>ではな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04020003")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Appear(Actor003)
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor001,Actor003,"J_Head")
set_enable_auto_lookat(Actor003,false)
lookat_delay_weight(Actor003, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor003,Actor001,"J_Head")
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "怒り")
-- ▲直接出力

	--★★ケイ★★:………アーサーは
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_04020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:今の今までいたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04020006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:仕事がキリのいいところまで片付いたから<br>今日はこのくらいにしておこうって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04020007")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:ほう…？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_04020008")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ケイ", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:…やはり、まだ全然終わってないではないか！<br>勝手にキリをつけて、あの愚弟は！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_04020010")


	--★★ケイ★★:…ノワール
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_04020012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はいはい<br>またアーサーをさがせばいいんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04020013")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_アーサー_ランクアップ4_3")
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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
