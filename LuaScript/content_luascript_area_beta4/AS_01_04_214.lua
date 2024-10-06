-- このluaスクリプトは、AS_01_04_214.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Morgan","101041001","101041001","content_animationpack_101_101morg","MotionPack_101Morg","Morgan_Sit_loop")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Surprise")

	--★★モルガン★★:
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","AS_01_04_2140002")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_2140003")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_2140004")

	change_face(Actor002,"Normal")

	--★★モルガン★★:
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","AS_01_04_2140005")


	--★★モルガン★★:
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","AS_01_04_2140006")


	--★★モルガン★★:
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","AS_01_04_2140007")


	--★★モルガン★★:
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","AS_01_04_2140008")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Morgan","101041001","101041001","content_animationpack_101_101morg","MotionPack_101Morg","Morgan_Sit_loop")
end
