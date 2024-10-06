-- このluaスクリプトは、EA_009_024.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_02","110141_02_h")
Include("content_adv_advsmall_110141_02","Template110141_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110141_02_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_009)
	Camera003 = SetTemplate("Actor003",198,CharaPos110141_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_003)
	Camera004 = SetTemplate("Actor004",65,CharaPos110141_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_006)
	Camera005 = SetTemplate("Actor005",175,CharaPos110141_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110141_02,CameraPos110141_02_002)
	InitializeTemplateRandomCamera110141_02()
	InitializeTemplate110141_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_weight(Actor001,0.5,0.1,0.9,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_weight(Actor002,0.6,0.1,0.9,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor003,0.65,0.1,0.9,0.2)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor004,0.5,0.1,0.9,0.2)
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor005,0.6,0.1,0.85,0.2)
keep_ik_lookat(Actor005,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("104000140", "content_still_10400014_image", "104000140_StillImage")
-- ▲直接出力
-- ▼直接出力
tegami = setup_prop_object(10106003)
off_active(tegami)
tegami_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
load_image("201010120", "content_still_20101012_image", "201010120_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:そういうことだったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力

	--★★ノワール★★:俺たちを気にしてくれていたんだな<br>心配かけてごめん、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240003")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:～～～！！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0240004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
set_enable_auto_lookat(Actor003, false)
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:？なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:――！――！――！！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0240007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん…ちょっとわからないかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240008")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:～～！！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0240009")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101017_sp_0002_3")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マルディサント★★:ディーナ…
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","EA_009_0240011")

-- ▼直接出力
set_enable_auto_lookat(Actor005, true)
set_enable_auto_lookat(Actor003, true)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0002")
-- ▲直接出力

	--★★エレイン★★:ディナタンさん<br>よければこれ、使ってください
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","EA_009_0240013")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
setup_small_camera_start()
wait_time(0.3)
PlayActionDirect(Actor004,"to LookFor")
wait_time(1.5)
PlayActionDirect(Actor004,"to Show")
wait_time(0.5)
ShowImageItem(104000140)
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0240014")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0008")
-- ▲直接出力

	--★★エレイン★★:レターセットです<br>私、いっぱい持ってるので！
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","EA_009_0240015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0240016")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
fadeout(0,0,0,1.0,1.0)
wait_time(1.2)
se_play("SE_ADV_MA_01A900_30_Pen_Writing_01")
wait_time(2.0)
se_play("SE_ADV_MA_01105_28_Paper")
show_image("201010120", 0.0, 0.0, 0,true,false)
fadein(1.0)
wait_time(1.9)
fadeout(0,0,0,1.0,1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
on_parent(tegami,Actor001, "Loc_weapon_constrint_L", tegami_offset)
on_active(tegami)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
keep_ik_lookat(Actor004,Actor001,"J_Head")
keep_ik_lookat(Actor005,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
wait_time(1.5)
hide_image(0)
fadein(1.0)
wait_time(1.35)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…えっと――<br>「謝らないで、兄さん」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240018")


	--★★ノワール★★:「私がやりたくてやったことなの<br>むしろ心配かけてごめんね」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240019")


	--★★ノワール★★:「でも私だってもう戦えるから<br>いつまでも守られるばかりじゃないよ」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240020")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.4)
off_parent(tegami)
off_active(tegami)
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…もしかして、俺ってちょっと<br>過保護だったりするのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240022")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0008")
-- ▲直接出力

	--★★イゾルデ★★:言われて気づくのなら上出来かもね
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","EA_009_0240023")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0007")
-- ▲直接出力

	--★★イゾルデ★★:少なくとも、ちゃんと言葉を尽くせば<br>伝わらないということはないのだから
	Talk(Actor005,"CHRNAME_ISOLDE","speech","L","EA_009_0240024")

-- ▼直接出力
setup_small_camera_end()
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…ああ、伝わったよ<br>ディナタンの気持ち
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240025")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0240026")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0002")
-- ▲直接出力

	--★★エレイン★★:…ねぇ、ディナタンさん<br>失くしたなら、取り戻せばいいんですよ
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","EA_009_0240027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0026")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★エレイン★★:それで、コンサートも成功させましょう！
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","EA_009_0240028")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…！！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0240029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:エレイン…ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240031")

-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0048")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★エレイン★★:えへへ…そうと決まれば、まずは<br>声を取り戻すための方法を見つけましょう
	Talk(Actor004,"CHRNAME_ELAINE","speech","L","EA_009_0240032")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな…どこかで調べてみるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0240033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_009_0240035","EA_009_0240036","EA_009_0240037")
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
reserve_next_script("シナリオイベクエ/新年24/2話_ADV_4_2")
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
reserve_next_script("シナリオイベクエ/新年24/2話_ADV_4_3")
-- ▲直接出力
	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
reserve_next_script("シナリオイベクエ/新年24/2話_ADV_4_4")
-- ▲直接出力
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
load_image_preload("104000140", "content_still_10400014_image", "104000140_StillImage")
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
load_image_preload("201010120", "content_still_20101012_image", "201010120_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
