-- このluaスクリプトは、MA_01A900_21.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	template1()
-- ▼直接出力
lookoj = create_object("kara")
-- ▲直接出力
-- ▼直接出力
set_pos_object(lookoj,5.15,-0.097,1.473)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力

end

function Play()
	StartPlay()

-- ▼直接出力
lookat_delay_weight(Actor001, {0.8, 0.05, 0.6, 0.6} , 100)
lookat_position(Actor001,{5.15,-0.097,1.473})
-- ▲直接出力
-- ▼直接出力
hide_image(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
change_face(Actor001,"Sad")
wait_time(2.0)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
wait_time(2.0)
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
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
