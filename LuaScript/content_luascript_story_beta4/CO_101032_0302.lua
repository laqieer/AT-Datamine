-- このluaスクリプトは、CO_101032_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",340,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",240,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",120,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401018","001","401018001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.7)
PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力

	--★★リオネス★★:なあなあ、そのスープってどんな味なんだ？肉は入ってるか？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_03020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "悩む")
-- ▲直接出力

	--★★ガレス★★:野菜をふんだんに使ったスープなんだって
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020003")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ガレス★★:村の近くの炭鉱で働く労働者のために村に住む料理人が考案したそうなんだけど
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:しばらく前に炭鉱が閉じてしまってからは作る人がいなくなっちゃったんだって
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020005")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:炊き出しってやつか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03020006")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("リオネス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リオネス★★:チェッ、野菜スープかぁ…お肉たっぷりのやつがよかったなあ
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_03020007")

	change_face(Actor002,"Surprise")

	--★★ガレス★★:もうじき、その村に着くから…あっ！あの子、なにか知らないかな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020008")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",0.5)
-- ▲直接出力
-- ▼直接出力
 --暗転＆時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Appear(Actor005)
keep_ik_lookat(Actor001,Actor005,"J_Head")
keep_ik_lookat(Actor002,Actor005,"J_Head")
keep_ik_lookat(Actor003,Actor005,"J_Head")
setup_small_camera_start()
wait_time(0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:この近くの村にスープ作りの達人がいるって<br>聞いてきたんだけど、なにか知らないかな？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020010")

-- ▼直接出力
PlayPartVoice("子供_女2", "肯定")
-- ▲直接出力

	--★★子供（女）②★★:スープ作りの達人？<br>もしかして、わたしのおばあちゃんのことかな
	Talk(Actor005,"NPCNAME_0275","speech","N","CO_101032_03020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:きみのおばあちゃんなのか！？<br>すごい偶然だな～♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020012")


	--★★子供（女）②★★:昔はそう言われてたみたいだけどもうスープを作るのはやめちゃったって
	Talk(Actor005,"NPCNAME_0275","speech","N","CO_101032_03020013")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガレス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★リオネス★★:ええっ！なんでだ！？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_03020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:詳しく話を聞かせてほしいな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020015")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_女2", "肯定2")
-- ▲直接出力

	--★★子供（女）②★★:じゃあ、おばあちゃんを呼んでくるね<br>すぐそばの畑で仕事してると思うから
	Talk(Actor005,"NPCNAME_0275","speech","N","CO_101032_03020016")

-- ▼直接出力
 --暗転＆時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Appear(Actor004)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民中年_女2", "挨拶")
-- ▲直接出力

	--★★市民（中年女）②★★:あんたらかいスープのこと知りたいってのは
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020018")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力

	--★★ガレス★★:そうなんだとびきり美味しいスープを作りたくて
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020019")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女2", "悩む")
-- ▲直接出力

	--★★市民（中年女）②★★:あのスープのことを言ってるんだろうけど残念ながらあたしには作れないんだよ
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020021")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？あなたがスープ作りの達人なんですよね？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03020022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_女2", "肯定")
-- ▲直接出力

	--★★市民（中年女）②★★:もう時効だろうから打ち明けるけどねあれを作っていたのは亡くなった兄なんだ
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020023")


	--★★市民（中年女）②★★:それをあたしが配って回ってたらあたしが作ったって誤解されちゃったのさ
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020024")

-- ▼直接出力
PlayPartVoice("ガレス", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:それじゃあもうそのスープは飲めないのか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_女2", "肯定2")
-- ▲直接出力

	--★★市民（中年女）②★★:レシピは一応残ってはいるけど…見てみるかい？
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020026")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:レシピがあるのか！ぜひ見せてほしい
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020027")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★リオネス★★:作れそうか、ガレス？
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_03020029")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:うーん、丁寧に書かれたレシピだから作れそうではあるんだけど
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020030")

	change_face(Actor002,"Sad")

	--★★ガレス★★:聞いたことのない食材があるんだよね『マイントリュフ』…？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020031")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_女2", "肯定")
-- ▲直接出力

	--★★市民（中年女）②★★:ああそれは近くの炭鉱で採れるキノコだよ
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★市民（中年女）②★★:鉱石の近くにだけ生える香り豊かで栄養たっぷりなキノコなんだ
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020033")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★市民（中年女）②★★:炭鉱が閉鎖されてからはめったに出回らなくなっちゃったけどね
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020034")

	open_select_window_tag(Actor001,"Normal","CO_101032_03020036","CO_101032_03020037")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:閉鎖された鉱山でだけ採れるキノコか残念だけど諦めよう、ガレス
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03020039")

	change_face(Actor001,"Normal")

	--★★ノワール★★:他を当たったほうがよくないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03020040")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ガレス★★:いやわたしはこのスープを作ってみたい！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020041")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガレス★★:このスープを作ることでなにか掴める気がする料理人のカンがそう言ってるんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020042")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その炭鉱に行ってみよう、ガレス
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03020044")

-- ▼直接出力
PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:でも、危なくないか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_03020045")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:バルバロイが出て危険なら倒せばいいここには強～いキラーズとマスターがいるだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03020046")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:任せとけ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_03020047")

	goto Block1end

::Block1end::
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.8)
wait_time(0.4)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その炭鉱に行ってみたいんですがどうすればいいかわかりますか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_03020049")

-- ▼直接出力
PlayPartVoice("市民中年_女2", "肯定")
-- ▲直接出力

	--★★市民（中年女）②★★:村長に聞いてあげるよ
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020050")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★市民（中年女）②★★:キラーズとそのマスターがいるなら立ち入りの許可も出ると思うよ
	Talk(Actor004,"NPCNAME_0255","speech","N","CO_101032_03020051")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガレス_ランクアップ3_3")
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
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401018","001","401018001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
