-- このluaスクリプトは、EA_066_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation11","DuelCommonFormation11_h")
Include("content_adv_advsmall_duelcommonformation11","TemplateDuelCommonFormation11_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation11_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation11_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation11_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation11_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_506_01_e0066_01_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation11_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_010)
	Camera006 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation11_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_e0066_01_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_002)
	Camera007 = SetTemplate("Actor009",nil,CharaPosDuelCommonFormation11_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation11,CameraPosDuelCommonFormation11_004)
	InitializeTemplateRandomCameraDuelCommonFormation11()
	InitializeTemplateDuelCommonFormation11()
-- ▼直接出力
Hide(Actor004)
Hide(Actor005)
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
seihai = setup_prop_object(10201022)
Ef_Holy01 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", false, true)
Ef_Holy02 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail02", false, true)
Ef_HolyLight = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
set_pos(seihai,CharaPosDuelCommonFormation11_010)
set_pos(Ef_Holy01,CharaPosDuelCommonFormation11_010)
set_pos(Ef_Holy02,CharaPosDuelCommonFormation11_010)
set_pos(Ef_HolyLight,CharaPosDuelCommonFormation11_010)
Hide(seihai)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Boss_Start")
-- ▲直接出力
-- ▼直接出力
Hide(Actor009)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101030011)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("201025","001","201025001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	Actor007 = InitializeCharacter_TextOnly()
	Actor008 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101025","002","101025002","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0009")
-- ▲直接出力

	--★★ラロゥ★★:…この遺跡、元はなんだったんだろ<br>罠やら仕掛けやらがやけに多いんだけど
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0510003")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力

	--★★ヴォールス★★:ラロゥが都度解除してくれなければ<br>探索に手間取っていただろうな
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510004")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0036")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ヴォールス★★:本当に助かった。礼を言う
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510005")

-- ▼直接出力
change_face(Actor001,"Normal")
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0007")
-- ▲直接出力

	--★★ラロゥ★★:お互い様。その分、魔物やローマ兵の相手は<br>アンタたちに任せてるからね
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0510006")


	--★★ラロゥ★★:けどローマ兵はもうほとんどいないね<br>あいつら、奥までは辿り着いてなかったんだ
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0510007")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ラロゥ★★:なら聖杯はまだ無事かな<br>今のところそれらしいものは見当たらないけど…
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0510008")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
PlayPartVoiceDirect("クレア","0002")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:…見て、あれ――
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0510009")

-- ▼直接出力
CloseTalkWindow()
on_active(Ef_Holy01)
play_particle(Ef_Holy01)
on_active(Ef_Holy02)
play_particle(Ef_Holy02)
Appear(seihai)
setup_small_camera_start(Camera005)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0030")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ヴォールス★★:…！これは――…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510011")

	change_face(Actor003,"Surprise")

	--★★ラロゥ★★:すごい輝き…それに、なんだろう――<br>ただならぬオーラを感じる
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0510012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ラロゥ★★:これ、ひょっとして本当に…！
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0510013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0034")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:…まずは確かめてみないと
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0510014")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002,{0.0,0.0,-2.0},1.0)
wait_time(1.0)
PlayActionDirect(Actor002,"to Std_Loop")

on_active(Ef_HolyLight)
play_particle(Ef_HolyLight)

se_play("SE_ADV_EA_066_051_Explosion")

