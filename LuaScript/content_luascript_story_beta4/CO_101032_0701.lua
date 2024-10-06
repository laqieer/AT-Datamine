-- このluaスクリプトは、CO_101032_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Sit01_Loop_f")
--	Actor003 = InitializeActiveCharacter("Lioness","101033001","101033001","content_animationpack_101_101lyon","MotionPack_101Lyon","Com_Sit01_Loop_f")
	Actor003 = InitializeCharacter_2DOnly("101033","001","101033001")
end

function Play()
	StartPlayActive()

	--★★ガレス★★:ノワール/大図書院に行かないか？
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101032_07010004","CO_101032_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	--★★ノワール★★:わかった/ナイトカジキについて調べるんだな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07010007")


	--★★ガレス★★:うん。わたしもリオネスも/大図書院にあまり行ったことがないんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07010008")


	--★★リオネス★★:ずいぶん前、あそこで肉を食べてたら/クリスにすっごい怒られてな
	Talk(Actor003,"CHRNAME_LYONESS","speech","L","CO_101032_07010009")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:クリスさんじゃなくても怒ると思うぞ、それは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07010010")

	change_face(Actor002,"Smile")

	--★★ガレス★★:というわけなんで/一緒に着いてきてほしい♪
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07010011")

	reserve_next_script("1章/コミュ/x0401_ガレス_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:今はちょっと忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_07010013")

	change_face(Actor002,"Normal")

	--★★ガレス★★:わかった！/ならまた今度付き合ってくれ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_07010014")

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
	InitializeActiveCharacter_Preload("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Sit01_Loop_f")
	InitializeCharacter_2DOnly_Preload("101033","001","101033001")
end
