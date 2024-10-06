-- このluaスクリプトは、AS_01C_12_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力

	--★★クラリス★★:こんにちは、ノワールくん<br>今日は大聖堂になんのご用ですか～？
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","AS_01C_12_1020001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:祈ってやりたいなと思ってさ<br>…パーシヴァルのこと
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_12_1020002")

	change_face(Actor002,"Sad")

	--★★クラリス★★:…わかりました<br>一緒に祈りましょう
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","AS_01C_12_1020003")


	--★★クラリス★★:頑張りましたよね、パーシヴァルさん<br>頑張ってくれましたよね、学園のために
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","AS_01C_12_1020004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…俺にどこまでできるかわからないけど<br>パーシヴァル、お前の意志は受け継ぐから
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_12_1020005")


	--★★クラリス★★:…安らかに
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","AS_01C_12_1020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_m")
end
