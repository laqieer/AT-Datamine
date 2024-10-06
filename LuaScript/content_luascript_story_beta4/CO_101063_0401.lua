-- このluaスクリプトは、CO_101063_0401.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end

function Play()
	StartPlayActive()

	--★★クリスティーナ★★:ノワールちゃん、これから時間ある？/あなたを連れて行きたいところがあるの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101063_04010004","CO_101063_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:場所にもよるかなぁ/また目の保養なら遠慮しとく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04010007")

	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ああ、それもいいわね/でも、今日は違う場所なの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04010008")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:最近、ノワールちゃん無理してるでしょ/お肌が荒れ気味よ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04010009")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ぷるぷるお肌を取り戻してあげたいと思って/ローマン・バスに行きましょ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04010010")

	reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:今はちょっと忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04010012")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:あ～ら、残念/また今度誘うわね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04010013")

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
	InitializeActiveCharacter_Preload("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end
