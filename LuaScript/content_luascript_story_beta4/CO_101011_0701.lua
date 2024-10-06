-- このluaスクリプトは、CO_101011_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:大変よ、ノワール！<br>ノワール、大変なのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101011_07010004","CO_101011_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07010007")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:大変で大変なのよ！<br>大変なんだったらノワール！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なにが大変なんだか説明してもらわないと…<br>落ち着ける場所に行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07010010")

	reserve_next_script("1章/コミュ/x0401_ギネヴィア_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:今日は忙しいから<br>また今度
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_07010012")

	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:大変だって言ってるのに！<br>薄情すぎない！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_07010014")

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
	InitializeActiveCharacter_Preload("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end
