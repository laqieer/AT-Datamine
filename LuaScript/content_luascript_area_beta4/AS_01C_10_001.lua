-- このluaスクリプトは、AS_C.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	open_narration_window()
		message("AS_01C_10_0011001")
		message("AS_01C_10_0011002")
		message("AS_01C_10_0011003")
		message("AS_01C_10_0011004")
		message("AS_01C_10_0011005")
	close_narration_window()

	wait_time(1.0)

	--★★ノワール★★:やっと戻ってこられた<br>なんだか懐かしいな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_0010004")


	--★★ノワール★★:あの森に飛ばされてから１ヶ月しか<br>経ってないなんて、いまだに信じられない
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_0010005")


	--★★ノワール★★:とりあえず、学園に顔を出そう<br>ずいぶん心配かけちゃったみたいだし
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_0010006")


	--★★ノワール★★:…みんな、元気かな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_0010007")

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
