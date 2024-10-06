-- このluaスクリプトは、DW_01A_12_010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01A_12_0100001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0100002")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01A_12_0100003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0100004")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01A_12_0100005")

-- ▼直接出力
PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01A_12_0100006")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_12_0100007")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01A_12_0100008")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01A_12_0100009")

	change_face(Actor002,"Normal")

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01A_12_0100010")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end
