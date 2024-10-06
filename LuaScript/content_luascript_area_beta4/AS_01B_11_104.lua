-- このluaスクリプトは、AS_01B_11_104.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
function Load()
	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")
end

function Play()
	StartPlayActive()


	--★★ランスロット★★:どうした、ノワール<br>顔がこわばっているようだが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01B_11_1040001")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:失敗できないと思い始めたら<br>なんか緊張してきちゃってさ
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_11_1040002")


	--★★ランスロット★★:お前らしくもないな<br>失敗が許されない戦いは何度も経験済みだろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01B_11_1040003")

-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ランスロット★★:いつもどおりでいい。気負う必要はない<br>たとえ失敗しても、俺や他の騎士がフォローする
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01B_11_1040004")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうか、そうだよな<br>俺には「最強騎士」とその仲間がついてるもんな
	Talk(Actor001,"PLAYERNAME_NOIR","speech","L","AS_01B_11_1040005")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:そうだ<br>ローマや魔女に目にものを見せてやろう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","AS_01B_11_1040006")

	EndPlayActive()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")
end
