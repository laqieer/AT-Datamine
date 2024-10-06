-- このluaスクリプトは、DW_01B_11_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01B_11_0010001")

-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_11_0010002")


	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_11_0010003")

-- ▼直接出力
PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_11_0010004")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0010005")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01B_11_0010006")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0010007")


	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_11_0010008")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01B_11_0010009")

-- ▼直接出力
PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力

	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_11_0010010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_11_0010011")

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
