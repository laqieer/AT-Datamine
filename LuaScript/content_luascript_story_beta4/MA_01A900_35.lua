-- このluaスクリプトは、MA_01A900_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_01","111012_01_h")
Include("content_adv_advsmall_111012_01","Template111012_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111012_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111012_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111012_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111012_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_005)
	Camera005 = SetTemplate("Actor009",nil,CharaPos111012_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_002)
	Camera006 = SetTemplate("Actor010",nil,CharaPos111012_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_001)
	Camera007 = SetTemplate("Actor011",nil,CharaPos111012_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111012_01,CameraPos111012_01_003)
	InitializeTemplateRandomCamera111012_01()
	InitializeTemplate111012_01()
-- ▼直接出力
set_chara_pos_resetting(Actor002,{6.38, 0, 1.07,   265.1186})
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
set_chara_pos_resetting(Actor003,{6.38, 0, 1.07,   265.1187})
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
set_chara_pos_resetting(Actor004,{-2.79912, 0, 2.66177,   359.0448})
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Joy")
-- ▲直接出力
-- ▼直接出力
pr1 = setup_prop_object(10130022)
set_pos(pr1,{-6.35, 0, -4.29,   0})
set_rot(pr1,{0,30,0})
-- ▲直接出力
-- ▼直接出力
pr2 = setup_prop_object(10130023)
set_pos(pr2,{1.81, 0, -10.3})
set_rot(pr2,{0,0,0})
-- ▲直接出力
-- ▼直接出力
pr3 = setup_prop_object(10130024)
set_pos(pr3,{-4.75, 0, 2.69})
set_rot(pr3,{0,90,0})
-- ▲直接出力
-- ▼直接出力
pr4 = setup_prop_object(10130025)
set_pos(pr4,{-1.3, 0, -6.7})
set_rot(pr4,{0,70,0})
-- ▲直接出力
-- ▼直接出力
pr5 = setup_prop_object(10130013)
set_pos(pr5,{7.31, 0, -3.95485})
set_rot(pr5,{0,293.5315,0})
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor011,"content_animationpack__common", "HeadPack")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401023","001","401023001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101039","003","101039003")
	Actor006 = InitializeCharacter_2DOnly("101010","001","101010001")
	Actor007 = InitializeCharacter_2DOnly("101030","002","101030002")
	Actor008 = InitializeCharacter_2DOnly("101015","001","101015001")
	Actor009 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor011")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ケイ★★:兵は引き続き城門を固めろ！<br>キャメリアード内の民を絶対に傷つけさせるな！
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A900_350002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
play_head_motion(Actor010, "Nod", 0.3, 1.0, false)
play_head_motion(Actor011, "Nod", 0.3, 1.0, false)
wait_time(1.0)
local movepos = {1.075, 0, 7.32,   314}
turn_lookat_position(Actor009,movepos[1],movepos[2],movepos[3],0.3)
turn_lookat_position(Actor010,movepos[1],movepos[2],movepos[3],0.3)
turn_lookat_position(Actor011,movepos[1],movepos[2],movepos[3],0.3)
PlayActionDirect(Actor009,"to Run")
PlayActionDirect(Actor010,"to Run")
PlayActionDirect(Actor011,"to Run")
wait_time(0.3)
slidemove(Actor009,movepos[1],movepos[2],movepos[3],1.0)
slidemove(Actor010,movepos[1],movepos[2],movepos[3]+0.6,1.0)
slidemove(Actor011,movepos[1],movepos[2],movepos[3]-0.6,1.0)
wait_time(1.5)
Hide(Actor009)
Hide(Actor010)
Hide(Actor011)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★アーサー★★:近くローマが攻勢を仕掛けてくるなら<br>継承者の不在で勝ち目がないのなら
	Talk(Actor008,"CHRNAME_ARTHUR","speech","L","MA_01A900_350004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ケイ★★:国を明け渡すなど無能の証でしかないが<br>継承者が帰還すれば取り返す目算はつく
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A900_350005")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor001,"to Wlk")
turn(Actor001,0,-19, 0,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★フレン★★:ログレス国民全員を<br>キャメリアードへ退避させていたと！？
	Talk(Actor005,"CHRNAME_FREN2","speech","R","MA_01A900_350006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ランスロット★★:学園にバルバロイを攻め入らせ<br>貴様らはそのあとで入城したものと思われるが…
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","MA_01A900_350007")

	change_face(Actor007,"Smile")

	--★★エレイン★★:歯ごたえ<br>なかったでしょうね
	Talk(Actor007,"CHRNAME_ELAINE","speech","L","MA_01A900_350009")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ケイ★★:よく帰って来た<br>継承者
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01A900_350010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130022)
setup_prop_object_preload(10130023)
setup_prop_object_preload(10130024)
setup_prop_object_preload(10130025)
setup_prop_object_preload(10130013)
load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
load_head_animation_preload(Actor011,"content_animationpack__common", "HeadPack")
	InitializeLoad_Preload()
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401023","001","401023001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101039","003","101039003")
	InitializeCharacter_2DOnly_Preload("101010","001","101010001")
	InitializeCharacter_2DOnly_Preload("101030","002","101030002")
	InitializeCharacter_2DOnly_Preload("101015","001","101015001")
	InitializeCharacter_3D_Preload("401035","001","401035001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor011")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111012_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
