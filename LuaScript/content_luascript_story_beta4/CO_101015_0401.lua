-- このluaスクリプトは、CO_101015_0401.csv の ADV シートから自動生成されました --
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

	--★★アーサー★★:おお、ノワール<br>なにか用か？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101015_04010004","CO_101015_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:今日はサボらないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04010007")

	change_face(Actor002,"Normal")

	--★★アーサー★★:おいおい<br>俺だってたまには仕事くらいするさ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04010008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:たまにって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04010009")

	reserve_next_script("1章/コミュ/x0401_アーサー_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、なんでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_04010011")

	change_face(Actor002,"Normal")

	--★★アーサー★★:そうか！<br>なにかあればいつでも俺を頼るといい！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_04010012")

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
