-- このluaスクリプトは、CO_101034_0801.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Excelia","101034001","101034001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★エクセリア★★:ここのところバルバロイの目撃情報はないけど/あの村のことが気になっているの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101034_08010004","CO_101034_08010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:それなら村まで調査に行こうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08010007")

	change_face(Actor002,"Smile")

	--★★エクセリア★★:…ありがとう/そう言ってくれると思っていたわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08010008")

	reserve_next_script("1章/コミュ/x0401_エクセリア_ランクアップ8_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:別の用事があって今は難しいけど/それが片付いたら一緒に行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_08010010")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:わかったわ/準備ができたら声をかけて
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_08010011")

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
	InitializeActiveCharacter_Preload("Excelia","101034001","101034001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end
