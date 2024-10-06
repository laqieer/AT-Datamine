-- このluaスクリプトは、MA_01108_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",180,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★モルドレッド★★:…行きやがったか
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01108_280002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk_2P(Actor002,Camera002,EntryData110051_02_20,CameraAssetBundleName110051_02,CameraPos110051_02_120,Actor003,CharaPos110051_02_021,CharaPos110051_02_121)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:妙な真似してみやがれ<br>容赦しねーぞ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01108_280004")

	change_face(Actor001,"Smile")

	--★★モルドレッド★★:ハハッ、俺が？<br>なにをしようって？
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01108_280005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:留守を預かってるんだ<br>大人しくしててよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01108_280006")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★モルドレッド★★:継承者サマがお戻りになるまで？
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01108_280007")


	--★★ガウェイン★★:俺のダチが信じられねーか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01108_280008")

	PlayAction(Actor001,"to  Std_No")

	--★★モルドレッド★★:不確かなものは信じられんねえ、全部ウソくせえ<br>伝説も言い伝えも家族やダチとの絆ってやつも
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01108_280009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:どれを本物として選ぶかだろ
	Talk(Actor001,"CHRNAME_MORDRED","speech","L","MA_01108_280010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
