-- このluaスクリプトは、DW_01A_11_015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Maril","101062001","101062001","content_animationpack_101_101mari","MotionPack_101Mari","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0150001")


	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01A_11_0150002")


	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01A_11_0150003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0150004")


	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01A_11_0150005")

-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01A_11_0150006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0150007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0150008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0150009")


	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01A_11_0150010")


	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01A_11_0150011")


	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01A_11_0150012")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0150013")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Maril","101062001","101062001","content_animationpack_101_101mari","MotionPack_101Mari","Com_Std01_Loop_m")
end
