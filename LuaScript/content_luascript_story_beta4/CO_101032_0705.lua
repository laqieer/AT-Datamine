-- このluaスクリプトは、CO_101032_0705.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114021_01","114021_01_h")
Include("content_adv_advsmall_114021_01","Template114021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_002)
	InitializeTemplateRandomCamera114021_01()
	InitializeTemplate114021_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
load_image("104000110", "content_still_10400011_image", "104000110_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんとか、釣り上げた…この魚は…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07050001")

-- ▼直接出力
setup_small_camera_start()
ShowImageItem("104000110")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:ツノが騎士の剣みたいなカタチしてるこれって、もしかして？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_07050002")

-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:ナイトカジキ！<br>ナイトカジキだよリオネス、ナイトカジキ！！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07050003")

-- ▼直接出力
HideImageItem()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Appl")

	--★★ガレス★★:やったやったナイトカジキだよリオネス！<br>これで兄さんの料理が作れるよ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07050004")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力

	--★★ガレス★★:さすがリオネス！わたしの親友！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07050005")

-- ▼直接出力
local trustParam = set_communication_rankup("ガレス_コミュランク", "ガレス_親密度")
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
load_image_preload("104000110", "content_still_10400011_image", "104000110_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName114021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
