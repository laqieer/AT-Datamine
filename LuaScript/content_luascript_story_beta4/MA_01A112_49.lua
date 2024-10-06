-- このluaスクリプトは、MA_01A112_49.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-25,CharaPos110901_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_007)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	template1()
-- ▼直接出力
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
-- ▲直接出力

end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…雪
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_490002")

-- ▼直接出力
DontChangeRandomCamera(false)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:街は降誕祭の時期か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_490003")

	open_select_window_tag(Actor001,"Normal","MA_01A112_490005","MA_01A112_490006")
	if is_select(1) then
		goto Block14994014_1
	elseif is_select(2) then
		goto Block14994014_2
	end

::Block14994014_1::
	CloseTalkWindow()
	goto Block14994014end

::Block14994014_2::
	CloseTalkWindow()
	goto Block14994014end

::Block14994014end::
	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
