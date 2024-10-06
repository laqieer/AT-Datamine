-- このluaスクリプトは、CO_101039_0301.csv の ADV シートから自動生成されました --
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

	change_face(Actor002,"Smile")

	--★★フレン★★:ノワールくん、陸上部で対抗戦をするんだけど<br>人数が足りないんだ。助っ人に来てくれない？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101039_03010004","CO_101039_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、今ならいいよ<br>期待に沿えるかはわからないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03010007")

	change_face(Actor002,"Smile")

	--★★フレン★★:ノワールくんなら大丈夫！<br>本当にありがとう！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03010008")

	reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:今はちょっと無理だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03010010")

	change_face(Actor002,"Sad")

	--★★フレン★★:そっかぁ<br>残念…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03010011")

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
