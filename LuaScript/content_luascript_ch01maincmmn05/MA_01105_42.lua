-- このluaスクリプトは、MA_01105_42.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation04","DuelCommonFormation04_h")
Include("content_adv_advsmall_duelcommonformation04","TemplateDuelCommonFormation04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_002)
	Camera002 = SetTemplate("Actor002",-360,CharaPosDuelCommonFormation04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_011)
	InitializeTemplateRandomCameraDuelCommonFormation04()
	InitializeTemplateDuelCommonFormation04()
-- ▼直接出力
   Ef_0001     = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
    set_pos(Ef_0001,{-0.949,0,-2.572})
   Ef_0002     = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
    set_pos(Ef_0002,{-0.949,0,-2.572})
set_scale(Ef_0001,{1.3,1.3,1.3})
set_scale(Ef_0002,{1.3,1.3,1.3})
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101080013)
	Actor001 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","002","101001002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101042","001","101042001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera011)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor001, {1.0, 0.5, 1.0, 0.5} ,1.0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.7)
-- ▲直接出力

	--★★モーロノエー02★★:やあっぱり、継承者だったようね
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","R","MA_01105_420002")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
on_active(Ef_0001)
wait_time(1.4)
Appear(Actor001)
wait_time(0.8)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-172.5,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:『魔女』モーロノエー！
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01105_420004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
	change_face(Actor001,"Smile")

	--★★モーロノエー★★:<ruby=ファースト・キラーズ>最初の武器</ruby>、ティルフィング<br>こんなところまで御苦労様
	Talk(Actor001,"CHRNAME_SISTERS_1","speech","R","MA_01105_420005")

	change_face(Actor002,"Anger")

	--★★ティルフィング★★:狙いはなんです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01105_420007")


	--★★モーロノエー★★:皆がどこへ行きたいかによるわ
	Talk(Actor001,"CHRNAME_SISTERS_1","speech","R","MA_01105_420008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ティルフィング★★:…『継承者』の選択次第と
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01105_420009")

	change_face(Actor001,"Normal")

	--★★モーロノエー★★:可哀想にねえ<br>貴方の運命は決まっているのに
	Talk(Actor001,"CHRNAME_SISTERS_1","speech","R","MA_01105_420010")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Smile")

	--★★モーロノエー★★:本当の武器が現れたとき<br>最初の武器はどうなるかなんて、ねえ
	Talk(Actor001,"CHRNAME_SISTERS_1","speech","R","MA_01105_420011")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
on_active(Ef_0002)
wait_time(1.5)
Hide(Actor001)
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ティルフィング★★:…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01105_420013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
   load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
   load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, false)
	InitializeLoad_Preload()
	load_duel_scene_preload(101080013)
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","002","101001002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101042","001","101042001")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
