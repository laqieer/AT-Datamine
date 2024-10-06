-- このluaスクリプトは、MA_01B111_36.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101160011)
	Actor001 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
Hide(Actor002)
Hide(Actor003)
-- ▲直接出力

end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★モルガン★★:逢いに来てくれたの？<br>あの人に
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01B111_360002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor002,Camera002,EntryDataDuelCommonFormation01_03,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_103,Actor003,CharaPosDuelCommonFormation01_002,CharaPosDuelCommonFormation01_102)
-- ▲直接出力

	--★★リリアーナ★★:…素敵なリンゴ園、ですね
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","MA_01B111_360004")


	--★★モルガン★★:でも、席を外されています
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01B111_360005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エクセリア★★:動ける御身体なのですか
	Talk(Actor003,"CHRNAME_EXCELIA","speech","L","MA_01B111_360006")

	PlayAction(Actor001,"to  Std_Worry")

	--★★モルガン★★:ふふ。新入生にまで心配されるなんて<br>王の座も危ういわね
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01B111_360007")

	change_face(Actor001,"Sad")

	--★★モルガン★★:座ってるだけで、やっとよ
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01B111_360009")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101160011)
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
