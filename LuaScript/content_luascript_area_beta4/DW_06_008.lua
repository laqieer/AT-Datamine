-- このluaスクリプトは、DW_06_008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ディナタン", "挨拶")
-- ▲直接出力

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_06_0080001")

-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力

	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_06_0080002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0080003")


	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_06_0080004")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_06_0080005")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_06_0080006")


	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_06_0080007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0080008")


	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_06_0080009")


	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_06_0080010")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_06_0080011")

-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_06_0080012")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_06_0080013")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
end
