-- このluaスクリプトは、AS_01B_01_108.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さん…私、どうしたらいいのかな？<br>本当にこのままでいいと思う？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01B_01_1080001")

	change_face(Actor001,"Sad")

	--★★ノワール★★:できることなら<br>今からでも別の方法を探したい。でも…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_1080002")


	--★★ディナタン★★:でも、そうしてるあいだに<br>世界が終わっちゃうかもしれない
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01B_01_1080003")

-- ▼直接出力
PlayPartVoice("ディナタン", "悲しみ")
-- ▲直接出力

	--★★ディナタン★★:それはわかってるけど！<br>みんな、誰かのために犠牲になろうとして…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01B_01_1080004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:覚えていてくれる、想いを繋いでくれる人がいる<br>…だからみんな、決断できるのかもしれない
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_1080005")


	--★★ディナタン★★:誰かが受け継いでくれるから頑張れる<br>…その気持ちを尊重してあげるべきなんだね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01B_01_1080006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end
