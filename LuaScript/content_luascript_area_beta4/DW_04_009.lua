-- このluaスクリプトは、DW_04_009.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ラグネル★★:いや、だからね？そうじゃなくて、こう。わかる？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_04_0090001")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:全然わかんねー、言ってることはわかるけど納得ができねえ、なんでこうなんの？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0090002")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0033")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラグネル★★:ちゃんと先生が説明してくれたでしょ！？寝てたガウェインが悪い！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_04_0090003")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0019")
-- ▲直接出力

	--★★ガウェイン★★:そう言わずにさ～頼むよ、教えてくれ！ラグネル先生！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0090004")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0004")
-- ▲直接出力

	--★★ノワール★★:ふたりとも、それは今日出た宿題か？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0090005")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0028")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ラグネル★★:ノワール！ちょうどいいところに！ノワールはもう宿題やった？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_04_0090006")


	--★★ノワール★★:いやこれから部屋に戻ってやろうと思ってたところ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0090007")


	--★★ラグネル★★:じゃ、ここで一緒にやろうよ！ガウェインに問題の解きかたを教えてほしいの
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_04_0090008")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いいよ、わかった教科書を取ってくるから少し待っててくれ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0090009")

-- ▼直接出力
PlayPartVoice("ラグネル", "喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラグネル★★:わーい！ありがと！ガウェイン良かったね！先生が増えたよ！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_04_0090010")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:よ、よし！やってやるぜ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0090011")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end
