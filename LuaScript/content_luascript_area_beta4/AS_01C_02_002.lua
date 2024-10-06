-- このluaスクリプトは、AS_C.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ディナタン★★:兄さん、どうしたの？<br>こんなところに来るなんて珍しいね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01C_02_0010002")


	--★★ノワール★★:大聖堂に行く途中で少し寄っただけで<br>とくに用事があるわけじゃないんだ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_02_0010007")


	--★★ディナタン★★:そうなんだ。それならいいんだけど<br>ところで兄さん、あのね…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01C_02_0010008")


	--★★ディナタン★★:…ううん、やっぱりいいや<br>もう少し、ちゃんと整理してから話すね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01C_02_0010009")


	--★★ノワール★★:そうか？<br>それならいいけど
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_02_0010010")

	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end
