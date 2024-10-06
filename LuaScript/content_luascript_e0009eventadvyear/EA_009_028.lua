-- このluaスクリプトは、EA_009_028.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera003 = SetTemplate("Actor003",103.089,CharaPos112041_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_001)
	Camera004 = SetTemplate("Actor004",46.886,CharaPos112041_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_008)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
Hide(Actor004)
set_pos(Actor004,{-2.65,0,-1.52})
-- ▲直接出力
-- ▼直接出力
tegami2 = setup_prop_object(10106003)
off_active(tegami2)
tegami_offset2 = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("201010130", "content_still_20101013_image", "201010130_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:色々試してみたけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280002")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:………
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0280003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0007")
-- ▲直接出力

	--★★エレイン★★:気落ちしないでください、ディナタンさん<br>まだ時間はありますから
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0280005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力

	--★★ノワール★★:そうだぞ。マルディサントたちも治療法を<br>調べてくれてるんだ、焦ることはないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280006")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:それにコンサートができなくなったって<br>誰もディナタンを責めたりしない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280007")


	--★★ノワール★★:ギネヴィアだって――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:………！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0280009")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Pain")

	--★★ディナタン★★:～～～！！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0280010")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0017")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★エレイン★★:だ、だめです！ディナタンさん！<br>無理をしちゃ喉を痛めます！！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0280012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★エレイン★★:
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0280013")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0280014")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタン…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280016")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.8)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("女子1","0031")
-- ▲直接出力

	--★★女子生徒A★★:だ、誰か！誰か来て！！
	Talk(Actor004,"NPCNAME_0146","speech","L","EA_009_0280017")

-- ▼直接出力
setup_small_camera_start(Camera001)
change_face(Actor003,"Surprise")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-145.712,0.5)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,202,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうした！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280019")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
IN_RUN(Actor004,CharaPos112041_03_008)
turn_lookat(Actor002,Actor004,0)
turn_lookat(Actor003,Actor004,0)
wait_time(0.5)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor003, true)
keep_ik_lookat(Actor002,Actor004,"J_Head")
turn_lookat(Actor001,Actor004,0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")

	--★★女子生徒A★★:バルバロイが出て、皆で出撃したんだけど…<br>数が多くて私たちだけじゃ…お願い、助けて！
	Talk(Actor004,"NPCNAME_0146","speech","N","EA_009_0280020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Anger")

	--★★ディナタン★★:！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0280022")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{1.039,0,1.566},1)
wait_time(0.3)
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor002,"to Std_Loop")
se_play("SE_ADV_MA_01A900_30_Pen_Writing_01")
wait_time(1.5)
se_play("SE_ADV_MA_01105_28_Paper")
wait_time(0.7)
fadein(0.5)
show_image("201010130", 0.0, 0.0, 0.0)
wait_time(CHARA_IN_OUT + 0.5)
wait_time(2.0)
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
keep_ik_lookat(Actor003,Actor001,"J_Head")
hide_image()
on_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
on_active(tegami2)
PlayActionDirect(Actor001,"to ReadLetter")
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
change_face(Actor001,"Surprise")
PlayActionDirect(Actor002,"to Run")
 --slidemove(Actor002,{-2.78,0,-1.21},1.5)
wait_time(1.3)
PlayActionDirect(Actor002,"to Std_Loop")
Hide(Actor004)
Hide(Actor002)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)

-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0003_2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280024")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
turn_lookat(Actor003,Actor001,0)
turn_lookat(Actor001,Actor003,0)
set_enable_auto_lookat(Actor001,true)
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor001,Actor003,"J_Head")
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0047")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★エレイン★★:さすが、先輩の妹さん<br>傭兵団上がりは伊達じゃないですね…！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0280025")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★エレイン★★:ちなみに手紙にはなんて？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0280026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:えっと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280027")


	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280029")


	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280030")

-- ▼直接出力
wait_time(0.8)
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
off_parent(tegami2,Actor001, "Loc_weapon_constrint_L", tegami_offset2)
off_active(tegami2)
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("エレイン","0034")
-- ▲直接出力

	--★★エレイン★★:…さすが先輩の妹さん<br>行動力が違います…！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0280031")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力

	--★★ノワール★★:それはもういいよ…ああ、もうしかたない<br>――俺たちも行こう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0280032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106003)
tegami_offset2 = {0,0,0,0,0,0}
load_image_preload("201010130", "content_still_20101013_image", "201010130_StillImage")
preload_sound("BGM_ADV_Antagonism")
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
