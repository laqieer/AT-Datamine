-- このluaスクリプトは、CO_101037_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110081_02","110081_02_h")
Include("content_adv_advsmall_110081_02","Template110081_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110081_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110081_02,CameraPos110081_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110081_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110081_02,CameraPos110081_02_008)
	InitializeTemplateRandomCamera110081_02()
	InitializeTemplate110081_02()
-- ▼直接出力
prop001 = setup_prop_object(10104007)
set_pos(prop001 , {15.732,0.831,36.772})
prop002 = setup_prop_object(10104007)
set_pos(prop002 , {16.8,0.831,36.772})
set_rot(prop002,{0, -180, 0})
prop003 = setup_prop_object(10104014)
set_pos(prop003 , {16.29,0.816,36.839})
set_rot(prop003,{0, 90, 0})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110081)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:このサンドイッチ、全部ラシアの手作りか？<br>すごく多いな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020002")

-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:ふたりで食べるつもりだったから<br>ちょっと多めに作っちゃったんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:なるほどね<br>ヴェルナルス先生ってよく食べるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:そうですね、体も大きいですし<br>たくさん召し上がりますよ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:どれもおいしそうだ<br>このなかで一番の自信作は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020007")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア★★:この鶏肉を挟んだものでしょうか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020008")


	--★★ラシア★★:スパイスで焼いた鶏肉と<br>クリーミーなソースが合いますよ
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ！<br>じゃ、まずはそれから食べてみようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020010")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
se_play("SE_ADV_MA_01C110_35_Food_Eat")
wait_time(1.5)
setup_small_camera_end()
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Smile")

	--★★ノワール★★:…うん！<br>ソースが甘酸っぱくて、すごくおいしい
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101037_03020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	close_cutin()

	--★★ラシア★★:隠し味にヨーグルトを少し入れてます
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020013")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なるほど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…そういえば、なんで先生とランチを？<br>このあいだも買い物に行ったって話をしてたし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020016")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア★★:私はローマ出身で、ヴェルナルス様には<br>小さな頃から良くしてもらっていたんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:ふうん、小さな頃から…<br>親戚かなにかか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:はい。といっても、遠い親戚ですけどね<br>数年に一度、顔を合わせるくらいでした
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020019")


	--★★ラシア★★:ただ…私にとってはただの親戚ではなくて<br>命の恩人、という部分が大きいです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:命の恩人だって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020022")

	change_face(Actor002,"Normal")

	--★★ラシア★★:私の実家はローマの田舎にあって<br>そこで牧畜業を営んでいました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ああ、だから乳搾りだったり<br>ヨーグルトを作ったりができるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:はい。ただ、あるときふとしたトラブルで<br>家が経営難に陥ってしまって…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020025")


	--★★ラシア★★:私はお金と引き換えに<br>売られそうになりました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:そんなときに私を助けてくれたのが<br>ヴェルナルス様だったんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020027")


	--★★ラシア★★:ヴェルナルス様はそれからしばらく<br>私の面倒を見てくれただけでなく
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ラシア★★:「騎士になりたい」と言い出した私を<br>全面的にバックアップしてくれました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力

	--★★ラシア★★:おかげでこの学園に通うことができて…<br>フレンとローラとも再会できたんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101037_03020033","CO_101037_03020034","CO_101037_03020035")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ローマから離れたこの地で再会なんて<br>ふたりも驚いただろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:それはもう、すごく
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020038")

	change_face(Actor002,"Smile")

	--★★ラシア★★:でも驚きよりも嬉しさが強かったです<br>３人で抱き合って泣いてしまったくらいです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:良かったな、本当に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020040")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:はい！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:３人はそういう運命だったんだろうな<br>神様の思し召しっていうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:私もそんな気がします
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020044")

	change_face(Actor002,"Smile")

	--★★ラシア★★:そうでなければ、ここログレスで<br>ふたりと再会なんてできないと思います
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020045")

-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:本当にこの学園に来てよかった
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020046")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もラシアと出会えて良かったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020048")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:本当ですか！？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020049")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ。こうやってふたりで楽しく<br>美味しいランチを食べられるしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020050")

-- ▼直接出力
PlayPartVoice("ラシア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラシア★★:あ、ありがとう…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020051")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…どうした？顔、赤くないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020052")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Shy")

	--★★ラシア★★:えっ！？き、気のせいですよっ！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020053")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴェルナルス先生にフレンとローラか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020055")


	--★★ノワール★★:あの３人と知り合いなら<br>ルーシャスのことも昔から知ってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	open_cutin(1,1)
	on_cutin(1,Actor002,"Surprise")

	--★★ラシア★★:まさか！あの方は皇族ですよ！？<br>この学園で初めてお目にかかりました
	Talk(Actor002,"CHRNAME_RASIA","speech","N","CO_101037_03020057")

	close_cutin()

	--★★ノワール★★:それもそうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020059")

-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:あの…ノワール<br>お願いがあるんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020060")


	--★★ラシア★★:私とヴェルナルス様が親戚だってこと<br>他のみんなには黙っていてもらえますか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020061")

-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:私みたいなおっちょこちょい娘が<br>身内だって知られてしまったら
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020062")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラシア★★:ヴェルナルス様の迷惑になってしまうから…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020063")

	open_select_window_tag(Actor001,"Normal","CO_101037_03020065","CO_101037_03020066","CO_101037_03020067")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった。言わない<br>でも、先生は迷惑だなんて思ってないはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020069")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:えっ？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020070")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:自分のことを想って<br>一緒にご飯を食べようと誘ってくれる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020071")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:そういう存在って<br>なによりも大事にしたいもんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020072")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だからそんなに自分のことを<br>卑下しなくてもいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020073")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:知られてしまっても問題ないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020075")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:ヴェルナルス先生は<br>そんなことを恥ずかしがる人じゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020076")

	change_face(Actor002,"Smile")

	--★★ラシア★★:そう、でしょうか…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020077")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:みんなもそれを知ったからって<br>ラシアや先生を色眼鏡でみたりしないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020078")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	change_face(Actor001,"Smile")

	--★★ノワール★★:もうバレてたりして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020080")

-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:私とヴェルナルス先生が<br>知り合いだってことをですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020081")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あ、いや、そっちじゃなくて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020082")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ごめんごめん、俺の勘違い<br>大丈夫だと思う。バレてないと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020084")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:励ましてもらえるのは嬉しいですけど<br>おっちょこちょいな自分がいつも嫌になります
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020086")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:気にしない気にしない<br>同じ失敗を繰り返さなけばいいのさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020087")


	--★★ノワール★★:俺だっていつも失敗ばっかりで<br>妹にドヤされてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020088")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:そうなんですか！？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020089")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:実はそうなんです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020090")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:あの…ありがとうございます<br>少し気持ちが楽になりました
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03020092")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:俺でよければ<br>いつでも相談に乗るよ<br>
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03020093")

-- ▼直接出力
local trustParam = set_communication_acquired("ラシア_コミュランク", "ラシア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
setup_prop_object_preload(10104007)
setup_prop_object_preload(10104007)
setup_prop_object_preload(10104014)
	InitializeLoad_Preload()
	load_area_scene_preload(110081)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110081_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
