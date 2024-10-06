-- このluaスクリプトは、MA_01C111_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_01","114101_01_h")
Include("content_adv_advsmall_114101_01","Template114101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera114101_01()
	InitializeTemplate114101_01()
-- ▼直接出力
on_cameraframe(2) 
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114101)
	Actor001 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()


	--★★ディナタン★★:薄暗い森にひとりの妖精が暮らしていました
	Talk(Actor001,"","narration","L","MA_01C111_090002")


	--★★ディナタン★★:妖精はいつもひとりで歌をうたっていました
	Talk(Actor001,"","narration","L","MA_01C111_090003")


	--★★ディナタン★★:ある日、歌に導かれるようにひとりの若者が<br>森に迷い込んできました
	Talk(Actor001,"","narration","L","MA_01C111_090004")


	--★★ディナタン★★:始めは歌を聴いていただけの青年でしたが<br>いつしかふたりは会話を交わすようになり
	Talk(Actor001,"","narration","L","MA_01C111_090005")


	--★★ディナタン★★:そして恋に落ちました
	Talk(Actor001,"","narration","L","MA_01C111_090006")


	--★★ディナタン★★:しかし妖精と人間の恋は禁忌
	Talk(Actor001,"","narration","L","MA_01C111_090007")


	--★★ディナタン★★:禁忌
	Talk(Actor001,"","narration","L","MA_01C111_090008")


	--★★ディナタン★★:………禁忌――…
	Talk(Actor001,"","narration","L","MA_01C111_090009")


	--★★ディナタン★★:それでもふたりは恋に落ちてしまったのです
	Talk(Actor001,"","narration","L","MA_01C111_090010")

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
	system.PreLoadRequest(CameraAssetBundleName114101_01)
end
