-- このluaスクリプトは、CO_101014_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_510_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_017_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101010111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401026","001","401026001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401030","001","401030001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor006,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("王様", "悲しみ")
-- ▲直接出力

	--★★汎用王様★★:娘よ、いたらぬ父を許してくれ…
	Talk(Actor006,"NPCNAME_0292","speech","N","CO_101014_09020002")

	PlayAction(Actor004,"to  Std_No")

	--★★貴族（女）②★★:お顔をお上げください、お父様私なら大丈夫です
	Talk(Actor004,"NPCNAME_0284","speech","N","CO_101014_09020003")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("貴族_男1", "肯定2")
-- ▲直接出力

	--★★貴族（男）②★★:あとは私どもにお任せくださいそれでは姫様、参りましょうか
	Talk(Actor005,"NPCNAME_0281","speech","N","CO_101014_09020004")

-- ▼直接出力
Appear(Actor001)
Appear(Actor002)
Appear(Actor003)
CloseTalkWindow()
wait_time(WAIT_TIME_SHORT)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:待ってくれ俺たちも着いていく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_09020006")


	--★★貴族（男）②★★:え、円卓の騎士…？
	Talk(Actor005,"NPCNAME_0281","speech","N","CO_101014_09020007")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_男1", "否定")
-- ▲直接出力

	--★★貴族（男）②★★:これは我が領地の問題です皆さまのお手を煩わせるわけにはまいりません
	Talk(Actor005,"NPCNAME_0281","speech","N","CO_101014_09020008")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "挨拶")
-- ▲直接出力

	--★★イゾルデ★★:生贄は若い娘であればこの領地の姫である必要はないはずよね？
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09020009")

-- ▼直接出力
PlayPartVoice("貴族_男1", "悩む")
-- ▲直接出力

	--★★貴族（男）②★★:どういう意味ですかな？
	Talk(Actor005,"NPCNAME_0281","speech","N","CO_101014_09020010")

-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:生贄には私がなると言っているの
	Talk(Actor003,"CHRNAME_ISOLDE","speech","L","CO_101014_09020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("貴族_男1", "悲しみ")
-- ▲直接出力

	--★★貴族（男）②★★:で、ですが…
	Talk(Actor005,"NPCNAME_0281","speech","N","CO_101014_09020012")


	--★★ノワール★★:なにか問題があるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_09020013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:ドラゴンに生贄の判別がつくのかわからないけどせっかくだし、ドラゴンを見てみたいんだよね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09020014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")

	--★★貴族（男）②★★:チッ…！ガキどもがしゃしゃり出てきおって…
	Talk(Actor005,"NPCNAME_0281","speech","N","CO_101014_09020015")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:なにか言った？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_09020016")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_男1", "肯定")
-- ▲直接出力

	--★★貴族（男）②★★:い、いえ…わかりました、参りましょう…
	Talk(Actor005,"NPCNAME_0281","speech","N","CO_101014_09020017")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ9_3")
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
	load_duel_scene_preload(101010111)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401026","001","401026001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401030","001","401030001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401035","001","401035001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
