-- このluaスクリプトは、AS_common.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ギネヴィア★★:ノワール！<br>今日はいよいよ五月女王の発表よ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01_05_0020007")


	--★★ノワール★★:妙に張り切ってるな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_0020008")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:主役だもの、張り切って当然でしょ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01_05_0020009")


	--★★ノワール★★:主役ねえ…<br>選ばれるといいな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_0020010")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:選ばれるにきまってるじゃない<br>むしろ、わたし以外の誰が女王になるの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01_05_0020011")


	--★★ギネヴィア★★:…って<br>こんなところで話しこんでる場合じゃないわ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01_05_0020012")


	--★★ギネヴィア★★:主役が会場にいなかったらみんなガッカリよ<br>早く行きましょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01_05_0020013")

	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end
