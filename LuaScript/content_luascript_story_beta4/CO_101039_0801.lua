-- このluaスクリプトは、CO_101039_0801.csv の ADV シートから自動生成されました --
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

	--★★フレン★★:ローラがまたローマに行くそうなんだ<br>練習の前にお見送りに行ってくるね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101039_08010004","CO_101039_08010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:今、ちょうど時間あるし<br>俺も付き合おうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08010007")

	change_face(Actor002,"Smile")

	--★★フレン★★:ありがとう！<br>ローラも喜ぶよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08010008")

	--★★フレン★★:じゃあ、さっそく出かけようー！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08010009")

	reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ8_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も行きたいな。少し待ってもらえるか？<br>用事を片付けてしまいたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_08010011")

	change_face(Actor002,"Surprise")

	--★★フレン★★:わかった<br>じゃあ、ここで待ってるね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_08010012")

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
