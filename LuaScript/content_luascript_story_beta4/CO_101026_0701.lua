-- このluaスクリプトは、CO_101026_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★パーシヴァル★★:ノワール<br>果てなき森の調査に向かおうじゃないか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101026_07010004","CO_101026_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:準備はできてるよ<br>いつでも行ける
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_07010007")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:大変結構
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_07010008")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:あの森へは距離がある<br>転移魔法で送ってもらうとしよう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_07010009")

	reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_07010011")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ならば、しばらく待っておいてやろう<br>用が片付いたら、またここに来たまえ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_07010012")

	system.Cancel()

	goto Block1end

::Block1end::
	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Perceval","101026001","101026001","content_animationpack_101_101perc","MotionPack_101Perc","Com_Std01_Loop_m")
end
