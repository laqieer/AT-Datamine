-- このluaスクリプトは、MA_01C900_37.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116102_02","116102_02_h")
Include("content_adv_advsmall_116102_02","Template116102_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPos116102_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_MA01C900_37_Controller","to Std_Loop",CameraAssetBundleName116102_02,CameraPos116102_02_001)
	InitializeTemplateRandomCamera116102_02()
	InitializeTemplate116102_02()
-- ▼直接出力
CUT_01 = cat_template_camera("P10_Cam")
-- ▲直接出力
-- ▼直接出力
RndCamera001 = CUT_01
-- ▲直接出力
-- ▼直接出力
Ef_Noise =  load_particle("content_effect3d_common_adv","Ef_C_Adv_BalNoiz03_L_Lop",false,true)
set_pos(Ef_Noise,{0, 0,0.5})
FX_Glitch = load_postprocess("content_adv_postprocess_glitch", "Ef_C_PP_Glitch_MA_01C900_37", false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_weight_reset(Actor002)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116102)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(6.0)
-- ▲直接出力

	--★★テロップ★★:兄さんとアタシ、どっちが大好きだよ？
	Talk(Actor001,"telop","narration","L","MA_01C900_370002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
on_active(Ef_Noise)
play_particle(Ef_Noise)
wait_time(0.5)
on_active(FX_Glitch)
wait_time(1.0)
fadeout(0,0,0,1,0.5)
wait_time(0.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_BalNoiz03_L_Lop",false,true)
load_postprocess_preload("content_adv_postprocess_glitch", "Ef_C_PP_Glitch_MA_01C900_37", false)
	InitializeLoad_Preload()
	load_area_scene_preload(116102)
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName116102_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
