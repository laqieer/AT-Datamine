-- このluaスクリプトは、PT3_01C_01_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★マルディサント★★:………
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01C_01_003001")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:マルディサント？<br>どうしたんだ、フラフラじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_003002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("マルディサント", "苦しみ")
-- ▲直接出力

	--★★マルディサント★★:昨日から…ずっとさがしてんだ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01C_01_003003")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:さがしてるって…なにを？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_003004")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:なにを、じゃねえよ！<br>アンタにだって違和感はあるはずだろ！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01C_01_003005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:違和感…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_003006")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルディサント", "驚き")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★マルディサント★★:…ッ！？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01C_01_003007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★マルディサント★★:向こうから絶ってるってことか？<br>そうさせられてるってことか？
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01C_01_003008")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_003009")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:クソッ！アタシがなんとかしなきゃ…<br>アタシはキラーズなんだから…！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","PT3_01C_01_003010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おい、マルディサント！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_003011")

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
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
