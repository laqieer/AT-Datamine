-- このluaスクリプトは、MA_01C110_32.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_005)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_TextOnly()
	template1()

end

function Play()
	StartPlay()


	--★★マルディサント★★:「不格好な金色のコートを纏い<br>円卓の騎士を狙う騎士がいた」
	Talk(Actor002,"CHRNAME_NAMELES","speech","N","MA_01C110_320002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…声？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_320003")

-- ▼直接出力
wait_time(1.5)
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
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
