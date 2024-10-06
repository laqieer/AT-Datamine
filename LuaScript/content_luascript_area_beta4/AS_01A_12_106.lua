-- このluaスクリプトは、AS_01A_12_106.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeCharacter_2DOnly("401035","001","401035001")
end

function Play()
	StartPlayActive()


	--★★キャメロット軍兵士_上位★★:おお、ノワール<br>久しぶりじゃないか！
	Talk(Actor002,"NPCNAME_0124","speech","L","AS_01A_12_1060001")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ここのところ人手が足りてないんだろ？<br>俺でよければ手伝おうと思ってさ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1060002")


	--★★キャメロット軍兵士_上位★★:ああ、そうなのか<br>実はそのあたり、どうにかなりそうなんだよ
	Talk(Actor002,"NPCNAME_0124","speech","L","AS_01A_12_1060003")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？<br>人手の確保ができたのか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1060004")

-- ▼直接出力
PlayPartVoice("兵士3", "肯定")
-- ▲直接出力

	--★★キャメロット軍兵士_上位★★:銀卓騎士団が島東部の見回りを強化してくれたり<br>コーンウォールが物資を提供してくれたりしてな
	Talk(Actor002,"NPCNAME_0124","speech","L","AS_01A_12_1060005")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そこまで人手が増えたわけじゃないけど<br>各国が協力してくれるってことか。心強いな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_12_1060006")

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
