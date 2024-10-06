-- このluaスクリプトは、DW_01C_01_009.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lucius","101051001","101051001","content_animationpack_101_101luci","MotionPack_101Luci","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力

	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_01_0090001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0090002")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_01_0090003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0090004")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_01_0090005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0090006")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_01_0090007")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_01_0090008")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0090009")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_01_0090010")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_01_0090011")

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
