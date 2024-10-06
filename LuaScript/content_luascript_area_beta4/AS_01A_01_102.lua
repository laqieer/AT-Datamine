-- このluaスクリプトは、AS_01A_01_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:ノワールじゃねーか<br>どうした、辛気臭せーツラして？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01A_01_1020001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あのさ。ガウェインってさ<br>ラグネルに無理させすぎちゃったことあるか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_01_1020002")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:あー…あるよ<br>「もう付き合ってらんない」って何度も言われた
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01A_01_1020003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それでどうしたんだ？<br>そう言われてもまだ付き合わせてるのか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_01_1020004")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:別に付き合わせてるわけじゃねーよ<br>俺たちは一緒に歩いてんだよ。戦いはその一環だ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01A_01_1020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:一緒に歩く…一緒にいたい…そうか<br>気持ちが整理できそうな気がするよ、ありがとう
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_01_1020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end
