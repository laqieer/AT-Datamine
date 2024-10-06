-- このluaスクリプトは、CO_101061_0401.csv の ADV シートから自動生成されました --
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

	--★★ラロゥ★★:ねえ、ちょっと相談があるんだけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101061_04010004","CO_101061_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:盗みの相談以外なら聞く
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04010007")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:そんなのアンタに相談しないよ<br>勉強のこと
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:勉強？<br>勉強に興味をもつのはいいことだけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04010009")

	change_face(Actor001,"Sad")

	--★★ノワール★★:質問の内容によっては<br>俺じゃ答えられないかもしれないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04010010")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ああ、大丈夫大丈夫
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04010011")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:この前、学園を案内してくれた時<br>本がたくさんある場所を紹介してくれたでしょ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04010012")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:あそこにもう一度連れてってよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04010013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:大図書院か<br>わかった、行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04010014")

	reserve_next_script("1章/コミュ/x0401_ラロゥ_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04010016")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:あっそ、わかったよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04010017")

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
