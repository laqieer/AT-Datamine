-- このluaスクリプトは、CO_101034_0301.csv の ADV シートから自動生成されました --
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

	--★★エクセリア★★:あら、ノワール。さっき出動命令が出てね/このあと出かけないとならないの。ごめんなさい
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101034_03010004","CO_101034_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイでも出たのか？/俺も手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03010007")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:そう？/ありがとう、助かるわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03010008")

	reserve_next_script("1章/コミュ/x0401_エクセリア_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか、頑張って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_03010010")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:ありがとう、またあとでね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_03010011")

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
