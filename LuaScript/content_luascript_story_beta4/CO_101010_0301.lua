-- このluaスクリプトは、CO_101010_0301.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")
end

function Play()
	StartPlayActive()

	--★★ランスロット★★:今日の補習を始めるぞ、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101010_03010004","CO_101010_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかったよ<br>で、今日はなんの補習をするんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03010007")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:バイブス学の補習だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03010008")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:教材を取ってくる<br>少し待っていてくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03010009")

	reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_03010011")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前が忙しいのは理解しているつもりだが<br>予習・復習は怠るなよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_03010012")

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
	InitializeActiveCharacter_Preload("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")
end
