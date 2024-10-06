-- このluaスクリプトは、CO_101063_0301.csv の ADV シートから自動生成されました --
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

	--★★クリスティーナ★★:あら、ノワールちゃん/もしよかったら私に付き合わない？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101063_03010004","CO_101063_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいけど…/なにをするつもりなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03010007")

	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ここのところデスクワークが続いてたから/少し目の保養をしたいなと思って
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それに俺は必要なのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03010009")

	reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:今はちょっと忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_03010011")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:あ～ら、残念<br>また今度お願いね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_03010012")

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
