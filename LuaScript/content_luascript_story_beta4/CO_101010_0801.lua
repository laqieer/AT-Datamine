-- このluaスクリプトは、CO_101010_0801.csv の ADV シートから自動生成されました --
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

	--★★ランスロット★★:ノワール、時間があるなら<br>今日も師匠の思い出巡りに行こう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101010_08010004","CO_101010_08010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ。行こう<br>そのつもりで来たんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08010007")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ランスロットとの二人旅も楽しくなってきたしな<br>今日はどこに行こうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08010008")

	change_face(Actor002,"Smile")

	--★★ランスロット★★:行ってからのお楽しみ、としておこう
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08010009")

	reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ8_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今はちょっと忙しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_08010011")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうか<br>では、また都合のいいときに声をかけてくれ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_08010012")

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
