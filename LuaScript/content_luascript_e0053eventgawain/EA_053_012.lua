-- このluaスクリプトは、EA_053_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_003)
	Camera002 = SetTemplate("Actor002",20,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_002)
	Camera004 = SetTemplate("Actor005",nil,CharaPos112021_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_008)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
-- ▼直接出力
Hide(Actor003)
set_pos(Actor003,{2,0,7.93})
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
set_pos(Actor005,{4.2,0,3.11})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	Actor005 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor005")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力

	--★★ノワール★★:マーケットも賑わってるなぁ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101062_sp_0001_1")
-- ▲直接出力

	--★★マルイル★★:おっ、ノワールさん！買い物ですか？<br>ならぜひマルイル商店へ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_053_0120004")


	--★★マルイル★★:五月祭に向けて色んな品を仕入れてきたので<br>覗くだけでもいかがですか？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_053_0120005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0047")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:どれどれ…おお～<br>確かに、いつにも増してすごい品ぞろえだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120006")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん？この空いてるスペースはなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120007")


	--★★マルイル★★:ああ、それはですね――
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_053_0120008")


	--★★？？？★★:どいたどいたー！！
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","EA_053_0120010")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(RndCamera002)
setup_small_camera_start()
local startpos = {2,0,7.93}
local gopos = {2.293,0,-1.181}
--到着までの時間を計算------------------
local disx = gopos[1] - startpos[1]
local disz = gopos[3] - startpos[3]
disx = math.abs(disx)
disz = math.abs(disz)
local dis = disx^2 + disz^2
local distance = math.sqrt(dis)
local SPEED = 5
local MOVETIME = distance / SPEED
local WAIT_TIME1 = 1.6
local WAIT_TIME2 = MOVETIME - WAIT_TIME1
----------------------------------------
Appear(Actor003)
turn_lookat_position(Actor003, gopos, 0)
PlayActionDirect(Actor003,"to Run")
slidemove(Actor003, gopos, MOVETIME)
wait_time(WAIT_TIME1)
setup_small_camera_end()
setup_small_camera_start(RndCamera007)
wait_time(WAIT_TIME2)
PlayActionDirect(Actor003,"to Std_Loop")
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
lookat_delay_weight(Actor001, {0.5, 0.1, 0.8, 0.2} , 1)
turn_chara(Actor001,-120,0.1)
PlayActionDirect(Actor001,"to  Std_Surp")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
-- ▲直接出力

	--★★ノワール★★:ガウェイン！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120013")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
lookat_delay_weight(Actor003, {0.5, 0.1, 0.8, 0.2} , 1)
PlayPartVoiceDirect("ガウェイン","0004")
-- ▲直接出力

	--★★ガウェイン★★:よお、ノワール<br>こんなところでなにやってんだ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120014")

-- ▼直接出力
setup_small_camera_end(RndCamera007)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにって…マーケットを見て回ってたんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120015")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:祭りとかあまり経験がないから<br>見てるだけでも楽しくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120016")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0045")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:なんだ、そっか！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガウェインこそなにやってるんだ？<br>そんなに急いで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120018")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:俺か？<br>もちろんヒーロー活動だよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120019")

	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:ってことで…ほらよ、マルイル<br>頼まれてたヤツ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120020")

-- ▼直接出力
PlayPartVoiceDirect("マルイル","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:おおお、ありがとうございます！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_053_0120021")

-- ▼直接出力
PlayPartVoiceDirect("マルイル","0048")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ぼくとしたことが店に出す品を切らしてしまって<br>どうしようかと思ってたんですよ～
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_053_0120022")


	--★★マルイル★★:かといって五月祭のこの盛り上がりの中で<br>店を閉めるわけにいきませんし
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_053_0120023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルイル★★:ガウェインさんが仕入れを手伝ってくれて<br>本当に助かりました！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_053_0120024")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力

	--★★ノワール★★:そうだったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120025")

	open_select_window_tag(Actor001,"Normal","EA_053_0120027","EA_053_0120028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101009_sp_0005_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガウェインって、暇なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120031")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0015")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガウェイン★★:ド直球に失礼だな！<br>ちっげーっての！超忙しいっての！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120032")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:けど忙しさを言い訳にできねーだろ！<br>ヒーローたるもの！！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120033")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:優しいんだな、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120036")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:別にそんなんじゃねーよ<br>ただヒーローとして当然のことをしてるだけだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120037")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0010")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:困っている人を助けるのは<br>ヒーローの務めだからな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120038")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0037")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:お手間をおかけしまして本当にすみません<br>ここ最近、とにかく忙しそうなのに…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_053_0120040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120041")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0052")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:まーな。五月祭に向けて<br>頼まれごととか相談が多くてよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("マルイル","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:街の皆さんにおけるヒーローの需要も<br>高まっている、ということですね！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","EA_053_0120043")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0034")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:ヒーローの需要…そうなのかなぁ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120044")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101009_sp_0005_1")
-- ▲直接出力

	--★★ノワール★★:？どうかしたか、ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120045")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0050")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:…いや、なんでもねえ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120046")

	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:街の皆が困ってるときに<br>駆けつけるのがヒーローの役目だし
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120047")


	--★★ガウェイン★★:それに…五月祭の成功はアーサー様の望みだ<br>頑張らねーとな！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0005_3")
-- ▲直接出力

	--★★ノワール★★:ガウェイン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120049")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
local gopos = {3.322, 0, 0.785}
CloseTalkWindow()
setup_small_camera_start(RndCamera090)
Appear(Actor005)
turn_lookat_position(Actor005, gopos, 0)
PlayActionDirect(Actor005,"to Run")
slidemove(Actor005, gopos, 1)
wait_time(0.8)
setup_small_camera_end(RndCamera090)
setup_small_camera_start(Camera004)
wait_time(0.2)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力

	--★★ログレス兵士★★:ガウェイン、ここにいたのか<br>さがしたぞ
	Talk(Actor005,"NPCNAME_0124","speech","N","EA_053_0120051")

-- ▼直接出力
CloseTalkWindow()
local TURN_TIME = 0.4
local WAIT_TIME = 0.1
local SPACE_TIME = 0.3
setup_small_camera_end(Camera004)
setup_small_camera_start()
lookat_delay_weight_reset(Actor003,1.0)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor005,TURN_TIME)
wait_time(WAIT_TIME)
lookat_delay_weight_reset(Actor001,1.0)
set_enable_auto_lookat(Actor001,false)
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
lookat_delay_weight(Actor001, {0.5,0.1,0.8,0.2} , 1)
PlayActionDirect(Actor001,"to Wlk")
--turn_lookat(Actor001,Actor005,TURN_TIME)
turn_chara(Actor001,-20,TURN_TIME)
wait_time(SPACE_TIME)
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(WAIT_TIME)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:？なにかあったのか？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("兵士3","0038")
-- ▲直接出力

	--★★ログレス兵士★★:近くにバルバロイが出現した<br>それも結構な数みたいだ
	Talk(Actor005,"NPCNAME_0124","speech","N","EA_053_0120053")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Surp")
PlayPartVoiceDirect("ガウェイン_004","0029")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:なんだって！？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120055")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("ガウェイン_004","0043")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガウェイン★★:街に近づけるわけにはいかねえ…<br>すぐに行かねーと！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120056")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:俺も行くよ<br>戦力は多い方がいいだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_053_0120057")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
PlayPartVoiceDirect("ガウェイン","0008")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:…！サンキュー、ノワール<br>よし――行こうぜ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","EA_053_0120058")

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
preload_sound("BGM_ADV_Antagonism")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor005")
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
