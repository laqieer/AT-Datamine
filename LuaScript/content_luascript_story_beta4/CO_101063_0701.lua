-- このluaスクリプトは、CO_101063_0701.csv の ADV シートから自動生成されました --
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

	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あら、ノワールちゃん/なにかご用かしら～？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101063_07010004","CO_101063_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか手伝えることはないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07010007")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:そうねえ…
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07010008")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:せっかくだし、お言葉に甘えちゃおうかしら/書架の整理を手伝ってくれる？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07010009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:よし、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07010010")

	reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、特に用事があったわけじゃないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_07010012")

	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:まあ！純粋に私に会いに来てくれたってわけ？/キュンキュンしちゃうわあ～
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_07010013")

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
