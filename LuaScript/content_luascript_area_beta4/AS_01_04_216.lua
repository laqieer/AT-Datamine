-- このluaスクリプトは、AS_01_04_216.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor001,"Smile")

	--★★ガレス★★:
	Talk(Actor001,"NPCNAME_0072","speech","L","AS_01_04_2160002")

	change_face(Actor001,"Sad")

	--★★ガレス★★:
	Talk(Actor001,"NPCNAME_0072","speech","L","AS_01_04_2160003")


	--★★ガレス★★:
	Talk(Actor001,"NPCNAME_0072","speech","L","AS_01_04_2160004")

	change_face(Actor001,"Normal")

	--★★ガレス★★:
	Talk(Actor001,"NPCNAME_0072","speech","L","AS_01_04_2160005")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
end
