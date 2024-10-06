-- このluaスクリプトは、CO_101032_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",320,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("104000100", "content_still_10400010_image", "104000100_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("リオネス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リオネス★★:こんなカビ臭いところにうまいものがあるとは思えないぞ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_03030002")

-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:こんなカビ臭いところだからこそ珍しいキノコが生えていそうだよ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:探してみよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03030004")

-- ▼直接出力
setup_small_camera_start()
wait_time(0.5)
set_enable_auto_lookat(Actor001, false)
lookat_delay_weight_reset(Actor001,0.6)
wait_time(0.7)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだか、このあたりからいい匂いがするような
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03030006")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
ShowImageItem("104000100")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:これは…キノコの一種か？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_03030008")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
HideImageItem()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:ノワール！それだよ！マイントリュフ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03030009")


	--★★ガレス★★:鉱石のそばに生えてる間違いない！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03030010")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Shy")

	--★★ガレス★★:鼻の奥がほわほわしてすっごくいい香り～♪きっと、これがスープの味の秘密なんだ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03030012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:よ～しこれでとびきりのスープが作れるぞ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03030014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガレス、盛り上がってるところ悪いんだが<br>今日はもう遅い
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03030015")


	--★★ノワール★★:一度学園に戻って料理はまた後日ということにしよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03030016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:そうかそうだな、わかった！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03030017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ガレス_コミュランク", "ガレス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000100", "content_still_10400010_image", "104000100_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
