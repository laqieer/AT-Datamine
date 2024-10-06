-- このluaスクリプトは、EA_053_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","e0053_01_f_Controller","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_003)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{5.64,-0.003,-7.51})
set_pos(Actor007,{5.64,-0.003,-7.51})
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
flyer1 = setup_prop_object(10106003)
flyer2 = setup_prop_object(10106003)
on_parent(flyer1,Actor001, "Loc_Weapon_Hand_L", 0,0,0,0,0,0)
on_parent(flyer2,Actor001, "Loc_Weapon_Hand_R", 0,0,0,0,0,0)
on_active(flyer1)
on_active(flyer2)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B109_10_Ambient_Loop")
-- ▲直接出力
-- ▼直接出力
 load_image("104000330", "content_still_10400033_image", "104000330_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115120)
	Actor001 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101047","001","101047001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401018","001","401018001","content_animationpack__common","FacialPack","Actor007")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor001,"to Std_HaveFlyer_talk")
PlayPartVoiceDirect("リオネス","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★リオネス★★:もうすぐ五月祭！食堂ではコック長とガレスが<br>特製メニューでおもてなし！
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_053_0310006")

-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0011")
-- ▲直接出力

	--★★リオネス★★:それから、五月祭用に準備した美味しいお菓子を<br>皆にプレゼントするぞ！
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_053_0310007")

	change_face(Actor001,"Normal")

	--★★リオネス★★:
	Talk(Actor001,"CHRNAME_LYONESS","speech","L","EA_053_0310008")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
setup_small_camera_end(Camera001)
setup_small_camera_start(RndCamera001)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
off_parent(flyer2)
off_active(flyer2)
PlayActionDirect(Actor001,"to Std_HaveFlyer_Continue")
local actor = {Actor006,Actor007}
local num = math.random(1,2)
local gopos = {7.389, -0.003, -7.107}
Appear(actor[num])
turn_lookat_position(actor[num], gopos, 0)
PlayActionDirect(actor[num],"to Run")
slidemove(actor[num], gopos, 1)
wait_time(1)
PlayActionDirect(actor[num],"to Std_Loop")
wait_time(0.6)
on_parent(flyer2,Actor001, "Loc_Weapon_Hand_R", 0,0,0,0,0,0)
on_active(flyer2)
wait_time(0.4)
show_image("104000330", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
wait_time(0.6)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("市民_男1","0007")
-- ▲直接出力

	--★★市民（男）★★:へえ、いいじゃん。食堂の飯はどれも美味いし<br>お菓子も気になるな～
	Talk(Actor002,"NPCNAME_0177","speech","N","EA_053_0310009")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.4)
hide_image(STILL_SWITCH_TIME)        
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
wait_time(0.4)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat(Actor003,Actor004,0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0002")
-- ▲直接出力

	--★★子供（男）★★:ママ、ママー！これ食べたい！
	Talk(Actor003,"NPCNAME_0077","speech","N","EA_053_0310010")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor003,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("市民_女1","0008")
-- ▲直接出力

	--★★市民（女）★★:そうね<br>お祭りの日、忘れずにもらいにこなくっちゃ
	Talk(Actor004,"NPCNAME_0182","speech","N","EA_053_0310011")

-- ▼直接出力
setup_small_camera_end(RndCamera001)
-- ▲直接出力

	--★★？？？★★:ふーん。特製お菓子、ねぇ…
	Talk(Actor005,"CHRNAME_NAMELES","speech","R","EA_053_0310014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10106003)
setup_prop_object_preload(10106003)
 load_image_preload("104000330", "content_still_10400033_image", "104000330_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115120)
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101047","001","101047001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401018","001","401018001","content_animationpack__common","FacialPack","Actor007")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
