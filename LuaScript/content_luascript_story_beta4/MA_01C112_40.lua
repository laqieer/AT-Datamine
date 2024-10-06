-- このluaスクリプトは、MA_01C112_40.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_002)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115131)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ガレス★★:食堂のクリスマスは盛大にやるつもりなんだ<br>やっぱりクリスマスにはご馳走がないとな♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C112_400002")


	--★★ガレス★★:おっきな七面鳥をじゅ～じゅ～焼いて～<br>ケーキに飾りもた～っぷり乗っけて♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C112_400003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0.27)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ガレス★★:あ！ノワールの好物ってなんだ？<br>特別に作ってあげるぞ～
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C112_400004")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…ごめん、ガレス
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_400005")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001, -55.3, 0.44)
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED)
Hide(Actor001)
wait_time(FADE_TIME)
fadein(FADE_TIME)
wait_time(1.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガレス★★:あ…
	Talk(Actor002,"CHRNAME_GARETH","speech","L","MA_01C112_400007")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115131)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
