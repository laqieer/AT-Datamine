-- このluaスクリプトは、CO_101013_0904.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",100,CharaPos112041_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_weight(Actor001,0.4, 0.1, 0.8, 0.2)
keep_ik_lookat(Actor001,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_weight(Actor002,0.4, 0.2, 0.8, 0.2)
keep_ik_lookat(Actor002,Actor004,"J_Head")
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
	load_area_scene(116044)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ごめんごめん、キッスさん<br>さっきは話の途中で出て行っちゃって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_09040002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:それで、俺たちに用ってなに？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_09040003")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:差出人はわからないんだけどね<br>あなたたちに荷物が届いてるの
	Talk(Actor004,"CHRNAME_KISS","speech","L","CO_101013_09040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:荷物？<br>手紙が入ってるな。えーと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_09040006")

-- ▼直接出力
 --ガウェインの首を調整
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
wait_time(0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_delay_weight(Actor003,1.0,0.5,1.0,0.2,1.3)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:「報酬」<br>なんだこれ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_09040007")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:ノワール、この荷物の中身…<br>入ってる…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_09040009")

-- ▼直接出力
 --ノワールの首を調整
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:入ってるって、なにが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_09040010")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力

	--★★ガウェイン★★:キンイロチョウの入った琥珀…！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_09040011")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ええっ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_09040012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:こんなことしてくれるのは<br>あの人しかいねえ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_09040013")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.25)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:ありがとう、ございます…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_09040014")

-- ▼直接出力
local trustParam = set_communication_rankup("ガウェイン_コミュランク", "ガウェイン_親密度")
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
	load_area_scene_preload(116044)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
