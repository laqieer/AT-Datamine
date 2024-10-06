-- このluaスクリプトは、MA_01B111_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:王さまっ！！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B111_070002")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:大丈夫。もう向かったよ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B111_070003")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:え…っ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B111_070004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:………貴方の尽力あればこそです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01B111_070006")


	--★★フィエナ★★:…聖杯、４つ目の封印は──
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B111_070007")

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:先んじて、彼らが
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01B111_070008")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力

	--★★フィエナ★★:──もう、解いちゃった…？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B111_070009")

-- ▼直接出力
 --PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:したたかなヤツらだ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B111_070010")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Surp")
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Anger")
-- ▲直接出力
-- ▼直接出力
set_animationbattlecontroller(Actor001, 1, false)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"ToAbnormal")
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力

	--★★フィエナ★★:王さま！？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B111_070012")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:…時間が、もう…ありませんね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01B111_070014")


	--★★フィエナ★★:じかん…？時間ってなに！？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B111_070015")

-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アーサー★★:ランスはそれを知ったうえで<br>沈着な判断を下している
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B111_070016")


	--★★アーサー★★:抜きん出て、孤高にな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01B111_070017")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
