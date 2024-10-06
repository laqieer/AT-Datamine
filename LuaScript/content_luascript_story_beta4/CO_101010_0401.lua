-- このluaスクリプトは、CO_101010_0401.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")
end

function Play()
	StartPlayActive()

	--★★ランスロット★★:剣術の特別授業を行う<br>お前も出席しろ、ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101010_04010004","CO_101010_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:特別授業？これから？<br>ああ…わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04010007")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:なにかボンヤリしているように見えるな<br>体調不良なら療養院へ行ってこい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、平気だ<br>大丈夫
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04010009")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（補習のおかげでちょっと疲れてるとか<br>カッコ悪くて言いたくないしな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101010_04010010")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:無理はするなよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04010011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:わかってる<br>さっさと行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04010012")

	reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い<br>今日はやめておくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04010014")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうか、残念だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04010015")

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
	InitializeActiveCharacter_Preload("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")
end
