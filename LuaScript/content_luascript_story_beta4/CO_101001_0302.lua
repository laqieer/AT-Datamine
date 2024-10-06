-- このluaスクリプトは、CO_101001_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",200,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:今日はみんなで協力して<br>授業の課題をやろうと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03020002")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:ひとりでやるより効率がいいし<br>みんなでやれば楽しい思い出になると思うんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03020003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それに<br>いかにも学園生活って感じがしないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:はあ…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03020006")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:今日はよろしくな、ティルフィング！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03020007")

-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:今回の史学の課題は時間かかりそう<br>だから、一緒にできて嬉しいよ～！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03020008")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ラグネル★★:頑張ろうね！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03020009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:よろしくお願いします
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03020011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:よし、始めるぞ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03020012")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ3_3")
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
