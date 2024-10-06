-- このluaスクリプトは、AS_01_05_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ディナタン、ちょっといいか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_1020002")

-- ▼直接出力
PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:うん、どうしたの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01_05_1020003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:実は今度<br>キャメリアードの様子を見に行くことになってさ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_1020004")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:キャメリアードに？<br>どうして兄さんが？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01_05_1020005")


	--★★ノワール★★:雇い主の付き合いってところだ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_1020006")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:そっか、わかった<br>でも、絶対に無理はしないでね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","AS_01_05_1020007")

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
