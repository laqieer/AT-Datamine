-- このluaスクリプトは、CO_101014_0401.csv の ADV シートから自動生成されました --
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

	--★★トリスタン★★:なに？もう少ししたら出かけるから<br>キミに構ってる暇なんてないんだけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101014_04010004","CO_101014_04010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:出かけるってどこに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04010007")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:ログレス北東の山中にある城下町だよ<br>このあいだ大規模な火災があったらしくてね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:復興支援に行くのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04010009")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:…そうだけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なあ、俺も行っていいか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04010011")

	change_face(Actor002,"Surprise")

	--★★トリスタン★★:はあ？なんでキミが…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04010012")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:嫌だって言っても着いてくる気でしょ？<br>好きにすれば
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04010014")

	reserve_next_script("1章/コミュ/x0401_トリスタン_ランクアップ4_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、ごめん<br>特にこれといった用事があるわけじゃないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04010016")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:そう。じゃあね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04010017")

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
