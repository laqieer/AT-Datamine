-- このluaスクリプトは、DW_01A_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Liam","101064001","101064001","content_animationpack_101_101liam","MotionPack_101Liam","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01A_10_0010001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0010002")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01A_10_0010003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0010004")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01A_10_0010005")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01A_10_0010006")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01A_10_0010007")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01A_10_0010008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_10_0010009")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01A_10_0010010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Liam","101064001","101064001","content_animationpack_101_101liam","MotionPack_101Liam","Com_Std01_Loop_m")
end