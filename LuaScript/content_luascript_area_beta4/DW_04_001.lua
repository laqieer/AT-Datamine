-- このluaスクリプトは、DW_04_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0010001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0010002")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0010003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0010004")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0010005")

	change_face(Actor001,"Anger")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0010006")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0010007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end
