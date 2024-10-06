-- このluaスクリプトは、MA_01A110_48.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("10101015", "content_still_10101015_image", "101010150_StillImage") 
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10103005_anim", "10103005_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
show_image("10101015", 0.0, 0.0, 0 )
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,1.0,0.5,1.0,0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,1.0,0.5,1.0,0)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.5)
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102008)
set_pos(BgProp,{0,0,0})
Kusa = get_object("geo_bush_round") --草
set_pos(Kusa, {0.0, -3.0, 0.0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
CloseTalkWindow()
fadeout(255, 255, 255, 0, 0.5)
wait_time(0.5)
	stillAnime.SetActive(true)
hide_image(0)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(255, 255, 255, 0, STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
stillAnime.SetActive(false)
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:学園祭も２日目か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_480002")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンはマルディサントと<br>回るって言ってたし…どうしようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_480003")

	open_select_window_tag(Actor001,"Normal","MA_01A110_480004","MA_01A110_480005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor002)
lookat_delay_weight(Actor001, {1.2, 0, 0.5, 0.2} ,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
 --DontChangeRandomCamera(true)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:どうせヒマしてるんでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_480007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:一緒に学園祭まわったげる<br>わたしもちょーどヒマだから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_480008")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:というかまわるわよね？<br>ログレス市街で待ってるから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_480009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor003)
lookat_delay_weight(Actor001, {1.2, 0, 0.5, 0.2} ,0.2)
keep_ik_lookat(Actor001,Actor003,"J_Head")
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor003)
 --DontChangeRandomCamera(true)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:…先輩、さがしました
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_480011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
lookat_delay_weight_reset(Actor003 , 0.6)
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★エレイン★★:もし、仮に、よければ、なんですけど…<br>私と一緒は…いやですか？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_480012")

-- ▼直接出力
lookat_delay_weight(Actor003, {1.0, 0.08, 0.6, 0.5} , 0.5)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★エレイン★★:もし、よかったら…私とまわりませんか？<br>学園の食堂前で待ってますから…それじゃ
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_480013")

	goto Block1end

::Block1end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10101015", "content_still_10101015_image", "101010150_StillImage")
load_ui_effect_preload("content_still_10103005_anim", "10103005_StillAnim", nil, nil, nil, "Root")
setup_prop_object_preload(10102008)
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
