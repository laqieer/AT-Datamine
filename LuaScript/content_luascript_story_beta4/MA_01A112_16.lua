-- このluaスクリプトは、MA_01A112_16.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_09","111012_09_h")
Include("content_adv_advsmall_111012_09","Template111012_09_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111012_09_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111012_09,CameraPos111012_09_012)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111012_09_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111012_09,CameraPos111012_09_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111012_09_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111012_09,CameraPos111012_09_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111012_09_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111012_09,CameraPos111012_09_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111012_09_001,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111012_09,CameraPos111012_09_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111012_09_002,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111012_09,CameraPos111012_09_002)
	InitializeTemplateRandomCamera111012_09()
	InitializeTemplate111012_09()
-- ▼直接出力
set_pos(Actor001,{6.456,0,18.223})
set_pos(Actor002,{4.9270,0,19.091})
set_pos(Actor005,{-8,0,18})
set_pos(Actor006,{-5.93,0,19.33})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
set_common_look_at(Actor003,Actor002)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
wait_time(0.2)
PlayActionDirect(Actor006,"to Std_Loop") --モーションをずらす用
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001,{0.71, 0, 17.683}, 1.5)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,{0.046, 0, 19.009}, 1)
wait_time(1)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "否定")
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:逃げ場はない
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01A112_160002")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("兵士2", "悲しみ")
-- ▲直接出力

	--★★ローマ兵士_下位★★:ろ、ローマの恥さらしめが…！
	Talk(Actor001,"NPCNAME_0169","speech","N","MA_01A112_160003")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★ローマ兵士_下位_2★★:大陸の本国との連絡すら遮断し<br>今やブリテン内のローマ軍はルーシャスの傀儡…
	Talk(Actor002,"NPCNAME_0170","speech","N","MA_01A112_160004")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("市民_男1", "激怒")
-- ▲直接出力

	--★★ローマ兵士_下位_2★★:皇太子の妄執に<br><ruby=と>憑</ruby>り殺されるつもりはない！
	Talk(Actor002,"NPCNAME_0170","speech","N","MA_01A112_160005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "挨拶")
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:万一、我らが負ければ<br>ログレスがここを制圧する
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01A112_160007")


	--★★ヴェルナルス大将軍★★:そうなれば亡命も叶おう
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01A112_160008")


	--★★ヴェルナルス大将軍★★:我らの敗北を<br>祈っているがいい
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01A112_160010")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★亡命者たち★★:…将軍
	Talk(Actor007,"NPCNAME_0171","speech","N","MA_01A112_160011")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor004,1)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Sad01")
-- ▲直接出力

	--★★ヴェルナルス大将軍★★:その暁には──
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01A112_160012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	system.PreLoadRequest(CameraAssetBundleName111012_09)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
