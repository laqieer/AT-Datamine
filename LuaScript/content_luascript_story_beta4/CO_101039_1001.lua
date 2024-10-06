-- このluaスクリプトは、CO_101039_1001.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Flen","101039001","101039001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Surprise")

	--★★フレン★★:いよいよ競技大会本番だね<br>ローラも間に合いそうだって
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101039_10010004","CO_101039_10010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ついに当日か<br>なんか緊張してきたな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10010007")

	change_face(Actor002,"Smile")

	--★★フレン★★:じつは私もなんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:今日は頑張ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10010009")

	change_face(Actor002,"Smile")

	--★★フレン★★:おーっ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10010010")

	reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ10_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ちょっと待ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_10010012")

	change_face(Actor002,"Normal")

	--★★フレン★★:なにか気になることでもあるの？<br>私はここで待ってるよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_10010013")

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
	InitializeActiveCharacter_Preload("Flen","101039001","101039001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end
