-- このluaスクリプトは、AS_01A_12_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeCharacter_2DOnly("401035","001","401035001")
end

function Play()
	StartPlayActive()

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:なぁ、ちょっといいか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1040001")

-- ▼直接出力
PlayPartVoice("兵士3", "驚き")
-- ▲直接出力

	--★★キャメロット軍兵士_上位★★:はい、なんでしょう…って<br>ノワール卿！？
	Talk(Actor002,"NPCNAME_0124","speech","L","AS_01A_12_1040002")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そんなに緊張しないでくれ…<br>ローマとの戦いが続いてるけど、調子はどうだ？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1040003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:緊張感を保つのはいいことだけどさ<br>たまには息を抜くのも重要だと思うぞ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1040004")

-- ▼直接出力
PlayPartVoice("兵士3", "納得")
-- ▲直接出力

	--★★キャメロット軍兵士_上位★★:…我々を激励に来てくれた、というわけですか？<br>円卓の騎士に気にかけてもらえるとは光栄至極！
	Talk(Actor002,"NPCNAME_0124","speech","L","AS_01A_12_1040005")


	--★★ノワール★★:…やれやれ。俺は傭兵団にいたことがあってさ<br>そのとき教わったことを伝えにきただけだよ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1040006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeCharacter_2DOnly_Preload("401035","001","401035001")
end
