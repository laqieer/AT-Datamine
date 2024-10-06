-- このluaスクリプトは、PT3_01A_11_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("トリスタン","挨拶")
-- ▲直接出力

	--★★トリスタン★★:ノワール<br>登山の準備はちゃんと進めてる？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01A_11_0020003")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力

	--★★ノワール★★:スノードン遠征のことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0020004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","落胆")
-- ▲直接出力

	--★★トリスタン★★:それ以外にないでしょ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01A_11_0020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★トリスタン★★:スノードン山はただの山じゃない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01A_11_0020006")


	--★★トリスタン★★:特に山頂付近は<br>招かれざる客が足を踏み入れると
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01A_11_0020007")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:吹雪がいっそう激しさを増すなんて言われてる
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01A_11_0020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:心配してくれてるんだな<br>ありがとう、気を付けるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_11_0020009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:別に心配してるわけじゃない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01A_11_0020010")


	--★★トリスタン★★:今回の遠征、ボクは参加できない<br>ボクが見ていてやれなかったせいで
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01A_11_0020011")

	change_face(Actor002,"Sad")

	--★★トリスタン★★:知り合いが雪で足を滑らせて大怪我<br>なんてことになったら寝覚めが悪そうだから
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01A_11_0020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:それだけだよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01A_11_0020013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
