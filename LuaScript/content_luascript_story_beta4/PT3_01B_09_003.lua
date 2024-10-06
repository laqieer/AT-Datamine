-- このluaスクリプトは、PT3_01B_09_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:おっはよー、ノワール！<br>こないだはお疲れ様だったね！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_09_003002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おはよう、フィエナ…<br>朝から元気だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_003003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力

	--★★フィエナ★★:えっへへ～<br>元気なのが私の取り柄だからねー！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_09_003004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだったな<br>でも、大丈夫か？無理してないか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_003005")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フィエナ★★:も～！そういうときはなにも言わずにいるのが<br>男の子ってものだよ？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_09_003006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ご、ごめん！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_003007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フィエナ★★:ふふっ。…ありがとう<br>ノワールは優しいもんね、昔から
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_09_003008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フィエナ★★:でもノワールには私よりも<br>ガラハッドを見ててほしいんだ
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_09_003009")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ガラハッドを？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_003010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フィエナ★★:そ！あの子、頑張りすぎちゃうところがあるから<br>お姉さんとしては心配でたまらないの！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","PT3_01B_09_003011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:頑張りすぎってことなら<br>フィエナも負けてないと思うけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_09_003012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
