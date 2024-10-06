-- このluaスクリプトは、PT2_01_06_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定2")
-- ▲直接出力

	--★★ヴェルナルス★★:次の土曜だが<br>ログレス郊外で実戦形式の演習を行ってもらう
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","PT2_01_06_0010005")

-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:演習？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","PT2_01_06_0010006")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:相手は、私が用意したローマの精鋭たちだ<br>彼らにも実戦のつもりで、と伝えてある
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","PT2_01_06_0010007")

	PlayAction(Actor004,"to Sit02_RH02")
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:ローマの兵士さんと戦うんですか！？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","PT2_01_06_0010008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定2")
-- ▲直接出力

	--★★ヴェルナルス★★:お前たちは対バルバロイのためとして<br>こうして授業を受けているが
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","PT2_01_06_0010009")


	--★★ヴェルナルス★★:ひとたび戦場に出れば<br>相手はバルバロイだけとは限らぬ
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","PT2_01_06_0010010")


	--★★ヴェルナルス★★:まして、現在ログレスは<br>カレドニアとの戦いを続けているのだろう
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","PT2_01_06_0010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:敵兵士との戦いは避けられない<br>そのときに備え、訓練はしておくべきだ
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","PT2_01_06_0010012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラグネル★★:ま、まあ、それはそうですけど…
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","PT2_01_06_0010013")


	--★★ヴェルナルス★★:それでは、良い結果報告を期待している
	Talk(Actor006,"CHRNAME_VERNARTH","speech","L","PT2_01_06_0010014")


	--★★ノワール★★:（ヴェルナルス先生が精鋭というほどの相手だ<br>気を引き締めてかからないとな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT2_01_06_0010015")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
