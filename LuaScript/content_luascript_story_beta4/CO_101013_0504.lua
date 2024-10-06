-- このluaスクリプトは、CO_101013_0504.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラグネル★★:えーっ！？ロンディニウム行きの船、もう出ちゃったの？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05040002")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ローマ兵士_下位★★:ああつい先刻発ってしまった
	Talk(Actor004,"NPCNAME_0122","speech","L","CO_101013_05040003")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:あちゃー…ヴェルナルス先生になんて言って謝る？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:そ、そりゃお前…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05040005")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ガウェイン★★:なあノワールなんて言って謝るのがいいかなあ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05040006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_05040008","CO_101013_05040009","CO_101013_05040010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイに襲われた村を助けていましたって事情を説明すればいいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05040012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴェルナルス先生ならわかってくれるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05040013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:そうだよな変に言い訳とかはしないほうがいいよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05040014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こういうときは素直に「すみませんでした」と謝るのが一番
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05040016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ラグネル★★:あたしもそう思う詳しく説明しようとしたら、あんたテンパりそう
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05040017")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:なんかバカにされてる気もするけどまあ、それがよさそうだよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05040018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は知らない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05040020")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガウェイン★★:お前、それはねーだろ！一緒に依頼受けて、一緒にここまで来たのによ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05040021")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ラグネル", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:見損なったよ、ノワール…
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","CO_101013_05040022")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:じょ、冗談！冗談だって…俺も一緒に謝るからさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_05040023")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:はあ…ログレスに戻って、先生んとこ行こうぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_05040025")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ5_5")
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
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
