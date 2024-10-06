-- このluaスクリプトは、AS_01B_01_106.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ノワールじゃないか<br>どうした、俺になにか用か？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AS_01B_01_1060001")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:体調が良か…ええっと<br>ヒマならマーケットまで食べ歩きに行かないか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_1060002")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:ほう…！お前もあの情報を聞いたんだな<br>屋台の新作、東方伝来の甘～い菓子のことを！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AS_01B_01_1060003")

-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:話題に乗り遅れる前に食わねばと思っているが<br>…すまん、今は手が離せない用事があってなあ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AS_01B_01_1060004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そっか、じゃあ、また今度声をかけるよ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_1060005")

	change_face(Actor002,"Normal")

	--★★アーサー★★:すまんな<br>…気を遣ってくれたこと、感謝する
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","AS_01B_01_1060006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Com_Std01_Loop_m")
end
