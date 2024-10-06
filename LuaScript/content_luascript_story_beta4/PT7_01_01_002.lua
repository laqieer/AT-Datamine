-- このluaスクリプトは、PT7_01_01_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_03","110111_03_h")
Include("content_adv_advsmall_110111_03","Template110111_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110111_03,CameraPos110111_03_005)
	InitializeTemplateRandomCamera110111_03()
	InitializeTemplate110111_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:キッスさんから連絡を受けた<br>なにか任務があるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT7_01_01_0020001")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("兵士3","悩む")
-- ▲直接出力

	--★★キャメロット軍兵士_上位★★:急な話ですまんな
	Talk(Actor002,"NPCNAME_0351","speech","N","PT7_01_01_0020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:気にしないでくれ<br>それで、どんな内容なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT7_01_01_0020003")

-- ▼直接出力
PlayPartVoice("兵士3","肯定")
-- ▲直接出力

	--★★キャメロット軍兵士_上位★★:偵察隊から<br>バルバロイが発生したと連絡があった
	Talk(Actor002,"NPCNAME_0351","speech","N","PT7_01_01_0020004")

	PlayAction(Actor002,"to  Std_Talk")

	--★★キャメロット軍兵士_上位★★:街の安全を守るため<br>至急、これを排除してもらいたい
	Talk(Actor002,"NPCNAME_0351","speech","N","PT7_01_01_0020005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:よし、わかった！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT7_01_01_0020006")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401035","001","401035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
