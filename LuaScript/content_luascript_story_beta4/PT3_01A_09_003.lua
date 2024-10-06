-- このluaスクリプトは、PT3_01A_09_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_03","110191_03_h")
Include("content_adv_advsmall_110191_03","Template110191_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110191_03,CameraPos110191_03_002)
	InitializeTemplateRandomCamera110191_03()
	InitializeTemplate110191_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("リリアーナ","驚き")
-- ▲直接出力

	--★★リリアーナ★★:あっ、お、おはようございます<br>ノワールさん…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_09_0030003")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール","挨拶")
-- ▲直接出力

	--★★ノワール★★:おはよう、リリアーナ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リリアーナ","挨拶")
-- ▲直接出力

	--★★リリアーナ★★:あの、えっと…<br>ロンディニウムは大丈夫でしょうか…？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_09_0030005")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:このあいだの事件で<br>大勢の人が亡くなったと聞きます
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_09_0030006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力

	--★★ノワール★★:たしかに負傷者はたくさん出たし<br>街の一角は崩壊してしまったそうだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0030007")


	--★★ノワール★★:すぐに復興活動がはじまったみたいだ<br>ログレスも有志を募ってその手伝いをしてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0030008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リリアーナ","落胆")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:そうですか、よかった…
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_09_0030009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リリアーナ","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★リリアーナ★★:あの…<br>なにか手伝えることはあるでしょうか？
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_09_0030010")


	--★★リリアーナ★★:ロンディニウムのみなさんを１日でも早く<br>苦しみや悲しみから解放してあげたいです
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_09_0030011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:優しいんだな、リリアーナは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0030012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("リリアーナ","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★リリアーナ★★:いえ、そんな…<br>私はローマの人たちに…ううん
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_09_0030013")


	--★★リリアーナ★★:私は臆病者で、戦いではお役に立てませんから<br>それ以外でできることを頑張りたいなって
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_09_0030014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:リリアーナのその気持ち<br>復興活動を進めてる連中に伝えておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0030015")

	change_face(Actor001,"Smile")

	--★★ノワール★★:きっと嬉しがると思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01A_09_0030016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リリアーナ","肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リリアーナ★★:はい、ありがとうございます<br>よろしくお願いします…！
	Talk(Actor002,"CHRNAME_LILIANA","speech","L","PT3_01A_09_0030017")

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
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
