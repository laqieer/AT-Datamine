-- このluaスクリプトは、CO_101015_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:（…アーサーのやつ、<br>なんか、いつもと雰囲気違ったな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101015_05020002")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
Appear(Actor002)
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001,{0.4, 0.08, 0.7, 0.6},1)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.5)
wait_time(1)
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "挨拶")
-- ▲直接出力

	--★★マーリン★★:ノワール様<br>ひとつ頼まれていただけないでしょうか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_05020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:頼み？なんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05020005")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マーリン", "悩む")
-- ▲直接出力

	--★★マーリン★★:…アーサーを町に連れ出してほしいのです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_05020006")


	--★★ノワール★★:街に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:はい<br>ここ最近ずっと執務室に籠りきりのようなので
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_05020008")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:確かに…仕事、立て込んでるみたいですしね<br>…でも、いいんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_05020009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:ええ。王としてやるべきことが山積みなのは<br>間違いありません。ですが――
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_05020010")

	change_face(Actor002,"Sad")

	--★★マーリン★★:それでも<br>今のあの方に一番必要なことだと思うのです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","CO_101015_05020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_アーサー_ランクアップ5_3")
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
