-- このluaスクリプトは、PT5_01_0042_1.csvから自動生成されました --
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
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_006)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
hideobj01 =get_object("geo_desk_item_02")
hideobj02 =get_object("geo_desk_item_04")
hideobj03 =get_object("geo_desk_item_07")
hideobj04 =get_object("geo_desk_item_10")
hideobj05 =get_object("geo_desk_item_13")
hideobj06 =get_object("geo_desk_item_01")
-- ▲直接出力
-- ▼直接出力
set_pos(hideobj01,{0,-20,0})
set_pos(hideobj02,{0,-20,0})
set_pos(hideobj03,{0,-20,0})
set_pos(hideobj04,{0,-20,0})
set_pos(hideobj05,{0,-20,0})
set_pos(hideobj06,{0,-20,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:遠い昔、この島の東端には<br>不可視の壁に守られた都があったとされているわ
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","PT5_01_00420002")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:その都の名前はサラス
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","PT5_01_00420003")


	--★★クリスティーナ★★:サラスにまつわる文献を紐解くと<br>聖杯についての記述が数多く見られるから
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","PT5_01_00420004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★クリスティーナ★★:サラスは聖杯と密接に関係する場所<br>だったのかもしれないわね
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","PT5_01_00420005")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力

	--★★クリスティーナ★★:でも<br>そんなサラスの都も滅んで久しい
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","PT5_01_00420006")

	change_face(Actor004,"Normal")

	--★★クリスティーナ★★:今となっては都があった場所を知る人間すら<br>ほとんどいないそうよ
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","PT5_01_00420007")


	--★★クリスティーナ★★:ただ、聖杯の出現に合わせて<br>サラスの都も再び現れるなんて伝承もあるわ
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","PT5_01_00420008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クリスティーナ★★:それが本当だったらすごく素敵よね
	Talk(Actor004,"CHRNAME_CHRISTINA","speech","L","PT5_01_00420009")

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
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
