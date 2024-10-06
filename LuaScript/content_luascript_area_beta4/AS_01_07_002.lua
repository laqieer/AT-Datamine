-- このluaスクリプトは、AS_common.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ギネマウアさん<br>昼に補講をやるって言ってたけど
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0020004")


	--★★ノワール★★:なんの補講なんだ？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0020005")


	--★★ノワール★★:とりあえず集合時間が近いし<br>ディナタンとマルディサントをさがそう
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0020006")

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
