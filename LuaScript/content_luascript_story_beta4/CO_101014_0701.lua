-- このluaスクリプトは、CO_101014_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Sit_hurp_loop_Chr_004_01")
end

function Play()
	StartPlayActive()

	--★★トリスタン★★:キミか。悪いけど、ボク<br>今日は行くところがあるんだ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101014_07010004","CO_101014_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:着いていってもいいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07010007")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:言うと思った<br>ま、好きにしたらいいよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07010009")

	reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そっか<br>行ってらっしゃい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_07010011")

	change_face(Actor002,"Surprise")

	--★★トリスタン★★:着いて来ると言い出すかと思ったけど<br>…そう、じゃあね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_07010013")

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
	InitializeActiveCharacter_Preload("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Sit_hurp_loop_Chr_004_01")
end
