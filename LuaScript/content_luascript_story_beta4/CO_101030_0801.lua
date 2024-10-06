-- このluaスクリプトは、CO_101030_0801.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Elaine","101030002","101030002","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★エレイン★★:先輩。久々にトビーくんに<br>会いに行こうかと思っているんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101030_08010004","CO_101030_08010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはいいけど…<br>体の調子は大丈夫なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08010007")

	change_face(Actor002,"Smile")

	--★★エレイン★★:はい、もうすっかり<br>この前、使用人の方から手紙が届いて
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08010008")

	change_face(Actor002,"Smile")

	--★★エレイン★★:トビーくんの目の調子が<br>少し良くなってきたそうなんですよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08010009")

	change_face(Actor002,"Normal")

	--★★エレイン★★:だから会って話をしたいなと思いまして<br>…このあいだのこともありますし
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それがいいと思う<br>俺もついていくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08010011")

	change_face(Actor002,"Smile")

	--★★エレイン★★:ありがとうございます、先輩
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08010012")

	reserve_next_script("1章/コミュ/x0401_エレイン_ランクアップ8_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪いけど<br>これから用事があってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_08010014")

	change_face(Actor002,"Normal")

	--★★エレイン★★:そうですか…。お忙しいところ<br>足止めさせてしまってすみません…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_08010015")

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
	InitializeActiveCharacter_Preload("Elaine","101030002","101030002","content_animationpack_101_101elai","MotionPack_101Elai","Com_Std01_Loop_f")
end
