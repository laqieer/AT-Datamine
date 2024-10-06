-- このluaスクリプトは、CO_101066_0901.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Blaise","101066001","101066001","content_animationpack_101_101blaz","MotionPack_101Blaz","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★ブレイズ★★:ノワール。研究のために<br>またバルバロイとの戦闘を観察させてくれんか？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101066_09010004","CO_101066_09010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、いいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09010007")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:お主、付き合いがいいのう！<br>ワシ、感動しちゃう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09010008")

	reserve_next_script("1章/コミュ/x0401_ブレイズ_ランクアップ9_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、今はちょっと忙しくて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_09010010")

	change_face(Actor002,"Normal")

	--★★ブレイズ★★:そうか。残念じゃのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_09010011")

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
	InitializeActiveCharacter_Preload("Blaise","101066001","101066001","content_animationpack_101_101blaz","MotionPack_101Blaz","Com_Std01_Loop_m")
end