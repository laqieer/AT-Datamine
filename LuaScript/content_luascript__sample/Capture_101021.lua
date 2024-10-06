-- このluaスクリプトは、EA_045_101001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_08","110011_08_h")
Include("content_adv_advsmall_110011_08","Template110011_08_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
--[[
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_016_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_017_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleName110011_08,CameraPos110011_08_001)
]]
	InitializeTemplateRandomCamera110011_08()
	InitializeTemplate110011_08()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101021","001","101021001","content_animationpack__common","FacialPack","Actor001")
--[[
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101053","001","101053001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101054","001","101054001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101055","001","101055001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor001 = InitializeCharacter_3D("101021","001","101021001","content_animationpack__common","FacialPack","Actor001")
]]
	template1()

--[[ ホワイトデー登場キャラ
	ノワール	CHRNAME_NOIR		101009002	Chr_002_01_StdController
	ランスロット	CHRNAME_LANCELOT	101010001	Chr_001_01_StdController
	ガウェイン	CHRNAME_GAWAIN		101013001	Chr_003_01_StdController
	トリスタン	CHRNAME_TRISTAN		101014001	Chr_004_01_StdController
	アーサー	CHRNAME_ARTHUR		101015001	Chr_005_01_StdController
	モルドレッド	CHRNAME_MORDRED		101022001	Chr_006_01_StdController
	ヴォールス	CHRNAME_BORS		101024001	Chr_010_01_StdController
	パーシヴァル	CHRNAME_PERCIVAL	101026001	Chr_008_01_StdController
	ラヴェイン	CHRNAME_LOVEIN		101031001	Chr_009_01_StdController
	マターヤ	CHRNAME_MATHAJIM	101053001	Chr_015_01_StdController
	アダン		CHRNAME_ADAM		101054001	Chr_016_01_StdController
	オーウェン	CHRNAME_OWEN		101055001	Chr_017_01_StdController
	ルーシャス	CHRNAME_LUCIUS		101051001	Chr_020_01_StdController
	ブルーノ	CHRNAME_BRUNO		101021001	Chr_007_01_StdController
]]

end

function Play()
	StartPlay()

	change_face(Actor001,"Normal")
	PlayAction(Actor001,"to Std_Loop")
	Talk(Actor001,"CHRNAME_BRUNO","speech","L","UITEST_SELECT4_3_3")
	change_face(Actor001,"Smile")
	PlayAction(Actor001,"to  Std_Talk")
	Talk(Actor001,"CHRNAME_BRUNO","speech","L","UITEST_SELECT4_3_3")
--[[
	Talk(Actor001,"CHRNAME_NOIR","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_TRISTAN","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_BORS","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_LOVEIN","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_MATHAJIM","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_ADAM","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_OWEN","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","UITEST_SELECT4_3_3")
	Talk(Actor001,"CHRNAME_BRUNO","speech","L","UITEST_SELECT4_3_3")
]]
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101021","001","101021001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110011_08)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
