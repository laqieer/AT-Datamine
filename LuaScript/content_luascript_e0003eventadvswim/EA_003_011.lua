-- このluaスクリプトは、EA_003_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_02","110901_02_h")
Include("content_adv_advsmall_110901_02","Template110901_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_003)
	InitializeTemplateRandomCamera110901_02()
	InitializeTemplate110901_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10130031)
set_pos(prop001 , {-6.444,2.04,1.405})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("女子1", "肯定2")
-- ▲直接出力

	--★★張り紙を読む生徒★★:『学園一のアイドルと学園一の非行少女のGSその一報は瞬く間に学園中を駆け巡った』
	Talk(Actor001,"NPCNAME_0375","speech","N","EA_003_0110002")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★歌姫D推し生徒★★:アイドルが誰かひとりのものになるなんて！もう、なにも手がつかない。泣きたい
	Talk(Actor002,"NPCNAME_0376","speech","N","EA_003_0110003")

-- ▼直接出力
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("女子2", "肯定2")
-- ▲直接出力

	--★★綺麗なものを愛する生徒★★:清純派アイドルとワイルド不良の組み合わせ実に王道。王道且つ、覇道。尊い。眼福
	Talk(Actor003,"NPCNAME_0377","speech","N","EA_003_0110004")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("女子1", "悩む")
-- ▲直接出力

	--★★張り紙を読む生徒★★:『ある者は泣き、ある者は沸きそしてある者は密かに妄想の花を開いた』
	Talk(Actor001,"NPCNAME_0375","speech","N","EA_003_0110005")


	--★★張り紙を読む生徒★★:『皆が思うことはただひとつ』
	Talk(Actor001,"NPCNAME_0375","speech","N","EA_003_0110006")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor001,"to  Std_Joy")
PlayActionDirect(Actor002,"to  Std_Joy")
-- ▲直接出力

	--★★生徒たち★★:学園でいま一番ホットなふたりのこともっと知りた～い！！！
	Talk(Actor004,"NPCNAME_0116","speech","N","EA_003_0110007")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130031)
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110901_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
