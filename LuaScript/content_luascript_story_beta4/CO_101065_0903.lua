-- このluaスクリプトは、CO_101065_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101020011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:それにしても、あいつら…子供たちのことを生贄とか言ってたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030002")


	--★★ノワール★★:もしも俺たちが間に合わなかったらきっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:そうさせないためにアタシたちが頑張ったわけじゃない♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でもなんであんなピッタリ日時がわかったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030005")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:キミが持って帰ってきてくれた計画書のおかげ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:計画書…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:まさか盗賊の根城にあった書類の束のことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:大正解♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだったのか…それならそうと言ってくれればよかったのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "落胆")
-- ▲直接出力

	--★★キッス★★:何度も言ってるじゃないせっかちさんは嫌い、って♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★キッス★★:でも…ラビットちゃんの働きもあって今日の取引は潰せたけど
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030012")


	--★★キッス★★:人さらいを生業とする集団は他にもいるわ調査は続けていかないとね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:俺も協力する
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030014")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ありがと♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:それにしても…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030016")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:昔はバルバロイもいなくてこんな連中も少なかったのに…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:イヤな世界になったものよね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030019")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:バルバロイが増えだしたのって何十年も昔のことだよな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030020")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:キッスさんっていったいいくつなんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030022")

-- ▼直接出力
PlayPartVoice("キッス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ラビットちゃん？なにか言ったかしら？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09030024")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あ、イエナンデモナイデス
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09030025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("キッス_コミュランク", "キッス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
	InitializeLoad_Preload()
	load_duel_scene_preload(101020011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
