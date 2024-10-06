-- このluaスクリプトは、MA_01C112_24.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_01","114101_01_h")
Include("content_adv_advsmall_114101_01","Template114101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	InitializeTemplateRandomCamera114101_01()
	InitializeTemplate114101_01()
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


	--★★テロップ★★:禁じられた恋に結ばれたものの<br>ふたりは離れ離れになってしまいます
	Talk(Actor001,"telop","narration","L","MA_01C112_240002")


	--★★テロップ★★:青年はある国の王子でした
	Talk(Actor001,"telop","narration","L","MA_01C112_240003")


	--★★テロップ★★:そして…森から出た青年は<br>恋の記憶を失ってしまいました
	Talk(Actor001,"telop","narration","L","MA_01C112_240004")


	--★★テロップ★★:妖精と別れた王子は<br>親に従うままとある姫君と結婚をします
	Talk(Actor001,"telop","narration","L","MA_01C112_240005")


	--★★テロップ★★:そして、王子と姫君の間には<br>子供が生まれ、大切に育てられました
	Talk(Actor001,"telop","narration","L","MA_01C112_240006")


	--★★テロップ★★:同じ頃、妖精も子供を産みました<br>王子との大切な愛の結晶でした
	Talk(Actor001,"telop","narration","L","MA_01C112_240008")


	--★★テロップ★★:そして妖精は望みました
	Talk(Actor001,"telop","narration","L","MA_01C112_240009")


	--★★テロップ★★:「この娘が、しあわせになりますように」
	Talk(Actor001,"telop","narration","L","MA_01C112_240010")

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
