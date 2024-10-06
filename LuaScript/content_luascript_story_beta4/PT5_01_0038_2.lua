-- このluaスクリプトは、PT5_01_0038_2.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力

MobsNo = 2
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
hideobj01 =get_object("geo_desk_item_02")
hideobj02 =get_object("geo_desk_item_04")
hideobj03 =get_object("geo_desk_item_07")
hideobj04 =get_object("geo_desk_item_10")
hideobj05 =get_object("geo_desk_item_13")
set_pos(hideobj01,{0,-20,0})
set_pos(hideobj02,{0,-20,0})
set_pos(hideobj03,{0,-20,0})
set_pos(hideobj04,{0,-20,0})
set_pos(hideobj05,{0,-20,0})
hideobj06 =get_object("geo_desk_item_06")
hideobj07 =get_object("geo_desk_item_15")
hideobj08 =get_object("geo_desk_item_16")
set_pos(hideobj06,{0,-20,0})
set_pos(hideobj07,{0,-20,0})
set_pos(hideobj08,{0,-20,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:コルベニック王国とか<br>コーンウォール王国とか
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00380002")


	--★★クリスティーナ★★:これまでにログレスと仲の良い国について<br>話してきたけれど
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00380003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:海の向こうにも<br>いくつかログレスの同盟国があるの
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00380004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:一番仲が良かったのは<br>ベンウィックという国なんだけど
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00380005")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★クリスティーナ★★:２０年以上も前に起きた<br>大きな戦闘で滅んでしまったわ
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00380006")

	change_face(Actor003,"Normal")

	--★★クリスティーナ★★:卒業後、海の向こうの同盟国の<br>防衛に派遣される子たちもいるそうだから
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00380007")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クリスティーナ★★:ひょっとするとみんなも<br>同盟国の人たちと知り合う機会があるかもね
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00380008")

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
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
