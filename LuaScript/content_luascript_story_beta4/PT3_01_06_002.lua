-- このluaスクリプトは、PT3_01_06_002.csvから自動生成されました --
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
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:やれやれ…。まさかボクまで<br>リンゴ狩りに付き合わされることになるとはね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_06_0020003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:たまにはいいじゃないか<br>みんなで遠出ってのも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:好きじゃないんだよ<br>誰かが近くにいる状態で眠るの
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_06_0020005")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:知り合いばっかりだろ？<br>気を張る必要なんてない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0020006")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★トリスタン★★:………
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_06_0020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:キミ、寝るときに<br>イビキをかく癖があったりする？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_06_0020008")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:いや…どうだろ？<br>イビキがうるさいと言われた経験はないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0020009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:キミがもしもボクの近くで寝ることになって<br>ボクの安眠を妨げたりしたら…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_06_0020010")

-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:キミが翌朝<br>目を覚ますことはないかもしれないよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","PT3_01_06_0020011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:き、気を付けるよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_06_0020012")

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
	load_area_scene_preload(115200)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
