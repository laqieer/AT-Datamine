-- このluaスクリプトは、CO_101025_0201.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★クレア★★:ノワール<br>今、時間あるわよね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101025_02010004","CO_101025_02010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:え？<br>あ、ああ。時間ならあるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02010007")

	change_face(Actor002,"Normal")

	--★★クレア★★:そうよね<br>いつもよりゆっくり歩いていたもの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02010008")

	change_face(Actor002,"Normal")

	--★★クレア★★:前に言った助手の件で話があるの<br>一緒に事務所まで来て
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02010009")

	reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ2_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪いけど、今は時間がない<br>またあとでな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_02010011")

	change_face(Actor002,"Normal")

	--★★クレア★★:そう、残念ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_02010012")

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
	InitializeActiveCharacter_Preload("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
end
