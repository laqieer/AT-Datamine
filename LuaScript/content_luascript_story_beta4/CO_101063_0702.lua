-- このluaスクリプトは、CO_101063_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("クリスティーナ","0010")
-- ▲直接出力

	--★★クリスティーナ★★:近いうちに結構な量の本が入るみたいでねその前に書架を整理しておきたかったのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:それで？聞きたいことがあって来たんでしょ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020004")

	open_select_window_tag(Actor001,"Normal","CO_101063_07020006","CO_101063_07020007")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:このあいだ悪徳商人から『荒獅子ゴッデム』って呼ばれてたけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あれは本当のことなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:…本当よ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:別になにも？クリスさんを手伝いに来ただけだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020013")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:優しいのね、ノワールちゃん
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020014")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:本当は『荒獅子ゴッデム』について聞きに来たんでしょう？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020015")

-- ▼直接出力
wait_time(1)
PlayPartVoiceDirect("ノワール","0008")
PlayActionDirect(Actor001,"to  Std_Yes")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それは…うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020016")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:…傭兵をやってたノワールちゃんにはいつかはバレるかなって思ってた
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020018")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:これから話すこと…学園のみんなには秘密にしてくれる？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020019")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:たぶん…怖がらせちゃうと思うから
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ゴッデムは私の本当の名前司書になる前は傭兵をやっていたの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020022")


	--★★クリスティーナ★★:私、小さい頃からカラダが大きくてケンカじゃ負けたことがなかったわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020024")


	--★★クリスティーナ★★:勝負事に勝ったあとってもっと強い刺激を求めたくなるでしょ？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020025")


	--★★クリスティーナ★★:同世代の男の子に勝ったら年上に挑戦してそれに勝ったらもっと年上に…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:それを繰り返しているうちに気づいたら私は戦場に立っていたわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020027")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:『カレドニアの猟犬』と知り合いだったってことだけど、それは本当なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:『カレドニアの猟犬』…ブライアンさんは私に傭兵の戦いかたを教えてくれた先輩よ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020029")


	--★★クリスティーナ★★:あの人は強かった…模擬戦で勝てたことはほとんどなかったわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020030")

	open_select_window_tag(Actor001,"Normal","CO_101063_07020032","CO_101063_07020033")
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
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ…さすがはブライアンだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020035")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ノワールちゃんはブライアンさんに育てられたんだっけ？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020036")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:…でも、この話の流れでブライアンさんを褒めるのは違わない？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020037")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ご、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020038")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:冗談よその言葉、ブライアンさんも嬉しいでしょうね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020039")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はブライアンの戦いかたを近くで見ていたことがあるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:このあいだのクリスさんの戦いぶりは決してブライアンに負けてなかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ありがと、ノワールちゃんでも、傭兵を辞めた今になって
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020043")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:戦いぶりを褒められるのはなんだか複雑な気分だわね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020044")

	goto Block2end

::Block2end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ブライアンとはずっと一緒だったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:いいえ。傭兵を続けているうちに私は良くない連中とつるむようになってしまって
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020047")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:ブライアンさんはそいつらと手を切れと助言してくれたんだけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "苦しみ")
-- ▲直接出力

	--★★クリスティーナ★★:当時、若かった私はブライアンさんに反発してしまった
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020049")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020050")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力

	--★★クリスティーナ★★:そこからは悪事に手を染めて…堕ちていくだけだったわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:『荒獅子ゴッデム』の悪名は知れ渡り名もなき正義の騎士様が懲らしめにやってきて
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020052")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:気が付いたらベッドの上だったわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020054")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで傭兵を辞めて司書の道に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020055")


	--★★クリスティーナ★★:そのあとは…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("女子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:クリスちゃーん！<br>今、本返してヘーキ？
	Talk(Actor003,"NPCNAME_0146","speech","L","CO_101063_07020058")

-- ▼直接出力
lookat_delay_weight_reset(Actor002,1.0)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:あ～ら、いつでもオッケーよ！今そっちに行くわね！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020059")

-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head",1.0)
lookat_delay_weight(Actor002,0.5,0.1,0.8,0.2,1.0)
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ノワールちゃん、ごめんなさいあの子たちの相手をしてあげないと
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020061")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わかった書架の整理は俺がやっておくから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07020062")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:お願いね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020063")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:話の続きはまた今度してあげるわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07020065")

-- ▼直接出力
local trustParam = set_communication_rankup("クリスティーナ_コミュランク", "クリスティーナ_親密度")
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
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
