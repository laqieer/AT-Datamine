-- このluaスクリプトは、CO_101037_0401.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Sit01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Surprise")

	--★★ラシア★★:あっ、ノワール<br>ヴェルナルス様を見ませんでしたか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101037_04010004","CO_101037_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、見かけてないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04010007")

	change_face(Actor002,"Surprise")

	--★★ラシア★★:そうですか…<br>モルガン先生がさがしてらっしゃるそうで
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺で良ければ付き合うよ<br>一緒にさがそう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04010009")

	change_face(Actor002,"Smile")

	--★★ラシア★★:ありがとう！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04010010")

	reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ヴェルナルス先生か<br>見てないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_04010012")

	change_face(Actor002,"Smile")

	--★★ラシア★★:そうですか…<br>どこに行っちゃったんだろう…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_04010013")

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
	InitializeActiveCharacter_Preload("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Sit01_Loop_f")
end
