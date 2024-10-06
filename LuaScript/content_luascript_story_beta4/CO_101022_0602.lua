-- このluaスクリプトは、CO_101022_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
turn_chara(Actor001,-45.384,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.45,0.1,0.8,0.2)
turn_chara(Actor003,-177.783,0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Noon_D")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:思ったより呆気なかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020002")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:ああ！<br>暴れ足りねえ、殺し足りねえ！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020003")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★クラリス★★:ダメですよ、モルくん～<br>任務のあとはちゃんと休まないと
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_06020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:へえへえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020005")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★貴族（男）②★★:ああ、モルドレッド様！
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","CO_101022_06020007")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Appear(Actor004)
--貴族（男）②,NPCNAME_0282 @名前変更
keep_ik_lookat(Actor004,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
turn_chara(Actor001,-98,0)
turn_chara(Actor003,-156,0)
set_enable_auto_lookat(Actor002, false)
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力

	--★★モルドレッド★★:ん？てめえは…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020009")

-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("貴族_男2", "肯定")
-- ▲直接出力

	--★★貴族（男）②★★:あのときの王家の<br>そしてログレスの判断は間違っていた！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020010")


	--★★貴族（男）②★★:貴方様こそが王の器であると気づけず<br>あのような男に座を渡すなど…なんと愚かな！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020011")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:あの、あなたはいったい…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_男2", "挨拶")
-- ▲直接出力

	--★★貴族（男）②★★:なにかなキミは！私は今、モルドレッド様と<br>お話しているのだ。控えたまえ！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020014")


	--★★ノワール★★:は、はあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020015")

-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")

	--★★貴族（男）②★★:ユーサー王の血をひき、幼き時分から<br>王位継承者として育てられた、真なる王よ！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Appl")

	--★★貴族（男）②★★:今こそ貴方様が愚王アーサーに変わり<br>このログレスの王となるときです！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020018")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("クラリス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:ぐ、愚王だなんて、酷い…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_06020019")

-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力

	--★★モルドレッド★★:よくもまあ、今さらそんなことが言えたもんだ<br>厚顔無恥の見本だな、てめえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020021")


	--★★ノワール★★:モルドレッド…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:よ～く覚えてるぜ、その顔
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020024")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:先王が死に、アーサーが姿を現した途端<br>掌を返して主人を変えたクソ野郎だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルドレッド★★:だったよな？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020027")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor002,"Normal")
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")

	--★★貴族（男）②★★:ヒッ！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020028")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("貴族_男2", "驚き")
-- ▲直接出力

	--★★貴族（男）②★★:あ、あのときの私は愚かでした！<br>なんらかの魔法がかけられていたのやも！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★貴族（男）②★★:ユーサー王の死で悲しみの淵にいたログレスを<br>救うかのように現れたアーサー…
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020031")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("貴族_男2", "落胆")
-- ▲直接出力

	--★★貴族（男）②★★:その鮮烈な登場に惑わされ<br>従うべき相手を間違えてしまったのです！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_06020034","CO_101022_06020035")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ノワール★★:なんだよ、その言い草！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020037")

	change_face(Actor001,"Anger")

	--★★ノワール★★:まるで、アーサーに従ったのが<br>間違いだったみたいじゃないか！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020038")

-- ▼直接出力
 --クラリスを非表示にするためにカメラを指定
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("貴族_男2", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★貴族（男）②★★:間違いだったのだ！このログレスの現状を見よ！<br>誰のせいでこうなったと思っている！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020039")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor004, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんた、もしかして<br>もともとはモルドレッド派の人間か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020041")

-- ▼直接出力
 --クラリスを非表示にするためにカメラを指定
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("貴族_男2", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★貴族（男）②★★:私は最初から信じていた！<br>モルドレッド様こそログレスの王なのだと！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020042")

	change_face(Actor004,"Normal")

	--★★貴族（男）②★★:だが怪しき宮廷魔術師が私に<br>魅了の魔法をかけたのだ！きっと！おそらく！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020043")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★貴族（男）②★★:そもそもアーサーは<br>故ユーサー王の長子というだけで王となり
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020045")


	--★★貴族（男）②★★:亡き御父上のご威光だけで<br>王として認められていたにすぎない
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020046")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_男2", "悩む")
-- ▲直接出力

	--★★貴族（男）②★★:なんの努力も苦労もなく<br>のうのうと玉座に座りおったのだ！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020047")

-- ▼直接出力
 --クラリスを非表示にしておく
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:アーサーは苦労も努力もたくさんしてた！<br>なにもしてなかったみたいに言うな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020048")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("貴族_男2", "肯定3")
-- ▲直接出力

	--★★貴族（男）②★★:ならばキミは<br>アーサーが真の王だとでも言うのかね？
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020049")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★貴族（男）②★★:バルバロイを従え<br>自らの国を襲うような男を！？
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020050")


	--★★貴族（男）②★★:かび臭い田舎の孤児院に預けられたのも<br>このような事態を招く恐れがあったからだろう！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020051")

-- ▼直接出力
PlayPartVoice("貴族_男2", "肯定")
-- ▲直接出力

	--★★貴族（男）②★★:血の正当性で王になったようだが<br>今となってはあの男は出自すらあやふやと思える
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020053")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ノワール★★:だからといって…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★モルドレッド★★:よくよく回る舌だよなぁ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020056")

	PlayAction(Actor004,"to  Std_Surp")

	--★★貴族（男）②★★:ヒッ！？
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020057")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:その舌の回りかたは尊敬するが…<br>ちょっと喋り過ぎだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★モルドレッド★★:それ以上ヤロウを…アーサーを侮辱してみろ<br>…その舌、引き抜いて切り刻んでやる
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020060")

	PlayAction(Actor004,"to  Std_Sad02")

	--★★貴族（男）②★★:ヒィィィッ！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020062")

