-- このluaスクリプトは、MA_01B900_55.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110241_21","110241_21_h")
Include("content_adv_advsmall_110241_21","Template110241_21_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110241_21_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110241_21_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110241_21_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110241_21_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110241_21_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110241_21_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110241_21_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_005)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110241_21_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_007)
	InitializeTemplateRandomCamera110241_21()
	InitializeTemplate110241_21()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110241)
	Actor001 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ケイ★★:あえて語ろう<br>胸を張りて
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550002")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★ケイ★★:歴史の波に消えゆくとも、平和への戦に身を投じ<br>キラーズとなった者たちを
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550003")


	--★★ケイ★★:歴史の頁に留まる決意、愛する者を見送る誓いで<br>バイブスを行使した者たちを
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550004")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★ケイ★★:これより歴史を紡いでいくはずであった<br>民たち、学び舎の仲間たちのことを
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550005")


	--★★ケイ★★:かけがえのない者たちを代償に得た<br>この度の大いなる勝利を──
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550006")

-- ▼直接出力
 --setup_small_camera_start(RndCamera004)
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:語り継ごう
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550007")


	--★★ケイ★★:苦節を共にした戦友すべてに<br>これからの未来を捧げよう
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550008")


	--★★ケイ★★:乗り越えた苦難を、振り返りながら
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550009")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
SwitchMob(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Camera009 = SetTemplate("Actor001",nil,CharaPos110241_21_009,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110241_21,CameraPos110241_21_009)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{0.694,0,5.779})
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,0,0,0.1)
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,0.694,0,9.866,4.0)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(4.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ケイ★★:継承者という進路を強いたというのに
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550011")

	change_face(Actor001,"Smile")

	--★★ケイ★★:よく、進み続けてくれた…<br>──ありがとう
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550012")

	change_face(Actor001,"Normal")

	--★★ケイ★★:登校は<br>億劫だったろうに
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550013")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:あくびが出るほど
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B900_550015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ケイ★★:…ならば平和で良かった
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550016")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ケイ★★:後の歴史がどう語るかはわからない
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550017")


	--★★ケイ★★:騎士の名と武器の銘<br>多くの物語が紡がれることだろう
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550018")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera009)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ケイ★★:アーサーが宮廷の歴史家には言い含めていたよ<br>自分を歴史に遺すのならば──
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550019")


	--★★ケイ★★:荒唐無稽な巨人と争い、妻も国も盗られ<br>目一杯無様な死に様になるよう描いてくれと
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550020")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:どうして？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B900_550021")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ケイ★★:バルバロイという歴史の消失点を乗り越えるべく<br>皆が命を賭した
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550022")

	change_face(Actor001,"Sad")

	--★★ケイ★★:それを強いた元凶こそが<br>アーサー自身だから…だそうだ
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550023")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:俺も付き合うよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B900_550024")

	change_face(Actor001,"Surprise")

	--★★ケイ★★:なに？
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550025")

	change_face(Actor002,"Laugh")

	--★★ノワール★★:俺のことも…歴史に目立たないような<br>ありきたりな騎士物語に納めてくれ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B900_550026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:罵詈雑言に晒されるような
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B900_550027")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ケイ★★:B級だな
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550028")

	change_face(Actor002,"Smile")

	--★★ノワール★★:不格好だろ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01B900_550029")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,180,0,1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ケイ★★:お前の想いより出でた劔だけは<br>千年先まで錆びずに遺ることを願う
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550030")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001,0.694,0,1.779,8.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ケイ★★:感謝する<br>ともに卓を囲んでくれて
	Talk(Actor001,"CHRNAME_KAY","speech","L","MA_01B900_550032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110241)
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401010","001","401010001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110241_21)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
