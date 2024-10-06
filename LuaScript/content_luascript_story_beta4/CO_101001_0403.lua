-- このluaスクリプトは、CO_101001_0403.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_02","112021_02_h")
Include("content_adv_advsmall_112021_02","Template112021_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_004)
	InitializeTemplateRandomCamera112021_02()
	InitializeTemplate112021_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:おおっ、新作のエプロンだ！<br>ちょうど欲しかったんだよな～
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101001_04030002")

-- ▼直接出力
CloseTalkWindow()
set_common_look_at(Actor003,Actor002)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:わぁ！素敵なハンカチがありますよ<br>ティルフィングさん！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04030003")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:こんなに<br>細やかな刺繍は見たことがありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --リオネス方向調整
CloseTalkWindow()
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,270,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "照れ")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★リオネス★★:くんくん、なんだか<br>あっちから肉のにおいがするぞー！
	Talk(Actor005,"CHRNAME_LYONESS","speech","L","CO_101001_04030005")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor005,"to Run")
wait_time(2.0)
PlayActionDirect(Actor005,"to Std_Loop")
Hide(Actor005)
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
 --ガレス方向調整
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,270,0.3)
wait_time(0.3)
PlayActionDirect(Actor004,"to  Std_Surp")
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ガレス★★:ああ！<br>待ってよ、リオネス～！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101001_04030007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:騒がしいなぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04030009")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ4_4")
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
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
