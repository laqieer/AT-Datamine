-- このluaスクリプトは、AS_01A_09_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:なあ、ケイ。ロンディニウムの件で<br>なにか俺にできることってないかな？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_09_1020001")


	--★★ケイ★★:貴公にできること？
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01A_09_1020002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:情報を集めるのでも<br>疑いを晴らす意味で街の復興を手伝うのでも
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_09_1020003")

-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:ふむ。復興について動き出している者がいる<br>機を見て彼らの手助けをしてやってくれ
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01A_09_1020004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:わかった<br>話を聞いてみたい。今どこにいるんだ？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_09_1020005")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:今は忙しく動いてくれている<br>いずれ出会うことになるはずだ
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01A_09_1020006")

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
