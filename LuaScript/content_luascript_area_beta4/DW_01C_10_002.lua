-- このluaスクリプトは、DW_01C_10_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dindrane","101027001","101027001","content_animationpack_101_101dind","MotionPack_101Dind","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ディンドラン★★:
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DW_01C_10_0020001")


	--★★ディンドラン★★:
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DW_01C_10_0020002")


	--★★ディンドラン★★:
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DW_01C_10_0020003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0020004")


	--★★ディンドラン★★:
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DW_01C_10_0020005")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0020006")

-- ▼直接出力
PlayPartVoice("ディンドラン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディンドラン★★:
	Talk(Actor002,"CHRNAME_DINDRANE","speech","L","DW_01C_10_0020007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_10_0020008")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Dindrane","101027001","101027001","content_animationpack_101_101dind","MotionPack_101Dind","Com_Std01_Loop_f")
end
