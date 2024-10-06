-- このluaスクリプトは、MA_01A111_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_02","111013_02_h")
Include("content_adv_advsmall_111013_02","Template111013_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111013_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111013_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111013_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName111013_02,CameraPos111013_02_007)
	InitializeTemplateRandomCamera111013_02()
	InitializeTemplate111013_02()
-- ▼直接出力
set_pos(Actor003, {-2.53, 0,19.46})
set_pos(Actor004, {2.5, 0,18.91})
set_pos(Actor005, {-3.1, 0, 20.63})
set_pos(Actor006, {3.55, 0, 17.89})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 0.8, 0.05, 0.5, 0.2,0.6)
lookat_delay_weight(Actor001, 0.8, 0.05, 0.5, 0.2,0.6)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "挨拶")
-- ▲直接出力

	--★★ヴェルナルス★★:もうどこにも行けなくなるぞ
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A111_280002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:構いません、ヴェルナルス様
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_280003")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "否定")
-- ▲直接出力

	--★★ヴェルナルス★★:お前ならどこでだって生きていける<br>ローマに来るべきでもなかった
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A111_280004")


	--★★ヴェルナルス★★:今のお前のそれは<br>狭められた視野の中での選択…
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A111_280005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ヴェルナルス★★:…少し歳を食えば、わかる<br>一時の気の迷いであると
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A111_280006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "否定")
-- ▲直接出力

	--★★ラシア★★:きっと今のままの私では<br>歳を食う前にどこかで野垂れ死にです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_280007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ラシア★★:…あの学園も、そういうことでしょう？<br>若年者ばかりなのは…そういう──
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_280008")

-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:バルバロイに対しほかに手だてがなきゆえに<br>仕様がなく…ではあろうがな
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A111_280009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ラシア★★:…私がヴェルナルス様のもとに<br>いることを望んだんです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_280010")


	--★★ラシア★★:それが結果として<br>ローマに属することになっただけ
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_280011")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴェルナルス★★:ラシア…お前はただ<br>浮かされているだけだ
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","MA_01A111_280012")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:どこでだっていいのなら<br>私はここがいいんです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A111_280013")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
