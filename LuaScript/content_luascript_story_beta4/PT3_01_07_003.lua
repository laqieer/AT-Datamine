-- このluaスクリプトは、PT3_01_07_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:おはよう、ノワール<br>気持ちのいい朝だね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_07_0030003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おはよう…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:やけに機嫌が良いな…<br>良すぎてちょっと怖いくらいだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0030005")

-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力

	--★★トリスタン★★:皇太子の面倒見も終わって<br>ゆっくり自分の部屋で眠れるようになったからね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_07_0030006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか<br>それはなにより
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0030007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あのさ<br>俺、イビキとかかいてなかったよな…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0030008")

-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ああ、全然<br>キミはいつも静かに眠っていたね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_07_0030009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…キミは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0030010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:うん、キミは
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_07_0030011")

-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:ボクの安眠を妨げた<br>不届きな輩には制裁を加えたけれど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_07_0030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "喜び")
-- ▲直接出力

	--★★トリスタン★★:キミにそうするつもりはないよ<br>なにも迷惑をかけられてないからね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_07_0030013")


	--★★ノワール★★:あ、ああ、よかった安心したよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0030014")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（どこかに制裁を加えられたヤツが<br>いるってことか…！？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT3_01_07_0030015")

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
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
