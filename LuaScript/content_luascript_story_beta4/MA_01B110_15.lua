-- このluaスクリプトは、MA_01B110_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","002","101036002","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:こんなところじゃ眠れないね<br>やっぱり
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_150002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:パーシヴァル様。良き判断でした
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_150003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★パーシヴァル★★:なんのこと？
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_150004")

-- ▼直接出力
 --PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力

	--★★ディンドラン★★:魔女を明るみに引っ張り出したことです
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_150005")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:…なんのこと？
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_150007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
change_face(Actor002,"Normal")
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:引き際が良すぎる<br>時間稼ぎか、あるいは…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_150008")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★パーシヴァル★★:手の込んだ嫌がらせか
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_150009")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★フィエナ★★:どっちにせよ目的地が近いかも<br>ってことだよね…！
	Talk(Actor004,"CHRNAME_VIENA2","speech","L","MA_01B110_150010")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…急ごう
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01B110_150012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001)
change_face(Actor002,"Smile")
 --PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:野宿がキャンセルされて良かったですね<br>パー坊？
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","MA_01B110_150013")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★パーシヴァル★★:良いベッドを予約したいね
	Talk(Actor001,"CHRNAME_PERCIVAL","speech","L","MA_01B110_150015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101036","002","101036002","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
