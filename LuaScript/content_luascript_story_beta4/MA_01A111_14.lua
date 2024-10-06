-- このluaスクリプトは、MA_01A111_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation04","DuelCommonFormation04_h")
Include("content_adv_advsmall_duelcommonformation04","TemplateDuelCommonFormation04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation04_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_011)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation04_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_012)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_024_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation04,CameraPosDuelCommonFormation04_003)
	InitializeTemplateRandomCameraDuelCommonFormation04()
	InitializeTemplateDuelCommonFormation04()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
Ef_Aura_Enemy = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
set_animationbattlecontroller(Actor005, 1)
keep_ik_lookat(Actor005,Actor004,"J_Head")
set_enable_auto_lookat(Actor005,false)
set_animationbattlecontroller(Actor006, 1)
PlayActionDirect(Actor006,"ToAbnormal")
local EfPos = get_pos(Actor004)
set_pos(Ef_Aura_Enemy , EfPos)
on_active(Ef_Aura_Enemy) 
play_particle(Ef_Aura_Enemy)
sword001 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
off_active(sword001)
sword001_offset  = {-0.07,-0.02,0,0,-170,0}
on_parent(sword001,Actor001, "J_Hand_R", sword001_offset)
off_parent(sword001)
sword002 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
off_active(sword002)
sword002_offset  = {-0.07,-0.02,0,0,-170,0}
on_parent(sword002,Actor005, "J_Hand_R", sword002_offset)
off_parent(sword002)
sword003 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
off_active(sword003)
sword003_offset  = {-0.07,-0.02,0,0,-170,0}
on_parent(sword003,Actor006, "J_Hand_R", sword003_offset)
off_parent(sword003)
on_active(sword002)
on_parent(sword002,Actor005, "J_Hand_R", sword002_offset)
on_active(sword003)
on_parent(sword003,Actor006, "J_Hand_R", sword003_offset)
load_image("101030440", "content_still_10103044_image", "101030440_StillImage")
load_image("101030450", "content_still_10103045_image", "101030450_StillImage")
Ef_Witch_Out = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
off_active(Ef_Witch_Out)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
Hide(Actor002)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor002,false)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001, {0, 0, 5.81,   180})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002, {1.325, 0, 6.99,   243.3485})
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor005,Actor004,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor006,Actor004,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101090011)
	Actor001 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101044","001","101044001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101058","002","101058002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01A111_141001")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01A111_141002")


	--★★テロップ★★:どこだ、ルーシャス
	Talk(Actor007,"telop","narration","N","MA_01A111_141003")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
shake_camera(RndCamera002,1.0,8)
se_play("SE_ADV_Emy001_Cry")
se_play("SE_ADV_MA_01A111_14_Earthquake")
wait_time(8.0)
setup_small_camera_end(RndCamera002)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ライエンス王★★:どこだ、ルーシャス
	Talk(Actor004,"CHRNAME_LAIENS","speech","R","MA_01A111_140002")

-- ▼直接出力
 --PlayPartVoice("兵士1", "苦しみ")
-- ▲直接出力

	--★★ローマ兵士_下位★★:ひ、ひるむな…！<br>包囲し叩け、敵は１体だ！！
	Talk(Actor005,"NPCNAME_0122","speech","N","MA_01A111_140003")

	PlayAction(Actor004,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ライエンス", "激怒")
-- ▲直接出力

	--★★ライエンス王★★:どこだあああ
	Talk(Actor004,"CHRNAME_LAIENS","speech","R","MA_01A111_140005")

-- ▼直接出力
Appear(Actor001)
Appear(Actor002)
CloseTalkWindow()
setup_small_camera_start(P11_Cam)
IN_WALK_2P(Actor001,{0, 0, 1.641,   180},Actor002,{1.325, 0, 2.306,   183})
on_active(sword001)
on_parent(sword001,Actor001, "J_Hand_R", sword001_offset)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ヴェルナルス★★:迷い出たか
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140007")

-- ▼直接出力
setup_small_camera_end(P11_Cam)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラシア★★:傷を負った物はカレドニア城へ退け！<br>ここはヴェルナルス大将軍が引き受ける！！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A111_140008")

-- ▼直接出力
 --PlayPartVoice("兵士2", "悲しみ")
-- ▲直接出力

	--★★ローマ兵士_下位★★:わ、我らでは刃すら通りませぬ！！<br>ご武運を！！
	Talk(Actor005,"NPCNAME_0122","speech","N","MA_01A111_140009")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor005)
Hide(Actor006)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ライエンス", "悲しみ")
-- ▲直接出力

	--★★ライエンス王★★:ルーシャス………！<br>聖杯を…我が悲願を、赦せぬ…！！
	Talk(Actor004,"CHRNAME_LAIENS","speech","R","MA_01A111_140011")

-- ▼直接出力
 --PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力

	--★★ラシア★★:ライエンス王…<br>コルベニックでログレスに討たれたはずでは──
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A111_140012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴェルナルス★★:謁見の許可は出せんな
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140013")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ライエンス王★★:死にぞこないが！！
	Talk(Actor004,"CHRNAME_LAIENS","speech","R","MA_01A111_140014")

