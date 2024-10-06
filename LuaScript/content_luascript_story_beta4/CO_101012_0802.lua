-- このluaスクリプトは、CO_101012_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:それで<br>今度はなにに行き詰まったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08020002")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:あのね。素敵な歌詞もできたことだし<br>今度は歌詞に曲をつけたいんだけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:私、楽器なんてできないし<br>どうしようかなって…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08020004")


	--★★ディナタン★★:マァルも楽器はサッパリだって言ってたし<br>兄さんができないのはもちろん知ってるし
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08020005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:失礼な…と言いたいところだけど<br>まったくもってそのとおりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08020006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:作曲が出来そうな人<br>兄さんの知り合いにいないかな？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08020007")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:作曲の出来そうなヤツか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:トリスタンはどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08020010")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ディナタン", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:ああ！トリスタンさん、竪琴が得意だったよね<br>ちょっとお願いに行ってみよう！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ディナタン_ランクアップ8_3")
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
