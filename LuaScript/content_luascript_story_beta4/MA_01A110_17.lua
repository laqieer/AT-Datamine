-- このluaスクリプトは、MA_01A110_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111042_01","111042_01_h")
Include("content_adv_advsmall_111042_01","Template111042_01_h")
Include("content_adv_advsmall_111042_02","111042_02_h")
Include("content_adv_advsmall_111042_02","Template111042_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111042_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111042_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111042_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111042_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111042_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111042_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111042_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_002)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111042_01_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_009)
	Camera009 = SetTemplate("Actor009",nil,CharaPos111042_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_001)
	Camera010 = SetTemplate("Actor010",nil,CharaPos111042_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName111042_01,CameraPos111042_01_001)
	InitializeTemplateRandomCamera111042_01()
	InitializeTemplate111042_01()
-- ▼直接出力
prop001 = setup_prop_object(10201007)
set_pos(prop001 , {3.46,32.1,-4.28})
set_rot(prop001,{0, 180, 0})
prop002 = setup_prop_object(10201007)
set_pos(prop002 , {9.33,32.1,-4.28})
set_rot(prop002,{0, 180, 0})
prop003 = setup_prop_object(10201007)
set_pos(prop003 , {-3.85,32.1,-4.28})
set_rot(prop003,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
cameraV = set_camera({4.694, 1.293, -32.442,   359.727, 140.4116, 0.34644,   30.36522})
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
Hide(Actor005)
Hide(Actor008)
Hide(Actor009)
Hide(Actor010)
Hide(Actor006)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
prop004 = setup_prop_object(10201007)
set_pos(prop004 , {-9.71,32.1,-4.28})
set_rot(prop004,{0, 180, 0})
prop005 = setup_prop_object(10201007)
set_pos(prop005 , {19.91,39.38,-6.53})
set_rot(prop005,{0, 180, 0})
prop006 = setup_prop_object(10201007)
set_pos(prop006 , {42.74,35.43,-3.91})
set_rot(prop006,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_delay_weight(Actor002, {1.0, 0.08, 0.5, 0.6} ,1.0)
-- ▲直接出力
-- ▼直接出力
Camera_EX02 = set_camera({9.63,2.28,-25.39, 11.978,-47.703,0, 15.75258})
-- ▲直接出力
-- ▼直接出力
prop007 = setup_prop_object(10201007)
set_pos(prop007 , {-20.02, 37.78, -5.99})
set_rot(prop007,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop008 = setup_prop_object(10201007)
set_pos(prop008 , {-29.04, 27.59, 0.25})
set_rot(prop008,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop009 = setup_prop_object(10201007)
set_pos(prop009 ,{-34.39, 27.59, 0.25})
set_rot(prop009,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop010 = setup_prop_object(10201007)
set_pos(prop010 ,{19.66, 38.87, -8.64})
set_rot(prop0010,{0, 180, 0})
prop011 = setup_prop_object(10201007)
set_pos(prop011 ,{29.05, 27.99, 0.37})
set_rot(prop011,{0, 180, 0})
prop012 = setup_prop_object(10201007)
set_pos(prop012 ,{35.47, 27.99, 0.37})
set_rot(prop012,{0, 180, 0})
prop013 = setup_prop_object(10201007)
set_pos(prop013 ,{0.23, 31.1, 1.99,   180})
set_rot(prop013,{0, 180, 0})
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111042_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_012)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111042_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111042_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_013)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111042_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111042_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111042_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111042_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos111042_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_001)
	Camera009 = SetTemplate("Actor009",nil,CharaPos111042_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_004)
	Camera010 = SetTemplate("Actor010",nil,CharaPos111042_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName111042_02,CameraPos111042_02_004)
	InitializeTemplateRandomCamera111042_02()
	InitializeTemplate111042_02()
-- ▼直接出力
load_sound("BGM_Battle_AfterGinevia_General2_Start")
-- ▲直接出力
-- ▼直接出力
Ef_Emblem01 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false)
set_rot(Ef_Emblem01,{0, 125, 0})
-- ▲直接出力
-- ▼直接出力
Ef_Emblem02 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false)
set_rot(Ef_Emblem02,{0, -50, 0})
-- ▲直接出力
-- ▼直接出力
Ef_Emblem03 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
set_pos(Ef_Emblem03,{5.285, 0, -21.992,   145})
-- ▲直接出力
-- ▼直接出力
Ef_Emblem04 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
set_pos(Ef_Emblem04,{5.285, 0, -21.992,   145})
-- ▲直接出力
-- ▼直接出力
Ef_Emblem05 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
set_pos(Ef_Emblem05,{5.285, 0, -21.992,   145})
slidemove(Ef_Emblem05,CharaPos111042_02_004[1],1.21,CharaPos111042_02_004[3],0)
-- ▲直接出力
-- ▼直接出力
Camera_EX01 = set_camera({9.48,1.42,-19.46, 0,265.335,0, 17.14272})
-- ▲直接出力
-- ▼直接出力
Camera_EX02 = set_camera({9.63,2.28,-25.39, 11.978,-47.703,0, 15.75258})
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor006,Actor003,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor007,Actor003,0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007,false)
-- ▲直接出力
-- ▼直接出力
prop001 = setup_prop_object(10201007)
set_pos(prop001 ,{3.46,32.1,-4.28})
set_rot(prop001,{0, 180, 0})
prop002 = setup_prop_object(10201007)
set_pos(prop002 ,{9.33,32.1,-4.28})
set_rot(prop002,{0, 180, 0})
prop003 = setup_prop_object(10201007)
set_pos(prop003 ,{-3.85,32.1,-4.28})
set_rot(prop003,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop004 = setup_prop_object(10201007)
set_pos(prop004 ,{-9.71,32.1,-4.28})
set_rot(prop004,{0, 180, 0})
prop005 = setup_prop_object(10201007)
set_pos(prop005 ,{19.91,39.38,-6.53})
set_rot(prop005,{0, 180, 0})
prop006 = setup_prop_object(10201007)
set_pos(prop006 ,{42.74,35.43,-3.91})
set_rot(prop006,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop007 = setup_prop_object(10201007)
set_pos(prop007 , {-20.02, 37.78, -5.99})
set_rot(prop007,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop008 = setup_prop_object(10201007)
set_pos(prop008 , {-29.04, 27.59, 0.25})
set_rot(prop008,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop009 = setup_prop_object(10201007)
set_pos(prop009 ,{-34.39, 27.59, 0.25})
set_rot(prop009,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop011 = setup_prop_object(10201007)
set_pos(prop011 ,{29.05, 27.99, 0.37})
set_rot(prop011,{0, 180, 0})
prop012 = setup_prop_object(10201007)
set_pos(prop012 ,{75.56, 35.9, -3.27,   180})
set_rot(prop012,{0, 180, 0})
prop013 = setup_prop_object(10201007)
set_pos(prop013 ,{35.76, 28.22, 0.12})
set_rot(prop013,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop014 = setup_prop_object(10201007)
set_pos(prop014 ,{-20.02, 38.66, -5.99})
set_rot(prop014,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop015 = setup_prop_object(10201007)
set_pos(prop015 ,{-39.52, 27.59, 0.25})
set_rot(prop015,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop016 = setup_prop_object(10201007)
set_pos(prop016 ,{50.1, 27.57, 1.55})
set_rot(prop016,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop017 = setup_prop_object(10201007)
set_pos(prop017 ,{56.03, 27.7, 1.55})
set_rot(prop017,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop018 = setup_prop_object(10201007)
set_pos(prop018, {62.57, 27.7, 1.55})
set_rot(prop018,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop019 = setup_prop_object(10201007)
set_pos(prop019, {69.34, 27.7, 1.55})
set_rot(prop019,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
prop020 = setup_prop_object(10201007)
set_pos(prop020, {75.5, 35.78, 1.55})
set_rot(prop020,{0, 180, 0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{6.26, 0, -19.95,   135.538})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111042)
	Actor001 = InitializeCharacter_3D("101045","001","101045001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101031","002","101031002","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_TextOnly()
	Actor012 = InitializeCharacter_2DOnly("101013","001","101013001")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★グリートーネア★★:素敵な壁。とっても
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170002")


	--★★グリートーネア★★:奴らのカレドニア城への侵攻を妨害しつつ<br>聖杯探索を邪魔するなら進路を塞げばいいんです
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170003")

	change_face(Actor001,"Normal")

	--★★グリートーネア★★:みんな馬鹿にするけど<br>ネアだってこれくらい思いつくんですよ
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ラシア★★:見かけ倒しです。これでは<br>時間も足らず、バルバロイも集め切れていない
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170005")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★グリートーネア★★:ルーシャス様が期待し、任せてくれたんです<br>この作戦を…他の誰でもなくこのネアに！
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170006")


	--★★ラシア★★:「丸投げされた」の間違いでは？<br>おかげで将軍はあなたのお目付け役として──
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170007")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★グリートーネア★★:仲良くしましょうよ、ラシア<br>あの子みたいに…♪
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170009")

	change_face(Actor002,"Anger")

	--★★ラシア★★:…あなた、ローラになにを言ったの
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170011")

	change_face(Actor001,"Normal")

	--★★グリートーネア★★:ただちょっとアドバイスをしただけですよ？<br>ネアは姉様やほかの妹たちと違って親切ですから
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170012")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★ガウェイン02★★:会えて嬉しいぜ
	Talk(Actor012,"CHRNAME_GAWAIN","speech","L","MA_01A110_170014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(2.0)
template2()
lookat_delay_weight_reset(Actor002 , 0.6)    
on_active(Actor008)
    on_active(Actor004)
    on_active(Actor005)
    on_active(Actor009)
    on_active(Actor006)
    on_active(Actor007)
setup_small_camera_start(Camera_EX01)
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力

	--★★ラグネル★★:顔を見せてよ
	Talk(Actor007,"CHRNAME_RAGNAR","speech","L","MA_01A110_170015")


	--★★ヴェルナルス★★:………ガウェイン、ラグネル
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170016")

-- ▼直接出力
setup_small_camera_end(Camera_EX01)
CloseTalkWindow()
setup_small_camera_start()
wait_time(1.4)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:…よォ、師匠
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01A110_170017")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ラシア★★:「平和を愛する、聖なる騎士たちに告げる<br>座を退き、跪け」
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170019")


	--★★ラシア★★:「余は『ローマの平和』の<br>速やかなる完遂を望んでいる」
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170021")


	--★★ラシア★★:「長年続いた島の内乱を<br>収束させたアーサー王は大義である」
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170023")


	--★★ラシア★★:「元ローマ領・ブリテンを掌握した貴国には<br>現ローマ大帝国へ貢物献上の義務が発生する」
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170024")


	--★★ラシア★★:「貴国の懸命な判断に期待する」
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor008,"Surprise")

	--★★エレイン★★:………ラシア、さん…？
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A110_170026")

	change_face(Actor004,"Sad")

	--★★ノワール★★:…ブリテンの今は騎士たちの血と<br>屍の上に成り立っている
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A110_170027")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Anger")

	--★★ノワール★★:それを忘れるのは失われた命への冒涜だ<br>聞き入れることは到底出来ない
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A110_170028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★ガウェイン★★:どのツラ下げて<br>裏切ったんだか知らねーが
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01A110_170029")

	play_head_motion(Actor007, "No", 0.3, 1.0, false)
	change_face(Actor007,"Sad")

	--★★ラグネル★★:ひとことぐらい、欲しかったよ…師匠
	Talk(Actor007,"CHRNAME_RAGNAR","speech","L","MA_01A110_170030")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ヴェルナルス★★:気色の悪い青春ごっこを続けるのはなぜだ？
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170031")


	--★★ヴェルナルス★★:あの学園が貴様らのキラーズを<br>研ぎ澄ませる鍛冶場ということは理解出来た
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170032")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス★★:友情や愛情…絆とやらを深め<br>キラーズの力を引き出すわけだ
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170033")


	--★★ヴェルナルス★★:限られた箱庭で軟弱な交友関係しか結べない<br>闘争心を育めるとも思えない。その結果──
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ヴェルナルス★★:カレドニア軍との戦いで学園は疲弊<br>聖杯探索と対ローマで騎士を分散せざるを得ず…
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170035")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ヴェルナルス★★:竜住まう学び舎は衰えた
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170036")

	PlayAction(Actor006,"to  Std_Surp")
	change_face(Actor006,"Anger")

	--★★ガウェイン★★:ずっと、待ってたってのか…！
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01A110_170037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Anger")

	--★★ラグネル★★:あたしたちの隙を<br>あたしたちと学園で過ごしながら…！？
	Talk(Actor007,"CHRNAME_RAGNAR","speech","L","MA_01A110_170038")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ヴェルナルス★★:ルーシャス様は然るべき時を見極め<br>扱うべきすべを得た。今狙わずしてなんとするか
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170039")

	PlayAction(Actor001,"to  Std_Worry")

	--★★グリートーネア★★:残念です…もう少し待っていただけたなら<br>もっと、もっと素敵な壁をお見せできたのに
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor004,"Normal","MA_01A110_170042","MA_01A110_170043")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor004,"Anger")

	--★★ノワール★★:そんなことは許さない！
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A110_170045")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★グリートーネア★★:酷いです…ネア、努力したんですよ…？<br>長く高い壁でこの島を区切ってあげようって…♪
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170046")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Anger")

	--★★ガウェイン★★:島の東側にはノワールの故郷もあんだ<br>里帰りできなくさせるわけにはいかねえ
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01A110_170047")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor004,"Anger")

	--★★ノワール★★:なにが素敵なものか
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A110_170049")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Anger")

	--★★ギネヴィア★★:そうよ、センス最悪だわ
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01A110_170050")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★グリートーネア★★:…は？は？ギネヴィア、あなたにまで<br>そんなこと言われる筋合い無いんですけど…？
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170051")

	change_face(Actor005,"Surprise")

	--★★ギネヴィア★★:…な、なに？　<br>なんかすごく怒ってるんだけど
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01A110_170052")

	change_face(Actor001,"Anger")

	--★★グリートーネア★★:どいつもこいつもネアのこと馬鹿にして…<br>今こそ目にもの見せてあげます…
	Talk(Actor001,"CHRNAME_SISTERS_4","speech","R","MA_01A110_170053")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ラシア★★:………私を見ないで、エレイン
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170055")

	change_face(Actor008,"Sad")

	--★★エレイン★★:報いる恩…返さなければならない義理<br>それがそちらにあるんですね
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A110_170056")


	--★★ラシア★★:こちらに来てしまった以上<br>私の気持ちは変えられません
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Anger")

	--★★ラシア★★:あなたもおなじでしょう、エレイン<br>後悔したことをそのままに戦うしかない…！
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170059")

	PlayAction(Actor008,"to  Std_No")

	--★★エレイン★★:違う、みたいです、ラシアさん<br>「してしまった」なんて…もう考えない
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A110_170061")


	--★★エレイン★★:自分の辛さなんて?み砕きます<br>誰かの覚悟を想えば、そんなもの──
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A110_170063")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(true)
setup_small_camera_start(Camera_EX02)
play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
change_face(Actor008,"Anger")
wait_time(1.8)
effect_at_character(Actor008, "Chest", Ef_Emblem01, 0.0, 0.15, 0.0)
effect_at_character(Actor009, "Chest", Ef_Emblem02, 0.0, 0.15, 0.0)
wait_time(1.0)
on_active( Ef_Emblem03 ) --キラーズ化エフェクト再生
play_particle( Ef_Emblem03 )
on_active( Ef_Emblem04 ) --キラーズ化エフェクト再生
play_particle( Ef_Emblem04 )
wait_time(2.3)
on_active( Ef_Emblem05 )
play_particle( Ef_Emblem05 )
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(1.0)
Hide(Actor009)
Appear(Actor010)
wait_time(TIME_ELAPSED + FADE_TIME)
fadein(FADE_TIME)
wait_time(FADE_TIME)
fadein(0.5)
wait_time(1.0)
off_active( Ef_Emblem01 )
off_active( Ef_Emblem02 )
stop_particle( Ef_Emblem03 )
stop_particle( Ef_Emblem04 )
stop_particle( Ef_Emblem05 )
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_AfterGinevia_General2_Start")
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor010, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor010, {1.0, 0.08, 0.5, 0.6} ,1.0)
keep_ik_lookat(Actor010,Actor008,"J_Head")
wait_time(1.0)
-- ▲直接出力
	change_face(Actor010,"Smile")

	--★★ラヴェイン2★★:ありがとう、エレイン
	Talk(Actor010,"CHRNAME_LOVEIN2","speech","L","MA_01A110_170065")

-- ▼直接出力
change_face(Actor010,"Anger")
lookat_delay_weight_reset(Actor010,1.8)
wait_time(1.4)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")
	change_face(Actor008,"Anger")

	--★★エレイン★★:飲み込んでみせます<br>怖さも憎さも口にして
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A110_170066")

-- ▼直接出力
setup_small_camera_end(Camera_EX02)
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★エレイン★★:変わっていってみせますから
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A110_170067")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ヴェルナルス★★:…浅はかな
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170068")

	open_select_window_tag(Actor004,"Normal","MA_01A110_170070","MA_01A110_170071","MA_01A110_170072")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor004,"Serious")

	--★★ノワール★★:ギネヴィア、準備は
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A110_170074")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:いつでもどうぞ、ノワール！
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01A110_170075")

	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:ムダなのよ<br>急場しのぎの策なんて
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01A110_170076")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Serious")

	--★★ノワール★★:エレイン、力を貸してくれ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A110_170078")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
	change_face(Actor008,"Anger")

	--★★エレイン★★:任せてください。先輩
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A110_170079")

-- ▼直接出力
lookat_delay_weight(Actor008, {1.0, 0.08, 0.5, 0.6} ,1.0)
keep_ik_lookat(Actor008,Actor004,"J_Head")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★エレイン★★:ありがとうございます<br>前に進む力をくれて
	Talk(Actor008,"CHRNAME_ELAINE","speech","L","MA_01A110_170080")

-- ▼直接出力
change_face(Actor008,"Anger")
lookat_delay_weight_reset(Actor008,1.8)
-- ▲直接出力
	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Serious")

	--★★ノワール★★:行こう、ガウェイン
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A110_170082")

-- ▼直接出力
setup_small_camera_start(Camera_EX01)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Angry")
	change_face(Actor006,"Serious")

	--★★ガウェイン★★:サンキュー、ノワール！<br>やってやろうぜ！
	Talk(Actor006,"CHRNAME_GAWAIN","speech","L","MA_01A110_170083")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Anger")

	--★★ラグネル★★:話してわかってもらえないなら、もう…！
	Talk(Actor007,"CHRNAME_RAGNAR","speech","L","MA_01A110_170084")

-- ▼直接出力
setup_small_camera_end(Camera_EX01)
-- ▲直接出力
	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Serious")

	--★★ノワール★★:長城中のバルバロイを殲滅し<br>ブリテンを分断する壁を──
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A110_170086")

	open_cutin(2,1)
	on_cutin(1,Actor005,"Normal")
	on_cutin(2,Actor008,"Anger")

	--★★ギネヴィア／エレイン★★:ブチ抜きましょう！
	Talk(Actor011,"CHRNAME_GUINEVERE_ELAINE","speech","N","MA_01A110_170087")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★ヴェルナルス★★:我らがローマ！<br>その五体、眠らず振るえ！
	Talk(Actor003,"CHRNAME_VERNARTH","speech","R","MA_01A110_170088")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラシア★★:我らがローマ！<br>この五体、死しても眠らず！
	Talk(Actor002,"CHRNAME_RASIA","speech","R","MA_01A110_170090")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
preload_sound("BGM_Battle_AfterGinevia_General2_Start")
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false)
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem07", false)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
setup_prop_object_preload(10201007)
	InitializeLoad_Preload()
	load_area_scene_preload(111042)
	InitializeCharacter_3D_Preload("101045","001","101045001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101031","002","101031002","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_2DOnly_Preload("101013","001","101013001")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor010,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111042_01)
	system.PreLoadRequest(CameraAssetBundleName111042_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
