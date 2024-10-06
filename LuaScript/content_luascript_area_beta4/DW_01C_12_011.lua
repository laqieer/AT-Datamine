-- このluaスクリプトは、DW_01C_12_011.csvから自動生成されました --
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

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0110001")

	change_face(Actor002,"Smile")

	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01C_12_0110002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0110003")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0110004")

	change_face(Actor002,"Normal")

	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01C_12_0110005")


	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01C_12_0110006")

-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:
	Talk(Actor002,"CHRNAME_MARIL","speech","L","DW_01C_12_0110007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0110008")

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
