-- このluaスクリプトは、CO_101022_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_017_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
set_enable_auto_lookat(Actor001, false)
set_common_look_at(Actor001,Actor005)
-- ▲直接出力
-- ▼直接出力
Ef_Portal_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
set_pos(Ef_Portal_Enemy,{-3.34, 0, -2.857})
set_rot(Ef_Portal_Enemy,{0,62,0})
Ef_Portal_Enemy_1 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
set_pos(Ef_Portal_Enemy_1,{-3.71, 0, -0.667})
set_rot(Ef_Portal_Enemy_1,{0,99,0})
Ef_Portal_Enemy_2 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
set_pos(Ef_Portal_Enemy_2,{-3.5, 0, 1.04})
set_rot(Ef_Portal_Enemy_2,{0,128,0})
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor002,Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_common_look_at(Actor003,Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-3.34, 0, -2.84})
set_rot(Actor006,{0,62,0})
Hide(Actor006)
move1 = {-3.04, 0, -2.84}
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{-3.71, 0, -0.66832})
set_rot(Actor007,{0,102.3498,0})
Hide(Actor007)
move2 = {-3.41, 0, -0.66832}
-- ▲直接出力
-- ▼直接出力
set_pos(Actor008,{-3.973, 0, 1.239,   124.8})
set_rot(Actor008,{0,124.8,0})
Hide(Actor008)
move3 = {-3.287, 0, 1.102}
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401030","001","401030001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("王様", "肯定")
-- ▲直接出力

	--★★汎用王様★★:これはこれは、モルドレッド様
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020002")


	--★★汎用王様★★:このような場所まで<br>ご足労いただき誠に感謝いたします
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020003")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("貴族_男2", "驚き")
-- ▲直接出力

	--★★貴族（男）②★★:ほ、本当に来た…！
	Talk(Actor004,"NPCNAME_0282","speech","N","CO_101022_10020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("王様", "笑い")
-- ▲直接出力

	--★★汎用王様★★:我々をおさがしと耳にしたもので<br>急ぎ招待状を送らせていただきましたが
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020005")


	--★★汎用王様★★:きちんと届いたようで<br>なによりです
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "否定")
-- ▲直接出力

	--★★モルドレッド★★:能書きはいい<br>オレは確認に来ただけだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10020007")


	--★★モルドレッド★★:学園内でアーサー王への<br>反感を煽るウワサを流させたのはてめえだな？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10020008")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "肯定")
-- ▲直接出力

	--★★汎用王様★★:いかにも
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020009")

-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:いったいなにが目的だ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("王様", "肯定3")
-- ▲直接出力

	--★★汎用王様★★:円卓の騎士ノワールか…<br>ふん、傭兵上がりが口を挟むな
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020011")


	--★★汎用王様★★:愚かなるアーサーが国と民に牙をむき<br>ログレスの王座は空席の状態
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020012")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("王様", "笑い")
-- ▲直接出力

	--★★汎用王様★★:ならば今度こそ真に相応しい方を<br>そこへ据えよう…そう考えただけのこと
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020013")

	open_select_window_tag(Actor001,"Normal","CO_101022_10020015","CO_101022_10020016")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ノワール", "激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:嘘をつけ<br>モルドレッドを飾りにしようとしているんだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10020018")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★汎用王様★★:真の王を飾りにですと？<br>なにか誤解をされているご様子
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020020")

	change_face(Actor005,"Normal")

	--★★汎用王様★★:本来いるべき場所へ<br>お戻りいただくだけですよ
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020021")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:ふん、どうだかな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10020022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはただの手段であって目的じゃない<br>真の目的を話せ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10020024")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("王様", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★汎用王様★★:ほう…？<br>少なくともその目は節穴ではないようだ
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020025")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:当たり前だろ<br>オレが使えねえヤツを連れて行動するもんかよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10020026")

	goto Block1end

::Block1end::
-- ▼直接出力
 --ランダムカメラ制御のためカメラを指定
