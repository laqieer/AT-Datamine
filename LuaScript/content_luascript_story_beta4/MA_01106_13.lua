-- このluaスクリプトは、MA_01106_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",120,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101160011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor002,"Sad")
	on_cutin(2,Actor003,"Normal")

	--★★ディナタン★★:んしょ… んっ、なかなか、もげない…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_130002")


	--★★マルディサント★★:モタモタやってんなよ ヘタクソ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130003")


	--★★マルディサント★★:こうやんだよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130005")

-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	close_cutin()
-- ▼直接出力
EntryWalk(Actor001,Camera001,EntryDataDuelCommonFormation01_06,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_106)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:手際いいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_130007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_130008")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★マルディサント★★:妹とさ、元気出さなきゃって 毎日毎日せんせのリンゴ食ってたんだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130009")


	--★★ディナタン★★:…おいしかった？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_130010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★マルディサント★★:………おいしかったよ、すげえ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130012")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★マルディサント★★:ありがとな、ディナタン アタシ…やっぱ来て良かったよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130014")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:この下で眠ってる妹にも もっかい会えた感じ…するんだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:マルディサントが 帰って来られて良かった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_130017")

	change_face(Actor003,"Laugh")

	--★★マルディサント★★:アンタさ、優しいよな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130018")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:うふふ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_130019")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:うふふ？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…私、マルディサントのためだけに リンゴ狩りに誘ったわけじゃないんだからね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_130021")

	change_face(Actor003,"Surprise")

	--★★マルディサント★★:え？ん？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130022")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:一番おいしいリンゴ 兄さんのために取って？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_130024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★マルディサント★★:…アンタ、マジで最近悪いカオしてんぜ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01106_130025")

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
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
