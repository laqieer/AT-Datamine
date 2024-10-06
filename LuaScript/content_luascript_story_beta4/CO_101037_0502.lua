-- このluaスクリプトは、CO_101037_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
sword001 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
off_active(sword001)
sword001_offset  = {-0.07,-0.02,0,0,-170,0}
on_parent(sword001,Actor001, "J_Hand_R", sword001_offset)
off_parent(sword001)
-- ▲直接出力
-- ▼直接出力
sword002 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
off_active(sword002)
sword002_offset  = {-0.07,-0.02,0,0,-170,0}
on_parent(sword002,Actor003, "J_Hand_R", sword002_offset)
off_parent(sword002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002, {-2.739, 0,0.58699})

-- ▲直接出力
-- ▼直接出力
set_pos(Actor001, {-3.52, 0, -1.69})

-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Speculation")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
character_in_move_walk(Actor001,CharaPos005,1.6,0)
turn_chara(Actor001,25,0.2)
character_in_move_walk(Actor002,CharaPos006,1.3,0)
wait_time(0.5)
-- ▲直接出力

	--★★ラシア★★:………
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020002")


	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020003")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:目撃されたってのはこのあたりか？<br>洞窟もあるし、身を隠すには最適だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:川がありますし<br>水にも困らなさそうです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:それにしてもローマ兵か<br>脱走兵かなにかだろうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020007")

-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:ローマの情勢は逃げ出したくなるほど<br>悪いのでしょうか…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020008")


	--★★ノワール★★:ルーシャスやヴェルナルス先生から<br>聞いていないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020009")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:なにも…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020011")


	--★★ラシア★★:私はそんな連絡をもらえるような<br>関係ではありませんから…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラシア★★:………
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020014")

	open_select_window_tag(Actor001,"Normal","CO_101037_05020016","CO_101037_05020017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんだか喉が渇いたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020019")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:お水、よかったら…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:大丈夫だ、自分のぶんは持ってきてるから<br>…その、よかったら少し休んでいかないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020022")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:えっ？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ラシア★★:…はい
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:出発してから結構歩いたし<br>そろそろ疲れてるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここで少し休もうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020028")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラシア★★:まだまだ元気ですよ！<br>ほら、このとおり…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020029")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_CO_101011_0202_Bodyfall")
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor002,"Surprise")

	--★★ラシア★★:きゃあっ！？
	Talk(Actor002,"CHRNAME_RASIA","speech","N","CO_101037_05020030")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
CloseTalkWindow()
wait_time(1.2)
setup_small_camera_end()
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	close_cutin()
	change_face(Actor002,"Sad")

	--★★ラシア★★:いたたたた…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020032")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:無理しちゃダメだ<br>少し休んでいこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020033")

-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:すみません<br>気を遣わせてしまいましたね…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020035")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ずっと浮かない感じだったからさ<br>ローマのことが気がかりなんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラシア★★:そう…ですね…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:正確には<br>ヴェルナルス先生のこと、か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020038")


	--★★ラシア★★:このあいだ<br>ヴェルナルス様から手紙が届いたんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020040")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ヴェルナルス先生から！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:内容を聞いてもいいか？<br>もちろん話せる範囲で構わないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020042")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:私に元気でいるか、って<br>すごく短いけど、すごくあの方らしい内容でした
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020043")


	--★★ラシア★★:でもどんな内容でも、ヴェルナルス様が<br>手紙を送ってきたこと自体珍しいんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:なにか大変なことが<br>あの方の身に起こっているのかも…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020046")

	open_select_window_tag(Actor001,"Normal","CO_101037_05020048","CO_101037_05020049")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今はローマから手紙を出すことは<br>かなり難しいはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020051")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:それなのにわざわざ手紙を送って来たのは<br>ラシアのことが心配なんだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020052")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
