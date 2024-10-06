-- このluaスクリプトは、MA_01106_902.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",123,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",-110,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_005)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	template1()

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:あの、さ<br>マルディサントの容体はどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_9020002")


	--★★イゾルデ★★:変わらないわ<br>良くも悪くもね
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01106_9020003")

	PlayAction(Actor003,"to  Std_Talk")

	--★★イゾルデ★★:あの子よりも<br>お前の妹のほうが良くないかもしれないわ
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01106_9020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタンが？<br>どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_9020005")


	--★★イゾルデ★★:ほとんど眠らずに<br>ずっと療養院であの子の看病をしてる
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01106_9020006")

	PlayAction(Actor003,"to  Std_Worry")

	--★★イゾルデ★★:あのままだと<br>いつか倒れてしまうかもしれない
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","MA_01106_9020007")

	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:行ってあげたら？<br>兄妹なんでしょ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","MA_01106_9020008")

-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
