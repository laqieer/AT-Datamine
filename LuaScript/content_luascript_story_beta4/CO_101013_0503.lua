-- このluaスクリプトは、CO_101013_0503.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("市民_男2", "悲しみ")
-- ▲直接出力

	--★★市民（男）★★:た、大変だーっ！
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101013_05030002")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:ど、どうしたの！？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05030003")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男2", "苦しみ")
-- ▲直接出力

	--★★市民（男）★★:お、俺たちの村にバルバロイが出たんです！ログレスに救助要請を出してきてもらえませんか
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101013_05030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:大丈夫、心配いらないわあたしたちがそのログレスの人間だから！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05030005")


	--★★ラグネル★★:バルバロイなら任せて！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05030006")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定2")
-- ▲直接出力

	--★★市民（男）★★:ほ、本当に…！？よかった、みんな助かるかもしれない…！
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101013_05030007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_05030009","CO_101013_05030010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ヴェルナルス先生は急いでほしいって言ってたロンディニウムに行ったほうが良くないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05030012")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:それはそうだけどよ…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05030013")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:目の前で困ってる人がいるのに放っておけるわけねーだろ！！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05030014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:うん、そうだよね！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05030015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:ガウェインこの人たちの村を助けに行こう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05030017")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:おうよ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05030018")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:ヴェルナルス先生の頼まれごともあるんだソッコー片付けちまおうぜ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05030019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:そうこなくっちゃ！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05030020")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:あんたたちの村に案内してくれ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05030022")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定3")
-- ▲直接出力

	--★★市民（男）★★:は、はいこっちです…！
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101013_05030023")

-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(0.3)
se_play("SE_ADV_CO_101013_0503_Foot_Grass_3_Peaple")
wait_time(FADE_TIME)
wait_time(TIME_ELAPSED + 1.0)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:思いの他手間取っちまったな…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05030025")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:予想していたよりも<br>バルバロイの数が多かった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05030026")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定2")
-- ▲直接出力

	--★★市民（男）★★:みなさんこのたびは本当にありがとうございました
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101013_05030027")


	--★★市民（男）★★:おかげで村の被害もほとんどありませんでしたなんとお礼を言っていいやら
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101013_05030029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:礼なんていいってバルバロイを倒すのが俺たちの仕事だしよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05030030")

-- ▼直接出力
PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:ガウェイン、ガウェイン船の時間がやばいよ。急いだほうがよさそう
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05030031")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:やべ、そっか！話の途中で悪いけど、俺たち急いでるんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05030032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:他に困ったことがあったらいつでもログレスに来てくれ。じゃな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05030033")

-- ▼直接出力
 --黒背景に移行
CloseTalkWindow() --疑似バトルならclose_speech_window(
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男2", "挨拶")
-- ▲直接出力

	--★★市民（男）★★:えっ？あの、ちょっと…
	Talk(Actor004,"NPCNAME_0187","speech","N","CO_101013_05030035")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ5_4")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
