-- このluaスクリプトは、AS_01_04_106.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Tyrfing","101001001","101001001","content_animationpack_101_101tyrf","MotionPack_101Tyrf","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:なにかご用でしょうか、マスター？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AS_01_04_1060002")


	--★★ノワール★★:聞かせてほしい。どうしてあの剣は抜けた？<br>どうしてキミは俺の前に姿を現した？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_1060003")


	--★★ティルフィング★★:一言で言い表すとするならば…<br>時が来たのです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AS_01_04_1060004")


	--★★ノワール★★:キミが世に現れなければならない時が来た<br>というわけか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_1060005")

-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力

	--★★ティルフィング★★:いいえ<br>アナタが戦わなければならない時が、です
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AS_01_04_1060006")


	--★★ノワール★★:俺が戦わなければならない時？<br>実感が湧かないけど…努力はしてみるよ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_1060007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Tyrfing","101001001","101001001","content_animationpack_101_101tyrf","MotionPack_101Tyrf","Com_Std01_Loop_f")
end
