-- このluaスクリプトは、AS_C.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Smile")

	--★★クラリス★★:ギネヴィアさんが戻ってきたみたいですよ?<br>よかったですね?
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","AS_01C_01_0010007")

	change_face(Actor002,"Normal")

	--★★クラリス★★:あっ…でも、もし逃げてこられたのなら<br>ケガをされているかもしれません
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","AS_01C_01_0010008")

	change_face(Actor002,"Surprise")

	--★★クラリス★★:このお薬を持っていってあげてください<br>え？これは薬じゃなくてお菓子の袋？あれれ…
	Talk(Actor002,"CHRNAME_CLARICE","speech","L","AS_01C_01_0010009")

	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Clarice","101023001","101023001","content_animationpack_101_101clrc","MotionPack_101Clrc","Com_Std01_Loop_f")
end
