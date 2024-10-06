-- このluaスクリプトは、EA_009_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-40,CharaPos110011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_008)
	Camera002 = SetTemplate("Actor002",200,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.85,0.2)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-0.843,0,-3.193})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-1.274,0,-2.964})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
show_image("101010150", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
tegami = setup_prop_object(10106003)
off_active(tegami)
tegami_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
CameraDina = set_camera({0.94, 1.801, -4.33,   12.89201, 46.9, 0,   25})
-- ▲直接出力
-- ▼直接出力
CameraEl = set_camera({2.9, 1.6, -1.44,   9.97, 210.87, 0,   32})
-- ▲直接出力
-- ▼直接出力
CameraMal = set_camera({2.52, 1.62, -1.08,   5.9, 218.8, 0,   25})
-- ▲直接出力
-- ▼直接出力
CameraNoi = set_camera({0.501, 1.64, -1.189,   5.5, 134, 0.023,   22})
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-1.586, 2.855, -0.513,   22.99999, 127.484, 0,   32})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:結局『力を奪う魔術師』を倒しても<br>ディナタンの声は戻らなかった
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_009_0510003")


	--★★ノワール★★:コンサートは中止したほうがいい<br>アーサーにそう伝えよう
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_009_0510004")


	--★★ノワール★★:そう言った俺にディナタンは手紙を寄こした
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_009_0510005")


	--★★ディナタン★★:「私、歌いたい<br>私の気持ちを届けるために」
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","EA_009_0510006")


	--★★ノワール★★:――そして、年が明けた
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_009_0510007")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera006)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
wait_time(1.0)
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:…本当にやるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0510010")

-- ▼直接出力
setup_small_camera_start(CameraDina)
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
wait_time(1.8)
setup_small_camera_start(Camera001)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_009_0510013","EA_009_0510014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:けど、お前…まだ声が戻っていないだろう<br>それなのに…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0510017")

-- ▼直接出力
CloseTalkWindow()
on_active(Actor003)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,CharaPos110011_01_006[1],CharaPos110011_01_006[2],CharaPos110011_01_006[3],0)
slidemove(Actor003,CharaPos110011_01_006[1],CharaPos110011_01_006[2],CharaPos110011_01_006[3],2.0)
setup_small_camera_start(CameraEx_01)
wait_time(1.8)
setup_small_camera_start(CameraEl)
slidemove(CameraEl,{2.86, 1.589, -1.51},8)
wait_time(0.2)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★エレイン★★:大丈夫ですよ、先輩<br>ディナタンさんがやると決めたなら、絶対大丈夫
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510019")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-75,0.3)
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-107,0.3)
wait_time(0.1)
PlayActionDirect(Actor001,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
set_enable_auto_lookat(Actor002, false)
setup_small_camera_start(CameraNoi)
slidemove(CameraNoi,{0.637, 1.622, -1.32},8)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0016_3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:エレイン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0510020")

-- ▼直接出力
CloseTalkWindow()
CameraEl = set_camera({2.9, 1.6, -1.44,   9.97, 210.87, 0,   32})
setup_small_camera_start(CameraEl)
slidemove(CameraEl,{2.86, 1.589, -1.51},8)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…そうか。わかった<br>お前がそこまで言うならもう止めないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0510023")

-- ▼直接出力
CloseTalkWindow()
on_active(Actor003)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,CharaPos110011_01_006[1],CharaPos110011_01_006[2],CharaPos110011_01_006[3],0)
slidemove(Actor003,CharaPos110011_01_006[1],CharaPos110011_01_006[2],CharaPos110011_01_006[3],2.0)
setup_small_camera_start(CameraEx_01)
wait_time(1.8)
setup_small_camera_start(CameraEl)
slidemove(CameraEl,{2.86, 1.589, -1.51},8)
wait_time(0.2)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★エレイン★★:意外です。先輩なら止めようとするかと思って<br>私、割って入る準備をしてたんですよ
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510025")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-75,0.3)
wait_time(0.2)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-107,0.3)
wait_time(0.1)
PlayActionDirect(Actor001,"to Std_Loop")
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
set_enable_auto_lookat(Actor002, false)
setup_small_camera_start(CameraNoi)
slidemove(CameraNoi,{0.637, 1.622, -1.32},8)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:もうそんなことしないさ<br>ディナタンの強さは兄貴の俺が一番知ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0510026")

