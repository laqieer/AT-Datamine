-- このluaスクリプトは、PT5_01_0007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力

	--★★ブレイズ★★:しばらく前より<br>市井で流行している『狂忘症』を知っておるか？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00070002")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:それまで元気だった人間が<br>突如として深い昏睡状態に陥り…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00070003")


	--★★ブレイズ★★:目覚めたさいに記憶の一部を失ったり<br>狂ったように暴れ出したり
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00070004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ブレイズ★★:二度と目覚めなかったりするという<br>恐ろしい病じゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00070005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "怒り")
-- ▲直接出力

	--★★ブレイズ★★:記憶を失うことから<br>バルバロイが関係する病気なのだとする説もある
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00070006")


	--★★ブレイズ★★:安静にしておれば<br>病気の進行をある程度遅らせられるとは聞くが
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00070007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:今もって<br>狂忘病の特効薬は見つかっておらん
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00070008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ブレイズ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:狂忘病の初期症状は<br>異常な咳をするようになるとのことじゃから
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00070009")


	--★★ブレイズ★★:もしも周りに感染したと思わしき者があったら<br>安静にすることを勧めるようにな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","PT5_01_00070010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
