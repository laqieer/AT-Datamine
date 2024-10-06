-- このluaスクリプトは、CO_101061_0701.csv の ADV シートから自動生成されました --
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

	--★★ラロゥ★★:ノワール<br>聖杯の在処、掴めるかも知れない
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101061_07010004","CO_101061_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本当か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07010007")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:うん。ある祭壇に保管されてる古文書に<br>聖杯を使った儀式のことが書いてあるって
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:信頼できる情報なんだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07010009")

	change_face(Actor002,"Smile")

	--★★ラロゥ★★:頭良さそうなじいさんを<br>酔っ払わせたらペラペラ喋ってくれたよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07010010")

	change_face(Actor001,"Sad")

	--★★ノワール★★:お前ってやつはホント…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07010012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…ま、今はそれはいいか<br>本当かどうかはわからないけど、行ってみよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07010013")

	reserve_next_script("1章/コミュ/x0401_ラロゥ_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07010015")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:早く調べたいのに…<br>さっさと用事済ませてよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07010016")

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
