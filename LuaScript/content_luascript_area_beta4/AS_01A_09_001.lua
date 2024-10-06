-- このluaスクリプトは、AS_A.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:号外に書いてあった日付って<br>確か今日だったよな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_09_0010003")


	--★★ノワール★★:ギネヴィアが<br>なにを話すつもりなのかはわからないけど
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_09_0010004")


	--★★ノワール★★:俺のこともいろいろ書かれてたし…<br>講堂をのぞいて見たほうが良さそうだな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_09_0010005")

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
