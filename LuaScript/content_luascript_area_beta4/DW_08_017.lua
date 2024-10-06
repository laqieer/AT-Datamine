-- このluaスクリプトは、DW_08_017.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Vernarth","101052001","101052001","content_animationpack_101_101vern","MotionPack_101Vern","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0170001")

-- ▼直接出力
PlayPartVoice("ヴェルナルス", "挨拶")
-- ▲直接出力

	--★★ヴェルナルス★★:
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DW_08_0170002")


	--★★ヴェルナルス★★:
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DW_08_0170003")

	change_face(Actor002,"Sad")

	--★★ヴェルナルス★★:
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DW_08_0170004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0170005")

	change_face(Actor002,"Normal")

	--★★ヴェルナルス★★:
	Talk(Actor002,"CHRNAME_VERNARTH","speech","L","DW_08_0170006")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0170007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Vernarth","101052001","101052001","content_animationpack_101_101vern","MotionPack_101Vern","Com_Std01_Loop_m")
end
