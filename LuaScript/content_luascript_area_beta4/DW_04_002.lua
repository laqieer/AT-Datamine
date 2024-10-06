-- このluaスクリプトは、DW_04_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","DW_04_0020001")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0020002")


	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","DW_04_0020003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0020004")


	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","DW_04_0020005")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0020006")


	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","DW_04_0020007")


	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","DW_04_0020008")

	change_face(Actor002,"Smile")

	--★★ウレリー★★:
	Talk(Actor002,"CHRNAME_URRIE","speech","L","DW_04_0020009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0020010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
end
