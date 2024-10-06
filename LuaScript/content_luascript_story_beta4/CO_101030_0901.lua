-- このluaスクリプトは、CO_101030_0901.csv の ADV シートから自動生成されました --
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

	--★★エレイン★★:先輩<br>トビーくんの様子を見に行きませんか？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101030_09010004","CO_101030_09010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:トビーの様子について<br>なにか連絡はあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09010007")

	change_face(Actor002,"Smile")

	--★★エレイン★★:はい<br>また使用人の方から手紙が届きました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09010008")

	change_face(Actor002,"Smile")

	--★★エレイン★★:もうすっかり元気になって<br>私たちに会いたいと言っているそうです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09010009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか<br>それじゃ、さっそく行ってやろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09010010")

	reserve_next_script("1章/コミュ/x0401_エレイン_ランクアップ9_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪いけど<br>これから用事があってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_09010012")

	change_face(Actor002,"Normal")

	--★★エレイン★★:そうですか…。お忙しいところ<br>足止めさせてしまってすみません…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_09010013")

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
