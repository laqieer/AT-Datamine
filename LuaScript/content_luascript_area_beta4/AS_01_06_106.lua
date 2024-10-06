-- このluaスクリプトは、AS_01_06_106.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Sit01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ガレス★★:あ、ノワール。聞いてるぞ<br>グラストンベリーでは大変だったな
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AS_01_06_1060002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺は大丈夫だ<br>ただ、マルディサントがまだ目を覚ましてない
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_06_1060003")

	change_face(Actor002,"Sad")

	--★★ガレス★★:心配だな。マルディサントも、モルガン先生も<br>ふたりと仲の良かったみんなも
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AS_01_06_1060004")

-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガレス★★:ところで、私のところに来たってことは<br>なにか食べたいものでもあるのか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AS_01_06_1060005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺じゃなくて<br>みんなが元気になるようなもの、作れないかな？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_06_1060006")

-- ▼直接出力
PlayPartVoice("ガレス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガレス★★:グッドアイデア！<br>みんなの好物を作って、あとでご馳走しとくぞ♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","AS_01_06_1060007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Sit01_Loop_f")
end
