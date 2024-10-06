-- このluaスクリプトは、AS_01C_10_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:クラリスの容態はどうなんだ？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_1020001")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:大したことなかったみてえだ<br>もう療養院を追い出されて、寮で寝てるぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AS_01C_10_1020002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そうか。じゃ、マーケットで果物でも買って<br>お見舞いに行こうかな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_1020003")

-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:クラリスのことは気にしねえでいい<br>てめえには、やらなきゃならねえことがあんだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AS_01C_10_1020004")


	--★★ノワール★★:仲間のことが最優先だよ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_1020005")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:やれやれ。クラリスにはてめえのこと伝えとく<br>本当に大丈夫だからよ。…悪いな、心配かけて
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","AS_01C_10_1020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
end