on_active(sword002)
on_parent(sword002,Actor003, "J_Hand_R", sword002_offset)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:そうでしょうか…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020053")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか別のメッセージが<br>込められてたりするんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:私も最初はそう思いました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020056")

	change_face(Actor002,"Sad")

	--★★ラシア★★:暗号が隠されているんじゃないかとか<br>あぶり出しの可能性があるんじゃないかとか
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020057")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:いろいろと調べてみたんですけど<br>それらしき形跡はありませんでした
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020058")

-- ▼直接出力
Appear(Actor003)
on_active(sword002)
on_parent(sword002,Actor003, "J_Hand_R", sword002_offset)
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020059")

	goto Block2end

::Block2end::
-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
se_play("SE_ADV_CO_101037_0502_Grass_Move")
-- ▲直接出力
-- ▼直接出力
wait_time(1.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
turn_chara(Actor001,45,0.0)
SkipDefaultMotion(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("兵士2", "驚き")
-- ▲直接出力

	--★★ローマ兵士_下位★★:あなたは…
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020061")

-- ▼直接出力
setup_small_camera_start(Camera001)
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
on_active(sword001)
on_parent(sword001,Actor001, "J_Hand_R", sword001_offset)
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ローマ兵か！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020062")

-- ▼直接出力
bgm_play("BGM_ADV_Speculation")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
CloseTalkWindow()
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:ノワール、待ってください
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ラシア★★:私のことを知っているんですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020066")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("兵士2", "肯定")
-- ▲直接出力

	--★★ローマ兵士_下位★★:以前、ヴェルナルス大将軍と一緒のところを<br>お見かけしたことがあります
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020067")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ラシア★★:目撃されたローマの兵というのは<br>この方かもしれませんね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020070")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
off_parent(sword001)
off_active(sword001)
off_parent(sword002)
off_active(sword002)
setup_small_camera_end()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("兵士2", "悲しみ")
-- ▲直接出力

	--★★ローマ兵士_下位★★:恥ずかしながら、逃げ出してきました
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020072")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:今のローマは魔女という強力な後ろ盾を得て<br>勢いづいているのでは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020074")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("兵士2", "驚き")
-- ▲直接出力

	--★★ローマ兵士_下位★★:後ろ盾なものですか！
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020075")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ローマ兵士_下位★★:ルーシャス様が引き入れた魔女たちは<br>次々とバルバロイを呼び出し
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020076")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ローマ兵士_下位★★:今ではカレドニアの地だけでなく<br>ローマ軍のなかにもバルバロイが跋扈しています
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020077")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ローマ兵士_下位★★:毎日、たくさんの同僚、同胞たちが<br>姿を消しています
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020078")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ローマ兵士_下位★★:もはやあそこは軍ではない<br>バルバロイの餌場です
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020080")


	--★★ローマ兵士_下位★★:だから俺はローマを出ました
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020081")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ローマ兵士_下位★★:俺にバルバロイと戦う力はありませんが<br>それでも残った仲間や遠くにいる家族を助けたい
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020082")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("兵士2", "悲しみ")
-- ▲直接出力

	--★★ローマ兵士_下位★★:お願いします、ローマを救ってください…
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020083")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:ノワール<br>この方を亡命させられないでしょうか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020085")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ひとまず城まで来てもらおう<br>ケイが相談に乗ってくれると思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_05020087")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラシア★★:わかりました、そうしましょう
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020088")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ラシア★★:私たちと<br>一緒に来てくれますか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_05020090")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("兵士2", "肯定")
-- ▲直接出力

	--★★ローマ兵士_下位★★:はい、もちろん！<br>ありがとうございます…
	Talk(Actor003,"NPCNAME_0082","speech","N","CO_101037_05020091")

-- ▼直接出力
local trustParam = set_communication_acquired("ラシア_コミュランク", "ラシア_親密度")
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
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
sword001_offset  = {-0.07,-0.02,0,0,-170,0}
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
sword002_offset  = {-0.07,-0.02,0,0,-170,0}
preload_sound("BGM_ADV_Speculation")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
