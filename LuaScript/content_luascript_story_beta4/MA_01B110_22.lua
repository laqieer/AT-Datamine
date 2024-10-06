-- このluaスクリプトは、MA_01B110_22.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor001,{-2.9,0.128,19.8})
set_rot(Actor001,{0,35,0})
set_pos(Actor002,{0.6,0.128,23.2})
set_rot(Actor002,{0,-95,0})
set_pos(Actor003,{-1.3,0.128,19.7})
set_rot(Actor003,{0,15,0})
set_pos(Actor004,{-0.4,0.128,23.6})
set_rot(Actor004,{0,165,0})
set_pos(Actor005,{-0.7,0.128,24.5})
set_rot(Actor005,{0,170,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_008)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(2)
PlayActionDirect(Actor004,"to  Std_Worry")
wait_time(2)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
template2()
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
DontChangeRandomCamera(false)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "挨拶")
-- ▲直接出力

	--★★ランスロット★★:ではな、ノワール<br>気を付けて行ってこい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B110_220002")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ<br>ランスロットもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_220003")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-180,0.5)
slidemove(Actor002,{0.5,0.128,18.3},2)
wait_time(0.5)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,-180,0.5)
slidemove(Actor003,{-1.40,0.128,17.1},2)
wait_time(3)
Hide(Actor002)
Hide(Actor003)
setup_small_camera_end()
manager.CloseupUpExclusiveCamera(Actor001)
set_rot(Actor005,{0,-115,0})
set_enable_auto_lookat_all(true)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B110_220004","MA_01B110_220005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ランスロットと仲がいいんだな<br>出発前、随分親しそうに話してた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_220007")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ボールス★★:かつてバルバロイに襲われたことがあってな<br>そのときに命を救ってもらった
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_220008")

	change_face(Actor004,"Smile")

	--★★ボールス★★:学園への入学を勧めてくれたのも<br>ランスロットだ
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_220009")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★クレア★★:それだけじゃないでしょう？
	Talk(Actor005,"CHRNAME_CLARE","speech","L","MA_01B110_220010")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ボールス★★:…クレア
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_220011")

	PlayAction(Actor005,"to  Std_Sad01")
	change_face(Actor005,"Sad")

	--★★クレア★★:ごめんなさい
	Talk(Actor005,"CHRNAME_CLARE","speech","L","MA_01B110_220012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴォールスは<br>ブリテン島東部の地理には詳しいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_220014")

-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ボールス★★:お前も東部で暮らしていたことがあるのだろう？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_220015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はカレドニアから東側はそれほどなんだ<br>母さんが病気がちであまり家を離れなかったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_220016")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:傭兵時代もカレドニア周辺や<br>西部での戦いばかりだったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_220017")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "納得")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ボールス★★:そうか。俺はブリテン東部を中心に活動する<br>海賊団に身を寄せていたことがあってな
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_220018")

	change_face(Actor004,"Smile")

	--★★ボールス★★:ちょうどねぐらもあったし<br>あのあたりの地理はある程度頭に入っている
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_220019")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その海賊団は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_220020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ボールス★★:なくなった<br>みんなバルバロイに喰われてな
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_220021")

	change_face(Actor004,"Normal")

	--★★ボールス★★:そのときに俺は<br>ランスロットに助けてもらったんだ
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_220022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:だからあんなに<br>親しそうに話していたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B110_220023")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat_all(true)
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1)
PlayActionDirect(Actor005,"to  Std_Talk")
 --PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★クレア★★:最強騎士が相手だからって負けられないわね<br>探偵として…探し物に関しては
	Talk(Actor005,"CHRNAME_CLARE","speech","L","MA_01B110_220025")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1)
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ボールス★★:俺たちも行こう
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B110_220026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
