-- このluaスクリプトは、PT5_01_0034.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ヴェルナルス", "挨拶")
-- ▲直接出力

	--★★ヴェルナルス★★:地理学の授業をはじめる
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340002")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス★★:今日は<br>ローマ大帝国について話していく
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340003")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ヴェルナルス★★:ローマは<br>ブリテン島から海を越えた先の大陸にある大国だ
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定2")
-- ▲直接出力

	--★★ヴェルナルス★★:広大な土地と百年以上にも及ぶ長い歴史をもち<br>世界の様々な国の文化に多くの影響を与えている
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340005")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)

	--★★ヴェルナルス★★:それは<br>このブリテン島とて例外ではない
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340006")


	--★★ヴェルナルス★★:およそ１５年ほど前まで<br>ブリテン島はローマの領土のひとつだった
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340007")


	--★★ヴェルナルス★★:また、ローマが築いた街ロンディニウムは<br>島でもっとも栄える都市であり
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:今でも連日のように<br>ローマ本国から人や物が運ばれてきている
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340009")


	--★★ヴェルナルス★★:お前たちが着ている服<br>お前たちが住んでいる家
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340010")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ヴェルナルス★★:そしてお前たちが口にしている言葉<br>そのすべてがローマ発祥といっても過言ではない
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ヴェルナルス", "挨拶")
-- ▲直接出力

	--★★ヴェルナルス★★:ローマとログレスのどちらが上でどちらが下か<br>そんな議論に展開させるつもりはないが
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340012")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス★★:この島の生活には<br>ローマの文化が深く根付いていると考えてくれ
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","PT5_01_00340013")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
