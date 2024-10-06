-- このluaスクリプトは、CO_101063_1004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
load_image("103050180", "content_still_10305018_image", "103050180_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:…ということで！司書クリスティーナよ。あらためてよろしくね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10040002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:こちらこそ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10040003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:結局…ゴッデムにいちばん怯えていたのは私自身だったのかも知れないわね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10040004")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:クリスティーナもゴッデムも受け入れてくれたみんなに感謝しなくちゃ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10040005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:絵本のとおりになったんじゃないか？頑張ったお姫様には幸せが訪れるんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10040006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:…そうね、そのとおりね！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10040007")


	--★★クリスティーナ★★:それじゃあ、お姫様の前に現れた王子様に最上級のサンクスを送らなくちゃ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10040008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力

	--★★クリスティーナ★★:ノワールちゃん！これからローマン・バスに行くわよ！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10040009")


	--★★クリスティーナ★★:今日はスペシャルコースの上のVIPコースで徹底的に綺麗にしてあげる♪
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10040010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
PlayActionDirect(Actor001,"to  Std_Surp")
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ！？い、いや、遠慮しておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10040011")

-- ▼直接出力
CloseTalkWindow()
show_image("103050180", 0.0, 0.0, STILL_SWITCH_TIME ,true,false) --基本的にtrue,falsle wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER
setup_small_camera_end()
wait_time(0.3)
se_play("SE_ADV_MA_01B109_11_Slap")
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "否定")
-- ▲直接出力

	--★★クリスティーナ★★:それじゃ私の気が済まないの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","N","CO_101063_10040012")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0043")
-- ▲直接出力

	--★★ノワール★★:し、『獅子より怖い司書』…！<br>噂は本当だった…！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101063_10040014")

-- ▼直接出力
irisout_set_to_wait(75,190,2000,380,1.2)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "喜び")
-- ▲直接出力

	--★★クリスティーナ★★:逃がさないわよ、王子様♪
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","N","CO_101063_10040015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("クリスティーナ_コミュランク", "クリスティーナ_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103050180", "content_still_10305018_image", "103050180_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
