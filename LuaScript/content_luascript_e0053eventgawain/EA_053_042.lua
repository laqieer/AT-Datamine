-- このluaスクリプトは、EA_053_042.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力

	--★★ノワール★★:この辺りはもう安全みたいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0420006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そうだな<br>手伝ってくれて助かったぜ、ノワール
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0420007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:いいよ。お菓子作り前の準備運動ってことで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0420008")


	--★★ノワール★★:それに、俺はどっちかといえば<br>こういう仕事のほうが慣れてるし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0420009")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:いや、俺だって<br>こういう仕事のほうが慣れてるからな？？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0420010")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:確かに料理は得意だけどさ<br>けどヒーローの仕事じゃねえとも思うし
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0420011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうかもな。まぁ、俺はなんだかんだで<br>結構楽しくなってきたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0420013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0012")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:今日は昨日よりも上手に作れる気がするぞ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0420014")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:…なんか、お前ってすげーよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0420015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？なにか言ったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0420016")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:いや…なんでもねーよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0420017")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガウェイン★★:それじゃ、とっとと食堂に行こうぜ<br>頼まれたからにはきっちりやらねーとな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","EA_053_0420018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
