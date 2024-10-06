-- このluaスクリプトは、CO_101022_0201.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★モルドレッド★★:行くぞ、継承者
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101022_02010004","CO_101022_02010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいけど/どこへ行くんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02010007")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:はあ？察しの悪いヤツだな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02010008")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:『気まぐれな道化師』の/集合場所に決まってんだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02010010")

	change_face(Actor001,"Sad")

	--★★ノワール★★:最初からそう言ってくれよ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02010012")

	reserve_next_script("1章/コミュ/x0401_モルドレッド_ランクアップ2_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ごめん、今はちょっと忙しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_02010014")

	change_face(Actor002,"Normal")

	--★★モルドレッド★★:おいおい！やるっつった自分の言葉には/責任を持てよ、継承者
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_02010015")

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
	InitializeActiveCharacter_Preload("Mordred","101022001","101022001","content_animationpack_101_101mord","MotionPack_101Mord","Com_Std01_Loop_m")
end
