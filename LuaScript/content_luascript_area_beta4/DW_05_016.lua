-- このluaスクリプトは、DW_05_016.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ラグネル", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160001")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0160002")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160003")


	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0160004")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0160005")

	change_face(Actor003,"Smile")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160006")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0160007")


	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160008")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0160009")

	change_face(Actor003,"Sad")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160010")

	change_face(Actor003,"Normal")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160011")

	change_face(Actor002,"Surprise")

	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0160012")


	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160013")


	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160014")


	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160015")

	change_face(Actor003,"Smile")

	--★★ラグネル★★:
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_05_0160016")

-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0160017")


	--★★ギネマウア★★:
	Talk(Actor002,"NPCNAME_0070","speech","L","DW_05_0160018")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0160019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_05_0160020")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end
