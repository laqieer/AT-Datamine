-- このluaスクリプトは、AS_C.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeCharacter_TextOnly()
end

function Play()
	StartPlayActive()


	--★★女子生徒★★:ギネヴィア様が戻って来たって！<br>みんな前庭に集まってる！
	Talk(Actor002,"NPCNAME_0002","speech","L","AS_01C_01_0010005")


	--★★ノワール★★:なんだって？<br>ギネヴィアが…！？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_01_0010006")

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
