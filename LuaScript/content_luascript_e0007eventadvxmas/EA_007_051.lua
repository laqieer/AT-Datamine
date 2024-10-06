-- このluaスクリプトは、EA_007_051.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
-- ▼直接出力
RndCamera001 = RndCamera009
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_2DOnly("101064","001","101064001")
	Actor002 = InitializeCharacter_TextOnly()
	Actor003 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
 --wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("リアム","0008")
-- ▲直接出力

	--★★リアム★★:まだ遠くへは行っていないはずです…！
	Talk(Actor001,"CHRNAME_LIAM","speech","N","EA_007_0510006")

-- ▼直接出力
PlayPartVoiceDirect("市民中年_男1","0025")
-- ▲直接出力

	--★★カイルの父★★:私の兄──カイルの叔父と、私たちは<br>うまくいっていなかったのです…！
	Talk(Actor002,"NPCNAME_0387","speech","N","EA_007_0510007")


	--★★カイルの母★★:我々はいわば…<ruby=あのひと>叔父</ruby>の商売敵でした
	Talk(Actor003,"NPCNAME_0388","speech","N","EA_007_0510008")

-- ▼直接出力
PlayPartVoiceDirect("市民中年_女1","0021")
-- ▲直接出力

	--★★カイルの母★★:カイルは叔父によく懐いていました<br>私たちがカイルから目を離したばかりに──
	Talk(Actor003,"NPCNAME_0388","speech","N","EA_007_0510010")

-- ▼直接出力
PlayPartVoiceDirect("リアム","0021")
-- ▲直接出力

	--★★リアム★★:<ruby=かれ>叔父</ruby>がカイルくんをログレスに誘ったのも<br>元々誘拐が目的だったというわけですか…！
	Talk(Actor001,"CHRNAME_LIAM","speech","N","EA_007_0510011")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera009
	InitializeLoad_Preload()
	load_area_scene_preload(110091)
	InitializeCharacter_2DOnly_Preload("101064","001","101064001")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
end
