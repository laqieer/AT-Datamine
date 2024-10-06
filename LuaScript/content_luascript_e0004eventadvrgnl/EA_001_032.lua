-- このluaスクリプトは、EA_001_032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_04","110111_04_h")
Include("content_adv_advsmall_110111_04","Template110111_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_003)
	Camera002 = SetTemplate("Actor002",-151,CharaPos110111_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_002)
	Camera003 = SetTemplate("Actor003",90,CharaPos110111_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_005)
	Camera005 = SetTemplate("Actor005",-100,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	Camera012 = SetTemplate("Actor012",nil,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	InitializeTemplateRandomCamera110111_04()
	InitializeTemplate110111_04()
-- ▼直接出力
 --set_chara_pos_resetting(Actor001,{-4.59,0,-4.49, 18})
set_chara_pos_resetting(Actor001,{2.52,0,-4.49, -65})
CameraRagnar = set_camera({-5.267,1.491,-2.7,4.224,159.888,-0.868,28.22622})
Camera001 = manager.RegisterExclusiveCamera(CameraRagnar, Actor001)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002, {2.03,0,-3.41})
set_rot(Actor002, {0,-85,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003, {1.28,0,-3.31})
set_rot(Actor003, {0,-90,0})
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
set_chara_pos_resetting(Actor004,{-10.19,0,-6.88, 60})
CameraKei = set_camera({-4.652,1.827,-2.618,12.082,-144.791,-0.886,28.22622})
Camera004 = manager.RegisterExclusiveCamera(CameraKei, Actor004)
set_camera_nearclip(CameraKei,1.5)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005, {-10.16,0,-5.62})
set_rot(Actor005, {0,-100,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006, {-9.64,0,-4.22})
set_rot(Actor006, {0,-100,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007, {-7.64,0,-4.21})
set_rot(Actor007, {0,-100,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008, {-10.33,0,-7.42})
set_rot(Actor008, {0,-100,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor009, {-8.44,0,-3.02})
set_rot(Actor009, {0,-120,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor010, {-6.98,0,-8.19})
set_rot(Actor010, {0,-90,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor011, {-6.02,0,-7.62})
set_rot(Actor011, {0,-90,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor012, {-8.05,0,-7.87})
set_rot(Actor012, {0,-100,0})
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10130022)
set_pos(prop001,{-12.07,0,-8.07})
set_rot(prop001,{0,-90,0})
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
disableTextBox = true
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01C110_43_Bell")
 --se_play("SE_ADV_MA_01C110_42_Crowd")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor012")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera007)
wait_time(1.7)
se_play("SE_ADV_EA_001_032_Fire")
wait_time(0.8)
CloseTalkWindow()
hide_image()
se_play("SE_ADV_EA_001_032_Crowd_Loop")
PlayActionDirect(Actor001,"to Run")
PlayActionDirect(Actor002,"to Run")
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,{-5.514,0,-3.309}, 0.9)
wait_time(0.2)
slidemove(Actor002,{-4.246,0,-3.406}, 1.0)
wait_time(0.1)
slidemove(Actor001,{-4.59,0,-4.49}, 1.1)
wait_time(0.6)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
DontChangeRandomCamera(false)
PlayActionDirect(Actor001,"to  Std_Surp")
wait_time(0.5)
disableTextBox = false
open_textbox_base()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラグネル★★:<ruby=ボヤ>小火！？</ruby>
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ローラ★★:お魚さんを早く助けなきゃ──
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_032004")


	--★★ラグネル★★:は！？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032005")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")

	--★★ローラ★★:素人料理同好会の不始末らしくて<br><ruby=わたしたち>手芸サークル</ruby>の屋台にも火が…！！
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_032006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","EA_001_032008","EA_001_032009","EA_001_032010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:焼き魚になっちゃうな<br>ぬいぐるみが
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_032012")

-- ▼直接出力
turn_lookat(Actor001,Actor003,0.5)
PlayActionDirect(Actor001,"to  Std_Angry")
PlayPartVoice("ラグネル", "激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ラグネル★★:「なっちゃうな」じゃねェーよッッ！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032013")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
turn_lookat(Actor002,Actor003,0.4)
PlayActionDirect(Actor002,"to  Std_No")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ローラ★★:ノワールさん、ありえない…！<br>酷い、幻滅、人でなし、ろくでなし…！
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_032014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:手芸品が燃えたら出店ができない！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_032016")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ローラ", "0021")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ローラ★★:私が、私がちゃんと見張っていれば…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_032017")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:ローラちゃんのせいじゃないよ<br>誰のせいでもないんでしょ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032019")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ノワール★★:おのれ素人料理同好会…！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_032021")

-- ▼直接出力
turn_lookat(Actor001,Actor003,0.2)
PlayActionDirect(Actor001,"to  Std_No")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:わざとやったわけじゃないよ絶対っ！<br>いい人たちだったもん！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032022")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:頑張り過ぎちゃったんだよ、きっと…
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032023")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
Appear(Actor004)
setup_small_camera_start(Rndcamera001)
wait_time(0.2)
PlayActionDirect(Actor004,"to Run")
slidemove(Actor004,{-6.09, 0, -4.51}, 1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(0.9)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor004)
PlayActionDirect(Actor004,"to Std_Loop")
turn_chara(Actor003,-160,0)
set_enable_auto_lookat(Actor003, false)
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor003,Actor004,"J_Head")
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ケイ★★:さがしたぞ…！
	Talk(Actor004,"CHRNAME_KAY","speech","L","EA_001_032025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ローラ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ローラ★★:け、ケイ先生<br>あのっ、私たち、いま急ぎの用が…！！
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_032026")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:──バルバロイ？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032028")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:剣の祭壇が再び制圧されつつある<br>キャメリアードからの増援であろう…
	Talk(Actor004,"CHRNAME_KAY","speech","L","EA_001_032030")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ケイ", "苦しみ")
-- ▲直接出力

	--★★ケイ★★:すまないが<br>いま動ける者が貴公らしか…！
	Talk(Actor004,"CHRNAME_KAY","speech","L","EA_001_032031")

-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0007")
-- ▲直接出力

	--★★ラグネル★★:そんな感じだと思った、オツカレ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032032")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor004, false)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to  Std_Surp")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "悲しみ")
-- ▲直接出力

	--★★ローラ★★:で、でもラグネルさん<br>手芸品はどうするの…？ぬいぐるみも──…！！
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_032033")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor004)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:ケイ先生<br>そんな申し訳なさそうな顔しないでよ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032034")

-- ▼直接出力
wait_time(0.5)
DontChangeRandomCamera(false)
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:祭りの準備を続けて
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_032036")

-- ▼直接出力
se_play("SE_ADV_Loop_Stop")
wait_time(0.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130022)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
disableTextBox = true
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor012")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
