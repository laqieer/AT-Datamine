-- このluaスクリプトは、CO_101062_0803.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor003,-37.686,0)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,-165.343,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("マルイル", "気合い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:あ！いた！！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08030002")

-- ▼直接出力
PlayPartVoice("市民_男1", "挨拶")
-- ▲直接出力

	--★★市民（男）★★:あれ？君はこのあいだのお店の…
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_08030003")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:あの！このあいだ仰っていた薬について聞きたいことがあるんですが――
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08030004")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男1", "納得")
-- ▲直接出力

	--★★市民（男）★★:なるほど…そういうことか
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_08030006")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男1", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★市民（男）★★:だが…すまない。薬はまだ完成してないんだ
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_08030007")

	change_face(Actor003,"Normal")

	--★★市民（男）★★:このあいだの素材のおかげで研究は進んだんだがそこまで効果は期待できるものになっていない
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_08030008")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民_男1", "肯定3")
-- ▲直接出力

	--★★市民（男）★★:これだ今はまだ試験薬に過ぎないがね
	Talk(Actor003,"NPCNAME_0271","speech","N","CO_101062_08030010")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:…これが…！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08030011")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Camera001 = setup_small_camera_resetting(Actor001,CharaPos006,CameraPos006)
turn_chara(Actor001,-16,0)
setup_small_camera_start()
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:それがあればお爺さんのための薬が<br>手に入るかもしれないんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08030012")

-- ▼直接出力
PlayPartVoice("マルイル", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:可能性はあるというだけです<br>そもそもノワールさんならバルバロイは倒せます
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08030013")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("マルイル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:ただバルバロイを倒せば手に入るなら最初から行きますよ。でも、あそこは…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08030014")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なんだ。どこにあるのかわかってるのか<br>なら、取りにいけばいいだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:つ、ついてきてくれるんですか？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08030016")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:このあいだの契約がまだ残ってるからなそれに…だからお爺さんの教えを貫いたんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08030017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マルイル★★:でも、その場所はかなりの危険でいくらなんでもそこまで付き合わせるのは…！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今さらそんなこと気にするなよここまできたら付き合うさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08030019")


	--★★ノワール★★:報酬次第でどんな危険でも引き受けるのが<br>傭兵だからな。それに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08030020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…家族を思う気持ちは、俺もわかるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_08030021")

-- ▼直接出力
PlayPartVoice("マルイル", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:ノワールさん…
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_08030022")

-- ▼直接出力
local trustParam = set_communication_rankup("マルイル_コミュランク", "マルイル_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
