-- このluaスクリプトは、CO_101030_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_005)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.9, 0.6} , 1)
keep_ik_lookat(Actor002,Actor003,"J_Head")
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.9, 0.6} , 1)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{0.36,-0.232,1.984})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力

	--★★子供（男）②★★:エレインお姉ちゃん！ノワールお兄ちゃん！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020002")

-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:すっかり元気になったみたいね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:よかった、安心したよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、どうしてあのときひとりでここを出て行ったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020005")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男2","0037")
-- ▲直接出力

	--★★子供（男）②★★:ごめんなさい…ぼく、どうしてもお姉ちゃんに会いたくて
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020006")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:えっ？私に会いに…？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020007")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:お屋敷で使用人さんたちがお姉ちゃんが大ケガしたって話してたから
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020008")


	--★★子供（男）②★★:お見舞いをしてあげたかったんだけど…
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020009")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★子供（男）②★★:お姉ちゃんたち迷惑かけちゃった本当にごめんなさい
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_09020012","CO_101030_09020013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:無事でよかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020015")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:トビーがいなくなったときいてエレインなんか半泣きだったんだぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020016")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:せ、先輩っ！<br>そんなことは…ありますけど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:無茶をするな！みんながどれだけ心配したと思ってる！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020019")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("子供_男2","0019")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）②★★:ううっ…
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020020")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★市民（中年男）★★:ま、まあまあ、ノワールさん…
	Talk(Actor004,"NPCNAME_0272","speech","L","CO_101030_09020021")

-- ▼直接出力
voice_play("VO_101030_sp_0001_3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:先輩そんなに怒ったら可哀そうですよ…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020022")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★エレイン★★:私があんなことを言ったからロンディニウムに行ったんだとばかり…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020024")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）②★★:あんなこと？
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020025")


	--★★子供（男）②★★:お父さんの…ことだね
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:ぼくねなんとなくわかってたんだ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020027")


	--★★子供（男）②★★:ロンディニウムの戦いのあとたくさんの人が街を出て行ったけど
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020028")


	--★★子供（男）②★★:戻ってきた人も大勢いたでも、お父さんはいなかったんだ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020029")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）②★★:だから、なんとなくわかった
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020030")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力

	--★★エレイン★★:トビーくん…あのとき嘘をついてしまってごめんなさい…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020032")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_男2", "否定")
-- ▲直接出力

	--★★子供（男）②★★:ぼく、目はよく見えなくなっちゃったけど
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★子供（男）②★★:その代わりに、人が話してるときに気持ちがわかるようになった気がするんだ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020034")


	--★★子供（男）②★★:あのときのお姉ちゃんはぼくのために泣いてくれてた
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020035")

-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:悲しかったけど、嬉しかったよ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★子供（男）②★★:ぼく、かわろうと思うんだ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020038")


	--★★子供（男）②★★:お母さんが死んじゃってお父さんも戻ってこないもう生きていたくないって思ってたけど
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020039")


	--★★子供（男）②★★:エレインお姉ちゃんがここに連れてきてくれてみんなのお手紙を読んでくれた
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020040")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★子供（男）②★★:元気になってお姉ちゃんたちに恩返ししたい
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020041")


	--★★子供（男）②★★:早く目を治していろいろ見られるようになりたい
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020042")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力

	--★★子供（男）②★★:お兄ちゃんが着てるっていう変なコートとかお姉ちゃんのお顔とか！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エレイン", "否定")
-- ▲直接出力

	--★★エレイン★★:私の顔なんて別に見る必要ないわ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020044")

	PlayAction(Actor003,"to  Std_Talk")

	--★★子供（男）②★★:だってお姉ちゃんは『アストラットの美姫』なんでしょ？
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020045")

-- ▼直接出力
local select_flag = false
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:お姉ちゃんの心はほかの誰よりもキレイに見えるよ？
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020046")

	open_select_window_tag(Actor001,"Normal","CO_101030_09020048","CO_101030_09020049")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:わかってるな、トビー
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020051")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:そのとおりだエレインほど心の綺麗な女性はいない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020052")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）②★★:だよね！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020053")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
select_flag = true
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…だってさ、エレイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020055")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）②★★:自信をもっていいよ！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020056")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もトビーの意見に賛成だキミほど心の綺麗な女性はいないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020057")

	goto Block2end

::Block2end::
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:せ、先輩！や、やめてください、恥ずかしいです…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020059")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "喜び")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）②★★:あははっ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020060")

-- ▼直接出力
if select_flag == true then
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
end
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうしたんだ、トビー<br>突然笑いだして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★子供（男）②★★:ノワールお兄ちゃんと話してるときはね
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020062")


	--★★子供（男）②★★:エレインお姉ちゃんの心がすごくポカポカしてるように見えるんだ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020063")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:これってエレインお姉ちゃんがノワールお兄ちゃんのことを好…
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020064")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "怒り")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")

	--★★エレイン★★:トビーくんッ！？余計なことを言うと怒るわよ！
	Talk(Actor002,"CHRNAME_ELAINE","speech","N","CO_101030_09020065")

	close_cutin()
-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("子供_男2","0044")
-- ▲直接出力

	--★★子供（男）②★★:ご、ごめんなさい！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_09020066")

-- ▼直接出力
local gopos = {-6.47, -0.232, -10}
local TURN_TIME = 0.1
local MOVE_TIME = 2
local MAN_WAIT_TIME = 0.2
local SPACE_TIME = MAN_WAIT_TIME - TURN_TIME
CloseTalkWindow()
PlayActionDirect(Actor003,"to Wlk")
--turn_chara(Actor003,-150,0.1)
turn_lookat_position(Actor003, gopos, TURN_TIME)
wait_time(TURN_TIME)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003, gopos, MOVE_TIME)
wait_time(0.3)
--ノワールとエレインの向きを変更------------------------
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,165,0.4)
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,180,0.4)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
--------------------------------------------------------
wait_time(MAN_WAIT_TIME)
PlayActionDirect(Actor004,"to Wlk")
--turn_chara(Actor004,-150,0.1)
turn_lookat_position(Actor004, gopos, TURN_TIME)
wait_time(TURN_TIME)
PlayActionDirect(Actor004,"to Run")
slidemove(Actor004, gopos, MOVE_TIME)
wait_time(SPACE_TIME) --0.1
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(MOVE_TIME - SPACE_TIME) --0.1
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:まったくもう！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020068")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:救えたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020069")

-- ▼直接出力
lookat_delay_weight_reset(Actor002,1.0)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,117,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:え？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020070")

	change_face(Actor001,"Smile")

	--★★ノワール★★:トビーを救ってやれたな『アストラットの美姫』が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020071")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:…はいまだはじめの一歩を踏み出せたくらいですけど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020072")

	change_face(Actor002,"Smile")

	--★★エレイン★★:ここから自信を持って歩いて行こうと思います
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020073")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:それで、あの…さっきトビーくんの言ったこと真に受けないでくださいね！？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020075")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:トビーの言葉？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020076")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、「変なコート」のことか？気にしてないよ、言われ慣れてるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020077")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:でも、ちょっとサイズが合ってないだけでそこまで変だとは思わないんだけどなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09020078")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:…え？あ、ああ、はい、そうですね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09020079")

-- ▼直接出力
local trustParam = set_communication_rankup("エレイン_コミュランク", "エレイン_親密度")
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
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
