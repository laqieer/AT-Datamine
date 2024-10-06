-- このluaスクリプトは、PT3_01C_01_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115200)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クラリス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:あ～、ノワールくんだ<br>おはようございます～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002001")

	PlayAction(Actor002,"to Greet_one")

	--★★クラリス★★:それじゃあ失礼します～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ええっ！？もう！？<br>どこかに用事でもあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_002003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クラリス★★:はい～、これから大聖堂で<br>お祈りをしてこようかと～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:朝の礼拝か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_002005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "否定")
-- ▲直接出力

	--★★クラリス★★:いえ～、それはもう終わってますよお
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002006")


	--★★クラリス★★:リアムさんがランスロットさんと<br>パーシヴァルさんのためにお祈りされるので
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002007")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クラリス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:わたしもご一緒させてもらうんです～
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:クラリス…ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_002009")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クラリス", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クラリス★★:んん～？どうしてノワールくんが<br>お礼を言うんですかあ？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺はふたりを…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_002011")

-- ▼直接出力
PlayPartVoice("クラリス", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クラリス★★:ノワールくん<br>めっ！ですよ
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_002013")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("クラリス", "怒り")
-- ▲直接出力

	--★★クラリス★★:今、ノワールくんがするべきことは<br>おふたりに悲しい顔を見せることじゃありません
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002014")


	--★★クラリス★★:アーサー様に、めっ！ってして<br>みんなが正しかったことを証明してあげないと
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クラリス★★:じゃないと<br>おふたりも悲しむと思います
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:クラリス…やっぱり、お礼を言わせてほしい<br>ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01C_01_002017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クラリス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クラリス★★:ふふ～、どういたしまして
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","PT3_01C_01_002018")

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
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
