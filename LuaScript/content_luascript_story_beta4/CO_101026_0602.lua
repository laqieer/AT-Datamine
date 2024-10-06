-- このluaスクリプトは、CO_101026_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",24,CharaPos110061_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_001)
	Camera002 = SetTemplate("Actor002",33,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("パーシヴァル", "挨拶")
-- ▲直接出力

	--★★パーシヴァル★★:義姉さん、聞きたいことがあるんだが
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_06020002")

-- ▼直接出力
CloseTalkWindow()
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-166,0.8)
wait_time(0.8)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力

	--★★ディンドラン★★:パー坊…いえ、パーシヴァル様<br>いらっしゃ…
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_06020003")

-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディンドラン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディンドラン★★:パッ！？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_06020005")

-- ▼直接出力
 --setup_small_camera_start()
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディンドラン", "喜び")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Smile")

	--★★ディンドラン★★:パー坊がダニーくんとジャンくん以外のお友達を<br>連れてくるなんて！
	Talk(Actor002,"CHRNAME_DINDRANE","speech","N","CO_101026_06020007")

	close_cutin()
	PlayAction(Actor002,"to  Std_Surp")

	--★★ディンドラン★★:あらあらいらっしゃい、あらあら！<br>お菓子をお持ちしますね。甘い物はお好き？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_06020009")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("パーシヴァル", "否定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★パーシヴァル★★:待て待て、落ち着け！<br>連れてきたのはノワールだし、ここは家じゃない
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","CO_101026_06020010")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ディンドラン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディンドラン★★:ご、ごめんなさい<br>私ったら嬉しくて、つい…
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_06020012")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:ノワールさん、ようこそ大図書院へ<br>今日はどんなご用ですか？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","CO_101026_06020014")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:は、ははは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06020016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ6_3")
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
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
