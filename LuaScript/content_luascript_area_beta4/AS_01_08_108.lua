-- このluaスクリプトは、AS_01_08_108.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ランスロット★★:その顔を見るかぎり<br>少しは落ち着いてきたようだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_08_1080002")


	--★★ノワール★★:あんたのほうは<br>まったく心配してなかったような顔だな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1080003")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:信じていたからな<br>お前なら必ず乗り越えられると
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_08_1080004")


	--★★ノワール★★:ランスロット…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1080005")


	--★★ランスロット★★:あれだけの戦いのあとだ<br>誰もが皆、疲弊している
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_08_1080006")


	--★★ランスロット★★:今はしっかり休んでおけ<br>教師ではなく、古くからの友人としての助言だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_08_1080007")

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
