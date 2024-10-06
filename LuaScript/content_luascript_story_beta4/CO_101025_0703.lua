-- このluaスクリプトは、CO_101025_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_02","112041_02_h")
Include("content_adv_advsmall_112041_02","Template112041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_003)
	Camera002 = SetTemplate("Actor002",155,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	Camera003 = SetTemplate("Actor003",-150,CharaPos112041_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_005)
	Camera005 = SetTemplate("Actor005",95,CharaPos112041_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_001)
	Camera006 = SetTemplate("Actor006",80,CharaPos112041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_002)
	InitializeTemplateRandomCamera112041_02()
	InitializeTemplate112041_02()
-- ▼直接出力
set_pos(Actor003,{0,0,3.5})
-- ▲直接出力
-- ▼直接出力
Camera001 = set_chara_pos_resetting(Actor001,{1.2,0,1.1, 70})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_weight(Actor003,0.5,0.03,0.7,0)
keep_ik_lookat(Actor003,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor004, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Surp")
PlayActionDirect(Actor002,"to  Std_Sad01")
PlayPartVoice("ジェラルド", "肯定3")
-- ▲直接出力

	--★★酒場店主★★:ジャスパーか…<br>たしかにここのところ見てないですね
	Talk(Actor004,"NPCNAME_0263","speech","L","CO_101025_07030002")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★酒場店主★★:みなさんはどうです？
	Talk(Actor004,"NPCNAME_0263","speech","L","CO_101025_07030003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera006)
keep_delay_ik_lookat(Actor003,Actor005,"J_Head",1)
PlayActionDirect(Actor001,"to Std_Loop")
turn_chara(Actor001,280,0.5)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor002,-125,0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男1", "悩む")
-- ▲直接出力

	--★★市民（男）★★:んー。しばらく前に会ったときによ<br>「ナントカって教団にツテができそう」だとか
	Talk(Actor005,"NPCNAME_0235","speech","N","CO_101025_07030004")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★市民（男）★★:「実力を示して幹部に取り立ててもらえれば<br>魔力を取り戻せるかも」なんて言ってたぜ
	Talk(Actor005,"NPCNAME_0235","speech","N","CO_101025_07030005")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_男1", "落胆")
-- ▲直接出力

	--★★市民（中年男）②★★:あいつ、冒険者を廃業してから<br>なにやっても上手くいってなかったしなあ
	Talk(Actor006,"NPCNAME_0236","speech","N","CO_101025_07030006")


	--★★市民（中年男）②★★:妙な連中に騙されて<br>身を持ち崩してなきゃいいけどよ
	Talk(Actor006,"NPCNAME_0236","speech","N","CO_101025_07030007")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "落胆")
-- ▲直接出力

	--★★クレア★★:そう…<br>ジャスパーが行きそうな場所は知らない？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07030008")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男1", "否定")
-- ▲直接出力

	--★★市民（男）★★:知らねえなあ。アイツ、家族はみんな死んで<br>知り合いもほとんどいなかったしな
	Talk(Actor005,"NPCNAME_0235","speech","N","CO_101025_07030009")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:助かったよ、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07030010")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ7_4")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
