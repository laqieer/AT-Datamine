-- このluaスクリプトは、CO_101012_0501.csv の ADV シートから自動生成されました --
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

	--★★ディナタン★★:はぁ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101012_05010004","CO_101012_05010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05010007")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:………あ、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:どうしたんだ、ぼーっとして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05010009")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:うん…ちょっと色々考えちゃって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05010010")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:…ねぇ、兄さん<br>ちょっと付き合ってくれる？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05010011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:付き合えって、どこへ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_05010012")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:私たちが飛ばされた場所<br>………妖精の森に
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05010013")

	reserve_next_script("1章/コミュ/x0401_ディナタン_ランクアップ5_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:（今はそっとしておくか）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101012_05010015")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:………はぁ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_05010016")

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
