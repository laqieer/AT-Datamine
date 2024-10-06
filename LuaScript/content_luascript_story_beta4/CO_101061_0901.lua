-- このluaスクリプトは、CO_101061_0901.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Larou","101061001","101061001","content_animationpack_101_101laro","MotionPack_101Laro","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★ラロゥ★★:ノワール<br>聖杯を探しに行こう
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101061_09010004","CO_101061_09010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:あぁ、出発しよう<br>準備は整ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09010007")

	change_face(Actor002,"Smile")

	--★★ラロゥ★★:こんなにワクワクするのは<br>初めて盗みをしたとき以来かも！
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09010008")

	change_face(Actor001,"Sad")

	--★★ノワール★★:それはどうかと思うけどな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09010009")

	reserve_next_script("1章/コミュ/x0401_ラロゥ_ランクアップ9_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:申し訳ない<br>もうちょっと待ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_09010011")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:聖杯を誰かに横取りされても知らないよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_09010013")

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
	InitializeActiveCharacter_Preload("Larou","101061001","101061001","content_animationpack_101_101laro","MotionPack_101Laro","Com_Std01_Loop_m")
end
