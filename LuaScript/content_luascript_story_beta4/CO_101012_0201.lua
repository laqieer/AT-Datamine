-- このluaスクリプトは、CO_101012_0201.csv の ADV シートから自動生成されました --
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

	--★★ディナタン★★:兄さん、今いい？<br>ちょっと相談したいことがあるんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101012_02010004","CO_101012_02010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、いいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02010007")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:ありがとう！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02010008")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:えっと…<br>ここじゃなんだから、場所を変えていい？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02010009")

	reserve_next_script("1章/コミュ/x0401_ディナタン_ランクアップ2_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101012_02010011")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:そっか、わかった<br>また今度、話を聞いてくれる？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","CO_101012_02010012")

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
