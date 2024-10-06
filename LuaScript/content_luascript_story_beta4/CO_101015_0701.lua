-- このluaスクリプトは、CO_101015_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Arthur_EntakuSit_loop")
end

function Play()
	StartPlayActive()

	--★★アーサー★★:ノワール、いいところに来た<br>ちょっとサボりに付き合わないか？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101015_07010004","CO_101015_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいけど…<br>とうとうサボリって隠さなくなったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07010007")

	change_face(Actor002,"Normal")

	--★★アーサー★★:隠したところで、だろう？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:まあ、そうだけど…<br>で、どこへ行くんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07010009")

	change_face(Actor002,"Normal")

	--★★アーサー★★:俺の一番好きな場所だよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07010010")

	reserve_next_script("1章/コミュ/x0401_アーサー_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:サボリはよくない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_07010012")

	change_face(Actor002,"Normal")

	--★★アーサー★★:ちょ、ちょっとくらいいいじゃないか！<br>誰かに似て融通の利かないやつだな…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_07010013")

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
	InitializeActiveCharacter_Preload("Arthur","101015001","101015001","content_animationpack_101_101arth","MotionPack_101Arth","Arthur_EntakuSit_loop")
end
