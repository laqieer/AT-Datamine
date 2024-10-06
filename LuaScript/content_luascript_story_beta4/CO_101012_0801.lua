-- このluaスクリプトは、CO_101012_0801.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:あ、兄さん！オリジナルの歌のことで<br>また相談に乗ってほしいんだけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101012_08010004","CO_101012_08010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、もちろんいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08010007")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:よかった！<br>また行き詰まっちゃって、困ってたんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08010008")

	reserve_next_script("1章/コミュ/x0401_ディナタン_ランクアップ8_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今はちょっと忙しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_08010010")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:そっか、わかった<br>また今度、話を聞いてくれる？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_08010011")

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
	InitializeActiveCharacter_Preload("Dinatan","101012001","101012001","content_animationpack_101_101dina","MotionPack_101Dina","Com_Std01_Loop_f")
end