CloseTalkWindow()
setup_small_camera_start(Camera005)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★汎用王様★★:アーサーを選んだ過去の王家は愚かだった
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020028")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "肯定3")
-- ▲直接出力

	--★★汎用王様★★:今こそ、真の王が<br>誰であるかを知らしめるときです
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020029")


	--★★汎用王様★★:煮え湯を飲まされ溜め込んだ<br>貴方様の恨みつらみ…
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020030")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("王様", "喜び")
-- ▲直接出力

	--★★汎用王様★★:我らとともに<br>愚者どもへ思い知らせてやりましょう――
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020031")

-- ▼直接出力
 --クラリスを映すカメラを指定
CloseTalkWindow()
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor004, true)
set_enable_auto_lookat(Actor005, true)
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★クラリス★★:もういい加減にして！！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10020033")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor004, false)
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
	PlayAction(Actor009,"to  Std_Surp")

	--★★一同★★:！？
	Talk(Actor009,"NPCNAME_0126","speech","N","CO_101022_10020034")

-- ▼直接出力
PlayPartVoice("クラリス", "怒り")
-- ▲直接出力

	--★★クラリス★★:みんな、みんな<br>自分勝手なことばっかり言って…！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10020036")


	--★★クラリス★★:モルくんがどんな思いで<br>ここまで生きてきたかも知らないくせに…！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10020037")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ク、クラリス…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10020038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("クラリス", "悲しみ")
-- ▲直接出力

	--★★クラリス★★:勝手に期待して<br>勝手に裏切って
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10020039")


	--★★クラリス★★:モルくんの気持ちも知らないで<br>勝手なことする人は大っ嫌いです！！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10020041")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("王様", "怒り")
-- ▲直接出力

	--★★汎用王様★★:キラーズごときが<br>でしゃばった真似をするな！
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "激怒")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★モルドレッド★★:おいおい、待てよ<br>誰のキラーズに向かって口きいてんだ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10020044")


	--★★モルドレッド★★:俺のキラーズを侮辱するやつは
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10020045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★モルドレッド★★:――100回死んでも許さねえぜ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10020047")

-- ▼直接出力
 --バルバロイ登場のため、カメラを指定
CloseTalkWindow()
setup_small_camera_start(Camera005)
set_enable_auto_lookat(Actor004, false)
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")

	--★★汎用王様★★:！！ええい！
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020048")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
wait_time(0.3)
on_active(Ef_Portal_Enemy) 
play_particle(Ef_Portal_Enemy)
wait_time(0.3)
Appear(Actor006)
PlayActionDirect(Actor006,"to Wlk")
slidemove(Actor006,move1,0.6)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_Portal_Enemy_1) 
play_particle(Ef_Portal_Enemy_1)
wait_time(0.3)
PlayActionDirect(Actor006,"to Std_Loop")
Appear(Actor007)
PlayActionDirect(Actor007,"to Wlk")
slidemove(Actor007,move2,0.6)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_Portal_Enemy_2) 
play_particle(Ef_Portal_Enemy_2)
wait_time(0.3)
PlayActionDirect(Actor007,"to Std_Loop")
Appear(Actor008)
PlayActionDirect(Actor008,"to Wlk")
slidemove(Actor008,move3,0.6)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor008,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力

	--★★ノワール★★:バルバロイ！？<br>なんで、こんなところに…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10020050")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "笑い")
-- ▲直接出力

	--★★汎用王様★★:あるところに親切な女性がいてね
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020051")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★汎用王様★★:ログレスをこの手にできるのなら<br>力を貸してもよい、と言ってくれたのさ
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020052")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:ふん、どいつもこいつも<br>女にたぶらかされ過ぎなんだよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10020054")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("王様", "落胆")
-- ▲直接出力

	--★★汎用王様★★:国民を納得させるための顔としての貴方でしたが<br>ご賛同いただけないのであれば仕方ありません
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020056")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★汎用王様★★:このまま人知れず、消えていただきましょう
	Talk(Actor005,"NPCNAME_0278","speech","N","CO_101022_10020057")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:準備はいいな！？クラリス！ノワール！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_10020059")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ああ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_10020060")

-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:は、はい～！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101022_10020061")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_モルドレッド_ランクアップ10_3")
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
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Enemy", false, true)
move1 = {-3.04, 0, -2.84}
move2 = {-3.41, 0, -0.66832}
move3 = {-3.287, 0, 1.102}
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401030","001","401030001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
