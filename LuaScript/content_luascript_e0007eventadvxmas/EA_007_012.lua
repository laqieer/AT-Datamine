-- このluaスクリプトは、EA_007_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_005)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
-- ▼直接出力
Hide(Actor005)
set_pos(Actor005,{11.2, -0.003, -1.65})
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor001,Actor006,0.4)
turn_lookat(Actor006,Actor001,0.4)
turn_lookat(Actor004,Actor001,0.4)
turn_lookat(Actor002,Actor001,0.4)
turn_lookat(Actor003,Actor001,0.4)
-- ▲直接出力
-- ▼直接出力
Camera_EX = set_camera({6.03, 1.69, -6.85, 12.98011, 97.44626, 359.8201, 21.50124})
-- ▲直接出力
-- ▼直接出力
Camera_EX2 = set_camera({8.18, 2.19, -7.13,   18.5326, 37.9258, 0,   21.40307})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★クラリス★★:プレゼント<br>決まりましたか？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120003")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0034")
-- ▲直接出力

	--★★カイル★★:うう～ん、まあボクがいるだけで<br>ママもパパも幸せなんだろうけどさっ
	Talk(Actor006,"CHRNAME_NAMELES","speech","L","EA_007_0120005")

	PlayAction(Actor001,"to  Std_Appl")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★クラリス★★:あらあら、カイルくんは<br>自己肯定感が高くてよろしいですね～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120006")

-- ▼直接出力
--カイル,NPCNAME_0386 @名前変更
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0048")
-- ▲直接出力

	--★★カイル★★:でしょでしょ<br>なでて！なでて！
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120007")

-- ▼直接出力
wait_time(0.3)
setup_small_camera_end(Camera007)
setup_small_camera_start(Camera_EX)
wait_time(0.4)
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{8.16, -0.003, -7.107},0.6)
PlayActionDirect(Actor001,"to  Std_Talk")
SkipDefaultMotion(Actor001)
wait_time(0.4)
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120008")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★カイル★★:
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120009")

-- ▼直接出力
wait_time(0.4)
setup_small_camera_end(Camera_EX)
setup_small_camera_start(Camera002)
set_pos(Actor001,CharaPos006)
turn_lookat(Actor001,Actor006,0.4)
change_face(Actor001,"Normal")
stop_head_motion(Actor001)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.0)
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ラグネル★★:ね！！！！
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120013")

-- ▼直接出力
wait_time(0.4)
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120014")

-- ▼直接出力
setup_small_camera_end(Camera003)
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	open_select_window_tag(Actor004,"Normal","EA_007_0120016","EA_007_0120017","EA_007_0120018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor004,"Surprise")

	--★★ノワール★★:ま、まだわからないだろ<br>クラリスの隠し子かどうかなんて
	Talk(Actor004,"CHRNAME_NOIR","mind_talk","L","EA_007_0120021")

	change_face(Actor002,"Normal")

	--★★ラグネル★★:そういう想定で動いたほうがいいよ
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120022")

	change_face(Actor004,"Sad")

	--★★ノワール★★:動くってなんだ
	Talk(Actor004,"CHRNAME_NOIR","mind_talk","L","EA_007_0120023")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:こっちの受け入れ態勢を<br>整えておくべきってことじゃねーか…？
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor004,"Surprise")

	--★★ノワール★★:お相手は…誰なんだ、いったい………
	Talk(Actor004,"CHRNAME_NOIR","mind_talk","L","EA_007_0120027")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:なにドレッドなんだ…？
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120028")

	change_face(Actor002,"Surprise")

	--★★ラグネル★★:ちょっと待って、仮定だけで<br>そこまで妄想しちゃうのは失礼だよ
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120029")

	change_face(Actor004,"Sad")

	--★★ノワール★★:ラグネルが言うか…？
	Talk(Actor004,"CHRNAME_NOIR","mind_talk","L","EA_007_0120030")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor004,"Normal")

	--★★ノワール★★:人の家庭事情には<br>首を突っ込まないほうがいい
	Talk(Actor004,"CHRNAME_NOIR","mind_talk","L","EA_007_0120033")

	change_face(Actor003,"Smile")

	--★★ガウェイン★★:おやおや、ノワールくんも<br>ここまで突っ込んで来てるのではぁ？
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120034")

	change_face(Actor002,"Laugh")

	--★★ラグネル★★:コトバとコウドウが一致していないよ<br>説得力がないねえ、ノワールくんはぁ
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120035")

	change_face(Actor004,"Sad")

	--★★ノワール★★:グッ
	Talk(Actor004,"CHRNAME_NOIR","mind_talk","L","EA_007_0120036")

	goto Block1end