-- ▼直接出力
CloseTalkWindow()
CameraEl = set_camera({2.9, 1.6, -1.44,   9.97, 210.87, 0,   32})
setup_small_camera_start(CameraEl)
slidemove(CameraEl,{2.86, 1.589, -1.51},8)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:…さすが先輩です
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510027")

	goto Block1end

::Block1end::
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor003,0.5,0.1,0.85,0.2,1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0002")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エレイン★★:ディナタンさん、お時間良いですか？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510029")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0510030")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor003,0.6)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to ReadLetter")
wait_time(0.2)
on_parent(tegami,Actor003, "Loc_weapon_constrint_L", tegami_offset)
on_active(tegami)
CameraEl = set_camera({2.9, 1.6, -1.44,   9.97, 210.87, 0,   32})
setup_small_camera_start(CameraEl)
slidemove(CameraEl,{2.86, 1.589, -1.51},8)
wait_time(0.8)
-- ▲直接出力

	--★★エレイン★★:すぅ…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510031")

-- ▼直接出力
PlayPartVoiceDirect("エレイン","0007")
-- ▲直接出力

	--★★エレイン★★:ディナタンさんの初コンサート<br>すごくすごく楽しみにしてきました
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510034")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:ディナタンさんらしい、優しくて芯の強い歌声は<br>１年の始まりを素敵に彩ってくれることでしょう
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510035")

	change_face(Actor003,"Normal")

	--★★エレイン★★:ディナタンさんの本気の声には力がある<br>…想いはきっと、伝わるはずです
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510036")

-- ▼直接出力
PlayPartVoiceDirect("エレイン","0011")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:だからどうか、コンサートを楽しんでください
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510037")

-- ▼直接出力
CameraEl = set_camera({2.9, 1.6, -1.44,   9.97, 210.87, 0,   32})
setup_small_camera_start(CameraEl)
slidemove(CameraEl,{2.86, 1.589, -1.51},8)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★エレイン★★:あなたのファン、そして友人・Ｅより
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510038")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
PlayActionDirect(Actor003,"to Std_Loop")
off_parent(tegami)
off_active(tegami)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0510039")

-- ▼直接出力
CloseTalkWindow()
CameraEl = set_camera({2.9, 1.6, -1.44,   9.97, 210.87, 0,   32})
setup_small_camera_start(CameraEl)
slidemove(CameraEl,{2.86, 1.589, -1.51},8)
lookat_delay_weight(Actor003,0.5,0.1,0.85,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★エレイン★★:えへへ…ファンレターです
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0510040")

-- ▼直接出力
CloseTalkWindow()
on_active(Actor004)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat_position(Actor004,CharaPos110011_01_007[1],CharaPos110011_01_007[2],CharaPos110011_01_007[3],0)
slidemove(Actor004,CharaPos110011_01_007[1],CharaPos110011_01_007[2],CharaPos110011_01_007[3],2.0)
setup_small_camera_start(CameraEx_01)
wait_time(1.8)
setup_small_camera_start(CameraMal)
slidemove(CameraMal,{2.41,1.6,-1.22},10)
wait_time(0.2)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Laugh")

	--★★マルディサント★★:よっし！そろそろ最終リハ始めるぞ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0510042")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0002")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マルディサント★★:オニーサン、部外者はとっとと出てきな！<br>ディーナに変な圧かけてんじゃねぇぞ！
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","EA_009_0510043")

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかったよ…<br>それじゃ、客席で見てるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0510044")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:がんばれよ、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0510045")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
change_face(Actor002,"Smile")
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.3)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
wait_time(1.8)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
