-- このluaスクリプトは、MA_01A109_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_007)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_common_look_at(Actor001,Actor002,1)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
set_common_look_at(Actor003,Actor002,1)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
set_common_look_at(Actor004,Actor002,1)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
set_common_look_at(Actor005,Actor002,1)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101046","001","101046001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:言いがかりつけようっていうのね<br>ルーシャス皇太子殿下が
	Talk(Actor001,"CHRNAME_GUINEVERE2","speech","L","MA_01A109_250002")

	change_face(Actor002,"Anger")

	--★★グリートン★★:思い起こして、顧みて
	Talk(Actor002,"CHRNAME_SISTERS_5","speech","R","MA_01A109_250003")

	PlayAction(Actor002,"to  Std_Talk")

	--★★グリートン★★:コルベニック城を守護する長城の他にもうひとつ<br>ブリテンには島を東西に二分する長城があるの
	Talk(Actor002,"CHRNAME_SISTERS_5","speech","R","MA_01A109_250004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:それがなんだってんだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A109_250006")


	--★★グリートン★★:島を横断する規格外で堅牢な要塞<br>いまや朽ち果て見る影もないけれど
	Talk(Actor002,"CHRNAME_SISTERS_5","speech","R","MA_01A109_250007")


	--★★グリートン★★:あれこそ古代ローマの遺物よ<br>圧倒的物量で建築された古代ローマの力の象徴…
	Talk(Actor002,"CHRNAME_SISTERS_5","speech","R","MA_01A109_250008")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★ノワール★★:そうだとして<br>戦争や虐殺を起こす理由にはならない
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_250009")

	change_face(Actor002,"Smile")

	--★★グリートン★★:昔々、ブリテンで発生し始めていたバルバロイを<br>せき止めるための防波堤だったわけだけれど
	Talk(Actor002,"CHRNAME_SISTERS_5","speech","R","MA_01A109_250010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★グリートン★★:いつからかバルバロイへ対抗できる秘術を<br>身に着けた者たちが現れたのはご存じね？
	Talk(Actor002,"CHRNAME_SISTERS_5","speech","R","MA_01A109_250011")

	change_face(Actor005,"Sad")

	--★★エレイン★★:………それが、ログレス
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A109_250012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101046","001","101046001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
