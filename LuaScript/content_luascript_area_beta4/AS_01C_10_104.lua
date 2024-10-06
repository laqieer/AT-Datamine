-- このluaスクリプトは、AS_01C_10_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor001,"Sad")

	--★★ノワール★★:マーリンさんは気付いていたんですか？<br>アーサーの、その…変化、について
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_1040001")

-- ▼直接出力
PlayPartVoice("マーリン", "肯定2" )
-- ▲直接出力

	--★★マーリン★★:変化という表現が正しいかはわかりませんが<br>はい、気づいていました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","AS_01C_10_1040002")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…それについても<br>まだ詳しくは聞かせてもらえない感じですね
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_1040003")


	--★★ノワール★★:でも、あなたが学園にいてくれてるってことは<br>俺たちに力を貸してくれると理解していい…？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_1040004")

-- ▼直接出力
PlayPartVoice("マーリン", "肯定" )
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:はい。置いて行かれた者の力などでよろしければ<br>存分にお使いください
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","AS_01C_10_1040005")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな！…俺は思うんです<br>あなたを置いて行ってくれたんじゃないかなって
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01C_10_1040006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Merlin","101020001","101020001","content_animationpack_101_101merl","MotionPack_101Merl","Com_Std01_Loop_f")
end
