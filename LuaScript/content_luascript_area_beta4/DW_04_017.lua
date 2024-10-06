-- このluaスクリプトは、DW_04_017.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_04_0170001")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0170002")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_04_0170003")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0170004")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_04_0170005")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_04_0170006")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_04_0170007")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_04_0170008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0170009")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_04_0170010")


	--★★ケイ★★:
	Talk(Actor002,"CHRNAME_KAY","speech","L","DW_04_0170012")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end
