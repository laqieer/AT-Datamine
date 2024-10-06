-- このluaスクリプトは、EA_001_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_02","110901_02_h")
Include("content_adv_advsmall_110901_02","Template110901_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-55,CharaPos110901_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_003)
	Camera002 = SetTemplate("Actor002",-60,CharaPos110901_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_001)
	Camera003 = SetTemplate("Actor003",-60,CharaPos110901_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_008)
	InitializeTemplateRandomCamera110901_02()
	InitializeTemplate110901_02()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to ReadLetter")
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
set_pos(Actor002, {-1.708,0,1.239})
set_rot(Actor002, {0,-90,0})
 --keep_ik_lookat(Actor002,Actor001,"J_Head") 
 --lookat_delay_weight(Actor002, 0.8,0,0.5,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
set_pos(Actor003, {0,0,-4})
set_rot(Actor003, {0,-45,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:これは………似合わないもんね
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_031002")

-- ▼直接出力
wait_time(0.5)
CloseTalkWindow()
on_active(Actor002)
turn_lookat_position(Actor002,CharaPos110901_02_001[1],CharaPos110901_02_001[2],CharaPos110901_02_001[3],0)
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,CharaPos110901_02_001[1],CharaPos110901_02_001[2],CharaPos110901_02_001[3],2.0)
setup_small_camera_start()
wait_time(1.5)
setup_small_camera_start(Camera002)
wait_time(0.5)
turn_chara(Actor002,-60,0.2)
wait_time(0.2)
PlayActionDirect(Actor002,"to Std_Loop")
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
lookat_delay_weight(Actor002, 0.8,0,0.5,0.2,1.0)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:仮眠、できたか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_031004")

-- ▼直接出力
DontChangeRandomCamera(false)
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
PlayActionDirect(Actor001,"to LookFor")
wait_time(0.2)
se_play("SE_ADV_MA_01B112_49_Cloth")
wait_time(2.8)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,160,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:だめだね、あたし！<br>昼ごはん食べるとどーにもチョーシが
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_031006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:夜も寝ないで<br>ぬいぐるみ作ってるからだろ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_031007")

	change_face(Actor001,"Normal")

	--★★ラグネル★★:五月祭の準備<br>いくらやったって足りないもん
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_031008")


	--★★ノワール★★:手に………いまなにを隠したんだ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_031009")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:女の子はねえ、買ってみたはいいものの<br>決して着ない服ってのがあるんだよ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_031010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:き、着替え中だったのか？<br>それは、ご、ごめん
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_031011")

	change_face(Actor001,"Normal")

	--★★ラグネル★★:ねえノワール。君ってさ<br>あのガワのこと…どう思ってるの？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_031013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:ガワ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_031014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:イケてるけどデカすぎない？<br>ビッグシルエットにもほどがあるよ
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_031015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:あ。<ruby=ガワ>金コート</ruby>か<br>似合わないだろ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_031016")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:あー、んー<br>ぶっちゃけね
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_031018")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:だから、<ruby=フィットする>似合うようになる</ruby>まで着たいんだ<br>あれは………そうだな、多分──
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_031019")

-- ▼直接出力
wait_time(0.8)
setup_small_camera_start(Camera002)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:憧れのサイズ<br>なんだ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_001_031021")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラグネル★★:………憧れの？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_031022")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera006)
 on_active(Actor003)
turn_lookat_position(Actor003,CharaPos110901_02_008[1],CharaPos110901_02_008[2],CharaPos110901_02_008[3],0)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003,CharaPos110901_02_008[1],CharaPos110901_02_008[2],CharaPos110901_02_008[3],2.0)
wait_time(1.5)
setup_small_camera_start(Camera003)
wait_time(0.5)
turn_chara(Actor003,CharaPos110901_02_008[4],0.1)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor001,133,0)
turn_chara(Actor002,90,0)
change_face(Actor002,"Normal")
lookat_weight_reset(Actor001 , 1)
lookat_weight_reset(Actor002 , 1)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ローラ", "0021")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ローラ★★:ら、ラグネルさん！！<br>燃えちゃう！！
	Talk(Actor003,"CHRNAME_LOLA","speech","L","EA_001_031024")

-- ▼直接出力
wait_time(0.8)
DontChangeRandomCamera(false)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0028")
-- ▲直接出力

	--★★ラグネル★★:なに、どしたのローラちゃん<br>あたしはいつでも燃えてるけど？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_031025")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★ローラ★★:そうじゃなくて！！
	Talk(Actor003,"CHRNAME_LOLA","speech","L","EA_001_031026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Antagonism")
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
