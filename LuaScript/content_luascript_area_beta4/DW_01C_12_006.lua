-- このluaスクリプトは、DW_01C_12_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lucius","101051001","101051001","content_animationpack_101_101luci","MotionPack_101Luci","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0060001")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060002")

	change_face(Actor002,"Surprise")

	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060003")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0060005")

	change_face(Actor002,"Anger")

	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060006")

	change_face(Actor002,"Normal")

	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060007")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0060008")

-- ▼直接出力
PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060009")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01C_12_0060011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0060012")

	change_face(Actor002,"Smile")

	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060013")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060014")

	change_face(Actor002,"Normal")

	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060015")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0060016")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Lucius","101051001","101051001","content_animationpack_101_101luci","MotionPack_101Luci","Com_Std01_Loop_m")
end
