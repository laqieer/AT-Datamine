-- このluaスクリプトは、MA_01108_57.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_03","111016_03_h")
Include("content_adv_advsmall_111016_03","Template111016_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111016_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111016_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111016_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos111016_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_007)
	Camera008 = SetTemplate("Actor008",169.2631,CharaPos111016_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_002)
	InitializeTemplateRandomCamera111016_03()
	InitializeTemplate111016_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101056","001","101056001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101035","002","101035002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101034","002","101034002","content_animationpack__common","FacialPack","Actor008")
	template1()
-- ▼直接出力
set_pos(Actor005,{0.323,-0.155,-3.925})
set_pos(Actor006,{-1.066,-0.155,-3.627})
set_pos(Actor007,{1.663,-0.155,-4.685})
set_pos(Actor008,{-2.257,-0.155,-3.845})
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
set_enable_auto_lookat_all(false)
-- ▲直接出力
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	change_face(Actor001,"Smile")

	--★★アーサー★★:世話になりました<br>ぺレス王
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01108_570002")


	--★★ペレス★★:聞き及んだぞ<br>継承者の決断を
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_570003")


	--★★ペレス★★:そして大敵の台頭…
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_570004")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ペレス★★:継承者が完全に覚醒した以上<br>これが最後の戦いとなろう
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_570005")


	--★★ペレス★★:我らが力を合わせねばならぬ時期が<br>来ていることは理解しておるつもりだ
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_570006")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
Appear(Actor006)
-- ▲直接出力
-- ▼直接出力
Appear(Actor007)
-- ▲直接出力
-- ▼直接出力
Appear(Actor008)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor007,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.1)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor008,"to Wlk")
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor005,0.480,-0.155,-5.670,1.8)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor006,-0.909,-0.155,-5.372,1.8)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor007,1.820,-0.155,-6.430,1.8)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor008,-2.1,-0.155,-5.59,1.8)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor006,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor007,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor008,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ペレス★★:聖杯探索の援助としてフィエナとガラハッド<br>学園の護衛にエクセリアとリリアーナをつけよう
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_570008")

	change_face(Actor003,"Surprise")

	--★★ノワール★★:ペレス王…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01108_570009")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:勉強させてもらう、ノワール
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_570010")

-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,338.3172,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,332.6601,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,332.6872,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor008,0,136.7339,0,0)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Normal")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera007)
-- ▲直接出力
	PlayAction(Actor007,"to Greet_one")
	change_face(Actor007,"Smile")

	--★★フィエナ★★:ノワール、よろしくねっ
	Talk(Actor007,"CHRNAME_VIENA","speech","L","MA_01108_570011")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力
-- ▼直接出力
Appear(Actor001)
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
	PlayAction(Actor006,"to Bow")

	--★★リリアーナ★★:お、お世話になります…
	Talk(Actor006,"CHRNAME_LILIANA2","speech","L","MA_01108_570012")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor008,"to  Std_Talk")
	change_face(Actor008,"Smile")

	--★★エクセリア★★:コルベニック城は我らのマスターが守護するわ<br>継承者はローマを叩く最適解を進んで
	Talk(Actor008,"CHRNAME_EXCELIA2","speech","L","MA_01108_570013")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ペレス★★:帰郷の土産として受け取って欲しい<br>継承者、そなたの選択に敬意を表して
	Talk(Actor002,"CHRNAME_PEREZ","speech","L","MA_01108_570014")

-- ▼直接出力
turn(Actor001,0,180,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,172,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor004,0,190,0,0)
-- ▲直接出力
-- ▼直接出力
turn(Actor008,0,169.2631,0,0)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ありがとうございます…！
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01108_570015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アーサー★★:ローマがバルバロイを得たとなれば<br>物量、戦力ともにこちらが圧倒的不利だ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01108_570016")


	--★★アーサー★★:<ruby=ティルフィング>最初の武器</ruby>が導いた<ruby=アロンダイト>ノワールのＧＳ</ruby>と<br>聖杯伝承にすべては懸かっている…
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01108_570017")

	PlayAction(Actor004,"to  Std_Angry")

	--★★ギネヴィア★★:やるわ<br>負けてなんかやんない、ぜったいに
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01108_570019")


	--★★ノワール★★:父さんたちに<br>格好がつかないしな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01108_570020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ギネヴィア★★:そうよ<br>パパにも良い格好しなきゃ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01108_570021")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ギネヴィア★★:もう、お飾りだなんて言わせない
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","MA_01108_570022")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101056","001","101056001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101035","002","101035002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101034","002","101034002","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
