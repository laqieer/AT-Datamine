-- このluaスクリプトは、DW_04_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0110001")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0110002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0110003")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0110004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0110005")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0110006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0110007")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0110008")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0110009")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0110010")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0110011")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0110012")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0110013")

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
