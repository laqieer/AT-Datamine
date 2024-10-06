-- このluaスクリプトは、DW_01C_11_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lioness","101033001","101033001","content_animationpack_101_101lyon","MotionPack_101Lyon","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リオネス★★:
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","DW_01C_11_0030001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0030002")


	--★★リオネス★★:
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","DW_01C_11_0030003")


	--★★リオネス★★:
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","DW_01C_11_0030004")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_11_0030005")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Lioness","101033001","101033001","content_animationpack_101_101lyon","MotionPack_101Lyon","Com_Std01_Loop_f")
end
