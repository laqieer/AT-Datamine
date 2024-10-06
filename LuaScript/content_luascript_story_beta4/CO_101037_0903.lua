-- このluaスクリプトは、CO_101037_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:まずはなんて言ったらいいんでしょう？<br>お見舞いの第一声の正解ってわからなくて…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ラシア★★:「お久しぶりです」？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ラシア★★:「お体の調子はいかがですか」？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101037_09030006","CO_101037_09030007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:正解なんてないと思うよ<br>いつものラシアでいいんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030009")

-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:いつもの私ってどういう感じですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030010")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:こんにちは！って感じ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:「こんにちは、ヴェルナルス様！<br>お約束していたヨーグルトをお持ちしました！」
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ラシア★★:…こんな感じでしょうか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうそう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ここはやっぱり明るく元気にいこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030016")

-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:明るく元気に…？<br>お手本を見せてもらっていいですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030017")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺が！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:はい！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030019")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:えーっと…<br>「先生こんにちは！お見舞いに来ました！！」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:こんな感じかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030021")

	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★ラシア★★:「先生こんにちは！！<br>お見舞いに来ました！！！！」
	Talk(Actor002,"CHRNAME_RASIA","speech","N","CO_101037_09030022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	close_cutin()
	change_face(Actor001,"Sad")

	--★★ノワール★★:あまり声が大きすぎても<br>病室だと迷惑になりそうだけどな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030023")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:「おかえりなさい」<br>なんてのもいいかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030025")


	--★★ラシア★★:おかえりなさい…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:家族のいるところに帰って来たんだから<br>迎えてあげないとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030027")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:そんなフレンとローラみたいな<br>関係じゃありませんし
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030028")


	--★★ラシア★★:ヴェルナルス様の帰るところは<br>ローマですから
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:じゃあそれもこの際だ<br>聞いてみたらいい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030030")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:えぇっ、お見舞いでですか！？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ラシアは先生との距離をつかみ切れてない<br>自分から懐に飛び込んでいこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030032")


	--★★ラシア★★:なんだか戦いみたいですね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:そのくらいのつもりで挑むんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:はいっ！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030035")


	--★★ノワール★★:勇気を出して一歩踏み出してみないと<br>なにも始まらないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:もし拒まれたらどうしましょう？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030038")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そのときはそうだな…<br>俺がヴェルナルス先生を??ろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:叱る！？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラシアを置いていってしまったから<br>あなたは大ケガをする羽目になった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:また同じ失敗を繰り返すつもりですか、って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030042")

-- ▼直接出力
PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:失敗を繰り返さない…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030043")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:さぁ、そろそろ行こう<br>先生もきっと待ちくたびれてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:緊張しますね…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09030045")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ほら、モタモタしてないで<br>冷たいヨーグルトをご所望なんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09030046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ9_4")
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
