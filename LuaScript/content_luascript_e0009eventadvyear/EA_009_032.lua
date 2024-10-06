-- このluaスクリプトは、EA_009_032.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_02","110071_02_h")
Include("content_adv_advsmall_110071_02","Template110071_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_004)
	Camera002 = SetTemplate("Actor002",-54.2,CharaPos110071_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_001)
	Camera003 = SetTemplate("Actor003",125.568,CharaPos110071_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_007)
	Camera005 = SetTemplate("Actor006",-61.134,CharaPos110071_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_02,CameraPos110071_02_007)
	InitializeTemplateRandomCamera110071_02()
	InitializeTemplate110071_02()
-- ▼直接出力
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
 --RndCamera001=RndCamera003
-- ▲直接出力
-- ▼直接出力
 --setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-7.4,0.13,12.6})
set_pos(Actor006,{0.27,0.13,13.28})
-- ▲直接出力
-- ▼直接出力
tegami2 = setup_prop_object(10106003)
off_active(tegami2)
tegami_offset2 = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
load_image("103050170", "content_still_10305017_image", "103050170_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Painful2")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101017","001","101017001")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…駄目だ。全然収穫無し
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320002")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:力を奪われたって生徒の話は聞くけど<br>肝心の魔術師の情報が無さすぎる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320003")


	--★★ノワール★★:けど<dot>力を奪う</dot>のが本当なら、そいつは<br>トリスタンが言う通りかなり強い魔術師のはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320004")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320006")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
PlayPartVoiceDirect("エレイン","0020")
-- ▲直接出力

	--★★エレイン★★:――そんなことないです！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320008")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
Appear(Actor002)
Appear(Actor003)
change_face(Actor003,"Sad")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,43.476,0.5)
 --turn_lookat(Actor001,Actor002, 0)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
 --set_enable_auto_lookat(Actor001, true)
-- ▲直接出力

	--★★ノワール★★:？今の声は――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320009")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Painful2")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0016")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:自分はなにもできないなんて<br>どうしてそんなふうに自分を責めるんですか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320012")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ディナタン★★:………
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0320013")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
turn_chara(Actor002,-86.8,0.5)
on_parent(tegami2,Actor002, "Loc_weapon_constrint_L", tegami_offset2)
on_active(tegami2)
PlayActionDirect(Actor002,"to ReadLetter")
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to ReadLetter")
setup_small_camera_start(RndCamera003)
se_play("SE_ADV_MA_01A900_30_Pen_Writing_01")
wait_time(2.0)
se_play("SE_ADV_MA_01105_28_Paper")
wait_time(1.5)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:…「だって私<br>ギネヴィアさんになにも返せてないから」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320015")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:「陰口を言われたら守ってくれて<br>ときには自分のことのように怒って」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320017")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320018")


	--★★エレイン★★:
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320019")


	--★★エレイン★★:「たくさん優しくしてもらった分<br>恩返ししたいのに」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320020")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力

	--★★エレイン★★:「そんなの全然いいのよって<br>ギネヴィアさんは笑ってたけど、よくない」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320021")


	--★★エレイン★★:「全然よくないの。だって」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320022")

-- ▼直接出力
PlayPartVoiceDirect("エレイン","0021")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:だって――
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320023")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★ディナタン★★:………
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0320025")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.4)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（ディナタン…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_009_0320026")

-- ▼直接出力
CloseTalkWindow()
IN_WALK(Actor004,CharaPos110071_02_007)
wait_time(0.5)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0004")
-- ▲直接出力

	--★★ラヴェイン★★:ノワールさん、ここにいたんですね<br>なにか有益な情報はありましたか
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","EA_009_0320028")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,200,0.5)
wait_time(0.5)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
PlayActionDirect(Actor001,"to Std_Loop")
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0017_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラヴェイン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320029")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320030")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0025")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラヴェイン★★:私も似たようなものです
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","EA_009_0320031")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ラヴェイン★★:まずは被害者の情報を整理してみましたが<br>目立った共通点もありませんでした
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","EA_009_0320032")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0034")
-- ▲直接出力

	--★★ラヴェイン★★:唯一確かな共通点といえば…
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","EA_009_0320033")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ラヴェイン★★:彼らが<dot>力を奪われた</dot>のは、学園近くに現れた<br>バルバロイの対応に出た後、ということ
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","EA_009_0320034")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力

	--★★ノワール★★:そういえば、ディナタンも…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320036")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_1")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
  --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("103050170", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
off_active(tegami2)
-- ▲直接出力

	--★★マルディサント★★:それがわかんねぇんだよ<br>いったいどうなってんだ！？
	Talk(Actor005,"CHRNAME_MALADISANT","simple","N","EA_009_0320038")


	--★★マルディサント★★:街の外にバルバロイをぶっ倒しに行くまでは<br>なんともなかったってのに
	Talk(Actor005,"CHRNAME_MALADISANT","simple","N","EA_009_0320039")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image() 
off_cameraframe()
off_screencolor()
setup_small_camera_start(RndCamera001)
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:…もし、バルバロイが生徒たちを<br>おびき寄せるための罠だったとしたら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320041")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
Appear(Actor006)
force_lipsync(Actor004,"Close1")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラヴェイン★★:…！
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","EA_009_0320042")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera001)
PlayActionDirect(Actor006,"to Run")
wait_time(0.5)
slidemove(Actor006,-2.432, 0.13, 15.042, 0.8)
wait_time(0.9)
PlayActionDirect(Actor006,"to Std_Loop")
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor001,-253,0.5)
turn_chara(Actor004,71.471,0.5)
turn_chara(Actor002,-133.6,0.5)
turn_chara(Actor003,186.73,0.5)
set_enable_auto_lookat(Actor003, true)
off_parent(tegami2)
off_active(tegami2)
force_lipsync(Actor004,"Auto")
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("女子1","0021")
-- ▲直接出力

	--★★女子生徒A★★:大変です！バルバロイの群れが<br>学園の近くに！
	Talk(Actor006,"NPCNAME_0146","speech","N","EA_009_0320044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --voice_play("VO_101009_sp_0017_2")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ラヴェイン…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320045")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0007")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ラヴェイン★★:だとしても、放っておくわけにはいきません
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","EA_009_0320046")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera005)
change_face(Actor002,"Anger")
change_face(Actor003,"Anger")
PlayActionDirect(Actor002,"to Run")
PlayActionDirect(Actor003,"to Run")
wait_time(0.5)
slidemove(Actor002,-2.5, 0.13, 16, 1.5)
slidemove(Actor003,-3.13, 0.13, 16.81, 1.7)
wait_time(1.7)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(RndCamera090)
voice_play("VO_101030_sp_0002_2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★エレイン★★:お兄ちゃん！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0320048")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0008")
-- ▲直接出力

	--★★ラヴェイン★★:行きましょう<br>学園を守るのが我々の役目ですから
	Talk(Actor004,"CHRNAME_LOVEIN","speech","L","EA_009_0320049")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:…ああ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0320050")

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
load_image_preload("103050170", "content_still_10305017_image", "103050170_StillImage")
preload_sound("BGM_ADV_Painful2")
preload_sound("BGM_ADV_Reconnaissance")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101017","001","101017001")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
