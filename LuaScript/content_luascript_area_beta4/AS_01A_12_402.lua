-- このluaスクリプトは、AS_01A_12_402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0025")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:どう思う？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01A_12_4020001")


	--★★ノワール★★:なんの話かわからない相談する気が本当にあるのか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_4020002")


	--★★ガウェイン★★:ラヴェインが言ってただろ師匠が逃げ腰になってるって
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01A_12_4020003")


	--★★ガウェイン★★:師匠は俺にとっては特別な位置にいるんだその背中を追いかけ続けたいくらいの
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01A_12_4020004")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力

	--★★ノワール★★:そういう人には本気でぶつかるしかない…お前も、俺も
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_4020005")

	change_face(Actor002,"Serious")

	--★★ガウェイン★★:…そうだよな。半端は逆に怒られるよなよし、やってやろうじゃねえか！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01A_12_4020006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end
