-- このluaスクリプトは、AS_B.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ここは先輩として<br>しっかり案内してあげないとな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_10_0010005")


	--★★ノワール★★:この時間だと、トリスタンは音楽室か…？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_10_0010006")

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
