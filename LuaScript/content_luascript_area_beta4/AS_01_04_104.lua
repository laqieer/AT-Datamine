-- このluaスクリプトは、AS_01_04_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ウレリー★★:お、ノワールくん<br>どうかした？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","AS_01_04_1040002")


	--★★ノワール★★:教えてほしいんだ。入学試験の内容とか<br>準備しておいたほうがいいものについて
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_1040003")


	--★★ウレリー★★:試験の内容？<br>準備しておいたほうがいいもの？
	Talk(Actor002,"CHRNAME_URRIE","speech","L","AS_01_04_1040004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_04_1040005")

	change_face(Actor002,"Smile")

	--★★ウレリー★★:ノワールくんは真面目なんだねえ！
	Talk(Actor002,"CHRNAME_URRIE","speech","L","AS_01_04_1040006")

	change_face(Actor002,"Normal")

	--★★ウレリー★★:細かいことは気にしなくて大丈夫<br>行けばすぐにわかるよ！
	Talk(Actor002,"CHRNAME_URRIE","speech","L","AS_01_04_1040007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Urrié","101068001","101068001","content_animationpack_101_101urri","MotionPack_101Urri","Com_Std01_Loop_f")
end
