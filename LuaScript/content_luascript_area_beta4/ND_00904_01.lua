Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010001")

	open_select_window_tag(Actor001,"Normal","ND_00904_010002","ND_00904_010003","ND_00904_010004","ND_00904_010005")

	if is_select(1) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010007")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010008")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010009")

	elseif is_select(2) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010011")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010012")

	elseif is_select(3) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010014")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010015")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010016")

	elseif is_select(4) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00904_010018")

	end

	CloseTalkWindow()

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end
