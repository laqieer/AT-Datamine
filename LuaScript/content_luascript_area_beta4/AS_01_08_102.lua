-- このluaスクリプトは、AS_01_08_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガラハッド", "挨拶")
-- ▲直接出力

	--★★ガラハッド★★:ノワールか<br>なんの用だ？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AS_01_08_1020002")


	--★★ノワール★★:今のフィエナについて少し聞きたくてさ<br>もう長いこと会ってないから
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1020003")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:なんだ、そんなことか<br>姉上は明るく優しい聡明な女性だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AS_01_08_1020004")

-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:それに、いつもガラハッドのことを<br>気にかけてくれている
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AS_01_08_1020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:仲がいいんだな<br>俺のことはまだ覚えてくれてるかな？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1020006")


	--★★ガラハッド★★:心配無用だ。お前のことは何度も聞かされてきた<br>機会があれば顔を見せてやってくれ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AS_01_08_1020007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end