-- ▼直接出力
PlayPartVoice("貴族_男2", "驚き")
-- ▲直接出力

	--★★貴族（男）②★★:は、話が違うじゃないか…！<br>モルドレッドはアーサーを嫌っていると…
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020063")

-- ▼直接出力
PlayPartVoice("モルドレッド", "激怒")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Serious")

	--★★モルドレッド★★:あァ！？
	Talk(Actor002,"CHRNAME_MORDRED","speech","N","CO_101022_06020064")

	close_cutin()
	PlayAction(Actor004,"to  Std_Surp")

	--★★貴族（男）②★★:ヒイィッ！！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_06020065")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2") 
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor004,"to Run")
wait_time(2.0)
PlayActionDirect(Actor004,"to Std_Loop")
setup_small_camera_start(RndCamera005)
Hide(Actor004)
wait_time(CHARA_IN_WAIT)
turn_chara(Actor001,-45.384,0)
turn_chara(Actor003,-177.783,0)
set_enable_auto_lookat(Actor001, true)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
bgm_play("BGM_Area_Noon_D") 
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:コウモリ野郎が…
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020067")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
wait_time(0.2)
-- ▲直接出力

	--★★モルドレッド★★:戻って来い、クラリス<br>もうあいつはいねえよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020069")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
EntryWalk(Actor003,Camera003,EntryData110111_01_01,CameraAssetBundleName110111_01,CameraPos110111_01_101)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クラリス", "肯定2")
-- ▲直接出力

	--★★クラリス★★:もう、終わりですかぁ…？<br>よかったぁ…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_06020071")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クラリス、大丈夫か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020072")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:はい～ノワールくんもすみません～<br>わたし、声の大きな人が苦手で…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_06020073")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:声のでかさもオツムの悪さも<br>救いようがねえ男だったな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020074")


	--★★ノワール★★:ははは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020076")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:それにしても、なんだったんだ？あの男…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020077")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor002,false)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:さぁな<br>アーサーのヤロウが馬鹿なことをしたせいで
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020078")


	--★★モルドレッド★★:権力欲の強い連中どもが<br>悪だくみでもしてんだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020079")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:他人事みたいに言うんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020081")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:オレには関係ねえことだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020082")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101022_06020084","CO_101022_06020085")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも<br>モルドレッド様って呼ばれてたじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020087")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:だからなんだよ<br>オレは「様」付けて呼べなんて頼んじゃいねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020088")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:「モルくん」が良かったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020089")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:てめえ、死にてえのか？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020090")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーを庇ってたな<br>嫌いなんじゃなかったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020092")

-- ▼直接出力
PlayPartVoice("モルドレッド", "照れ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:うるせえ<br>あの場を早く切り上げる方便だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020093")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:それともなにか？<br>おめえは静かに聞いてられたってのか？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020094")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ムリだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020095")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:オレはアーサーを<br>ムカつくヤロウだと思ってたが
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020097")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020098")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:ヤロウがなんの苦悩もしてなかった<br>なんて言われんのはもっとムカつくんだよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020099")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:孤独なる王の道に<br>苦悩がねえわけねえだろう
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020101")

-- ▼直接出力
PlayPartVoice("クラリス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:モルくん…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_06020103")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:しっかし、イヤになるな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020105")


	--★★モルドレッド★★:アーサーという濃い血統が現れた途端<br>掌を返してオレから離れてったヤツが
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020106")


	--★★モルドレッド★★:アーサーが国と敵対した途端<br>オレに尻尾を振りに戻ってきやがった
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020107")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:最低だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020109")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:ふん、そう思うか？<br>だが現実、人間なんてそんなもんさ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020110")

	PlayAction(Actor002,"to  Std_Talk")

	--★★モルドレッド★★:損得勘定ってやつだ<br>ひとつ賢くなったな、継承者
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020111")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:そういう言いかたはないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020113")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:学園を崩壊させかけた<br>アーサーを恨んでねえのか？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020114")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:恨んでないわけじゃない<br>でも、まだわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020115")


	--★★ノワール★★:あれもアーサーの選んだ理想なんだとしたら<br>それまでのすべてを否定してはいけない気もする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020116")


	--★★ノワール★★:もっと中身を見てる人だっているはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020117")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ほら、あんたにおけるクラリスみたいに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020118")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クラリス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:ふわっ！？<br>あ、わ、わたしはその、その～…！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_06020119")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:こいつはオレしか知らねえだけだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020120")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("クラリス", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:ふえぇ…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_06020122")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:おい、言葉を選べよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020124")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "否定")
-- ▲直接出力

	--★★モルドレッド★★:うるせえ<br>なにも知らねえヤツは黙ってろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020125")

	change_face(Actor001,"Sad")

	--★★ノワール★★:モルドレッド…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020126")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:中身を見る、ねえ…<br>理想論だな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020128")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020129")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:王とは人の為にあり<br>人あってこそ成り立つ存在
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020131")

	PlayAction(Actor002,"to  Std_Worry")

	--★★モルドレッド★★:故に己を支え<br>付き従う者たちを第一に考えねばならない
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020132")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:モルドレッド…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_06020133")

-- ▼直接出力
PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力

	--★★モルドレッド★★:理想なんて<br>棄てちまえばラクになれんのにな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_06020135")

-- ▼直接出力
local trustParam = set_communication_rankup("モルドレッド_コミュランク", "モルドレッド_親密度")
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
preload_sound("BGM_ADV_Reconnaissance")
preload_sound("BGM_Area_Noon_D")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
