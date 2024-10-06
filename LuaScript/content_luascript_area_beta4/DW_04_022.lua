-- このluaスクリプトは、DW_04_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("Ragnar","101018001","101018001","content_animationpack_101_101ragn","MotionPack_101Ragn","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:よぉ、転校生
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0220001")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0005")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ラグネル★★:こんばんは！
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_04_0220002")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0004")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:こんばんは、ふたりとも
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0220003")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだろ？今日はこんな時間になっても寮の中が騒がしい気がする
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0220004")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0007")
-- ▲直接出力

	--★★ガウェイン★★:五月祭が近いからな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0220005")


	--★★ガウェイン★★:準備だなんだで遅くまで起きてる奴が多いんじゃね？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0220006")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そういうガウェインもなにか五月祭の準備してるのか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0220007")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:ん？いや、俺は別に当日、店を出す知り合いの手伝いはするけどよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0220008")


	--★★ラグネル★★:ガウェインは困ってる人がいたら放っておけないもんね
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_04_0220009")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:へへっ、まーな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0220010")


	--★★ノワール★★:よければ俺も手伝うよ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0220011")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:いや、手伝ってもらうほどの量じゃねーよ気持ちだけ受け取っとくぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0220012")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0007")
-- ▲直接出力

	--★★ラグネル★★:入学試験も終わってひと段落したんだし今はちゃんと休んだほうがいいんじゃない？
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","DW_04_0220013")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0008")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:そうそう五月祭を楽しむためにもな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","DW_04_0220014")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力

	--★★ノワール★★:わかった。そうさせてもらうよ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0220015")

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
