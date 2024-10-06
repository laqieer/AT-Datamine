-- このluaスクリプトは、CO_101010_0201.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")
end

function Play()
	StartPlayActive()

	--★★ランスロット★★:ああ、ノワール<br>どうだ、授業はきちんと受けてるか？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101010_02010004","CO_101010_02010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:受けてるよ、余計なお世話だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02010007")

	change_face(Actor001,"Normal")

	--★★ノワール★★:今日の授業だって<br>ちゃんと聞いてるの見てただろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02010008")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ、頑張ってたな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02010009")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが、俺の授業だけ頑張るのではダメだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02010010")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:他の先生方の授業もしっかり聞いておけ<br>これからの戦いに必要なことばかりだからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02010011")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:それじゃ<br>今日の補習を始めるか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02010012")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:げ…今日もあるのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02010014")

	reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ2_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:あー…悪い、これから用事があるんだ<br>話はまた今後にしてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_02010016")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前が忙しいのは理解しているつもりだが<br>予習・復習は怠るなよ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_02010017")

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
	InitializeActiveCharacter_Preload("Lancelot","101010001","101010001","content_animationpack_101_101lanc","MotionPack_101Lanc","Lancelot_EntakuSit_loop")
end
