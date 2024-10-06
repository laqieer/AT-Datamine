-- このluaスクリプトは、CO_101010_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114061_01","114061_01_h")
Include("content_adv_advsmall_114061_01","Template114061_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",353.2,CharaPos114061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_004)
	Camera002 = SetTemplate("Actor002",37.1,CharaPos114061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName114061_01,CameraPos114061_01_002)
	InitializeTemplateRandomCamera114061_01()
	InitializeTemplate114061_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002, 0)
turn_lookat(Actor002,Actor001, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ランスロット★★:リムニーナ村…ここはいつ来ても落ち着くな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうだなけどさ、こんなに静かな場所だったっけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:俺たちがここで暮らしていた頃は<br>もう少し賑やかだった気がするんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:あのときは子供がいたからな<br>お前にディナタンに
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010011")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだよ俺が子供だったらあんただって子供だったろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…そうだな俺も子供だった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010013")

	change_face(Actor002,"Laugh")

	--★★ランスロット★★:だが、あの頃、お前たちと過ごした時間は俺にとってもっとも大事な宝物だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だから時折こうしてこの湖を見つめていたくなる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010015")

	open_select_window_tag(Actor001,"Normal","CO_101010_00010016","CO_101010_00010017","CO_101010_00010018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:リラックスできる場所をもつのは大事だよな気を張ってばかりいると、いつか潰れてしまう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010020")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010021")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんだよ、その顔？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:いやお前も大人になったんだと思ってな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010023")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:そんな言いかたはないだろ？せっかく話を合わせてやってるのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010024")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…前言撤回
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:で、お前はどうなんだ？リラックスできる場所がひとつくらいあるのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010026")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん、そうだなあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もここにいるとリラックスできる気がするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010028")

-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:そうかそれは良かった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひとりでここに来たことがあるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ近くに来る任務があったら、その帰りにな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだよそれなら俺も誘ってくれればよかったのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010033")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:騒々しくなってしまうだろうお前がいたら
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010034")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのなあ…俺だって空気は読めるようにはなってるよ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010035")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…昔よりは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:ははっ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:さっきのは冗談だ次からはお前も誘うことにするよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010038")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:変わらないな、ランスロットは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010042")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:昔もよくひとりでこの湖を眺めていた気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:そうだったかもしれないな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010044")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:お前はそんな俺によく聞いて来たな「ひとりで湖なんか見てて楽しいのか」と
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…そうだったっけ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_00010046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:ああ、そうだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:変わらないよ、お前も
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_00010048")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"ランスロット")
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
	load_area_scene_preload(114061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114061_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
