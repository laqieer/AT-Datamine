-- このluaスクリプトは、DW_06_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0210001")


	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","DW_06_0210002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0210003")


	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","DW_06_0210004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0210005")


	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","DW_06_0210006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0210007")


	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","DW_06_0210008")


	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","DW_06_0210009")


	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","DW_06_0210010")


	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","DW_06_0210011")

	change_face(Actor002,"Smile")

	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","DW_06_0210012")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0210013")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","DW_06_0210014")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end
