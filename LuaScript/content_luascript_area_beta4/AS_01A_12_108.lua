-- このluaスクリプトは、AS_01A_12_108.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:この前さ<br>エレインとお話、したんだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01A_12_1080001")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:どんな話？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1080002")


	--★★ギネヴィア★★:元気になったらまた一緒に笑おうね、って話
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01A_12_1080003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:今度の戦いが終わったら<br>またみんなで笑い合える日が来るよ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1080004")


	--★★ギネヴィア★★:うん、きっと来るよね<br>ノワールがそうしてくれるよね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01A_12_1080005")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:あとね、約束っぽいこともしたんだ<br>「覚悟する」って。だから…頑張らなきゃ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","AS_01A_12_1080006")

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
