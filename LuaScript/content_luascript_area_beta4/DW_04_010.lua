-- このluaスクリプトは、DW_04_010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0100001")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0100002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0100003")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0100004")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0100005")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0100006")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0100007")

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
end
