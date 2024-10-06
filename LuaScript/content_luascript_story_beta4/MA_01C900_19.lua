-- このluaスクリプトは、MA_01C900_19.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",100,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_common_look_at(Actor001,Actor003)
set_enable_auto_lookat(Actor003, false)
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
-- ▼直接出力
CameraEx = set_camera({-0.28, 1.71, 0.49,   5.68708, 153.169, 0,   21})
-- ▲直接出力
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Speculation")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000012)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:…遅いよ。マァル
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_190002")


	--★★マルディサント★★:アーサーと戦う前に話がある
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190003")


	--★★ノワール★★:…いったいなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_190004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マルディサント★★:みんな死んでいった
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190005")

-- ▼直接出力
bgm_play("BGM_ADV_Speculation")
-- ▲直接出力

	--★★マルディサント★★:GSってなんなんだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190006")


	--★★マルディサント★★:血の繋がりってなんだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190008")

	PlayAction(Actor003,"to  Std_No")

	--★★マルディサント★★:円卓って伝説って妖精ってなんだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190009")


	--★★マルディサント★★:アタシにはわからない
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190010")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★マルディサント★★:アタシにわかるのは<br>アタシの気持ちとディーナの気持ちだけだ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190011")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:だから――…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190012")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003,{0.21, 0, -0.91,0.6})
turn_chara(Actor003,122.116,0.6)
-- ▲直接出力
-- ▼直接出力
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Surp")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
on_camera(CameraEx)
on_active(FX_DoF)
PlayActionDirect(Actor001,"to  Std_Surp")
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C900_19_Punch")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,0.719, 0, -1.195,0.3)
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:…ッ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_190014")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…マァル…！？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_190015")

	change_face(Actor003,"Pain")

	--★★マルディサント★★:アンタは…アタシの大切なものが<br>大切にしてるもんだから
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190016")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★マルディサント★★:だから全部許してきた！<br>けど、今アタシは――アンタが許せない…！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190017")

	change_face(Actor003,"Pain")

	--★★マルディサント★★:どうしたらよかったかなんてわかんねえ…！<br>だけどこのままアーサーと戦っても──
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190018")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★マルディサント★★:勝ったとしても何も遺らねえ！<br>仲間を殺して！ディーナを泣かせて！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190019")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★マルディサント★★:まだキズつけなきゃならねえのか！？
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C900_190020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
preload_sound("BGM_ADV_Speculation")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000012)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
