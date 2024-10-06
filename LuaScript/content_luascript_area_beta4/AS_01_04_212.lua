-- このluaスクリプトは、AS_01_04_212.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
	Actor002 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ウレリー★★:
	Talk(Actor001,"CHRNAME_URRIE","speech","L","AS_01_04_2120002")

	change_face(Actor002,"Smile")

	--★★ノワール★★:
	Talk(Actor002,"PLAYERNAME_NOIR","speech","L","AS_01_04_2120003")


	--★★ウレリー★★:
	Talk(Actor001,"CHRNAME_URRIE","speech","L","AS_01_04_2120004")


	--★★ウレリー★★:
	Talk(Actor001,"CHRNAME_URRIE","speech","L","AS_01_04_2120005")


	--★★ウレリー★★:
	Talk(Actor001,"CHRNAME_URRIE","speech","L","AS_01_04_2120006")

	change_face(Actor001,"Smile")

	--★★ウレリー★★:
	Talk(Actor001,"CHRNAME_URRIE","speech","L","AS_01_04_2120007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end
