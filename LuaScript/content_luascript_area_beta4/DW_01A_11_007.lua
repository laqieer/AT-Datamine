-- このluaスクリプトは、DW_01A_11_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
voice_play("VO_101012_sp_0001_1")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070001")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0070002")

-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070003")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0070004")

-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0007")
-- ▲直接出力

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070005")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070006")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0070008")

-- ▼直接出力
PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070009")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0070011")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070012")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0070013")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070014")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_01A_11_0070015")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0070016")

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