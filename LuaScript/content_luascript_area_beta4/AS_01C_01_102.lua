-- このluaスクリプトは、AS_01C_01_102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ケイ<br>ギネヴィアの足取りはつかめそうなのか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_01_1020001")

-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ケイ★★:残念ながら、めぼしい情報は入ってきていない<br>ローマにも協力してもらっているのだがな
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01C_01_1020002")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そうか…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_01_1020003")


	--★★ノワール★★:なあ<br>調べてほしい場所があるんだ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_01_1020004")

-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:調べてほしい場所？<br>わかった、至急人員を確保しよう
	Talk(Actor002,"CHRNAME_KAY","speech","L","AS_01C_01_1020005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:頼む<br>…手遅れになってしまう前に探し出したい
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_01_1020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Kay","101040001","101040001","content_animationpack_101_101kay","MotionPack_101Kay","Com_Std01_Loop_m")
end
