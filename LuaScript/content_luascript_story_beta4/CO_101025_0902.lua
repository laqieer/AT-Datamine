-- このluaスクリプトは、CO_101025_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1002_01_Controller","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
lookoj=create_object("kara")
set_pos_object(lookoj,-1.8,0.5,0)
keep_ik_lookat(Actor001, lookoj, "")
keep_ik_lookat(Actor002, lookoj, "")
keep_ik_lookat(Actor003, lookoj, "")
keep_ik_lookat(Actor005, lookoj, "")
lookat_weight(Actor001,0.5,0.03,0.4,0)
lookat_weight(Actor002,0.6,0.03,0.4,0)
lookat_weight(Actor003,0.6,0.03,0.4,0)
lookat_weight(Actor005,0.6,0.03,0.4,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("402001","001","402001001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to Tailwag")
se_play("SE_ADV_CO_101025_0803_Dog_Barks")
-- ▲直接出力

	--★★犬★★:ワン！ワン！
	Talk(Actor004,"NPCNAME_0245","speech","N","CO_101025_09020002")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:そうか、今回もスコーンを頼るわけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:ええ、そうよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09020004")


	--★★クレア★★:ジャスパーを噛んだときに<br>スコーンは衣類の一部をちぎってくれたの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09020005")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayActionDirect(Actor004,"to idle01_Loop")
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",0.7)
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",0.7)
lookat_delay_weight_reset(Actor005,0.7)
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:ジョーイ、捕まっていたときのことを教えて<br>ジャスパーはどこか地名を言っていなかった？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09020006")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("子供_男1", "悩む")
-- ▲直接出力

	--★★子供（男）★★:うーんと…「アッシュリッジの森で<br>俺はもう一度あの日々を…」って言ってたよ
	Talk(Actor005,"NPCNAME_0244","speech","N","CO_101025_09020007")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",1.0)
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:目的地がわかったな<br>頼むぞ、スコーン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09020008")

-- ▼直接出力
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",1.0)
keep_delay_ik_lookat_object(Actor003,lookoj,"kara",1.0)
keep_delay_ik_lookat_object(Actor004,lookoj,"kara",1.0)
PlayActionDirect(Actor004,"to Tailwag")
se_play("SE_ADV_CO_101025_0803_Dog_Barks")
-- ▲直接出力

	--★★犬★★:ワン！ワン！！
	Talk(Actor004,"NPCNAME_0245","speech","N","CO_101025_09020009")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ9_3")
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
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("402001","001","402001001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
