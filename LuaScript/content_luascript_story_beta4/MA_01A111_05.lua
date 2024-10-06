-- このluaスクリプトは、MA_01A111_05.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 1
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エレイン★★:こんにちは…差出人です
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A111_050002")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:…恋文のお返事<br>望んでないのかなと思っちゃった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050003")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "悩む")
-- ▲直接出力

	--★★エレイン★★:失敗しました…<br>最近手渡しが多かったので──
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A111_050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力

	--★★ギネヴィア★★:差出人の名前を書き忘れた？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A111_050007","MA_01A111_050008","MA_01A111_050009")
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
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:誘うのが怖くて<br>その気持ちがそうさせたのかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_050011")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:わ、わたしって怖い…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050012")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エレイン★★:い、いえ…お誘いしていいものか迷っていて<br>それで、書き忘れてしまったのかも…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A111_050013")

	change_face(Actor003,"Sad")

	--★★エレイン★★:ごめんなさい…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A111_050014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
lookat_delay_weight(Actor001,0.5, 0.03, 0.7, 0.5,1)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:書き忘れに気づいて、来てくれたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_050016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エレイン★★:はい…先輩<br>気づいた瞬間、汗がドッと出ました…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A111_050017")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:べ、別にいいのよ<br>差出人はすぐにわかったし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:わたしこそ変な勘繰りしないで<br>すぐにお返事に行けばよかったね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ギネヴィアも色々気を使ったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_050021")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:字がね、手紙の字が<br>なんだかちょっと震えてて
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:あるでしょ？こう…気持ちは伝えたいけど<br>返事はノーサンキューみたいなとき
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050023")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:だから、どうしようかなって思ってたの<br>わたしも迷っちゃってて、ごめんね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050024")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:差出人は書いてなくてもわかった<br>返事を迷ってるうちに、結局当人が来てくれた
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050026")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:なんかちょっと、気恥ずかしいね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_050027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:…はい。ギネヴィア様
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A111_050028")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Shy")

	--★★エレイン★★:ご一緒に、すこし遠出を、しませんか！！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A111_050030")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 1
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
