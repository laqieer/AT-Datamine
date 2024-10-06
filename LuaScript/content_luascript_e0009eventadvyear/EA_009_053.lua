-- このluaスクリプトは、EA_009_053.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_04","110101_04_h")
Include("content_adv_advsmall_110101_04","Template110101_04_h")
-- ▼直接出力
Include("content_luascript_system", "MovieFunctions")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110101_04,CameraPos110101_04_007)
	Camera002 = SetTemplate("Actor003",nil,CharaPos110101_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110101_04,CameraPos110101_04_001)
	Camera003 = SetTemplate("Actor005",nil,CharaPos110101_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110101_04,CameraPos110101_04_004)
	Camera004 = SetTemplate("Actor006",nil,CharaPos110101_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110101_04,CameraPos110101_04_005)
	Camera005 = SetTemplate("Actor007",nil,CharaPos110101_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110101_04,CameraPos110101_04_006)
	Camera006 = SetTemplate("Actor009",nil,CharaPos110101_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110101_04,CameraPos110101_04_003)
	Camera007 = SetTemplate("Actor010",nil,CharaPos110101_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110101_04,CameraPos110101_04_002)
	Camera008 = SetTemplate("Actor011",nil,CharaPos110101_04_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110101_04,CameraPos110101_04_008)
	Camera009 = SetTemplate("Actor012",nil,CharaPos110101_04_009,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110101_04,CameraPos110101_04_009)
	InitializeTemplateRandomCamera110101_04()
	InitializeTemplate110101_04()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
load_image("201010050", "content_still_20101005_image", "201010050_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("201010080", "content_still_20101008_image", "201010080_StillImage")
-- ▲直接出力
-- ▼直接出力
movie_load("EA_009_053")
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
Hide(Actor009)
Hide(Actor010)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Dinatan_Stage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_2DOnly("101017","001","101017001")
	Actor003 = InitializeCharacter_3D("101012","006","101012006","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101030","006","101030006","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	Actor009 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101030","006","101030006","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor012")
	Actor013 = InitializeCharacter_2DOnly("101014","001","101014001")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★トリスタン3★★:じゃあ、ボクは先に出てるから
	Talk(Actor013,"CHRNAME_TRISTAN","speech","L","EA_009_0530002")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン_002","0003")
-- ▲直接出力

	--★★トリスタン3★★:…もし声が出なかったとしても<br>演出と演奏でフォローできるから
	Talk(Actor013,"CHRNAME_TRISTAN","speech","L","EA_009_0530003")

	change_face(Actor013,"Sad")

	--★★トリスタン3★★:…だから、まあ――<br>あまり気負わずやってみなよ
	Talk(Actor013,"CHRNAME_TRISTAN","speech","L","EA_009_0530004")

-- ▼直接出力
PlayPartVoiceDirect("マルディサント","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","EA_009_0530006")

	change_face(Actor003,"Smile")

	--★★ディナタン★★:！！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0530007")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor003,"Normal")
hide_image(BLACK_WHITE_TIME)
wait_time(4.0)
show_image("201010050", 0.0, 0.0, 0.8,true,false)
wait_time(1.8)
-- ▲直接出力

	--★★テロップ★★:歌は好き。だけど皆の前で歌うのは苦手<br>たくさんの人に注目されるのも嫌
	Talk(Actor004,"telop","simple","N","EA_009_0530017")


	--★★テロップ★★:だって私はそんな大層な器じゃないから
	Talk(Actor004,"telop","simple","N","EA_009_0530018")


	--★★テロップ★★:私はお姫様じゃないし、特別強いわけでもない<br>歌だって、ちゃんと誰かに習ったわけでもない
	Talk(Actor004,"telop","simple","N","EA_009_0530019")


	--★★テロップ★★:それでも――届けたいって思ったの
	Talk(Actor004,"telop","simple","N","EA_009_0530020")


	--★★ノワール★★:
	Talk(Actor005,"CHRNAME_NOIR","simple","N","EA_009_0530022")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(1.2)
hide_image(0.0)
wait_time(0.6)
se_play("SE_ADV_EA_009_053_Applause")
wait_time(6.4)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0002")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:皆さん…まずは<br>――あけましておめでとうございます
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0530025")


	--★★生徒たち★★:おめでとう！
	Talk(Actor008,"NPCNAME_0116","speech","L","EA_009_0530026")


	--★★ディナタン★★:厳しい戦いに疲れた人たちの心を癒したい<br>そして背中を押したい。また頑張れるように
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0530027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:そんな私の想いを届けるために<br>たくさんの人が協力して、支えてくれて…
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0530028")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★ディナタン★★:そのおかげでこうして、こんな素敵な<br>コンサートを開くことができました
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0530029")

	change_face(Actor003,"Normal")

	--★★ディナタン★★:…どんなに苦しくても、私たちはひとりじゃない<br>ここにはいつだって支えてくれる仲間がいるから
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0530030")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:私たちはひとりで戦っているわけじゃないんだ…<br>その気持ちを、歌に乗せて届けます
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0530031")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
setup_small_camera_start(Camera003)
wait_time(TIME_ELAPSED + FADE_TIME)
movie_set_active(true)
movie_play()
movie_wait_playing()
movie_stop()
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_1")
wait_time(0.4)
hide_image(BLACK_WHITE_TIME)
wait_time(FADE_TIME)
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0010")
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ギネヴィア★★:…素敵な歌ね
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","EA_009_0530035")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ノワール★★:
	Talk(Actor005,"CHRNAME_NOIR","speech","L","EA_009_0530036")


	--★★ギネヴィア★★:
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","EA_009_0530037")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Smile")

	--★★ギネヴィア★★:…わたし、この歌好きだわ
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","EA_009_0530038")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_LongFade3")
wait_time(4.4)
setup_small_camera_end(Camera003)
setup_small_camera_start(Camera002)
wait_time(3.6)
-- ▲直接出力

	--★★ディナタン★★:――いよいよ最後の曲になりました
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","EA_009_0530040")


	--★★生徒たち★★:え～！
	Talk(Actor008,"NPCNAME_0116","speech","L","EA_009_0530041")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
