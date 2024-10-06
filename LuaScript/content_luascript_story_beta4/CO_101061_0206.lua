-- このluaスクリプトは、CO_101061_0206.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor001,0.8,0.05,0.5,0.2)
-- ▲直接出力

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:こんなに本があるんだ、圧巻だね/一生かけても読み切れなさそう
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02060002")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:この大図書院の蔵書の量は/ブリテン中でも１、２を争うらしいからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02060003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:へえ！/それならきっと…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02060005")


	--★★ノワール★★:きっと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02060006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラロゥ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:えっと…なんでもないよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02060007")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラロゥ_ランクアップ2_7")
-- ▲直接出力
	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
