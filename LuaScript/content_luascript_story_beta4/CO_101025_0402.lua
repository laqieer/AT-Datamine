-- このluaスクリプトは、CO_101025_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_02","110161_02_h")
Include("content_adv_advsmall_110161_02","Template110161_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110161_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110161_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110161_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110161_02,CameraPos110161_02_004)
	InitializeTemplateRandomCamera110161_02()
	InitializeTemplate110161_02()
-- ▼直接出力
Prop_01 = get_object("geo_desk_item_09")
set_pos(Prop_01, {0,0,1.6})
Prop_02 = get_object("geo_chair_14")
set_pos(Prop_02, {1.05,0,3.13})
set_rot(Prop_02,{0,0,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:このあいだの<br>料理人を名乗った男の顔は覚えてる？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04020002")


	--★★ノワール★★:料理人？<br>…ああ、あのとき現場に駆けつけてきたヤツか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04020003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:覚えてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:似顔絵を描いてほしいの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04020005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:いいけど…なんに使うんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04020006")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:聞き込みに使うのよ<br>街の人に似顔絵を見せて足取りを追う
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04020007")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:あのあとロンディニウムに行ってみたんだがな<br>男が言っていたようなレストランはなかった
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_04020008")


	--★★ヴォールス★★:それ以前に、あの男が<br>ロンディニウムの住人かどうかも疑わしい
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_04020009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なるほど。それで似顔絵を見せて<br>あの男を見たことがないか聞くわけだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04020010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:…でもさ。クレアかヴォールスが<br>描くんじゃダメなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:む…
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_04020012")

-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
-- ▲直接出力

	--★★クレア★★:…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:わ、わかった<br>思い出しながら描いてみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04020014")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor003,"Normal")
setup_small_camera_start(Camera001)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こんなのでどうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:うん、よく特徴を捉えられているわ<br>これで聞き込みできそうね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04020017")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ4_3")
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
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
