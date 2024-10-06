-- このluaスクリプトは、AS_01_04_106.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:俺がローマへの使者になるって言ったのは驚かれるようなことだったか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_4020002")


	--★★ランスロット★★:驚いたわけではないやれることをやろうとするのは知っている
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_07_4020003")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力

	--★★ノワール★★:まだお前が俺に言えることがあまりないとしてその不満とは別の話だしな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_4020004")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0034")
-- ▲直接出力

	--★★ランスロット★★:いつか色んなことを話せるようになったら溜め込んだぶん怒られるんだろうな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_07_4020005")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:俺に怒る権利はあるだろう？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_07_4020006")

-- ▼直接出力
PlayPartVoiceDirect("ランスロット","0010")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:ふふっ、その権利は認めてやるよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01_07_4020007")

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
