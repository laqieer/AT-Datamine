-- このluaスクリプトは、CO_101061_0601.csv の ADV シートから自動生成されました --
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

	--★★ラロゥ★★:ねえ、これから時間ある？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101061_06010004","CO_101061_06010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、あるよ<br>今日は特になんの用事もない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06010007")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:これから情報屋に会いに行くんだけどさ<br>ノワールも付き合ってよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06010008")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:信頼できる情報かどうか<br>一緒に確かめてほしいんだよね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06010009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06010010")

	reserve_next_script("1章/コミュ/x0401_ラロゥ_ランクアップ6_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_06010012")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:そう、わかったよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_06010013")

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
