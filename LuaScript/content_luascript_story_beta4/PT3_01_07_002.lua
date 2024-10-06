-- このluaスクリプトは、PT3_01_07_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:よう、ノワール<br>このあいだは大変だったな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_07_0020003")

-- ▼直接出力
PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:ルーシャスの相手はマジで<br>疲れるっつーか、厄介つーか…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_07_0020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ああ…ほんとにな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0020005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:でも、ゲームをクリアすれば<br>兵を出してくれるってことだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0020006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:まあ、頑張るっきゃねーか…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_07_0020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ああ、そうだ。うまいこと終わったらさ<br>ロンディニウムに遊びに行かね？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_07_0020008")


	--★★ガウェイン★★:ロンディニウムの楽団の演奏は一度聞くべきって<br>トリスタンが言ってたんだよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_07_0020009")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:トリスタンが褒めるほどの演奏なのか？<br>それは俺も一度聴いてみたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT3_01_07_0020010")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:うし、決まりな<br>落ち着いたらスケジュール考えようぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT3_01_07_0020011")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
