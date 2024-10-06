-- このluaスクリプトは、DW_01A_11_008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_11_0080001")

-- ▼直接出力
PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DW_01A_11_0080002")


	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DW_01A_11_0080003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0080004")

	change_face(Actor003,"Normal")

	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DW_01A_11_0080005")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_11_0080006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0080007")


	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_11_0080008")

	change_face(Actor003,"Smile")

	--★★マーリン★★:
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","DW_01A_11_0080009")

-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","DW_01A_11_0080010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end
