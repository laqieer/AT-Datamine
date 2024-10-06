-- このluaスクリプトは、DW_01C_01_010.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0100001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0100002")


	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0100003")


	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0100004")


	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0100005")

	change_face(Actor002,"Normal")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0100006")

-- ▼直接出力
PlayPartVoice("ガレス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガレス★★:
	Talk(Actor002,"CHRNAME_GARETH","speech","L","DW_01C_01_0100007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01C_01_0100008")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Std01_Loop_f")
end
