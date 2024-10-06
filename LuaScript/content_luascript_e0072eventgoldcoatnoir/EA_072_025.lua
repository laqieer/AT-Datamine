-- このluaスクリプトは、EA_072_025.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_03","111016_03_h")
Include("content_adv_advsmall_111016_03","Template111016_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111016_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName111016_03,CameraPos111016_03_004)
	InitializeTemplateRandomCamera111016_03()
	InitializeTemplate111016_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ギネマウア★★:「娘は願いました<br>リッチになりたい、と」
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250002")


	--★★ギネマウア★★:「異国のコインは答えました」
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250003")


	--★★ギネマウア★★:「そういった夢をもてる時点で<br>キミはじゅうぶんにリッチだ」
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250004")


	--★★ギネマウア★★:「キミが貧しい気持ちでいるのは<br>それに気づかないままだからだ」
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250005")


	--★★ギネマウア★★:「異国のコインを磨いてごらん<br>そうすれば──…」
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250006")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera001)
setup_small_camera_start()
wait_time(2.8)
setup_small_camera_end()
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:………？<br>あら、制服が…ほつれて
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250007")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:どうしてかしら<br>私がやったのであれば、必ずしっかりと──
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250008")

	change_face(Actor001,"Normal")

	--★★ギネマウア★★:………ああ
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250009")


	--★★ギネマウア★★:そういえば、確か…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250010")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネマウア★★:あなたの仕業、だったわね
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_072_0250011")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
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
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName111016_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
