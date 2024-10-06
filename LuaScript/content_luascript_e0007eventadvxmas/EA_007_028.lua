-- このluaスクリプトは、EA_007_028.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_003)
	Camera002 = SetTemplate("Actor002",170,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera003 = SetTemplate("Actor003",-25,CharaPos110091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_004)
	Camera005 = SetTemplate("Actor005",-120,CharaPos110091_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_008)
	Camera006 = SetTemplate("Actor006",140,CharaPos110091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_002)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
-- ▼直接出力
keep_ik_lookat(Actor002,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005,Actor003,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
wait_time(0.9)
play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★クラリス★★:参考になりました～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280003")

-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
turn_lookat( Actor006,Actor001, 0.3)
wait_time(0.3)
PlayActionDirect(Actor006,"to Std_Loop")
PlayPartVoiceDirect("子供_男1","0019")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★カイル★★:ホントに？クラリスお姉ちゃんホントに？
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280004")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Talk")
turn_lookat( Actor001,Actor002, 0.3)
voice_play("VO_101023_sp_0001_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280005")

	open_select_window_tag(Actor002,"Normal","EA_007_0280007","EA_007_0280008","EA_007_0280009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0014")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:そ、そういえば、インタビュアーだったら<br>サプライズになにを贈るんだ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280012")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0033")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280013")

-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_lookat( Actor003,Actor002, 0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to Finger")
PlayPartVoiceDirect("ラグネル","0008")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:そうだね…魚のぬいぐるみの中に<br>メッセージカード！っていうのはどうかな！？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_007_0280014")

	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Sad")

	--★★リアム★★:（………魚をさばくと<br>カードが出て来る…とかでしょうか）
	Talk(Actor004,"CHRNAME_LIAM","mind","L","EA_007_0280015")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ガウェイン★★:俺だったら、１回プレゼント忘れたフリして<br>あとで渡すとか…するかなあ！
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_007_0280016")

-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
turn_lookat( Actor003,Actor005, 0.3)
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
play_head_motion(Actor003, "No", 0.3, 1.0, false)
PlayPartVoiceDirect("ラグネル","0019")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:あのさ、あたしソレやられたら<br>結構落ち込むからね、あとで渡されたとしても
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_007_0280017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
turn_lookat( Actor006,Actor002, 0)
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:…相手によるかなあ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
turn_lookat( Actor003,Actor006, 0)
turn_lookat( Actor002,Actor006, 0)
turn_lookat( Actor005,Actor006, 0)
PlayPartVoiceDirect("クラリス","0038")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★クラリス★★:まあサプライズが嫌いな御方も<br>いらっしゃいますしね～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280021")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★ガウェイン★★:カイルのご両親はどうなんだ？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_007_0280022")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0039")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★カイル★★:サプライズは喜んでくれると思うんだ<br>なにせ、このボクが仕掛けるわけだし
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280023")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0038")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:確かに子供からサプライズされて<br>喜ばない親はいないよね！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_007_0280024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
turn_lookat( Actor006,Actor001, 0)
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:だとしたらなんでも<br>喜んでくれるような気がするけどなあ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280025")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
PlayActionDirect(Actor002,"to Wlk")
turn_lookat( Actor002,Actor006, 0.3)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
turn_lookat( Actor006,Actor002, 0)
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:ぱ、パーティ三昧とか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280028")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0013")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:ノワール<br>意外とパリピだね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_007_0280029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0048")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:い、いや、どこかお店を貸し切ってさ<br>飾り付けとかして…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280030")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ガウェイン★★:おお、それは悪くないかもな
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_007_0280031")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0017")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★カイル★★:そ、そんなにお金ないよ…<br>普通の同世代よりはお小遣い多いけど
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280032")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
turn_lookat( Actor006,Actor001, 0)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:う～ん…<br>なにか良い案ないかな～
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_007_0280033")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
manager.CloseupUpExclusiveCamera(Actor006)
turn_lookat( Actor002,Actor006, 0)
turn_lookat( Actor003,Actor006, 0)
turn_lookat( Actor005,Actor006, 0)
keep_delay_ik_lookat(Actor006,Actor001,"J_Head",0.6)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0034")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★カイル★★:…クラリスお姉ちゃんは<br>やっぱりさ、なんかないの？
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280035")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_lookat( Actor001,Actor006, 0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to  Std_No")
PlayPartVoiceDirect("クラリス","0040")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★クラリス★★:わたしはいいですから～<br>みんなで考えましょうよ～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280036")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0042")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★カイル★★:クラリスお姉ちゃんの案がイイ！
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280037")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:…カイル？どうしてそこまで？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280038")

-- ▼直接出力
turn_lookat( Actor006,Actor002, 0.3)
PlayActionDirect(Actor006,"to  Std_Sad02")
PlayPartVoiceDirect("子供_男1","0021")
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★カイル★★:………だって<br>いっしょに迷ってくれたんだもん
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280039")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ガウェイン★★:迷って？
	Talk(Actor005,"CHRNAME_GAWAIN","speech","L","EA_007_0280040")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0007")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★カイル★★:ボクがログレスに来て、迷子になったとき<br>クラリスお姉ちゃんに会ってさ
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280041")

-- ▼直接出力
SkipDefaultMotion(Actor001)
lookat_delay_weight_reset(Actor001 , 0.6)
turn_chara(Actor001,185,0.8)
PlayActionDirect(Actor001,"to  Std_Sad01")
PlayPartVoiceDirect("クラリス","0048")
-- ▲直接出力
	change_face(Actor001,"Shy")

	--★★クラリス★★:ああ、お恥ずかしい～見栄を張って<br>道案内を買って出たんですが～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280042")


	--★★カイル★★:いっしょに迷子になっちゃって
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("ラグネル","0046")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_007_0280044")


	--★★カイル★★:
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280045")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0010")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★カイル★★:
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★クラリス★★:………カイルくん
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280047")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0008")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★カイル★★:ボクあんま、同世代と遊んだりしなくて<br>なんかみんなガキだからさ
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280048")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ラグネル★★:カイルくん、ませてるねえ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_007_0280049")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:カイルくん、でもわたし…<br>よくわからないんです～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280050")


	--★★クラリス★★:「もし自分が誰かに贈り物をする」と考えても<br>あの………なんというか～ですね
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280051")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 turn_lookat( Actor006,Actor001, 0.3)
PlayActionDirect(Actor006,"to  Std_Talk")
PlayPartVoiceDirect("子供_男1","0015")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★カイル★★:なんというか、なに？！
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0280052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0020")
-- ▲直接出力

	--★★クラリス★★:ええと…いえ、あのぉ、それよりも<br>み、みんなで仲良く考えたほうがいいような～…
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280053")

-- ▼直接出力
voice_play("VO_101009_sp_0015_1")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:クラリス
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280054")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_lookat( Actor001,Actor002, 0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★クラリス★★:はい？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280055")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:迷う時間は、要るよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280056")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0037")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:………決められませんよお
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280057")

	change_face(Actor001,"Normal")

	--★★クラリス★★:わたしの選択がカイルくんの幸せになるか<br>わからないんです…どうしても
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280058")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0024")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","EA_007_0280059")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:………<br>どうして…でしょうね
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280061")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0015_1")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:…じゃあ、クラリス
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力

	--★★クラリス★★:はい…
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280065")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ノワール★★:あえて迷子になってみるか
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280066")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★クラリス★★:ど、どういうことです～？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0280067")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:いい知り合いがいるんだ<br>世界中を旅した商人が
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_007_0280068")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
