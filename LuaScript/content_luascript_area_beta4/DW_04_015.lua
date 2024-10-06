-- このluaスクリプトは、DW_04_015.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力

	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150001")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_04_0150002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0150003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0150004")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150005")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150006")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_04_0150007")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0150008")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_04_0150009")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150010")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_04_0150011")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150012")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_04_0150013")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150014")

-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_04_0150015")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150016")


	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_04_0150017")

	change_face(Actor003,"Smile")

	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150018")

-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラグネル★★:
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","DW_04_0150019")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150020")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0150021")


	--★★ガウェイン★★:
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","DW_04_0150022")

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
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end
