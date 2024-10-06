-- このluaスクリプトは、MA_01B109_04.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_007)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116014)
	Actor001 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_TextOnly()
	template1()

end

function Play()
	StartPlay()


	--★★ランスロット★★:師を継ぎ、歩み来て<br>お前と会うべく走りて
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_040002")


	--★★テロップ★★:「最強騎士に斬られるのなら<br>格好だってつくだろう」
	Talk(Actor002,"telop","narration","N","MA_01B109_040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:止まってくれるな２本脚
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_040005")


	--★★テロップ★★:「王を殺してくれるよな」
	Talk(Actor002,"telop","narration","N","MA_01B109_040006")


	--★★ランスロット★★:償い切るまで、背くなよ
	Talk(Actor001,"CHRNAME_LANCELOT","speech","L","MA_01B109_040007")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(116014)
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
