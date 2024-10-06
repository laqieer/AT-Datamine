-- このluaスクリプトは、AS_01C_11_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ケイ<br>俺に用事ってのは？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_11_1020001")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:パーシヴァルから<br>お前宛に渡されていた手紙があってな…これだ
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01C_11_1020002")


	--★★ノワール★★:えーっと…「ぼくはぼくの責務を果たす<br>キミも継承者としての責務を果たしたまえ」
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_11_1020003")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どういうことだ？<br>パーシヴァルはなにを俺に伝えたいんだろう？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_11_1020004")


	--★★ケイ★★:真意はわからんが、一種の決意表明なのだろう<br>尊重してやってくれ
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01C_11_1020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:わかった<br>なんだろう、嫌な胸騒ぎがするけど…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_11_1020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end
