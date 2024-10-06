-- このluaスクリプトは、DW_01C_12_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lucius","101051001","101051001","content_animationpack_101_101luci","MotionPack_101Luci","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0070001")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0070002")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0070003")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0070004")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0070005")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0070006")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_01C_12_0070007")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_12_0070008")

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
