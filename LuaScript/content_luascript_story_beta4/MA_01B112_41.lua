-- このluaスクリプトは、MA_01B112_41.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115113)
	Actor001 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★テロップ★★:相容れぬふたつの願いの行く末はペレス王の死<br>彼はガラハッドに別れを告げ、不吉な言葉を遺す
	Talk(Actor004,"telop","narration","N","MA_01B112_411001")


	--★★テロップ★★:ログレスで行われる降誕祭に<br>その言葉は影を落とすのであった
	Talk(Actor004,"telop","narration","N","MA_01B112_411002")


	--★★テロップ★★:
	Talk(Actor004,"telop","narration","N","MA_01B112_411003")


	--★★テロップ★★:
	Talk(Actor004,"telop","narration","N","MA_01B112_411004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:
	Talk(Actor004,"telop","narration","N","MA_01B112_411005")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
wait_time(1.6)
hide_image(1.6)
se_play("SE_ADV_MA_01B112_41_Crowds")
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Talk")
on_camera(set_camera) 
wait_time(2.0)
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(2.0)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
setup_prop_object_preload(10102012)
	InitializeLoad_Preload()
	load_area_scene_preload(115113)
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
