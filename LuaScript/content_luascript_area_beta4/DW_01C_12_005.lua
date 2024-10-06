-- このluaスクリプトは、DW_01C_12_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Rola","101038001","101038001","content_animationpack_101_101rola","MotionPack_101Rola","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ローラ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01C_12_0050001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0050002")


	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01C_12_0050003")


	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01C_12_0050004")


	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01C_12_0050005")


	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01C_12_0050006")


	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01C_12_0050007")


	--★★ローラ★★:
	Talk(Actor002,"CHRNAME_LOLA","speech","L","DW_01C_12_0050008")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Rola","101038001","101038001","content_animationpack_101_101rola","MotionPack_101Rola","Com_Std01_Loop_f")
end
