-- このluaスクリプトは、CO_101001_0301.csv の ADV シートから自動生成されました --
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

	--★★ティルフィング★★:マスター<br>なにか私に用事でしょうか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101001_03010004","CO_101001_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:この前話したことなんだけど<br>今からどうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03010007")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:構いません<br>マスターがお望みであれば
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:よかった<br>それじゃあ、さっそく行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03010009")

	reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや…<br>ごめん、なんでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03010011")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:そうですか<br>では、失礼します
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03010012")

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
