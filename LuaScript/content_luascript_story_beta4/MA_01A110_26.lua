-- このluaスクリプトは、MA_01A110_26.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Ef_0001 =　load_particle("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, false)
on_parent(Ef_0001, Actor003, "J_Hips", 0.198, -0.157, -0.188, 0,0,0)
off_active(Ef_0001)
-- ▲直接出力
-- ▼直接出力
Ef_0002     = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Slash01", false, false)
set_pos(Ef_0002,{-3,1.52,0.23})
set_rot(Ef_0002,{54, 0, 0})
-- ▲直接出力
-- ▼直接出力
Ef_0003     = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Sla", false, false)
set_pos(Ef_0003,{-1.63,1.1,0.26})
set_rot(Ef_0003,{0, 100, 12})
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("グリートーネア", "肯定")
-- ▲直接出力

	--★★グリートーネア★★:仲良くしたいんです、ネアは
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260002")

-- ▼直接出力
 --PlayPartVoice("ラシア", "否定")
-- ▲直接出力

	--★★ラシア★★:どいて、ください
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "落胆")
-- ▲直接出力

	--★★グリートーネア★★:あなたは覚悟を決めて道を選んだのに<br>ろくに役にも立たず、逃げて来た
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:やめて、ください
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260005")

-- ▼直接出力
 --PlayPartVoice("グリートーネア", "悲しみ")
-- ▲直接出力

	--★★グリートーネア★★:同じ境遇にいると思っていた彼女は既に美しくて<br>お友達はひとあし先に行ってしまった
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260006")

-- ▼直接出力
 --PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:やめて
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260008")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "肯定3")
-- ▲直接出力

	--★★グリートーネア★★:その姉は皇太子殿下に小鳥と可愛がられ<br>あなただけが違う、あなただけが醜く見苦しい
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ラシア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラシア★★:やめて！！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260010")

-- ▼直接出力
 --PlayPartVoice("グリートーネア", "否定")
-- ▲直接出力

	--★★グリートーネア★★:あなたは巨大なチカラを秘めているのに<br>アイツらをまとめて倒せるくらいのチカラを
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:私が…？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "肯定2")
-- ▲直接出力

	--★★グリートーネア★★:人間、食材の新鮮さがわかるように<br>ネアたち、活きの良い因子がわかるんです
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260013")


	--★★グリートーネア★★:貴方は自らを抑えつけている<br>ネアたちなら貴方を救ってあげられる
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260014")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("グリートーネア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★グリートーネア★★:チカラが──欲しいでしょ？
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260015")

	change_face(Actor002,"Normal")

	--★★ラシア★★:チカラ…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260016")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera003)
wait_time(0.2)
on_active(Ef_0002)
se_play("SE_ADV_MA_01A111_14_sword_02")
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
on_active(Ef_0003)
wait_time(0.2)
set_battlecontroller(Actor003,"fig_mbo","AC_TL_Fig_Mbo_Idle_Run_F","ToAbnormal")
 --PlayPartVoice("グリートーネア", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★グリートーネア★★:なっ………！
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260018")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★グリートーネア★★:どうして…ネアはルーシャス様が…<br>あなたの主が望むようにしてあげたのに…
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260020")

-- ▼直接出力
 --PlayPartVoice("グリートーネア", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★グリートーネア★★:彼が望んで、ネアを求めたから<br>ほかの姉妹の誰でもなくネアを…だから――
	Talk(Actor003,"CHRNAME_SISTERS_4","speech","L","MA_01A110_260021")

-- ▼直接出力
on_active(Ef_0001)
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
Appear(Actor001)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0)
lookWeight = {1.2, 0, 0.3, 0.5}
lookat_delay_weight(Actor001, lookWeight,0)
turn_chara(Actor002,-118,0)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",100)
lookat_delay_weight(Actor002, lookWeight,0)
setup_small_camera_start()
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
 --PlayPartVoice("ヴェルナルス", "否定")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ヴェルナルス★★:魔女の嫉心ゆえの浅知恵に<br>これ以上身を削ることはない。退くぞ
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A110_260023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ラシア", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラシア★★:ま、待ってください！<br>まだ私は――
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260024")

-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴェルナルス★★:そもそもこの戦いは<br><ruby=ゲシュタルト・シフト>ＧＳ</ruby>の重要性を見極めるためのものだった
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A110_260025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ヴェルナルス★★:お前はじゅうぶんな働きをしたうえで<br>退き際を見定める目を持っていた。誇れ
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A110_260027")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ラシア", "落胆")
-- ▲直接出力

	--★★ラシア★★:…ごめんなさい、ヴェルナルス様
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴェルナルス★★:…退かず立ち向かった者を悪く言う気もないがな<br>彼女は気の毒だったが、回収した
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A110_260030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ヴェルナルス★★:１度くらい負けたといって滅入る必要はない<br>…勝ったとしても驕るべきではないがな
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A110_260032")

-- ▼直接出力
 --PlayPartVoice("ラシア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラシア★★:魔女は…どうします
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260033")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ヴェルナルス", "肯定")
-- ▲直接出力

	--★★ヴェルナルス★★:ああ、しまった<br>ついやってしまったな
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A110_260034")


	--★★ヴェルナルス★★:黙っていてくれるか、ラシア
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A110_260035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラシア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラシア★★:ええ…っ？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260036")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
lookat_weight_default(Actor001)
 --PlayPartVoice("ヴェルナルス", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ヴェルナルス★★:口実が思いつかないのでな
	Talk(Actor001,"CHRNAME_VERNARTH","speech","L","MA_01A110_260037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラシア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラシア★★:…はい、ヴェルナルス様
	Talk(Actor002,"CHRNAME_RASIA","speech","L","MA_01A110_260039")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Die_Witch", false, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Slash01", false, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Hit_Witch_Sla", false, false)
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