show_image("201010080", 0.0, 0.0, 0.8,true,false)
wait_time(1.0)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Noon_D")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:ふふっ…最後の曲は…<br>――皆で一緒に歌いましょう
	Talk(Actor003,"CHRNAME_DINATAN","simple","N","EA_009_0530042")

	change_face(Actor006,"Surprise")

	--★★ギネヴィア★★:
	Talk(Actor006,"CHRNAME_GUINEVERE","simple","N","EA_009_0530043")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
setup_small_camera_start(Camera007)
Hide(Actor007)
Hide(Actor001)
Appear(Actor010)
Appear(Actor009)
wait_time(1.0)
hide_image(0.0)
wait_time(1.4)
-- ▲直接出力
	PlayAction(Actor010,"to  Std_Talk")

	--★★エレイン2★★:皆さん、入場時に配った冊子をご用意ください<br>そちらに楽譜を載せてあります
	Talk(Actor010,"CHRNAME_ELAINE","speech","L","EA_009_0530047")

	play_head_motion(Actor010, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0010")
-- ▲直接出力
	change_face(Actor010,"Smile")

	--★★エレイン2★★:それを見ながら、皆で一緒に歌いましょう！
	Talk(Actor010,"CHRNAME_ELAINE","speech","L","EA_009_0530048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★ギネヴィア★★:ええ…う、歌うのぉ？<br>わたし、歌は…
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","EA_009_0530049")

	PlayAction(Actor009,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0013")
-- ▲直接出力

	--★★トリスタン2★★:どこかの芸術センスゼロの元王妃様でも<br>歌えるように簡単なメロディにしておいたから
	Talk(Actor009,"CHRNAME_TRISTAN","speech","L","EA_009_0530050")

-- ▼直接出力
PlayPartVoiceDirect("トリスタン","0010")
-- ▲直接出力

	--★★トリスタン2★★:だから皆安心して<br>自由にのびのびと歌ってくれていいよ
	Talk(Actor009,"CHRNAME_TRISTAN","speech","L","EA_009_0530051")

	play_head_motion(Actor009, "No", 0.3, 1.0, false)
	change_face(Actor009,"Smile")

	--★★トリスタン2★★:
	Talk(Actor009,"CHRNAME_TRISTAN","speech","L","EA_009_0530052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0030")
-- ▲直接出力
	change_face(Actor006,"Shy")

	--★★ギネヴィア★★:で、でもぉ…
	Talk(Actor006,"CHRNAME_GUINEVERE","speech","L","EA_009_0530053")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
show_image("201010080", 0.0, 0.0, 0.8,true,false)
wait_time(1.0)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:一緒に歌えばきっと、<br>皆の心が一つになれると思うんです
	Talk(Actor003,"CHRNAME_DINATAN","simple","N","EA_009_0530054")


	--★★ディナタン★★:皆、一緒だから<br>…ひとりじゃ、ないから
	Talk(Actor003,"CHRNAME_DINATAN","simple","N","EA_009_0530055")

	change_face(Actor005,"Normal")

	--★★ノワール★★:…大丈夫そうか？
	Talk(Actor005,"CHRNAME_NOIR","simple","N","EA_009_0530058")

	change_face(Actor006,"Normal")

	--★★ギネヴィア★★:全然大丈夫じゃないわよ<br>わたし、歌だめなのに～！でも…
	Talk(Actor006,"CHRNAME_GUINEVERE","simple","N","EA_009_0530059")

	change_face(Actor006,"Laugh")

	--★★ギネヴィア★★:
	Talk(Actor006,"CHRNAME_GUINEVERE","simple","N","EA_009_0530060")

	change_face(Actor005,"Sad")

	--★★ノワール★★:
	Talk(Actor005,"CHRNAME_NOIR","simple","N","EA_009_0530061")

	change_face(Actor006,"Smile")

	--★★ギネヴィア★★:
	Talk(Actor006,"CHRNAME_GUINEVERE","simple","N","EA_009_0530062")

-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:では――皆さんにとってこの一年が<br>素敵な一年になりますように
	Talk(Actor003,"CHRNAME_DINATAN","simple","N","EA_009_0530064")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("201010050", "content_still_20101005_image", "201010050_StillImage")
load_image_preload("201010080", "content_still_20101008_image", "201010080_StillImage")
movie_load_preload("EA_009_053")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
preload_sound("BGM_ADV_Dinatan_Stage")
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_2DOnly_Preload("101017","001","101017001")
	InitializeCharacter_3D_Preload("101012","006","101012006","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101030","006","101030006","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101030","006","101030006","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor012")
	InitializeCharacter_2DOnly_Preload("101014","001","101014001")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
