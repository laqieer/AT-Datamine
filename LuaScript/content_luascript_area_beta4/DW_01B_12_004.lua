-- このluaスクリプトは、DW_01B_12_004.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Dindrane","101027001","101027001","content_animationpack_101_101dind","MotionPack_101Dind","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ディンドラン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_12_0040001")

	change_face(Actor002,"Smile")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_12_0040002")


	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_12_0040003")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0040004")

	change_face(Actor002,"Normal")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_12_0040005")

	change_face(Actor003,"Normal")

	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_12_0040006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_12_0040007")


	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_12_0040008")


	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_12_0040009")

-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_01B_12_0040010")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01B_12_0040011")

	change_face(Actor003,"Sad")

	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_12_0040012")


	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_12_0040013")

	change_face(Actor003,"Normal")

	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_12_0040014")


	--★★ディンドラン★★:
	Talk(Actor003,"CHRNAME_DINDRANE","speech","L","DW_01B_12_0040015")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Dindrane","101027001","101027001","content_animationpack_101_101dind","MotionPack_101Dind","Com_Std01_Loop_f")
end
