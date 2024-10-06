-- このluaスクリプトは、CO_101022_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110231_11","110231_11_h")
Include("content_adv_advsmall_110231_11","Template110231_11_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110231_11_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110231_11,CameraPos110231_11_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110231_11_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110231_11,CameraPos110231_11_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110231_11_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110231_11,CameraPos110231_11_005)
	InitializeTemplateRandomCamera110231_11()
	InitializeTemplate110231_11()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110231)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:特徴、背格好も一致<br>間違いねえこいつだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020002")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:な、なんだよ、急に？
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020003")


	--★★キャメロット騎士学術院（男）②★★:モルドレッドくんに、ノワールくん？<br>ぼくにいったい何の用だ？
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:単刀直入に言う
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020005")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:アーサー王の<br>不穏なウワサを流したのはてめえだな？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020006")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:は、はぁっ！？
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020007")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）②★★:な、なんだよそれ<br>ぼくはそんなことをした覚えはないよ
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020008")

-- ▼直接出力
PlayPartVoice("モルドレッド", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:残念ながら<br>てめえから聞いたって証言が何件もある
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020009")

	change_face(Actor002,"Smile")

	--★★モルドレッド★★:言い逃れはできねえぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:別に罰を与えようとかじゃない<br>流布するのをやめてくれればいいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020011")


	--★★ノワール★★:ただ、なぜそんなウワサを流したのか<br>それだけは教えてほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020012")

-- ▼直接出力
PlayPartVoice("男子2", "怒り")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:理由？
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:そんなの、決まってるだろ…
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020016")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020017")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("男子2", "苦しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:それが、本当のことだからだよ！！
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020019")

-- ▼直接出力
PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:は？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020020")

	PlayAction(Actor003,"to  Std_Angry")

	--★★キャメロット騎士学術院（男）②★★:今までアーサーがやってきたことは全部嘘だ！<br>この学園にバルバロイが好む『餌』を集め
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020021")


	--★★キャメロット騎士学術院（男）②★★:キラーズやバイブス持ちを一網打尽にして<br>世界を掌握するためにこの学園を運営していた！
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）②★★:最初から…ッ、最初からぼくたちを<br>裏切って、絶望させるために…！
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020023")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子2", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:ッく、ヒック…そうじゃなきゃ、<br>なんでッアーサー様が、あんなこと…！
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020025")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:掌返しが起こるケースのひとつだな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020028")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:慕う気持ちが強すぎて<br>裏切られたショックがデカすぎて…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020029")


	--★★モルドレッド★★:その衝撃で、くるっと綺麗にひっくり返るんだ<br>真逆の立場にな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020030")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.6)
wait_time(0.5)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:おいてめえ、いい加減泣き止みやがれ<br>泣いたところで事態は好転しねえぞ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020032")

	PlayAction(Actor003,"to  Std_Sad02")

	--★★キャメロット騎士学術院（男）②★★:うぅ…だ、だっでえ～………
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020033")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:ったく…こんな泣き虫が<br>よくあんな大それたことをやろうとしたもんだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子2", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:う、うえぇえ…アーザーざまぁ…<br>ぼくは、ぼくはぁ…一生づいでいぐつもりでぇ…
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★モルドレッド★★:やれやれ…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020037")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:おい、泣いたままでいいから答えろ<br>おめえにそれを吹き込んだヤツは誰だ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020040")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力

	--★★モルドレッド★★:いくら慕う気持ちが強くて<br>それが反転して憎らしくなっても
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020042")


	--★★モルドレッド★★:こいつが他の人間を巻き込んでまで<br>ここまでの事件を起こすとは思えねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020043")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:ウワサを流し<br>アーサーへの反感を煽ることで得をする奴がいる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_08020046","CO_101022_08020047")
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
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いったい誰がそんなこと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020049")

-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:おいおい、気付かねえのか？<br>継承者のくせに鈍感だな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020050")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今、俺が継承者かどうかは<br>関係ないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020051")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まさか<br>モルドレッドを担ごうとしてたあいつか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:だろうな<br>ま、さすがにわかるか。継承者だもんな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020055")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それ、褒めてるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020056")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:さあな。意外に思ってようがバカにしてようが<br>どっちでもいいだろ、今はよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020057")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…どっちでもよくはないぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020058")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:王だったアーサーへの反感を煽って<br>もっとも得をするのは誰だと思う？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020060")

	change_face(Actor001,"Normal")

	--★★ノワール★★:政敵？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:そうだ。ローマと敵対してた頃は<br>ローマの可能性もあったが今は違う
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルドレッド★★:外の敵でないのなら答えは簡単だな？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020063")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:内側の敵<br>アーサーがいなければ王になっていた者…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020064")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:その通り。つまり――
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020066")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:オレだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_08020069","CO_101022_08020070")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:モ、モルドレッド、あんたまさか…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020072")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:って言うと思うか？<br>俺が今さら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020073")

-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:んだよ、つまんねー奴だな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020074")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪ぶるなよ、モルドレッド<br>そんなことしても意味ない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020076")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はもう、あんたが<br>いい奴だって知ってるんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020077")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:だぁれがいい奴だアマチャンが！<br>クラリスみたいなこと言いやがって！！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020079")

	goto Block2end

::Block2end::
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:つまり、あのときモルドレッドを担ごうと<br>俺たちに接触してきた奴が…ってことだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020081")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:ああ。ま、正確にはその上だろうがな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020082")


	--★★ノワール★★:上…黒幕か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020084")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:ああ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020085")

-- ▼直接出力
PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:どこの誰だか知らねえが<br>ぶん殴ってやれるときが楽しみだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020086")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:まずは<br>それをさがさないとだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020087")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.6)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.5)
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:ううぇっ！？
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020089")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ウワサを流せって言われたんだろ？<br>どんな奴だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_08020090")

	PlayAction(Actor003,"to  Std_Worry")

	--★★キャメロット騎士学術院（男）②★★:わ、わかんないんだよ<br>手紙で指示が来ただけだから…
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020091")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:隠し立てするならてめえをケイに突き出すぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_08020092")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子2", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:本当だよ！<br>信じておくれよ！！
	Talk(Actor003,"NPCNAME_0001","speech","N","CO_101022_08020093")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_モルドレッド_ランクアップ8_3")
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
	load_area_scene_preload(110231)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110231_11)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
