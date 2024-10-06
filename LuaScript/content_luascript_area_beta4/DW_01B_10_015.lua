-- このluaスクリプトは、DW_01B_10_015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("マーリン", "挨拶")
-- ▲直接出力

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0150002")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150003")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150004")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150005")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0150006")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0150007")

-- ▼直接出力
PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0150009")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0150010")

	change_face(Actor002,"Sad")

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150011")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150012")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150013")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150014")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0150015")

-- ▼直接出力
PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150016")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0150017")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150018")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0150019")


	--★★マーリン★★:
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","DW_01B_10_0150020")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_10_0150021")

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
