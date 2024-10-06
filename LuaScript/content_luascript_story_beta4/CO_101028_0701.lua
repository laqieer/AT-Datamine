-- このluaスクリプトは、CO_101028_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★ガラハッド★★:ノワール/今、時間はあるか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101028_07010004","CO_101028_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、今なら時間があるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07010007")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:であれば/その、例のレッスンのことだが…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07010009")

	--★★ノワール★★:あ、ああ…（前回も思ったが、勝負なんかしてたか…？）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07010015")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:こ、ここでは人目が気になる！/場所を移そう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07010010")

	reserve_next_script("1章/コミュ/x0401_ガラハッド_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は時間がなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_07010012")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そうか…/呼び止めて悪かった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_07010014")

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
	InitializeActiveCharacter_Preload("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
end
