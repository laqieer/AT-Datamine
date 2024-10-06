-- このluaスクリプトは、MA_01A109_39.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_003)
	Camera002 = SetTemplate("Actor002",162,CharaPos110041_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_005)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,-2.977, 1.507, -6.311)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1) 
set_common_look_at(Actor001,Actor002,1) 
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:おせっかい…でしたか？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390002")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:いいえ………助かりました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_390003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:ラシアです、あなたは？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390004")

	change_face(Actor002,"Sad")

	--★★エレイン★★:あ、の
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_390005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定")
-- ▲直接出力

	--★★ラシア★★:焦らずで、大丈夫ですから
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390006")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
se_play("SE_ADV_MA_01A900_30_Pen_Writing_01")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラシア★★:…なにを、書いて…手紙？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390008")

-- ▼直接出力
se_play("SE_ADV_MA_01105_28_Paper")
-- ▲直接出力

	--★★ラシア★★:『ありがとうございました』…？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ラシア", "否定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:…礼には及びません
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390012")

-- ▼直接出力
CloseTalkWindow()
wait_time(WAIT_TIME_NORMAL)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラシア★★:ロンディニウムのこと<br>…聞かせてもらいたいんです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390013")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★エレイン★★:…っ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_390014")

	change_face(Actor001,"Normal")

	--★★ラシア★★:…すみません。知り合い…が<br>その件に関わっている可能性があって
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:なにも、わかりません<br>なにもできませんでした
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_390016")

	change_face(Actor001,"Surprise")

	--★★ラシア★★:大柄な男性の姿を見ませんでしたか？<br>この学園で教師をしていた──
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390017")


	--★★エレイン★★:…失礼、します
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","MA_01A109_390018")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + 0.2)
--se_play("SE_ADV_MA_01104_20_DoorOpen")
se_play("SE_ADV_MA_01B109_11_Door")
Hide(Actor002)
turn_chara(Actor001, -27.175, 0)
lookat_weight_default(Actor001)
keep_delay_ik_lookat_object(Actor001, nil,"kara",100)
wait_time(2.5)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラシア★★:…『アストラットの美姫』<br>あれが…？
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01A109_390020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
