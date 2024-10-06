Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010001")

	open_select_window_tag(Actor001,"Normal","ND_00901_010002","ND_00901_010003","ND_00901_010004","ND_00901_010005")

	if is_select(1) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010007")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010008")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010009")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010010")

	elseif is_select(2) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010012")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010013")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010014")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010015")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010016")

	elseif is_select(3) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010018")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010019")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010020")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010021")

	elseif is_select(4) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00901_010023")

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
