-- このluaスクリプトは、AS_01_05_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ケイ★★:なにか用か？<br>私は出陣の準備で忙しいのだが
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01_05_1040002")


	--★★ノワール★★:そう思って手伝いに来たんだ<br>なにか俺にできることはないか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_1040003")

	change_face(Actor002,"Normal")

	--★★ケイ★★:貴公も潜入任務を控えた身だろうが
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01_05_1040004")


	--★★ノワール★★:もう準備は整えた<br>だから、今の俺にできることがないかと思って…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_1040005")

-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力

	--★★ケイ★★:殊勝な心掛けだが、<br>貴公は貴公の任務に集中にするべきだな
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01_05_1040006")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…わかった<br>俺の手が必要な何かが生じたら声を掛けてくれ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_1040007")

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
