-- このluaスクリプトは、CO_101037_0301.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Sit01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★ラシア★★:お昼ごはん…うーん…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101037_03010005","CO_101037_03010006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ラシア、こんなところでなにしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03010008")

	change_face(Actor002,"Surprise")

	--★★ラシア★★:あっ、ノワール
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03010009")

	change_face(Actor002,"Surprise")

	--★★ラシア★★:ヴェルナルス様と<br>ランチを食べる約束だったんですけど
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03010010")

	change_face(Actor002,"Surprise")

	--★★ラシア★★:突然ミーティングが入って<br>来られなくなってしまったそうなんです
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03010011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなのか。だったら一緒にどうだ？<br>俺もちょうどこれからランチのつもりだったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03010012")

	change_face(Actor002,"Smile")

	--★★ラシア★★:いいんですか？
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03010013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:騎士たる者、女性にぼっちメシなんて<br>恥はかかせられないからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101037_03010014")

	change_face(Actor002,"Smile")

	--★★ラシア★★:ふふっ、またそれですか？<br>せっかくだし、お言葉に甘えさせてもらいます
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03010016")

	reserve_next_script("1章/コミュ/x0401_ラシア_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ノワール★★:これ、頑張ってひとりで<br>食べるしかないのかな…
	Talk(Actor002,"CHRNAME_RASIA","speech","L","CO_101037_03010018")

	change_face(Actor001,"Normal")

	--★★ラシア★★:（なにか考えごとをしてるみたいだし<br>声はかけずにおこう）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101037_03010019")

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
	InitializeActiveCharacter_Preload("Rasia","101037001","101037001","content_animationpack_101_101rasi","MotionPack_101Rasi","Com_Sit01_Loop_f")
end
