-- このluaスクリプトは、CO_101063_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-155,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera002 = SetTemplate("Actor002",10,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
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
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("クリスティーナ","0002")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:あのね…<br>私、学園を離れようかと思うの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020002")

	open_select_window_tag(Actor001,"Normal","CO_101063_10020004","CO_101063_10020005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どうして急にそんな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10020007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:別に急じゃないわ<br>ずっと考えていたことなのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020008")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:なにが本当の私なのか<br>ここが本当の居場所なのかって
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなことだと思った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10020011")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:みんなに『荒獅子ゴッデム』としての素顔を<br>知られてしまったこと、気にしてるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ノワールちゃんにはお見通しみたいね<br>ただ、あの出来事はただのきっかけよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020014")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:もう『クリスティーナ』になるのもオシマイ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020016")


	--★★クリスティーナ★★:どんなに厚く化粧しても<br>どれだけ綺麗なドレスに身を包んでも
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★クリスティーナ★★:乱暴で、薄汚くて、嫌われ者の<br>『荒獅子ゴッデム』は隠しきれないの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020018")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:…そもそも『クリスティーナ』になれてる<br>なんて思ってたのは私だけだったのかもね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★クリスティーナ★★:実際、あれ以来<br>みんなから避けられちゃってる気がするもの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かに、『クリスティーナ』になってる<br>なんて思ってたのはクリスさんだけかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10020021")


	--★★クリスティーナ★★:そう、よね…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:クリスさんは勘違いしているよ<br>学園に行こう。みんなが待ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10020024")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:えっ…どういう、こと…？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10020025")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ10_3")
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
