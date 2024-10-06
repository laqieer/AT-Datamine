-- このluaスクリプトは、CO_101065_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",-45,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_030_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor005,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor004,Actor005,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401022","001","401022001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_2DOnly("101065","001","101065001")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男1", "悩む")
-- ▲直接出力

	--★★市民（男）★★:それでは今回の取引は………で………して………という流れで
	Talk(Actor005,"NPCNAME_0277","speech","N","CO_101065_09020002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("山賊", "笑い")
-- ▲直接出力

	--★★山賊★★:あいよ、了解だ
	Talk(Actor003,"NPCNAME_0203","speech","N","CO_101065_09020003")

-- ▼直接出力
PlayPartVoice("市民中年_男1", "肯定")
-- ▲直接出力

	--★★市民（中年男）②★★:それにしても怖ぇコト考えるなあ<br>ガキを生贄にバルバロイに取り入ろうなんてよ
	Talk(Actor004,"NPCNAME_0204","speech","N","CO_101065_09020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男2", "肯定2")
-- ▲直接出力

	--★★市民（男）★★:望みをかなえるために多少の犠牲を気にしてはいられません
	Talk(Actor005,"NPCNAME_0277","speech","N","CO_101065_09020005")


	--★★市民（男）★★:それに大いなる存在の糧となることは彼らに比類なき名誉と幸福を――
	Talk(Actor005,"NPCNAME_0277","speech","N","CO_101065_09020006")

-- ▼直接出力
PlayPartVoice("キッス", "落胆")
-- ▲直接出力

	--★★キッス2D★★:まったく、はた迷惑なものよねぇ
	Talk(Actor007,"CHRNAME_KISS","speech","L","CO_101065_09020008")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
turn_lookat(Actor003,Actor002,0)
turn_lookat(Actor004,Actor002,0)
Appear(Actor001)
Appear(Actor002)
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME) 
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("市民_男2", "驚き")
-- ▲直接出力

	--★★市民（男）★★:何者だ！？
	Talk(Actor005,"NPCNAME_0277","speech","N","CO_101065_09020010")

-- ▼直接出力
PlayPartVoice("山賊", "怒り")
-- ▲直接出力

	--★★山賊★★:くそ、なんでここがわかったんだ…！
	Talk(Actor003,"NPCNAME_0203","speech","N","CO_101065_09020011")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:罪のない子供を巻き込もうなんて絶対に許すわけにはいかない！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:心も体も全然なってないわ、キミたちまずはたっぷり、お仕置きしてあげる♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09020014")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor003)
Hide(Actor005)
Hide(Actor004)
Hide(Actor006)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME) 
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:片付いたか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09020017")

	open_select_window_tag(Actor001,"Normal","CO_101065_09020019","CO_101065_09020020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キッスさん怪我はないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09020022")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:全然問題ないわ心配してくれてありがと♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09020023")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:でも、驚いた本当に鍛えてたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09020024")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:エージェントは<br>つねに危険と隣り合わせの仕事だもの♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09020025")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:これで子供たちも安心だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09020027")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:大事になる前に解決できて良かったわラビットちゃんのおかげよ。ありがとう
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09020028")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:騎士として当然のことをしたまでだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09020029")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:その名に恥じぬ行いね…騎士として
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09020030")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★キッス★★:それじゃ、こいつらを捕まえてログレスの警吏に引き渡しましょうか
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09020032")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★キッス★★:うまくすれば報酬もらえるかもしれないわよ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_09020033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ、期待しとく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_09020034")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_キッス_ランクアップ9_3")
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
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401041","001","401041001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401022","001","401022001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_2DOnly_Preload("101065","001","101065001")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
