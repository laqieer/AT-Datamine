-- このluaスクリプトは、CO_101026_0905.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114061_01","114061_01_h")
Include("content_adv_advsmall_114061_01","Template114061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",109,CharaPos114061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_001)
	Camera002 = SetTemplate("Actor002",33.5,CharaPos114061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114061_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_007)
	InitializeTemplateRandomCamera114061_01()
	InitializeTemplate114061_01()
-- ▼直接出力
change_face(Actor001,"Surprise")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114061)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101027","002","101027002","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("パーシヴァル", "肯定2")
-- ▲直接出力

	--★★パーシヴァル★★:湖？<br>ノワール、キミの知っている場所かい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09050002")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ここはリムニーナ村<br>俺が産まれ育った村だ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09050003")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,195,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★パーシヴァル★★:なんだって？<br>キミの故郷って聖杯城の近くだろう？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★パーシヴァル★★:果てなき森からだいぶ離れているはずじゃないか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_09050006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:状況が、よく、飲み込めないが…<br>いったん戻ってアーサーに報告しよう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_09050007")

-- ▼直接出力
local trustParam = set_communication_rankup("パーシヴァル_コミュランク", "パーシヴァル_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
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
	load_area_scene_preload(114061)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101027","002","101027002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
