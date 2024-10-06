-- このluaスクリプトは、DW_04_008.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
	Actor003 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ふたりでなにを？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0080001")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さん…私、最近廊下で変な視線を沢山感じるような気がするの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0080002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:変な視線？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0080003")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0007")
-- ▲直接出力

	--★★ランスロット★★:ああ、それで相談を受けていたんだ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","DW_04_0080004")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタンの気のせいなんじゃないか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0080005")

-- ▼直接出力
PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:違うよ！たしかに最初は私の勘違いかなとも思ったけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0080006")


	--★★ディナタン★★:何度も何度も感じるの！あれは絶対、気のせいなんかじゃないよ！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0080007")


	--★★ランスロット★★:ディナタンも傭兵経験があるんだろう？危険を察知する力は鍛えられているはずだ
	Talk(Actor003,"CHRNAME_LANCELOT","speech","L","DW_04_0080008")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん…？まあ、俺も気にかけておくけどさ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0080009")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:お願いね、ふたりとも
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","DW_04_0080010")

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
	InitializeActiveCharacter_Preload("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end
