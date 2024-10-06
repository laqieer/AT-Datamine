-- このluaスクリプトは、DW_01B_09_008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01B_09_0080001")

-- ▼直接出力
PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_09_0080002")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0080003")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_09_0080004")


	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_09_0080005")

-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01B_09_0080006")

	change_face(Actor003,"Anger")

	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_09_0080007")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","DW_01B_09_0080008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_01B_09_0080009")

	change_face(Actor002,"Smile")

	--★★ギネマウア★★:
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","DW_01B_09_0080010")


	--★★ノワール★★:
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_01B_09_0080011")

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
	InitializeActiveCharacter_Preload("Maladisant","101017001","101017001","content_animationpack_101_101mala","MotionPack_101Mala","Com_Std01_Loop_f")
end
