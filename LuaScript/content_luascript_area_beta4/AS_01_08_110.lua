-- このluaスクリプトは、AS_01_08_110.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:兄さん、大丈夫？<br>無理してない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01_08_1100002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:少しずつ気持ちの整理はついてきたよ<br>ディナタンこそ、無理してないか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1100003")


	--★★ディナタン★★:まったくしてないって言ったら<br>嘘になるかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01_08_1100004")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:でも、マァルがいろいろ話を聞いてくれて<br>少し気が楽になったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01_08_1100005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうか…マルディサントに感謝しないとな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1100006")


	--★★ディナタン★★:辛いときは気持ちを共有し合おうね<br>私たちは兄妹なんだから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01_08_1100007")

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
