-- このluaスクリプトは、CO_101010_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111041_01","111041_01_h")
Include("content_adv_advsmall_111041_01","Template111041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-16,CharaPos111041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111041_01,CameraPos111041_01_003)
	Camera002 = SetTemplate("Actor002",25,CharaPos111041_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111041_01,CameraPos111041_01_005)
	InitializeTemplateRandomCamera111041_01()
	InitializeTemplate111041_01()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,5.26,2.64,-30.81)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
lookoj2 = create_object("kara2")
set_pos_object(lookoj2,4.77,2.64,-30.81)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111041)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:ここで父さんとブライアンは出会ったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ああ。ブライアンはライエンスの命を受け<br>コルベニック城に潜り込もうとしたが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:ここで師匠に見つかり、組み伏せられた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020004")


	--★★ランスロット★★:そのとき師匠はブライアンに提案したんだ<br>命を救う代わりに…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:自分の身になにかあったときに<br>家族――俺たちを守ってくれ、ってやつだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020006")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:よくよく考えると<br>父さん、結構無理言ってるよな。ブライアンに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:よく考えなくても、無理言ってるな。師匠は
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:でも…友情の始まりなんて<br>そんなものかも知れない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020010")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-60.652,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか覚えがあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020012")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ランスロット★★:いや、なんでもない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020013")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだそれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020014")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:まあ、ブライアンもブライアンで<br>師匠に無理を言ってきていたようだがな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020015")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:「おめえは家族が大勢いるのにオレは独り身だ」
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020016")


	--★★ランスロット★★:「オレの命ひとつで<br>おめえの家族全員を守るのは割に合わねえ」
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:そういっていろいろ連れまわしていたようだ<br>戦いだの、酒の席だのな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ！目に浮かぶよ<br>押しに弱かったからなあ、父さん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:いつか俺も<br>お前に無理を聞いてもらうときが来るのかもな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020021")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？なにか言ったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020023")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ランスロット★★:いや、なんでもない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_07020027","CO_101010_07020028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:「いや、なんでもない」<br>さっきからそればっかりだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020030")

-- ▼直接出力
CloseTalkWindow()
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,111.636,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:気のせいだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:まあ、いいけどさ<br>はぐらかされるのには慣れてる、あんたに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なあ、ランスロット
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020034")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ＧＳを果たした今<br>俺とあんたはふたりでひとりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020035")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:お互い、隠しごとはなしにしよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020037")

-- ▼直接出力
CloseTalkWindow()
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,111.636,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:ノワール…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020038")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:だが、本当になんでもないんだ<br>気を遣わせてしまって申し訳ない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020039")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それならいいけどさ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020040")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ブライアンに、感謝しなければな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020042")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだよ、急に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020043")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:ブライアンは師匠との約束を違えることなく<br>お前を守り、そして育ててくれた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020045")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:そのお陰で俺は今こうして<br>お前とともにいることができる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020046")

-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かにな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020048")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-16,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ノワール★★:父さんの無茶な願いを<br>ブライアンは命を賭けて叶えてくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020050")

-- ▼直接出力
 --keep_ik_lookat(Actor001, lookoj, "kara")
lookat_delay_weight(Actor001, {1.1, 0.08, 0.4, 0.2},1.0)
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:俺にとっては間違いなく…<br>もうひとりの父親だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020051")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,25,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020053")

-- ▼直接出力
 --keep_ik_lookat(Actor002, lookoj2, "kara2")
lookat_delay_weight(Actor002, {1.1, 0.08, 0.4, 0.2},1.0)
keep_delay_ik_lookat_object(Actor002,lookoj2,"kara2",1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:ちゃんと、覚えておかないとな<br>ふたりとも
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020054")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:うん。どちらか一方だけなんていったら<br>もう片方に怒られそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020055")

	change_face(Actor001,"Normal")

	--★★ノワール★★:継いでいこう<br>ふたりの想いを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_07020056")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_07020057")

-- ▼直接出力
local trustParam = set_communication_rankup("ランスロット_コミュランク", "ランスロット_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(111041)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
