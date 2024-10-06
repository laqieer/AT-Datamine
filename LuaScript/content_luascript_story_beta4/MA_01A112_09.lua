-- このluaスクリプトは、MA_01A112_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",105,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115194)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:聞き上手だという自負はあるのですがね<br>それゆえ、かけてあげられる言葉が見つからない
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090002")


	--★★ラヴェイン★★:キズの熱は引きましたが<br>あまりにも、痛むようで…
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:…『アストラットの美姫』<br>妹はそう呼ばれてきました
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090005")


	--★★ラヴェイン★★:本来であれば家督を継ぐべき私が<br>キラーズになってしまったことで
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090006")

	PlayAction(Actor002,"to  Std_Sad02")
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:妹はその小さな肩に似つかわしくない<br>重責を負うことになりました
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090007")

	change_face(Actor002,"Normal")

	--★★ラヴェイン★★:ひとりで必死に抱えてきたのだと思います<br>通り名に相応しい自分に、と
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090008")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラヴェイン★★:今のエレインを支えてあげられるのは<br>きっと、私ではなくだと思うんです
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラヴェイン★★:甘えてしまえる家族ではなく<br>誰か、外の、信頼出来る誰かでなくては
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090010")


	--★★ラヴェイン★★:今の見えかたが<br>変えたくても変えられない
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラヴェイン★★:エレインも<br>もがいている
	Talk(Actor002,"CHRNAME_LOVEIN","speech","L","MA_01A112_090012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115194)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
