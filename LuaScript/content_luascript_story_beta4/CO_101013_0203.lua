-- このluaスクリプトは、CO_101013_0203.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_003)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("市民_男1", "悩む")
-- ▲直接出力

	--★★市民（男）★★:うーん、見てないなあ
	Talk(Actor004,"NPCNAME_0195","speech","N","CO_101013_02030002")

-- ▼直接出力
Appear(Actor005)
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,0.5, 0.5, 0.7, 0.5)
keep_ik_lookat(Actor002,Actor005, "J_Head")
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,0.5, 0.5, 0.7, 0.5)
keep_ik_lookat(Actor001,Actor005, "J_Head")
wait_time(WAIT_TIME_SHORT)
setup_small_camera_end()

-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_女2", "肯定2")
-- ▲直接出力

	--★★市民（女）②★★:どうしたの、ガウェインちゃん誰かをさがしてるの？
	Talk(Actor005,"NPCNAME_0196","speech","N","CO_101013_02030004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:ああ、迷子をさがしてるんだけどさ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02030005")

-- ▼直接出力
  --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_女2", "挨拶")
-- ▲直接出力

	--★★市民（女）②★★:それっぽい子供ならさっき街の出口のほうで見たわよ
	Talk(Actor005,"NPCNAME_0196","speech","N","CO_101013_02030007")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:本当か！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_02030008")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:行ってみよう、ガウェイン！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_02030009")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ2_4")
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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
