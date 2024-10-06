-- このluaスクリプトは、CO_101014_1001.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Sit_hurp_loop_Chr_004_01")
end

function Play()
	StartPlayActive()

	--★★トリスタン★★:ああ、ちょうど良かった<br>待ってたんだ、キミを
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101014_10010004","CO_101014_10010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺を待ってた？<br>もしかしてまたあの町になにかあったのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10010007")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:そうじゃないよ<br>まあ、あの町絡みではあるけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10010008")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:慰労の催しをするんだ<br>といってもボクが竪琴を奏でるだけだけどね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10010009")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:復興支援に訪れた場所では必ず<br>最後にやることにしているんだよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それ、いいな！<br>俺も行っていいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10010011")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:いいから誘ったに決まってるでしょ？<br>早く行こう
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10010012")

	reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ10_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪い、今は忙しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_10010014")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:そう<br>またあとで来てくれたら嬉しい
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_10010016")

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
	InitializeActiveCharacter_Preload("Tristan","101014001","101014001","content_animationpack_101_101tris","MotionPack_101Tris","Sit_hurp_loop_Chr_004_01")
end
