-- このluaスクリプトは、DW_01C_01_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Isolde","101019001","101019001","content_animationpack_101_101isol","MotionPack_101Isol","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0020001")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_01_0020002")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_01_0020003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0020004")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_01_0020005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0020006")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_01_0020007")


	--★★イゾルデ★★:
	Talk(Actor002,"CHRNAME_ISOLDE","speech","L","DW_01C_01_0020008")

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
end
