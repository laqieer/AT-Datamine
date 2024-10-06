-- このluaスクリプトは、MA_01108_07.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114021_01","114021_01_h")
Include("content_adv_advsmall_114021_01","Template114021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",80,CharaPos114021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName114021_01,CameraPos114021_01_006)
	InitializeTemplateRandomCamera114021_01()
	InitializeTemplate114021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114021)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")

	--★★イゾルデ★★:謁見は終わったわ<br>カレドニア戦に兵を出してくれるそうよ
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01108_070002")


	--★★ノワール★★:そうか<br>これでひと安心だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_070003")


	--★★イゾルデ★★:次はガラハッドの依頼のほうね<br>必要な薬草の名前はわかるかしら？
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01108_070004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガラハッド★★:ええと…<br>エルダーリンデンの花と聞いている
	Talk(Actor003,"CHRNAME_GALAHAD","speech","L","MA_01108_070005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★イゾルデ★★:それなら南の森ね<br>さっそく出かけましょう
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","MA_01108_070007")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114021)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
