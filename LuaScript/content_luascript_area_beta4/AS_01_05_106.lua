-- このluaスクリプトは、AS_01_05_106.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ギネマウアさん、こんにちは<br>あれから調子はどうですか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_1060002")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネマウア★★:ご心配いただきありがとうございます<br>もうすっかり元気です
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","AS_01_05_1060003")

	change_face(Actor001,"Sad")

	--★★ノワール★★:それはよかったです<br>えっと…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_1060004")

-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力

	--★★ギネマウア★★:ふふっ。殿下も元気ですよ<br>すぐにこれまでどおり、とは難しいでしょうけど
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","AS_01_05_1060005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺で力になれることがあれば<br>いつでも言ってください
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01_05_1060006")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:ありがとうございます<br>あの子もきっと喜びます
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","AS_01_05_1060007")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end
