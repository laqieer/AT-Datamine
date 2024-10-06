-- このluaスクリプトは、MA_01106_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111011_01","111011_01_h")
Include("content_adv_advsmall_111011_01","Template111011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName111011_01,CameraPos111011_01_004)
	Camera002 = SetTemplate("Actor002",118,CharaPos111011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName111011_01,CameraPos111011_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName111011_01,CameraPos111011_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111011_01,CameraPos111011_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111011_01,CameraPos111011_01_007)
	InitializeTemplateRandomCamera111011_01()
	InitializeTemplate111011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111011)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","002","101017002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Pain")

	--★★マルディサント★★:う、う、うそだろ…！？<br>せんせ、モルガンせんせ…！！
	Talk(Actor002,"CHRNAME_MALADISANT2","speech","L","MA_01106_350002")

	change_face(Actor003,"Surprise")

	--★★モルガン★★:………あ、ら…
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_350004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:モルガンせんせ…！？<br>無事なの、かよ…？まじで…！？
	Talk(Actor002,"CHRNAME_MALADISANT2","speech","L","MA_01106_350005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★モルガン★★:…聞こえていたわ…<br>貴方たちの、ごっこあそび…
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_350006")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Shy")

	--★★マルディサント★★:恥っっずぃこと<br>すげえ言ってましたけど
	Talk(Actor002,"CHRNAME_MALADISANT2","speech","L","MA_01106_350007")

	change_face(Actor003,"Smile")

	--★★モルガン★★:「私の別荘で──<br>もっと見せてくれません？」
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_350008")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★マルディサント★★:…～～～～ッッ！！
	Talk(Actor002,"CHRNAME_MALADISANT2","speech","L","MA_01106_350010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:<dot>ディーナ</dot>！！
	Talk(Actor002,"CHRNAME_MALADISANT2","speech","L","MA_01106_350011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:なあに、マァル？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_350013")


	--★★マルディサント★★:このあと、ふたりでフケねえか！
	Talk(Actor002,"CHRNAME_MALADISANT2","speech","L","MA_01106_350015")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_350016")

	change_face(Actor002,"Shy")

	--★★マルディサント★★:…でぃ、でぃーな？
	Talk(Actor002,"CHRNAME_MALADISANT2","speech","L","MA_01106_350017")

	PlayAction(Actor001,"to  Std_No")

	--★★ディナタン★★:フケません
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_350018")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:エッ！？
	Talk(Actor002,"CHRNAME_MALADISANT2","speech","L","MA_01106_350019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:ビアンは私のダチなんだよ？<br>一緒にお勉強したいな
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_350020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ディナタン★★:良い子も、演じてもらわなきゃ
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01106_350021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111011)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","002","101017002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
