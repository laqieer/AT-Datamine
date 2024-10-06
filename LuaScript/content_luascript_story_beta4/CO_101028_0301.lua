-- このluaスクリプトは、CO_101028_0301.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
--	Actor003 = InitializeActiveCharacter("Viena","101036001","101036001","content_animationpack_101_101vien","MotionPack_101Vien","Com_Std01_Loop_f")
	Actor003 = InitializeCharacter_2DOnly("101036","001","101036001")
end

function Play()
	StartPlayActive()

	--★★ガラハッド★★:ノワール/今、手は空いているだろうか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101028_03010004","CO_101028_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、大丈夫だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03010007")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:であれば、その…/例のレッスンに付き合ってほしい
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03010008")

	change_face(Actor003,"Smile")

	--★★フィエナ★★:フューチャープリンセス・プロジェクトね！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_03010009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:はいはい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03010010")

	reserve_next_script("1章/コミュ/x0401_ガラハッド_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:えっと、今は時間がなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_03010012")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そうか/呼び止めて悪かった
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_03010013")

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
	InitializeActiveCharacter_Preload("Galahad","101028001","101028001","content_animationpack_101_101gala","MotionPack_101Gala","Com_Std01_Loop_f")
	InitializeCharacter_2DOnly_Preload("101036","001","101036001")
end
