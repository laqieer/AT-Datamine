-- このluaスクリプトは、MA_01C110_40.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110261_41","110261_41_h")
Include("content_adv_advsmall_110261_41","Template110261_41_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110261_41_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110261_41,CameraPos110261_41_001)
	InitializeTemplateRandomCamera110261_41()
	InitializeTemplate110261_41()
-- ▼直接出力
movie_load("MA_01C110_40")
movie_set_active(true)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Dinatan_Stage")
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102023)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110261)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ディナタン★★:ほんとは、まだ少し恥ずかしいんです
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C110_400002")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ディナタン★★:いつもは家族と<br>だいじな友達の前でしか歌わないから
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C110_400003")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:だけど私の歌で…少しでも<br>みんなが元気になってくれるなら
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C110_400004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:私…歌います！<br>?
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C110_400005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C110_41_Cheers_02")
wait_time(2.8)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Dinatan_Stage")
-- ▲直接出力
-- ▼直接出力
movie_play()
movie_wait_playing()
fadeout(0,0,0,1.0,0)
movie_stop()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
movie_load_preload("MA_01C110_40")
preload_sound("BGM_ADV_Dinatan_Stage")
setup_prop_object_preload(10102023)
	InitializeLoad_Preload()
	load_area_scene_preload(110261)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110261_41)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
