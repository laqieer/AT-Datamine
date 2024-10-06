-- このluaスクリプトは、CO_101030_0401.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Elaine","101030001","101030001","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★エレイン★★:先輩！<br>今、お時間大丈夫ですか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101030_04010004","CO_101030_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:空いてるよ<br>トビーの様子を見に行くのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04010007")

	change_face(Actor002,"Normal")

	--★★エレイン★★:それもあるのですが…<br>その前に行きたい場所がありまして
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:行きたい場所？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04010009")

	change_face(Actor002,"Normal")

	--★★エレイン★★:トビーくんの目が<br>あんな状態になった原因を調べたいんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04010010")

	change_face(Actor002,"Normal")

	--★★エレイン★★:ロンディニウムに<br>付き合っていただけないでしょうか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04010011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04010012")

	change_face(Actor002,"Normal")

	--★★エレイン★★:今日はお兄ちゃんが<br>ロンディニウムに行っているはずです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04010013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、向こうで合流しよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04010014")

	reserve_next_script("1章/コミュ/x0401_エレイン_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪いけど<br>これから用事があってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_04010016")

	change_face(Actor002,"Surprise")

	--★★エレイン★★:あ、お、お忙しいですよね<br>し、失礼しました！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_04010017")

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
	InitializeActiveCharacter_Preload("Elaine","101030001","101030001","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
end
