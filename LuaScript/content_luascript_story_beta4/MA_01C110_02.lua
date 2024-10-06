-- このluaスクリプトは、MA_01C110_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_01","114101_01_h")
Include("content_adv_advsmall_114101_01","Template114101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_511_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_005)
	InitializeTemplateRandomCamera114101_01()
	InitializeTemplate114101_01()
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114101)
	Actor001 = InitializeCharacter_3D("101067","001","101067001","content_animationpack__common","FacialPack","Actor001")
	template1()
end

function Play()
	StartPlay()


	--★★ニニアン★★:選んだのはあの人だけじゃない<br>私もあの人を選んでしまった
	Talk(Actor001,"CHRNAME_NINIAN","narration","N","MA_01C110_020003")


	--★★ニニアン★★:私の血が必要だというなら<br>私は喜んであの人に血を捧げる
	Talk(Actor001,"CHRNAME_NINIAN","narration","N","MA_01C110_020004")


	--★★ニニアン★★:でも、この子には幸せになってほしい
	Talk(Actor001,"CHRNAME_NINIAN","narration","N","MA_01C110_020005")


	--★★ニニアン★★:私たちは許されない恋をした
	Talk(Actor001,"CHRNAME_NINIAN","narration","N","MA_01C110_020007")


	--★★ニニアン★★:許されないはずだった
	Talk(Actor001,"CHRNAME_NINIAN","narration","N","MA_01C110_020008")


	--★★ニニアン★★:……でも――
	Talk(Actor001,"CHRNAME_NINIAN","narration","N","MA_01C110_020009")


	--★★ニニアン★★:お願い、この子を守って
	Talk(Actor001,"CHRNAME_NINIAN","narration","N","MA_01C110_020010")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114101)
	InitializeCharacter_3D_Preload("101067","001","101067001","content_animationpack__common","FacialPack","Actor001")
	system.PreLoadRequest(CameraAssetBundleName114101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
