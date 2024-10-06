-- このluaスクリプトは、MA_01A900_30.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_002)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
tegami = setup_prop_object(10106004)
-- ▲直接出力
-- ▼直接出力
set_pos(tegami,{0.798, 0.816, -2.038})
-- ▲直接出力
-- ▼直接出力
set_rot(tegami,{0, 212, 0})
-- ▲直接出力
-- ▼直接出力
tegami2 = setup_prop_object(10106003)
-- ▲直接出力
-- ▼直接出力
set_pos(tegami2,{0.987, 0.818, -1.715})
-- ▲直接出力
-- ▼直接出力
set_rot(tegami2,{0,0, 180})
-- ▲直接出力
-- ▼直接出力
pen = setup_prop_object(10106006)
-- ▲直接出力
-- ▼直接出力
on_parent(pen,Actor001, "Loc_weapon_constrint_R", {0,0,0,0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:「いえない気持ちを<br>したためます」
	Talk(Actor002,"","simple","N","MA_01A900_300002")

-- ▼直接出力
se_play("SE_ADV_MA_01A900_30_Pen_Writing_01")
wait_time(0.5)
-- ▲直接出力

	--★★テロップ★★:「あなたの手助けをする気はありません<br>安らかに消えてもらいたくありません」
	Talk(Actor002,"","simple","N","MA_01A900_300003")

-- ▼直接出力
se_play("SE_ADV_MA_01A900_30_Pen_Writing_02")
wait_time(0.5)
-- ▲直接出力

	--★★テロップ★★:「あなたを想う私の気持ちのすべてが<br>忘れ去られてしまうとしても」
	Talk(Actor002,"","simple","N","MA_01A900_300004")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
hide_image(BLACK_WHITE_TIME)
wait_time(0.5)
SkipDefaultMotion(Actor001)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Studying")
reserve_lipsync(Actor001,"Close2")
se_play("SE_ADV_MA_01A900_30_Pen_Writing_03")
-- ▲直接出力

	--★★エレイン★★:「ここに記した言葉はどうなります？」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A900_300006")


	--★★エレイン★★:「あなたがこれより幾千年<br>遠い旅路に出るのなら」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A900_300007")

-- ▼直接出力
se_play("SE_ADV_MA_01A900_30_Pen_Writing_04")
wait_time(0.5)
setup_small_camera_end()
-- ▲直接出力

	--★★エレイン★★:「一生いえぬ気持ちを刻みます<br>記した言葉が残らずとも」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A900_300008")

-- ▼直接出力
se_play("SE_ADV_MA_01A900_30_Pen_Writing_04")
wait_time(0.5)
-- ▲直接出力

	--★★エレイン★★:「いま貴方に費やした時間は消えない」
	Talk(Actor001,"CHRNAME_ELAINE","speech","L","MA_01A900_300010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10106004)
setup_prop_object_preload(10106003)
setup_prop_object_preload(10106006)
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
