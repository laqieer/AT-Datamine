-- このluaスクリプトは、CO_101062_0401.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Maril","101062001","101062001","content_animationpack_101_101mari","MotionPack_101Mari","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★マルイル★★:あ、ノワールさん！新商品、入荷してますよ～<br>ちょっと見ていきませんか？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101062_04010004","CO_101062_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうしようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04010007")

	change_face(Actor002,"Smile")

	--★★マルイル★★:どうぞどうぞ！<br>今回の仕入れも、自信アリです！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04010008")

	reserve_next_script("1章/コミュ/x0401_マルイル_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、ちょっと忙しくてさ<br>また今度でいいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_04010010")

	change_face(Actor002,"Normal")

	--★★マルイル★★:わかりました。お時間あるときに、ぜひ！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_04010011")

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
	InitializeActiveCharacter_Preload("Maril","101062001","101062001","content_animationpack_101_101mari","MotionPack_101Mari","Com_Std01_Loop_m")
end
