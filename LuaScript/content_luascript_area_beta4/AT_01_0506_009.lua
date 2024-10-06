-- このluaスクリプトは、AT_01.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack__common","MotionPack","Sri_Std_loop_m")
	Actor002 = InitializeActiveCharacter("season_LM1b_Middleman","401019001","401019001","content_animationpack__common","MotionPack","Sri_Std_loop_m")
end

function Play()
	StartPlayActive()


	--★★市民（中年男）★★:五月祭、ログレスの外からも<br>見物客が来てくれたのは良かったんだけどさ
	Talk(Actor002,"NPCNAME_0316","speech","N","AT_01_0506_00901")


	--★★市民（中年男）★★:ゴミの量がすごくて、片付けが大変だったよ<br>盛り上がりすぎるってのも考え物だな
	Talk(Actor002,"NPCNAME_0316","speech","N","AT_01_0506_00902")

	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack__common","MotionPack","Sri_Std_loop_m")
	InitializeActiveCharacter_Preload("season_LM1b_Middleman","401019001","401019001","content_animationpack__common","MotionPack","Sri_Std_loop_m")
end
