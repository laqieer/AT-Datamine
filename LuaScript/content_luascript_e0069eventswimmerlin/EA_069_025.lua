-- このluaスクリプトは、EA_069_025.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera002 = SetTemplate("Actor002",150,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",190,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera004 = SetTemplate("Actor004",130,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",-48.24,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera006 = SetTemplate("Actor006",-326,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera007 = SetTemplate("Actor007",-100,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera008 = SetTemplate("Actor008",31,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_pos(Actor005,{12.68,0.0,-16.44})
set_pos(Actor006,{21,0.0,-19.8})
set_pos(Actor007,{13.36,0.0,-33.63})
set_pos(Actor008,{9.55,0.0,-36})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0053")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:めっちゃ動物が棲みついているじゃないの！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0250003")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:いやあ、放置しすぎたな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0250004")

-- ▼直接出力
change_face(Actor002,"Normal")
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0037")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:申し訳ありません<br>私の確認不足でした
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0250005")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor003,"Normal")
setup_small_camera_start(RndCamera005)
PlayActionDirect(Actor005,"to Run")
turn_chara(Actor005,-40,0.4)
wait_time(0.4)
slidemove(Actor005,{3.0,0.0,-4.89},1.5)
wait_time(0.9)
setup_small_camera_start()
wait_time(1.1)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.8)
PlayActionDirect(Actor005,"to std01yell02")
se_play("SE_ADV_EA_069_025_Roar")
-- ▲直接出力

	--★★イノシシA★★:ガアアアッ！
	Talk(Actor005,"NPCNAME_0396","speech","N","EA_069_0250006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0034")
-- ▲直接出力

	--★★ギネマウア★★:どうやら、夏休みを楽しむ前に<br>掃除をする必要がありそうですね
	Talk(Actor004,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0250007")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
