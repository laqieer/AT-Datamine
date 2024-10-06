-- このluaスクリプトは、AS_01_08_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ガウェイン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:よう、ノワール<br>美味いもんでも食いに行かねーか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01_08_1040002")


	--★★ノワール★★:え？<br>いいけど、その前にちょっと相談したいことが…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1040003")

	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:そんなの、あとでいーだろ！<br>ハラ減っちまってよ。もう耐えられねーんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01_08_1040004")

-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:食堂にするか、『竜のゆりかご亭』にするか…<br>うーん、悩むな。お前はどっちがいい？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01_08_1040005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…気を遣ってくれてるんだな、ありがとう
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_08_1040006")

-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:…なんのことだか知らねーけどよ<br>元気出ねーときはメシ喰うのが一番だと思うぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","AS_01_08_1040007")

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
