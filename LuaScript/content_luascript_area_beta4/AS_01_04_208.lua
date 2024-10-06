-- このluaスクリプトは、AS_01_04_208.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ウレリー★★:
	Talk(Actor001,"CHRNAME_URRIE","speech","L","AS_01_04_2080002")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
end
