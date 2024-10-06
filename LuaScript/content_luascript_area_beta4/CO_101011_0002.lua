-- このluaスクリプトは、CO_101011_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:華やかで、活気があって…ロンディニウムって、いつ来ても素敵な街よね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:大陸にあるローマ本国の街もこんな感じなのかしら？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もっと賑やかだったりして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ああ～、たしかに！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010011")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:きっとローマ本国には他のたくさんの国から人や物が入ってくるのよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010012")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:いつか行ってみたいな～
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:戦いさえ落ち着けばすぐにでも行けるさ、きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
lookat_delay_weight(Actor002, 0.6, 0.3, 0.6, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:そうよね！ノワールも荷物持ちとして連れてったげるからね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010015")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:荷物持ち…楽しみにしてるよ、はは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:で？今日はこのあとどうしようかしら？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_00010018","CO_101011_00010019","CO_101011_00010020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:マーケットに行ってみないか？ログレスでは手に入らないものがあるかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight_default(Actor002,1.0)
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:賛成！まずは宝石店に行きたいな
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:そのあとは新しい服を見に行って…みんなのお土産も買って…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010024")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:あっ！？あんまりハシャいでると田舎者と思われちゃう？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:大丈夫じゃないかな？（田舎者はそんなに大量に買わないだろうし…）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうかな？…そうよね！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:じゃあ、お言葉に甘えてお土産を買ったあとはねえ…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010028")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（今日は帰りが遅くなりそうだな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101011_00010029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:この先に美味しいレストランがあるんだってそこに行ってみないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010032")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:最近話題になってるお店よね、そこ<br>ノワールが知ってるなんて意外～！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:どういう意味だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:でもさ、大丈夫？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010035")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:大丈夫って、なにが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010036")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:あなた、テーブルマナーとか知らないでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010037")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:バカにするな！知ってるさ、テーブルマナーのひとつやふたつ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010038")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…じゃ、質問フィンガーボウルって、どうやって使うもの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…フィンガー…ボウル…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010040")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight_default(Actor002,0.6)
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:やれやれわたしが教えたげるから。ついてきなさい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010041")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:実は、なにも考えてなかったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010044")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ノープラン！？嘘でしょ！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ノープランじゃない歩いてるうちに浮かぶと思ってたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010046")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
lookat_delay_weight(Actor002, 0.6, 0.3,0.6, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:それをノープランって言うのよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010047")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:女性を上手にエスコートするのも騎士のたしなみのひとつでしょ？まったくもう…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:う…ごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_00010049")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:…ま、そんなところがあなたらしいけど
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_00010050")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"ギネヴィア")
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
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
