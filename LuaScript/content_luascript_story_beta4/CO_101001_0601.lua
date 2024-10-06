-- このluaスクリプトは、CO_101001_0601.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Tyrfing","101001001","101001001","content_animationpack_101_101tyrf","MotionPack_101Tyrf","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★ティルフィング★★:マスター<br>本日はどこかに行かれますか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101001_06010004","CO_101001_06010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:大図書院に行こうと思ってるんだ<br>ティルフィングも一緒にどうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06010007")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:はい、ぜひ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06010008")

	reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ6_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ごめん、今日はちょっと用事があってさ<br>悪いけど、また今後でいいかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06010010")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…そうですか<br>ではまた、ご都合のよろしいときにお願いします
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06010012")

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
	InitializeActiveCharacter_Preload("Tyrfing","101001001","101001001","content_animationpack_101_101tyrf","MotionPack_101Tyrf","Com_Std01_Loop_f")
end
