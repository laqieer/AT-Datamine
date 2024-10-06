-- このluaスクリプトは、EA_010_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation07","DuelCommonFormation07_h")
Include("content_adv_advsmall_duelcommonformation07","TemplateDuelCommonFormation07_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation07_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation07,CameraPosDuelCommonFormation07_001)
	InitializeTemplateRandomCameraDuelCommonFormation07()
	InitializeTemplateDuelCommonFormation07()
-- ▼直接出力
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
initialize_MA0010023(heroIdshort)
-- ▲直接出力
-- ▼直接出力
CUT_10 =  cat_template_camera("P10_Cam")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("201010230", "content_still_20101023_image", "201010230_StillImage")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
RndCamera001=CUT_10
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101220011)
	Actor001 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(2.5)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0027")
-- ▲直接出力

	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210004")


	--★★レーヴァテイン★★:
	Talk(Actor001,"CHRNAME_LAEVATEIN","speech","L","EA_010_0210005")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
heroId = GetPlayerStyleId()
if heroId == 101003001 then
	heroIdshort = 101003
	Yof=1.6
elseif heroId == 101005001 then
	heroIdshort = 101005
	Yof=1.6
elseif heroId == 101007001 then
	heroIdshort = 101007
	Yof=1.6
elseif heroId == 101004001 then
	heroIdshort = 101004
	Yof=1.45
elseif heroId == 101006001 then
	heroIdshort = 101006
	Yof=1.45
else
	heroIdshort = 101008
	Yof=1.45
end
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("201010230", "content_still_20101023_image", "201010230_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101220011)
	InitializeCharacter_3D_Preload("101002","002","101002002","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation07)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