shake_camera(RndCamera090, 1.0, 5.0)
wait_time(0.5)
se_play("SE_ADV_MA_01A900_25_Earthquake_loop")
wait_time(4.5)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0028")
-- ▲直接出力

	--★★ラロゥ★★:な、なに！？<br>なんか、ヤバい空気なんだけど！？
	Talk(Actor003,"CHRNAME_LAROU","speech","L","EA_066_0510020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:…！<br>「望みを叶えたくば知恵と力を守護者に示せ」
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0510021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0061")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:聖杯に辿り着くまでが『知恵』とすれば<br>これからわたしたちが試されるのは――
	Talk(Actor002,"CHRNAME_CLARE","speech","L","EA_066_0510022")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ヴォールス★★:ふたりとも、伏せろ！
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510023")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, 0.5)
wait_time(0.5)
se_play("SE_ADV_Loop_Stop")
set_pos(Actor002,CharaPosDuelCommonFormation11_004)
PlayActionDirect(Actor001,"to Std_Squareoff_Loop")
PlayActionDirect(Actor002,"to Std_Squareoff_Loop")
SkipDefaultMotion(Actor001)
SkipDefaultMotion(Actor002)
Hide(Actor003)
Appear(Actor008)
Appear(Actor004)
PlayActionDirect(Actor004,"to std01_Start_pose")
setup_small_camera_start(RndCamera011)
wait_time(1.0)
fadein(0.5)
PlayActionDirect(Actor004,"to std01_Start")
se_play("SE_ADV_MA_Urery_Emy501_Roar")
wait_time(2.0)
-- ▲直接出力
	open_cutin(3,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor002,"Surprise")
	on_cutin(3,Actor008,"Surprise")

	--★★全員★★:！！！！！
	Talk(Actor007,"NPCNAME_0394","speech","N","EA_066_0510025")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to std01yell")
se_play("SE_ADV_MA_Urery_Emy501_Roar")
wait_time(1.5)
PlayActionDirect(Actor008,"to sit10_Start")
wait_time(0.8)
se_play("SE_ADV_MA_01B112_38_Kneeling")
bgm_play("BGM_Battle_Boss_Start")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0044")
-- ▲直接出力

	--★★ラロゥ2★★:うわあああ！
	Talk(Actor008,"CHRNAME_LAROU","speech","L","EA_066_0510027")


	--★★ヴォールス★★:ラロゥ！大丈夫か！？
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Sad")

	--★★ラロゥ2★★:な、なんとか…でも、ちょっと立てないかも<br>身体、ビリビリする――
	Talk(Actor008,"CHRNAME_LAROU","speech","L","EA_066_0510029")

-- ▼直接出力
PlayPartVoiceDirect("ラロゥ","0030")
-- ▲直接出力

	--★★ラロゥ2★★:あいつ、なに…！？<br>デカすぎて、鳴き声だけで空気が割れそう…
	Talk(Actor008,"CHRNAME_LAROU","speech","L","EA_066_0510030")

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0009")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ヴォールス★★:下がっていろ<br>この場は俺たちが引き受ける
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510031")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera011)
wait_time(0.5)
fadeout(255,255,255,1.0,FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.3)
Hide(Actor002)
Appear(Actor009)
wait_time(0.3)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor009, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クレア","0034")
-- ▲直接出力
	change_face(Actor009,"Anger")

	--★★クレア2★★:とはいえどうしたものかしら
	Talk(Actor009,"CHRNAME_CLARE2","speech","L","EA_066_0510032")


	--★★クレア2★★:圧倒的な力、脅威…まさに伝承上の魔獣ね<br>あの巨体に斧や槍が通るとは思えない
	Talk(Actor009,"CHRNAME_CLARE2","speech","L","EA_066_0510033")


	--★★クレア2★★:ブレイズ先生が言うには<br>強大な魔法ならドラゴンも倒せるらしいけど…
	Talk(Actor009,"CHRNAME_CLARE2","speech","L","EA_066_0510034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0034")
-- ▲直接出力

	--★★ヴォールス★★:ドラゴン…嫌な記憶だな
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510035")


	--★★ヴォールス★★:あのときは円卓の仲間がいた<br>…継承者が、いた。だが――
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510037")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴォールス★★:（だが、今は俺とクレアだけだ）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0510038")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ヴォールス★★:（聖杯を見つけ出すことすらできず<br>バルバロイを倒し切る力もない）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0510039")


	--★★ヴォールス★★:（そんな俺が、勝てるというのか<br>こんな強大な存在に）
	Talk(Actor001,"CHRNAME_BORS","mind","L","EA_066_0510040")


	--★★テロップ★★:強大な魔法の力があれば<br>魔法でなくてもいい、もっと強い力――
	Talk(Actor006,"","narration","N","EA_066_0510041")

-- ▼直接出力
setup_small_camera_start(RndCamera011)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0043")
-- ▲直接出力
	change_face(Actor009,"Surprise")

	--★★クレア2★★:…！？ヴォールス、危ない！
	Talk(Actor009,"CHRNAME_CLARE2","speech","L","EA_066_0510042")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to std01yell")
se_play("SE_ADV_MA_Urery_Emy501_Roar")
wait_time(0.3)
fadeout(255,255,255,1.0, 0.5)
wait_time(0.5)
Actor001.SetSkipDefautTrigger(1)
Actor007.SetSkipDefautTrigger(1)
PlayActionDirect(Actor009,"to Sit10")
se_play("SE_ADV_MA_01C900_19_Punch")
wait_time(0.8)
se_play("SE_ADV_MA_01B112_38_Kneeling")
fadein(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クレア_003","0044")
-- ▲直接出力
	change_face(Actor009,"Pain")

	--★★クレア2★★:ああああああッ！？
	Talk(Actor009,"CHRNAME_CLARE2","speech","L","EA_066_0510044")

	PlayAction(Actor001,"to TakeHand")
-- ▼直接出力
voice_play("VO_101024_sp_0002_2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ヴォールス★★:クレア！！
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510045")

	play_head_motion(Actor009, "No", 0.3, 1.0, false)

	--★★クレア2★★:だい、じょうぶ…かすり傷よ<br>それより――
	Talk(Actor009,"CHRNAME_CLARE2","speech","L","EA_066_0510046")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to std01yell")
se_play("SE_ADV_MA_Urery_Emy501_Roar")
wait_time(1.0)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor009,"to Std_Squareoff_Loop")
-- ▲直接出力
	PlayAction(Actor001,"to Std_Squareoff_Loop")
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0015")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ヴォールス★★:…！
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0510048")


	--★★テロップ★★:だが俺には、そんな力は無い
	Talk(Actor006,"","narration","N","EA_066_0510049")


	--★★テロップ★★:選ばれしものではない俺の力は及ばず<br>だからあのとき、俺は――
	Talk(Actor006,"","narration","N","EA_066_0510050")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10201022)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail02", false, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail_ForcefulLight", false, true)
preload_sound("BGM_Battle_Boss_Start")
	InitializeLoad_Preload()
	load_duel_scene_preload(101030011)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("201025","001","201025001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101025","002","101025002","content_animationpack__common","FacialPack","Actor009")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation11)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
