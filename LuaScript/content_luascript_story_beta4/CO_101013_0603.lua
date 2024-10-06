-- このluaスクリプトは、CO_101013_0603.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera002 = SetTemplate("Actor002",-130,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.4, 0.08, 0.8, 0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.4, 0.08, 0.8, 0.6)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:え…売れちゃった…？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06030002")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:はい。数日前にいらした別のお客様が<br>購入されていかれました
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_06030003")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力

	--★★ガウェイン★★:マ、マジかよ…！<br>同じのってもうないのか！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_男2", "落胆")
-- ▲直接出力

	--★★市民（中年男）★★:すみません。キンイロチョウの入った琥珀は<br>そうそう出回るものではなくて…
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_06030005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:取り寄せとか！<br>取り寄せとかできねーかな！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06030006")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "否定")
-- ▲直接出力

	--★★市民（中年男）★★:知り合いに聞いてはみますが<br>難しいのではないかと思います…
	Talk(Actor003,"NPCNAME_0157","speech","N","CO_101013_06030007")

-- ▼直接出力
 --ノワールとガウェインの首を調整
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:なあ、ノワール<br>こないだも聞いた気がするんだけどよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06030009")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ガウェイン★★:こういうときって<br>なんて言ってトムに謝ればいいんだ…？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06030010")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…素直に謝るんでいいんじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それにキンイロチョウは<br>どうにかして捕まえられるかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06030012")


	--★★ノワール★★:まだ諦めるのは早いと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06030013")

-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力

	--★★ガウェイン★★:そうか…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★ガウェイン★★:それにしても<br>俺ってどうしてこう要領が悪いかねえ………
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06030015")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:今日のところは帰ろう<br>トムに会うときも付き合うからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_06030017")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:ああ、悪いな…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_06030018")

-- ▼直接出力
local trustParam = set_communication_rankup("ガウェイン_コミュランク", "ガウェイン_親密度")
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
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
