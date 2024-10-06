-- このluaスクリプトは、CO_101037_0901.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Sit01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ラシア★★:どうしよう…うーん…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101037_09010004","CO_101037_09010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにをそんなに唸ってるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09010007")

	change_face(Actor002,"Sad")

	--★★ラシア★★:…わっ！？<br>ノワール、いたんですか…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09010008")

	change_face(Actor002,"Sad")

	--★★ラシア★★:ヴェルナルス様のお見舞いに行く<br>勇気がなかなか出なくて…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09010009")

	change_face(Actor002,"Smile")

	--★★ラシア★★:そうだ！<br>一緒に来てくれませんか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺が一緒に行ってもいいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_09010011")

	change_face(Actor002,"Smile")

	--★★ラシア★★:ぜひお願いします！
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09010012")

	reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ9_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ラシア★★:うーんうーんうーんうーんうーんうーんうーん<br>うーんうーんうーんうーんうーんうーんうーん
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_09010014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（これは<br>あとにしたほうが良さそうだな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101037_09010015")

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
	InitializeActiveCharacter_Preload("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Sit01_Loop_f")
end
