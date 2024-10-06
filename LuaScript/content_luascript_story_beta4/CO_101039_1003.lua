-- このluaスクリプトは、CO_101039_1003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",285,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",330,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",260,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera008 = SetTemplate("Actor008",315,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera009 = SetTemplate("Actor009",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera010 = SetTemplate("Actor010",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera011 = SetTemplate("Actor011",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera012 = SetTemplate("Actor012",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor011,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor011,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor011,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
turn_lookat(Actor006,Actor007,0)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
turn_lookat(Actor007,Actor006,0)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor009, false)
turn_lookat(Actor009,Actor010,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor010, false)
turn_lookat(Actor010,Actor009,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor011, false)
turn_lookat(Actor011,Actor009,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor012, false)
Hide(Actor012)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor012")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:参加者はみんな集まってるみたいだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030002")

-- ▼直接出力
PlayPartVoice("ローラ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:すごい…みんなやる気満々
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_10030003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:賞品のおかげかもな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.8)
wait_time(0.3)
-- ▲直接出力

	--★★ローラ★★:賞品？
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_10030005")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.6)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.6)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:勝ったチームは食堂で好きなものを<br>好きなだけ食べられる権利がもらえるの
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030006")


	--★★フレン★★:チョコレートケーキを１ホールでもいいし<br>ビーフシチューをひと鍋まるごとでもいいし
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030007")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:故郷の料理を作ってもらって<br>お腹いっぱい食べてもいいんだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030008")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:フレンの提案なんだろ？この賞品は
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030009")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ローラ", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:さすがお姉ちゃんだね<br>いいアイデアだと思う！
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_10030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:ルーシャスくんが<br>賞品を好きに決めていいって言ってたから
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030011")


	--★★フレン★★:大会の開催手続きや賞品の用意以外にも<br>ルーシャスくん、いろいろやってくれたんだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030012")


	--★★フレン★★:運営本部や待機スペースのためのテントに<br>参加者用の食べ物や飲み物
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★フレン★★:もしも敵が襲来したときのために<br>護衛の兵士まで準備してくれたんだから
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030014")

-- ▼直接出力
PlayPartVoice("ローラ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:ルーシャス様がそんなことを？
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_10030015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:うん。しかも自分が<br>今回のスポンサーだってことを伏せてね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:おっ<br>話をすればルーシャスだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030017")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
 --ルーシャス登場
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Appear(Actor004)
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
keep_ik_lookat(Actor004,Actor003,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,0.2)
wait_time(CHARA_IN_WAIT)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:ローラ、よくやってくれた<br>これで戦いの準備は万全といえる
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_10030019")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "照れ")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★ローラ★★:め、滅相もないです…
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_10030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ルーシャス★★:戻って来て早々で済まぬが<br>また頼まれてくれるか
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_10030022")

-- ▼直接出力
 --ルーシャスとローラ退場のためカメラを指定
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:は、はいっ！<br>喜んで！
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_10030023")

-- ▼直接出力
 --ルーシャスとローラ退場
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor004)
Hide(Actor003)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:ローラの任務は<br>もう少し続きそうなんだって
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030025")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
wait_time(0.4)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:そうか<br>寂しくないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030026")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:頑張って<br>寂しくないって思うことにしてるんだ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030027")

	change_face(Actor002,"Normal")

	--★★フレン★★:でも、ローラはローマとログレスのために<br>一生懸命働いてる
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030028")


	--★★フレン★★:私もなにかできることを<br>探していたつもりだったんだけど
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030029")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★フレン★★:結局、まだなにもできてない…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_10030032","CO_101039_10030033")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなことはないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030035")

	change_face(Actor001,"Normal")

	--★★ノワール★★:フレンが頑張ったから<br>陸上部の内部分裂を防げたわけだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こうやって競技大会も開催できた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030037")

