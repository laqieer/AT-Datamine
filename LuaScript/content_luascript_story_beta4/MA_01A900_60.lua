-- このluaスクリプトは、MA_01A900_60.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-10.279,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
Chair_01 = get_object("geo_chair_01") --ギネヴィアの椅子
set_pos(Chair_01, {2.36, 0, -1.419285})
set_rot(Chair_01, {0, 0, 0})
-- ▲直接出力
-- ▼直接出力
 --lookat_weight_default(Actor001)
 --keep_delay_ik_lookat_object(Actor001,nil,"geo_chair_01",100)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-0.0820000023,0,-3.63199997})

-- ▲直接出力
-- ▼直接出力
INIT_CHRPOS(Actor002,{-0.0820000023,0,-3.63199997,90},false)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
IN_WALK(Actor002,CharaPos110011_01_006)
set_common_look_at(Actor002,Actor001)
wait_time(2.0)
-- ▲直接出力

	--★★ティルフィング★★:天命、曰く
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01A900_600002")


	--★★ティルフィング★★:アナタが選び抜いたのは<br>唯一無二の伝説
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01A900_600003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:六千年の歴史の海からサルベージされ<br>未来まで語り継がれる墓碑銘
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01A900_600004")


	--★★ティルフィング★★:継承者のキラーズは<br>未来にて世界を救う武器となります
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01A900_600005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:………アナタの喪失に対し<br>なんの慰めにもなりませんが──
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01A900_600007")


	--★★ノワール★★:だったら、きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_600008")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:…え？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01A900_600009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:きっと未来を救いにいくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_600010")


	--★★ノワール★★:待っていてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_600012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001,0.6)
-- ▲直接出力

	--★★ノワール★★:覚えたそばから<br>忘れていくとしても
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_600013")


	--★★ノワール★★:ひとつも失くしたくないのに<br>ひとつしか残せないのだとしたら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_600014")


	--★★ノワール★★:なにを喪っても<br>生きていくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_600015")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.8)
wait_time(0.8)
PlayActionDirect(Actor001,"to Std_Loop")
setup_small_camera_end(Camera001)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
SkipOffsetCamera(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:このいたみが、武器になるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_600017")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
