-- このluaスクリプトは、CO_101013_0803.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",250,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",230,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor008")
	template1()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
turn_lookat(Actor005,Actor002,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
turn_lookat(Actor006,Actor002,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
turn_lookat(Actor007,Actor002,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
turn_lookat(Actor008,Actor002,0)
-- ▲直接出力
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor005,"to Greet_one")
-- ▼直接出力
PlayPartVoice("市民_男1","笑い")
-- ▲直接出力

	--★★市民（男）②★★:いたいた、ガウェイン！<br>ちょっと相談に乗ってほしいことがあるんだ
	Talk(Actor005,"NPCNAME_0193","speech","N","CO_101013_08030002")

	PlayAction(Actor006,"to Greet_one")
-- ▼直接出力
PlayPartVoice("市民中年_女1", "怒り")
-- ▲直接出力

	--★★市民（中年女）②★★:うちの台所に大きなネズミが出てさ！<br>ガウェインちゃん、退治しておくれよ！
	Talk(Actor006,"NPCNAME_0194","speech","N","CO_101013_08030003")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男1", "挨拶")
-- ▲直接出力

	--★★市民（中年男）②★★:ガウェイン！
	Talk(Actor007,"NPCNAME_0195","speech","N","CO_101013_08030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("市民_女1", "挨拶")
-- ▲直接出力

	--★★市民（女）②★★:ガウェイン！
	Talk(Actor008,"NPCNAME_0196","speech","N","CO_101013_08030005")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:お、おいおい…！<br>俺はなんでも屋じゃねーんだぞ！？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08030006")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ったくしょうがねえなあ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08030007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:ひとりずつ並びな！<br>順番に話を聞いてやっからよ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_08030008")

-- ▼直接出力
 --アーサーの表情を映す
CloseTalkWindow()
setup_small_camera_start(Camera004)
wait_time(0.6)
change_face(Actor004,"Smile")
wait_time(0.3)
play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
wait_time(1.8)
setup_small_camera_start()
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ノワール、ラグネル<br>あとは任せた
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08030010")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？<br>俺たちに相談があったんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_08030011")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:またにしとくよ<br>ヒーローの邪魔をするわけにはいかないだろう
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","CO_101013_08030012")

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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
