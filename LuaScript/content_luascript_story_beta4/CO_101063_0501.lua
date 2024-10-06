-- このluaスクリプトは、CO_101063_0501.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end

function Play()
	StartPlayActive()

	--★★クリスティーナ★★:あら、ノワールちゃん/ごめんなさ～い、ちょうど席を外すところなの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101063_05010004","CO_101063_05010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか用事があるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05010007")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:こないだの子がまた本を滞納しててね/ちょっと催促をしに行こうと思っているの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あいつ、釘を刺しといたのに/また滞納してるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05010009")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺が代わりに行ってこようか？/クリスさんは司書の仕事もあるだろうし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（クリスさんが相手だと/あいつ逃げ出しちゃうかもしれないしな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101063_05010011")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:そうね、お願いできるかしら？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05010012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05010013")

	reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ5_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、こっちはたいした用事じゃないから/またあとで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_05010015")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ごめんなさいね～
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_05010016")

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
	InitializeActiveCharacter_Preload("Christina","101063001","101063001","content_animationpack_101_101chri","MotionPack_101Chri","An_Hom_101063001_Std02_Loop")
end