-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "気合い")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ヴェルナルス★★:こちらの台詞だ
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140016")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1,0.2)
se_play("SE_ADV_MA_01A111_14_sword_01")
wait_time(0.2)
show_image("101030440", 0.0, 0.0, 0 ,true,false) 
fadein(0.5)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ライエンス王★★:アアアアアアアアアアアアアアアッッ！？！？
	Talk(Actor004,"CHRNAME_LAIENS","simple","N","MA_01A111_140018")

-- ▼直接出力
set_animationbattlecontroller(Actor004, 1)
PlayActionDirect(Actor004,"ToAbnormal")
SkipDefaultMotion(Actor004)
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ライエンス", "落胆")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ライエンス王★★:こ、こ、ここは、我が根城…！<br>大陸の支配者気取りの輩が、よくも、よくもォ…
	Talk(Actor004,"CHRNAME_LAIENS","simple","N","MA_01A111_140020")

	change_face(Actor001,"Serious")

	--★★ヴェルナルス★★:あの御方曰く<br>ブリテンはもとよりローマのものだ
	Talk(Actor001,"CHRNAME_VERNARTH","simple","N","MA_01A111_140021")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1,0.5)
se_play("SE_ADV_MA_01A111_14_sword_02")
wait_time(0.5)
hide_image(0)
setup_small_camera_start()
fadein(0.5)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ライエンス", "苦しみ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ライエンス王★★:ゆえに…死にぞこないよ
	Talk(Actor004,"CHRNAME_LAIENS","speech","R","MA_01A111_140023")

	change_face(Actor004,"Sad")

	--★★ライエンス王★★:ユーサーの時代に、貴様らローマの<br>ブリテンに…おける、進退は既に決まっていた…
	Talk(Actor004,"CHRNAME_LAIENS","speech","R","MA_01A111_140024")


	--★★ライエンス王★★:ルーシャスの理想は…真実に眼を伏せた妄執<br>ただの、幻、叶うべくもない…
	Talk(Actor004,"CHRNAME_LAIENS","speech","R","MA_01A111_140025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ライエンス王★★:夢…そのもの──
	Talk(Actor004,"CHRNAME_LAIENS","speech","R","MA_01A111_140026")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.5)
wait_time(0.5)
show_image("101030450", 0.0, 0.0, 0 ,true,false) 
se_play("SE_ADV_MA_01A111_14_Fall")
wait_time(CHARA_IN_WAIT + 1.0)
Hide(Actor004)
turn_lookat(Actor002,Actor001,0)
turn(Actor001,0,120, 0,0)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.7)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.7)
off_active(Ef_Aura_Enemy) 
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
 --PlayPartVoice("グリーテン", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★グリーテン★★:………チッ
	Talk(Actor003,"CHRNAME_SISTERS_3","simple","N","MA_01A111_140028")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.5)
wait_time(0.5)
hide_image()
off_active(sword001) 
off_parent(sword001)
setup_small_camera_start()
on_active(Ef_Witch_Out)
wait_time(2.0)
fadein(CHARA_IN_OUT)
off_active(Ef_Witch_Out)
wait_time(0.5)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴェルナルス★★:怪我はないか、ラシア
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140030")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラシア★★:お見事です。将軍
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A111_140031")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ヴェルナルス★★:…バルバロイの雑兵程度、造作もない
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140032")


	--★★ラシア★★:聖杯取得前にとんだ邪魔が入りましたね
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A111_140033")


	--★★ヴェルナルス★★:いいや、そうでもない
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140034")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:え…？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A111_140035")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:ＧＳを果たした騎士どもは<br>この程度ではなかった、それがはっきりした
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラシア★★:………はい
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A111_140038")


	--★★ヴェルナルス★★:存在を懸けた力<br>かつてのローマには授けられなかった力
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140039")


	--★★ヴェルナルス★★:ゆえにルーシャス様は<br>今のローマに魔女とバルバロイの力を欲した
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140040")


	--★★ヴェルナルス★★:ルーシャス様は勝者として喰らうだろう<br>化け物となってでも…ブリテンのすべてを
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴェルナルス★★:だがこのままでは<br>私は、人としては、将としては──…
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140042")

-- ▼直接出力
 --PlayPartVoice("ラシア", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:…ヴェルナ叔父様
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A111_140044")

-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴェルナルス★★:いいや、ラシア<br>思わぬことを口走った
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140045")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス★★:忘れてくれ
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A111_140046")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Aura_Enemy_Lop", false, true)
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
sword001_offset  = {-0.07,-0.02,0,0,-170,0}
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
sword002_offset  = {-0.07,-0.02,0,0,-170,0}
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
sword003_offset  = {-0.07,-0.02,0,0,-170,0}
load_image_preload("101030440", "content_still_10103044_image", "101030440_StillImage")
load_image_preload("101030450", "content_still_10103045_image", "101030450_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Portal_Witch", false, true)
	InitializeLoad_Preload()
	load_duel_scene_preload(101090011)
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101044","001","101044001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101058","002","101058002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401040","001","401040001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
