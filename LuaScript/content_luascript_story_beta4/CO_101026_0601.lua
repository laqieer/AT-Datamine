-- このluaスクリプトは、CO_101026_0601.csv の ADV シートから自動生成されました --
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

	--★★パーシヴァル★★:ノワール<br>アーサー王に頼まれた任務を進めようか
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101026_06010004","CO_101026_06010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>森に調査に向かうんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06010007")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:いや、もう少し情報が欲しい<br>義姉さんに、なにか知らないか話を聞いてみよう
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ディンドランさんに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06010009")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:義姉さんは故郷にあった書庫で<br>妖精についての本を多数読んでいたからね
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06010010")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:妖精やあの森についての知識なら<br>ボクよりも数倍上だ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06010011")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ついてきたまえ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06010012")

	reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ6_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_06010014")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:ならば、しばらく待っておいてやろう<br>用が片付いたら、またここに来たまえ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_06010015")

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
