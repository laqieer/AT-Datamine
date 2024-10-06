-- このluaスクリプトは、DW_01B_10_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Liam","101064001","101064001","content_animationpack_101_101liam","MotionPack_101Liam","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01B_10_0030001")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0030002")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01B_10_0030003")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0030004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0030005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0030006")

-- ▼直接出力
PlayPartVoice("リアム", "悩む")
-- ▲直接出力

	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01B_10_0030007")


	--★★リアム★★:
	Talk(Actor002,"CHRNAME_LIAM","speech","L","DW_01B_10_0030008")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0030009")

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
