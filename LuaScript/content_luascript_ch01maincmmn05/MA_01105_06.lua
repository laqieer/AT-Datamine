-- このluaスクリプトは、MA_01105_06.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_003)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:祭はもういいのか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060002")

	open_select_window_tag(Actor001,"Normal","MA_01105_060004","MA_01105_060005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにをしていたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_060007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:見回りだ<br>生徒たちが羽目を外し過ぎていないかのな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ちゃんと教師をやってるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_060009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:まあな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:どうにも<br>ああいう輪のなかに入る気になれなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_060012")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:昔からそうだったな、お前は
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:わかる、俺もだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060014")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが、学園で過ごす時間はあっという間だぞ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060016")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ランスロット★★:大騒ぎも悪くない<br>今年の祭は今年だけだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…わからないんだよ、そういうの<br>学校なんてなかったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_060018")

	change_face(Actor002,"Laugh")

	--★★ランスロット★★:師匠が先生みたいなものだったな<br>俺たちにとっては
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_060020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:だから師匠も俺たちと<br>騒いでくれていたんだろうな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:楽しかったな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01105_060022")

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
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
