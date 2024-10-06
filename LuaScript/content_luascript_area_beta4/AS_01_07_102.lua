-- このluaスクリプトは、AS_01_07_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Tyrfing","101001001","101001001","content_animationpack_101_101tyrf","MotionPack_101Tyrf","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ティルフィング、聞きたいことがあるんだ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_1020002")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:なんでしょうか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AS_01_07_1020003")


	--★★ノワール★★:継承者はどういう存在なんだ？<br>俺がすべきことって一体なんなんだ？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_1020004")


	--★★ティルフィング★★:マスターは、これまでどおりでよいのです<br>正しいと思う道を皆さんと一緒に進んでください
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AS_01_07_1020005")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:それで…<br>たったそれだけでいいのか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_1020006")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:はい。それができる方だからこそ<br>アナタが継承者に選ばれたのだと私は思います
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","AS_01_07_1020007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Tyrfing","101001001","101001001","content_animationpack_101_101tyrf","MotionPack_101Tyrf","Com_Std01_Loop_f")
end
