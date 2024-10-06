-- このluaスクリプトは、MA_01A900_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_007)
	Camera002 = SetTemplate("Actor002",5,CharaPos110041_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_002)
	Camera003 = SetTemplate("Actor003",-22,CharaPos110041_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_001)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Sad02")
	change_face(Actor003,"Sad")

	--★★マルディサント★★:世界平和の代わりに<br>継承者が一生のキズを背負うってどーよ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A900_190002")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ランスロット★★:…自己犠牲でしかないな
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A900_190003")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Pain")

	--★★マルディサント★★:それで平和に暮らせんのかよ<br>オニーサン自身はさ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A900_190004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ランスロット★★:考えたことがある
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A900_190005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ランスロット★★:戦いが終わり、武器を失った騎士に<br>どんな価値が残るのか
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A900_190006")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:けど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A900_190007")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:ああ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A900_190008")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:それでも兄さんは私の兄さんだから<br>戦いがないころから今までずっと
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01A900_190009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ランスロット★★:…そうだ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A900_190010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ランスロット★★:可愛い弟だ<br>ずっと、ずっと前から
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01A900_190011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
