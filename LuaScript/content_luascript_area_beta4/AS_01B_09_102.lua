-- このluaスクリプトは、AS_01B_09_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ディナタン★★:兄さん、どうしたの？<br>なにか用事？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01B_09_1020001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:えっと…<br>弔いの花はなにがいいのかなって、聞きに来た
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_09_1020002")


	--★★ディナタン★★:ブライアンさんは派手な色で大きな花が好きそう<br>…私が兄さんのぶんも用意しておこうか？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01B_09_1020003")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:いや、大丈夫。自分で準備するよ<br>それだけじゃなくてさ、その…大丈夫か？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_09_1020004")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:…気を遣ってきてくれたんだよね、ありがとう<br>兄さんが話したいこと、なんとなくわかるよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01B_09_1020005")


	--★★ディナタン★★:本当は、今感じてる以上に悲しいはずなんだよね<br>だから、盛大に弔ってあげなきゃ…みんなを
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01B_09_1020006")

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
