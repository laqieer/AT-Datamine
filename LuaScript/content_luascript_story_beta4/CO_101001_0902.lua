-- このluaスクリプトは、CO_101001_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112011_01","112011_01_h")
Include("content_adv_advsmall_112011_01","Template112011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",9,CharaPos112011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_005)
	Camera002 = SetTemplate("Actor002",104,CharaPos112011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName112011_01,CameraPos112011_01_006)
	InitializeTemplateRandomCamera112011_01()
	InitializeTemplate112011_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,-10.746,0.3)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,140,0.3)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:来たかった場所って…ここか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい<br>ここの雰囲気、好きなんです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ちょっと分かる気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020004")

-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:ふふ<br>気が合いますね、私たち
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020006")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:ここもきっと…<br>いつかの時代に作られたのでしょうね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィングの<br>時代のものってわけじゃないのか、ここ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい、恐らくは<br>ですが…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ティルフィング★★:こうして、朽ちてはいても<br>ちゃんと遺っているのを見ると
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020011")

	change_face(Actor002,"Smile")

	--★★ティルフィング★★:嬉しくなりますね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020013")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:のちの世に、これほど立派なお城が<br>傍に建つことになるとは
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020015")


	--★★ティルフィング★★:当時の誰も<br>思っていなかったかも知れませんが
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:はは、確かに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020018")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
-- ▲直接出力

	--★★ティルフィング★★:武器を見つけてください、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ティルフィング…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020022")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:世界を救うためには<br>継承者であるアナタの武器が必要です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:アナタが自分の武器を手に出来なければ<br>この遺跡も城も、すべてが瓦礫の山と化し
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020024")


	--★★ティルフィング★★:ここに立派な城が、町が<br>存在したことを語れる者もいなくなるのです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020025")

	change_face(Actor001,"Normal")

	--★★ノワール★★:自分の武器を、手に…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020026")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ティルフィングじゃ…キミじゃダメなのか？<br>息はあってるだろ、俺たち
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020028")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ティルフィング★★:私は…遺物、ですから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101001_09020032","CO_101001_09020033")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな悲しいことを言うなよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020035")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺にとってキミは大事な存在だ<br>もしも自分の武器が見つからなくても
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020036")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はキミとだったら<br>自分の役目を果たせると思ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:ああ、マスター…！<br>そう言っていただけただけで私は満足です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020039")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなのか<br>でも、そんな寂しい言いかたしないでほしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:これまで一緒にやってきた仲じゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020042")

-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:ですが、これは事実なのです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020043")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:これから先の世界を背負うのは
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020045")


	--★★ティルフィング★★:今を生きる<br>新たなキラーズでなければなりません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィング…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020047")


	--★★ティルフィング★★:どうか選択を<br>マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020048")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:心のままに、選び取ってください<br>アナタの思う、アナタの道を
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101001_09020051","CO_101001_09020052")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…分かった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020054")

	change_face(Actor001,"Normal")

	--★★ノワール★★:まだよく分からないことも多いけど<br>ちゃんと選ぶよ。約束する
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020055")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:期待しています<br>マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020056")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:急に言われても、今はまだ決められない<br>俺には分からないことだらけだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020058")

	change_face(Actor001,"Normal")

	--★★ノワール★★:キラーズのこと、バルバロイのこと<br>それに継承者のこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_09020059")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:ゆっくりでいいのです<br>でも、そのときはいつか必ず来ます
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020060")

	goto Block2end

::Block2end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:どうか、良き選択を<br>継承者ノワール
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_09020062")

-- ▼直接出力
local trustParam = set_communication_rankup("ティルフィング_コミュランク", "ティルフィング_親密度")
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
	load_area_scene_preload(112011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
