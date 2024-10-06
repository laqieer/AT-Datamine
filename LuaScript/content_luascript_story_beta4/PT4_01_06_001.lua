-- このluaスクリプトは、PT4_01_06_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ここでなにしてるんだ、ディナタン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0010002")

-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…いろいろね、考えてたの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0010003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:あのときの私、間違ってたのかなマルディサントを止めるべきじゃなかった？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0010004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いやディナタンの判断は正しかったと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0010005")


	--★★ノワール★★:マルディサントはとても戦えるような状態じゃなかったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0010006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:たとえ戦えたとしても、相手は魔女だただじゃ済まなかったはず
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0010007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:うん…それはわかってる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0010008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力

	--★★ディナタン★★:でも、このままモルガン先生と別れたままだとマルディサントは…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0010009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:モルガン先生のことなら心配いらないアーサーが動いてくれてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0010010")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:カレドニアに行けるの？私もついて行っていい？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:ダメって言ってもついて来るんだろアーサーに話してみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:ありがとう、兄さん絶対モルガン先生を助けようね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:それと、ブライアンさんのことも
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","PT4_01_06_0010014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああちゃんと話をしないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_06_0010015")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
