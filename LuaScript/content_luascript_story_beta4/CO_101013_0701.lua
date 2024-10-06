-- このluaスクリプトは、CO_101013_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★ガウェイン★★:なあ、ノワール<br>ちょっと付き合ってほしいところがあるんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101013_07010004","CO_101013_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:別に構わないよ<br>トムに説明しに行くんだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07010007")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ああ<br>話が早くて助かる
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07010008")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:どんな顔して説明したらいいかわかんなくてよ<br>一緒についてきてほしいんだ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07010009")

	reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:これから用事があってさ<br>今はムリなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_07010011")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:そっか…<br>じゃ、また今度付き合ってくれよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_07010012")

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
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end
