-- このluaスクリプトは、CO_101026_0801.csv の ADV シートから自動生成されました --
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

	--★★パーシヴァル★★:ああ、ノワールか<br>ボクになにか用だろうか？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101026_08010004","CO_101026_08010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:あれからジャンの容体はどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08010007")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:まだ意識を取り戻さないんだ
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか<br>心配だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08010009")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:これから療養院に様子を見に行くつもりだ<br>キミも来るかい？
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08010011")

	reserve_next_script("1章/コミュ/x0401_パーシヴァル_ランクアップ8_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、なにも用はない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101026_08010013")

	change_face(Actor002,"Normal")

	--★★パーシヴァル★★:そうか<br>それじゃ、また
	Talk(Actor002,"CHRNAME_PERCIVAL","speech","L","CO_101026_08010014")

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
