-- このluaスクリプトは、MA_01B900_56.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_004)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★パーシヴァル★★:公平無私で<br>面白味のないヤツだと思っていたよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B900_560002")


	--★★パーシヴァル★★:だけどそうあり続けられたのは<br>目指す先がもっともっと先にあったからなんだね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B900_560003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:尊敬に値するよ。ノワール
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B900_560004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:パー坊もそうなれますよ
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_560005")

	change_face(Actor002,"Sad")

	--★★パーシヴァル★★:ボクはダメさ<br>我欲が強すぎる
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B900_560006")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ディンドラン★★:ふふ。確かに
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_560007")

	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:あっ！謙遜したのに！
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B900_560008")

	change_face(Actor003,"Normal")

	--★★ディンドラン★★:ですが貴方は<br>進んで誰かの前に出ることもできた
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_560009")

	change_face(Actor002,"Smile")

	--★★パーシヴァル★★:そりゃあね、眼前で命削ってる姿見せられたらね<br>さすがにボクだって釣られちゃうよ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B900_560010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:強く心を持てたのは<br>きっと
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","MA_01B900_560011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★パーシヴァル★★:流されたからだね。キミたちに
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","MA_01B900_560012")

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
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
