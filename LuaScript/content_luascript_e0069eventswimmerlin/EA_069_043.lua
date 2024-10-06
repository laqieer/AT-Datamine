-- このluaスクリプトは、EA_069_043.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",0,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",95,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("201010870","content_still_20101087_image","201010870_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
set_pos(Actor001,{1,0,-0.19})
set_pos(Actor002,{0.26,0,-0.96})
set_pos(Actor003,{-8.2,0,-1.15})
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0)
--lookat_delay_weight(Actor002,0.45,0.1,0.85,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
Sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
Sword_offset = {0,0,0,0,0,0}
off_parent(Sword_01,Actor001, "Loc_weapon_constrint_L",Sword_offset)
-- ▲直接出力
-- ▼直接出力
Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
set_pos(Ef_0002,{-0.74,0,1.41})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","005","101020005","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0019")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アーサー★★:うーむ…まさか少し目を離した隙に<br>ふたりがいなくなってしまうとは
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0430002")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
wait_time(0.1)
PlayPartVoiceDirect("マーリン_005","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:私も、この辺りは敵の気配がないからと<br>少し油断していました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0430003")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0033")
-- ▲直接出力

	--★★アーサー★★:ああ、なんたる失態だ。ランスに知られたら<br>ものすごく呆れられるだろうな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0430004")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:それくらいで済むようにしなくてはいけませんね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0430005")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★マーリン★★:少しお待ちください<br>今、魔法でおふたりの行方を追いますから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","EA_069_0430006")

-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_delay_ik_lookat(Actor002,Actor002,"J_Foot_L",1.0)
lookat_delay_weight(Actor002,0.25,0.1,0.45,0.2,1.0)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-60,0.6)
wait_time(0.6)
PlayActionDirect(Actor002,"to  Std_Surp")
SkipDefaultMotion(Actor002)
force_eyesync(Actor002,"Close")
reserve_eyesync(Actor002,"Close")
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:魔法があってよかった～！
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0430007")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:これでふたりを見つけられるな<br>何事もなければいいが…
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0430008")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
show_image("201010870", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(0.8,0.8)
force_eyesync(Actor002,"Auto")
on_active(Ef_0002) 
PlayActionDirect(Actor002,"to Std_Loop")
on_parent(Sword_01,Actor001, "Loc_weapon_constrint_L",Sword_offset)
wait_time(0.7)
fadein(0.4)
wait_time(1.5)
-- ▲直接出力

	--★★マーリン★★:…痕跡が掴めました<br>どうやらこの先の森の洞窟にいるようです
	Talk(Actor002,"CHRNAME_MERLIN","simple","N","EA_069_0430018")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0019")
-- ▲直接出力

	--★★アーサー★★:あの辺りには確かイノシシの巣穴があったな<br>以前、狩りの途中に見たことがある
	Talk(Actor001,"CHRNAME_ARTHUR","simple","N","EA_069_0430019")


	--★★アーサー★★:なんだってふたりはそんなところに？
	Talk(Actor001,"CHRNAME_ARTHUR","simple","N","EA_069_0430020")

-- ▼直接出力
PlayPartVoiceDirect("マーリン","0034")
change_face(Actor002,"Anger")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:なにか気になることがあったのかもしれません<br>たとえば…このイノシシ大発生の理由とか
	Talk(Actor002,"CHRNAME_MERLIN","simple","N","EA_069_0430021")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
setup_small_camera_start(RndCamera002)
off_active(Ef_0002) 
hide_image(0)
Appear(Actor003)
wait_time(0.1)
set_enable_auto_lookat_all(false)
turn_chara(Actor002,-70,0.3)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
wait_time(0.3 + 0.2)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to std01yell02")
se_play("SE_ADV_EA_069_031_Growl")
-- ▲直接出力

	--★★イノシシ★★:グルルルルル…
	Talk(Actor003,"NPCNAME_0396","speech","N","EA_069_0430024")

-- ▼直接出力
wait_time(1)
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0046")
-- ▲直接出力

	--★★アーサー★★:なるほどなそれは俺も気になるところだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0430025")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor001,"to Std_Squareoff_Loop")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
se_play("SE_Handling_Swd_001")
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★アーサー★★:それじゃあ…視察に行くとするか
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","EA_069_0430026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("201010870","content_still_20101087_image","201010870_StillImage")
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
Sword_offset = {0,0,0,0,0,0}
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Black_fog", false, true)
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","005","101020005","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