::Block1end::
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0002")
-- ▲直接出力

	--★★カイル★★:クラリスお姉ちゃんだったら<br>なにをプレゼントする？
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120038")

-- ▼直接出力
setup_small_camera_end(RndCamera002)
change_face(Actor004,"Normal")
change_face(Actor003,"Normal")
change_face(Actor002,"Normal")
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Surprise")

	--★★クラリス★★:え──…？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120039")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start(RndCamera004)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラグネル★★:…風向き変わって来た？<br>クラリスちゃんのことを<dot>お姉ちゃん</dot>って呼んでる
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120040")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120042")

	change_face(Actor004,"Sad")

	--★★ノワール★★:隠し弟って言葉、存在するか？
	Talk(Actor004,"CHRNAME_NOIR","mind_talk","L","EA_007_0120043")

-- ▼直接出力
setup_small_camera_end(RndCamera004)
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0034")
-- ▲直接出力

	--★★カイル★★:サプライズにしたいんだけどさ<br>なにあげたって驚いてくれなさそうなんだ
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120044")


	--★★カイル★★:ママもパパも<br>商品という商品は見飽きてるだろうからさぁ
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120045")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0011")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★クラリス★★:なんでも嬉しいはずですよ<br>カイルくんからのプレゼントなら
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120046")


	--★★カイル★★:けどさ、けどさあ！
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120047")

	change_face(Actor001,"Normal")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120048")

	PlayAction(Actor006,"to  Std_Joy")

	--★★カイル★★:ハートに火をつけたいんだよ！！
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120049")

-- ▼直接出力
setup_small_camera_end(RndCamera002)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★クラリス★★:な、なるほど～？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120050")

	PlayAction(Actor006,"to  Std_Talk")

	--★★カイル★★:
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120051")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:…そ、うですね～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120053")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ノワール★★:………？
	Talk(Actor004,"CHRNAME_NOIR","mind","L","EA_007_0120054")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera001)
setup_small_camera_start(RndCamera090)
wait_time(0.4)
character_in_move_walk(Actor005,CharaPos007,3,0.25)
setup_small_camera_start(Camera005)
PlayActionDirect(Actor005,"to Wlk")
turn_lookat(Actor005,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
set_common_look_at(Actor001,Actor005)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0002")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★モルドレッド★★:ままごとやってんのか、まだ
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120057")

-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor005,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.4)
setup_small_camera_end(Camera005)
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ラグネル★★:あっ！<br>ねえ、モルドレッドが来たよ！
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120058")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor005,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0017")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★クラリス★★:モルくん、コラッですよ<br>そういう言いかたは
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120059")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120060")


	--★★モルドレッド★★:
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120061")

-- ▼直接出力
setup_small_camera_end(RndCamera090)
setup_small_camera_start(Camera006)
wait_time(0.4)
PlayActionDirect(Actor006,"to Wlk")
turn_chara(Actor006,180,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad02")

	--★★カイル★★:………このお兄ちゃん、嫌い
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120063")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ラグネル★★:こ、子供は素直だね…
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120064")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0015")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120065")

-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★クラリス★★:これから降誕祭の準備もありますし<br>戦いの際にはログレスに留まることになりますし
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120066")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0014")
-- ▲直接出力

	--★★モルドレッド★★:おめえの仕事じゃねえだろ
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120067")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0041")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120068")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★モルドレッド★★:祈ったってダメだね
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120069")

-- ▼直接出力
setup_small_camera_end(RndCamera007)
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120070")

-- ▼直接出力
CloseTalkWindow()
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:一進一退の攻防<br>両者譲らずといったところでしょうか
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120072")

-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor001,"to  Std_No")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120074")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(RndCamera002)
setup_small_camera_start(RndCamera004)
wait_time(0.8)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor004,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor004,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120075")

-- ▼直接出力
CloseTalkWindow()
turn_lookat(Actor007,Actor005,0.4)
Appear(Actor007)
wait_time(1.5)
setup_small_camera_end(RndCamera004)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_No")

	--★★ノワール2★★:待てよ
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_007_0120078")

-- ▼直接出力
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor007,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor007,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.6)
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120079")

-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
turn_lookat(Actor005,Actor007,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★モルドレッド★★:ア？<br>んだよてめえは
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120080")

-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor007,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ラグネル★★:ガウェイン、どうしよう！<br>険悪な雰囲気だよ！
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120081")

	PlayAction(Actor003,"to  Std_Angry")

	--★★ガウェイン★★:よっしゃ加勢するか！
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120082")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Surprise")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120083")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0002")
-- ▲直接出力

	--★★ノワール2★★:クラリスの話を<br>聞いてあげてもいいんじゃないのか？
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_007_0120084")

-- ▼直接出力
setup_small_camera_end(RndCamera090)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0015")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★モルドレッド★★:他人はすっこんでな
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120085")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0009")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120086")

