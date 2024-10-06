-- このluaスクリプトは、AS_01B_11_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★フィエナ★★:あっ、ノワール<br>少し話をしたいと思ってたんだ
	Talk(Actor002,"CHRNAME_VIENA","speech","L","AS_01B_11_1020001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ちょうどよかった<br>俺もだ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_11_1020002")

-- ▼直接出力
PlayPartVoice("フィエナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フィエナ★★:あのさ。聖杯が欲しければ銀卓騎士を倒しなさい<br>…ってなったら、ノワールはどうする？
	Talk(Actor002,"CHRNAME_VIENA","speech","L","AS_01B_11_1020003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:できることなら一度話をしてみたい<br>ローマも出て来るし、状況的には難しそうだけど
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_11_1020004")

-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★フィエナ★★:ノワールもガラハッドも銀卓の皆も大事な家族<br>私が守るからね！絶対絶対、仲良くしようね！
	Talk(Actor002,"CHRNAME_VIENA","speech","L","AS_01B_11_1020005")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:…フィエナ？<br>ありがとう、でも、くれぐれも無理はするなよ？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_11_1020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
end
