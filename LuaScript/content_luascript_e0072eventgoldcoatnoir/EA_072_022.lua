-- このluaスクリプトは、EA_072_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111012_08","111012_08_h")
Include("content_adv_advsmall_111012_08","Template111012_08_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111012_08_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_012)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111012_08_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111012_08_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111012_08_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName111012_08,CameraPos111012_08_001)
	InitializeTemplateRandomCamera111012_08()
	InitializeTemplate111012_08()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage") --黒バック
load_image("101030020", "content_still_10103002_image", "101030020_StillImage") --【さよならクイーンルーム４・ギネヴィア大演説、離縁と勝利への縁結び】
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2")
load_sound("BGM_ADV_Painful2")
load_sound("BGM_Battle_Noir")
-- ▲直接出力
-- ▼直接出力
sword001 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
on_parent(sword001,Actor001, "J_Hand_R", {-0.07,-0.02,0,0,-170,0})

sword002 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
on_parent(sword002,Actor002, "J_Hand_R", {-0.07,-0.02,0,0,-170,0})
sword003 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
on_parent(sword003,Actor003, "J_Hand_R", {-0.07,-0.02,0,0,-170,0})
sword004 = set_object("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
on_parent(sword004,Actor004, "J_Hand_R", {-0.07,-0.02,0,0,-170,0})
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor002, 1)

PlayActionDirect(Actor003,"to Sit10")
SkipDefaultMotion(Actor003)
wait_time(0.3)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111012)
	Actor001 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("兵士1","0032")
-- ▲直接出力

	--★★カレドニア兵B★★:つ、強すぎる………！！
	Talk(Actor002,"NPCNAME_0398","speech","N","EA_072_0220002")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
SkipDefaultMotion(Actor004)
-- ▲直接出力

	--★★カレドニア兵A★★:け、継承者…貴様は世界を救うべく<br>キラーズを手放したと聞いたぞ…！？
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220003")

-- ▼直接出力
PlayPartVoiceDirect("兵士2","0024")
-- ▲直接出力

	--★★カレドニア兵A★★:なぜ、こんなにも強い…！？<br>我ら精鋭が手も足も出ぬほど──
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0017")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:…キャメリアード城内のカレドニア兵は鎮圧した<br>長城にいるというライエンスの正体を吐け
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0220005")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("兵士2","0013")
-- ▲直接出力

	--★★カレドニア兵A★★:………あの御方の正体、だと？
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:お前が言ったとおり、俺は世界を救うべく<br>キラーズを手放し…バルバロイを封じた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0220007")

	PlayAction(Actor001,"to Std_Squareoff_Loop")
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:だからバルバロイに侵されていたライエンスも<br>もう生きているはずがないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0220008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
bgm_play("BGM_ADV_Serious2")
PlayPartVoiceDirect("兵士2","0010")
-- ▲直接出力

	--★★カレドニア兵A★★:我らが王は<dot>蘇った</dot>のだ<br>湖の妖精の力でな
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0020")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:…妖精にそんな力はない<br>妄言はやめろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0220011")


	--★★カレドニア兵A★★:生前となんら変わらぬ姿でおられるよ<br>纏う衣服も、その喋りかたもな
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220012")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★カレドニア兵A★★:幽霊の類では決してない
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0220014")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("兵士2","0011")
-- ▲直接出力

	--★★カレドニア兵A★★:ログレスの疲弊を待ち、ローマ残党をも取り込み<br>これより復讐を始めようとしているのだ
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220015")


	--★★カレドニア兵B★★:ここにもすぐに<br>アントニヌス・ウォールからの増援が来る
	Talk(Actor002,"NPCNAME_0398","speech","N","EA_072_0220016")

-- ▼直接出力
PlayPartVoiceDirect("兵士1","0013")
-- ▲直接出力

	--★★カレドニア兵B★★:貴様ひとりで<br>止め切れる兵力ではないぞ
	Talk(Actor002,"NPCNAME_0398","speech","N","EA_072_0220017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor004)
-- ▲直接出力

	--★★カレドニア兵A★★:世界は変わった。平和になった。貴様のおかげだ<br>バルバロイも消え去った。貴様がやったのだ
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220018")


	--★★カレドニア兵A★★:おかげで随分<br>動きやすくなった
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("兵士2","0011")
-- ▲直接出力

	--★★カレドニア兵A★★:この我らの蜂起はいわば<br>貴様が化け物を消したせい、というわけだ
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220020")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0024")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:………俺の、せい…？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","EA_072_0220021")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
show_image("101010140", 0.0, 0.0, 0.3,false,false)
set_scale_image(20,20)
wait_time(0.3)
close_cutin()
CloseTalkWindow()
wait_time(1.0)
PlayPartVoiceDirect("兵士2","0035")
-- ▲直接出力

	--★★カレドニア兵A★★:消し去った責任を取り、死ね。継承者
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0220023")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
wait_time(2.0)
bgm_play("BGM_ADV_Painful2")
show_image("101030020", 0.0, 0.0, 0,false,false)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ノワール★★:キミを変え、キミを消した
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0220026")


	--★★テロップ★★:「消し去った責任を取り、死ね」
	Talk(Actor005,"","simple","N","EA_072_0220027")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力

	--★★ノワール★★:確かに、ライエンスとの戦いで<br>キミを選ばなければキミは消えなかった
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0220028")


	--★★ノワール★★:そのほうが良かったのか？
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0220029")


	--★★ノワール★★:…そんなはずはない<br>そう、ふたりで答えを出した
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0220030")


	--★★ノワール★★:キミを忘れないように<br>思い出しては繰り返した
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0220031")


	--★★ノワール★★:だけど<br>どこへいっても──
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0220032")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
voice_play("VO_101009_sp_0002_3")
-- ▲直接出力

	--★★ノワール★★:キミのいない旅が続く
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0220033")

-- ▼直接出力
bgm_play("BGM_Battle_Noir")
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
load_image_preload("101030020", "content_still_10103002_image", "101030020_StillImage")
preload_sound("BGM_ADV_Serious2")
preload_sound("BGM_ADV_Painful2")
preload_sound("BGM_Battle_Noir")
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_001", "Wpn_01_swd_001", true)
	InitializeLoad_Preload()
	load_area_scene_preload(111012)
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111012_08)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
