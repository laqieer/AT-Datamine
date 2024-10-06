-- このluaスクリプトは、AS_01A_12_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("エクセリア", "怒り")
-- ▲直接出力

	--★★エクセリア★★:どうしたの？<br>なにか用かしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AS_01A_12_1020001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ガラハッドのこと<br>俺からも改めて謝罪させて欲しいんだ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1020002")


	--★★エクセリア★★:謝罪は受け取らないと言ったはずよ<br>あなたが責任を感じる必要はないわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AS_01A_12_1020003")


	--★★エクセリア★★:ただ…謝罪は受け取らないと言ったけれど<br>あなたたちの気持ちは伝わった
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AS_01A_12_1020004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:エクセリア…！<br>ありがとう、ギネヴィアも喜ぶよ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1020005")

-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:あなたたちがいるログレスは信頼がおける<br>微力ながら、今後も協力させてもらうわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","AS_01A_12_1020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Excelia","101034001","101034001","content_animationpack_101_101exce","MotionPack_101Exce","Com_Std01_Loop_f")
end
