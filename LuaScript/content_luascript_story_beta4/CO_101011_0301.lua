-- このluaスクリプトは、CO_101011_0301.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★ギネヴィア★★:ノワール<br>わたし、今日もまた時間あるんだ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101011_03010004","CO_101011_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>どこかに遊びに行こうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03010007")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そうこなくっちゃ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03010008")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:今日は<br>ロンディニウムの都に行くわよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03010009")

	reserve_next_script("1章/コミュ/x0401_ギネヴィア_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ごめん<br>俺は時間がない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_03010011")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:なによ、もーっ！<br>次は付き合いなさいよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","CO_101011_03010013")

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
	InitializeActiveCharacter_Preload("Guinevere","101011001","101011001","content_animationpack_101_101guin","MotionPack_101Guin","Com_Std01_Loop_f")
end
