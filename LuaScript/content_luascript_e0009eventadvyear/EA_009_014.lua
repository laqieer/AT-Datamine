-- このluaスクリプトは、EA_009_014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_05","110111_05_h")
Include("content_adv_advsmall_110111_05","Template110111_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_05_011,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_011)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_05_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_05_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_05_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_012)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_05_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110111_05,CameraPos110111_05_001)
	InitializeTemplateRandomCamera110111_05()
	InitializeTemplate110111_05()
-- ▼直接出力
BgProp = setup_prop_object(10102012)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{3.15, 0, 6.43,   232})
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-4.66, 0, -1.61})
set_pos(Actor006,{-3.45, 0, -0.52})
turn_chara(Actor005,141,0)
turn_chara(Actor006,150,0)
Hide(Actor005)
Hide(Actor006)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115119)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール★★:またあのふたりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0140003")

-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0034")
-- ▲直接出力

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0140004")

-- ▼直接出力
PlayPartVoiceDirect("エレイン","0034")
-- ▲直接出力

	--★★エレイン★★:ヒソヒソ…では冊子はこちらで…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0140005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:ヒソヒソ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","EA_009_0140006")


	--★★エレイン★★:ヒソヒソ…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","EA_009_0140007")

-- ▼直接出力
setup_small_camera_end()
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:こんな人目のある場所で<br>公然とヒソヒソ話をしている…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0140008")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor004)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{0.848, 0, 4.637},1.6)
wait_time(0.8)
setup_small_camera_start(Camera004)
wait_time(0.8)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.6)
-- ▲直接出力

	--★★リオネス★★:ところが！こういう場所では皆自分の話に夢中で<br>違うテーブルの話を意外と聞いていないのだ！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_009_0140009")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんなものなのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0140011")

-- ▼直接出力
setup_small_camera_end(Camera001)
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0038")
-- ▲直接出力

	--★★リオネス★★:ちなみにあのふたりは<br>ここに来てからずっとあんな感じだ！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_009_0140012")

	change_face(Actor004,"Sad")

	--★★リオネス★★:
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_009_0140013")

-- ▼直接出力
setup_small_camera_end()
setup_small_camera_start(Camera001)
Hide(Actor002)
Hide(Actor003)
Appear(Actor005)
Appear(Actor006)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…気になりすぎる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_009_0140014")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera001)
setup_small_camera_start()
wait_time(0.2)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,{2.59, 0, -10.72},6.0)
wait_time(0.4)
PlayActionDirect(Actor006,"to Wlk")
slidemove(Actor006,{2.78, 0, -10.61},6.0)
wait_time(1.0)
setup_small_camera_end()
setup_small_camera_start(Camera004)
wait_time(0.2)
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★リオネス★★:あ、ふたりが移動したぞ！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","EA_009_0140015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102012)
	InitializeLoad_Preload()
	load_area_scene_preload(115119)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
