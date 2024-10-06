-- このluaスクリプトは、DW_01C_12_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_12_0030001")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_12_0030002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0030003")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_12_0030004")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_12_0030005")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_12_0030006")

	change_face(Actor002,"Sad")

	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_12_0030007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
end
