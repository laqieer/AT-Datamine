-- このluaスクリプトは、PT2_01_04_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101018","001","101018001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:よう、ノワール<br>憲兵団の仕事を手伝うことになったんだって？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01_04_0060005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ<br>少しでも街のために協力できたらと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0060006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:バルバロイとの戦いについても<br>もう少し慣れておきたいしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0060007")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ふ～ん
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01_04_0060008")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ま、せいぜいケガしねーように頑張りな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","PT2_01_04_0060009")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Appear(Actor003)
setup_small_camera_start(Camera001)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★ラグネル2★★:ガウェインってば<br>素直じゃないんだから～
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","PT2_01_04_0060011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わっ、ラグネル！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0060012")

	change_face(Actor003,"Laugh")

	--★★ラグネル★★:手伝いたいなら<br>手伝いたいって言えばいいのにね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT2_01_04_0060013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:手伝ってくれるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0060014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ラグネル★★:どうだろ？<br>さっきも言ったけど素直じゃないからね、あいつ
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT2_01_04_0060015")

-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:まあ、それは…<br>あたしも、だけど
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","PT2_01_04_0060016")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…結局、どっちなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT2_01_04_0060018")

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
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101018","001","101018001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
