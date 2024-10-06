-- このluaスクリプトは、PT2_01A_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")

	--★★トリスタン★★:やあ、おかえり
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01A_10_0010004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ただいま<br>そっちはなにもなかったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_10_0010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:これといって特にないよ<br>ま、つかの間の平穏なのかもしれないけどね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01A_10_0010006")


	--★★トリスタン★★:なんにせよ<br>キミたちの勝利を学園のみんなは喜んでる
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01A_10_0010007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:継承者の面目躍如ってところかな<br>ご苦労様
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01A_10_0010008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:褒めて…るんだよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_10_0010009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "喜び")
-- ▲直接出力

	--★★トリスタン★★:そのつもりだけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01A_10_0010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★トリスタン★★:長らく戦いに身を置いているからか<br>継承者サマは疑り深いね。困った困った
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01A_10_0010011")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:さて。そんな継承者サマを<br>アーサー様がお呼びだよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT2_01A_10_0010012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:円卓の間だな？<br>わかった、すぐに行くよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01A_10_0010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
