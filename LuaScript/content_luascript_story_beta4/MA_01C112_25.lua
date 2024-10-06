-- このluaスクリプトは、MA_01C112_25.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_002)
	Camera002 = SetTemplate("Actor002",75.7,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
lookat_delay_weight(Actor002, 1.0, 0, 0.3, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
force_eyesync(Actor001,"Close")
set_enable_auto_lookat(Actor001,false)
change_face(Actor001,"Sad")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★マルディサント★★:ディーナ！
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_250002")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
force_eyesync(Actor001,"Auto")
wait_time(1.0)
change_face(Actor001,"Surprise")
wait_time(1.0)
keep_delay_ik_lookat(Actor001,Actor002, "J_Head",1.0)
wait_time(2.0)

-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:…マァル…私…<br>夢…夢を見ていたの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_250004")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ディナタン★★:本当に夢なのかもわからない…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_250005")


	--★★ディナタン★★:…夢…また夢…<br>誰と誰が結ばれて…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_250006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:これは誰の夢なの<br>私の夢…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_250007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マルディサント★★:…夢のことなんて忘れろ、ディーナ
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_250008")


	--★★ディナタン★★:私、私も兄さんも<br>大切なことを忘れて――…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_250009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ディナタン★★:だって…でもこの記憶は<br>あの青年は
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_250010")


	--★★ディナタン★★:じゃあ…？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_250011")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マルディサント★★:おい、ディーナ――
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","MA_01C112_250012")


	--★★ディナタン★★:――気持ち悪い
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","MA_01C112_250014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
