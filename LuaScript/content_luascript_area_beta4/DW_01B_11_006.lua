-- このluaスクリプトは、DW_01B_11_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_11_0060001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0060002")

-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_11_0060003")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0060004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0060005")

-- ▼直接出力
PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_11_0060006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0060007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0060008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0060009")

-- ▼直接出力
PlayPartVoice("マーリン", "悩む")
-- ▲直接出力

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_11_0060010")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_11_0060011")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_11_0060012")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_11_0060013")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end