-- ▼直接出力
wait_time(1.4)
PlayActionDirect(Actor005,"to Wlk")
turn_lookat(Actor005,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0002")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★モルドレッド★★:…クラリス<br>おめえ、もしかして──
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120087")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★クラリス★★:はい…
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120088")

	change_face(Actor005,"Serious")

	--★★モルドレッド★★:──<dot>視えた</dot>のか
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120089")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0033")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:………わかりません
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120091")

	change_face(Actor007,"Surprise")

	--★★ノワール2★★:『視えた』…？
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_007_0120092")

-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0019")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★モルドレッド★★:
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120093")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★クラリス★★:ありがとう、モルくん
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120095")

-- ▼直接出力
setup_small_camera_end(RndCamera007)
setup_small_camera_start(Camera005)
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Surprise")

	--★★モルドレッド★★:チッ
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120096")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120097")

	change_face(Actor002,"Laugh")

	--★★ラグネル★★:みたいだね。あのふたりなりの<br>コミュニケーションがあるっていうか
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120098")

-- ▼直接出力
setup_small_camera_end(Camera005)
setup_small_camera_start(RndCamera090)
wait_time(1.4)
PlayActionDirect(Actor005,"to Wlk")
turn_lookat(Actor005,Actor006,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0002")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★モルドレッド★★:オイ、ガキ
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120099")

-- ▼直接出力
wait_time(0.4)
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor005,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Surp")

	--★★カイル★★:な、なに
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120100")

	change_face(Actor005,"Anger")

	--★★モルドレッド★★:コイツにケガさせたら<br>その髪全部はがしてやるからな
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120101")

	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0030")
-- ▲直接出力

	--★★カイル★★:え、えええ～…？
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120102")

	PlayAction(Actor007,"to  Std_No")
	change_face(Actor007,"Anger")

	--★★ノワール2★★:
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_007_0120103")

	PlayAction(Actor005,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("モルドレッド","0013")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★モルドレッド★★:
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","EA_007_0120104")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
setup_small_camera_end(RndCamera090)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor005)
turn_lookat(Actor007,Actor001,0.4)
turn_lookat(Actor001,Actor007,0.4)
wait_time(2.2)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ノワール2★★:…クラリス、さっきの<br>「視えた」ってどういう──
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_007_0120106")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0037")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120108")

-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
turn_lookat(Actor006,Actor001,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★クラリス★★:そのお話は後日
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120109")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	change_face(Actor007,"Surprise")

	--★★ノワール2★★:え………？ああ…
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_007_0120111")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.8)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor006,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0048")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★クラリス★★:カイルくん、怖がらせてしまいましたね～<br>ごめんなさい～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120112")

	PlayAction(Actor006,"to  Std_Talk")

	--★★カイル★★:へ、平気だよ
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120113")

	change_face(Actor001,"Laugh")

	--★★クラリス★★:お話の続きでしたね<br>「プレゼントをどうするか」──
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120114")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120116")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★カイル★★:うん、クラリスお姉ちゃんならさあ<br>ボクより年上だろ、経験豊富だろ？
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120117")

-- ▼直接出力
setup_small_camera_end(RndCamera090)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0015")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★クラリス★★:…わたし、実を言うとですね？
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120118")


	--★★カイル★★:
	Talk(Actor006,"NPCNAME_0386","speech","L","EA_007_0120119")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★クラリス★★:したことないんです<br>プレゼント
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120120")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Surp")

	--★★ノワール2★★:えっ
	Talk(Actor007,"CHRNAME_NOIR","speech","L","EA_007_0120123")

-- ▼直接出力
wait_time(0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor007,0.6)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0045")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★クラリス★★:だから、お救いください～<br>ノワールくん～
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120125")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:巻き込まれた！
	Talk(Actor003,"CHRNAME_GAWAIN","mind_talk","L","EA_007_0120127")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラグネル★★:よく巻き込まれるよねえ<br>ノワールって
	Talk(Actor002,"CHRNAME_RAGNAR","mind_talk","L","EA_007_0120128")

-- ▼直接出力
wait_time(0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002,0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0042")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★クラリス★★:そこのお二人もご一緒に
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120129")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Surp")
PlayActionDirect(Actor002,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★ガウェイン／ラグネル★★:
	Talk(Actor008,"CHRNAME_GAWAIN_RAGNAR","speech","L","EA_007_0120130")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★クラリス★★:わたしも常々<br>知りたいと思っていました
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120131")

-- ▼直接出力
wait_time(1.0)
setup_small_camera_end(RndCamera007)
wait_time(1.4)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★クラリス★★:
	Talk(Actor001,"CHRNAME_CLARICE","speech","L","EA_007_0120132")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
