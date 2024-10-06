-- このluaスクリプトは、DW_01B_01_005.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_01_0050001")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_01_0050002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0050003")

-- ▼直接出力
PlayPartVoice("エクセリア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_01_0050004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0050005")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_01_0050006")


	--★★エクセリア★★:
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","DW_01B_01_0050007")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_01_0050008")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
end
