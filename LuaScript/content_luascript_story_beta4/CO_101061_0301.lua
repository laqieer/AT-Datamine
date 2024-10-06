-- このluaスクリプトは、CO_101061_0301.csv の ADV シートから自動生成されました --
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
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101061_03010004","CO_101061_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:あぁ、なにか用か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03010007")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:この前、学園を案内してくれたでしょ<br>そのお礼がしたくてさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03010008")

	change_face(Actor002,"Smile")

	--★★ラロゥ★★:初心者向きの盗みの技術を教えてあげるよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03010009")

	change_face(Actor001,"Sad")

	--★★ノワール★★:あのな…そんなの教わると思うか？<br>気持ちだけでいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03010010")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:それだとオレの気が済まない
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03010011")

	change_face(Actor001,"Sad")

	--★★ノワール★★:困ったな…んー、じゃあ<br>美味しい店でも紹介してくれよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03010012")

	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:真面目だな、アンタ<br>じゃ、オレの馴染みの店を教えてやるよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03010014")

	reserve_next_script("1章/コミュ/x0401_ラロゥ_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_03010017")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:じゃ、また今度ね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_03010018")

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
