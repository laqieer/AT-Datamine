-- このluaスクリプトは、AS_01B_01_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ランスロット★★:なあ、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01B_01_1040001")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:なんだ？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_1040002")


	--★★ランスロット★★:師匠は悩まずに決断できたんだろうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01B_01_1040003")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…悩んだと思う<br>悩んで悩んで、悩みぬいて決断したんだと思う
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_1040004")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力

	--★★ランスロット★★:そうか。強い人だったものな、師匠は<br>俺はまだ迷っている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01B_01_1040005")


	--★★ランスロット★★:だがいつまで迷うことは許されない<br>あいつのためにも。お前が進む道のためにも
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01B_01_1040006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end
