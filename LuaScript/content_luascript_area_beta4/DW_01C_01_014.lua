-- このluaスクリプトは、DW_01C_01_014.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_01_0140001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0140002")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_01_0140003")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_01_0140004")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0140005")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_01_0140006")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_01_0140007")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_01_0140008")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_01_0140009")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_01_0140010")


	--★★モルドレッド★★:
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","DW_01C_01_0140011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0140012")

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
