-- このluaスクリプトは、AS_01A_01_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gwenhwymawr","101016001","101016001","content_animationpack_101_101gwen","MotionPack_101Gwen","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★ノワール★★:ギネマウアさん<br>ギネヴィアの容態はどうですか？
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_01_1040001")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネマウア★★:大分顔色はよくなってきました<br>そろそろ目を覚ましてくれるかもしれません
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","AS_01A_01_1040002")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうですか、よかった！<br>それで、あの、ギネマウアさん…
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_01_1040003")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:あの…ノワール様<br>先日は取り乱してしまい、大変失礼致しました
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","AS_01A_01_1040004")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いえ！いいんです、謝らないでください<br>俺がなにもできてないことは事実なんだし
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01A_01_1040005")

-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:ふふっ。では、見守っていきましょう<br>私たちふたりであの子を。…いつまでも
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","AS_01A_01_1040006")

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
