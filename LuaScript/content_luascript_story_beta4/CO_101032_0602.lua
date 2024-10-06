-- このluaスクリプトは、CO_101032_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:今さらなんだけどさ<br>ナイトカジキってどんな魚なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:コーンウォール近海でたまに揚がる魚でね<br>ツノが騎士の剣みたいなカタチをしてるんだ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06020003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:へえ<br>だからナイトなんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "喜び")
-- ▲直接出力

	--★★ガレス★★:わたしたちのご馳走としてぴったりだろう！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101032_06020007","CO_101032_06020008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ナイトカジキって美味いのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06020010")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ガレス★★:コック長に聞いた話なんだけど<br>焼いて食べると絶品らしい
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06020011")

-- ▼直接出力
PlayPartVoice("ガレス", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:軽く噛んだだけでホロリと身が崩れて<br>脂の甘みが口のなかに広がるんだって♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06020012")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★リオネス★★:あたしは肉派だけど<br>食べてみたいな～
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_06020013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:でも、釣れるのか？<br>たまにしか揚がらない魚なんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06020015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガレス", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:ノワール！<br>釣れるのか？じゃない
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06020016")

	change_face(Actor002,"Anger")

	--★★ガレス★★:釣るんだ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_06020017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★リオネス★★:絶対だ！
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_06020018")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ああ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_06020019")

	goto Block1end

::Block1end::
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガレス_ランクアップ6_3")
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
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
