-- このluaスクリプトは、DW_01C_10_006.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0060001")

-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力

	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_10_0060002")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0060003")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_10_0060004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0060005")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0060006")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_10_0060007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0060008")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_10_0060009")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01C_10_0060010")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_10_0060011")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0060012")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0060013")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_10_0060014")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_10_0060015")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01C_10_0060016")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
end
