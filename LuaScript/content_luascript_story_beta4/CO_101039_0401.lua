-- このluaスクリプトは、CO_101039_0401.csv の ADV シートから自動生成されました --
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

	--★★フレン★★:あ、ノワールくん<br>時間があるなら話し相手になってくれない？<br>
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101039_04010004","CO_101039_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:もちろん<br>俺でよければ喜んで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04010007")

	change_face(Actor002,"Surprise")

	--★★フレン★★:ふふ、ありがと<br>ノワールくんは優しいね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:どうする、食堂でも行くか？<br>ここじゃ落ち着いて話せないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04010009")

	change_face(Actor002,"Smile")

	--★★フレン★★:えっとね<br>ちょっと行きたいところがあるんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04010011")

	reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今はちょっと忙しくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_04010013")

	change_face(Actor002,"Normal")

	--★★フレン★★:そっか、残念<br>また今度お願いね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_04010014")

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
