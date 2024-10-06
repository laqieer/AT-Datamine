-- このluaスクリプトは、AS_01_06_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("クリスティーナ", "挨拶")
-- ▲直接出力

	--★★クリスティーナ★★:あら、ノワールちゃんじゃな～い<br>今日はどんな本を探しに来たのかしら
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","AS_01_06_1020002")


	--★★ノワール★★:最近のカレドニアの情勢について<br>書かれたものってあるかな？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_06_1020003")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力

	--★★クリスティーナ★★:それなら本よりも新聞がいいかしらね<br>はい、どうぞ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","AS_01_06_1020004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ありがとう。えーっと…<br>（…ブライアン関連の情報はないみたいだな）
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_06_1020005")


	--★★クリスティーナ★★:どう？<br>気になるニュースは載ってた？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","AS_01_06_1020006")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いや。載ってなかったけど、なくてよかったよ<br>（便りがないのは良い便り、っていうしな）
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_06_1020007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end
