-- このluaスクリプトは、EA_066_043.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation11","DuelCommonFormation11_h")
Include("content_adv_advsmall_duelcommonformation11","TemplateDuelCommonFormation11_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation11_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_001)
	Camera002 = SetTemplate("Actor002",-25,CharaPosDuelCommonFormation11_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_002)
	Camera003 = SetTemplate("Actor003",10,CharaPosDuelCommonFormation11_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation11_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation11_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation11_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_007)
	InitializeTemplateRandomCameraDuelCommonFormation11()
	InitializeTemplateDuelCommonFormation11()
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
load_sound("BGM_Battle_Nature_Start")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{ 0, 0, -6.5})
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
weapon1 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon1_offset = {0,0.01,-0.05,0,0,0}
off_parent(weapon1,Actor004, "Loc_weapon_constrint_L",weapon1_offset)
off_active(weapon1)
-- ▲直接出力
-- ▼直接出力
weapon2 = set_object("content_weapon_103010001", "weapon_model_103010001", true)
weapon2_offset = {0,0,0,0,0,0}
off_parent(weapon2,Actor005, "Loc_weapon_constrint_L",weapon2_offset)
off_active(weapon2)
-- ▲直接出力
-- ▼直接出力
weapon3 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
weapon3_offset = {0,0,0,0,0,-5}
off_parent(weapon3,Actor006, "Loc_weapon_constrint_L",weapon3_offset)
off_active(weapon3)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101030011)
	Actor001 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera001)
PlayActionDirect(Actor001,"to Wlk")
slidemove( Actor001, 0, 0, -4.95, 1.2)
setup_small_camera_start(Camera001)
se_play("SE_ADV_MA_01100_11_Jail_Foot")
wait_time( 1.1)
PlayActionDirect( Actor001,"to  Std_Worry")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0009")
-- ▲直接出力

	--★★ラロゥ★★:
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0430003")

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-40,0.2)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
lookat_delay_weight(Actor002,0.5,0.5,0.85,0.2,0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0007")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,60,0.35)
wait_time(0.35)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★クレア★★:そうね。でも気を付けたほうがいいわところどころの作りが劣化してる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0430004")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:いつ崩れてもおかしくないわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0430005")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0030")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラロゥ★★:うげ。やっぱ古い遺跡なんだね
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0430006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0430007")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:………
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0430008")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor003,"J_Foot_L", 0.8)
lookat_delay_weight(Actor003,0.3,0.4,0.3,1.0, 0.8)
-- ▲直接出力

	--★★ヴォールス★★:（なんだ、遺跡の中に漂うこの妙な空気は）
	Talk(Actor003,"CHRNAME_BORS","mind","L","EA_066_0430009")


	--★★ヴォールス★★:（息をしているだけで、まるでなにかに<br>せっつかれているような焦りを感じさせる――）
	Talk(Actor003,"CHRNAME_BORS","mind","L","EA_066_0430010")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
set_animationbattlecontroller(Actor005, 6, False)
set_animationbattlecontroller(Actor006, 8, False)
Appear(Actor004)
Appear(Actor005)
Appear(Actor006)
on_active(weapon1)
on_active(weapon2)
on_active(weapon3)
on_parent(weapon1,Actor004, "Loc_weapon_constrint_L",weapon1_offset)
on_parent(weapon2,Actor005, "Loc_weapon_constrint_L",weapon2_offset)
on_parent(weapon3,Actor006, "Loc_weapon_constrint_L",weapon3_offset)
-- ▲直接出力

	--★★ローマ兵★★:――貴様ら、何者だ！？
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430011")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003,0,0.25)
wait_time(0.05)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,0,0.25)
wait_time(0.1)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,0,0.2)

wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
SkipDefaultMotion(Actor002)
wait_time(0.2)
PlayActionDirect(Actor001,"to Std_Squareoff_Loop")
SkipDefaultMotion(Actor001)
wait_time(0.2)
PlayActionDirect(Actor003,"to Std_Squareoff_Loop")
SkipDefaultMotion(Actor003)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
lookat_delay_weight(Actor001,0.5,0.5,0.85,0.2,0.5)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
PlayPartVoiceDirect("ラロゥ","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラロゥ★★:
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0430013")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ラロゥ★★:ローマ兵の残党が聖杯を狙ってるって話は<br>デマじゃないみたいだね
	Talk(Actor001,"CHRNAME_LAROU","speech","L","EA_066_0430014")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("兵士2","0046")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ローマ兵★★:聖杯――そうか、貴様らも聖杯が目当てか――
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430015")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("兵士2","0013")
-- ▲直接出力

	--★★ローマ兵★★:フフ、フフフ…渡さんぞ…<br>聖杯は我らがローマのものだ…
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430016")


	--★★ローマ兵★★:我らは必ず聖杯を手に入れ<br>あの方の大願を成就させるのだ
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430017")

	PlayAction(Actor004,"to  Std_Joy")

	--★★ローマ兵★★:滅びの未来になにも手を打とうとせず<br>限りあるローマを食い潰す本国に誰が従えよう
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430018")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("兵士2","0014")
-- ▲直接出力

	--★★ローマ兵★★:ローマの過去の繁栄を取り戻し<br>真にローマのために戦い抜いた
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430019")

-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Sad01")
SkipDefaultMotion(Actor004)
-- ▲直接出力

	--★★ローマ兵★★:あの方こそがローマの希望<br>あの方こそがローマの意志
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430020")


	--★★ローマ兵★★:我らが従うべきは真の王<br>ルーシャス様の御意志のみ
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430021")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("兵士2","0010")
-- ▲直接出力

	--★★ローマ兵★★:そう、悪逆非道のログレスを討ち滅ぼし<br><ruby=パクス・ロマーナ>ローマの平和</ruby>を実現させる――
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430022")

-- ▼直接出力
setup_small_camera_start(Camera002)
off_parent(weapon1,Actor004, "Loc_weapon_constrint_L",weapon1_offset)
on_parent(weapon1,Actor004, "Loc_weapon_constrint_R",weapon1_offset)
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor004,1,False)
-- ▲直接出力

	--★★クレア★★:…気を付けて。様子が変だわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0430024")

-- ▼直接出力
se_play("SE_Handling_Swd_001")
setup_small_camera_start(Camera004)
PlayActionDirect(Actor002,"to Std_Squareoff_Loop")
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Sad02")
SkipDefaultMotion(Actor004)
-- ▲直接出力

	--★★ローマ兵★★:先の戦いで我らが不甲斐ないばかりに<br>あの方の理想を叶えることが出来なかった
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430025")

-- ▼直接出力
PlayPartVoiceDirect("兵士2","0021")
-- ▲直接出力

	--★★ローマ兵★★:
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430026")

-- ▼直接出力
PlayPartVoiceDirect("兵士2","0035")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor004,"Normal")
	change_face(Actor004,"Normal")

	--★★ローマ兵★★:
	Talk(Actor004,"NPCNAME_0122","speech","N","EA_066_0430027")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	close_cutin()
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0016")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ヴォールス★★:…来るぞ！！
	Talk(Actor003,"CHRNAME_BORS","speech","L","EA_066_0430028")

-- ▼直接出力
bgm_play("BGM_Battle_Nature_Start")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Reconnaissance")
preload_sound("BGM_Battle_Nature_Start")
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon1_offset = {0,0.01,-0.05,0,0,0}
set_object_preload("content_weapon_103010001", "weapon_model_103010001", true)
weapon2_offset = {0,0,0,0,0,0}
set_object_preload("content_weapon_105010001", "weapon_model_105010001", true)
weapon3_offset = {0,0,0,0,0,-5}
	InitializeLoad_Preload()
	load_duel_scene_preload(101030011)
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation11)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
