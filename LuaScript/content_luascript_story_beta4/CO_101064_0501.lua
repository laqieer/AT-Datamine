-- このluaスクリプトは、CO_101064_0501.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Liam","101064001","101064001","content_animationpack_101_101liam","MotionPack_101Liam","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★リアム★★:こんにちは、ノワールさん<br>ハーブの栽培についてお教えしましょうか？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101064_05010004","CO_101064_05010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、お願いしたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05010007")

	change_face(Actor002,"Normal")

	--★★リアム★★:承知しました<br>それではハーブ園に…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05010008")

	change_face(Actor002,"Normal")

	--★★リアム★★:おっと、街の方がいらっしゃったようです<br>少し待っていただけますか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05010009")

	reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ5_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ごめん、今日は忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_05010011")

	change_face(Actor002,"Normal")

	--★★リアム★★:そうですか<br>では、またお時間のあるときにでも
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_05010012")

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
	InitializeActiveCharacter_Preload("Liam","101064001","101064001","content_animationpack_101_101liam","MotionPack_101Liam","Com_Std01_Loop_m")
end
