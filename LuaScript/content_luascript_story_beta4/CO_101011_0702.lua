-- このluaスクリプトは、CO_101011_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
-- ▼直接出力
keep_ik_lookat(Actor001, Actor002, "J_Head")
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:それで？どうしたんだ、いったい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07020002")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:こないだ見せたでしょ？お姉ちゃんからもらった魔法のガラス玉
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ギネヴィア★★:あれがね…なくなっちゃったの
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07020005")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだって！？一番大切な宝物だって言ってたやつだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07020006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:うん…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101011_07020009","CO_101011_07020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:すぐに探しに行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07020012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:う、うんありがとう
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07020013")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか心当たりは？どこかに落とした覚えはないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07020014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:落とし物としてどこかに届けられてないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07020016")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:落ちてても気にしないよ他の人が見たらただのガラス玉だもん
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07020017")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:どこでなくしちゃったのかな…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07020018")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:昨日まではたしかにあったから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07020020")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ギネヴィア★★:今日やったことや行った場所を思い出せば見つかるかな？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07020021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:よし、出発だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07020022")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ギネヴィア_ランクアップ7_3")
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
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
