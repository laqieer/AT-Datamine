-- このluaスクリプトは、MA_01B110_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101020013)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101036","002","101036002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","002","101025002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力

	--★★ボールス★★:あっけないものだ
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_280002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:事件の終わりはいつでもね
	Talk(Actor003,"CHRNAME_CLARE2","speech","L","MA_01B110_280003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:引き際が良すぎる<br>時間稼ぎか、あるいは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_280004")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力

	--★★ボールス★★:単なる暇つぶしか
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_280005")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:どっちにせよ目的地が近いかも<br>ってことだよね…！
	Talk(Actor002,"CHRNAME_VIENA2","speech","L","MA_01B110_280006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…急ごう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_280008")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor001)
Hide(Actor002)
set_enable_auto_lookat_all(false)
lookat_delay_weight_reset(Actor002,1)
lookat_weight_default(Actor002)
lookat_delay_weight_reset(Actor002,1)
lookat_weight_default(Actor002)
setup_small_camera_start(RndCamera001)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:仮に…ね。ヴォールス？
	Talk(Actor003,"CHRNAME_CLARE2","speech","L","MA_01B110_280010")

-- ▼直接出力
set_common_look_at(Actor004,Actor003)
-- ▲直接出力

	--★★ボールス★★:ん？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_280011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★クレア★★:私か、ほかの人かどちらかをどうしても<br>選ばなければならなくなったら…どうする？
	Talk(Actor003,"CHRNAME_CLARE2","speech","L","MA_01B110_280012")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
lookat_delay_weight_reset(Actor004,1)
 --PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ボールス★★:………そんな問いが継承者に<br>投げかけられる日がくるかもしれんな
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_280013")

-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力

	--★★クレア★★:ヴォールスだったら…どうする？
	Talk(Actor003,"CHRNAME_CLARE2","speech","L","MA_01B110_280015")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ボールス★★:わかっているだろう？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_280017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor004)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
 --PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クレア★★:…わかっていても<br>ききたいものよ
	Talk(Actor003,"CHRNAME_CLARE2","speech","L","MA_01B110_280019")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101020013)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101036","002","101036002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","002","101025002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
