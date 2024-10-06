-- このluaスクリプトは、MA_01C111_26.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation04","DuelCommonFormation04_h")
Include("content_adv_advsmall_duelcommonformation04","TemplateDuelCommonFormation04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",-180,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera004 = SetTemplate("Actor004",-180,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera005 = SetTemplate("Actor005",-28.041,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera008 = SetTemplate("Actor008",-180,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10104005_anim", "10104005_StillAnim", nil, nil, nil, "Root")
load_image("10101014", "content_still_10101014_image", "101010140_StillImage") 
show_image("10101014", 0.0, 0.0, 0.0,true,false)
set_scale_image(20,20)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
set_scale_image(20,20)
set_animationbattlecontroller(Actor005,1,true)
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"ToAbnormal")
set_camera_nearclip(Camera005,1)
halloween_prop = setup_prop_object(10102011)
set_pos(halloween_prop,{0,0,0})
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2MB")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005,Actor001,"J_Head")
keep_ik_lookat(Actor001,Actor005,"J_Head")
keep_ik_lookat(Actor002,Actor005,"J_Head")
keep_ik_lookat(Actor003,Actor005,"J_Head")
keep_ik_lookat(Actor004,Actor005,"J_Head")
keep_ik_lookat(Actor008,Actor005,"J_Head")
set_enable_auto_lookat_all(false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",70,CharaPosDuelCommonFormation04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_011)
	Camera002 = SetTemplate("Actor002",40,CharaPosDuelCommonFormation04_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_012)
	Camera003 = SetTemplate("Actor003",100,CharaPosDuelCommonFormation04_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_013)
	Camera004 = SetTemplate("Actor004",120,CharaPosDuelCommonFormation04_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_015)
	Camera005 = SetTemplate("Actor005",-140,CharaPosDuelCommonFormation04_014,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_014)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_002)
	Camera008 = SetTemplate("Actor008",-90,CharaPosDuelCommonFormation04_016,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_016)
	InitializeTemplateRandomCameraDuelCommonFormation04()
	InitializeTemplateDuelCommonFormation04()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
set_scale_image(20,20)
set_animationbattlecontroller(Actor005,1,true)
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"ToAbnormal")
set_camera_nearclip(Camera005,1)
halloween_prop = setup_prop_object(10102011)
set_pos(halloween_prop,{0,0,0})
-- ▲直接出力
-- ▼直接出力
 set_pos(Actor002,{0.7,0,0.72})
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
 --set_pos(Actor003,{-1.63,0,34.7})
set_pos(Actor003,{-3.53,0,5.28})
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
 --set_pos(Actor004,{-2.78,0,3.61})
set_pos(Actor004,{-3.73,0,3.38})
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
set_pos(Actor006,{-1.15,0,-6.26})
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
set_pos(Actor007,{-3.42,0,-7.16})
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
 --set_pos(Actor008,{9.73,0,2.55})
set_pos(Actor008,{11.86,0,1.53})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005,Actor001,"J_Head")
keep_ik_lookat(Actor001,Actor005,"J_Head")
keep_ik_lookat(Actor002,Actor005,"J_Head")
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2MB")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101150093)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101046","001","101046001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
CloseTalkWindow()
fadeout(0, 0, 0, 0, 0.5)
wait_time(0.5)
	stillAnime.SetActive(true)
hide_image(0)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
-- ▲直接出力

	--★★ランスロット★★:仮装とはいえなかなかの光景だな<br>これがすべて本当の魔女だったら
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","MA_01C111_260002")


	--★★ノワール★★:考えるだけでゾッとする
	Talk(Actor003,"CHRNAME_NOIR","simple","N","MA_01C111_260003")


	--★★ランスロット★★:そうだな<br>特に今は魔女の力が増大する時期だ
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","MA_01C111_260004")


	--★★ノワール★★:魔女たちは今<br>ルーシャスの側にいるんだよな
	Talk(Actor003,"CHRNAME_NOIR","simple","N","MA_01C111_260005")


	--★★ランスロット★★:ああ<br>今現在、ローマの動きは見えないが
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","MA_01C111_260006")


	--★★ランスロット★★:相手にせずに済むなら<br>それに越したことはない
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","MA_01C111_260007")


	--★★ランスロット★★:それにしても…こうも皆が仮装をしていると<br>誰が誰だかわからないな
	Talk(Actor004,"CHRNAME_LANCELOT","simple","N","MA_01C111_260008")


	--★★ノワール★★:あそこではしゃいでるのがギネヴィアだろ<br>で、あっちがディナタンとマルディサント
	Talk(Actor003,"CHRNAME_NOIR","simple","N","MA_01C111_260009")


	--★★ノワール★★:あそこにはガレスたちもいるな<br>みんな楽しそうだ
	Talk(Actor003,"CHRNAME_NOIR","simple","N","MA_01C111_260010")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★ノワール★★:…ん？　あれは――
	Talk(Actor003,"CHRNAME_NOIR","simple","N","MA_01C111_260011")

-- ▼直接出力
bgm_play("BGM_ADV_Serious2MB")
-- ▲直接出力

	--★★ローラ★★:………
	Talk(Actor005,"CHRNAME_NAMELES","simple","N","MA_01C111_260013")

-- ▼直接出力
	CloseTalkWindow()
	signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(0, 0, 0, 0, STILL_SWITCH_TIME)
	wait_time(STILL_SWITCH_TIME)
stillAnime.SetActive(false)
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
template2()
wait_time(1.0)
fadein(0.5)
-- ▲直接出力

	--★★マルディサント★★:おい、なんだよアンタ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_260015")


	--★★ローラ★★:………
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01C111_260017")


	--★★ローラ★★:…けて
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01C111_260019")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:あ？なんだよ<br>言いたいことがあんならハッキリ言え
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C111_260020")

-- ▼直接出力
CameraEX = set_camera({3.001,1.436,4.473,12.538,-154.104,0.5,40})
setup_small_camera_start(CameraEX)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:待って、マァル<br>この人――
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C111_260021")

-- ▼直接出力
CloseTalkWindow() 
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ローラ★★:たすけ、て
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01C111_260023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor005)
lookat_delay_weight(Actor005,1,0.03,0.7,0,0.5)
-- ▲直接出力

	--★★ローラ★★:ルーシャス様を…たすけて――
	Talk(Actor005,"CHRNAME_NAMELES","speech","L","MA_01C111_260025")

	open_cutin(2,1)
	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor001,"Surprise")

	--★★ディナタン／マルディサント★★:！！
	Talk(Actor009,"CHRNAME_DINATAN_MALADISANT","speech","N","MA_01C111_260027")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera001)
