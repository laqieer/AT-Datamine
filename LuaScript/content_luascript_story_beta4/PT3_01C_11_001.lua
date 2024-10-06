-- このluaスクリプトは、PT3_01C_11_001.csvから自動生成されました --
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

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:ノワール<br>ディナタンの具合はあれからどう？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01C_11_001002")


	--★★トリスタン★★:学園祭で歌っている最中に<br>倒れたって聞いたけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01C_11_001003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:イゾルデにも診てもらったけど<br>もう大丈夫みたいだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_001004")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:ならいいんだけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01C_11_001005")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:トリスタンは<br>学園祭に参加しなかったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_001006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボクは学園の見回りだよ<br>いつバルバロイが襲ってくるかわからないからね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01C_11_001007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:学園祭だけじゃない<br>次のハロウィンだって顔を出せるか怪しいもんさ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01C_11_001008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ハロウィンの見回り<br>俺が代わろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_001009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "否定")
-- ▲直接出力

	--★★トリスタン★★:余計なお世話
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01C_11_001010")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな言いかた…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_11_001011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:冗談だよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01C_11_001012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボクは学園の安全を守る<br>キミは会場にいてみんなを安心させてあげる
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01C_11_001013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:いいじゃない、それで
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01C_11_001014")

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
