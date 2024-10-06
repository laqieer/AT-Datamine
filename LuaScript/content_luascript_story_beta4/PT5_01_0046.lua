-- このluaスクリプトは、PT5_01_0046.csvから自動生成されました --
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
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:カレドニアの制圧下になってからは<br>訪れることすら困難になってしまっているが
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460002")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:ブリテン島の東部の情勢について<br>少し整理していくとしよう
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460003")

	PlayAction(Actor006,"to  Std_Talk")

	--★★ケイ★★:まず、島の中央部北側に位置するのが<br>カーライル城だ
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:ここは近くに港が存在し<br>漁業や海の向こうとの貿易
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460005")


	--★★ケイ★★:加えてアイルランド島への連絡便などで<br>賑わう地域だったのだが
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460006")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:現在はカレドニアに抑えられてしまっている
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460007")


	--★★ケイ★★:また、島の東部は険しい山岳地帯と森が広がり<br>もともと人が住むのに適した環境ではなかったが
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:カレドニアの侵略やバルバロイの増加によって<br>今では人の姿を見かけることすら珍しいとも聞く
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460009")


	--★★ケイ★★:もともとあった城や街、村からは人が逃げ出し<br>廃墟と化した場所もいくつかあるようだ
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460010")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:カレドニアに勝利した暁には<br>これらの地の平定も視野に入れねばならんな
	Talk(Actor006,"CHRNAME_KAY","speech","L","PT5_01_00460011")

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
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
