-- このluaスクリプトは、CO_101025_0804.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",60,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",95,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",80,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera004 = SetTemplate("Actor004",-100,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera005 = SetTemplate("Actor005",100,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera006 = SetTemplate("Actor006",90,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1002_01_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera007 = SetTemplate("Actor007",90,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1002_01_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
DontChangeRandomCamera(true)
set_pos(Actor001,{-2.3,0,-1.75})
set_pos(Actor002,{-3.1,0,0.575})
set_pos(Actor003,{-3.9,0,-0.35})
set_pos(Actor005,{-4,0,0.5})
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Surp")
set_pos(Actor006,{0,0,-0.3})
set_pos(Actor007,{0,0,-0.3})
PlayActionDirect(Actor004,"to  Std_Sad02")
SkipDefaultMotion(Actor007)
PlayActionDirect(Actor007,"to Tailwag")
Hide(Actor001)
Hide(Actor002)
Hide(Actor003)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401042","001","401042001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("402001","001","402001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("402001","001","402001001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "苦しみ")
-- ▲直接出力

	--★★市民（中年男）③★★:な、なんだこの犬！<br>いてて、足に噛みつくな！！
	Talk(Actor004,"NPCNAME_0242","speech","L","CO_101025_08040002")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
Hide(Actor007)
Appear(Actor006)
PlayActionDirect(Actor006,"to Tailwag")
se_play("SE_ADV_CO_101025_0803_Dog_Barks")
Appear(Actor001)
Appear(Actor002)
Appear(Actor003)
Appear(Actor005)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:よくやったぞ、スコーン！<br>お手柄だ！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08040003")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor006,"to idle01_Loop")
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,{-1.1,0,0.4},0.5)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001,{-0.6,0,-0.75},0.5)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor006,"to Run")
turn(Actor006,0,-90,0,0.3)
slidemove(Actor006,{-4,0,-0.3},1)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,{-1.9,0,0},0.5)
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.4)
PlayActionDirect(Actor006,"to idle01_Loop")
turn(Actor006,0,90,0,0.3)
wait_time(1)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start(RndCamera004)
PlayPartVoice("市民中年_男2", "驚き")
-- ▲直接出力

	--★★市民（中年男）③★★:お、お前らはあのときの…！<br>なんでここがわかったんだ！？
	Talk(Actor004,"NPCNAME_0242","speech","L","CO_101025_08040005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:あなたは手がかりを残し過ぎたのよ<br>ニセモノさん
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08040006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今ならやり直せる<br>一緒に警吏のところに行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08040007")

-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Joy")
PlayPartVoice("市民中年_男2", "激怒")
-- ▲直接出力

	--★★市民（中年男）③★★:なにがやり直せるってんだ！
	Talk(Actor004,"NPCNAME_0242","speech","L","CO_101025_08040008")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★市民（中年男）③★★:俺にはもう魔力はほとんど残ってねえ<br>魔力のねえ俺になにができるんだよ
	Talk(Actor004,"NPCNAME_0242","speech","L","CO_101025_08040009")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★市民（中年男）③★★:「助けてください魔法使いさま」とか<br>言ってた連中も、今じゃ俺に見向きもしねえ
	Talk(Actor004,"NPCNAME_0242","speech","L","CO_101025_08040010")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★市民（中年男）③★★:むしろ落ちぶれた俺を見て<br>あざわらってやがる
	Talk(Actor004,"NPCNAME_0242","speech","L","CO_101025_08040011")

	PlayAction(Actor004,"to LookFor")
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★市民（中年男）③★★:俺は魔力を取り戻してあいつらを見返すんだ<br>幸せな記憶を取り戻すんだ
	Talk(Actor004,"NPCNAME_0242","speech","L","CO_101025_08040012")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Show")
wait_time(0.5)
se_play("SE_ADV_CO_101025_0803_FlashGranade")
show_image("101010150", 0.0, 0.0, 0.2,false,false)
set_scale_image(20,20)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
set_rot(Actor001,{0,20,0})
PlayActionDirect(Actor002,"to  Std_Sad02")
PlayActionDirect(Actor003,"to  Std_No")
Hide(Actor004)
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:しまった！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08040014")

-- ▼直接出力
CloseTalkWindow()
wait_time(1)
hide_image(2)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:くそっ、逃げられたか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08040016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:ジャスパーの行先は<br>おそらくバルバロイ教団のアジトのひとつね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08040017")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★クレア★★:すぐに追いかけましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08040018")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力

	--★★ヴォールス★★:今から追いかけても追いつけないだろう<br>まずはジョーイの安全確保を優先すべきだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_08040019")


	--★★ヴォールス★★:ジョーイの母親を安心させてやることも<br>犯人確保と同じくらい重要だからな
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_08040020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:そうね<br>なら、ジョーイのことはふたりに任せるわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08040021")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:待ってくれ<br>まさかひとりで行くつもりか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08040022")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,130,0.5)
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:「答えが近づいて来たら走れ」<br>今がその時よ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08040023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、それは違う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08040024")

-- ▼直接出力
PlayPartVoice("クレア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:えっ？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08040025")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")

	--★★ノワール★★:今のクレアはただ焦ってるだけだ<br>無策のまま単身で追うなんて危険すぎる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08040026")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
PlayPartVoice("クレア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:それは…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08040027")


	--★★ノワール★★:俺からもひとつキミに教えたいことがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08040028")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:手を差し伸べてくれる人がいるなら<br>逸らず、その人と一緒に前に進んでいくべきだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_08040029")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
PlayActionDirect(Actor002,"to Std_Loop")
change_face(Actor002,"Surprise")
wait_time(5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(RndCamera007)
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ありがとう<br>探偵の心得のひとつに加えておくわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_08040031")

-- ▼直接出力
local trustParam = set_communication_rankup("クレア_コミュランク", "クレア_親密度")
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
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
preload_sound("BGM_ADV_Reconnaissance")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401042","001","401042001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("402001","001","402001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("402001","001","402001001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
