Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	Talk(Actor002,"CHRNAME_URRIE","speech","L","AS_01_04_2200002")
	Talk(Actor002,"CHRNAME_URRIE","speech","L","AS_01_04_2200003")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
end