-- ▼直接出力
PlayPartVoice("フレン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:少しはログレスやローマのみんなのために<br>なってたのかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030038")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:少しどころじゃないさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030039")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:焦る必要はないんじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030041")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:少しずつ探していけばいいと思う<br>キミができること、キミにしかできないことを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030042")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:そうか…そうだよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030043")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、俺は思うんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030045")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:フレンはとても大きな偉業を<br>なし遂げようとしてるって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030046")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:私が？偉業を成し遂げる？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030047")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ほら、あそこ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030048")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
wait_time(0.3)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor001)
Hide(Actor002)
Appear(Actor003)
Appear(Actor004)
Appear(Actor012)
set_pos(Actor004,CharaPosDuelCommonFormation01_002)
turn_lookat(Actor004,Actor011,0)
turn_lookat(Actor009,Actor004,0)
turn_lookat(Actor010,Actor004,0)
turn_lookat(Actor011,Actor004,0)
turn_lookat(Actor012,Actor004,0)
lookat_weight_reset(Actor004)
lookat_weight_reset(Actor003)
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★モブ男★★:ルーシャス様、ありがとうございました！
	Talk(Actor009,"NPCNAME_0151","speech","N","CO_101039_10030050")

	PlayAction(Actor010,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力

	--★★モブ男2★★:こんな素敵な大会を開催してもらえて<br>俺、感激です！
	Talk(Actor010,"NPCNAME_0153","speech","N","CO_101039_10030051")

-- ▼直接出力
PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ルーシャス★★:なんだそなたたちは？<br>余は感謝されることをした覚えなどないぞ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_10030053")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Appear(Actor001)
Appear(Actor002)
Hide(Actor003)
Hide(Actor004)
Hide(Actor012)
set_pos(Actor004,CharaPosDuelCommonFormation01_007)
turn_lookat(Actor004,Actor001,0)
turn_lookat(Actor009,Actor010,0)
turn_lookat(Actor010,Actor009,0)
turn_lookat(Actor011,Actor009,0)
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:フレンはあのルーシャスを<br>学園に馴染ませようとしてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030055")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.3)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:ルーシャスと学園の仲をとりもつことは<br>ローマとログレスの国交の修復につながるはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★フレン★★:そ、そうかなあ<br>そんな意識はなかったから、なんか照れちゃうな
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030057")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★フレン★★:でも、私が頑張れたのは<br>ノワールくんの協力があってこそだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030058")


	--★★フレン★★:助っ人から始まって、競技大会が決まって…<br>たくさん手伝ってくれたよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力

	--★★フレン★★:私ひとりじゃ、きっとできなかったよ<br>本当にありがとう！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030060")

-- ▼直接出力
 --ルーシャス登場
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Appear(Actor004)
set_enable_auto_lookat(Actor004, false)
wait_time(CHARA_IN_WAIT)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.8)
wait_time(0.3)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:おい。フレン、ノワール<br>なにやら生徒たちがもめているようだぞ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_10030062")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030064")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor009)
Hide(Actor010)
Hide(Actor011)
Hide(Actor012)
Appear(Actor005)
Appear(Actor006)
Appear(Actor007)
Appear(Actor008)
Appear(Actor003)
Camera001 = setup_small_camera_resetting(Actor001,CharaPosDuelCommonFormation01_001,CameraPosDuelCommonFormation01_001)
Camera002 = setup_small_camera_resetting(Actor002,CharaPosDuelCommonFormation01_002,CameraPosDuelCommonFormation01_002)
Camera003 = setup_small_camera_resetting(Actor003,CharaPosDuelCommonFormation01_004,CameraPosDuelCommonFormation01_004)
Camera004 = setup_small_camera_resetting(Actor004,CharaPosDuelCommonFormation01_003,CameraPosDuelCommonFormation01_003)
turn_lookat(Actor001,Actor006,0)
turn_lookat(Actor002,Actor006,0)
turn_lookat(Actor003,Actor006,0)
turn_lookat(Actor004,Actor006,0)
keep_ik_lookat(Actor001,Actor005,"J_Head")
keep_ik_lookat(Actor002,Actor005,"J_Head")
keep_ik_lookat(Actor003,Actor005,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
keep_ik_lookat(Actor004,Actor005,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,0.2)
keep_ik_lookat(Actor005,Actor001,"J_Head")
lookat_weight(Actor005,0.4,0.1,0.8,0.2)
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:ノワールにフレン、聞いてくれ<br>このふたりが勝利したときの料理を
	Talk(Actor005,"NPCNAME_0241","speech","N","CO_101039_10030065")


	--★★キャメロット騎士学術院（男）③★★:ログレススペシャルコースにするか<br>ローマグラッツェコースにするかでもめ始めてな
	Talk(Actor005,"NPCNAME_0241","speech","N","CO_101039_10030066")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor007,"J_Head",0.8)
wait_time(0.3)
keep_delay_ik_lookat(Actor004,Actor007,"J_Head",0.8)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor007,"J_Head",0.8)
wait_time(0.2)
keep_delay_ik_lookat(Actor003,Actor007,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("現代男子", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:絶対に<br>ログレススペシャルコースだ！
	Talk(Actor006,"NPCNAME_0265","speech","N","CO_101039_10030067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("男子2", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ローマグラッツェコースのほうが<br>美味いに決まってるだろ！
	Talk(Actor007,"NPCNAME_0266","speech","N","CO_101039_10030068")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:まだどっちのチームが勝つかも<br>決まってないのにか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030069")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ルーシャス★★:こういう場合<br>競技者ならやることはひとつであろう？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","CO_101039_10030071")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10030072")


	--★★フレン★★:おあつらえ向きに<br>次はちょうど個人戦だよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030074")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力

	--★★フレン★★:どっちにするかは<br>公平に競技で決めようーっ！！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10030075")

-- ▼直接出力
local trustParam = set_communication_rankup("フレン_コミュランク", "フレン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor011")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor012")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
