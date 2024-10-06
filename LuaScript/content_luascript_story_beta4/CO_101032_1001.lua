-- このluaスクリプトは、CO_101032_1001.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gareth","101032001","101032001","content_animationpack_101_101gare","MotionPack_101Gare","Com_Sit01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★ガレス★★:ノワール。兄さんのためのメニューの/試食をしてほしいんだ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101032_10010004","CO_101032_10010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:試食？/俺が食べていいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10010007")

	change_face(Actor002,"Normal")

	--★★ガレス★★:ノワールに食べてほしいんだ/そして感想を聞かせてくれ
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10010008")

	change_face(Actor001,"Serious")

	--★★ノワール★★:わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10010009")

	reserve_next_script("1章/コミュ/x0401_ガレス_ランクアップ10_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:今はちょっと忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101032_10010011")

	change_face(Actor002,"Normal")

	--★★ガレス★★:わかった！/ならまた今度付き合ってくれ！
	Talk(Actor002,"CHRNAME_GARETH","speech","L","CO_101032_10010012")

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
end
