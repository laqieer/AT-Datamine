-- このluaスクリプトは、CO_101013_0304.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003, "J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("104000050", "content_still_10400005_image", "104000050_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:ねえ、暗くなってきたよ？<br>そろそろ帰らない？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_03040002")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:くそー、ここまで来たのに収穫なしかぁ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040003")


	--★★ガウェイン★★:あの人だったら<br>サクッと見つけてんだろうなあ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:あの人って、ガウェイン憧れの？<br>虫捕りも上手かったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03040005")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ラグネル★★:そんな話は聞いたことないけど
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_03040006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:きっとできるさ<br>だってヒーローってなんでもできるもんだろ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040007")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういうもんか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03040008")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Surprise")

	--★★子供（男）★★:…あれ？
	Talk(Actor004,"NPCNAME_0248","speech","L","CO_101013_03040010")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力

	--★★ガウェイン★★:どした、トム？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040011")

-- ▼直接出力
ShowImageItem("104000050")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）★★:…金色の、蝶？
	Talk(Actor004,"NPCNAME_0248","speech","L","CO_101013_03040013")

-- ▼直接出力
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_03040015","CO_101013_03040016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガウェイン、ぼーっとしてる場合じゃないぞ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03040018")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:キンイロチョウだ！<br>あれがきっとキンイロチョウだ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03040019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:そ、そっか！<br>おっし、捕まえてやるぜ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040020")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:へえ<br>金色に輝く蝶か、綺麗だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03040022")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:綺麗だな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:…じゃねえよ！<br>あれがキンイロチョウだろ、捕まえねえと！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040024")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Joy")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Smile")

	--★★ガウェイン★★:よーし、捕まえた！<br>待たせたなトム、これを親父さんに…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","N","CO_101013_03040026")

	close_cutin()
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:え？えっ、なんだこれ！？<br>急に輝きが弱弱しくなって…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040028")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:…消えちまった
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラグネル★★:せっかく捕まえたのに！<br>あんたが強く握りすぎたんじゃないの！？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_03040032")

-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:強く握ってなんかいねーって！<br>手の平で優しく包み込むように捕まえたって！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040033")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん<br>なにか特別な生態をもつ蝶なのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03040034")


	--★★ノワール★★:どこかで<br>ちょっと調べてみたほうがいいかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03040035")

-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:そうだね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_03040036")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:…トム、ごめんな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★子供（男）★★:ううん<br>ガウェインお兄ちゃんは悪くないよ
	Talk(Actor004,"NPCNAME_0248","speech","L","CO_101013_03040038")


	--★★子供（男）★★:それにさっきのキンイロチョウも<br>死んじゃったわけじゃないし
	Talk(Actor004,"NPCNAME_0248","speech","L","CO_101013_03040039")

-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力

	--★★子供（男）★★:また今度捕まえに来よう！
	Talk(Actor004,"NPCNAME_0248","speech","L","CO_101013_03040040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:ああ、そうだな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03040041")

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
load_image_preload("104000050", "content_still_10400005_image", "104000050_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
