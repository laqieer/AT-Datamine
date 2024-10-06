-- このluaスクリプトは、MA_01B112_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",-121.3,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★エクセリア★★:『父なる彼』の名も顔も<br>思い出せはしないわ
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B112_070002")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:…それは、つまりは…
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B112_070003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エクセリア★★:バルバロイに存在を喰い尽くされたか<br>あるいは──
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B112_070004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディンドラン★★:聖遺物化、されたか
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B112_070005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★エクセリア★★:存在は忘却されたけど<br>私たち銀卓騎士は強く育ったわ
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B112_070006")


	--★★エクセリア★★:私たちに引き継がれた騎士道が<br>その忘れられし父の存在した証
	Talk(Actor001,"CHRNAME_EXCELIA","speech","L","MA_01B112_070007")

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
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
