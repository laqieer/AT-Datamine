-- このluaスクリプトは、EA_066_033.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos114011_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_008)
	Camera007 = SetTemplate("Actor007",230,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera008 = SetTemplate("Actor008",130,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
Hide(Actor007)
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Squareoff_Loop")
PlayActionDirect(Actor002,"to Std_Squareoff_Loop")
PlayActionDirect(Actor003,"to Std_Squareoff_Loop")
PlayActionDirect(Actor004,"to Std_Squareoff_Loop")
PlayActionDirect(Actor005,"to Std_Squareoff_Loop")
PlayActionDirect(Actor006,"to Std_Squareoff_Loop")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊","0032")
-- ▲直接出力

	--★★盗賊A★★:く、クソッ…！お前ら、行くぞ！！
	Talk(Actor004,"NPCNAME_0283","speech","N","EA_066_0330001")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor004,"to Run")
turn_chara(Actor004,120,0.4)
PlayActionDirect(Actor005,"to Run")
turn_chara(Actor005,120,0.4)
PlayActionDirect(Actor006,"to Run")
turn_chara(Actor006,120,0.4)
wait_time(0.4)
slidemove(Actor004,{10, 0, -5}, 1.5)
slidemove(Actor005,{10, 0, -5}, 1.5)
slidemove(Actor006,{10, 0, -5}, 1.5)
wait_time(1.5)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(2.2)
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor001,Actor003,0.4)
turn_lookat(Actor002,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0007")
-- ▲直接出力

	--★★ラロゥ★★:この辺の盗賊連中も動き出しそうだね<br>調査するなら早めに行った方がよさそうだよ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0330003")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ラロゥ★★:オレ、港に行って船の手配をしてくるから<br>ふたりも準備を整えておいてよ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0330004")

-- ▼直接出力
CloseTalkWindow()

fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

Hide(Actor001)
Hide(Actor002)
Hide(Actor003)
Appear(Actor007)
Appear(Actor008)
setup_small_camera_start()

wait_time(2.0)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0008")
-- ▲直接出力

	--★★ヴォールス2★★:…らしくないな
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330006")

-- ▼直接出力
PlayPartVoiceDirect("クレア","0028")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★クレア2★★:え？
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330007")

	PlayAction(Actor007,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
-- ▲直接出力

	--★★ヴォールス2★★:聖杯があるかもしれない、など――
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330008")


	--★★ヴォールス2★★:お前にしてはずいぶんぼんやりとした<br>希望的観測だ
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330009")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0038")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★クレア2★★:そうかもしれないわね<br>でも、伝説ってそういうものでしょ
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330010")

	change_face(Actor008,"Normal")

	--★★クレア2★★:それに縋ることで安らぐ気持ちがあることを<br>否定はしないわ
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ヴォールス2★★:………
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330012")

	PlayAction(Actor008,"to  Std_Talk")

	--★★クレア2★★:わたし、まだ見ぬ謎があるかもと想像して<br>ワクワク胸を躍らせるのも好きよ
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330013")


	--★★クレア2★★:あなたもそうでしょ
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0010")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★クレア2★★:伝説級の武具について調べているときの<br>あなたの目、キラキラしてた
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330015")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0010")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ヴォールス2★★:そんなふうに見られていたとは<br>…恥ずかしいな
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330016")

	change_face(Actor007,"Normal")

	--★★ヴォールス2★★:役目を降り、立場を離れた冒険が<br>これほど胸躍るものだとは思わなかった
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330017")

	PlayAction(Actor007,"to  Std_Talk")

	--★★ヴォールス2★★:自由を与えられたところで、どこへいって<br>なにをすべきかもわからないと思っていたのに
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330018")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0038")
-- ▲直接出力
	change_face(Actor008,"Normal")

	--★★クレア2★★:むしろ、やることが目白押し
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330019")

	PlayAction(Actor007,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス2★★:武具探しはしばしお預けにはなるがな<br>だが、不謹慎かもしれないが…
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330020")


	--★★ヴォールス2★★:『聖杯』を探ることにも<br>少し興味を引かれているんだ
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330021")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0011")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★ヴォールス2★★:育ちが悪いのかもしれん<br>なにせ、元海賊だからな
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330022")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Smile")

	--★★クレア2★★:いいと思うわ<br>わたしも『聖杯』の謎は解きたいし
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★クレア2★★:楽しいことをすることをするのが一番よね
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330024")

	PlayAction(Actor008,"to  Std_Talk")

	--★★クレア2★★:あなたのその顔<br>アーサー様に見せてあげたいわ
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330025")

	change_face(Actor007,"Normal")

	--★★ヴォールス2★★:…？どんな顔だ？
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330026")

-- ▼直接出力
PlayPartVoiceDirect("クレア","0011")
-- ▲直接出力

	--★★クレア2★★:青春してる顔
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★ヴォールス2★★:…！
	Talk(Actor007,"CHRNAME_BORS","speech","L","EA_066_0330028")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力

	--★★クレア2★★:さ、行きましょう<br>楽しい楽しい、宝探しに
	Talk(Actor008,"CHRNAME_CLARE","speech","L","EA_066_0330029")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