lookat_delay_weight_reset(Actor005,0.5)
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,{2.536,0,2.1},0.4)
PlayActionDirect(Actor001,"to Run")
slidemove(Actor001,{1.8, 0, 2.98},0.4)
wait_time(0.3)
turn_lookat(Actor001,Actor005,0.2)
turn_lookat(Actor002,Actor005,0.2)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
reserve_eyesync(Actor005,"Close")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera003)
Appear(Actor003)
Appear(Actor004)
Appear(Actor008)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,{1.57,0,4.137},1)
wait_time(0.3)
PlayActionDirect(Actor004,"to Run")
slidemove(Actor004,{0.38,0,3.01},1)
PlayActionDirect(Actor008,"to Run")
slidemove(Actor008,{3.88,0,2.55},1.0)
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
turn_lookat( Actor003,Actor005, 0.3)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.3)
turn_lookat( Actor004,Actor005, 0.3)
turn_lookat( Actor008,Actor005, 0.3)
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor008,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:ローラ！？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01C111_260028")


	--★★グリートーネア★★:あらあ、やっぱり<br>お姉さまの言うとおり
	Talk(Actor006,"CHRNAME_NAMELES","speech","N","MA_01C111_260030")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera007)
set_chara_pos_resetting(Actor003,CharaPosDuelCommonFormation04_013)
set_chara_pos_resetting(Actor001,CharaPosDuelCommonFormation04_011)
set_chara_pos_resetting(Actor002,CharaPosDuelCommonFormation04_012)
set_chara_pos_resetting(Actor004,CharaPosDuelCommonFormation04_015)
set_chara_pos_resetting(Actor008,CharaPosDuelCommonFormation04_016)
-- ▲直接出力
-- ▼直接出力
Appear(Actor006)
Appear(Actor007)
PlayActionDirect(Actor007,"to Wlk")
turn_lookat_position(Actor007,CharaPosDuelCommonFormation04_002[1],CharaPosDuelCommonFormation04_002[2],CharaPosDuelCommonFormation04_002[3],0.0)
slidemove(Actor007,{CharaPosDuelCommonFormation04_002[1],0.0,CharaPosDuelCommonFormation04_002[3]},2.0)
wait_time(0.3)
PlayActionDirect(Actor006,"to Wlk")
turn_lookat_position(Actor006,CharaPosDuelCommonFormation04_001[1],0.0,CharaPosDuelCommonFormation04_001[3],0.0)
slidemove(Actor006,{CharaPosDuelCommonFormation04_001[1],0.0,CharaPosDuelCommonFormation04_001[3]},2.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.7)
turn_lookat(Actor006,Actor003,0.3)
wait_time(0.3)
turn_lookat(Actor007,Actor003,0.3)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.3)
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat(Actor006, true)
set_enable_auto_lookat(Actor007, true)
keep_ik_lookat(Actor001,Actor006,"J_Head")
keep_ik_lookat(Actor002,Actor006,"J_Head")
keep_ik_lookat(Actor003,Actor006,"J_Head")
keep_ik_lookat(Actor004,Actor006,"J_Head")
keep_ik_lookat(Actor008,Actor006,"J_Head")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ノワール★★:魔女！？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01C111_260032")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
set_enable_auto_lookat_all(false)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
--グリートーネア,CHRNAME_SISTERS_4 @名前変更
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★グリートーネア★★:あれだけ大口をたたいておきながら<br>結局ログレスを頼るなんて
	Talk(Actor006,"CHRNAME_SISTERS_4","speech","R","MA_01C111_260033")

	PlayAction(Actor007,"to  Std_Worry")
	change_face(Actor007,"Smile")

	--★★グリートン★★:王様が聞いて呆れますねぇ♪
	Talk(Actor007,"CHRNAME_SISTERS_5","speech","R","MA_01C111_260034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Surp")
	change_face(Actor008,"Surprise")

	--★★ギネヴィア★★:なんで、魔女がここに！？
	Talk(Actor008,"CHRNAME_GUINEVERE","speech","L","MA_01C111_260036")

	PlayAction(Actor006,"to Greet_one")

	--★★グリートーネア★★:契約破棄のニオイを嗅ぎ付けたので<br>実力行使にきたんです…♪
	Talk(Actor006,"CHRNAME_SISTERS_4","speech","R","MA_01C111_260037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")

	--★★グリートン★★:今のあたしたちならやれるわ<br>だって今宵は楽しい楽しいハロウィンですもの♪?
	Talk(Actor007,"CHRNAME_SISTERS_5","speech","R","MA_01C111_260038")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_ui_effect_preload("content_still_10104005_anim", "10104005_StillAnim", nil, nil, nil, "Root")
load_image_preload("10101014", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10102011)
preload_sound("BGM_ADV_Serious2MB")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10102011)
preload_sound("BGM_ADV_Serious2MB")
	InitializeLoad_Preload()
	load_duel_scene_preload(101150093)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101046","001","101046001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor008")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
