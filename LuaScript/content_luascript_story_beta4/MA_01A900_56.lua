-- このluaスクリプトは、MA_01A900_56.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110241_21","110241_21_h")
Include("content_adv_advsmall_110241_21","Template110241_21_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110241_21_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110241_21_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110241_21_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110241_21_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110241_21_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110241_21_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110241_21_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110241_21_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_006)
	InitializeTemplateRandomCamera110241_21()
	InitializeTemplate110241_21()
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
-- ▲直接出力
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,0.04, 1.30, 11.8)
-- ▲直接出力
-- ▼直接出力
lookoj2 = create_object("kara2")
set_pos_object(lookoj2,-1.4, 1.30, 11.8)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110241)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:あえて語ろう<br>胸を張りて
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560002")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:歴史の波に消えゆくとも、平和への戦に身を投じ<br>キラーズとなった者たちを
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560003")


	--★★アーサー★★:歴史の頁に留まる決意、愛する者を見送る誓いで<br>バイブスを行使した者たちを
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560004")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★アーサー★★:これより歴史を紡いでいくはずであった<br>民たち、学び舎の仲間たちのことを
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560005")

	change_face(Actor002,"Sad")

	--★★アーサー★★:かけがえのない者たちを代償に得た<br>この度の大いなる勝利を──
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:語り継ごう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560007")

-- ▼直接出力
se_play("SE_ADV_MA_01C110_41_Cheers_02")
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★アーサー★★:苦節を共にした戦友全てに<br>これからの未来を捧げよう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:乗り越えた苦難を、振り返りながら
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560009")

-- ▼直接出力

  --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
set_animationcontroller(Actor002,"Com_m_SitController","to Sit01_Loop")
Camera002 = setup_small_camera_resetting(Actor002,CharaPos110241_21_003,CameraPos003)
set_enable_auto_lookat_all(false)
lookat_delay_weight_reset(Actor001,0.6)
setup_small_camera_start(RndCamera006)
lookat_weight(Actor002,0.8, 0.03, 0.6, 0.3)
keep_delay_ik_lookat_object(Actor002,nil,"kara2",0.55)
SwitchMob(false)
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
lookat_weight(Actor002,0.8, 0.03, 0.6, 0.3)
keep_delay_ik_lookat_object(Actor002,nil,"kara",0.55)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:継承者という進路を強いたというのに
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560011")

-- ▼直接出力
lookat_delay_weight(Actor001,0.8, 0.05, 0.6, 0.5,0.55)
keep_ik_lookat_object(Actor001,nil,"kara")
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:よく、進み続けてくれた<br>──ありがとう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560012")

	change_face(Actor002,"Normal")

	--★★アーサー★★:登校は<br>億劫だったろうに
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560013")

	change_face(Actor001,"Smile")

	--★★ノワール★★:あくびが出るほど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_560015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:…ならば平和で良かった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560016")

-- ▼直接出力
CloseTalkWindow()
 --setup_small_camera_end(Camera002)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
lookat_delay_weight_reset(Actor002,0.6)
wait_time(1.0)
SkipOffsetCamera(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:のちの歴史がどう語るかはわからない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560017")


	--★★アーサー★★:騎士の名と武器の銘<br>多くの物語が紡がれることだろう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:宮廷の歴史家には言い含めているんだ<br>俺を歴史に遺すのならば──
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★アーサー★★:荒唐無稽な巨人と争い、妻も国も盗られ<br>目一杯無様な死に様になるよう描いてくれと
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560020")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうして？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_560021")

	change_face(Actor002,"Sad")

	--★★アーサー★★:バルバロイという歴史の消失点を乗り越えるべく<br>皆が命を賭した
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560022")

-- ▼直接出力
lookat_delay_weight(Actor002,0.8, 0.05, 0.6, 0.5,0.55)
keep_ik_lookat_object(Actor002, nil, "kara")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★アーサー★★:それを強いた元凶こそが<br>俺だからな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560023")

-- ▼直接出力
CloseTalkWindow()	
change_face(Actor001,"Normal")
setup_small_camera_start(RndCamera004)
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight_reset(Actor001,0.6)
wait_time(1.5)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も付き合うよ、アーサー
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_560024")

	change_face(Actor002,"Surprise")

	--★★アーサー★★:なに？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺のことも…歴史に目立たないような<br>ありきたりな騎士物語に納めてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_560026")

-- ▼直接出力
keep_ik_lookat_object(Actor001, nil, "kara")
lookat_delay_weight(Actor001,0.8, 0.05, 0.6, 0.5,0.6)
-- ▲直接出力

	--★★ノワール★★:罵詈雑言に晒されるような
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_560027")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:B級だな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560028")

	change_face(Actor001,"Smile")

	--★★ノワール★★:不格好だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A900_560029")

	change_face(Actor002,"Smile")

	--★★アーサー★★:お前の想いより出でた劔だけは<br>千年先まで錆びずに遺ることを願う
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Serious")

	--★★アーサー★★:ありがとう<br>共に卓を囲んでくれて
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A900_560032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110241)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110241_21)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
