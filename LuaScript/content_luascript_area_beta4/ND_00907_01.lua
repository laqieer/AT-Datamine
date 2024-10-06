Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010001")

	open_select_window_tag(Actor001,"Normal","ND_00907_010002","ND_00907_010003","ND_00907_010004","ND_00907_010005","ND_00907_010006")

	if is_select(1) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010008")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010009")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010010")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010011")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010012")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010013")

	elseif is_select(2) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010015")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010016")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010017")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010018")

	elseif is_select(3) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010020")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010021")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010022")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010023")

	elseif is_select(4) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010025")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010026")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010027")
		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010028")

	elseif is_select(5) then

		Talk(Actor001,"PLAYERNAME_NOIR","speech","L","ND_00907_010030")

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
