-- このluaスクリプトは、MA_01C110_18.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:ノワール！ディナタン！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180002")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ランスロット★★:無事でよかった…！
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_180004")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:ランス兄ちゃんも<br>…みんなが無事でよかった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_180005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ランスロット★★:…全員が無事だったわけじゃない<br>命を落とした者たちもいる
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_180006")


	--★★ランスロット★★:俺たちは多くのものを失った<br>だが…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_180007")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C110_42_Crowd")
wait_time(3.2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:…？なんだか騒がしいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_180009")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:学園祭の準備よ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180010")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:学園祭？こんなときに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_180011")


	--★★ギネヴィア★★:こんなときだから
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:悲しかったことも全部含めて<br>これからみんなでがんばろうって
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180013")


	--★★ギネヴィア★★:予定どおり学園祭を<br>やろうってことになったの
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:今から〇日後が開催日だからね<br>あんたもちゃんと、楽しむ準備しとくのよ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ああ、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_180017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_180018","MA_01C110_180019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:それでアーサーは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_180021")

	PlayAction(Actor004,"to  Std_Sad02")
	change_face(Actor004,"Sad")

	--★★ランスロット★★:行方不明だ……だが、『妖精殺し』については<br>さらにわかったことがある
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_180022")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ランスロット★★:あとで話そう
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_180023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それでルーシャスは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_180025")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ランスロット★★:魔女と動きをともにしているようだ<br>アーサーと別行動なことは間違いない
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_180026")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ローマと魔女<br>アーサーとバルバロイってことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_180027")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ランスロット★★:おそらくはな…<br>あとで話そう
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01C110_180028")

	goto Block1end

::Block1end::
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ランス兄ちゃん…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_180030")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:ランスロットは事件のあと<br>ずっと難しい顔してる
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180031")


	--★★ギネヴィア★★:それが今の俺の役目だって…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_180033")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:でも…<br>みんな元気にならないとね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180035")


	--★★ギネヴィア★★:じゃないと戦うこともできない
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180036")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180037")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:そうだ、ディナタン<br>学園祭で歌ってよ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180038")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:えっ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_180039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:ね、お願い。ディナタンが歌えば<br>きっとみんな元気になるから
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:…はい。わかりました
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_180041")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:にししっ…♪<br>ディナタンの歌、聞けるの楽しみ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C110_180042")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
