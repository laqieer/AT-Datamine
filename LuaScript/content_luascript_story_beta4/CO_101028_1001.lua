-- このluaスクリプトは、CO_101028_1001.csv の ADV シートから自動生成されました --
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

	--★★ガラハッド★★:ノワール、姉上から…/最終試験の結果を発表するとのことだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101028_10010004","CO_101028_10010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:聞きにいこうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10010007")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:場所はコルベニック城/謁見の間でやる、と
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10010008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そんなゴタイソウな試験だったっけ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10010009")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:もしかして緊張してるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10010011")

	reserve_next_script("1章/コミュ/x0401_ガラハッド_ランクアップ10_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、少し待ってくれるか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10010013")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:わかった/準備ができたら声をかけてくれ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10010014")

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
