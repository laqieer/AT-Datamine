-- このluaスクリプトは、PT3_01C_02_001.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ディナタン★★:兄さん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_02_001001")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_02_001002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:マーリンさんは言ってた
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_02_001003")


	--★★ディナタン★★:「アーサー様の育てた学園の勇士が正しいか<br>アーサー様自身が掲げる新たな秩序が正しいか」
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_02_001004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:私は兄さんを信じてる<br>兄さんを信じて、ついていく
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_02_001005")


	--★★ディナタン★★:兄さんは自分を信じて<br>悔いのない選択をして
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT3_01C_02_001006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:…わかった<br>ありがとう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_02_001007")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
