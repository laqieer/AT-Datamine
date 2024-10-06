-- このluaスクリプトは、MA_01104_38.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_003)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")

	--★★ケイ★★:焚きつけるのが貴公の仕事ではなかろう<br>モルガン女史
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01104_380002")


	--★★モルガン★★:奮い立たせるお手伝いくらいはしたいの
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01104_380003")


	--★★アーサー★★:生徒のやる気は伸ばしたいなあ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_380004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:儀式にてディナタンが力を得れば<br>確かにログレスの戦力となるかも知れん
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01104_380005")


	--★★ケイ★★:そして彼女は快く送り出してくれた王と<br>モルガン女史に借りができる
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01104_380006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:それは良い<br>だが万一逃げ出すようなことがあれば？
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01104_380007")

	PlayAction(Actor001,"to  Std_No")

	--★★モルガン★★:それはないわ
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01104_380008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ケイ★★:例えばもっと悪いなにかが起こるとすれば…？<br>学園に盾突くようなことになれば？
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01104_380009")


	--★★モルガン★★:そんな子が療養院で働こうなんて思わないわ<br>なんの見返りもなく
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01104_380010")


	--★★ケイ★★:…監視からの報告を待ちますゆえ
	Talk(Actor003,"CHRNAME_KAY","speech","L","MA_01104_380011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★アーサー★★:義兄さん…大変だナ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01104_380013")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★モルガン★★:ホント、オツカレ
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01104_380015")

	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★ケイ★★:誰のせいか、誰の！
	Talk(Actor003,"CHRNAME_KAY","speech","N","MA_01104_380016")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
