-- このluaスクリプトは、CO_101061_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
turn_chara(Actor001,-53.977,0)
lookat_delay_weight(Actor001, 0.8, 0.05, 0.5, 0.2,0.6)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("104000020", "content_still_10400002_image", "104000020_StillImage")
-- ▲直接出力
-- ▼直接出力
 -- prop001 = setup_prop_object(10104008)
off_active(prop001)
 -- prop001_offset = {-0.105,-0.0669,0.00316,51,-256.824,-88.854}
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101030011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:ここだね<br>さっそく手分けして探そう
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020002")

	open_select_window_tag(Actor001,"Normal","CO_101061_09020004","CO_101061_09020005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:周囲は俺が見張っておく<br>このあたりでバルバロイの目撃情報もあるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:じゃ、オレは気兼ねなく探索させてもらうよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020008")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:サンキュー、ノワール！
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020009")

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああいうところは、まだまだ子供だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺が探してくるから<br>お前はここで待っていてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020013")

-- ▼直接出力
PlayPartVoice("ラロゥ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:はぁ～？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020014")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:察しが悪くて不器用なアンタに<br>見つけられるわけないじゃん
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020015")

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そこまで言わなくなっていいじゃないか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020080")

	change_face(Actor001,"Sad")

	--★★ノワール★★:目を離さないようにしなくちゃな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020017")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start(Camera001)
change_face(Actor001, "Surprise")
change_face(Actor002, "Surprise")
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うん…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020019")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:見つけた？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020021")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なあ、壁のこの部分<br>他と比べてすり減ってる気がしないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020022")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:なにかのスイッチになってるのかも
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020023")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラロゥ★★:ちょっと代わってオレが調べてみるから
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020024")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
se_play("SE_ADV_CO_101061_0902_Rock_Touch")
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "悩む")
-- ▲直接出力

	--★★ラロゥ★★:こういうときはだいたいこのあたりに…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020081")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_CO_101061_0902_Switch")
wait_time(0.5)
se_play("SE_ADV_MA_01108_40_Gate")
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:ほらね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020083")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:すごいじゃないか、壁が開いたぞ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020085")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…奥に部屋があるみたいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020086")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:見てくる<br>ノワールはここで待ってて
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020087")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:いや、危ないだろ<br>俺が行くよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020088")

-- ▼直接出力
PlayPartVoice("ラロゥ", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:こういうのは<ruby=オレたち>盗賊</ruby>の仕事<br>騎士様は大人しくしてるもんだよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020089")


	--★★ノワール★★:盗賊だから、騎士だから、とかじゃない<br>仲間を危険な目に遭わせるわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020090")

-- ▼直接出力
PlayPartVoice("ラロゥ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020092")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:仲間だったら信用してよ<br>オレなら大丈夫だから
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020093")

	change_face(Actor001,"Sad")

	--★★ノワール★★:トレジャーハンターだもんな<br>わかった、信用する
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020094")

-- ▼直接出力
se_play("SE_ADV_CO_101061_0902_Rock_Touch")
-- ▲直接出力

	--★★ラロゥ★★:えーと、これかな？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020096")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
se_play("SE_ADV_MA_01108_40_Gate")
hide_image(BLACK_WHITE_TIME)
 -- on_active(prop001)
 -- on_parent(prop001,Actor002, "J_Hand_R", prop001_offset)
template2()
turn_chara(Actor002,-254,0)
turn_chara(Actor001,-34.7,0)
DontChangeRandomCamera(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
setup_small_camera_start()
wait_time(5.5)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
ShowImageItem(104000020)
PlayPartVoice("ラロゥ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:こ、これが…聖杯？<br>ただの古ぼけたコップにしか見えないけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020098")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かに装飾もついてて派手だけど<br>伝説のお宝っぽいオーラはないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020099")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あっ？<br>底になにか古代文字が刻まれてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020100")

-- ▼直接出力
PlayPartVoice("ラロゥ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ほんとだ<br>なになに…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020101")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラロゥ★★:「この地の豊かな実りは<br>　この清らかな杯にあり」
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020102")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:清らかな杯…？<br>なんだか嫌な予感がするな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020103")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:もう一度<br>古文書を読んでみてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020104")

