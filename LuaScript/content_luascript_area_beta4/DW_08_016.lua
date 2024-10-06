-- このluaスクリプトは、DW_08_016.csvから自動生成されました --
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
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0160001")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_08_0160002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0160003")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_08_0160004")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0160005")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_08_0160006")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_08_0160007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0160008")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_08_0160009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0160010")

-- ▼直接出力
PlayPartVoice("ルーシャス", "怒り")
-- ▲直接出力

	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_08_0160011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_08_0160012")


	--★★ルーシャス★★:
	Talk(Actor002,"CHRNAME_LUCIUS","speech","L","DW_08_0160013")

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
