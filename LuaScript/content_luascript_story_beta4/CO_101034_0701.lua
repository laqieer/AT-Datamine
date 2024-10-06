-- このluaスクリプトは、CO_101034_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Excelia","101034001","101034001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive(true)

	--★★エクセリア★★:この本を読み終えたら/あの森へ行ってこようと思っているの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101034_07010004","CO_101034_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ひとりで行くのか？/それなら俺も行くよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07010007")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:大丈夫よ/心配はいらないわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07010008")


	fadeout(0,0,0,1.0, CHARA_IN_IN)
	wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

--	off_active(Actor002)
	set_pos(Actor002, {-10.07+0, 0-3, 6.98+0})

	fadein(CHARA_IN_OUT)
	wait_time(CHARA_IN_OUT)


	change_face(Actor001,"Normal")

	--★★ノワール★★:…なんか気になるな/様子を見に行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07010010")

	reserve_next_script("1章/コミュ/x0401_エクセリア_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺も一緒に行くよ/少し待っていてくれないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_07010012")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:…わかったわ/ここで待っていることにする
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_07010013")

	system.Cancel()

	goto Block1end

::Block1end::
	EndPlayActive(true)
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
