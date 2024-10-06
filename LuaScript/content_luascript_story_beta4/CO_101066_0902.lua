-- このluaスクリプトは、CO_101066_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
on_parent(sword_01,Actor001, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-6.02,0,-2.2})
set_pos(Actor004,{-6.33,0,0.78})
set_pos(Actor005,{-6.01,0,2.37})
set_pos(Actor006,{-6.44,0,-0.75})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	demo_loadend_area2adv()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera002)
wait_time(1.4)
setup_small_camera_end(RndCamera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.6)
lookat_delay_weight(Actor001,0.5,0.1,0.8,0.2,1)
voice_play("VO_101066_sp_0001_1")
-- ▲直接出力

	--★★ブレイズ★★:今回はなるべくすぐに倒さんでくれ<br>ダメージを受けたバルバロイを観察したいんじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:それから複数のバルバロイに同じタイミングで<br>同じダメージを与えてみてほしい
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020004")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:それから――
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020005")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0014")
-- ▲直接出力

	--★★ブレイズ★★:…ふむ。大体こんなもんじゃろか<br>調子乗って頼みすぎてしまったわい
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020007")


	--★★ブレイズ★★:どうじゃ、いけそうかのう？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020008")

	open_select_window_tag(Actor001,"Normal","CO_101066_09020010","CO_101066_09020011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_end()
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、わかった<br>任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020013")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:いい返事じゃ！感心感心！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020014")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0008")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ワシの無茶ぶりにもすっかり慣れた<br>って顔しとるのう～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020015")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:（自分で言うのか…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101066_09020016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
setup_small_camera_end()
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:面倒くさいな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020018")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、ここまで来ちゃったしな<br>しかたない、やるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020019")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:わざと面倒くさそうな素振りしちゃって～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:なんだかんだ付き合ってくれるんじゃから<br>おぬしってば人がいいのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020021")

	goto Block1end

::Block1end::
-- ▼直接出力
local gopos = {-4.48, 0, 0.48}
--到着までの時間を計算------------------
local disx = gopos[1] - CharaPosDuelCommonFormation01_002[1]
local disz = gopos[3] - CharaPosDuelCommonFormation01_002[3]
disx = math.abs(disx)
disz = math.abs(disz)
local dis = disx^2 + disz^2
local distance = math.sqrt(dis)
local SPEED = 4
local MOVETIME = distance / SPEED
----------------------------------------
local tmp
CloseTalkWindow()
lookat_delay_weight_reset(Actor001,1.0)
wait_time(0.4)
setup_small_camera_start(RndCamera002)
PlayActionDirect(Actor001,"to Run")
tmp = slidemove(Actor001, gopos, MOVETIME)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_end(RndCamera002)
setup_small_camera_start(RndCamera007)
wait_proccess(tmp)
PlayActionDirect(Actor001,"to Std_Loop")
set_pos(Actor001,CharaPosDuelCommonFormation01_002)
off_parent(sword_01)
off_active(sword_01)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
wait_time(TIME_ELAPSED + 0.4)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.4)
setup_small_camera_end(RndCamera007)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ふぅ…こんな感じでどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020023")

	PlayAction(Actor002,"to  Std_Appl")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0045")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:うむ。上出来じゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020024")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0001")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:それにしても今日はやけに協力的じゃのう<br>この前は結構不満そうじゃったのに
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020025")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力

	--★★ノワール★★:まぁ…正直このあいだはあんたの研究に<br>なんの意味があるのかよくわからなかったからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020026")


	--★★ノワール★★:なんの説明もないまま変な実験されたり<br>いきなりバルバロイと戦えって言われたり
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020027")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0029")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:あらためて聞くと<br>ワシなかなかひどいことしとるの～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020028")

	change_face(Actor002,"Smile")

	--★★ブレイズ★★:おぬしがここまで付き合ってくれるのが<br>奇跡に思えてきたわ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020029")

-- ▼直接出力
setup_small_camera_end(RndCamera008)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:まったくだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020030")


	--★★ノワール★★:でも、あんたが研究を通じて本気でバルバロイと<br>戦おうとしているってのはわかったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020031")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:だから俺も、本気で手伝う気になったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020032")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:…ふむ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020033")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:今だってあんたの研究がバルバロイとの戦いに<br>どう活かされるのか、俺にはわからないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020034")


	--★★ノワール★★:あんたはわかったうえでやってるんだろ？<br>だったら任せてもいいかなって思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020035")

-- ▼直接出力
voice_play("VO_101066_sp_0001_3")
-- ▲直接出力

	--★★ブレイズ★★:ノワール…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020036")


	--★★ノワール★★:俺はバルバロイについても継承者についても<br>知らないことばかりだ。考えるのも得意じゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力

	--★★ノワール★★:だからそういうのはあんたに任せる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020038")


	--★★ノワール★★:あんたの研究がかたちになれば<br>バルバロイとの戦いが有利になるかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020039")


	--★★ノワール★★:それにきっと<br>この先、バルバロイと戦う人の助けになる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020040")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:たとえキラーズ因子がなくたって<br>あんたはそうやってバルバロイと戦えるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09020041")


	--★★ブレイズ★★:………キラーズ因子がなくとも、か
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020042")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor002,1.0)
wait_time(0.4)
setup_small_camera_end(RndCamera008)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
change_face(Actor001,"Normal")
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:…バルバロイが標的とするのは<br>体内に含まれるキラーズ因子が高い者とされる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020044")


	--★★ブレイズ★★:…つまりバルバロイが本当に欲しがっているのは<br>人間の記憶ではない
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020045")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:…キラーズ因子とは記憶とつながるもの？<br>…キラーズ因子はバルバロイになにを与える？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020046")


	--★★ブレイズ★★:…じゃとするなら<br>キラーズ因子とバルバロイの関係性とは？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020047")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0033")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:…やれやれ<br>老後の趣味としてはじめたはずの研究じゃのに
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020049")

	change_face(Actor002,"Smile")

	--★★ブレイズ★★:年甲斐もなく<br>興奮してきてしまったわい
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020050")


	--★★ブレイズ★★:若者の期待に応えるためにも<br>これは気張らんといかんのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09020051")

-- ▼直接出力
local trustParam = set_communication_rankup("ブレイズ_コミュランク", "ブレイズ_親密度")
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
	demo_playend_area2adv()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
