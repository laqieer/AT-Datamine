-- このluaスクリプトは、MA_01A111_06.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114091_01","114091_01_h")
Include("content_adv_advsmall_114091_01","Template114091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114091_01,CameraPos114091_01_004)
	InitializeTemplateRandomCamera114091_01()
	InitializeTemplate114091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114091)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
turn_chara(Actor001, 110, 0)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()


	--★★エレイン★★:…主演女優に、花束を
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_060002")


	--★★ギネヴィア★★:花束？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_060003")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Shy")

	--★★エレイン★★:お花を摘んで束ねようとも考えたいんですが<br>ちょっと、それよりも──
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_060004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:花束に代えて<br>この景色をお贈りしたくて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_060005")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Smile")

	--★★エレイン★★:………なんて、どうでしょう？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_060006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:ふふ。オツだわ、エレイン
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_060007")

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:見えてる景色をね<br>「贈るよ」って言ってくれるだけで…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_060008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:あなたの心意気が景色の見え方を変えてくれる<br>すごく愛おしくなってくる
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_060009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:ありがとう、エレイン
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_060010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:感動したんです。あのお芝居…<br>ギネヴィア様が語る台詞に
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_060011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")

	--★★エレイン★★:ああ、用意され与えられた言葉でも<br>ここまで人の心をつかんで離さないんだと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_060012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:…当てはめられた役であっても<br>まっすぐ、まっすぐ、まっとうできれば
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_060013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:こころを震わせることができるんだと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A111_060014")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:ほ、褒め過ぎよ…！本が良かったの、演出も！<br>舞台も、手伝ってくれる人いっぱいいたもの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_060015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:飾ってくれた人がいたから<br>やってこられたの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_060016")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114091)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
