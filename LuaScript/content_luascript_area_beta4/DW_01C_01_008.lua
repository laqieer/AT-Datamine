-- このluaスクリプトは、DW_01C_01_008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Liam","101064001","101064001","content_animationpack_101_101liam","MotionPack_101Liam","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("リアム", "挨拶")
-- ▲直接出力

	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01C_01_0080001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0080002")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01C_01_0080003")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01C_01_0080004")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01C_01_0080005")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0080006")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01C_01_0080007")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01C_01_0080008")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01C_01_0080009")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01C_01_0080010")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0080011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0080012")

	change_face(Actor002,"Smile")

	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01C_01_0080013")

	change_face(Actor002,"Sad")

	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","mind","L","DW_01C_01_0080014")

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
