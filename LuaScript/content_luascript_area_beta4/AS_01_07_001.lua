-- このluaスクリプトは、AS_common.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ブライアンは<br>あのあと牢に入れられたって聞いたけど
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0010005")


	--★★ノワール★★:ケガは大丈夫なんだろうか？<br>心配だな…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0010006")


	--★★ノワール★★:様子を見に行かせてもらえないか<br>ランスロットに相談してみよう
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0010007")

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
