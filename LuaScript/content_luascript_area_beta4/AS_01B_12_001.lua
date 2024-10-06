-- このluaスクリプトは、AS_B.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ガラハッドが言ってる非行少女って<br>多分、マルディサントのことだよな…？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_12_0010005")


	--★★ノワール★★:つまり、療養院まで<br>一緒に行って欲しいってことか
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_12_0010006")

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
