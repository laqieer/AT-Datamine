Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","ND_00201_010001")

	CloseTalkWindow()

	--[[
		寝る、寝ない選択
		０番を肯定で判定しています。並びを変える場合は対象のindexをSelectMenuItem()に設定してください。
		resource\text\adv2\common.xlsmに仮定義
	]]
	open_select_window_tag(Actor001,"Normal","ND_00201_000","ND_00201_001")

	-- 0始まりで渡す,寝る選択のindeを登録
	if is_select(1) then
        system.SelectMenuItem(0) -- 寝る
	end
	
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
