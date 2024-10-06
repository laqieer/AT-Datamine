-- このluaスクリプトは、MA_01B900_59.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",304,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",115,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_007_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115074)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101021","002","101021002","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()


	--★★ブルーノ★★:天命、曰く
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_590002")


	--★★ブルーノ★★:お前が選び抜いたのは<br>唯一無二の伝説
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_590003")


	--★★ブルーノ★★:六千年の歴史の海からサルベージされ<br>未来まで語り継がれる墓碑銘
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_590004")


	--★★ブルーノ★★:継承者のキラーズは<br>未来にて世界を救う武器となる
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_590005")

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
	change_face(Actor002,"Sad")

	--★★ブルーノ★★:………お前の喪失に対し<br>なんの慰めにもなりはしないが──
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_590007")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力

	--★★ノワール★★:だったら、必ず
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_590008")

	change_face(Actor002,"Normal")

	--★★ブルーノ★★:…ああ
	Talk(Actor002,"CHRNAME_BRUNO","speech","L","MA_01B900_590009")


	--★★ノワール★★:必ず<ruby=おれたち>未来</ruby>は救われる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_590010")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Surprise")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor002,0,295,0,1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:待っていてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_590012")


	--★★ノワール★★:覚えたそばから<br>忘れていくとしても
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_590013")


	--★★ノワール★★:ひとつも失くしたくないのに<br>ひとつしか残せないのだとしたら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_590014")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:なにを<ruby=うしな>喪</ruby>っても<br>生きていくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_590015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,124,0,1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力

	--★★ノワール★★:<ruby=ランスロット>このいたみ</ruby>が、武器になるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_590017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115074)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101021","002","101021002","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
