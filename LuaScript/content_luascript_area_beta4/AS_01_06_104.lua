-- このluaスクリプトは、AS_01_06_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Sit01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:どうしたノワール<br>俺をマーケットの屋台へ誘いにでも来たのか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AS_01_06_1040002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:そんなんじゃない<br>モルガン先生のことを聞きたくて来たんだ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_06_1040003")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:義姉さんのことなら<br>学園の皆からある程度聞かされているだろう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AS_01_06_1040004")


	--★★アーサー★★:優しい療養院の養護教諭で<br>好きなものはリンゴと生徒たちの恋バナだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AS_01_06_1040005")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:こ、恋バナ…？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_06_1040006")

-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:お前も捕まったら根掘り葉掘り聞かれると思うぞ<br>別荘に行ったら気を付けてな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AS_01_06_1040007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Sit01_Loop_m")
end
