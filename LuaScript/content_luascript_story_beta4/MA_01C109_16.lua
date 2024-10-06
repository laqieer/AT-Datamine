-- このluaスクリプトは、MA_01C109_16.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_004)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115034)
	Actor001 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	template1()
-- ▼直接出力
set_pos(Actor001, {18.677,0, -25.469})
-- ▲直接出力
-- ▼直接出力
set_rot(Actor001, {0, -90,0})
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Anger")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Run")
-- ▲直接出力

end

function Play()
	StartPlay()

-- ▼直接出力
slidemove(Actor001,{-13.677,0, -25.469}, 7)
on_camera(RndCamera007)
wait_time(1.2)
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
on_camera(RndCamera008)
-- ▲直接出力
-- ▼直接出力
wait_time(3.8)
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
	load_area_scene_preload(115034)
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
