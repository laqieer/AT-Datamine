-- このluaスクリプトは、MA_01104_44.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114051_01","114051_01_h")
Include("content_adv_advsmall_114051_01","Template114051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",43.06,CharaPos114051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_004)
	InitializeTemplateRandomCamera114051_01()
	InitializeTemplate114051_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114051)
	Actor001 = InitializeCharacter_3D("101041","002","101041002","content_animationpack__common","FacialPack","Actor001")
	template1()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
DontChangeRandomCamera(true)
-- ▲直接出力

end

function Play()
	StartPlay()


	--★★モルガン★★:蟲喰いの貴方
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_440002")

-- ▼直接出力
on_camera(RndCamera003)
-- ▲直接出力

	--★★モルガン★★:蝕まれて蝕まれて蝕まれて蝕まれて蝕ま/れて蝕まれて蝕まれて蝕まれて蝕まれて
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_440003")


	--★★モルガン★★:蝕まれてしまって熟れて腐り朽ちて堕ちて/しまっても死斑まで愛おしく撫で頬擦るから
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_440004")

-- ▼直接出力
on_camera(RndCamera002)
-- ▲直接出力

	--★★モルガン★★:癒し失き園までもう少し/奇跡も福音も既に枯れたもの
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_440005")


	--★★モルガン★★:さあ…死ぬまでの辛抱よ
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_440006")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, 2.0)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0.0,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
fadein(2.0)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★モルガン★★:どうか　幻想に浸らせて
	Talk(Actor001,"CHRNAME_NAMELES","speech","L","MA_01104_440007")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114051)
	InitializeCharacter_3D_Preload("101041","002","101041002","content_animationpack__common","FacialPack","Actor001")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	system.PreLoadRequest(CameraAssetBundleName114051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
