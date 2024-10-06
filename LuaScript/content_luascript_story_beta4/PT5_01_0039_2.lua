-- このluaスクリプトは、PT5_01_0039_2.csvから自動生成されました --
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
	change_face(Actor003,"Smile")

	--★★クリスティーナ★★:今日の地理学の授業は<br>少しロマンティックな話をしましょうか
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390002")

	change_face(Actor003,"Normal")

	--★★クリスティーナ★★:妖精と呼ばれる存在についてよ
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390003")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:みんなも知ってのとおり<br>私たちの住むブリテン島は水と緑にあふれる地
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★クリスティーナ★★:かつてこの島の湖や森には<br>たくさんの妖精が住んでいたとされているわ
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390005")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クリスティーナ★★:妖精たちは人間に友好的で<br>両者は長らく共生関係にあったそうよ
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390006")


	--★★クリスティーナ★★:妖精伝承があちこちに残っていることからも<br>その事実はうかがえるわよね
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390007")

	PlayAction(Actor003,"to  Std_Sad01")
	change_face(Actor003,"Normal")

	--★★クリスティーナ★★:ところがある時期を境に<br>妖精の数は減少していき…
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★クリスティーナ★★:今ではこの島で<br>妖精の姿を確認することはできなくなった
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390009")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:危険を察知してどこかに隠れたのか？<br>それとも滅んでしまったのか？
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390010")


	--★★クリスティーナ★★:それは定かではないけれどね
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:妖精の数が減少した理由は<br>バルバロイによるものという説が有力だけど
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390012")


	--★★クリスティーナ★★:最後まで人間とともに<br>暮らしていた妖精の命を奪ったのは
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:他でもない<br>人間だとウワサされているわ
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390014")


	--★★クリスティーナ★★:「妖精殺し」が起こったのは<br>今から数年前の出来事
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クリスティーナ★★:その犯人は今もなお逃亡中だというわ<br>おそろしい話よね…
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","PT5_01_00390016")

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
