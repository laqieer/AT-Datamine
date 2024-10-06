-- このluaスクリプトは、DW_01A_11_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("マルディサント", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01A_11_0030001")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01A_11_0030002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01A_11_0030003")

	change_face(Actor002,"Normal")

	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01A_11_0030004")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01A_11_0030005")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01A_11_0030006")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01A_11_0030007")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01A_11_0030008")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01A_11_0030009")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01A_11_0030010")


	--★★マルディサント★★:
	Talk(Actor002,"CHRNAME_MALADISANT","speech","L","DW_01A_11_0030011")


	--★★トリスタン★★:
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","DW_01A_11_0030012")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Com_Std01_Loop_m")
end
