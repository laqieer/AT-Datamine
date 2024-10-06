-- このluaスクリプトは、DW_01C_11_008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Larou","101061001","101061001","content_animationpack_101_101laro","MotionPack_101Laro","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0080001")


	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01C_11_0080002")


	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01C_11_0080003")

	change_face(Actor001,"Anger")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0080004")

	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01C_11_0080005")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0080006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0080007")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01C_11_0080008")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0080009")

	change_face(Actor001,"Anger")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0080010")


	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01C_11_0080011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0080012")

	change_face(Actor002,"Smile")

	--★★ラロゥ★★:
	Talk(Actor002,"CHRNAME_LAROU","speech","L","DW_01C_11_0080013")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Larou","101061001","101061001","content_animationpack_101_101laro","MotionPack_101Laro","Com_Std01_Loop_m")
end
