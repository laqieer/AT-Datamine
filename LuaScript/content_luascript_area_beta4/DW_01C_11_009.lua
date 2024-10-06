-- このluaスクリプトは、DW_01C_11_009.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("イゾルデ", "落胆")
-- ▲直接出力

	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_11_0090001")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_11_0090002")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01C_11_0090003")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_11_0090004")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01C_11_0090005")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_11_0090006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0090007")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_11_0090008")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_11_0090009")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01C_11_0090010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0090011")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01C_11_0090012")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end
