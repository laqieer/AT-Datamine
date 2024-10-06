-- このluaスクリプトは、DW_04_007.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ギネヴィア…王妃の部屋はこの宿舎じゃなくて王城にあるんじゃないのか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0070001")


	--★★ギネヴィア★★:わたしがここにいちゃだめなわけ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_04_0070002")


	--★★ノワール★★:いや、単純な疑問というか…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0070003")


	--★★ギネヴィア★★:わたしはね、宿舎に部屋が欲しいって言ったのみんなと同じようにね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_04_0070004")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:けど立場的にちゃんとしなきゃならないらしくて王妃の部屋が設けられちゃった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_04_0070005")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:でもさ～、女学生といえばアレでしょ？夜にワクワク秘密のパジャマパーティでしょ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_04_0070006")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ワクワク秘密のパジャマパーティがしたいのか
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","DW_04_0070007")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0015")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:べっ、つにィッ！？誘われ待ちしてるわけじゃアないッ、しィッ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_04_0070008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（誘われないんだろうな…一国の王妃を自室に招くなんてリスキーだし）
	Talk(Actor001,"PLAYERNAME_NOIR","mind","L","DW_04_0070009")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ああっあとちょっとで侍女が迎えに来ちゃう…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","DW_04_0070010")

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
