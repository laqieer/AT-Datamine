-- このluaスクリプトは、PT3_01B_01_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")

	--★★ディンドラン★★:ノワールさん、おはようございます
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_01_003002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:おはようございます、ディンドランさん<br>パーシヴァルに用事ですか？あいつだったら…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_01_003003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "否定")
-- ▲直接出力

	--★★ディンドラン★★:いえ<br>今日はノワールさんにお話があって参りました
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_01_003004")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_01_003005")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定2")
-- ▲直接出力

	--★★ディンドラン★★:私はパーシヴァル様のキラーズですから<br>貴方の宿命についての詳細はわかりかねます
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_01_003006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディンドラン★★:ですが、これだけはわかります<br>貴方は今後、辛く悲しい決断を余儀なくされる
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_01_003007")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ディンドランさん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_01_003008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力

	--★★ディンドラン★★:そんなときは、泣いたっていいんです<br>誰かを頼っていいんです
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_01_003009")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ディンドラン★★:学園で一緒に過ごした者として…<br>そして、ちょっとだけ年長者として
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_01_003010")

	change_face(Actor002,"Normal")

	--★★ディンドラン★★:ノワールくんにそれが言いたかったんです
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_01_003011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ありがとう、ございます<br>心細くなったら頼らせてもらいます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01B_01_003012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:はい、いつでも
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","PT3_01B_01_003013")

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
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
