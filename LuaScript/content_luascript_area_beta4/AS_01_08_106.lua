-- このluaスクリプトは、AS_01_08_106.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:あ…ノワール<br>その…もう大丈夫なの？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01_08_1060002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:おかげさまで<br>みんなに心配かけ続けるわけにはいかないしな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1060003")

	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:焦らなくていいわよ<br>時間をかけてゆっくり消化しなさい
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01_08_1060004")


	--★★ギネヴィア★★:わたしたち、ちゃんと待っててあげるから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01_08_1060005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ありがとう、ギネヴィア
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1060006")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:にしし♪<br>どういたしまして
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01_08_1060007")

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
