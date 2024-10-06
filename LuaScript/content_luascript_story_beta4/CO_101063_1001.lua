-- このluaスクリプトは、CO_101063_1001.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end

function Play()
	StartPlayActive()

	--★★クリスティーナ★★:あら、ノワールちゃん/大図書院にご用かしら？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101063_10010004","CO_101063_10010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:クリスさんと話をしにきたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10010007")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ふふ。悩める乙女の前に颯爽と現れる…/やっぱりノワールちゃんって王子様なのね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…茶化さないでくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10010009")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:冗談を言える空気ではなさそうね/ちょっとその辺をブラつきましょ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10010010")

	reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ10_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:とくに用事はない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_10010012")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:そう/またいつでもいらっしゃいな
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_10010013")

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
	InitializeActiveCharacter_Preload("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end
