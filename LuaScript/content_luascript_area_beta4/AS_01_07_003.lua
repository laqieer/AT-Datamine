-- このluaスクリプトは、AS_common.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ランスロット<br>相談があるんだ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0010010")


	--★★ランスロット★★:どうした？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_07_0010011")


	--★★ノワール★★:ブライアンの様子を見に行かせてくれないか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0010012")


	--★★ノワール★★:安心してくれ<br>おかしなことをするつもりはないから
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0010013")


	--★★ランスロット★★:ふむ…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_07_0010014")


	--★★ノワール★★:難しいか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_0010015")


	--★★ランスロット★★:いや。アーサーやディナタンからも<br>同じような話を受けたものでな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_07_0010016")


	--★★ランスロット★★:丁度いい<br>全員で行こう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_07_0010017")

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
