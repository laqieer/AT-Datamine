-- このluaスクリプトは、EA_066_042.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor004",108,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_weight(Actor004,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Nature_Start")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_TextOnly()
	Actor002 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:「覚悟を決めよ<br>その覚悟こそが可能性を広げる劒となる」
	Talk(Actor001,"","simple","N","EA_066_0420002")


	--★★テロップ★★:「己が心の内にある鞘から劔を抜くとき<br>その覚悟は山をも砕くだろう」
	Talk(Actor001,"","simple","N","EA_066_0420003")


	--★★テロップ★★:「あらゆる覚悟は尊ばれ<br>何人もこれを侵すことは許されない」
	Talk(Actor001,"","simple","N","EA_066_0420004")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ヴォールス★★:…覚悟、か――
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0420005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,0)
wait_time(0)
hide_image(0.0)
setup_small_camera_start(Camera001)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Worry")
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_Nature_Start")
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101025_sp_0002_1")
-- ▲直接出力

	--★★クレア★★:ヴォールス？
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0420009")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0030")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ヴォールス★★:…！どうかしたか
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0420010")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0025")
-- ▲直接出力

	--★★ラロゥ★★:それはこっちの台詞だよ。解読が終わったって<br>何度も呼んでるのに全然返事しないんだから
	Talk(Actor004,"CHRNAME_LAROU","speech","L","EA_066_0420011")


	--★★ラロゥ★★:あんまりぼーっとしてるから<br>クレアなんて着替えまで済ませちゃったよ
	Talk(Actor004,"CHRNAME_LAROU","speech","L","EA_066_0420012")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0037")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ヴォールス★★:すまん。もう終わったのか
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0420013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor004, true)
PlayPartVoiceDirect("クレア","0009")
-- ▲直接出力

	--★★クレア★★:ええ。妖精の導きにより奇跡をここに封じる――<br>この暗号は遺跡の場所を示すもののようね
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0420014")


	--★★クレア★★:ただ、急いだほうがいいわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0420015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0054")
-- ▲直接出力

	--★★ヴォールス★★:どういうことだ？
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0420016")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0051")
-- ▲直接出力

	--★★クレア★★:この石板、ずっと水の中に沈んでいたにしては<br>不自然な点があるの
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0420017")


	--★★クレア★★:掘られた文字の隙間に入り込んだ土…<br>これは粒度から考えて水底のものではないわ
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0420018")


	--★★クレア★★:それがここまで残ってる<br>まるでついさっき水の中に投げ込まれたみたいに
	Talk(Actor003,"CHRNAME_CLARE","speech","L","EA_066_0420019")

-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0028")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラロゥ★★:それって…！
	Talk(Actor004,"CHRNAME_LAROU","speech","L","EA_066_0420020")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0046")
-- ▲直接出力

	--★★ヴォールス★★:…足止めのつもりか<br>行こう、ふたりとも
	Talk(Actor002,"CHRNAME_BORS","speech","L","EA_066_0420021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
preload_sound("BGM_Battle_Nature_Start")
	InitializeLoad_Preload()
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