-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★ラロゥ★★:………あっ！？
	Talk(Actor002,"CHRNAME_LAROU","speech","N","CO_101061_09020105")


	--★★ラロゥ★★:ここ「聖なる」じゃなくて<br>正しくは「清廉なる」じゃん！
	Talk(Actor002,"CHRNAME_LAROU","speech","N","CO_101061_09020106")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	close_cutin()

	--★★ノワール★★:古文書を読み違えたわけだな<br>この杯はただの儀式用の道具ってところか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020107")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:オレとしたことが…<br>こんな初歩的なミスをするなんて
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020109")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ！残念だったな<br>こんなこともあるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020111")

-- ▼直接出力
PlayPartVoice("ラロゥ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:…残念？<br>なに寝ぼけたこと言ってんの
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020112")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラロゥ★★:ターゲットは伝説の秘宝だよ<br>むしろ、こうでなくっちゃ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020114")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:こんなカンタンに見つかるものに<br>価値があるわけないじゃん！
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020115")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ノワールだって諦めるつもりはないんでしょ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020116")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、もちろんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020117")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:だったら話は早いよ<br>振り出しに戻ってやり直すだけ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020118")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラロゥ★★:この程度のことで<br>立ち止まってなんていられないね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020119")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラロゥは前向きだな<br>ところでその杯はどうするんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020120")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:せっかくだし持って帰るよ<br>これはこれでなにか役に立つかもしれないし
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020121")


	--★★ラロゥ★★:売っても大した金には<br>ならないだろうけどね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020122")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:手に入れたのはお前だから<br>どうするかは任せるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020123")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:もしも持ち主や杯の用途を知る人が現れたら<br>譲ってやってほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020124")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラロゥ★★:えー？<br>そんなの盗賊の仕事じゃないよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020125")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:まあ<br>気が向いたら考えなくもないけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020126")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:気が向いたらでもいいからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020127")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:さて、帰ろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020129")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end()
wait_time(1.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "挨拶")
-- ▲直接出力

	--★★ラロゥ★★:あのさ、ノワール<br>さっきのことなんだけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020130")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020131")


	--★★ラロゥ★★:守ろうとしてくれたのは仲間だからってだけ？<br>オレが…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020132")

	open_select_window_tag(Actor001,"Normal","CO_101061_09020133","CO_101061_09020134","CO_101061_09020135")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:危険だって思われるところに<br>仲間を行かせるわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020137")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラロゥじゃなくてもそうしたさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020138")

	change_face(Actor002,"Anger")

	--★★ラロゥ★★:…あっそ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020139")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:仲間だからってだけじゃないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020141")

-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:…えっ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020142")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:大人の男として<br>子供は守ってやりたいからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020143")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:ふーん<br>大人の男って大変だね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020144")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ラロゥが可愛いからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020146")

-- ▼直接出力
PlayPartVoice("ラロゥ", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:可愛い？オレが？<br>バッカじゃないの、そんなわけじゃないじゃん
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020147")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:可愛いさ<br>きょうだいみたいで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020148")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:…そういうことか<br>ま、そうだよね、別にいいけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020149")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020150")

	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:久々にデカイ仕事したからか<br>お腹空いちゃったよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020152")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:なにか食べて帰るか？<br>頑張ってくれたお礼におごるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020153")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:本当？<br>じゃあ、ロンディニウムのあの店がいい
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09020154")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:わかった<br>ロンディニウムに寄ってから帰ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09020155")

-- ▼直接出力
local trustParam = set_communication_rankup("ラロゥ_コミュランク", "ラロゥ_親密度")
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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("104000020", "content_still_10400002_image", "104000020_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101030011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
