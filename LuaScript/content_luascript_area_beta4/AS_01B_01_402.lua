-- このluaスクリプトは、AS_01B_01_402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor001,"Sad")

	--★★ノワール★★:なあ、ガラハッドひとりであんまり頑張りすぎるなよ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_4020001")

-- ▼直接出力
PlayPartVoiceDirect("ガラハッド","0028")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:ぐっ…誤情報だ！名誉棄損だ！ガラハッドは泣いてなどいない！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AS_01B_01_4020002")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力

	--★★ノワール★★:まだ何も言ってないじゃないか…あのさ。俺、思ったんだ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_4020003")


	--★★ノワール★★:ガラハッドもランスロットも俺も結局似ているんじゃないかって
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_4020004")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ガラハッドたちが似ている？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","AS_01B_01_4020005")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺たちは同じ方向を向いて、同じように歩ける…だからお互いを頼りにしていこう
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_01_4020006")

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
